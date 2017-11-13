using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class Shape : ReportModuleBase {
        public Shape() {
            InitializeComponent();
        }
    }

    public class ShapeViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.Shape.Report();
        }
    }
}
