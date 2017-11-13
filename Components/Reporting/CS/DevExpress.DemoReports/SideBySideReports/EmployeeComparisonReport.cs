using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace XtraReportsDemos.SideBySideReports {
    public partial class EmployeeComparisonReport : DevExpress.XtraReports.UI.XtraReport {
        public EmployeeComparisonReport() {
            InitializeComponent();
            Name = ReportNames.SideBySideReports;
            DisplayName = ReportNames.SideBySideReports;
        }
        void DisposeReportSource(XRSubreport subreport) {
            XtraReport report = subreport.ReportSource;
            if(report != null && !report.IsDisposed)
                report.Dispose();
        }
        protected override void OnDisposing() {
            DisposeReportSource(xrSubreport1);
            DisposeReportSource(xrSubreport2);
            base.OnDisposing();
        }
    }
}
