using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;

namespace XtraReportsDemos.TableReport {
    public partial class Report : DevExpress.XtraReports.UI.XtraReport {
        public Report() {
            InitializeComponent();
            Name = ReportNames.TableReport;
            DisplayName = ReportNames.TableReport;
        }
    }
}
