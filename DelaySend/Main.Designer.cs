namespace DelaySend
{
    partial class Main : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Main()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.GroupProperties = this.Factory.CreateRibbonGroup();
            this.DSOptions = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.GroupProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabSendReceive";
            this.tab1.Groups.Add(this.GroupProperties);
            this.tab1.Label = "TabSendReceive";
            this.tab1.Name = "tab1";
            // 
            // GroupProperties
            // 
            this.GroupProperties.Items.Add(this.DSOptions);
            this.GroupProperties.Label = "Delay Send";
            this.GroupProperties.Name = "GroupProperties";
            this.GroupProperties.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupProperties");
            // 
            // DSOptions
            // 
            this.DSOptions.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DSOptions.Label = "Options";
            this.DSOptions.Name = "DSOptions";
            this.DSOptions.OfficeImageId = "DelayDeliveryOutlook";
            this.DSOptions.ShowImage = true;
            this.DSOptions.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DSOptions_Click);
            // 
            // Main
            // 
            this.Name = "Main";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.GroupProperties.ResumeLayout(false);
            this.GroupProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupProperties;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DSOptions;
    }

    partial class ThisRibbonCollection
    {
        internal Main Main
        {
            get { return this.GetRibbon<Main>(); }
        }
    }
}
