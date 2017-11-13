namespace DevExpress.Docs.Demos {
    partial class Compression {
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbEncryption = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.edtPassword = new DevExpress.XtraEditors.TextEdit();
            this.Encryption = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pnlProgress = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalFilesCount = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileSystemViewer1 = new DevExpress.Docs.Demos.Modules.FileSystemViewer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(8, 87);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(186, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Add To Archive...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbEncryption);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.edtPassword);
            this.groupControl2.Controls.Add(this.Encryption);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(8, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.groupControl2.Size = new System.Drawing.Size(186, 79);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Options";
            // 
            // cbEncryption
            // 
            this.cbEncryption.Location = new System.Drawing.Point(74, 52);
            this.cbEncryption.Name = "cbEncryption";
            this.cbEncryption.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEncryption.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEncryption.Size = new System.Drawing.Size(105, 20);
            this.cbEncryption.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Password:";
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(74, 26);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(105, 20);
            this.edtPassword.TabIndex = 5;
            // 
            // Encryption
            // 
            this.Encryption.Location = new System.Drawing.Point(13, 55);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(55, 13);
            this.Encryption.TabIndex = 6;
            this.Encryption.Text = "Encryption:";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(3, 29);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(710, 18);
            this.progressBarControl1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Location = new System.Drawing.Point(716, 29);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 18);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.OnCancelArchivingOperation);
            // 
            // pnlProgress
            // 
            this.pnlProgress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlProgress.Controls.Add(this.lblTotalFilesCount);
            this.pnlProgress.Controls.Add(this.progressBarControl1);
            this.pnlProgress.Controls.Add(this.simpleButton2);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgress.Location = new System.Drawing.Point(0, 381);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(784, 51);
            this.pnlProgress.TabIndex = 9;
            // 
            // lblTotalFilesCount
            // 
            this.lblTotalFilesCount.Location = new System.Drawing.Point(5, 6);
            this.lblTotalFilesCount.Name = "lblTotalFilesCount";
            this.lblTotalFilesCount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFilesCount.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileSystemViewer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 381);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(590, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(194, 381);
            this.panel2.TabIndex = 8;
            // 
            // fileSystemViewer1
            // 
            this.fileSystemViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSystemViewer1.Location = new System.Drawing.Point(0, 0);
            this.fileSystemViewer1.Name = "fileSystemViewer1";
            this.fileSystemViewer1.Size = new System.Drawing.Size(590, 381);
            this.fileSystemViewer1.TabIndex = 2;
            // 
            // Compression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProgress);
            this.Name = "Compression";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEncryption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlProgress)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.ProgressBarControl progressBarControl1;
        private XtraEditors.SimpleButton simpleButton1;
        private XtraEditors.ComboBoxEdit cbEncryption;
        private XtraEditors.TextEdit edtPassword;
        private XtraEditors.LabelControl Encryption;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.GroupControl groupControl2;
        private XtraEditors.SimpleButton simpleButton2;
        private Modules.FileSystemViewer fileSystemViewer1;
        private XtraEditors.PanelControl pnlProgress;
        private XtraEditors.LabelControl lblTotalFilesCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

    }
}
