Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class ProductReports
	Inherits Page

	Public Enum ProductReportKind
		CategorySales
		IntervalGrouping
		AverageSales
		ProductSales
		MultipleSubtotals
		Top3Products
	End Enum

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			UpdatePivotGridFieldLayout()
		End If
	End Sub
	Protected Sub tblDemoKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdatePivotGridFieldLayout()
	End Sub
	Protected Sub ddlIntervalGrouping_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdatePivotGridFieldLayout()
	End Sub
	Protected Sub cbProductSales_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdatePivotGridFieldLayout()
	End Sub
	Protected Sub cbShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		UpdatePivotGridFieldLayout()
	End Sub
	Private Sub UpdatePivotGridFieldLayout()
		Dim index As Integer = If(tblDemoKind.SelectedIndex > -1, tblDemoKind.SelectedIndex, 0)
		ChangePivotGridFieldLayout(CType(index, ProductReportKind))
	End Sub
	Private Sub ChangePivotGridFieldLayout(ByVal kind As ProductReportKind)
		pivotGrid.BeginUpdate()
		For Each field As PivotGridField In pivotGrid.Fields
			field.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
			field.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Ascending
		Next field
		pnlIntervalGrouping.Visible = kind = ProductReportKind.IntervalGrouping
		cbProductSales.Visible = kind = ProductReportKind.ProductSales
		cbShowOthers.Visible = kind = ProductReportKind.Top3Products

		pivotGrid.Fields("Sales").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
		pivotGrid.Fields("Category").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
		pivotGrid.Fields("Category").AreaIndex = 0
		pivotGrid.Fields("Category").TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.AutomaticTotals
		pivotGrid.Fields("AvgSale").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
		pivotGrid.Fields("MinSale").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
		pivotGrid.Fields("AvgSale").Visible = kind = ProductReportKind.AverageSales
		pivotGrid.Fields("MinSale").Visible = kind = ProductReportKind.AverageSales
		pivotGrid.Fields("Product").SortBySummaryInfo.FieldName = ""
		pivotGrid.Fields("Product").TopValueCount = 0

		Select Case kind
			Case ProductReportKind.CategorySales
			Case ProductReportKind.IntervalGrouping
				pivotGrid.Fields("Product").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
				pivotGrid.Fields("Product").AreaIndex = 1
				ApplyIntervalGrouping()
			Case ProductReportKind.AverageSales
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
				pivotGrid.Fields("Quarter").AreaIndex = 0
			Case ProductReportKind.ProductSales
				If (Not cbProductSales.Checked) Then
					pivotGrid.Fields("Category").Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
				End If
				pivotGrid.Fields("Product").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Case ProductReportKind.MultipleSubtotals
				pivotGrid.Fields("Product").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
				pivotGrid.Fields("Product").AreaIndex = 1
				pivotGrid.Fields("Year").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
				pivotGrid.Fields("Year").AreaIndex = 0
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
				pivotGrid.Fields("Quarter").AreaIndex = 1
				pivotGrid.Fields("Category").TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals
			Case ProductReportKind.Top3Products
				pivotGrid.Fields("Product").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
				pivotGrid.Fields("Product").AreaIndex = 1
				pivotGrid.Fields("Product").SortBySummaryInfo.FieldName = "ProductSales"
				pivotGrid.Fields("Product").SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum
				pivotGrid.Fields("Product").SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
				pivotGrid.Fields("Product").TopValueCount = 3
				pivotGrid.Fields("Product").TopValueShowOthers = cbShowOthers.Checked
		End Select
		pivotGrid.Width = If(kind = ProductReportKind.AverageSales, Unit.Empty, Unit.Percentage(100))
		pivotGrid.EndUpdate()
	End Sub
	Private Sub ApplyIntervalGrouping()
		pivotGrid.Fields("Month").Visible = ddlIntervalGrouping.SelectedIndex > 1
		Select Case ddlIntervalGrouping.SelectedIndex
			Case 0
				pivotGrid.Fields("Year").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Case 1
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Case 2
				pivotGrid.Fields("Month").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Case 3
				pivotGrid.Fields("Year").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
				pivotGrid.Fields("Quarter").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
				pivotGrid.Fields("Month").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
		End Select
	End Sub
End Class
