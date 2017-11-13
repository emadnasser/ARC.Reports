using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class BarCodes : ReportModuleBase {
        public BarCodes() {
            InitializeComponent();
        }
    }
    public class BarCodesViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.BarCodes.BarCodeTypesReport();
        }
    }
}
