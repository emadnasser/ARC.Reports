namespace DevExpress.XtraTreeMap.Demos {
    partial class Grouping {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grouping));
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnWithoutGrouping = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByResidence = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByAge = new DevExpress.XtraBars.BarCheckItem();
            this.btnGroupByResidenceAndAge = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            treeMapFlatDataAdapter1.DataMember = null;
            treeMapFlatDataAdapter1.LabelDataMember = "Name";
            treeMapFlatDataAdapter1.ValueDataMember = "NetWorth";
            this.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(12, 35);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Size = new System.Drawing.Size(476, 312);
            this.treeMapControl1.TabIndex = 0;
            this.treeMapControl1.ToolTipController = this.toolTipController1;
            this.treeMapControl1.ToolTipGroupPattern = "{L}: {V}B$";
            this.treeMapControl1.ToolTipLeafPattern = "{L}: {V}B$";
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Options.UseTextOptions = true;
            this.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnWithoutGrouping,
            this.btnGroupByResidence,
            this.btnGroupByAge,
            this.btnGroupByResidenceAndAge});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(500, 141);
            // 
            // btnWithoutGrouping
            // 
            this.btnWithoutGrouping.Caption = "Without Grouping";
            this.btnWithoutGrouping.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnWithoutGrouping.GroupIndex = 1;
            this.btnWithoutGrouping.Id = 3;
            this.btnWithoutGrouping.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWithoutGrouping.ImageOptions.Image")));
            this.btnWithoutGrouping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWithoutGrouping.ImageOptions.LargeImage")));
            this.btnWithoutGrouping.Name = "btnWithoutGrouping";
            this.btnWithoutGrouping.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupingItemClick);
            // 
            // btnGroupByResidence
            // 
            this.btnGroupByResidence.BindableChecked = true;
            this.btnGroupByResidence.Caption = "Group By Residence";
            this.btnGroupByResidence.Checked = true;
            this.btnGroupByResidence.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByResidence.GroupIndex = 1;
            this.btnGroupByResidence.Id = 5;
            this.btnGroupByResidence.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupByResidence.ImageOptions.Image")));
            this.btnGroupByResidence.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGroupByResidence.ImageOptions.LargeImage")));
            this.btnGroupByResidence.Name = "btnGroupByResidence";
            this.btnGroupByResidence.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupingItemClick);
            // 
            // btnGroupByAge
            // 
            this.btnGroupByAge.Caption = "Group By Age Category";
            this.btnGroupByAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByAge.GroupIndex = 1;
            this.btnGroupByAge.Id = 6;
            this.btnGroupByAge.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupByAge.ImageOptions.Image")));
            this.btnGroupByAge.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGroupByAge.ImageOptions.LargeImage")));
            this.btnGroupByAge.Name = "btnGroupByAge";
            this.btnGroupByAge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupingItemClick);
            // 
            // btnGroupByResidenceAndAge
            // 
            this.btnGroupByResidenceAndAge.Caption = "Group By Residence And Age Category";
            this.btnGroupByResidenceAndAge.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupByResidenceAndAge.GroupIndex = 1;
            this.btnGroupByResidenceAndAge.Id = 7;
            this.btnGroupByResidenceAndAge.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupByResidenceAndAge.ImageOptions.Image")));
            this.btnGroupByResidenceAndAge.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGroupByResidenceAndAge.ImageOptions.LargeImage")));
            this.btnGroupByResidenceAndAge.Name = "btnGroupByResidenceAndAge";
            this.btnGroupByResidenceAndAge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGroupingItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Options";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupByResidence);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupByAge);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupByResidenceAndAge);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnWithoutGrouping);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Group Definitions";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.treeMapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 141);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(500, 359);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(137, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 19);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Forbes World\'s Billionaires 2010";
            this.labelControl1.UseMnemonic = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(500, 359);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(480, 316);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControl1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(480, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Grouping
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MenuManager = this.ribbonControl1;
            this.Name = "Grouping";
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private TreeMapControl treeMapControl1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.BarCheckItem btnWithoutGrouping;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarCheckItem btnGroupByResidence;
        private XtraBars.BarCheckItem btnGroupByAge;
        private XtraBars.BarCheckItem btnGroupByResidenceAndAge;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
