Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Web
Imports System.Configuration

Public Class ConnectionStringsProvider
	Implements IDataSourceWizardConnectionStringsProvider
	Private connections As New Dictionary(Of String, DataConnectionParametersBase)()
	Public Sub New()
		For Each connectionStringSettings As ConnectionStringSettings In ConfigurationManager.ConnectionStrings
			Dim connectionString = connectionStringSettings.ConnectionString
			If connectionStringSettings.Name = "NorthwindConnectionString" Then
				connectionString = DevExpress.Internal.DbEngineDetector.PatchConnectionString(connectionString) & ";XpoProvider=MSSqlServer"
			End If
			connections.Add(connectionStringSettings.Name, New CustomStringConnectionParameters(connectionString))
		Next connectionStringSettings
	End Sub

	Private Function GetConnectionDescriptions() As Dictionary(Of String, String) Implements IDataSourceWizardConnectionStringsProvider.GetConnectionDescriptions
		Return connections.Keys.ToDictionary(Function(key) key, Function(value) value)
	End Function

	Private Function GetDataConnectionParameters(ByVal name As String) As DataConnectionParametersBase Implements IDataSourceWizardConnectionStringsProvider.GetDataConnectionParameters
		Return connections(name)
	End Function
End Class
