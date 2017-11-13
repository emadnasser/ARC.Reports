using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Web;
using System.Configuration;

public class ConnectionStringsProvider : IDataSourceWizardConnectionStringsProvider {
    Dictionary<string, DataConnectionParametersBase> connections = new Dictionary<string, DataConnectionParametersBase>();
    public ConnectionStringsProvider() {
        foreach(ConnectionStringSettings connectionStringSettings in ConfigurationManager.ConnectionStrings) {
            var connectionString = connectionStringSettings.ConnectionString;
            if(connectionStringSettings.Name == "NorthwindConnectionString") {
                connectionString = DevExpress.Internal.DbEngineDetector.PatchConnectionString(connectionString) + ";XpoProvider=MSSqlServer";
            }
            connections.Add(connectionStringSettings.Name, new CustomStringConnectionParameters(connectionString));
        }
    }

    Dictionary<string, string> IDataSourceWizardConnectionStringsProvider.GetConnectionDescriptions() {
        return connections.Keys.ToDictionary(key => key, value => value);
    }

    DataConnectionParametersBase IDataSourceWizardConnectionStringsProvider.GetDataConnectionParameters(string name) {
        return connections[name];
    }
}
