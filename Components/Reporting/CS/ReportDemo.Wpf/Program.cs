using System;
using System.Configuration;
using DevExpress.DemoData;
using DevExpress.DemoData.Helpers;
using DevExpress.DemoReports;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Reports.UserDesigner;

namespace ReportWpfDemo {
    public class Program {
        [STAThread]
        static void Main(string[] args) {
            StartupBase.Run<Startup>(null);
        }
    }

    public class Startup : DemoStartup {
        static Startup() {
            ParameterTypeRegistrator.Register<uint>("Unsigned Integer");
        }

        public static void InitDemo() {
            DevExpress.Xpf.Reports.UserDesigner.Extensions.ReportDesignerRibbonDemoButtonHelper.Load();
            PatchDemoReportsConnectionStrings();
        }

        public static void PatchDemoReportsConnectionStrings() {
            string path = DataFilesHelper.FindFile("nwind.db", DataFilesHelper.DataPath);
            string directory = System.IO.Path.GetDirectoryName(path);
            XtraReportsDemos.ConnectionHelper.SetDataDirectory(directory);
            XtraReportsDemos.ConnectionHelper.ApplyDataDirectory(directory);

            Func<string, string> findDataFile = delegate(string fileName) { return DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath); };
            new ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings)
                .SelectDbEngine()
                .ExpandDataDirectory(findDataFile);
        }

        protected override bool DoStartup() {
            PatchDemoReportsConnectionStrings();
            return base.DoStartup();
        }

        protected override bool GetDebug() {
#if DEBUG
            return true;
#else
            return false;
#endif
        }
    }
}
