Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports System.Threading

Partial Public Class MSAjax_UpdatePanel
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Thread.Sleep(1500)
		End If
	End Sub

	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub
	Protected Sub cbCountry_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Session("Country") = CStr(cbCountry.SelectedValue)
		grid.Selection.UnselectAll()
		grid.PageIndex = 0
		grid.DataBind()
	End Sub
	Protected Sub cbYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim year As Integer = 1995
		Session("AllYears") = Not Integer.TryParse(CStr(cbYear.SelectedValue), year)
		Session("Year") = year
		grid.Selection.UnselectAll()
		grid.PageIndex = 0
		grid.DataBind()
	End Sub
	Public Function GetSelectedAmount() As String
		Dim result As Double = 0
		Dim totals As List(Of Object) = grid.GetSelectedFieldValues("Total")
		For i As Integer = 0 To totals.Count - 1
			If totals(i) Is Nothing OrElse totals(i) Is DBNull.Value Then
				Continue For
			End If
			result += CDbl(totals(i))
		Next i
		Return String.Format("{0:c}", result)
	End Function
End Class
