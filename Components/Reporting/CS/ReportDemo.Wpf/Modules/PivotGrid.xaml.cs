using DevExpress.XtraReports;
using System.Data;
using DevExpress.Xpf.DemoBase;

namespace ReportWpfDemo {
    public partial class PivotGrid : ReportModuleBase {
        public PivotGrid() {
            InitializeComponent();
        }
    }

    public class PivotGridViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.PivotGrid.Report();
        }
    }
}
