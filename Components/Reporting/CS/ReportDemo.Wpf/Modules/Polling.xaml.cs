using System.Collections.Generic;
using DevExpress.XtraReports;
using XtraReportsDemos.PollingReport;
using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;

namespace ReportWpfDemo {
    public partial class Polling : ReportModuleBase {
        public Polling() {
            InitializeComponent();
        }
    }

    public class PollingReportViewModel : ReportModuleViewModelBase {
        readonly IList<ResultingData> data = new List<ResultingData>();
        int pollCount = 3;

        bool IsPollingReportActive { get { return Report is PollingReport; } }

        protected override IReport CreateReport() {
            return !IsPollingReportActive ? CreatePollingReport() : CreateResultingReport();
        }

        XtraReport CreatePollingReport() {
            return new PollingReport();
        }

        XtraReport CreateResultingReport() {
            var resultingReport = new XtraReportsDemos.PollingReport.ResultingReport();
            resultingReport.ResultingReportDS.DataSource = data;
            resultingReport.Parameters["paramPollCount"].Value = ++pollCount;
            return resultingReport;
        }

        public void ChangeReport(DocumentPreviewMouseEventArgs args) {
            if(args.Brick == null)
                return;

            if(!ReferenceEquals(((VisualBrick)args.Brick).BrickOwner, IsPollingReportActive ? ((PollingReport)Report).ResultingLink : ((ResultingReport)Report).PollingLink))
                return;
            if(IsPollingReportActive) {
                ((PollingReport)Report).UpdateData(data);
            }
            Report = CreateReport();
            Report.CreateDocument();
        }
    }
}
