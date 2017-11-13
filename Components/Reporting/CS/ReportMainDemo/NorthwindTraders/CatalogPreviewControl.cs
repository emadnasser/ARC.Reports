using System;

namespace XtraReportsDemos.NorthwindTraders {
    public class CatalogPreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new CatalogReport();
        }
    }
}
