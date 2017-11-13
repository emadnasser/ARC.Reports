using System;

namespace XtraReportsDemos.NorthwindTraders {
    public class InvoicePreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new InvoiceReport();
        }
    }
}
