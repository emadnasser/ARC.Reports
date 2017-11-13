using System;
using System.Configuration;
using DevExpress.DemoData.Helpers;
using DevExpress.DemoReports;
using DevExpress.XtraReports;

namespace ProductsDemo.Modules {
    public class ReportsModuleViewModel {
        static ReportsModuleViewModel() {
            PatchDemoReportsConnectionStrings();
        }
        public virtual IReport DocumentSource { get; set; }

        public void OnLoaded() {
            UpdateReport();
        }
        public void OnUnloaded() {
            DocumentSource.StopPageBuilding();
        }
        void UpdateReport() {
            DocumentSource = new XtraReportsDemos.MasterDetailReport.Report();
            DocumentSource.CreateDocument(true);
        }
        static void PatchDemoReportsConnectionStrings() {
            Func<string, string> findDataFile = delegate (string fileName) { return DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath); };
            new ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings)
                .SelectDbEngine()
                .ExpandDataDirectory(findDataFile);
        }
    }
}
