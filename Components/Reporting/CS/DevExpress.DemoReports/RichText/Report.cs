using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using System.IO;

namespace XtraReportsDemos.RichText
{
	public partial class Report : DevExpress.XtraReports.UI.XtraReport
	{
		public Report()
		{
			InitializeComponent();

			Name = ReportNames.RichText;
            DisplayName = ReportNames.RichText;
		}
	}
}
