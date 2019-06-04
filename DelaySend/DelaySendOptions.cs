using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelaySend
{
    public partial class DelaySendOptions : Form
    {
        public DelaySendOptions()
        {
            InitializeComponent();

            LoadSchedule();

            EnableSchedule.Checked = Properties.Settings.Default.EnableSchedule;
        }

        private void LoadSchedule()
        {
            DateTime nullDate = DateTime.Today;

            Start_Monday.Value = nullDate + Properties.Settings.Default.Monday_Start;
            End_Monday.Value = nullDate + Properties.Settings.Default.Monday_End;

            Start_Tuesday.Value = nullDate + Properties.Settings.Default.Tuesday_Start;
            End_Tuesday.Value = nullDate + Properties.Settings.Default.Tuesday_End;

            Start_Wednesday.Value = nullDate + Properties.Settings.Default.Wednesday_Start;
            End_Wednesday.Value = nullDate + Properties.Settings.Default.Wednesday_End;

            Start_Thursday.Value = nullDate + Properties.Settings.Default.Thursday_Start;
            End_Thursday.Value = nullDate + Properties.Settings.Default.Thursday_End;

            Start_Friday.Value = nullDate + Properties.Settings.Default.Friday_Start;
            End_Friday.Value = nullDate + Properties.Settings.Default.Friday_End;

            Start_Saturday.Value = nullDate + Properties.Settings.Default.Saturday_Start;
            End_Saturday.Value = nullDate + Properties.Settings.Default.Saturday_End;

            Start_Sunday.Value = nullDate + Properties.Settings.Default.Sunday_Start;
            End_Sunday.Value = nullDate + Properties.Settings.Default.Sunday_End;
        }

        private void SaveSchedule()
        {
            Properties.Settings.Default.Monday_Start = Start_Monday.Value.TimeOfDay;
            Properties.Settings.Default.Monday_End = End_Monday.Value.TimeOfDay;

            Properties.Settings.Default.Tuesday_Start = Start_Tuesday.Value.TimeOfDay;
            Properties.Settings.Default.Tuesday_End = End_Tuesday.Value.TimeOfDay;

            Properties.Settings.Default.Wednesday_Start = Start_Wednesday.Value.TimeOfDay;
            Properties.Settings.Default.Wednesday_End = End_Wednesday.Value.TimeOfDay;

            Properties.Settings.Default.Thursday_Start = Start_Thursday.Value.TimeOfDay;
            Properties.Settings.Default.Thursday_End = End_Thursday.Value.TimeOfDay;

            Properties.Settings.Default.Friday_Start = Start_Friday.Value.TimeOfDay;
            Properties.Settings.Default.Friday_End = End_Friday.Value.TimeOfDay;

            Properties.Settings.Default.Saturday_Start = Start_Saturday.Value.TimeOfDay;
            Properties.Settings.Default.Saturday_End = End_Saturday.Value.TimeOfDay;

            Properties.Settings.Default.Sunday_Start = Start_Sunday.Value.TimeOfDay;
            Properties.Settings.Default.Sunday_End = End_Sunday.Value.TimeOfDay;

        }

        private void CancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSchedule();
            Properties.Settings.Default.EnableSchedule = EnableSchedule.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            using (AboutDelaySend about = new AboutDelaySend())
            {
                about.ShowDialog();
            }
        }
    }
}
