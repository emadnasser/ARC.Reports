using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;

namespace XtraReportsDemos.MasterDetailReport
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
	{

		public Report()
		{
			InitializeComponent();

			Name = ReportNames.MasterDetailReport;
            DisplayName = ReportNames.MasterDetailReport;
		}

		private void xrTableCell54_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
			((XRControl)sender).Text = ((XRControl)sender).Text.Replace('#', ' ');
		}
	}
}
