using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace DelaySend
{
    public partial class ThisAddIn
    {

        const long DELIVERYTIME_NULL = 1420062624000000000;

        //TODO: Send Immediately Button in Mail Form
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.ItemSend += Application_ItemSend;
            
        }

        private void Application_ItemSend(object Item, ref bool Cancel)
        {
            if (Item is Outlook.MailItem mailItem)
            {
                if (mailItem.DeferredDeliveryTime.Ticks == DELIVERYTIME_NULL)
                {
                    DateTime currentDate = DateTime.Now;
                    DayOfWeek dayOfWeek = currentDate.DayOfWeek;

                    string dayOfWeekName = dayOfWeek.ToString();
                    TimeSpan startTime = (TimeSpan)Properties.Settings.Default[dayOfWeekName + "_Start"];
                    TimeSpan stopTime = (TimeSpan)Properties.Settings.Default[dayOfWeekName + "_End"];

                    Boolean activeToday = true;
                    if (startTime == stopTime) activeToday = false;

                    //If not active today and if outside of start and stop time.
                    if (!activeToday || (currentDate.TimeOfDay < startTime || currentDate.TimeOfDay > stopTime))
                    {
                        if (activeToday && currentDate.TimeOfDay < startTime)
                        {
                            //Before Start Time
                            mailItem.DeferredDeliveryTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, startTime.Hours, startTime.Minutes, startTime.Seconds);
                        }
                        else
                        {
                            //After Stop Time or not delivering today
                            //find the next active time
                            mailItem.DeferredDeliveryTime = FindNextActiveTime();
                        }
                    }
                }
            }

        }

        private DateTime FindNextActiveTime()
        {
            DateTime currentDate = DateTime.Now;

            do
            {
                currentDate = currentDate.AddDays(1); //Add another day onto the current date time.

                DayOfWeek dayOfWeek = currentDate.DayOfWeek;
                string dayOfWeekName = dayOfWeek.ToString();
                TimeSpan startTime = (TimeSpan)Properties.Settings.Default[dayOfWeekName + "_Start"];
                TimeSpan stopTime = (TimeSpan)Properties.Settings.Default[dayOfWeekName + "_End"];
                if (startTime != stopTime) //Active today
                    return new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, startTime.Hours, startTime.Minutes, startTime.Seconds);
            } while (true);
                
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
