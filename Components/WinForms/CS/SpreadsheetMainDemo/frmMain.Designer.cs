using System;
namespace DevExpress.XtraSpreadsheet.Demos {
	partial class frmMain {
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
			this.components = new System.ComponentModel.Container();
			this.SuspendLayout();
			// 
			// pnlCaption
			// 
			this.pnlCaption.Location = new System.Drawing.Point(200, 24);
			// 
			// frmMain
			// 
			this.ClientSize = new System.Drawing.Size(950, 650);
			this.Name = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.IContainer components = null;

	}
}
