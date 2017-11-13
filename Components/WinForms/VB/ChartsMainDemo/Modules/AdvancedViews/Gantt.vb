Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraCharts.Demos.AdvancedViews
	Partial Public Class GanttDemo
		Inherits ChartDemoBase2D
		Private Shared ReadOnly rightAxisLimit As New DateTime(2006, 11, 13)

		Private WithEvents chart As ChartControl
		Private dragging As Boolean = False
		Private currentCursor As Cursor

		Private ReadOnly Property Diagram() As GanttDiagram
			Get
				Return TryCast(chart.Diagram, GanttDiagram)
			End Get
		End Property
		Private ReadOnly Property PlannedSeries() As Series
			Get
				Return chart.GetSeriesByName("Planned")
			End Get
		End Property
		Private ReadOnly Property CompletedSeries() As Series
			Get
				Return chart.GetSeriesByName("Completed")
			End Get
		End Property
		Private ReadOnly Property ProgressLine() As ConstantLine
			Get
				Return Diagram.AxisY.ConstantLines(0)
			End Get
		End Property
		Private ReadOnly Property HasConstantLine() As Boolean
			Get
				Return Diagram IsNot Nothing AndAlso Diagram.AxisY.ConstantLines.Count > 0
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

		Private Sub SetCursor()
			If currentCursor Is Nothing Then
				currentCursor = chart.Cursor
			End If
			chart.Cursor = Cursors.VSplit
		End Sub
		Private Sub RestoreCursor()
			If currentCursor IsNot Nothing Then
				chart.Cursor = currentCursor
				currentCursor = Nothing
			End If
		End Sub
		Private Sub SetProgressState(ByVal dateTimeValue As DateTime)
			If dateTimeValue > rightAxisLimit Then
				dateTimeValue = rightAxisLimit
			End If
			If CompletedSeries IsNot Nothing AndAlso PlannedSeries IsNot Nothing Then
				CompletedSeries.Points.BeginUpdate()
				CompletedSeries.Points.Clear()
				For Each point As SeriesPoint In PlannedSeries.Points
					Dim plannedStartDate As DateTime = point.DateTimeValues(0)
					If DateTime.Compare(plannedStartDate, dateTimeValue) >= 0 Then
						Continue For
					End If
					Dim plannedFinishDate As DateTime = point.DateTimeValues(1)
					Dim completedFinishDate As DateTime
					If DateTime.Compare(dateTimeValue, plannedFinishDate) > 0 Then
						completedFinishDate = plannedFinishDate
					Else
						completedFinishDate = dateTimeValue
					End If
					CompletedSeries.Points.Add(New SeriesPoint(point.Argument, New DateTime() { plannedStartDate, completedFinishDate }))
				Next point
				CompletedSeries.Points.EndUpdate()
			End If
			If HasConstantLine Then
				ProgressLine.AxisValue = dateTimeValue
			End If
		End Sub
		Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseDown
			If Diagram Is Nothing Then
				Return
			End If
			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
			If (Not coords.IsEmpty) AndAlso HasConstantLine Then
				Dim dif As TimeSpan = If(coords.DateTimeValue > CDate(ProgressLine.AxisValue), coords.DateTimeValue - CDate(ProgressLine.AxisValue), CDate(ProgressLine.AxisValue) - coords.DateTimeValue)
				If dif < TimeSpan.FromDays(1) Then
					dragging = True
					chart.Capture = True
					SetCursor()
				End If
			End If
		End Sub
		Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseUp
			dragging = False
			chart.Capture = False
		End Sub
		Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
			If Diagram Is Nothing Then
				Return
			End If
			If dragging AndAlso (e.Button And MouseButtons.Left) = 0 Then
				dragging = False
				chart.Capture = False
			End If
			Dim coords As DiagramCoordinates = Diagram.PointToDiagram(e.Location)
			If coords.IsEmpty Then
				RestoreCursor()
			Else
				If dragging Then
					SetProgressState(coords.DateTimeValue)
				End If
				Dim dif As TimeSpan = If(coords.DateTimeValue > CDate(ProgressLine.AxisValue), coords.DateTimeValue - CDate(ProgressLine.AxisValue), CDate(ProgressLine.AxisValue) - coords.DateTimeValue)
				If HasConstantLine AndAlso dif < TimeSpan.FromDays(1) Then
					SetCursor()
				Else
					RestoreCursor()
				End If
			End If
		End Sub

		Protected Overrides Sub InitControls()
			MyBase.InitControls()
			ShowLabels = False
		End Sub
		Protected Overrides Function ConstructPopupMenu(ByVal obj As Object, ByVal chartControl As ChartControl) As DXPopupMenu
			Return DXMenuHelper.ConstructGanttMenu(obj, chartControl)
		End Function
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			Dim diagram = CType(ChartControl.Diagram, XYDiagram)
			diagram.AxisY.ConstantLines(0).Visible = False
		End Sub

		Private Sub chart_AnimationEnded(ByVal sender As Object, ByVal e As EventArgs) Handles chart.AnimationEnded
			Dim diagram = CType(ChartControl.Diagram, XYDiagram)
			diagram.AxisY.ConstantLines(0).Visible = True
		End Sub
	End Class
End Namespace
