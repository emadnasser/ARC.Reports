using System;

namespace XtraReportsDemos.HugeAmountRecords {
	public class PreviewControl : XtraReportsDemos.PreviewControl {

		public PreviewControl() {
			InitializeComponent();
		}
	
		protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
			return new Report();
		}

		private void InitializeComponent() {
			this.SuspendLayout();
			// 
			// PreviewControl
			// 
			this.Name = "PreviewControl";
			this.ResumeLayout(false);
		}
	}

}
