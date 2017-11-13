namespace DevExpress.XtraGrid.Demos {
    partial class frmSQLConnector {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLConnector));
            this.npMain = new DevExpress.Utils.Frames.NotePanel();
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.sbGenerateDB = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.lbRecords = new DevExpress.XtraEditors.LabelControl();
            this.sbAddRecords = new DevExpress.XtraEditors.SimpleButton();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.seRecordCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // npMain
            // 
            this.npMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            resources.ApplyResources(this.npMain, "npMain");
            this.npMain.ForeColor = System.Drawing.Color.Black;
            this.npMain.MaxRows = 20;
            this.npMain.Name = "npMain";
            this.npMain.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlButtons.Controls.Add(this.progressBarControl1);
            resources.ApplyResources(this.pnlButtons, "pnlButtons");
            this.pnlButtons.Name = "pnlButtons";
            // 
            // progressBarControl1
            // 
            resources.ApplyResources(this.progressBarControl1, "progressBarControl1");
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Maximum = 99;
            // 
            // sbGenerateDB
            // 
            resources.ApplyResources(this.sbGenerateDB, "sbGenerateDB");
            this.sbGenerateDB.Name = "sbGenerateDB";
            this.sbGenerateDB.Click += new System.EventHandler(this.sbGenerateDB_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Controls.Add(this.lbRecords);
            this.pnlMain.Controls.Add(this.sbAddRecords);
            this.pnlMain.Controls.Add(this.sbExit);
            this.pnlMain.Controls.Add(this.seRecordCount);
            this.pnlMain.Controls.Add(this.labelControl6);
            this.pnlMain.Controls.Add(this.sbGenerateDB);
            this.pnlMain.Controls.Add(this.tePassword);
            this.pnlMain.Controls.Add(this.teLogin);
            this.pnlMain.Controls.Add(this.labelControl5);
            this.pnlMain.Controls.Add(this.labelControl4);
            this.pnlMain.Controls.Add(this.radioGroup1);
            this.pnlMain.Controls.Add(this.labelControl3);
            this.pnlMain.Controls.Add(this.teServer);
            this.pnlMain.Controls.Add(this.labelControl2);
            this.pnlMain.Controls.Add(this.cbDatabase);
            this.pnlMain.Controls.Add(this.labelControl1);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // lbRecords
            // 
            this.lbRecords.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbRecords.Appearance.Font")));
            this.lbRecords.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("lbRecords.Appearance.ForeColor")));
            resources.ApplyResources(this.lbRecords, "lbRecords");
            this.lbRecords.Name = "lbRecords";
            // 
            // sbAddRecords
            // 
            resources.ApplyResources(this.sbAddRecords, "sbAddRecords");
            this.sbAddRecords.Name = "sbAddRecords";
            this.sbAddRecords.Click += new System.EventHandler(this.sbAddRecords_Click);
            // 
            // sbExit
            // 
            resources.ApplyResources(this.sbExit, "sbExit");
            this.sbExit.Name = "sbExit";
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // seRecordCount
            // 
            resources.ApplyResources(this.seRecordCount, "seRecordCount");
            this.seRecordCount.Name = "seRecordCount";
            this.seRecordCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seRecordCount.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seRecordCount.Properties.IsFloatValue = false;
            this.seRecordCount.Properties.Mask.EditMask = resources.GetString("seRecordCount.Properties.Mask.EditMask");
            this.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("seRecordCount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.seRecordCount.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.seRecordCount.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelControl6
            // 
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // tePassword
            // 
            resources.ApplyResources(this.tePassword, "tePassword");
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            // 
            // teLogin
            // 
            resources.ApplyResources(this.teLogin, "teLogin");
            this.teLogin.Name = "teLogin";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // radioGroup1
            // 
            resources.ApplyResources(this.radioGroup1, "radioGroup1");
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items"))), resources.GetString("radioGroup1.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items2"))), resources.GetString("radioGroup1.Properties.Items3"))});
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // teServer
            // 
            resources.ApplyResources(this.teServer, "teServer");
            this.teServer.Name = "teServer";
            this.teServer.EditValueChanged += new System.EventHandler(this.teServer_EditValueChanged);
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // cbDatabase
            // 
            resources.ApplyResources(this.cbDatabase, "cbDatabase");
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbDatabase.Properties.Buttons"))))});
            this.cbDatabase.Properties.ReadOnly = true;
            this.cbDatabase.EditValueChanged += new System.EventHandler(this.cbDatabase_EditValueChanged);
            this.cbDatabase.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbDatabase_QueryPopUp);
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // frmSQLConnector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.npMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSQLConnector";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSQLConnector_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Frames.NotePanel npMain;
        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.SimpleButton sbGenerateDB;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seRecordCount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton sbAddRecords;
        private DevExpress.XtraEditors.LabelControl lbRecords;
    }
}
