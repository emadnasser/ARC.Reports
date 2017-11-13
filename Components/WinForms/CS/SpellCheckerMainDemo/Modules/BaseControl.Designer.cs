namespace DevExpress.XtraSpellChecker.Demos {
	partial class BaseTutorialControl {
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
            this.components = new System.ComponentModel.Container();
            this.sharedDictionaryStorage1 = new DevExpress.XtraSpellChecker.SharedDictionaryStorage(this.components);
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.btnCheckSpelling = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en");
            this.spellChecker1.ParentContainer = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Controls.Add(this.btnCheckSpelling);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 39);
            this.panel1.TabIndex = 1;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.Location = new System.Drawing.Point(582, 9);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.AutoWidth = true;
            this.checkEdit1.Properties.Caption = "CheckAsYouType Mode";
            this.checkEdit1.Size = new System.Drawing.Size(134, 19);
            this.checkEdit1.TabIndex = 7;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // btnCheckSpelling
            // 
            this.btnCheckSpelling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckSpelling.AutoSize = true;
            this.btnCheckSpelling.Location = new System.Drawing.Point(0, 8);
            this.btnCheckSpelling.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnCheckSpelling.Name = "btnCheckSpelling";
            this.btnCheckSpelling.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnCheckSpelling.Size = new System.Drawing.Size(149, 22);
            this.btnCheckSpelling.TabIndex = 6;
            this.btnCheckSpelling.Text = "Check Spelling...";
            this.btnCheckSpelling.Click += new System.EventHandler(this.btnCheckSpelling_Click);
            // 
            // BaseTutorialControl
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel1);
            this.Name = "BaseTutorialControl";
            this.Size = new System.Drawing.Size(716, 396);
            this.Load += new System.EventHandler(this.OnTutorialControlLoaded);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		protected DevExpress.XtraSpellChecker.SharedDictionaryStorage sharedDictionaryStorage1;
		protected DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private System.ComponentModel.IContainer components = null;
        protected XtraEditors.SimpleButton btnCheckSpelling;
        protected XtraEditors.CheckEdit checkEdit1;
        protected System.Windows.Forms.Panel panel1;
    }
}
