Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraCharts

Partial Public Class ChartsIntegration_CustomChartData
	Inherits Page
	Private Enum RowFieldValueExportRule
		ProductName = 0
		CategoryAndProduct = 1
		CategoryEncoded = 2
	End Enum

	Private Shared categories() As String = { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" }

	Private ReadOnly Property ExportRowFieldValuesAsType() As Type
		Get
			Select Case RowExportRule
				Case RowFieldValueExportRule.ProductName, RowFieldValueExportRule.CategoryAndProduct
					Return GetType(String)
				Case RowFieldValueExportRule.CategoryEncoded
					Return GetType(Char)
			End Select
			Return Nothing
		End Get
	End Property
	Private ReadOnly Property RowExportRule() As RowFieldValueExportRule
		Get
			Return CType(RowValueExport.SelectedIndex, RowFieldValueExportRule)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ChartType.Items.AddRange(New ViewType() { ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar, ViewType.SideBySideStackedBar, ViewType.SideBySideFullStackedBar, ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Spline, ViewType.Area, ViewType.SplineArea, ViewType.StackedArea, ViewType.StackedSplineArea, ViewType.FullStackedArea, ViewType.FullStackedSplineArea })
			RowValueExport.Items.AddRange(New String() { "ProductName", "Category/ProductName", "Encoded Product Category" })
			PointLabels.Checked = False
			WebChart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			ASPxPivotGrid.OptionsChartDataSource.ProvideRowFieldValuesAsType = ExportRowFieldValuesAsType
			If (Not IsCallback) Then
				ChartType.SelectedItem = ChartType.Items.FindByText(ViewType.Line.ToString())
				RowValueExport.SelectedIndex = 0
				CellValueThreshold.Value = "100"
				SetChartType("Line")
				ASPxPivotGrid.OptionsPager.PageIndex = 4
			End If
		End If
	End Sub
	Private Sub SetChartType(ByVal text As String)
		WebChart.SeriesTemplate.ChangeView(CType(System.Enum.Parse(GetType(ViewType), text), ViewType))
	End Sub
	Protected Sub PointLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		WebChart.SeriesTemplate.LabelsVisibility = If(PointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
	End Sub
	Protected Sub ChartType_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetChartType(ChartType.SelectedItem.Text)
	End Sub
	Protected Sub ASPxPivotGrid_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs)
		If e.ItemType = DevExpress.XtraPivotGrid.PivotChartItemType.CellItem Then
			If e.Value Is DBNull.Value OrElse CDec(e.Value) < Convert.ToDecimal(CellValueThreshold.Value) Then
				e.Value = 0
			End If
		End If
		If e.ItemType = DevExpress.XtraPivotGrid.PivotChartItemType.RowItem Then
			Dim isCategoryField As Boolean = Object.Equals(e.FieldValueInfo.Field, fieldCategoryName)
			Select Case RowExportRule
				Case RowFieldValueExportRule.ProductName
					If isCategoryField Then
						e.Value = e.FieldValueInfo.Value.ToString() & " Category"
					Else
						e.Value = e.FieldValueInfo.Value
					End If
				Case RowFieldValueExportRule.CategoryAndProduct
					If isCategoryField Then
						e.Value = e.FieldValueInfo.Value.ToString() & "/"c & "Total"
					Else
						e.Value = e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString() & "/"c + e.FieldValueInfo.Value.ToString()
					End If
				Case RowFieldValueExportRule.CategoryEncoded
					Dim categoryName As String = If((isCategoryField), e.FieldValueInfo.Value.ToString(), e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString())
					e.Value = EncodeCategoryName(categoryName)
			End Select
		End If
	End Sub
	Private Function EncodeCategoryName(ByVal categoryName As String) As Char
		For i As Integer = 0 To categories.Length - 1
			If categories(i) = categoryName Then
				Return Convert.ToChar(Convert.ToInt32("A"c) + i)
			End If
		Next i
		Return "Z"c
	End Function
End Class
