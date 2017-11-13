namespace DevExpress.XtraTreeList.Demos {
    partial class TreeListCustomDraw {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeListCustomDraw));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imglNodes = new System.Windows.Forms.ImageList(this.components);
            this.imglCustom = new System.Windows.Forms.ImageList(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // imglNodes
            // 
            this.imglNodes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglNodes.ImageStream")));
            this.imglNodes.TransparentColor = System.Drawing.Color.Magenta;
            this.imglNodes.Images.SetKeyName(0, "");
            this.imglNodes.Images.SetKeyName(1, "");
            this.imglNodes.Images.SetKeyName(2, "");
            this.imglNodes.Images.SetKeyName(3, "");
            this.imglNodes.Images.SetKeyName(4, "");
            this.imglNodes.Images.SetKeyName(5, "");
            this.imglNodes.Images.SetKeyName(6, "");
            // 
            // imglCustom
            // 
            this.imglCustom.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglCustom.ImageStream")));
            this.imglCustom.TransparentColor = System.Drawing.Color.Magenta;
            this.imglCustom.Images.SetKeyName(0, "");
            this.imglCustom.Images.SetKeyName(1, "");
            this.imglCustom.Images.SetKeyName(2, "");
            this.imglCustom.Images.SetKeyName(3, "");
            this.imglCustom.Images.SetKeyName(4, "");
            this.imglCustom.Images.SetKeyName(5, "");
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList1.Appearance.Empty.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.treeList1.Appearance.EvenRow.Options.UseBackColor = true;
            this.treeList1.Appearance.EvenRow.Options.UseForeColor = true;
            this.treeList1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeList1.Appearance.HeaderPanel.Options.UseFont = true;
            this.treeList1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.treeList1.Appearance.OddRow.Options.UseBackColor = true;
            this.treeList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeList1.BackgroundImage")));
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowSummaryFooter = true;
            this.treeList1.SelectImageList = this.imglNodes;
            this.treeList1.Size = new System.Drawing.Size(720, 349);
            this.treeList1.TabIndex = 1;
            this.treeList1.CustomDrawNodeIndicator += new DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(this.treeList1_CustomDrawNodeIndicator);
            this.treeList1.CustomDrawRowFooterCell += new DevExpress.XtraTreeList.CustomDrawRowFooterCellEventHandler(this.treeList1_CustomDrawRowFooterCell);
            this.treeList1.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeList1_CustomDrawNodeCell);
            this.treeList1.CustomDrawFooter += new DevExpress.XtraTreeList.CustomDrawFooterEventHandler(this.treeList1_CustomDrawFooter);
            this.treeList1.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(this.treeList1_FocusedColumnChanged);
            this.treeList1.CustomDrawNodeImages += new DevExpress.XtraTreeList.CustomDrawNodeImagesEventHandler(this.treeList1_CustomDrawNodeImages);
            this.treeList1.CustomDrawNodeButton += new DevExpress.XtraTreeList.CustomDrawNodeButtonEventHandler(this.treeList1_CustomDrawNodeButton);
            this.treeList1.CustomDrawRowFooter += new DevExpress.XtraTreeList.CustomDrawRowFooterEventHandler(this.treeList1_CustomDrawRowFooter);
            this.treeList1.CustomDrawColumnHeader += new DevExpress.XtraTreeList.CustomDrawColumnHeaderEventHandler(this.treeList1_CustomDrawColumnHeader);
            this.treeList1.CustomDrawFooterCell += new DevExpress.XtraTreeList.CustomDrawFooterCellEventHandler(this.treeList1_CustomDrawFooterCell);
            this.treeList1.TreeListMenuItemClick += new DevExpress.XtraTreeList.TreeListMenuItemClickEventHandler(this.treeList1_TreeListMenuItemClick);
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
            // TreeListCustomDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TreeListCustomDraw";
            this.Size = new System.Drawing.Size(720, 349);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imglCustom;
        private System.Windows.Forms.ImageList imglNodes;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.ComponentModel.IContainer components;
    }
}
