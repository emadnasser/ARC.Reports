namespace DevExpress.XtraTreeMap.Demos {
    partial class Colorizer {
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
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colorizer));
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGroupGradient = new DevExpress.XtraBars.BarCheckItem();
            this.btnPalette = new DevExpress.XtraBars.BarCheckItem();
            this.btnRange = new DevExpress.XtraBars.BarCheckItem();
            this.btnGradient = new DevExpress.XtraBars.BarCheckItem();
            this.btnEnableGrouping = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.treeMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            treeMapFlatDataAdapter1.DataMember = null;
            treeMapFlatDataAdapter1.LabelDataMember = "CompanyName";
            treeMapFlatDataAdapter1.ValueDataMember = "Assets";
            this.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(12, 35);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Size = new System.Drawing.Size(476, 312);
            this.treeMapControl1.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnGroupGradient,
            this.btnPalette,
            this.btnRange,
            this.btnGradient,
            this.btnEnableGrouping});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(500, 141);
            // 
            // btnGroupGradient
            // 
            this.btnGroupGradient.Caption = "Group Gradient Colorizer";
            this.btnGroupGradient.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGroupGradient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGroupGradient.Glyph")));
            this.btnGroupGradient.GroupIndex = 1;
            this.btnGroupGradient.Id = 3;
            this.btnGroupGradient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGroupGradient.LargeGlyph")));
            this.btnGroupGradient.Name = "btnGroupGradient";
            this.btnGroupGradient.Tag = 3;
            this.btnGroupGradient.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnColorizerChanged);
            // 
            // btnPalette
            // 
            this.btnPalette.BindableChecked = true;
            this.btnPalette.Caption = "Palette Colorizer";
            this.btnPalette.Checked = true;
            this.btnPalette.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnPalette.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPalette.Glyph")));
            this.btnPalette.GroupIndex = 1;
            this.btnPalette.Id = 5;
            this.btnPalette.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPalette.LargeGlyph")));
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Tag = 0;
            this.btnPalette.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnColorizerChanged);
            // 
            // btnRange
            // 
            this.btnRange.Caption = "Range Colorizer";
            this.btnRange.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnRange.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRange.Glyph")));
            this.btnRange.GroupIndex = 1;
            this.btnRange.Id = 6;
            this.btnRange.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRange.LargeGlyph")));
            this.btnRange.Name = "btnRange";
            this.btnRange.Tag = 1;
            this.btnRange.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnColorizerChanged);
            // 
            // btnGradient
            // 
            this.btnGradient.Caption = "Gradient Colorizer";
            this.btnGradient.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.btnGradient.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGradient.Glyph")));
            this.btnGradient.GroupIndex = 1;
            this.btnGradient.Id = 7;
            this.btnGradient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGradient.LargeGlyph")));
            this.btnGradient.Name = "btnGradient";
            this.btnGradient.Tag = 2;
            this.btnGradient.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnColorizerChanged);
            // 
            // btnEnableGrouping
            // 
            this.btnEnableGrouping.BindableChecked = true;
            this.btnEnableGrouping.Caption = "Enable Grouping";
            this.btnEnableGrouping.Checked = true;
            this.btnEnableGrouping.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEnableGrouping.Glyph")));
            this.btnEnableGrouping.Id = 8;
            this.btnEnableGrouping.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEnableGrouping.LargeGlyph")));
            this.btnEnableGrouping.Name = "btnEnableGrouping";
            this.btnEnableGrouping.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnEnableGroupingCheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Options";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPalette);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRange);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGradient);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupGradient);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Colorizer";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEnableGrouping);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
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
            this.labelControl1.Location = new System.Drawing.Point(150, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 19);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "US Largest Companies 2011";
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
            // Colorizer
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MenuManager = this.ribbonControl1;
            this.Name = "Colorizer";
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
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarCheckItem btnGroupGradient;
        private XtraBars.BarCheckItem btnPalette;
        private XtraBars.BarCheckItem btnRange;
        private XtraBars.BarCheckItem btnGradient;
        private XtraBars.BarCheckItem btnEnableGrouping;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
