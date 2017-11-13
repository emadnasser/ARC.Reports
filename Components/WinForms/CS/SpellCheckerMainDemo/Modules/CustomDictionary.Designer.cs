namespace DevExpress.XtraSpellChecker.Demos {
	partial class CustomDictionary {
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDictionary));
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.mmDictionary = new DevExpress.XtraEditors.MemoEdit();
            this.memText = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmDictionary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = true;
            this.spellChecker1.ParentContainer = this;
            this.spellChecker1.AfterCheck += new DevExpress.XtraSpellChecker.AfterCheckEventHandler(this.spellChecker1_AfterCheck);
            this.spellChecker1.BeforeCheck += new DevExpress.XtraSpellChecker.BeforeCheckEventHandler(this.spellChecker1_BeforeCheck);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.mmDictionary);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "Dictionary";
            this.splitContainerControl1.Panel2.Controls.Add(this.memText);
            this.splitContainerControl1.Panel2.ShowCaption = true;
            this.splitContainerControl1.Panel2.Text = "Type text and press the F7 key to check it ...";
            this.splitContainerControl1.Size = new System.Drawing.Size(724, 472);
            this.splitContainerControl1.SplitterPosition = 288;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // mmDictionary
            // 
            this.spellChecker1.SetCanCheckText(this.mmDictionary, false);
            this.mmDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmDictionary.EditValue = "mesto\r\ndroogs";
            this.mmDictionary.Location = new System.Drawing.Point(0, 0);
            this.mmDictionary.Name = "mmDictionary";
            this.spellChecker1.SetShowSpellCheckMenu(this.mmDictionary, true);
            this.mmDictionary.Size = new System.Drawing.Size(288, 472);
            this.spellChecker1.SetSpellCheckerOptions(this.mmDictionary, optionsSpelling1);
            this.mmDictionary.TabIndex = 0;
            this.mmDictionary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEditControlKeyDown);
            // 
            // memText
            // 
            this.memText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memText.EditValue = resources.GetString("memText.EditValue");
            this.memText.Location = new System.Drawing.Point(0, 0);
            this.memText.Name = "memText";
            this.spellChecker1.SetShowSpellCheckMenu(this.memText, true);
            this.memText.Size = new System.Drawing.Size(431, 472);
            this.spellChecker1.SetSpellCheckerOptions(this.memText, optionsSpelling2);
            this.memText.TabIndex = 1;
            this.memText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnEditControlKeyDown);
            // 
            // CustomDictionary
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "CustomDictionary";
            this.Size = new System.Drawing.Size(724, 512);
            this.Load += new System.EventHandler(this.FormDictionary_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmDictionary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraEditors.MemoEdit mmDictionary;
		private DevExpress.XtraEditors.MemoEdit memText;
		private System.ComponentModel.IContainer components = null;

	}
}
