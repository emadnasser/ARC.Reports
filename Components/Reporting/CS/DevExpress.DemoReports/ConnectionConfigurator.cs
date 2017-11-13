using System;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using DevExpress.Utils;
using System.Globalization;
using DevExpress.DemoData.Helpers;

namespace DevExpress.DemoReports {
    public class ConnectionStringConfigurator {
        const string DataDirectoryMacro = "|DataDirectory|";
        const string SqlClientProviderName = "System.Data.SqlClient";
        const string SQLiteProviderName = "System.Data.SQLite";
        readonly IEnumerable<ConnectionStringSettings> sqlClientConnectionStrings;
        readonly IEnumerable<ConnectionStringSettings> sqliteConnectionStrings;

        public ConnectionStringConfigurator(ConnectionStringSettingsCollection connectionStrings) {
            Guard.ArgumentNotNull(connectionStrings, "connectionStrings");
            this.sqlClientConnectionStrings = GetConnectionStrings(connectionStrings, "", SqlClientProviderName);
            this.sqliteConnectionStrings = GetConnectionStrings(connectionStrings, SQLiteProviderName);
        }

        public ConnectionStringConfigurator SelectDbEngine() {
            foreach(ConnectionStringSettings settingsElement in sqlClientConnectionStrings) {
                var connectionString = settingsElement.ConnectionString;
                var builder = new DbConnectionStringBuilder { ConnectionString = connectionString };
                if(!builder.ContainsKey("AttachDbFilename")) {
                    continue;
                }
                PatchReadOnly(settingsElement);
                settingsElement.ConnectionString = DbEngineDetector.PatchConnectionString(settingsElement.ConnectionString);
            }

            return this;
        }

        public ConnectionStringConfigurator ExpandDataDirectory(Func<string, string> findDataFile) {
            Guard.ArgumentNotNull(findDataFile, "findDataFile");

            foreach(ConnectionStringSettings connectionStringSettings in sqlClientConnectionStrings.Union(sqliteConnectionStrings)) {
                PatchReadOnly(connectionStringSettings);
                connectionStringSettings.ConnectionString = ExpandDataDirectory(connectionStringSettings.ConnectionString, findDataFile);
            }
            return this;
        }

        IEnumerable<ConnectionStringSettings> GetConnectionStrings(ConnectionStringSettingsCollection connectionStrings, params string[] providerNames) {
            List<ConnectionStringSettings> filteredSettings = new List<ConnectionStringSettings>();
            foreach(ConnectionStringSettings settingsElement in connectionStrings)
                if(providerNames.Contains(settingsElement.ProviderName ?? string.Empty))
                    filteredSettings.Add(settingsElement);
            return filteredSettings;
        }

        void PatchReadOnly(ConfigurationElement element) {
            FieldInfo fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(element, false);
        }

        string ExpandDataDirectory(string connectionString, Func<string, string> findDataFile) {
            string dataSource = GetValue(connectionString, "Data Source");
            string attachDbFileName = GetValue(connectionString, "AttachDbFilename");
            if(!attachDbFileName.Contains(DataDirectoryMacro) && !dataSource.Contains(DataDirectoryMacro))
                return connectionString;
            string dbFilePath = null;
            if(dataSource.Contains(DataDirectoryMacro))
                dbFilePath = findDataFile(GetDbFileName(dataSource));
            else if(attachDbFileName.Contains(DataDirectoryMacro))
                dbFilePath = findDataFile(GetDbFileName(attachDbFileName));
            if(string.IsNullOrEmpty(dbFilePath))
                return connectionString;
            dbFilePath = Path.GetFullPath(dbFilePath);
            string dataDirectory = Path.GetDirectoryName(dbFilePath);
            string patchedString = connectionString.Replace(DataDirectoryMacro, dataDirectory);
            return patchedString;
        }

        string GetValue(string connectionString, string key) {
            DbConnectionStringBuilder dbCSB = new DbConnectionStringBuilder() { ConnectionString = connectionString };
            object value;
            if(dbCSB.TryGetValue(key, out value))
                try {
                    return ((IConvertible)value).ToString(CultureInfo.InvariantCulture);
                } catch(InvalidCastException) {
                }
            return "";
        }
        string GetDbFileName(string attachDbFileName) {
            string dbFileName = attachDbFileName.Replace(DataDirectoryMacro, "");
            dbFileName = dbFileName.TrimStart('\\', '/');
            return dbFileName;
        }
    }
}
