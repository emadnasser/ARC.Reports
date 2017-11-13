using DevExpress.XtraReports;
using DevExpress.Xpf.DemoBase;
using System.IO;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ReportWpfDemo {
    public partial class MasterDetail : ReportModuleBase {
        public MasterDetail() {
            InitializeComponent();
        }
    }

    public class MasterDetailViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.MasterDetailReport.Report();
        }
    }
}
