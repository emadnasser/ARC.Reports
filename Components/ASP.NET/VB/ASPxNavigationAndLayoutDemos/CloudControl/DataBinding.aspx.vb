Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class CloudControl_DataBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim sql As String = "select c.Name, c.Area, c.Population from countries AS c"
		If ddlFilter.SelectedItem.Value.ToString() <> "" Then
			sql &= " where " & ddlFilter.SelectedItem.Value.ToString()
		End If
		CountriesDataSource.CommandText = sql
		ASPxCloudControl1.ValueField = ddlValueField.SelectedItem.Value.ToString()
	End Sub

	Protected Sub ASPxCloudControl1_ItemDataBound(ByVal sender As Object, ByVal e As CloudControlItemEventArgs)
		e.Item.Text = e.Item.Text.ToUpper()
	End Sub
End Class
