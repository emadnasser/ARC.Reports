Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class PolarDiagramCustomPaintDemo
		Inherits ChartDemoBase2D
		Private Const ImageWidth As Integer = 64
		Private Const ImageHeight As Integer = 64

		Private target1 As Target
		Private target2 As Target
		Private target3 As Target
		Private random As Random
		Private delayTime As Integer = 0
		Private radius As Integer
		Private center As ControlCoordinates

		Private ReadOnly Property PolarDiagram() As PolarDiagram
			Get
				Return If(chart IsNot Nothing, TryCast(chart.Diagram, PolarDiagram), Nothing)
			End Get
		End Property
		Private ReadOnly Property ShouldProcessTarget() As Boolean
			Get
				Return PolarDiagram IsNot Nothing AndAlso center IsNot Nothing AndAlso PolarDiagram.StartAngleInDegrees = 0 AndAlso PolarDiagram.DrawingStyle = RadarDiagramDrawingStyle.Circle AndAlso chart.Series(0).ValueScaleType = ScaleType.Numerical
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property
		Public Overrides ReadOnly Property AnimateChartControlOnDemoAppear() As Boolean
			Get
				Return False
			End Get
		End Property
		Public ReadOnly Property AxisX() As RadarAxisX
			Get
				Return PolarDiagram.AxisX
			End Get
		End Property
		Public ReadOnly Property AxisY() As RadarAxisY
			Get
				Return PolarDiagram.AxisY
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			random = New Random()
			target1 = New Target(Math.PI / 2, CDbl(AxisX.VisualRange.MaxValue) / 8, CDbl(AxisY.VisualRange.MaxValue) / 2)
			target2 = New Target(0, CDbl(AxisX.VisualRange.MinValue), CDbl(AxisY.VisualRange.MinValue))
			target3 = New Target(-Math.PI / 2, -CDbl(AxisX.VisualRange.MaxValue) / 8, CDbl(AxisY.VisualRange.MaxValue) / 2)
			Using ms As New MemoryStream(My.Resources.CrossCursor)
				chart.Cursor = New Cursor(ms)
			End Using
			timer.Enabled = True
		End Sub

		Private Sub CalculateCircle()
			center = PolarDiagram.DiagramToPoint(CDbl(AxisX.VisualRange.MinValue), CDbl(AxisY.VisualRange.MinValue))
			Dim circlePoint As ControlCoordinates = PolarDiagram.DiagramToPoint(CDbl(AxisX.VisualRange.MinValue), CDbl(AxisY.VisualRange.MaxValue))
			radius = center.Point.Y - circlePoint.Point.Y
		End Sub
		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
			If (Not ShouldProcessTarget) Then
				Return
			End If
			If target1.IsHit AndAlso target2.IsHit AndAlso target3.IsHit Then
				If delayTime > 20 Then
					delayTime = 0
					target1.Recover()
					target2.Recover()
					target3.Recover()
				Else
					delayTime += 1
				End If
			Else
				If (Not target1.IsHit) Then
					MoveTarget(target1)
				End If
				If (Not target2.IsHit) Then
					MoveTarget(target2)
				End If
				If (Not target3.IsHit) Then
					MoveTarget(target3)
				End If
				chart.Invalidate()
			End If
		End Sub
		Private Sub MoveTarget(ByVal target As Target)
			Dim imageCenter As ControlCoordinates = PolarDiagram.DiagramToPoint(target.Argument, target.Value)
			Dim imageCenterX As Integer = imageCenter.Point.X
			Dim imageCenterY As Integer = imageCenter.Point.Y
			Dim stepX, stepY As Integer
			Dim currentRadius As Double
			Dim counter As Integer = 0
			Do
				If counter > 1000 Then
					imageCenterX = center.Point.X
					imageCenterY = center.Point.Y
				End If
				Dim extraAngle As Double = (random.Next(50) - 25) * Math.PI / 180
				target.MovementAngle += extraAngle
				stepX = CInt(Fix(5 * Math.Cos(target.MovementAngle)))
				stepY = CInt(Fix(5 * Math.Sin(target.MovementAngle)))
				Dim deltaX As Integer = center.Point.X - imageCenterX - stepX
				Dim deltaY As Integer = center.Point.Y - imageCenterY - stepY
				currentRadius = Math.Sqrt(deltaX * deltaX + deltaY * deltaY)
				counter += 1
			Loop While currentRadius >= radius
			Dim x As Integer = imageCenterX + stepX
			Dim y As Integer = imageCenterY + stepY
			Dim diagramImageCenter As DiagramCoordinates = PolarDiagram.PointToDiagram(New Point(x, y))
			target.Argument = diagramImageCenter.NumericalArgument
			target.Value = diagramImageCenter.NumericalValue
		End Sub
		Private Sub DrawTarget(ByVal g As Graphics, ByVal target As Target)
			Dim imageCenter As ControlCoordinates = PolarDiagram.DiagramToPoint(target.Argument, target.Value)
			Dim left As Integer = imageCenter.Point.X - ImageWidth \ 2
			Dim top As Integer = imageCenter.Point.Y - ImageHeight \ 2
			g.DrawImage(target.Image, left, top, ImageWidth, ImageHeight)
		End Sub
		Private Sub CheckHit(ByVal x As Integer, ByVal y As Integer, ByVal target As Target)
			Dim imageCenter As ControlCoordinates = PolarDiagram.DiagramToPoint(target.Argument, target.Value)
			Dim left As Integer = imageCenter.Point.X - ImageWidth \ 2
			Dim top As Integer = imageCenter.Point.Y - ImageHeight \ 2
			If (Not target.IsHit) AndAlso left + 13 <= x AndAlso x <= left + ImageWidth - 13 AndAlso top + 8 <= y AndAlso y <= top + ImageHeight - 8 Then
				target.Hit()
			End If
		End Sub
		Private Sub chart_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs) Handles chart.CustomPaint
			If PolarDiagram Is Nothing Then
				Return
			End If
			Dim g As Graphics = e.Graphics
			CalculateCircle()
			DrawTarget(g, target1)
			DrawTarget(g, target2)
			DrawTarget(g, target3)
		End Sub
		Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseDown
			If (Not ShouldProcessTarget) Then
				Return
			End If
			CheckHit(e.X, e.Y, target1)
			CheckHit(e.X, e.Y, target2)
			CheckHit(e.X, e.Y, target3)
		End Sub
	End Class

	Friend Class Target
		Private movementAngle_Renamed As Double
		Private isHit_Renamed As Boolean = False
		Private _value As Double
		Private argument_Renamed As Double
		Private image_Renamed As Image

		Public Property MovementAngle() As Double
			Get
				Return movementAngle_Renamed
			End Get
			Set(ByVal value As Double)
				movementAngle_Renamed = value
			End Set
		End Property
		Public Property IsHit() As Boolean
			Get
				Return isHit_Renamed
			End Get
			Set(ByVal value As Boolean)
				isHit_Renamed = value
			End Set
		End Property
		Public Property Value() As Double
			Get
				Return _value
			End Get
			Set(ByVal value As Double)
				_value = value
			End Set
		End Property
		Public Property Argument() As Double
			Get
				Return argument_Renamed
			End Get
			Set(ByVal value As Double)
				argument_Renamed = value
			End Set
		End Property
		Public Property Image() As Image
			Get
				Return image_Renamed
			End Get
			Set(ByVal value As Image)
				image_Renamed = value
			End Set
		End Property

		Public Sub New(ByVal movementAngle As Double, ByVal argument As Double, ByVal value As Double)
			Me.movementAngle_Renamed = movementAngle
			Me.argument_Renamed = argument
			_value = value
			image_Renamed = My.Resources.Bug
		End Sub

		Public Sub Hit()
			isHit_Renamed = True
			image_Renamed = My.Resources.NoBug
		End Sub
		Public Sub Recover()
			isHit_Renamed = False
			image_Renamed = My.Resources.Bug
		End Sub
	End Class
End Namespace
