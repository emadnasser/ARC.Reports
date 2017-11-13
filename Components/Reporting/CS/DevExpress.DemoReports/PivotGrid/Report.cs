using System;

namespace XtraReportsDemos.PivotGrid
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {

		public Report() {
			InitializeComponent();
            Name = ReportNames.PivotGrid;
            DisplayName = ReportNames.PivotGrid;
		}
	}
}
