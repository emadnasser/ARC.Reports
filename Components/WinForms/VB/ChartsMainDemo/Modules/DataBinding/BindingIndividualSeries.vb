Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class BindingIndividualSeriesDemo
		Inherits ChartDemoBase2D
		Private Structure SortingKeys
			Public Const Argument As String = "Products"
			Public Const Value As String = "Price"
		End Structure

		Private WithEvents chart As ChartControl
		Private WithEvents comboBoxEditFilter As ComboBoxEdit
		Private oleDbConnection1 As OleDbConnection
		Private oleDbDataAdapterCategories As OleDbDataAdapter
		Private oleDbSelectCommand1 As OleDbCommand
		Private oleDbInsertCommand1 As OleDbCommand
		Private oleDbUpdateCommand1 As OleDbCommand
		Private oleDbDeleteCommand1 As OleDbCommand
		Private oleDbSelectCommand2 As OleDbCommand
		Private oleDbInsertCommand2 As OleDbCommand
		Private oleDbUpdateCommand2 As OleDbCommand
		Private oleDbDeleteCommand2 As OleDbCommand
		Private oleDbDataAdapterProducts As OleDbDataAdapter
		Private ds1 As DS
		Private WithEvents comboBoxEditSortOrder As ComboBoxEdit
		Private WithEvents comboBoxEditSortBy As ComboBoxEdit

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEditFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditFilter.SelectedIndexChanged
			If Me.comboBoxEditFilter.SelectedIndex = -1 OrElse Me.chart.Series.Count = 0 Then
				Return
			End If
			Me.chart.Series(0).DataFilters.Clear()
			Dim id As Integer = Me.ds1.Categories(Me.comboBoxEditFilter.SelectedIndex).CategoryID
			Me.chart.Series(0).DataFilters.Add(New DataFilter(Me.ds1.Categories.CategoryIDColumn.ColumnName, id.GetType().FullName, DataFilterCondition.Equal, id))
		End Sub
		Private Sub comboBoxEditSortOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditSortOrder.SelectedIndexChanged
			If Me.comboBoxEditSortOrder.SelectedIndex = -1 OrElse Me.chart.Series.Count = 0 Then
				Return
			End If
			If Me.comboBoxEditSortOrder.Text = SortingMode.Ascending.ToString() Then
				Me.chart.Series(0).SeriesPointsSorting = SortingMode.Ascending
			ElseIf Me.comboBoxEditSortOrder.Text = SortingMode.Descending.ToString() Then
				Me.chart.Series(0).SeriesPointsSorting = SortingMode.Descending
			Else
				Me.chart.Series(0).SeriesPointsSorting = SortingMode.None
			End If
			UpdateControls()
		End Sub
		Private Sub comboBoxEditSortBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditSortBy.SelectedIndexChanged
			If Me.comboBoxEditSortBy.SelectedIndex = -1 OrElse Me.chart.Series.Count = 0 Then
				Return
			End If
			Select Case Me.comboBoxEditSortBy.Text
				Case SortingKeys.Argument
					Me.chart.Series(0).SeriesPointsSortingKey = SeriesPointKey.Argument
				Case SortingKeys.Value
					Me.chart.Series(0).SeriesPointsSortingKey = SeriesPointKey.Value_1
			End Select
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			If chart.Titles.Count = 0 Then
				Return
			End If
			Dim dataInfoTitle As ChartTitle = chart.Titles(0)
			Dim categoryIndex As Integer = Me.comboBoxEditFilter.SelectedIndex
			If categoryIndex >= 0 Then
				Dim categoryName As String = Me.ds1.Categories(categoryIndex).CategoryName
				dataInfoTitle.Text = "Category: " & categoryName
				Dim series As Series = chart.Series(0)
				If series.Points.Count > 0 Then
					Dim minValue As Double = Math.Round(CalcMinValue(series), 2)
					Dim maxValue As Double = Math.Round(CalcMaxValue(series), 2)
					Dim averageValue As Double = Math.Round(CalcAverageValue(series), 2)
					dataInfoTitle.Text += Constants.vbLf & "Min price: " & minValue.ToString() & Constants.vbLf & "Max price: " & maxValue.ToString() & Constants.vbLf & "Average price: " & averageValue.ToString()
				End If
			Else
				dataInfoTitle.Text = String.Empty
			End If
			ChartControl.Animate()
		End Sub
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

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = True
			ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries
			Dim path As String = Utils.GetRelativePath("nwind.mdb")
			If path.Length > 0 Then
				Utils.SetConnectionString(Me.oleDbConnection1, path)
			Else
				XtraMessageBox.Show("The ""nwind.mdb"" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
			Try
				Me.oleDbDataAdapterCategories.Fill(Me.ds1)
				Me.oleDbDataAdapterProducts.Fill(Me.ds1)
			Catch e As OleDbException
				XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End Try
			For Each row As DS.CategoriesRow In Me.ds1.Categories
				Me.comboBoxEditFilter.Properties.Items.Add(row.CategoryName)
			Next row
			Me.comboBoxEditFilter.SelectedIndex = 2
			Me.comboBoxEditSortOrder.Properties.Items.AddRange(New String() { SortingMode.None.ToString(), SortingMode.Ascending.ToString(), SortingMode.Descending.ToString() })
			Me.comboBoxEditSortOrder.SelectedIndex = 1
			Me.comboBoxEditSortBy.Properties.Items.AddRange(New String() { SortingKeys.Argument, SortingKeys.Value })
			Me.comboBoxEditSortBy.SelectedIndex = 1
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			If Me.chart.Series.Count > 0 Then
				Dim sortingEnabled As Boolean = Me.chart.Series(0).SeriesPointsSorting <> SortingMode.None
				Me.comboBoxEditSortBy.Enabled = sortingEnabled
				Me.labelSortBy.Enabled = sortingEnabled
			End If
		End Sub
	End Class
End Namespace
