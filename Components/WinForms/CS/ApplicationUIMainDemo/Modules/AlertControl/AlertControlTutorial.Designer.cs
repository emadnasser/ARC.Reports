namespace DevExpress.ApplicationUI.Demos {
    partial class AlertControlTutorial {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            DevExpress.XtraBars.Alerter.AlertButton alertButton1 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton2 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton3 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraBars.Alerter.AlertButton alertButton4 = new DevExpress.XtraBars.Alerter.AlertButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertControlTutorial));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.sePostponedFormCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceHeight = new DevExpress.XtraEditors.SpinEdit();
            this.ceWidth = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.alertInfoProperties1 = new DevExpress.ApplicationUI.Demos.AlertInfoProperties();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.alertControlProperties1 = new DevExpress.ApplicationUI.Demos.AlertControlProperties();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sePostponedFormCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWidth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(708, 530);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.sePostponedFormCount);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.ceHeight);
            this.xtraTabPage1.Controls.Add(this.ceWidth);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.button1);
            this.xtraTabPage1.Controls.Add(this.barDockControlLeft);
            this.xtraTabPage1.Controls.Add(this.barDockControlRight);
            this.xtraTabPage1.Controls.Add(this.barDockControlBottom);
            this.xtraTabPage1.Controls.Add(this.barDockControlTop);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(702, 524);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // sePostponedFormCount
            // 
            this.sePostponedFormCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePostponedFormCount.Location = new System.Drawing.Point(316, 21);
            this.sePostponedFormCount.Name = "sePostponedFormCount";
            this.sePostponedFormCount.Properties.IsFloatValue = false;
            this.sePostponedFormCount.Properties.Mask.EditMask = "N00";
            this.sePostponedFormCount.Properties.ReadOnly = true;
            this.sePostponedFormCount.Size = new System.Drawing.Size(61, 20);
            this.sePostponedFormCount.TabIndex = 18;
            this.sePostponedFormCount.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(183, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(114, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Postponed Form Count:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(203, 484);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = ",";
            // 
            // ceHeight
            // 
            this.ceHeight.EditValue = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.ceHeight.Location = new System.Drawing.Point(216, 481);
            this.ceHeight.Name = "ceHeight";
            this.ceHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ceHeight.Properties.IsFloatValue = false;
            this.ceHeight.Properties.Mask.EditMask = "N00";
            this.ceHeight.Properties.MaxValue = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ceHeight.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ceHeight.Size = new System.Drawing.Size(84, 20);
            this.ceHeight.TabIndex = 11;
            // 
            // ceWidth
            // 
            this.ceWidth.EditValue = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.ceWidth.Location = new System.Drawing.Point(113, 481);
            this.ceWidth.Name = "ceWidth";
            this.ceWidth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ceWidth.Properties.IsFloatValue = false;
            this.ceWidth.Properties.Mask.EditMask = "N00";
            this.ceWidth.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ceWidth.Properties.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ceWidth.Size = new System.Drawing.Size(84, 20);
            this.ceWidth.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 484);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Alert Form Size:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.alertInfoProperties1);
            this.groupControl2.Location = new System.Drawing.Point(359, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(298, 399);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Alert Info:";
            // 
            // alertInfoProperties1
            // 
            this.alertInfoProperties1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertInfoProperties1.Location = new System.Drawing.Point(2, 20);
            this.alertInfoProperties1.Name = "alertInfoProperties1";
            this.alertInfoProperties1.Size = new System.Drawing.Size(294, 377);
            this.alertInfoProperties1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.alertControlProperties1);
            this.groupControl1.Location = new System.Drawing.Point(12, 54);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 399);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Alert Control Properties:";
            // 
            // alertControlProperties1
            // 
            this.alertControlProperties1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertControlProperties1.Location = new System.Drawing.Point(2, 20);
            this.alertControlProperties1.Name = "alertControlProperties1";
            this.alertControlProperties1.Size = new System.Drawing.Size(324, 377);
            this.alertControlProperties1.TabIndex = 0;
            this.alertControlProperties1.AllowHtmlTextChanged += new System.EventHandler(this.alertControlProperties1_AllowHtmlTextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Show Alert Form";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 524);
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(702, 0);
            // 
            // alertControl1
            // 
            alertButton1.Hint = "Open Info";
            alertButton1.ImageIndex = 5;
            alertButton1.Name = "Open";
            alertButton2.Hint = "Copy Info";
            alertButton2.ImageIndex = 2;
            alertButton2.Name = "Copy";
            alertButton3.Hint = "Delete Info";
            alertButton3.ImageIndex = 6;
            alertButton3.Name = "Delete";
            alertButton4.Down = true;
            alertButton4.Hint = "Mail";
            alertButton4.ImageDownIndex = 1;
            alertButton4.ImageIndex = 0;
            alertButton4.Name = "Mail";
            alertButton4.Style = DevExpress.XtraBars.Alerter.AlertButtonStyle.CheckButton;
            this.alertControl1.Buttons.Add(alertButton1);
            this.alertControl1.Buttons.Add(alertButton2);
            this.alertControl1.Buttons.Add(alertButton3);
            this.alertControl1.Buttons.Add(alertButton4);
            this.alertControl1.FormMaxCount = 7;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            this.alertControl1.Images = this.imageCollection1;
            this.alertControl1.PopupMenu = this.popupMenu1;
            this.alertControl1.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alertControl1_BeforeFormShow);
            this.alertControl1.FormLoad += new DevExpress.XtraBars.Alerter.AlertFormLoadEventHandler(this.alertControl1_FormLoad);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Contact";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.BindableChecked = true;
            this.barCheckItem1.Caption = "Customer";
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.GroupIndex = 1;
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.ImageIndex = 10;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Employee";
            this.barCheckItem2.GroupIndex = 1;
            this.barCheckItem2.Id = 2;
            this.barCheckItem2.ImageIndex = 11;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Find";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageIndex = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.BindableChecked = true;
            this.barCheckItem3.Caption = "Attachment";
            this.barCheckItem3.Checked = true;
            this.barCheckItem3.Id = 5;
            this.barCheckItem3.ImageIndex = 9;
            this.barCheckItem3.Name = "barCheckItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Preview";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageIndex = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Print";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageIndex = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCheckItem3,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 7;
            // 
            // AlertControlTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "AlertControlTutorial";
            this.Size = new System.Drawing.Size(713, 535);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sePostponedFormCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceWidth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private AlertControlProperties alertControlProperties1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private AlertInfoProperties alertInfoProperties1;
        private DevExpress.XtraEditors.SpinEdit ceHeight;
        private DevExpress.XtraEditors.SpinEdit ceWidth;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit sePostponedFormCount;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraTab.XtraTabPage xtraTabPage1;

    }
}
