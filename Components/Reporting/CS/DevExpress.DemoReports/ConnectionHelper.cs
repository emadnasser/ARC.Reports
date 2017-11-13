using System;
using System.IO;
using DevExpress.Internal;
using System.Security;
namespace XtraReportsDemos {
    public static class ConnectionHelper {
        static string dataDirectoryName = "DataDirectory";
        static string dataDirectoryTag = "|DataDirectory|";

        public static void ApplyDataDirectory(string dataDirectory) {
            ApplyDataDirectory(dataDirectory, true);
        }        
        public static void ApplyDataDirectory(string dataDirectory, bool forcePatch) {
            ApplyDataDirectoryCore(ValidateDirectory(dataDirectory));            
        }
        static void ApplyDataDirectoryCore(string dataDirectory) {
            if(!Directory.Exists(dataDirectory))
                throw new ArgumentException("dataDirectory");

            string name = "countriesDBConnectionString";
            string connection = global::DevExpress.DemoReports.Properties.Settings.Default[name] as string;
            global::DevExpress.DemoReports.Properties.Settings.Default[name] = PatchConnection(connection, dataDirectory);
        }
        public static string PatchConnection(string connectionString, string dataDirectory) {
            return PatchConnectionCore(connectionString, () => dataDirectory);
        }
        public static string PatchConnectionCore(string connectionString, Func<string> getDataDirectory) {
            if(!string.IsNullOrEmpty(connectionString) && connectionString.Contains(dataDirectoryTag))
                return connectionString.Replace(dataDirectoryTag, getDataDirectory());
            return connectionString;
        }
        static string ValidateDirectory(string dataDirectory) {
            string result = Path.GetFullPath(dataDirectory);
            return result.TrimEnd('\\');
        }
        public static string PatchDataDirectory(string connectionString) {
            return PatchConnectionCore(connectionString, GetDataDirectory);
        }
        static string GetDataDirectory() {
            string dataDirectory = AppDomain.CurrentDomain.GetData(dataDirectoryName) as string;
            if(string.IsNullOrEmpty(dataDirectory))
                dataDirectory = AppDomain.CurrentDomain.BaseDirectory;
            return ValidateDirectory(dataDirectory);
        }        
        public static void SetDataDirectory(string directory) {
            AppDomain.CurrentDomain.SetData("DataDirectory", directory);
        }
    }
}
