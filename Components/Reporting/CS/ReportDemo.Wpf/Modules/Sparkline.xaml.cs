using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class Sparkline : ReportModuleBase {
        public Sparkline() {
            InitializeComponent();
        }
    }
    public class SparklineViewModel : ReportModuleViewModelBase {
        public SparklineViewModel() {
        }

        protected override IReport CreateReport() {
            return new XtraReportsDemos.Sparkline.Report();
        }
    }
}
