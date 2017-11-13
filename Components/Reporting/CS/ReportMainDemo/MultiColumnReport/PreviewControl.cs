using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraPrinting;


namespace XtraReportsDemos.MultiColumnReport
{
    public class PreviewControl : XtraReportsDemos.PreviewControl {
		private System.ComponentModel.IContainer components = null;

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		
			
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		protected override XtraReport CreateReport() {
			return new Report();
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // PreviewControl
            // 
            this.Name = "PreviewControl";
            this.ResumeLayout(false);

		}
		#endregion		
	}
}

