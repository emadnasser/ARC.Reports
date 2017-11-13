using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.FormattingRules {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        public PreviewControl() {
            InitializeComponent();
        }
        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.FormattingRules.Report();
        }
        private void InitializeComponent() {
            this.SuspendLayout();
            //
            // PreviewControl
            //
            this.Name = "PreviewControl";
            this.ResumeLayout(false);
        }
    }
}
