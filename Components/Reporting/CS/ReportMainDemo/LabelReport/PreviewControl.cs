using System;

namespace XtraReportsDemos.LabelReport {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new XtraReportsDemos.BarCodes.ProductLabelsReport();
        }
    }
}
