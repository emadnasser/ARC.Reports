using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class CustomControl : ReportModuleBase {
        public CustomControl() {
            InitializeComponent();
        }
    }

    public class CustomControlViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.CustomDraw.Report();
        }
    }
}
