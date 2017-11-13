Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
Imports DevExpress.Utils

Partial Public Class DrillDown
	Inherits ChartBasePage
	Private ReadOnly summaryKind() As String = { "Min", "Max", "Average" }
	Private ReadOnly sqlSummaryCommand() As String = { "MIN", "MAX", "AVG" }
	Private ReadOnly Property CategoriesSeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName("Categories")
		End Get
	End Property
	Private ReadOnly Property ProductsSeries() As Series
		Get
			Return WebChartControl1.GetSeriesByName("Products")
		End Get
	End Property
	Private ReadOnly Property IsCategoriesChart() As Boolean
		Get
			Return CategoriesSeries.Visible
		End Get
	End Property

	Private Function RetrieveCategories() As DataView
		Dim selectCommand As String = "SELECT Categories.CategoryName, Categories.CategoryID, " & sqlSummaryCommand(cbSummaryKind.SelectedIndex) & "(Products.UnitPrice) AS AvgPrice FROM Categories, Products WHERE Categories.CategoryID = Products.CategoryID GROUP BY Categories.CategoryName, Categories.CategoryID"
		Using dataSource As New AccessDataSource(AccessDataSource1.DataFile, selectCommand)
			dataSource.DataSourceMode = SqlDataSourceMode.DataSet
			Return CType(dataSource.Select(DataSourceSelectArguments.Empty), DataView)
		End Using
	End Function
	Private Sub BindCategories()
		If IsCategoriesChart Then
			Dim categories As DataView = RetrieveCategories()
			CategoriesSeries.DataSource = categories
			CategoriesSeries.ArgumentDataMember = "CategoryName"
			CategoriesSeries.ValueDataMembers(0) = "AvgPrice"
		Else
			CategoriesSeries.ArgumentDataMember = String.Empty
			CategoriesSeries.ValueDataMembers(0) = String.Empty
		End If
	End Sub
	Private Sub InitProductsChart(ByVal point As SeriesPoint)
		CategoriesSeries.Visible = False
		ProductsSeries.DataFilters(0).Value = CInt(Fix((CType(point.Tag, DataRowView))("CategoryId")))
		ProductsSeries.LegendText = point.Argument
		Dim axisX As AxisXBase = (CType(ProductsSeries.View, XYDiagramSeriesViewBase)).AxisX
		axisX.Label.Angle = 30
		Dim axisY As AxisYBase = (CType(ProductsSeries.View, XYDiagramSeriesViewBase)).AxisY
		axisY.Title.Text = "Price, USD"
		axisY.Title.Visibility = DefaultBoolean.True
		WebChartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
		WebChartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Top
		WebChartControl1.Legend.Margins.All = 10
		WebChartControl1.Titles(0).Visibility = DefaultBoolean.False
		WebChartControl1.Titles(1).Visibility = DefaultBoolean.True
		If WebChartControl1.ToolTipEnabled = DefaultBoolean.True Then
			WebChartControl1.CrosshairEnabled = DefaultBoolean.True
			WebChartControl1.ToolTipEnabled = DefaultBoolean.False
		End If
	End Sub
	Private Sub InitCategoriesChart()
		CategoriesSeries.Visible = True
		WebChartControl1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
		WebChartControl1.Legend.AlignmentVertical = LegendAlignmentVertical.Center
		WebChartControl1.Legend.Margins.All = 5
		WebChartControl1.Titles(0).Visibility = DefaultBoolean.True
		WebChartControl1.Titles(1).Visibility = DefaultBoolean.False
		If WebChartControl1.CrosshairEnabled = DefaultBoolean.True Then
			WebChartControl1.ToolTipEnabled = DefaultBoolean.True
			WebChartControl1.CrosshairEnabled = DefaultBoolean.False
		End If
		BindCategories()
	End Sub
	Private Sub InitChartTitle()
		WebChartControl1.Titles(0).Text = summaryKind(cbSummaryKind.SelectedIndex) & " Product Prices by Categories"
	End Sub
	Private Sub PerformSummaryKindAction()
		InitChartTitle()
	End Sub
	Private Sub PerformShowLabelsAction()
		For Each series As Series In WebChartControl1.Series
			series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		Next series
		If WebChartControl1.Series(0).Visible Then
			WebChartControl1.ToolTipEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			WebChartControl1.CrosshairEnabled = DefaultBoolean.False
		Else
			WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
			WebChartControl1.ToolTipEnabled = DefaultBoolean.False
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = CategoriesSeries.LabelsVisibility = DefaultBoolean.True
			ComboBoxHelper.PrepareComboBox(cbSummaryKind, summaryKind)
		End If
		BindCategories()
		If IsCategoriesChart Then
			InitChartTitle()
		End If
	End Sub
	Protected Sub WebChartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
		If IsCategoriesChart Then
			Dim point As SeriesPoint = TryCast(e.AdditionalObject, SeriesPoint)
			If point IsNot Nothing Then
				InitProductsChart(point)
			End If
			e.Cancel = point Is Nothing
		ElseIf e.HitInfo.InChartTitle Then
			InitCategoriesChart()
		End If
	End Sub
	Protected Sub WebChartControl1_CallbackStateLoad(ByVal sender As Object, ByVal e As CallbackStateLoadEventArgs)
		BindCategories()
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "SummaryKind" Then
			PerformSummaryKindAction()
		ElseIf e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		End If
	End Sub
End Class
