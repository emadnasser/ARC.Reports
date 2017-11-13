Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos.DataAnalysis
	Partial Public Class TrendlinesDemo
		Inherits ChartDemoBase2D
		Private trendlineBorder As ConstantLine = Nothing
		Private draggingTrendline As TrendLine = Nothing
		Private selectedTrendline As TrendLine = Nothing
		Private startValueLevelForNext As ValueLevel = ValueLevel.Close
		Private endValueLevelForNext As ValueLevel = ValueLevel.Close
		Private colorForNext As Color = Color.Empty
		Private extrapolateForNext As Boolean = True
		Private valueLevels() As ValueLevel = { ValueLevel.Low, ValueLevel.High, ValueLevel.Open, ValueLevel.Close }

		Private ReadOnly Property StartValueLevel() As ValueLevel
			Get
				Return valueLevels(cbeStarValueLevel.SelectedIndex)
			End Get
		End Property
		Private ReadOnly Property EndValueLevel() As ValueLevel
			Get
				Return valueLevels(cbeEndValueLevel.SelectedIndex)
			End Get
		End Property
		Private ReadOnly Property CurrentSeries() As Series
			Get
				Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
			End Get
		End Property
		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(chart.Diagram, XYDiagram)
			End Get
		End Property
		Private ReadOnly Property View() As FinancialSeriesViewBase
			Get
				Return If(CurrentSeries IsNot Nothing, TryCast(CurrentSeries.View, FinancialSeriesViewBase), Nothing)
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function CalculateArgument(ByVal hitArgument As DateTime) As DateTime
			For i As Integer = 0 To CurrentSeries.Points.Count - 1
				If CurrentSeries.Points(i).DateTimeArgument < hitArgument Then
					Return If(i > 0, CurrentSeries.Points(i - 1).DateTimeArgument, CurrentSeries.Points(i).DateTimeArgument)
				End If
			Next i
			Return If(CurrentSeries.Points.Count > 0, CurrentSeries.Points(CurrentSeries.Points.Count - 1).DateTimeArgument, hitArgument)
		End Function
		Private Sub DeleteSelectedTrendline()
			If View IsNot Nothing AndAlso selectedTrendline IsNot Nothing Then
				View.Indicators.Remove(selectedTrendline)
				selectedTrendline = Nothing
			End If
			UpdateControls()
		End Sub
		Private Sub FillDefaultTrendlines()
			Dim trendline1 As New TrendLine("Trendline 2")
			trendline1.Point1.Argument = New DateTime(2016, 4, 15)
			trendline1.Point1.ValueLevel = ValueLevel.High
			trendline1.Point2.Argument = New DateTime(2016, 6, 12)
			trendline1.Point2.ValueLevel = ValueLevel.High
			trendline1.ExtrapolateToInfinity = False
			View.Indicators.Add(trendline1)

			Dim trendline2 As New TrendLine("Trendline 1")
			trendline2.Point1.Argument = New DateTime(2016, 6, 23)
			trendline2.Point1.ValueLevel = ValueLevel.High
			trendline2.Point2.Argument = New DateTime(2016, 10, 11)
			trendline2.Point2.ValueLevel = ValueLevel.High
			View.Indicators.Add(trendline2)

			Dim trendline3 As New TrendLine("Trendline 3")
			trendline3.Point1.Argument = New DateTime(2016, 3, 20)
			trendline3.Point1.ValueLevel = ValueLevel.Low
			trendline3.Point2.Argument = New DateTime(2016, 5, 13)
			trendline3.Point2.ValueLevel = ValueLevel.Low
			trendline3.ExtrapolateToInfinity = False
			View.Indicators.Add(trendline3)

			Dim trendline4 As New TrendLine("Trendline 4")
			trendline4.Point1.Argument = New DateTime(2016, 6, 27)
			trendline4.Point1.ValueLevel = ValueLevel.Low
			trendline4.Point2.Argument = New DateTime(2016, 10, 31)
			trendline4.Point2.ValueLevel = ValueLevel.Low
			View.Indicators.Add(trendline4)
		End Sub
		Private Sub FillComboBoxEditByValueLevels(ByVal comboboxEdit As ComboBoxEdit, ByVal selectedValueLevel As ValueLevel)
			comboboxEdit.Properties.Items.AddRange(valueLevels)
			comboboxEdit.SelectedItem = selectedValueLevel
		End Sub
		Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseDown
			If View Is Nothing Then
				Return
			End If
			Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
			If TypeOf hitInfo.Indicator Is TrendLine OrElse (Not hitInfo.InDiagram) OrElse e.Button <> MouseButtons.Left Then
				Return
			End If
			chart.SelectionMode = ElementSelectionMode.Single
			selectedTrendline = Nothing
			draggingTrendline = New TrendLine(View.Indicators.GenerateName("Trendline "))
			View.Indicators.Add(draggingTrendline)
			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
			draggingTrendline.Point1.Argument = CalculateArgument(coords.DateTimeArgument)
			draggingTrendline.Point1.ValueLevel = startValueLevelForNext
			draggingTrendline.Point2.Argument = draggingTrendline.Point1.Argument
			draggingTrendline.Point2.ValueLevel = endValueLevelForNext
			draggingTrendline.ExtrapolateToInfinity = False
			draggingTrendline.Color = colorForNext
			trendlineBorder = New ConstantLine()
			trendlineBorder.AxisValue = draggingTrendline.Point1.Argument
			trendlineBorder.LineStyle.DashStyle = DashStyle.Dash
			trendlineBorder.LineStyle.Thickness = 1
			trendlineBorder.ShowInLegend = False
			View.AxisX.ConstantLines.Add(trendlineBorder)
			chart.Capture = True
			Cursor.Current = Cursors.SizeWE
			UpdateControls()
		End Sub
		Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseUp
			If View Is Nothing Then
				Return
			End If
			If draggingTrendline IsNot Nothing Then
				draggingTrendline.ExtrapolateToInfinity = extrapolateForNext
				If draggingTrendline.Point1.Argument.Equals(draggingTrendline.Point2.Argument) Then
					View.Indicators.Remove(draggingTrendline)
				Else
					chart.SetObjectSelection(draggingTrendline)
				End If
				View.AxisX.ConstantLines.Remove(trendlineBorder)
				draggingTrendline = Nothing
			End If
			chart.Capture = False
			Cursor.Current = Cursors.Default
			UpdateControls()
		End Sub
		Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
			If View Is Nothing Then
				Return
			End If
			Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
			If draggingTrendline IsNot Nothing AndAlso e.Button = MouseButtons.Left Then
				If hitInfo.InDiagram Then
					Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
					If (Not coords.IsEmpty) Then
						draggingTrendline.Point2.Argument = CalculateArgument(coords.DateTimeArgument)
						If CDate(draggingTrendline.Point1.Argument) > CDate(draggingTrendline.Point2.Argument) Then
							draggingTrendline.Point1.ValueLevel = EndValueLevel
							draggingTrendline.Point2.ValueLevel = StartValueLevel
						Else
							draggingTrendline.Point1.ValueLevel = StartValueLevel
							draggingTrendline.Point2.ValueLevel = EndValueLevel
						End If
						trendlineBorder.AxisValue = draggingTrendline.Point2.Argument
					End If
				End If
			ElseIf chart.SelectionMode = ElementSelectionMode.None Then
				chart.SelectionMode = ElementSelectionMode.Single
			End If
		End Sub
		Private Sub chart_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles chart.KeyDown
			If e.KeyCode = Keys.Delete Then
				DeleteSelectedTrendline()
			End If
		End Sub
		Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
		   DeleteSelectedTrendline()
		End Sub
		Private Sub btnDeleteAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteAll.Click
			If View IsNot Nothing Then
				View.Indicators.Clear()
			End If
			selectedTrendline = Nothing
			UpdateControls()
		End Sub
		Private Sub cbeStarValueLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeStarValueLevel.SelectedIndexChanged
			If View IsNot Nothing Then
				If selectedTrendline Is Nothing Then
					startValueLevelForNext = StartValueLevel
				Else
					selectedTrendline.Point1.ValueLevel = StartValueLevel
				End If
			End If
		End Sub
		Private Sub cbeEndValueLevel_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeEndValueLevel.SelectedIndexChanged
			If View IsNot Nothing Then
				If selectedTrendline Is Nothing Then
					endValueLevelForNext = EndValueLevel
				Else
					selectedTrendline.Point2.ValueLevel = EndValueLevel
				End If
			End If
		End Sub
		Private Sub cheExtrapolateToInfinity_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheExtrapolateToInfinity.CheckedChanged
			If selectedTrendline Is Nothing Then
				extrapolateForNext = cheExtrapolateToInfinity.Checked
			Else
				selectedTrendline.ExtrapolateToInfinity = cheExtrapolateToInfinity.Checked
			End If
		End Sub
		Private Sub ceColor_CustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs) Handles ceColor.CustomDisplayText
			If CType(e.Value, Color) = Color.Empty Then
				e.DisplayText = "Default"
			End If
		End Sub
		Private Sub ceColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceColor.EditValueChanged
			If selectedTrendline Is Nothing Then
				colorForNext = ceColor.Color
			Else
				selectedTrendline.Color = ceColor.Color
			End If
		End Sub
		Private Sub ceColor_Properties_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles ceColor.Properties.ButtonClick
			If e.Button.Kind = ButtonPredefines.Delete Then
				ceColor.Color = Color.Empty
			End If
		End Sub
		Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chart.BoundDataChanged
			ChartControl.Animate()
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			FillDefaultTrendlines()
			FillComboBoxEditByValueLevels(cbeStarValueLevel, startValueLevelForNext)
			FillComboBoxEditByValueLevels(cbeEndValueLevel, endValueLevelForNext)
			ShowLabels = False
			CurrentSeries.DataSource = MarketPrices.GetAppleStockPrices()
		End Sub
		Protected Overrides Sub OnChartControlObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
			If Not(TypeOf e.Object Is TrendLine) Then
				If (Not chart.Capture) Then
					Cursor = Cursors.Default
				End If
				e.Cancel = True
			ElseIf draggingTrendline Is Nothing Then
				Cursor = Cursors.Hand
			Else
				e.Cancel = True
			End If
		End Sub
		Protected Overrides Sub OnChartControlObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
			If e.HitInfo.InIndicator Then
				selectedTrendline = TryCast(e.HitInfo.Indicator, TrendLine)
			Else
				selectedTrendline = Nothing
			End If
			If selectedTrendline Is Nothing Then
				e.Cancel = True
			End If
			UpdateControls()
		End Sub

		Public Overrides Sub UpdateControls()
			MyBase.UpdateControls()
			btnDelete.Enabled = selectedTrendline IsNot Nothing
			If View IsNot Nothing Then
				btnDeleteAll.Enabled = View.Indicators.Count <> 0
			End If
			If selectedTrendline Is Nothing Then
				cheExtrapolateToInfinity.Checked = extrapolateForNext
				cbeStarValueLevel.SelectedItem = startValueLevelForNext
				cbeEndValueLevel.SelectedItem = endValueLevelForNext
				ceColor.Color = colorForNext
			Else
				cheExtrapolateToInfinity.Checked = selectedTrendline.ExtrapolateToInfinity
				cbeStarValueLevel.SelectedItem = selectedTrendline.Point1.ValueLevel
				cbeEndValueLevel.SelectedItem = selectedTrendline.Point2.ValueLevel
				ceColor.Color = selectedTrendline.Color
			End If
		End Sub
	End Class
End Namespace
