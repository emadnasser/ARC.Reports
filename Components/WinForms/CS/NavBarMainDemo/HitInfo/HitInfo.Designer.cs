namespace DevExpress.XtraNavBar.Demos {
    partial class HitInfo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitInfo));
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.lbHitTest = new DevExpress.XtraEditors.TextEdit();
            this.lbGroup = new DevExpress.XtraEditors.TextEdit();
            this.lbLink = new DevExpress.XtraEditors.TextEdit();
            this.lbPoint = new DevExpress.XtraEditors.TextEdit();
            this.lbClick = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbHitTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbClick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panelControl2);
            this.contentPanel.Controls.Add(this.panelControl1);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel.Size = new System.Drawing.Size(554, 391);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HitTest:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Group:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Link:";
            // 
            // label6
            // 
            this.label6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.label6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.label6.Location = new System.Drawing.Point(26, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 48);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Link Clicked:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Point:";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
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
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 376);
            this.navBarControl1.SmallImages = this.imageCollection2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl1_LinkClicked);
            this.navBarControl1.MouseLeave += new System.EventHandler(this.navBarControl1_MouseLeave);
            this.navBarControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navBarControl1_MouseMove);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Contacts";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup2.LargeImageIndex = 6;
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImageIndex = 6;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Calendar";
            this.navBarItem6.LargeImageIndex = 7;
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 7;
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Task";
            this.navBarItem7.LargeImageIndex = 8;
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImageIndex = 8;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Report";
            this.navBarItem5.LargeImageIndex = 4;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 4;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Local";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup1.LargeImageIndex = 5;
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImageIndex = 5;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Inbox";
            this.navBarItem1.LargeImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 0;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Outbox";
            this.navBarItem2.LargeImageIndex = 1;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 1;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Sent Items";
            this.navBarItem3.Enabled = false;
            this.navBarItem3.LargeImageIndex = 2;
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 2;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Deleted Items";
            this.navBarItem4.Enabled = false;
            this.navBarItem4.LargeImageIndex = 3;
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 3;
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
            // lbHitTest
            // 
            this.lbHitTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHitTest.Location = new System.Drawing.Point(106, 0);
            this.lbHitTest.Name = "lbHitTest";
            this.lbHitTest.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHitTest.Properties.Appearance.Options.UseFont = true;
            this.lbHitTest.Properties.ReadOnly = true;
            this.lbHitTest.Size = new System.Drawing.Size(229, 20);
            this.lbHitTest.TabIndex = 1;
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGroup.Location = new System.Drawing.Point(106, 24);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Properties.ReadOnly = true;
            this.lbGroup.Size = new System.Drawing.Size(229, 20);
            this.lbGroup.TabIndex = 2;
            // 
            // lbLink
            // 
            this.lbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLink.Location = new System.Drawing.Point(106, 48);
            this.lbLink.Name = "lbLink";
            this.lbLink.Properties.ReadOnly = true;
            this.lbLink.Size = new System.Drawing.Size(229, 20);
            this.lbLink.TabIndex = 3;
            // 
            // lbPoint
            // 
            this.lbPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPoint.Location = new System.Drawing.Point(106, 72);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Properties.ReadOnly = true;
            this.lbPoint.Size = new System.Drawing.Size(229, 20);
            this.lbPoint.TabIndex = 4;
            // 
            // lbClick
            // 
            this.lbClick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClick.Location = new System.Drawing.Point(106, 104);
            this.lbClick.Name = "lbClick";
            this.lbClick.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.lbClick.Properties.Appearance.Options.UseBackColor = true;
            this.lbClick.Properties.ReadOnly = true;
            this.lbClick.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbClick.Size = new System.Drawing.Size(229, 48);
            this.lbClick.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.lbClick);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.lbPoint);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.lbLink);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.lbGroup);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.lbHitTest);
            this.panelControl1.Location = new System.Drawing.Point(206, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(341, 378);
            this.panelControl1.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.navBarControl1);
            this.panelControl2.Location = new System.Drawing.Point(4, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(197, 380);
            this.panelControl2.TabIndex = 12;
            // 
            // HitInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "HitInfo";
            this.Size = new System.Drawing.Size(554, 391);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbHitTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbClick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label7;
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
        private DevExpress.XtraEditors.TextEdit lbHitTest;
        private DevExpress.XtraEditors.TextEdit lbGroup;
        private DevExpress.XtraEditors.TextEdit lbLink;
        private DevExpress.XtraEditors.TextEdit lbPoint;
        private DevExpress.XtraEditors.MemoEdit lbClick;
        private System.ComponentModel.IContainer components;
        private XtraEditors.PanelControl panelControl1;
        private Utils.ImageCollection imageCollection1;
        private Utils.ImageCollection imageCollection2;
        private XtraEditors.PanelControl panelControl2;

    }
}
