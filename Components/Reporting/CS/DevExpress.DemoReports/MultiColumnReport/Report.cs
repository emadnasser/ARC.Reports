using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraPrinting;

namespace XtraReportsDemos.MultiColumnReport
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : DevExpress.XtraReports.UI.XtraReport
	{
		public Report()
		{
			InitializeComponent();

            Name = ReportNames.MultiColumnReport;
            DisplayName = ReportNames.MultiColumnReport;

            BeforePrint += Report_BeforePrint;
		}

        void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            Report report = sender as Report;
            DetailBand detailBand = report.Bands[BandKind.Detail] as DetailBand;
            if ((bool)report.Parameters["ColumnLayoutParameter"].Value)
                detailBand.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            else
                detailBand.MultiColumn.Layout = ColumnLayout.DownThenAcross;
        }
	}
}
