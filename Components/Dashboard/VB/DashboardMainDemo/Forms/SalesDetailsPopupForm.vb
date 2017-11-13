Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.ObjectModel
Imports System.Linq
Imports DevExpress.DashboardCommon.ViewerData
Imports DevExpress.DashboardWin
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors

Namespace DashboardMainDemo
	Partial Public Class SalesDetailsPopupForm
		Inherits XtraForm
		Private measure As MeasureDescriptor = Nothing
		Private sparklineDimension As DimensionDescriptor = Nothing
		Private data As MultiDimensionalData = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub SetPieData(ByVal data As Object)
			pieChart.DataSource = data
		End Sub
		Public Sub SetChartData(ByVal data As Object)
			barChart.DataSource = data
		End Sub
		Public Sub SetUnitsInStock(ByVal count As Object)
			lblUnitsInStockCount.Text = count.ToString()
		End Sub
		Public Sub SetGridDataSource(ByVal data As Object)
			drillThroughGrid.DataSource = data
		End Sub
		Public Sub PrepareChart(ByVal e As DashboardItemMouseActionEventArgs)
			SetData(e)
			SetActiveMeasure(e)
			SetSparklineDimension(e)
			SetChartSeriesName(e)
		End Sub
		Private Sub SetData(ByVal e As DashboardItemMouseActionEventArgs)
			Me.data = e.Data
		End Sub
		Private Sub SetSparklineDimension(ByVal e As DashboardItemMouseActionEventArgs)
			Dim sparklineAxis As DataAxis = e.Data.GetAxis("Sparkline")
			If sparklineAxis IsNot Nothing Then
				Dim dimensions As DimensionDescriptorCollection = sparklineAxis.Dimensions
				If dimensions.Count > 0 Then
					Me.sparklineDimension = dimensions(0)
				End If
			End If
		End Sub
		Private Sub SetActiveMeasure(ByVal e As DashboardItemMouseActionEventArgs)
			Dim value As AxisPoint = e.GetAxisPoint()
			Dim data As MultiDimensionalData = e.Data
			Dim delta As DeltaDescriptor = e.GetDeltas()(0)
			For Each measure As MeasureDescriptor In data.GetMeasures()
				If measure.ID = delta.ActualMeasureID Then
					Me.measure = measure
				End If
			Next measure
		End Sub
		Private Sub SetChartSeriesName(ByVal e As DashboardItemMouseActionEventArgs)
			barChart.Series(1).Name = If(measure IsNot Nothing, measure.DataMember, String.Empty)
		End Sub
		Private Sub barChart_CustomDrawAxisLabel(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs) Handles barChart.CustomDrawAxisLabel
			If e.Item.Axis.Name = "Primary AxisX" Then
				Dim points As ReadOnlyCollection(Of AxisPoint) = data.GetAxisPointsByDimension(sparklineDimension)
				Dim currentPoint As AxisPoint = points.FirstOrDefault(Function(point) Object.Equals(point.Value, CInt(Fix(e.Item.AxisValueInternal))))
				If currentPoint IsNot Nothing Then
					e.Item.Text = currentPoint.DisplayText
				End If
			Else
				If measure IsNot Nothing Then
					e.Item.Text = measure.Format(e.Item.AxisValue)
				End If
			End If
		End Sub
		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			If e.Column.ColumnType IsNot GetType(Decimal) Then
				Return
			End If
			If measure IsNot Nothing Then
				e.DisplayText = measure.Format(e.CellValue)
			End If
		End Sub

		Private Sub barChart_CustomDrawCrosshair(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawCrosshairEventArgs) Handles barChart.CustomDrawCrosshair
			For Each group As CrosshairElementGroup In e.CrosshairElementGroups
				Dim points As ReadOnlyCollection(Of AxisPoint) = data.GetAxisPointsByDimension(sparklineDimension)
				Dim currentPoint As AxisPoint = points.FirstOrDefault(Function(point) Object.Equals(point.Value, CInt(Fix(group.HeaderElement.SeriesPoints.First().NumericalArgument))))
				If currentPoint IsNot Nothing Then
					group.HeaderElement.Text = currentPoint.DisplayText
				End If
				For Each element As CrosshairElement In group.CrosshairElements
					If measure IsNot Nothing Then
						Dim value As Object = element.AxisLabelElement.AxisValue
						element.LabelElement.Text = element.Series.LegendText & ": " & measure.Format(CDbl(value))
					End If
				Next element
			Next group
		End Sub

		Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerShowEventArgs) Handles toolTipController1.BeforeShow
			If measure IsNot Nothing Then
				e.ToolTip = e.ToolTip & ": " & measure.Format((CType(e.SelectedObject, SeriesPoint)).Values(0))
			End If
		End Sub
	End Class
End Namespace
