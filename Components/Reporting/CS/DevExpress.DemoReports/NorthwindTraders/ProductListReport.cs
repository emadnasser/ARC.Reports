using System;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.NorthwindTraders {
	public partial class ProductListReport : XtraReport {
		public ProductListReport() {
			InitializeComponent();
			Name = ReportNames.NorthwindTraders_Products;
            DisplayName = ReportNames.NorthwindTraders_Products;
		}
	}
}
