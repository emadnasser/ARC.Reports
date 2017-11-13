using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;


namespace XtraReportsDemos.ShrinkGrow
{
	public class PreviewControl : XtraReportsDemos.PreviewControl
	{
		protected override XtraReport CreateReport() {
			Report report = new Report();
			return report;
		}
	}
}

