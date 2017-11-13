using DevExpress.XtraReports;

namespace ReportWpfDemo {
    /// <summary>
    /// Interaction logic for InvoiceReportModule.xaml
    /// </summary>
    public partial class Invoice : ReportModuleBase {
        public Invoice() {
            InitializeComponent();
        }
    }

    public class InvoiceViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.NorthwindTraders.InvoiceReport();
        }
    }
}
