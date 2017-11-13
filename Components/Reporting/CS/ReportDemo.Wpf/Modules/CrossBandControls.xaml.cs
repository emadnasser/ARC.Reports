using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class CrossBandControls : ReportModuleBase {
        public CrossBandControls() {
            InitializeComponent();
        }
    }

    public class CrossBandControlsViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.CrossBandControls.Report();
        }
    }
}
