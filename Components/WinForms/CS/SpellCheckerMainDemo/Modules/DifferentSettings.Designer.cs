namespace DevExpress.XtraSpellChecker.Demos {
	partial class DifferentSettings {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifferentSettings));
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling4 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grpDescription = new DevExpress.XtraEditors.GroupControl();
            this.mmDescription = new DevExpress.XtraEditors.MemoEdit();
            this.grpInfo = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mmAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrl = new DevExpress.XtraEditors.TextEdit();
            this.picPhoto = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDescription)).BeginInit();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.ParentContainer = this;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grpDescription);
            this.panelControl2.Controls.Add(this.grpInfo);
            this.panelControl2.Controls.Add(this.picPhoto);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(728, 416);
            this.panelControl2.TabIndex = 8;
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.mmDescription);
            this.grpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDescription.Location = new System.Drawing.Point(282, 188);
            this.grpDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(444, 226);
            this.grpDescription.TabIndex = 12;
            this.grpDescription.Text = "Description";
            // 
            // mmDescription
            // 
            this.mmDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmDescription.EditValue = resources.GetString("mmDescription.EditValue");
            this.mmDescription.Location = new System.Drawing.Point(2, 20);
            this.mmDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mmDescription.Name = "mmDescription";
            this.spellChecker1.SetShowSpellCheckMenu(this.mmDescription, true);
            this.mmDescription.Size = new System.Drawing.Size(440, 204);
            this.spellChecker1.SetSpellCheckerOptions(this.mmDescription, optionsSpelling1);
            this.mmDescription.TabIndex = 1;
            this.mmDescription.ToolTip = "default settings";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.tableLayoutPanel1);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpInfo.Location = new System.Drawing.Point(2, 188);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(280, 226);
            this.grpInfo.TabIndex = 11;
            this.grpInfo.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mmAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUrl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 204);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Source:";
            // 
            // mmAddress
            // 
            this.mmAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mmAddress.EditValue = "3131 Las Vegas Blvd S - Las Vegas, NV, United States 89109 ";
            this.mmAddress.Location = new System.Drawing.Point(43, 50);
            this.mmAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mmAddress.Name = "mmAddress";
            this.spellChecker1.SetShowSpellCheckMenu(this.mmAddress, true);
            this.mmAddress.Size = new System.Drawing.Size(231, 152);
            optionsSpelling2.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False;
            optionsSpelling2.IgnoreWordsWithNumbers = DevExpress.Utils.DefaultBoolean.True;
            this.spellChecker1.SetSpellCheckerOptions(this.mmAddress, optionsSpelling2);
            this.mmAddress.TabIndex = 12;
            this.mmAddress.ToolTip = "words with digits are ignored";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.EditValue = "dealer@ferrari.com";
            this.txtEmail.Location = new System.Drawing.Point(43, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.spellChecker1.SetShowSpellCheckMenu(this.txtEmail, true);
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            optionsSpelling3.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False;
            optionsSpelling3.IgnoreEmails = DevExpress.Utils.DefaultBoolean.True;
            this.spellChecker1.SetSpellCheckerOptions(this.txtEmail, optionsSpelling3);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.ToolTip = "emails are ignored";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(2, 26);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "E-mail:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(2, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Dealer:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.EditValue = "www.ferrari-cars.net";
            this.txtUrl.Location = new System.Drawing.Point(43, 2);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUrl.Name = "txtUrl";
            this.spellChecker1.SetShowSpellCheckMenu(this.txtUrl, true);
            this.txtUrl.Size = new System.Drawing.Size(231, 20);
            optionsSpelling4.CheckSelectedTextFirst = DevExpress.Utils.DefaultBoolean.False;
            optionsSpelling4.IgnoreUri = DevExpress.Utils.DefaultBoolean.True;
            this.spellChecker1.SetSpellCheckerOptions(this.txtUrl, optionsSpelling4);
            this.txtUrl.TabIndex = 9;
            this.txtUrl.ToolTip = "Urls are ignored";
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPhoto.Location = new System.Drawing.Point(2, 2);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Properties.ZoomAccelerationFactor = 1D;
            this.picPhoto.Size = new System.Drawing.Size(724, 186);
            this.picPhoto.TabIndex = 0;
            // 
            // DifferentSettings
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DifferentSettings";
            this.Size = new System.Drawing.Size(728, 455);
            this.Load += new System.EventHandler(this.DifferentSettings_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDescription)).EndInit();
            this.grpDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PictureEdit picPhoto;
		private DevExpress.XtraEditors.PanelControl panelControl2;
        private XtraEditors.GroupControl grpDescription;
        private XtraEditors.MemoEdit mmDescription;
        private XtraEditors.GroupControl grpInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.MemoEdit mmAddress;
        private XtraEditors.TextEdit txtEmail;
        private XtraEditors.LabelControl labelControl4;
        private XtraEditors.LabelControl labelControl3;
        private XtraEditors.TextEdit txtUrl;
    }
}
