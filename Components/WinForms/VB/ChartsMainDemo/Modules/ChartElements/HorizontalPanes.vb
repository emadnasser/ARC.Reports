Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class HorizontalPanesDemo
		Inherits ChartDemoBase2D
		Private ReadOnly Property LeftSeries() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property
		Private ReadOnly Property RightSeries() As Series
			Get
				Return chart.Series(1)
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

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub LeftSeriesDataBind()
			If chart.Series.Count > 0 Then
				SeriesDataBind(LeftSeries, Me.dS31.Categories(cbLeftCategory.SelectedIndex))
			End If
		End Sub
		Private Sub RightSeriesDataBind()
			If chart.Series.Count > 1 Then
				SeriesDataBind(RightSeries, Me.dS31.Categories(cbRightCategory.SelectedIndex))
			End If
		End Sub
		Private Sub SeriesDataBind(ByVal series As Series, ByVal row As DS3.CategoriesRow)
			series.Name = row.CategoryName
			series.DataFilters.Clear()
			series.DataFilters.Add(New DataFilter("Products.CategoryID", "System.Int32", DataFilterCondition.Equal, row.CategoryID))
			Dim view As XYDiagramSeriesViewBase = TryCast(series.View, XYDiagramSeriesViewBase)
			If view IsNot Nothing Then
				view.AxisX.Title.Text = series.Name
			End If
		End Sub
		Private Sub cbLeftCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLeftCategory.SelectedIndexChanged
			LeftSeriesDataBind()
		End Sub
		Private Sub cbRightCategory_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRightCategory.SelectedIndexChanged
			RightSeriesDataBind()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			Dim path As String = Utils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(Me.oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				Me.oleDbDataAdapterCategories.Fill(Me.dS31)
				Me.oleDbDataAdapterProducts.Fill(Me.dS31)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			For Each row As DS3.CategoriesRow In Me.dS31.Categories
				Me.cbLeftCategory.Properties.Items.Add(row.CategoryName)
				Me.cbRightCategory.Properties.Items.Add(row.CategoryName)
			Next row
			Me.cbLeftCategory.SelectedIndex = LeftCategoryDefaultIndex
			Me.cbRightCategory.SelectedIndex = RightCategoryDefaultIndex
			LeftSeriesDataBind()
			RightSeriesDataBind()
		End Sub
		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructPaneMenu(obj, chartControl)
		End Function
	End Class
End Namespace
