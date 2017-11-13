namespace DevExpress.XtraNavBar.Demos {
    partial class CustomizableDistances {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizableDistances));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.navBarGroup10 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup11 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem16 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup12 = new DevExpress.XtraNavBar.NavBarGroup();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.pnlHint = new DevExpress.Utils.Frames.NotePanel();
            this.distanceChanger3 = new DevExpress.XtraNavBar.Demos.DistanceChanger();
            this.distanceChanger2 = new DevExpress.XtraNavBar.Demos.DistanceChanger();
            this.distanceChanger1 = new DevExpress.XtraNavBar.Demos.DistanceChanger();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Controls.Add(this.navBarControl1);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.contentPanel.Size = new System.Drawing.Size(597, 538);
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
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.ExplorerBarGroupInterval = 10;
            this.navBarControl1.ExplorerBarGroupOuterIndent = 5;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup10,
            this.navBarGroup11,
            this.navBarGroup12});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.navBarItem14,
            this.navBarItem16});
            this.navBarControl1.LargeImages = this.imageList1;
            this.navBarControl1.LinkInterval = 0;
            this.navBarControl1.Location = new System.Drawing.Point(4, 5);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.Size = new System.Drawing.Size(172, 525);
            this.navBarControl1.SmallImages = this.imageList2;
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.AdvExplorerBarViewInfoRegistrator();
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "System Tasks";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "View system information";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImageIndex = 0;
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Add or remove programs";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImageIndex = 2;
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Change settings";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImageIndex = 3;
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Controls.Add(this.label3);
            this.navBarGroupControlContainer3.Controls.Add(this.label2);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(160, 76);
            this.navBarGroupControlContainer3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "System Folder";
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "My computer";
            // 
            // navBarGroup10
            // 
            this.navBarGroup10.Caption = "Other Places";
            this.navBarGroup10.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup10.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup10.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup10.LargeImage")));
            this.navBarGroup10.Name = "navBarGroup10";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "My Network Places";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.SmallImageIndex = 1;
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "My Documents";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.SmallImageIndex = 4;
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Control Panel";
            this.navBarItem12.Name = "navBarItem12";
            this.navBarItem12.SmallImageIndex = 3;
            // 
            // navBarGroup11
            // 
            this.navBarGroup11.Caption = "Disks";
            this.navBarGroup11.Expanded = true;
            this.navBarGroup11.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup11.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem16)});
            this.navBarGroup11.Name = "navBarGroup11";
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Floppy (A:)";
            this.navBarItem13.LargeImageIndex = 0;
            this.navBarItem13.Name = "navBarItem13";
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "System (C:)";
            this.navBarItem14.LargeImageIndex = 1;
            this.navBarItem14.Name = "navBarItem14";
            // 
            // navBarItem16
            // 
            this.navBarItem16.Caption = "CD Drive (E:)";
            this.navBarItem16.LargeImageIndex = 2;
            this.navBarItem16.Name = "navBarItem16";
            // 
            // navBarGroup12
            // 
            this.navBarGroup12.Caption = "Details";
            this.navBarGroup12.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup12.Expanded = true;
            this.navBarGroup12.GroupClientHeight = 77;
            this.navBarGroup12.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup12.Name = "navBarGroup12";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.pnlHint);
            this.panel1.Controls.Add(this.distanceChanger3);
            this.panel1.Controls.Add(this.distanceChanger2);
            this.panel1.Controls.Add(this.distanceChanger1);
            this.panel1.Location = new System.Drawing.Point(180, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 525);
            this.panel1.TabIndex = 3;
            // 
            // pnlHint
            // 
            this.pnlHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHint.ForeColor = System.Drawing.Color.Black;
            this.pnlHint.Location = new System.Drawing.Point(10, 198);
            this.pnlHint.MaxRows = 20;
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(393, 22);
            this.pnlHint.TabIndex = 3;
            this.pnlHint.TabStop = false;
            // 
            // distanceChanger3
            // 
            this.distanceChanger3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceChanger3.Caption = "Link Interval:";
            this.distanceChanger3.Location = new System.Drawing.Point(6, 130);
            this.distanceChanger3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.distanceChanger3.Name = "distanceChanger3";
            this.distanceChanger3.Size = new System.Drawing.Size(401, 56);
            this.distanceChanger3.TabIndex = 2;
            this.distanceChanger3.Value = 0;
            // 
            // distanceChanger2
            // 
            this.distanceChanger2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceChanger2.Caption = "Bar Group Outer Indent:";
            this.distanceChanger2.Location = new System.Drawing.Point(6, 70);
            this.distanceChanger2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.distanceChanger2.Name = "distanceChanger2";
            this.distanceChanger2.Size = new System.Drawing.Size(401, 56);
            this.distanceChanger2.TabIndex = 1;
            this.distanceChanger2.Value = 0;
            // 
            // distanceChanger1
            // 
            this.distanceChanger1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceChanger1.Caption = "Bar Group Interval:";
            this.distanceChanger1.Location = new System.Drawing.Point(6, 10);
            this.distanceChanger1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.distanceChanger1.Maximum = 60;
            this.distanceChanger1.Minimum = 10;
            this.distanceChanger1.Name = "distanceChanger1";
            this.distanceChanger1.Size = new System.Drawing.Size(401, 56);
            this.distanceChanger1.TabIndex = 0;
            this.distanceChanger1.Value = 10;
            // 
            // CustomizableDistances
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomizableDistances";
            this.Size = new System.Drawing.Size(597, 538);
            this.Load += new System.EventHandler(this.CustomizableDistances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.navBarGroupControlContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup10;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup11;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraNavBar.NavBarItem navBarItem16;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraNavBar.Demos.DistanceChanger distanceChanger1;
        private DevExpress.XtraNavBar.Demos.DistanceChanger distanceChanger2;
        private DevExpress.XtraNavBar.Demos.DistanceChanger distanceChanger3;
        private DevExpress.Utils.Frames.NotePanel pnlHint;
        private System.ComponentModel.IContainer components;

    }
}
