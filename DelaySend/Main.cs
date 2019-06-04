using Microsoft.Office.Tools.Ribbon;

namespace DelaySend
{
    public partial class Main
    {

        private void DSOptions_Click(object sender, RibbonControlEventArgs e)
        {
            using (DelaySendOptions options = new DelaySendOptions())
            {
                options.ShowDialog();
            }
        }

        private void DSEnableSchedule_Click(object sender, RibbonControlEventArgs e)
        {
            Properties.Settings.Default.EnableSchedule = DSEnableSchedule.Checked;
            Properties.Settings.Default.Save();
        }

        private void GroupProperties_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            using (AboutDelaySend about = new AboutDelaySend())
            {
                about.ShowDialog();
            }
        }
    }
}
