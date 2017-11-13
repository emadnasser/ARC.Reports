using DevExpress.XtraReports;

namespace ReportWpfDemo {
    /// <summary>
    /// Interaction logic for ProductListReportModule.xaml
    /// </summary>
    public partial class ProductList : ReportModuleBase {
        public ProductList() {
            InitializeComponent();
        }
    }

    public class ProductListViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.NorthwindTraders.ProductListReport();
        }
    }
}
