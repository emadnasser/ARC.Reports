namespace DevExpress.XtraSpellChecker.Demos {
	partial class MultipleEditors {
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling4 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.memoAbout = new DevExpress.XtraEditors.MemoEdit();
            this.picPhoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblPosition = new DevExpress.XtraEditors.LabelControl();
            this.lblBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.lblAbout = new DevExpress.XtraEditors.LabelControl();
            this.memoAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAbout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.ParentContainer = this;
            // 
            // memoAbout
            // 
            this.memoAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoAbout.EditValue = "Education includes a BA in psyhology from Colorado State Univercity in 1970.  She" +
    " also completed \"The Art of the Cold Call.\"  Nancy is a member of Toastmasters I" +
    "nternationa.";
            this.memoAbout.Location = new System.Drawing.Point(64, 119);
            this.memoAbout.Margin = new System.Windows.Forms.Padding(2);
            this.memoAbout.Name = "memoAbout";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoAbout, true);
            this.memoAbout.Size = new System.Drawing.Size(530, 297);
            this.spellChecker1.SetSpellCheckerOptions(this.memoAbout, optionsSpelling3);
            this.memoAbout.TabIndex = 5;
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(8, 51);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Properties.AllowFocused = false;
            this.picPhoto.Properties.ReadOnly = true;
            this.picPhoto.Properties.ShowMenu = false;
            this.picPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picPhoto.Properties.ZoomAccelerationFactor = 1D;
            this.picPhoto.Size = new System.Drawing.Size(128, 128);
            this.picPhoto.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(0, 25);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(41, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Location = new System.Drawing.Point(0, 50);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(0, 75);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(0, 117);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(33, 13);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "About:";
            // 
            // memoAddress
            // 
            this.memoAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoAddress.EditValue = "USA, Seattle, 507-20th Ave. E. Apt. 2A";
            this.memoAddress.Location = new System.Drawing.Point(62, 75);
            this.memoAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.memoAddress.Name = "memoAddress";
            this.spellChecker1.SetShowSpellCheckMenu(this.memoAddress, true);
            this.memoAddress.Size = new System.Drawing.Size(534, 37);
            this.spellChecker1.SetSpellCheckerOptions(this.memoAddress, optionsSpelling2);
            this.memoAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.EditValue = "Nancy Davolio";
            this.txtName.Location = new System.Drawing.Point(62, 0);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtName.Name = "txtName";
            this.spellChecker1.SetShowSpellCheckMenu(this.txtName, true);
            this.txtName.Size = new System.Drawing.Size(534, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.txtName, optionsSpelling1);
            this.txtName.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.EditValue = "Sales Reprseentative";
            this.txtPosition.Location = new System.Drawing.Point(62, 25);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtPosition.Name = "txtPosition";
            this.spellChecker1.SetShowSpellCheckMenu(this.txtPosition, true);
            this.txtPosition.Size = new System.Drawing.Size(534, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.txtPosition, optionsSpelling4);
            this.txtPosition.TabIndex = 2;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(1948, 12, 8, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(62, 50);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(101, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.memoAbout, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPosition, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAbout, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPosition, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 418);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // MultipleEditors
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picPhoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MultipleEditors";
            this.Size = new System.Drawing.Size(746, 469);
            this.Load += new System.EventHandler(this.MultipleEditors_Load);
            this.Controls.SetChildIndex(this.picPhoto, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAbout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.MemoEdit memoAbout;
		private DevExpress.XtraEditors.LabelControl lblName;
		private DevExpress.XtraEditors.LabelControl lblPosition;
		private DevExpress.XtraEditors.LabelControl lblBirthDate;
		private DevExpress.XtraEditors.LabelControl lblAddress;
		private DevExpress.XtraEditors.LabelControl lblAbout;
		private DevExpress.XtraEditors.MemoEdit memoAddress;
		private DevExpress.XtraEditors.TextEdit txtName;
		private DevExpress.XtraEditors.TextEdit txtPosition;
		private DevExpress.XtraEditors.DateEdit dateEdit1;
		private DevExpress.XtraEditors.PictureEdit picPhoto;
		private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
