Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Data
Imports DevExpress.Web

Partial Public Class Summary_SoryBySummary
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		grid.GroupSummarySortInfo.Clear()
		If ddlGroupSummary.SelectedIndex > 0 Then
			Dim sortOrder As ColumnSortOrder = If(ddlGroupSummary.SelectedIndex = 1, ColumnSortOrder.Ascending, ColumnSortOrder.Descending)
			grid.GroupSummarySortInfo.AddRange(New ASPxGroupSummarySortInfo("Country", grid.GroupSummary("Total"), sortOrder))
		End If
	End Sub
	Protected Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As ASPxGridViewColumnDataEventArgs)
		If e.Column.FieldName = "Total" Then
			Dim price As Decimal = CDec(e.GetListSourceFieldValue("UnitPrice"))
			Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"))
			e.Value = price * quantity
		End If
	End Sub
End Class
