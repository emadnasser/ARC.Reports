Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class SortBySummaryDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			SetYearFilter()
		End If
		SetSortBySummary()
	End Sub
	Private Sub SetYearFilter()
		pivotGrid.Fields("Year").FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
		pivotGrid.Fields("Year").FilterValues.Add(1996)
	End Sub
	Private Sub SetSortBySummary()
		For Each field As PivotGridField In pivotGrid.Fields
			If field.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea Then
				field.CellStyle.Font.Bold = False
				field.HeaderStyle.Font.Bold = False
			End If
		Next field
		Dim selectedField As PivotGridField = pivotGrid.Fields(ddlSortByField.SelectedItem.Text)
		If selectedField Is Nothing Then
			Return
		End If
		selectedField.CellStyle.Font.Bold = True
		selectedField.HeaderStyle.Font.Bold = True
		pivotGrid.Fields("Sales_Person").SortBySummaryInfo.FieldName = selectedField.FieldName
		pivotGrid.Fields("Sales_Person").SortBySummaryInfo.SummaryType = selectedField.SummaryType
	End Sub
End Class
