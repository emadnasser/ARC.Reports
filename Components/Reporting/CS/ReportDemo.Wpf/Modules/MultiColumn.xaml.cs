using System.Windows;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting;

namespace ReportWpfDemo {
    public partial class MultiColumn : ReportModuleBase {
        public MultiColumn() {
            InitializeComponent();
        }
    }

    public class MultiColumnViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.MultiColumnReport.Report();
        }
    }
}
