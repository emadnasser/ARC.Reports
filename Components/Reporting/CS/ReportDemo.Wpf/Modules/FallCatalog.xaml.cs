using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class FallCatalog : ReportModuleBase {
        public FallCatalog() {
            InitializeComponent();
        }
    }

    public class FallCatalogViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.NorthwindTraders.CatalogReport();
        }
    }
}
