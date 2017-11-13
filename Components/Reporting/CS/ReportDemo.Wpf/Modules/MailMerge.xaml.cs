using DevExpress.XtraReports;

namespace ReportWpfDemo {
    /// <summary>
    /// Interaction logic for MailMergeReportModule.xaml
    /// </summary>
    public partial class MailMerge : ReportModuleBase {
        public MailMerge() {
            InitializeComponent();
        }
    }

    public class MailMergeViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.MailMerge.Report();
        }
    }
}
