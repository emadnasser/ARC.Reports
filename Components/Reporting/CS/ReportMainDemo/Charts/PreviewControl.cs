using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.Charts {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        public PreviewControl() {
            printControl.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth);
        }

        protected override XtraReport CreateReport() {
            return new Charts.Report();
        }
    }
}
