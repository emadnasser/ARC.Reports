using DevExpress.XtraReports;

namespace ReportWpfDemo {
    /// <summary>
    /// Interaction logic for OddEvenStylesReportModule.xaml
    /// </summary>
    public partial class OddEvenStyles : ReportModuleBase {
        public OddEvenStyles() {
            InitializeComponent();
        }
    }

    public class OddEvenStylesViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.OddEvenStyles.Report();
        }
    }
}
