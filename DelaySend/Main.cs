using Microsoft.Office.Tools.Ribbon;

namespace DelaySend
{
    public partial class Main
    {

        private void DSOptions_Click(object sender, RibbonControlEventArgs e)
        {
            DelaySendOptions options = new DelaySendOptions();
            options.ShowDialog();
        }
    }
}
