namespace DevExpress.XtraNavBar.Demos {
    partial class frmNavBarDragDrop {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "GridControl"}, 19, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "TreeList"}, 22, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "NavBarControl"}, 23, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavBarDragDrop));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem15 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem20 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem23 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem16 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem21 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem18 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem17 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem19 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem24 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbRecycle = new DevExpress.XtraEditors.LabelControl();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ceAllowOuterDrop = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowDrop = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowDrag = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowOuterDrop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowDrop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowDrag.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupControl3);
            this.contentPanel.Controls.Add(this.groupControl2);
            this.contentPanel.Controls.Add(this.groupControl1);
            this.contentPanel.Controls.Add(this.navBarControl1);
            this.contentPanel.Size = new System.Drawing.Size(624, 425);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup2;
            this.navBarControl1.DragDropFlags = ((DevExpress.XtraNavBar.NavBarDragDrop)(((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag | DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop) 
            | DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem13,
            this.navBarItem14,
            this.navBarItem15,
            this.navBarItem16,
            this.navBarItem17,
            this.navBarItem18,
            this.navBarItem19,
            this.navBarItem20,
            this.navBarItem21,
            this.navBarItem23,
            this.navBarItem24});
            this.navBarControl1.Location = new System.Drawing.Point(5, 5);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.Size = new System.Drawing.Size(172, 417);
            this.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.navBarControl1.SmallImages = this.imageList1;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.NavDragOver += new DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventHandler(this.navBarControl1_NavDragOver);
            this.navBarControl1.NavDragDrop += new DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventHandler(this.navBarControl1_NavDragDrop);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Windows Forms";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem15)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Label";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 5;
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Button";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImageIndex = 7;
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "TextBox";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImageIndex = 8;
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "MainMenu";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.SmallImageIndex = 9;
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "CheckBox";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.SmallImageIndex = 10;
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "GroupBox";
            this.navBarItem13.Enabled = false;
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.SmallImageIndex = 12;
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "PictureBox";
            this.navBarItem14.Enabled = false;
            this.navBarItem14.Name = "navBarItem14";
            this.navBarItem14.SmallImageIndex = 13;
            // 
            // navBarItem15
            // 
            this.navBarItem15.Caption = "Panel";
            this.navBarItem15.Name = "navBarItem15";
            this.navBarItem15.SmallImageIndex = 14;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Components";
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "FileSystemWatcher";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 0;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "DirectoryEntry";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 1;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "DirectorySearcher";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 2;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Timer";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 4;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navBarGroup3.AppearanceHotTracked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.navBarGroup3.AppearanceHotTracked.Options.UseFont = true;
            this.navBarGroup3.AppearanceHotTracked.Options.UseForeColor = true;
            this.navBarGroup3.Caption = "Xtra Products";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem20),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem23),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem16),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem21),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem18),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem17),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem19)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem20
            // 
            this.navBarItem20.Caption = "GridControl";
            this.navBarItem20.Name = "navBarItem20";
            this.navBarItem20.SmallImageIndex = 19;
            // 
            // navBarItem23
            // 
            this.navBarItem23.Caption = "TreeList";
            this.navBarItem23.Name = "navBarItem23";
            this.navBarItem23.SmallImageIndex = 22;
            // 
            // navBarItem16
            // 
            this.navBarItem16.Caption = "BarManager";
            this.navBarItem16.Name = "navBarItem16";
            this.navBarItem16.SmallImageIndex = 15;
            // 
            // navBarItem21
            // 
            this.navBarItem21.Caption = "PrintControl";
            this.navBarItem21.Name = "navBarItem21";
            this.navBarItem21.SmallImageIndex = 20;
            // 
            // navBarItem18
            // 
            this.navBarItem18.Caption = "ButtonEdit";
            this.navBarItem18.Name = "navBarItem18";
            this.navBarItem18.SmallImageIndex = 17;
            // 
            // navBarItem17
            // 
            this.navBarItem17.Caption = "CalcEdit";
            this.navBarItem17.Name = "navBarItem17";
            this.navBarItem17.SmallImageIndex = 16;
            // 
            // navBarItem19
            // 
            this.navBarItem19.Caption = "DataNavigator";
            this.navBarItem19.Name = "navBarItem19";
            this.navBarItem19.SmallImageIndex = 18;
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Temp";
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarItem24
            // 
            this.navBarItem24.Caption = "NavBarControl";
            this.navBarItem24.Name = "navBarItem24";
            this.navBarItem24.SmallImageIndex = 23;
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
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(2, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 97);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // lbRecycle
            // 
            this.lbRecycle.AllowDrop = true;
            this.lbRecycle.Appearance.ImageIndex = 0;
            this.lbRecycle.Appearance.ImageList = this.imageList2;
            this.lbRecycle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRecycle.Location = new System.Drawing.Point(178, 48);
            this.lbRecycle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbRecycle.Name = "lbRecycle";
            this.lbRecycle.Size = new System.Drawing.Size(63, 34);
            this.lbRecycle.TabIndex = 4;
            this.lbRecycle.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbRecycle_DragDrop);
            this.lbRecycle.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbRecycle_DragEnter);
            this.lbRecycle.DragLeave += new System.EventHandler(this.lbRecycle_DragLeave);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listView1);
            this.groupControl1.Location = new System.Drawing.Point(199, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(412, 120);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Items List:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lbRecycle);
            this.groupControl2.Location = new System.Drawing.Point(199, 134);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(411, 120);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Recycle Bin:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ceAllowOuterDrop);
            this.groupControl3.Controls.Add(this.ceAllowDrop);
            this.groupControl3.Controls.Add(this.ceAllowDrag);
            this.groupControl3.Location = new System.Drawing.Point(199, 260);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(411, 126);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Drag && Drop Options:";
            // 
            // ceAllowOuterDrop
            // 
            this.ceAllowOuterDrop.Location = new System.Drawing.Point(16, 96);
            this.ceAllowOuterDrop.Name = "ceAllowOuterDrop";
            this.ceAllowOuterDrop.Properties.Caption = "Allow Outer Drop";
            this.ceAllowOuterDrop.Size = new System.Drawing.Size(144, 19);
            this.ceAllowOuterDrop.TabIndex = 2;
            this.ceAllowOuterDrop.CheckedChanged += new System.EventHandler(this.ceAllowOuterDrop_CheckedChanged);
            // 
            // ceAllowDrop
            // 
            this.ceAllowDrop.Location = new System.Drawing.Point(16, 64);
            this.ceAllowDrop.Name = "ceAllowDrop";
            this.ceAllowDrop.Properties.Caption = "Allow Drop";
            this.ceAllowDrop.Size = new System.Drawing.Size(144, 19);
            this.ceAllowDrop.TabIndex = 1;
            this.ceAllowDrop.CheckedChanged += new System.EventHandler(this.ceAllowDrop_CheckedChanged);
            // 
            // ceAllowDrag
            // 
            this.ceAllowDrag.Location = new System.Drawing.Point(16, 32);
            this.ceAllowDrag.Name = "ceAllowDrag";
            this.ceAllowDrag.Properties.Caption = "Allow Drag";
            this.ceAllowDrag.Size = new System.Drawing.Size(144, 19);
            this.ceAllowDrag.TabIndex = 0;
            this.ceAllowDrag.CheckedChanged += new System.EventHandler(this.ceAllowDrag_CheckedChanged);
            // 
            // frmNavBarDragDrop
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "frmNavBarDragDrop";
            this.Size = new System.Drawing.Size(624, 425);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel)).EndInit();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowOuterDrop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowDrop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowDrag.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraNavBar.NavBarItem navBarItem15;
        private DevExpress.XtraNavBar.NavBarItem navBarItem16;
        private DevExpress.XtraNavBar.NavBarItem navBarItem17;
        private DevExpress.XtraNavBar.NavBarItem navBarItem18;
        private DevExpress.XtraNavBar.NavBarItem navBarItem19;
        private DevExpress.XtraNavBar.NavBarItem navBarItem20;
        private DevExpress.XtraNavBar.NavBarItem navBarItem21;
        private DevExpress.XtraNavBar.NavBarItem navBarItem23;
        private System.Windows.Forms.ListView listView1;
        private DevExpress.XtraEditors.LabelControl lbRecycle;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem24;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckEdit ceAllowDrag;
        private DevExpress.XtraEditors.CheckEdit ceAllowDrop;
        private DevExpress.XtraEditors.CheckEdit ceAllowOuterDrop;
        private System.ComponentModel.IContainer components;

    }
}
