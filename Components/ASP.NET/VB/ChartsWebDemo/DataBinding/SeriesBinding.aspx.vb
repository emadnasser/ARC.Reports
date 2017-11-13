Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web

Partial Public Class SeriesBinding
	Inherits ChartBasePage
	Private sortFields() As String = { "Products", "Price" }

	Private ReadOnly Property Series() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = Series.LabelsVisibility = DefaultBoolean.True
			PrepareCategoriesComboBox()
			ComboBoxHelper.PrepareComboBox(cbSortOrder, Series.SeriesPointsSorting)
			ComboBoxHelper.PrepareComboBox(cbSortBy, sortFields)
			cbSortBy.SelectedIndex = If(Series.SeriesPointsSortingKey = SeriesPointKey.Value_1, 1, 0)
			SelectCategory()
		End If
		Dim enableSorting As Boolean = cbSortOrder.SelectedIndex <> 0
		cbSortBy.ClientEnabled = enableSorting
		lblSortBy.ClientEnabled = enableSorting
	End Sub
	Private Sub SelectCategory()
		If cbFilterByCategory.Items.Count = 0 Then
			Return
		End If
		Dim categoryId As String = CStr(cbFilterByCategory.SelectedItem.Value)
		Dim id As Integer = Convert.ToInt32(categoryId)
		Series.DataFilters(0).Value = id
	End Sub
	Private Sub PrepareCategoriesComboBox()
		Dim categories As SortedList = RetrieveCategories()
		If categories.Count = 0 Then
			cbFilterByCategory.Enabled = False
			Series.DataFilters.Clear()
		Else
			ComboBoxHelper.PrepareComboBox(cbFilterByCategory, categories)
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		Series.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformFilterByCategoryAction()
		SelectCategory()
	End Sub
	Private Sub PerformSortByAction()
		Series.SeriesPointsSortingKey = If(cbSortBy.SelectedIndex = 1, SeriesPointKey.Value_1, SeriesPointKey.Argument)
	End Sub
	Private Sub PerformSortOrderAction()
		Series.SeriesPointsSorting = GetSelectedSortingMode()
	End Sub
	Private Function GetSelectedSortingMode() As SortingMode
		Return CType(ComboBoxHelper.GetSelectedItem(cbSortOrder, GetType(SortingMode)), SortingMode)
	End Function
	Private Function RetrieveDataView() As DataView
		Const selectCommand As String = "SELECT * from CATEGORIES"
		Using dataSource As New AccessDataSource(AccessDataSource1.DataFile, selectCommand)
			dataSource.DataSourceMode = SqlDataSourceMode.DataSet
			Return CType(dataSource.Select(DataSourceSelectArguments.Empty), DataView)
		End Using
	End Function
	Private Function RetrieveDataRowViewByIndex(ByVal rowIndex As Integer) As DataRowView
		Dim dataView As DataView = RetrieveDataView()
		Return dataView(rowIndex)
	End Function
	Private Function RetrieveCategories() As SortedList
		Dim list As New SortedList()
		Dim dataView As DataView = RetrieveDataView()
		If dataView IsNot Nothing Then
			For Each view As DataRowView In dataView
				Dim categoryId As Integer = CInt(Fix(view.Row("CategoryID")))
				Dim category As String = CStr(view.Row("CategoryName"))
				list(category) = categoryId
			Next view
		End If
		Return list
	End Function
	Private Function CalcMinValue(ByVal series As Series) As Double
		Dim min As Double = Double.MaxValue
		For Each point As SeriesPoint In series.Points
			min = Math.Min(min, point.Values(0))
		Next point
		Return min
	End Function
	Private Function CalcMaxValue(ByVal series As Series) As Double
		Dim max As Double = Double.MinValue
		For Each point As SeriesPoint In series.Points
			max = Math.Max(max, point.Values(0))
		Next point
		Return max
	End Function
	Private Function CalcAverageValue(ByVal series As Series) As Double
		Dim sum As Double = 0
		For Each point As SeriesPoint In series.Points
			sum += point.Values(0)
		Next point
		Return sum / series.Points.Count
	End Function
	Protected Sub WebChartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim dataInfoTitle As ChartTitle = WebChartControl1.Titles(0)
		Dim categoryIndex As Integer = cbFilterByCategory.SelectedIndex
		If categoryIndex >= 0 Then
			Dim categoryName As String = CStr(RetrieveDataRowViewByIndex(categoryIndex)("CategoryName"))
			dataInfoTitle.Text = "Category: " & categoryName
			If Series.Points.Count > 0 Then
				Dim minValue As Double = Math.Round(CalcMinValue(Series), 2)
				Dim maxValue As Double = Math.Round(CalcMaxValue(Series), 2)
				Dim averageValue As Double = Math.Round(CalcAverageValue(Series), 2)
				dataInfoTitle.Text += Constants.vbLf & "Min price: " & minValue.ToString() & Constants.vbLf & "Max price: " & maxValue.ToString() & Constants.vbLf & "Average price: " & averageValue.ToString()
			End If
		Else
			dataInfoTitle.Text = String.Empty
		End If
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "FilterByCategory" Then
			PerformFilterByCategoryAction()
		ElseIf e.Parameter = "SortBy" Then
			PerformSortByAction()
		ElseIf e.Parameter = "SortOrder" Then
			PerformSortOrderAction()
		End If
	End Sub
End Class
