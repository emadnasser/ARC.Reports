namespace DevExpress.XtraTreeList.Demos {
    partial class TreeListStyles {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeListStyles));
            this.lsStyles = new DevExpress.XtraEditors.ListBoxControl();
            this.btnAlphaBlending = new DevExpress.XtraEditors.SimpleButton();
            this.chbAlphaBlending = new DevExpress.XtraEditors.CheckEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTreeListBlending1 = new DevExpress.XtraTreeList.Blending.XtraTreeListBlending();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ceNewStyles = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitter2 = new DevExpress.XtraEditors.SplitterControl();
            this.lbcAppearances = new DevExpress.XtraEditors.ListBoxControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAlphaBlending.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceNewStyles.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsStyles
            // 
            this.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsStyles.ItemHeight = 16;
            this.lsStyles.Location = new System.Drawing.Point(2, 54);
            this.lsStyles.Name = "lsStyles";
            this.lsStyles.Size = new System.Drawing.Size(163, 329);
            this.lsStyles.TabIndex = 0;
            this.lsStyles.SelectedIndexChanged += new System.EventHandler(this.lsStyles_SelectedIndexChanged);
            // 
            // btnAlphaBlending
            // 
            this.btnAlphaBlending.Enabled = false;
            this.btnAlphaBlending.Location = new System.Drawing.Point(124, 4);
            this.btnAlphaBlending.Name = "btnAlphaBlending";
            this.btnAlphaBlending.Size = new System.Drawing.Size(28, 20);
            this.btnAlphaBlending.TabIndex = 24;
            this.btnAlphaBlending.Text = "...";
            this.btnAlphaBlending.Click += new System.EventHandler(this.btnAlphaBlending_Click);
            // 
            // chbAlphaBlending
            // 
            this.chbAlphaBlending.Location = new System.Drawing.Point(4, 4);
            this.chbAlphaBlending.Name = "chbAlphaBlending";
            this.chbAlphaBlending.Properties.Caption = "Alpha Blending";
            this.chbAlphaBlending.Size = new System.Drawing.Size(108, 19);
            this.chbAlphaBlending.TabIndex = 23;
            this.chbAlphaBlending.CheckedChanged += new System.EventHandler(this.chbAlphaBlending_CheckedChanged);
            // 
            // treeList1
            // 
            this.treeList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeList1.BackgroundImage")));
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(182, 0);
            this.treeList1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.FocusRectStyle = DrawFocusRectStyle.None;
            this.treeList1.SelectImageList = this.imageList1;
            this.treeList1.Size = new System.Drawing.Size(668, 416);
            this.treeList1.TabIndex = 1;
            this.treeList1.ShowCustomizationForm += new System.EventHandler(this.treeList1_ShowCustomizationForm);
            this.treeList1.HideCustomizationForm += new System.EventHandler(this.treeList1_HideCustomizationForm);
            this.treeList1.GetSelectImage += new DevExpress.XtraTreeList.GetSelectImageEventHandler(this.treeList1_GetSelectImage);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(176, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 416);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            this.imageList2.Images.SetKeyName(16, "");
            this.imageList2.Images.SetKeyName(17, "");
            // 
            // xtraTreeListBlending1
            // 
            this.xtraTreeListBlending1.Enabled = false;
            this.xtraTreeListBlending1.TreeListControl = this.treeList1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(176, 416);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Text = "xtraTabControl1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lsStyles);
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Size = new System.Drawing.Size(167, 385);
            this.xtraTabPage1.Text = "Formats";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ceNewStyles);
            this.panel1.Controls.Add(this.chbAlphaBlending);
            this.panel1.Controls.Add(this.btnAlphaBlending);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 52);
            this.panel1.TabIndex = 25;
            // 
            // ceNewStyles
            // 
            this.ceNewStyles.Location = new System.Drawing.Point(4, 28);
            this.ceNewStyles.Name = "ceNewStyles";
            this.ceNewStyles.Properties.Caption = "Only New Styles";
            this.ceNewStyles.Size = new System.Drawing.Size(186, 19);
            this.ceNewStyles.TabIndex = 25;
            this.ceNewStyles.CheckedChanged += new System.EventHandler(this.ceNewStyles_CheckedChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.propertyGrid1);
            this.xtraTabPage2.Controls.Add(this.splitter2);
            this.xtraTabPage2.Controls.Add(this.lbcAppearances);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Size = new System.Drawing.Size(167, 336);
            this.xtraTabPage2.Text = "Appearances";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.Gray;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(2, 184);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(163, 150);
            this.propertyGrid1.TabIndex = 25;
            this.propertyGrid1.ToolbarVisible = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(2, 178);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(163, 6);
            this.splitter2.TabIndex = 26;
            this.splitter2.TabStop = false;
            // 
            // lbcAppearances
            // 
            this.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbcAppearances.ItemHeight = 16;
            this.lbcAppearances.Location = new System.Drawing.Point(2, 2);
            this.lbcAppearances.Name = "lbcAppearances";
            this.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbcAppearances.Size = new System.Drawing.Size(163, 176);
            this.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lbcAppearances.TabIndex = 24;
            this.lbcAppearances.SelectedIndexChanged += new System.EventHandler(this.lbcAppearances_SelectedIndexChanged);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // TreeListStyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TreeListStyles";
            this.Size = new System.Drawing.Size(850, 416);
            this.Load += new System.EventHandler(this.TreeListStyles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lsStyles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbAlphaBlending.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceNewStyles.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.Design.XAppearances xapp;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.ListBoxControl lsStyles;
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraTreeList.Blending.XtraTreeListBlending xtraTreeListBlending1;
        internal DevExpress.XtraEditors.SimpleButton btnAlphaBlending;
        internal DevExpress.XtraEditors.CheckEdit chbAlphaBlending;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit ceNewStyles;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private DevExpress.XtraEditors.SplitterControl splitter2;
        private DevExpress.XtraEditors.ListBoxControl lbcAppearances;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.ComponentModel.IContainer components;

    }
}
