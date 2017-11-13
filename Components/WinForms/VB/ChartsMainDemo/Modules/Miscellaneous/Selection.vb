Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class SelectionDemo
		Inherits ChartDemoBase2D
		Private chartBars As ChartControl
		Private colorIndices As Dictionary(Of String, Integer)
		Private paletteIndices As New List(Of Integer)()
		Private pieSeries As Series

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chartBars
			End Get
		End Property
		Public Overrides ReadOnly Property ExportedObject() As Object
			Get
				Return Nothing
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Me.comboBoxEditSelectionMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(ElementSelectionMode)))
			Me.comboBoxEditSelectionMode.SelectedIndex = 2
		End Sub

		Private Sub InitPieChart()
			pieSeries = New Series("Total", ViewType.Pie)
			pieSeries.ArgumentDataMember = "Region"
			pieSeries.ValueDataMembers.AddRange("Sales")
			pieSeries.SummaryFunction = "SUM([Sales])"
			pieSeries.LegendTextPattern = "{A} {VP:P}"
			pieSeries.LabelsVisibility = DefaultBoolean.False
			pieSeries.ToolTipEnabled = DefaultBoolean.True
			pieSeries.DataSource = DevAV.GetSales()
			chartTotal.Series.Clear()
			chartTotal.Series.Add(pieSeries)
			chartTotal.SeriesSelectionMode = SeriesSelectionMode.Point
			AddHandler chartTotal.SelectedItemsChanged, AddressOf ChartTotal_SelectedItemsChanged

			AddHandler chartTotal.BoundDataChanged, AddressOf ChartTotal_BoundDataChanged
		End Sub
		Private Sub InitBarChart()
			chartBars.SelectionMode = ElementSelectionMode.None
			chartBars.DataSource = DevAV.GetSales()
			chartBars.SeriesDataMember = "Region"
			chartBars.Legend.Visibility = DefaultBoolean.False
			chartBars.SeriesTemplate.ArgumentDataMember = "Year"
			chartBars.SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.Or
			AddHandler chartBars.BoundDataChanged, AddressOf ChartBars_BoundDataChanged
			chartBars.SeriesTemplate.CrosshairLabelPattern = "{S} : {V}"
			Dim diagram As XYDiagram = TryCast(Me.chartBars.Diagram, XYDiagram)
			If diagram IsNot Nothing Then
				diagram.AxisX.Title.Text = "Years"
				diagram.AxisX.Label.Staggered = False
				diagram.AxisY.GridLines.MinorVisible = True
				diagram.AxisY.Title.Text = "Millions of Dollars"
				diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
				diagram.AxisY.Alignment = AxisAlignment.Far
			End If
		End Sub
		Private Sub InitColorIndices()
			colorIndices = New Dictionary(Of String, Integer)()
			For i As Integer = 0 To pieSeries.Points.Count - 1
				colorIndices.Add(pieSeries.Points(i).Argument, i)
			Next i
		End Sub
		Private Sub FilterSeries()
			paletteIndices = New List(Of Integer)()
			Dim filters As New List(Of DataFilter)()
			chartBars.SeriesTemplate.DataFilters.Clear()
			For Each dataList As List(Of Object) In chartTotal.SelectedItems
				If dataList.Count > 0 Then
					Dim dataRowView As DataRowView = TryCast(dataList(0), DataRowView)
					Dim region As String = dataRowView.Row.Field(Of String)("Region")
					Dim selectedSeriesFilter As New DataFilter("Region", GetType(String).FullName, DataFilterCondition.Equal, region)
					filters.Add(selectedSeriesFilter)
					paletteIndices.Add(colorIndices(region))
				End If
			Next dataList
			chartBars.SeriesTemplate.DataFilters.AddRange(filters.ToArray())
		End Sub
		Private Sub UpdateSeriesColors(ByVal paletteIndices As List(Of Integer))
			Dim paletteEntries() As PaletteEntry = chartTotal.GetPaletteEntries(chartTotal.Series(0).Points.Count)
			For i As Integer = 0 To paletteIndices.Count - 1
				chartBars.Series(i).View.Color = paletteEntries(paletteIndices(i)).Color
			Next i
		End Sub
		Private Sub ChartTotal_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
			InitColorIndices()
		End Sub
		Private Sub ChartBars_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSeriesColors(paletteIndices)
		End Sub
		Private Sub ChartTotal_SelectedItemsChanged(ByVal sender As Object, ByVal e As SelectedItemsChangedEventArgs)
			FilterSeries()
		End Sub
		Private Sub comboBoxEditSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEditSelectionMode.SelectedIndexChanged
			chartTotal.SelectionMode = CType(Me.comboBoxEditSelectionMode.SelectedItem, ElementSelectionMode)
		End Sub
		Private Sub ChartBars_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartTotal.ObjectHotTracked
			If Not(TypeOf e.Object Is Series) Then
				e.Cancel = True
			End If
		End Sub
		Private Sub ChartTotal_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartTotal.ObjectSelected
			If Not(TypeOf e.Object Is Series) Then
				e.Cancel = True
				chartTotal.SelectedItems.Clear()
			End If
		End Sub
		Protected Overrides Sub checkEditShowLabels_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			chartBars.SeriesTemplate.LabelsVisibility = If(ShowLabels, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
			chartBars.CrosshairEnabled = If(checkEditShowLabels.Checked, DefaultBoolean.False, CrosshairEnabled)
			chartTotal.Series(0).LabelsVisibility = chartBars.SeriesTemplate.LabelsVisibility
			chartTotal.ToolTipEnabled = If(ShowLabels, DefaultBoolean.False, DefaultBoolean.True)
			FilterSeries()
		End Sub
		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
			InitPieChart()
			InitBarChart()
		End Sub
		Protected Overrides Sub SetAppearanceName(ByVal appearanceName As String)
			chartTotal.AppearanceName = appearanceName
			chartBars.AppearanceName = appearanceName
			UpdateSeriesColors(paletteIndices)
		End Sub
		Protected Overrides Sub SetPaletteName(ByVal paletteName As String)
			chartTotal.PaletteName = paletteName
			chartBars.PaletteName = paletteName
			UpdateSeriesColors(paletteIndices)
		End Sub
	End Class
End Namespace
