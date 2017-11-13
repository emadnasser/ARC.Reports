using System;


namespace XtraReportsDemos.NorthwindTraders {
	public class ProductListPreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new ProductListReport();
        }
	}
}

