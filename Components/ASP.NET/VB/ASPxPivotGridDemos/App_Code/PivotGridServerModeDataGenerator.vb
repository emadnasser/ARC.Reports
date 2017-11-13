Imports Microsoft.VisualBasic
Imports System.Linq
Imports DevExpress.Web.Demos

Public Class PivotGridServerModeDataGenerator
	Private Shared table_Renamed As DatabaseGenerator.TableData

	Public Shared ReadOnly Property Table() As DatabaseGenerator.TableData
		Get
			Return table_Renamed
		End Get
	End Property

	Public Shared Sub Register()
		table_Renamed = New DatabaseGenerator.TableData()
		table_Renamed.Name = "Sales"
		table_Renamed.ConnectionStringName = "PivotGridServerModeDemoConnectionString"
		table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("Order", Enumerable.Range(1, 600).ToArray()))
		table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("Product", Enumerable.Range(1, 83).ToArray()))
		table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("Quantity", Enumerable.Range(1, 100).ToArray()))
		table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("UnitPrice", Enumerable.Range(1, 100).Select(Function(v) v / 10).ToArray()))
		table_Renamed.RecordCount = 300000
		DatabaseGenerator.RegisterTable("GeneratedServerModeTable", table_Renamed)
	End Sub
End Class
