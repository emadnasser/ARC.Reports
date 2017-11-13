Imports Microsoft.VisualBasic
Imports System.Linq
Imports System.Configuration
Imports System.Collections.Generic
Imports DevExpress.DataAccess.Web
Imports DevExpress.DataAccess.ConnectionParameters

Public Class DataSourceWizardConnectionStringsProvider
	Implements IDataSourceWizardConnectionStringsProvider
	Private connectionStrings As Dictionary(Of String, String)
	Public Sub New()
		connectionStrings = New Dictionary(Of String, String)()
		connectionStrings.Add("Northwind", ConfigurationManager.ConnectionStrings("NWindConnectionString").ConnectionString)
		connectionStrings.Add("Cars", ConfigurationManager.ConnectionStrings("CarsDBConnectionString").ConnectionString)
		connectionStrings.Add("Contacts", ConfigurationManager.ConnectionStrings("ContactsConnectionString").ConnectionString)
		connectionStrings.Add("Countries", ConfigurationManager.ConnectionStrings("CountriesDBConnectionString").ConnectionString)
	End Sub
	Private Function GetConnectionDescriptions() As Dictionary(Of String, String) Implements IDataSourceWizardConnectionStringsProvider.GetConnectionDescriptions
		Return connectionStrings.ToDictionary(Function(k) k.Key, Function(k) k.Key)
	End Function
	Private Function GetDataConnectionParameters(ByVal name As String) As DataConnectionParametersBase Implements IDataSourceWizardConnectionStringsProvider.GetDataConnectionParameters
		Return New CustomStringConnectionParameters(connectionStrings(name))
	End Function
End Class
