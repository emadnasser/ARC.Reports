using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class VerticalAnchoring : ReportModuleBase {
        public VerticalAnchoring() {
            InitializeComponent();
        }
    }

    public class VerticalAnchoringViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.AnchorVertical.Report();
        }
    }
}
