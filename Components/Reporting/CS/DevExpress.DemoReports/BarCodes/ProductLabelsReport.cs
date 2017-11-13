using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.BarCodes
{
	public partial class ProductLabelsReport : DevExpress.XtraReports.UI.XtraReport
	{
		public ProductLabelsReport()
		{
			InitializeComponent();

			Name = ReportNames.BarCodes_ProductLabels;
            DisplayName = ReportNames.BarCodes_ProductLabels;
        }
	}
}
