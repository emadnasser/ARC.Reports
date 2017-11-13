namespace DevExpress.XtraNavBar.Demos {
    partial class CustomDraw {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDraw));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.checkBox1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkBox6 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panelControl1);
            this.contentPanel.Controls.Add(this.navBarControl1);
            this.contentPanel.Size = new System.Drawing.Size(675, 388);
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
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "My Documents";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
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
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Other Places";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Desktop";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 0;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "My Computer";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 1;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "My Network Places";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 2;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.GroupHeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.GroupHeaderPressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeaderPressed.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseBackColor = true;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.navBarControl1.Appearance.ItemPressed.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.ExplorerBarGroupInterval = 10;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5});
            this.navBarControl1.LargeImages = this.imageList1;
            this.navBarControl1.Location = new System.Drawing.Point(6, 6);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 229;
            this.navBarControl1.Size = new System.Drawing.Size(229, 376);
            this.navBarControl1.SmallImages = this.imageList1;
            this.navBarControl1.TabIndex = 21;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.UltraFlatExplorerBarViewInfoRegistrator();
            this.navBarControl1.CustomDrawGroupCaption += new DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(this.navBarControl1_CustomDrawGroupCaption);
            this.navBarControl1.CustomDrawLink += new DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(this.navBarControl1_CustomDrawLink);
            this.navBarControl1.CustomDrawGroupClientBackground += new DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(this.navBarControl1_CustomDrawGroupClientBackground);
            this.navBarControl1.CustomDrawGroupClientForeground += new DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(this.navBarControl1_CustomDrawGroupClientForeground);
            this.navBarControl1.CustomDrawBackground += new DevExpress.XtraNavBar.ViewInfo.CustomDrawObjectEventHandler(this.navBarControl1_CustomDrawBackground);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Details";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.CalcGroupClientHeight += new DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventHandler(this.navBarGroup3_CalcGroupClientHeight);
            // 
            // checkBox1
            // 
            this.checkBox1.EditValue = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 4);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Properties.Caption = "CustomDrawBackground";
            this.checkBox1.Size = new System.Drawing.Size(283, 20);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.EditValue = true;
            this.checkBox2.Location = new System.Drawing.Point(31, 36);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Properties.Caption = "CustomDrawGroupCaption";
            this.checkBox2.Size = new System.Drawing.Size(283, 20);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.EditValue = true;
            this.checkBox3.Location = new System.Drawing.Point(31, 67);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Properties.Caption = "CustomDrawGroupClientBackground";
            this.checkBox3.Size = new System.Drawing.Size(283, 20);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.EditValue = true;
            this.checkBox4.Location = new System.Drawing.Point(31, 99);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Properties.Caption = "CustomDrawGroupClientForeground";
            this.checkBox4.Size = new System.Drawing.Size(283, 20);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.EditValue = true;
            this.checkBox5.Location = new System.Drawing.Point(31, 130);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Properties.Caption = "CustomDrawLink";
            this.checkBox5.Size = new System.Drawing.Size(283, 20);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.EditValue = true;
            this.checkBox6.Location = new System.Drawing.Point(31, 161);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Properties.Caption = "CalcGroupClientHeight";
            this.checkBox6.Size = new System.Drawing.Size(283, 20);
            this.checkBox6.TabIndex = 28;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.checkBox1);
            this.panelControl1.Controls.Add(this.checkBox2);
            this.panelControl1.Controls.Add(this.checkBox6);
            this.panelControl1.Controls.Add(this.checkBox3);
            this.panelControl1.Controls.Add(this.checkBox5);
            this.panelControl1.Controls.Add(this.checkBox4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(235, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(434, 376);
            this.panelControl1.TabIndex = 29;
            // 
            // CustomDraw
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomDraw";
            this.Size = new System.Drawing.Size(675, 388);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraEditors.CheckEdit checkBox1;
        private DevExpress.XtraEditors.CheckEdit checkBox2;
        private DevExpress.XtraEditors.CheckEdit checkBox3;
        private DevExpress.XtraEditors.CheckEdit checkBox4;
        private DevExpress.XtraEditors.CheckEdit checkBox5;
        private DevExpress.XtraEditors.CheckEdit checkBox6;
        private System.ComponentModel.IContainer components;
        private XtraEditors.PanelControl panelControl1;

    }
}
