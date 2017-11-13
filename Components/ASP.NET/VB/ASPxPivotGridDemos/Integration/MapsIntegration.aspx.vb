Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI

Partial Public Class MapsIntegration
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack AndAlso (Not IsCallback) Then
			pivotGrid.DataBind()
		End If
	End Sub
	Protected Sub pivotGrid_CustomJsProperties(ByVal sender As Object, ByVal e As DevExpress.Web.CustomJSPropertiesEventArgs)
		e.Properties.Add("cpCountrySales", GetCountrySales())
	End Sub
	Private Function GetCountrySales() As Dictionary(Of String, Decimal)
		Dim res As New Dictionary(Of String, Decimal)()
		Dim isColumn As Boolean = fieldCountry.IsColumn
		Dim count As Integer = If(isColumn, pivotGrid.ColumnCount, pivotGrid.RowCount)
		For i As Integer = 0 To count - 1
			Dim country As String = CStr(pivotGrid.GetFieldValue(fieldCountry, i))
			If String.IsNullOrEmpty(country) Then
				Continue For
			End If
			Dim value As Decimal = Convert.ToDecimal(pivotGrid.GetCellValue(If(isColumn, i, pivotGrid.ColumnCount - 1),If(isColumn, pivotGrid.RowCount - 1, i)))
			res.Add(country, value)
		Next i
		Return res
	End Function
End Class
