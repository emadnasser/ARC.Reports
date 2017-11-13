using System.IO;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;

namespace ReportWpfDemo {
    public abstract class ReportModuleViewModelBase : ViewModelBase {
        public ReportModuleViewModelBase() {
            ShowDesignerCommand = new DelegateCommand(DoShowDesigner);
        }

        IReport fReport;
        public virtual IReport Report {
            get { return fReport; }
            set {
                var oldValue = fReport;
                if(SetProperty(ref fReport, value, () => Report))
                    OnReportChanged(oldValue);
            }
        }

        public ICommand ShowDesignerCommand { get; private set; }

        protected virtual IWindowService WindowService { get { return null; } }

        static XtraReport CloneReport(XtraReport report) {
            using(var stream = new MemoryStream()) {
                report.SaveLayoutToXml(stream);
                stream.Position = 0;
                return XtraReport.FromStream(stream, true);
            }
        }

        void DoShowDesigner() {
            Report.StopPageBuilding();
            var clonedReport = CloneReport((XtraReport)Report);
            var reportDesignerViewModel = new ReportDesignerViewModel(clonedReport);

            WindowService.Show(typeof(ReportDesignerControl).FullName, reportDesignerViewModel);

            if(reportDesignerViewModel.Saved) {
                Report = CloneReport(reportDesignerViewModel.Report);
                Report.CreateDocument(true);
            }
        }

        void OnReportChanged(IReport oldValue) {
            if(IsInDesignMode)
                return;
            UnsusbscrubeReport(oldValue);
            SubscribeReport(Report);
        }

        public void InitializeReport() {
            Report = CreateReport();
            Report.CreateDocument(true);
        }

        void SubscribeReport(IReport report) {
            report.Do(x => x.PrintingSystemBase.CreateDocumentException += OnCreateDocumentException);
        }

        void UnsusbscrubeReport(IReport report) {
            report.Do(x => x.PrintingSystemBase.CreateDocumentException -= OnCreateDocumentException);
        }

        void OnCreateDocumentException(object sender, DevExpress.XtraPrinting.ExceptionEventArgs args) {
            args.Handled = true;
            Report.StopPageBuilding();
        }

        void ResetDataAdapters(XtraReportBase report) {
            if(report == null)
                return;
            var enumerator = new NestedComponentEnumerator(new object[] { report });
            while(enumerator.MoveNext()) {
                var dataContainer = enumerator.Current as IDataContainer;
                if(dataContainer != null)
                    dataContainer.DataAdapter = null;
                XRSubreport subreport = enumerator.Current as XRSubreport;
                if(subreport != null)
                    ResetDataAdapters(subreport.ReportSource as XtraReportBase);
            }
        }
        protected abstract IReport CreateReport();
    }
}
