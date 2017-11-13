using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Extensions;

namespace XtraReportsDemos.SideBySideReports {
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new EmployeeComparisonReport();
        }
    }
}
