namespace DevExpress.XtraSpreadsheet.Demos {
    partial class EncryptionModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionModule));
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.basePanel = new DevExpress.XtraEditors.PanelControl();
            this.chbOpenResultingFile = new DevExpress.XtraEditors.CheckEdit();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.btnExportToXLS = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToXLSX = new DevExpress.XtraEditors.SimpleButton();
            this.passwordEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.typeEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.typeLabel = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.basePanel)).BeginInit();
            this.basePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbOpenResultingFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.MinimumSize = new System.Drawing.Size(200, 150);
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(630, 411);
            this.spreadsheetControl1.TabIndex = 0;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(853, 25);
            this.splitterControl1.MinExtra = 250;
            this.splitterControl1.MinSize = 150;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 527);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // basePanel
            // 
            this.basePanel.Controls.Add(this.chbOpenResultingFile);
            this.basePanel.Controls.Add(this.passwordLabel);
            this.basePanel.Controls.Add(this.btnExportToXLS);
            this.basePanel.Controls.Add(this.btnExportToXLSX);
            this.basePanel.Controls.Add(this.passwordEdit);
            this.basePanel.Controls.Add(this.typeEdit);
            this.basePanel.Controls.Add(this.typeLabel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.basePanel.Location = new System.Drawing.Point(640, 141);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(218, 411);
            this.basePanel.TabIndex = 4;
            // 
            // chbOpenResultingFile
            // 
            this.chbOpenResultingFile.EditValue = true;
            this.chbOpenResultingFile.Location = new System.Drawing.Point(15, 175);
            this.chbOpenResultingFile.Name = "chbOpenResultingFile";
            this.chbOpenResultingFile.Properties.Caption = "Open resulting file";
            this.chbOpenResultingFile.Size = new System.Drawing.Size(144, 19);
            this.chbOpenResultingFile.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(15, 21);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(50, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "&Password:";
            // 
            // btnExportToXLS
            // 
            this.btnExportToXLS.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToXLS.Image")));
            this.btnExportToXLS.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportToXLS.Location = new System.Drawing.Point(115, 97);
            this.btnExportToXLS.Name = "btnExportToXLS";
            this.btnExportToXLS.Size = new System.Drawing.Size(90, 59);
            this.btnExportToXLS.TabIndex = 1;
            this.btnExportToXLS.Text = "Save as XLS";
            this.btnExportToXLS.Click += new System.EventHandler(this.BtnExportToXLS_Click);
            // 
            // btnExportToXLSX
            // 
            this.btnExportToXLSX.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToXLSX.Image")));
            this.btnExportToXLSX.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportToXLSX.Location = new System.Drawing.Point(15, 97);
            this.btnExportToXLSX.Name = "btnExportToXLSX";
            this.btnExportToXLSX.Size = new System.Drawing.Size(90, 59);
            this.btnExportToXLSX.TabIndex = 0;
            this.btnExportToXLSX.Text = "Save as XLSX";
            this.btnExportToXLSX.Click += new System.EventHandler(this.BtnExportToXLSX_Click);
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(84, 18);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.Properties.MaxLength = 255;
            this.passwordEdit.Size = new System.Drawing.Size(118, 20);
            this.passwordEdit.TabIndex = 8;
            this.passwordEdit.TextChanged += new System.EventHandler(PasswordEdit_TextChanged);
            // 
            // typeEdit
            // 
            this.typeEdit.Location = new System.Drawing.Point(84, 53);
            this.typeEdit.Name = "typeEdit";
            this.typeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeEdit.Size = new System.Drawing.Size(118, 20);
            this.typeEdit.TabIndex = 9;
            this.typeEdit.TextChanged += new System.EventHandler(TypeEdit_TextChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(15, 56);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(28, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.separatorControl1.Location = new System.Drawing.Point(630, 141);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(10, 411);
            this.separatorControl1.TabIndex = 6;
            // 
            // EncryptionModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.basePanel);
            this.Name = "EncryptionModule";
            this.Size = new System.Drawing.Size(858, 552);
            this.Controls.SetChildIndex(this.basePanel, 0);
            this.Controls.SetChildIndex(this.separatorControl1, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.basePanel)).EndInit();
            this.basePanel.ResumeLayout(false);
            this.basePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbOpenResultingFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl basePanel;
        private XtraEditors.CheckEdit chbOpenResultingFile;
        private XtraEditors.LabelControl passwordLabel;
        private XtraEditors.SimpleButton btnExportToXLS;
        private XtraEditors.SimpleButton btnExportToXLSX;
        private XtraEditors.ComboBoxEdit passwordEdit;
        private XtraEditors.ComboBoxEdit typeEdit;
        private XtraEditors.LabelControl typeLabel;
        private XtraEditors.SeparatorControl separatorControl1;
    }
}
