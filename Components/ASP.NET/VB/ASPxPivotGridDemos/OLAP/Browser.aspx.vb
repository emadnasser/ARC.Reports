Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Features_OLAP
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim [error] As String = OLAPConnector.TryConnect(pivotGrid)
		If (Not String.IsNullOrEmpty([error])) Then
			Dim errorPanel As Control = OLAPConnector.CreateErrorPanel([error])
			pivotGrid.Parent.Controls.AddAt(0, errorPanel)
		End If
	End Sub
End Class
