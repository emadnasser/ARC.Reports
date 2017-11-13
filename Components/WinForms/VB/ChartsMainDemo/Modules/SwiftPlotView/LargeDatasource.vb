Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.SwiftPlotView
	Partial Public Class LargeDataSourceDemo
		Inherits ChartDemoBase
		Private pointCount As Integer
		Private newPointCount As Integer

		Private ReadOnly Property Series() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property Diagram() As SwiftPlotDiagram
			Get
				Return TryCast(chart.Diagram, SwiftPlotDiagram)
			End Get
		End Property
		Private ReadOnly Property AxisX() As AxisBase
			Get
				Return If(Diagram IsNot Nothing, Diagram.AxisX, Nothing)
			End Get
		End Property
		Private ReadOnly Property AxisY() As AxisBase
			Get
				Return If(Diagram IsNot Nothing, Diagram.AxisY, Nothing)
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

		Private Sub LoadPoints()
			If Series Is Nothing OrElse AxisX Is Nothing Then
				Return
			End If
			Dim value As Double = 0
			Dim random As New Random()
			ChartControl.BeginInit()
			Series.Points.Clear()
			For i As Integer = 0 To pointCount - 1
				Series.Points.Add(New SeriesPoint(CDbl(i), value))
				value += (random.NextDouble() * 10.0 - 5.0)
				If value > 1200 Then
					value -= 500
				End If
				If value < -1200 Then
					value += 500
				End If
			Next i
			AxisX.VisualRange.SetMinMaxValues(pointCount \ 4, 3 * pointCount \ 4)
			AxisX.WholeRange.SetMinMaxValues(0, pointCount)
			AxisY.WholeRange.SetMinMaxValues(-1000, 1000)
			ChartControl.EndInit()
		End Sub
		Private Sub Apply()
			btnApply.Enabled = False
			cmbPointCount.Enabled = False
			lblPointCount.Enabled = False
			pointCount = newPointCount
			Using dlg As New WaitDialogForm("Please Wait", "Loading Data...", New Size(200, 50), ParentForm)
				LoadPoints()
			End Using
			cmbPointCount.Enabled = True
			lblPointCount.Enabled = True
		End Sub
		Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
			Apply()
		End Sub
		Private Sub cmbPointCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbPointCount.SelectedIndexChanged
			newPointCount = Convert.ToInt32(cmbPointCount.EditValue)
			btnApply.Enabled = newPointCount <> pointCount
		End Sub
		Private Sub cmbPointCount_Properties_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles cmbPointCount.Properties.DrawItem
			If e.State = System.Windows.Forms.DrawItemState.Selected Then
				e.Appearance.FillRectangle(e.Cache, e.Bounds)
			End If
			e.Appearance.DrawString(e.Cache, (CInt(Fix(e.Item))).ToString("N0"), e.Bounds)
			e.Handled = True
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			cmbPointCount.Properties.Items.AddRange(New Object() { 10000, 20000, 50000, 100000, 500000, 1000000 })
			cmbPointCount.SelectedIndex = 2
			Apply()
			Dim crosshairPosition As New CrosshairFreePosition()
			crosshairPosition.DockTarget = (CType(ChartControl.Diagram, XYDiagram2D)).DefaultPane
			crosshairPosition.DockCorner = DockCorner.LeftTop
			ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition
			For Each series As Series In chart.Series
				series.CrosshairLabelPattern = "{A} : {V:F2}"
			Next series
		End Sub
	End Class
End Namespace
