Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class CustomerReports
	Inherits Page

	Public Enum CustomerReportKind
		Customers
		Filtered
		Top2Products
		Top10Customers
	End Enum

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			UpdatePivotGridLayout()
		End If
	End Sub
	Protected Sub tblDemoKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdatePivotGridLayout()
	End Sub
	Protected Sub filterYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyFilter()
	End Sub
	Private Sub UpdatePivotGridLayout()
		Dim index As Integer = If(tblDemoKind.SelectedIndex > -1, tblDemoKind.SelectedIndex, 0)
		ChangePivotGridFieldLayout(CType(index, CustomerReportKind))
	End Sub
	Private Sub ChangePivotGridFieldLayout(ByVal kind As CustomerReportKind)
		pivotGrid.BeginUpdate()
		pivotGrid.Fields("Year").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
		pivotGrid.Fields("Year").AreaIndex = 0
		pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
		pivotGrid.Fields("Quarter").AreaIndex = 1
		pivotGrid.Fields("ProductAmount").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
		pivotGrid.Fields("Customer").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
		pivotGrid.Fields("Customer").AreaIndex = 0
		pivotGrid.Fields("Customer").SortOrder = If(kind = CustomerReportKind.Top10Customers, DevExpress.XtraPivotGrid.PivotSortOrder.Descending, DevExpress.XtraPivotGrid.PivotSortOrder.Ascending)
		pivotGrid.Fields("Customer").TopValueCount = 0
		pivotGrid.Fields("Customer").SortBySummaryInfo.FieldName = ""
		pivotGrid.Fields("ProductName").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
		pivotGrid.Fields("ProductName").SortOrder = If(kind = CustomerReportKind.Top2Products, DevExpress.XtraPivotGrid.PivotSortOrder.Descending, DevExpress.XtraPivotGrid.PivotSortOrder.Ascending)
		pivotGrid.Fields("ProductName").TopValueCount = 0
		pivotGrid.Fields("ProductName").SortBySummaryInfo.FieldName = ""

		filterPanel.Visible = kind = CustomerReportKind.Filtered

		Select Case kind
			Case CustomerReportKind.Customers
			Case CustomerReportKind.Filtered
				pivotGrid.Fields("Customer").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
				pivotGrid.Fields("ProductName").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Case CustomerReportKind.Top2Products
				pivotGrid.Fields("ProductName").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
				pivotGrid.Fields("ProductName").TopValueCount = 2
				pivotGrid.Fields("ProductName").SortBySummaryInfo.FieldName = "ProductAmount"
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
				pivotGrid.Fields("Year").Area = pivotGrid.Fields("Quarter").Area
			Case CustomerReportKind.Top10Customers
				pivotGrid.Fields("Customer").TopValueCount = 10
				pivotGrid.Fields("Customer").SortBySummaryInfo.FieldName = "ProductAmount"
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
				pivotGrid.Fields("Year").Area = pivotGrid.Fields("Quarter").Area
		End Select
		If kind <> CustomerReportKind.Filtered Then
			filterYear.SelectedIndex = 0
			filterQuarter.SelectedIndex = 0
		End If
		ApplyFilter()
		pivotGrid.EndUpdate()
	End Sub
	Private Sub ApplyFilter()
		pivotGrid.BeginUpdate()
		ApplyFilter(pivotGrid.Fields("Year"), filterYear)
		ApplyFilter(pivotGrid.Fields("Quarter"), filterQuarter)
		pivotGrid.EndUpdate()
	End Sub
	Private Sub ApplyFilter(ByVal field As PivotGridField, ByVal filter As ASPxComboBox)
		field.FilterValues.Clear()
		If filter.SelectedIndex > 0 Then
			field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Included
			field.FilterValues.Add(filter.SelectedItem.Value)
		Else
			field.FilterValues.FilterType = DevExpress.XtraPivotGrid.PivotFilterType.Excluded
		End If
	End Sub
End Class
