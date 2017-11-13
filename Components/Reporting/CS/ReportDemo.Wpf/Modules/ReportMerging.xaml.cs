using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Printing;

namespace ReportWpfDemo {
    public partial class ReportMerging : ReportModuleBase {
        public ReportMerging() {
            InitializeComponent();
        }
    }

    public class ReportMergingViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.ReportMerging.MergedReport();
        }
    }
}
