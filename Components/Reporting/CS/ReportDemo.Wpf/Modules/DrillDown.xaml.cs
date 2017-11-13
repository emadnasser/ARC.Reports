using System;
using DevExpress.XtraReports;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Printing;
using System.Collections.Generic;
using System.Windows.Input;
using XtraReportsDemos.DrillDownReport;
using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Core.Commands;

namespace ReportWpfDemo {
    public partial class DrillDown : ReportModuleBase {
        public DrillDown() {
            InitializeComponent();
        }
    }

    public class DrillDownViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.DrillDownReport.DrillDownReport();
        }
    }
}
