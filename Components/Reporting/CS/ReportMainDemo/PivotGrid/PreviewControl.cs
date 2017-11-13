using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;


namespace XtraReportsDemos.PivotGrid
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
		protected override XtraReport CreateReport() {
			return new Report();
		}
	}
}

