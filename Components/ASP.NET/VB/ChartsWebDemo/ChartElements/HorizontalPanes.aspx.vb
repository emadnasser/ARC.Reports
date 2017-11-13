Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports DevExpress.XtraCharts.Web

Partial Public Class HorizontalPanes
	Inherits ChartBasePage
	Private ReadOnly Property LeftSeries() As Series
		Get
			Return WebChartControl1.Series(0)
		End Get
	End Property
	Private ReadOnly Property RightSeries() As Series
		Get
			Return WebChartControl1.Series(1)
		End Get
	End Property
	Private ReadOnly Property LeftCategoryDefaultIndex() As Integer
		Get
			Return 2
		End Get
	End Property
	Private ReadOnly Property RightCategoryDefaultIndex() As Integer
		Get
			Return 3
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			cbShowLabels.Checked = LeftSeries.LabelsVisibility = DefaultBoolean.True
			PrepareCategoriesComboBox(cbLeftCategory, LeftCategoryDefaultIndex)
			PrepareCategoriesComboBox(cbRightCategory, RightCategoryDefaultIndex)
			SelectCategory(cbLeftCategory, LeftSeries)
			SelectCategory(cbRightCategory, RightSeries)
		End If
	End Sub
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
	Private Sub SelectCategory(ByVal cbCategories As ASPxComboBox, ByVal series As Series)
		If cbCategories.Items.Count = 0 Then
			Return
		End If
		Dim categoryId As Integer = Convert.ToInt32(CStr(cbCategories.SelectedItem.Value))
		Dim categoryName As String = cbCategories.SelectedItem.Text

		series.Name = categoryName
		series.DataFilters.Clear()
		series.DataFilters.Add(New DataFilter("CategoryID", "System.Int32", DataFilterCondition.Equal, categoryId))
		CType(series.View, XYDiagramSeriesViewBase).AxisX.Title.Text = series.Name
	End Sub
	Private Sub PrepareCategoriesComboBox(ByVal cbCategories As ASPxComboBox, ByVal selectedIndex As Integer)
		Dim categories As SortedList = RetrieveCategories()
		If categories.Count = 0 Then
			cbCategories.Enabled = False
		Else
			ComboBoxHelper.PrepareComboBox(cbCategories, categories, selectedIndex)
		End If
	End Sub
	Private Sub PerformShowLabelsAction()
		LeftSeries.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		RightSeries.LabelsVisibility = If(cbShowLabels.Checked, DefaultBoolean.True, DefaultBoolean.False)
		WebChartControl1.CrosshairEnabled = If(cbShowLabels.Checked, DefaultBoolean.False, DefaultBoolean.True)
	End Sub
	Private Sub PerformLeftCategoryAction()
		SelectCategory(cbLeftCategory, LeftSeries)
	End Sub
	Private Sub PerformRightCategoryAction()
		SelectCategory(cbRightCategory, RightSeries)
	End Sub
	Protected Sub WebChartControl1_CustomCallback(ByVal sender As Object, ByVal e As CustomCallbackEventArgs)
		If e.Parameter = "ShowLabels" Then
			PerformShowLabelsAction()
		ElseIf e.Parameter = "LeftCategory" Then
			PerformLeftCategoryAction()
		ElseIf e.Parameter = "RightCategory" Then
			PerformRightCategoryAction()
		End If
	End Sub
End Class
