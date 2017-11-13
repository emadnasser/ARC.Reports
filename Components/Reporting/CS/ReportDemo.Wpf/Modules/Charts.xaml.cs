using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class Charts : ReportModuleBase {
        public Charts() {
            InitializeComponent();
        }
    }

    public class ChartsViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.Charts.Report();
        }
    }
}

