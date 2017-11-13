Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.Demos

Partial Public Class PivotGridDemoDBDataContextExt
	Inherits PivotGridDemoDBDataContext
	Private Shared ReadOnly Property ConnectionString() As String
		Get
			Return PivotGridServerModeDataGenerator.Table.ConnectionString
		End Get
	End Property
	Public Sub New()
		MyBase.New(ConnectionString)
	End Sub
End Class
