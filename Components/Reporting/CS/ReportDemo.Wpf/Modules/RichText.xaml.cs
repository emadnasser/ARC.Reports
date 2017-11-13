using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class RichText : ReportModuleBase {
        public RichText() {
            InitializeComponent();
        }
    }

    public class RichTextViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.RichText.Report();
        }
    }
}
