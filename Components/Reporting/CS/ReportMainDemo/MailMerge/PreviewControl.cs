using System;

namespace XtraReportsDemos.MailMerge
{
	public class PreviewControl : XtraReportsDemos.PreviewControl {
		protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
			return new Report();
		}
	}
}
