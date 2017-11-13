using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class LargeQuantityOfData : ReportModuleBase {
        public LargeQuantityOfData() {
            InitializeComponent();
        }
    }

    public class LargeQuantityOfDataViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.HugeAmountRecords.Report();
        }
    }
}
