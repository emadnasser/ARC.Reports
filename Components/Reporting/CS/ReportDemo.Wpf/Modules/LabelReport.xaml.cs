using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class LabelReport : ReportModuleBase {
        public LabelReport() {
            InitializeComponent();
        }
    }

    public class LabelReportViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.BarCodes.ProductLabelsReport();
        }
    }
}
