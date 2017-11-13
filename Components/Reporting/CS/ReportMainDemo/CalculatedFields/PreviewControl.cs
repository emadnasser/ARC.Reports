using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CalculatedFieldsReport {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        public PreviewControl() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }

        protected override XtraReport CreateReport() {
            return new XtraReportsDemos.CalculatedFieldsReport.Report();
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
