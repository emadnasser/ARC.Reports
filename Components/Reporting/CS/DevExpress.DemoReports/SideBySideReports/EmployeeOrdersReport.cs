using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace XtraReportsDemos.SideBySideReports {
    public partial class EmployeeOrdersReport : DevExpress.XtraReports.UI.XtraReport {
        public EmployeeOrdersReport() {
            InitializeComponent();
            Name = ReportNames.SideBySideReports;
            DisplayName = ReportNames.SideBySideReports;
        }
    }
}
