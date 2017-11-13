using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class ConditionalFormatting : ReportModuleBase {
        public ConditionalFormatting() {
            InitializeComponent();
        }
    }

    public class ConditionalFormattingViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.FormattingRules.Report();
        }
    }
}
