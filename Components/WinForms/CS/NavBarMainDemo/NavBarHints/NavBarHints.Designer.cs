namespace DevExpress.XtraNavBar.Demos {
    partial class NavBarHints {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBarHints));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceCustomHint = new DevExpress.XtraEditors.CheckEdit();
            this.seInterval = new DevExpress.XtraEditors.SpinEdit();
            this.ceLinkHint = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ceGroupHint = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomHint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLinkHint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupHint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panelControl1);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel.Size = new System.Drawing.Size(595, 436);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.navBarItem6,
            this.navBarItem7});
            this.navBarControl1.LargeImages = this.imageCollection1;
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 186;
            this.navBarControl1.Size = new System.Drawing.Size(186, 407);
            this.navBarControl1.SmallImages = this.imageCollection2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 28;
            this.navBarControl1.GetHint += new DevExpress.XtraNavBar.NavBarGetHintEventHandler(this.navBarControl1_GetHint);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Deleted";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup3.Hint = "Deleted Group hint";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup3.LargeImageIndex = 3;
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImageIndex = 3;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Report";
            this.navBarItem5.Hint = "Report hint";
            this.navBarItem5.LargeImageIndex = 4;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 4;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Deleted Items";
            this.navBarItem4.Enabled = false;
            this.navBarItem4.Hint = "Deleted Items folder";
            this.navBarItem4.LargeImageIndex = 3;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 3;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Local";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.Hint = "Local Group hint";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.LargeImageIndex = 5;
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImageIndex = 5;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Inbox";
            this.navBarItem1.Hint = "Inbox folder";
            this.navBarItem1.LargeImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 0;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Outbox";
            this.navBarItem2.Hint = "Outbox folder";
            this.navBarItem2.LargeImageIndex = 1;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 1;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Sent Items";
            this.navBarItem3.Enabled = false;
            this.navBarItem3.Hint = "Sent Items folder";
            this.navBarItem3.LargeImageIndex = 2;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 2;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Contacts";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarGroup2.Hint = "Contacts Group hint";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup2.LargeImageIndex = 6;
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImageIndex = 6;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Calendar";
            this.navBarItem6.Hint = "Calendar hint";
            this.navBarItem6.LargeImageIndex = 7;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 7;
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Task";
            this.navBarItem7.Hint = "Task hint";
            this.navBarItem7.LargeImageIndex = 8;
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImageIndex = 8;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("newmail_32x32.png", "images/mail/newmail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/newmail_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "newmail_32x32.png");
            this.imageCollection1.InsertGalleryImage("send_32x32.png", "images/mail/send_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/send_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "send_32x32.png");
            this.imageCollection1.InsertGalleryImage("emailtemplate_32x32.png", "images/mail/emailtemplate_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "emailtemplate_32x32.png");
            this.imageCollection1.InsertGalleryImage("trash_32x32.png", "images/actions/trash_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/trash_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "trash_32x32.png");
            this.imageCollection1.InsertGalleryImage("content_32x32.png", "images/miscellaneous/content_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/content_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "content_32x32.png");
            this.imageCollection1.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "mail_32x32.png");
            this.imageCollection1.InsertGalleryImage("bocontact2_32x32.png", "images/business%20objects/bocontact2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bocontact2_32x32.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "bocontact2_32x32.png");
            this.imageCollection1.InsertGalleryImage("today_32x32.png", "images/scheduling/today_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/today_32x32.png"), 7);
            this.imageCollection1.Images.SetKeyName(7, "today_32x32.png");
            this.imageCollection1.InsertGalleryImage("task_32x32.png", "images/tasks/task_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_32x32.png"), 8);
            this.imageCollection1.Images.SetKeyName(8, "task_32x32.png");
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.InsertGalleryImage("newmail_16x16.png", "images/mail/newmail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/newmail_16x16.png"), 0);
            this.imageCollection2.Images.SetKeyName(0, "newmail_16x16.png");
            this.imageCollection2.InsertGalleryImage("send_16x16.png", "images/mail/send_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/send_16x16.png"), 1);
            this.imageCollection2.Images.SetKeyName(1, "send_16x16.png");
            this.imageCollection2.InsertGalleryImage("emailtemplate_16x16.png", "images/mail/emailtemplate_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_16x16.png"), 2);
            this.imageCollection2.Images.SetKeyName(2, "emailtemplate_16x16.png");
            this.imageCollection2.InsertGalleryImage("trash_16x16.png", "images/actions/trash_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/trash_16x16.png"), 3);
            this.imageCollection2.Images.SetKeyName(3, "trash_16x16.png");
            this.imageCollection2.InsertGalleryImage("content_16x16.png", "images/miscellaneous/content_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/content_16x16.png"), 4);
            this.imageCollection2.Images.SetKeyName(4, "content_16x16.png");
            this.imageCollection2.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_16x16.png"), 5);
            this.imageCollection2.Images.SetKeyName(5, "mail_16x16.png");
            this.imageCollection2.InsertGalleryImage("bocontact2_16x16.png", "images/business%20objects/bocontact2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bocontact2_16x16.png"), 6);
            this.imageCollection2.Images.SetKeyName(6, "bocontact2_16x16.png");
            this.imageCollection2.InsertGalleryImage("today_16x16.png", "images/scheduling/today_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/today_16x16.png"), 7);
            this.imageCollection2.Images.SetKeyName(7, "today_16x16.png");
            this.imageCollection2.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_16x16.png"), 8);
            this.imageCollection2.Images.SetKeyName(8, "task_16x16.png");
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.ceCustomHint);
            this.groupControl1.Controls.Add(this.seInterval);
            this.groupControl1.Controls.Add(this.ceLinkHint);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.ceGroupHint);
            this.groupControl1.Location = new System.Drawing.Point(223, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 168);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Properties";
            // 
            // ceCustomHint
            // 
            this.ceCustomHint.Location = new System.Drawing.Point(16, 128);
            this.ceCustomHint.Name = "ceCustomHint";
            this.ceCustomHint.Properties.Caption = "Custom Hint (GetHint event)";
            this.ceCustomHint.Size = new System.Drawing.Size(224, 19);
            this.ceCustomHint.TabIndex = 4;
            // 
            // seInterval
            // 
            this.seInterval.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seInterval.Location = new System.Drawing.Point(152, 88);
            this.seInterval.Name = "seInterval";
            this.seInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seInterval.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seInterval.Properties.IsFloatValue = false;
            this.seInterval.Properties.Mask.EditMask = "N00";
            this.seInterval.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.seInterval.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seInterval.Size = new System.Drawing.Size(80, 20);
            this.seInterval.TabIndex = 3;
            this.seInterval.EditValueChanged += new System.EventHandler(this.seInterval_EditValueChanged);
            // 
            // ceLinkHint
            // 
            this.ceLinkHint.Location = new System.Drawing.Point(16, 56);
            this.ceLinkHint.Name = "ceLinkHint";
            this.ceLinkHint.Properties.Caption = "Show Link Hint";
            this.ceLinkHint.Size = new System.Drawing.Size(144, 19);
            this.ceLinkHint.TabIndex = 2;
            this.ceLinkHint.CheckedChanged += new System.EventHandler(this.ceLinkHint_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Show Hint Interval:";
            // 
            // ceGroupHint
            // 
            this.ceGroupHint.Location = new System.Drawing.Point(16, 32);
            this.ceGroupHint.Name = "ceGroupHint";
            this.ceGroupHint.Properties.Caption = "Show Group Hint";
            this.ceGroupHint.Size = new System.Drawing.Size(144, 19);
            this.ceGroupHint.TabIndex = 0;
            this.ceGroupHint.CheckedChanged += new System.EventHandler(this.ceGroupHint_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(7, 8);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(581, 417);
            this.panelControl1.TabIndex = 30;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.navBarControl1);
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(190, 411);
            this.panelControl2.TabIndex = 30;
            // 
            // NavBarHints
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NavBarHints";
            this.Size = new System.Drawing.Size(595, 436);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceCustomHint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLinkHint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGroupHint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ceGroupHint;
        private DevExpress.XtraEditors.CheckEdit ceLinkHint;
        private DevExpress.XtraEditors.SpinEdit seInterval;
        private DevExpress.XtraEditors.CheckEdit ceCustomHint;
        private System.ComponentModel.IContainer components;
        private XtraEditors.PanelControl panelControl1;
        private Utils.ImageCollection imageCollection1;
        private Utils.ImageCollection imageCollection2;
        private XtraEditors.PanelControl panelControl2;

    }
}
