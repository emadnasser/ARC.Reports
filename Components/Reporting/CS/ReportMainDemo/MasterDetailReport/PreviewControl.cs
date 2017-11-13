using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Native;

namespace XtraReportsDemos.MasterDetailReport
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
		protected override XtraReport CreateReport() {
			MasterDetailReport.Report report = new MasterDetailReport.Report();
			return report;
		}
	}
}

