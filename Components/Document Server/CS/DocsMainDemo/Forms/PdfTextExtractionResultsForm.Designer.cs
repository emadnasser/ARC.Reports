namespace DevExpress.Docs.Demos
{
	partial class PdfTextExtractionResultsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.memoEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEdit
            // 
            this.memoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit.Location = new System.Drawing.Point(0, 0);
            this.memoEdit.Name = "memoEdit";
            this.memoEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.memoEdit.Properties.Appearance.Options.UseFont = true;
            this.memoEdit.Properties.ReadOnly = true;
            this.memoEdit.Size = new System.Drawing.Size(561, 335);
            this.memoEdit.TabIndex = 0;
            this.memoEdit.UseOptimizedRendering = true;
            // 
            // PdfTextExtractionResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 335);
            this.Controls.Add(this.memoEdit);
            this.Name = "PdfTextExtractionResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Text Extraction";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private XtraEditors.MemoEdit memoEdit;
	}
}
