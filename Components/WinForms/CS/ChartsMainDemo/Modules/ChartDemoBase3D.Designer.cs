namespace DevExpress.XtraCharts.Demos {
	partial class ChartDemoBase3D {
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
            this.btnDefaultAngles = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnDefaultAngles);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 52;
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(10, 36);
            this.btnDefaultAngles.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.btnDefaultAngles.Name = "btnDefaultAngles";
            this.btnDefaultAngles.Size = new System.Drawing.Size(128, 22);
            this.btnDefaultAngles.TabIndex = 51;
            this.btnDefaultAngles.Text = "Restore Default Angles";
            this.btnDefaultAngles.Click += new System.EventHandler(this.btnDefaultAngles_Click);
            // 
            // ChartDemoBase3D
            // 
            this.Name = "ChartDemoBase3D";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.SimpleButton btnDefaultAngles;

	}
}
