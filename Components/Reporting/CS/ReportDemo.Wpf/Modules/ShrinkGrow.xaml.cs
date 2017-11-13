using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class ShrinkGrow : ReportModuleBase {
        public ShrinkGrow() {
            InitializeComponent();
        }
    }

    public class ShrinkGrowViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.ShrinkGrow.Report();
        }
    }
}
