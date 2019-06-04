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

            DSEnableSchedule.Checked = Properties.Settings.Default.EnableSchedule;

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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.GroupProperties = this.Factory.CreateRibbonGroup();
            this.DSOptions = this.Factory.CreateRibbonButton();
            this.DSEnableSchedule = this.Factory.CreateRibbonCheckBox();
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
            this.GroupProperties.DialogLauncher = ribbonDialogLauncherImpl1;
            this.GroupProperties.Items.Add(this.DSOptions);
            this.GroupProperties.Items.Add(this.DSEnableSchedule);
            this.GroupProperties.Label = "Delay Send";
            this.GroupProperties.Name = "GroupProperties";
            this.GroupProperties.Position = this.Factory.RibbonPosition.AfterOfficeId("GroupProperties");
            this.GroupProperties.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GroupProperties_DialogLauncherClick);
            // 
            // DSOptions
            // 
            this.DSOptions.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.DSOptions.Label = "Options";
            this.DSOptions.Name = "DSOptions";
            this.DSOptions.OfficeImageId = "AnimationDelay";
            this.DSOptions.ShowImage = true;
            this.DSOptions.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DSOptions_Click);
            // 
            // DSEnableSchedule
            // 
            this.DSEnableSchedule.Label = "Enable";
            this.DSEnableSchedule.Name = "DSEnableSchedule";
            this.DSEnableSchedule.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DSEnableSchedule_Click);
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
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox DSEnableSchedule;
    }

    partial class ThisRibbonCollection
    {
        internal Main Main
        {
            get { return this.GetRibbon<Main>(); }
        }
    }
}
