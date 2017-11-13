using DevExpress.XtraReports;

namespace ReportWpfDemo {

    public partial class PivotGridAndChart : ReportModuleBase {
        public PivotGridAndChart() {
            InitializeComponent();
        }
    }

    public class PivotGridAndChartViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.PivotGridAndChart.Report();
        }
    }
}
