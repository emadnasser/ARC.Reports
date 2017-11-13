using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class CalculatedFields : ReportModuleBase {
        public CalculatedFields() {
            InitializeComponent();
        }
    }

    public class CalculatedFieldsViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.CalculatedFieldsReport.Report();
        }
    }
}
