namespace DevExpress.XtraSpellChecker.Demos {
	partial class CheckMemoEdit {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckMemoEdit));
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.ParentContainer = this;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(0, 40);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.HideSelection = false;
            this.spellChecker1.SetShowSpellCheckMenu(this.memoEdit1, true);
            this.memoEdit1.Size = new System.Drawing.Size(716, 356);
            this.spellChecker1.SetSpellCheckerOptions(this.memoEdit1, optionsSpelling1);
            this.memoEdit1.TabIndex = 1;
            this.memoEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEditControlKeyDown);
            // 
            // CheckMemoEdit
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.memoEdit1);
            this.Name = "CheckMemoEdit";
            this.Load += new System.EventHandler(this.CheckMemoEdit_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.memoEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.ComponentModel.IContainer components = null;

	}
}
