using DevExpress.XtraReports;
using System.Data;
using System.Collections.ObjectModel;
using DevExpress.Xpf.DemoBase;
using System.Linq;
using System;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Editors;
using System.Windows.Data;
using System.Collections.Generic;

namespace ReportWpfDemo {
    public partial class SideBySideReports : ReportModuleBase {
        public SideBySideReports() {
            InitializeComponent();
        }
    }

    public class SideBySideReportsViewModel : ReportModuleViewModelBase {        
        protected override IReport CreateReport() {
            return new XtraReportsDemos.SideBySideReports.EmployeeComparisonReport();            
        }
    }
}
