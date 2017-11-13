using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class Table : ReportModuleBase {
        public Table() {
            InitializeComponent();
        }
    }

    public class TableViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            var report = new XtraReportsDemos.TableReport.Report();
            SuppressHamburgerImage(report);
            return report;
        }

        void SuppressHamburgerImage(XtraReportsDemos.TableReport.Report report) {
            report.FindControl("xrPictureBox2", false).Visible = false;
            report.FindControl("xrLabel2", false).Visible = false;
        }
    }
}
