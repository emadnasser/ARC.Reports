using System.Linq;
using System.Configuration;
using System.Collections.Generic;
using DevExpress.DataAccess.Web;
using DevExpress.DataAccess.ConnectionParameters;

public class DataSourceWizardConnectionStringsProvider : IDataSourceWizardConnectionStringsProvider {
    Dictionary<string, string> connectionStrings;
    public DataSourceWizardConnectionStringsProvider() {
        connectionStrings = new Dictionary<string, string>();
        connectionStrings.Add("Northwind", ConfigurationManager.ConnectionStrings["NWindConnectionString"].ConnectionString);
        connectionStrings.Add("Cars", ConfigurationManager.ConnectionStrings["CarsDBConnectionString"].ConnectionString);
        connectionStrings.Add("Contacts", ConfigurationManager.ConnectionStrings["ContactsConnectionString"].ConnectionString);
        connectionStrings.Add("Countries", ConfigurationManager.ConnectionStrings["CountriesDBConnectionString"].ConnectionString);
    }
    Dictionary<string, string> IDataSourceWizardConnectionStringsProvider.GetConnectionDescriptions() {
        return connectionStrings.ToDictionary(k => k.Key, k => k.Key);
    }
    DataConnectionParametersBase IDataSourceWizardConnectionStringsProvider.GetDataConnectionParameters(string name) {
        return new CustomStringConnectionParameters(connectionStrings[name]);
    }
}
