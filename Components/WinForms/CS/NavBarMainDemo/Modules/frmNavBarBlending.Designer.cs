namespace DevExpress.XtraNavBar.Demos {
    partial class frmNavBarBlending {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavBarBlending));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ctrlAlphaBlending1 = new DevExpress.XtraNavBar.Demos.ctrlAlphaBlending();
            this.ctrlAlphaBlending2 = new DevExpress.XtraNavBar.Demos.ctrlAlphaBlending();
            this.ctrlAlphaBlending3 = new DevExpress.XtraNavBar.Demos.ctrlAlphaBlending();
            this.ctrlAlphaBlending4 = new DevExpress.XtraNavBar.Demos.ctrlAlphaBlending();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.ctrlAlphaBlending4);
            this.contentPanel.Controls.Add(this.ctrlAlphaBlending3);
            this.contentPanel.Controls.Add(this.ctrlAlphaBlending2);
            this.contentPanel.Controls.Add(this.ctrlAlphaBlending1);
            this.contentPanel.Controls.Add(this.navBarControl1);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.contentPanel.Size = new System.Drawing.Size(1005, 659);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(174)))), ((int)(((byte)(215)))));
            this.navBarControl1.Appearance.GroupBackground.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.navBarControl1.Appearance.GroupBackground.Options.UseBackColor = true;
            this.navBarControl1.Appearance.GroupBackground.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarControl1.Appearance.GroupHeaderPressed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderPressed.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.navBarControl1.Appearance.ItemPressed.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6});
            this.navBarControl1.LargeImages = this.imageList1;
            this.navBarControl1.Location = new System.Drawing.Point(5, 5);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 229;
            this.navBarControl1.Size = new System.Drawing.Size(229, 741);
            this.navBarControl1.SmallImages = this.imageList2;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator();
            this.navBarControl1.CustomDrawGroupClientForeground += new DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(this.navBarControl1_CustomDrawGroupClientForeground);
            this.navBarControl1.MouseLeave += new System.EventHandler(this.navBarControl1_MouseLeave);
            this.navBarControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBarControl1_MouseMove);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))), ((int)(((byte)(151)))));
            this.navBarGroup2.AppearanceBackground.Options.UseBackColor = true;
            this.navBarGroup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.BackgroundImage")));
            this.navBarGroup2.Caption = "Other Places";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup2.LargeImageIndex = 1;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Desktop";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 0;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "My Computer";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 1;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "My Network Places";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 2;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(145)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.navBarGroup1.AppearanceBackground.Options.UseBackColor = true;
            this.navBarGroup1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.BackgroundImage")));
            this.navBarGroup1.Caption = "My Documents";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup1.LargeImageIndex = 0;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "My Music";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 3;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "My Pictures";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 4;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Received Files";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 5;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Details";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.LargeImageIndex = 2;
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.CalcGroupClientHeight += new DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(this.navBarGroup3_CalcGroupClientHeight);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
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
            // 
            // ctrlAlphaBlending1
            // 
            this.ctrlAlphaBlending1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlAlphaBlending1.Location = new System.Drawing.Point(254, 5);
            this.ctrlAlphaBlending1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAlphaBlending1.Name = "ctrlAlphaBlending1";
            this.ctrlAlphaBlending1.Size = new System.Drawing.Size(706, 118);
            this.ctrlAlphaBlending1.TabIndex = 1;
            // 
            // ctrlAlphaBlending2
            // 
            this.ctrlAlphaBlending2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlAlphaBlending2.Location = new System.Drawing.Point(254, 131);
            this.ctrlAlphaBlending2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAlphaBlending2.Name = "ctrlAlphaBlending2";
            this.ctrlAlphaBlending2.Size = new System.Drawing.Size(706, 118);
            this.ctrlAlphaBlending2.TabIndex = 2;
            // 
            // ctrlAlphaBlending3
            // 
            this.ctrlAlphaBlending3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlAlphaBlending3.Location = new System.Drawing.Point(254, 256);
            this.ctrlAlphaBlending3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAlphaBlending3.Name = "ctrlAlphaBlending3";
            this.ctrlAlphaBlending3.Size = new System.Drawing.Size(706, 118);
            this.ctrlAlphaBlending3.TabIndex = 3;
            // 
            // ctrlAlphaBlending4
            // 
            this.ctrlAlphaBlending4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlAlphaBlending4.Location = new System.Drawing.Point(254, 382);
            this.ctrlAlphaBlending4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAlphaBlending4.Name = "ctrlAlphaBlending4";
            this.ctrlAlphaBlending4.Size = new System.Drawing.Size(706, 122);
            this.ctrlAlphaBlending4.TabIndex = 4;
            // 
            // frmNavBarBlending
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNavBarBlending";
            this.Size = new System.Drawing.Size(1005, 659);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private ctrlAlphaBlending ctrlAlphaBlending1;
        private ctrlAlphaBlending ctrlAlphaBlending2;
        private ctrlAlphaBlending ctrlAlphaBlending3;
        private ctrlAlphaBlending ctrlAlphaBlending4;
        private System.ComponentModel.IContainer components;

    }
}
