Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos.CustomDraw
	Partial Public Class XYDiagramCustomPaintDemo
		Inherits ChartDemoBase2D
		Private Shared ReadOnly cluster1Color As Color = Color.FromArgb(89, Color.FromArgb(&Hfda3a3))
		Private Shared ReadOnly cluster1BorderColor As Color = Color.FromArgb(89, Color.FromArgb(&Hb41b1b))
		Private Shared ReadOnly cluster2Color As Color = Color.FromArgb(89, Color.FromArgb(&Ha3befd))
		Private Shared ReadOnly cluster2BorderColor As Color = Color.FromArgb(89, Color.FromArgb(&H1947b3))
		Private Shared ReadOnly cluster3Color As Color = Color.FromArgb(89, Color.FromArgb(&H9dd987))
		Private Shared ReadOnly cluster3BorderColor As Color = Color.FromArgb(89, Color.FromArgb(&H61a647))
		Private Shared ReadOnly selectionRectColor As Color = Color.FromArgb(89, Color.FromArgb(&Hf1ea6f))
		Private Shared ReadOnly selectionRectBorderColor As Color = Color.FromArgb(89, Color.FromArgb(&Hbaa500))

		Private cluster1 As New Cluster()
		Private cluster2 As New Cluster()
		Private cluster3 As New Cluster()
		Private manualCluster As New Cluster()
		Private firstSelectionCorner As Point = Point.Empty
		Private lastSelectionCorner As Point = Point.Empty
		Private selectionRectangle As Rectangle = Rectangle.Empty

		Private ReadOnly Property XYDiagram() As XYDiagram
			Get
				Return (TryCast(chart.Diagram, XYDiagram))
			End Get
		End Property
		Private ReadOnly Property ShouldCreateClusters() As Boolean
			Get
				Return XYDiagram IsNot Nothing AndAlso chart.Series(0).View.GetType().Equals(GetType(PointSeriesView)) AndAlso chart.Series(0).ArgumentScaleType = ScaleType.Numerical
			End Get
		End Property

		Protected Overrides ReadOnly Property CrosshairEnabled() As DefaultBoolean
			Get
				Return DefaultBoolean.False
			End Get
		End Property

		Public Overrides ReadOnly Property ChartControl() As ChartControl
			Get
				Return Me.chart
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			InitSeries()
			cheAutoMode.Checked = True
			ShowLabels = False
		End Sub

		Private Sub InitSeries()
			If chart.Series.Count > 0 Then
				Dim random As New Random()
				chart.Series(0).Points.Clear()
				chart.Series(0).Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 5, 9))
				chart.Series(0).Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 13, 5))
				chart.Series(0).Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 10, 18))
			End If
		End Sub
		Private Sub ProcessAutoClusters()
			Dim points1 As New List(Of PointF)()
			Dim points2 As New List(Of PointF)()
			Dim points3 As New List(Of PointF)()
			DiagramToPointHelper.CalculateClusters(chart.Series(0).Points, points1, points2, points3)
			cluster1.Calculate(points1)
			cluster2.Calculate(points2)
			cluster3.Calculate(points3)
			cluster1.IsClusterSelected = True
			FillListBox(cluster1.SortedPoints)
		End Sub
		Private Sub ProcessManualPoints()
			Dim firstCoordinate As DiagramCoordinates = XYDiagram.PointToDiagram(firstSelectionCorner)
			Dim lastCoordinate As DiagramCoordinates = XYDiagram.PointToDiagram(lastSelectionCorner)
			If firstCoordinate.IsEmpty OrElse lastCoordinate.IsEmpty Then
				Return
			End If
			Dim firstPoint As New PointF(CSng(firstCoordinate.NumericalArgument), CSng(firstCoordinate.NumericalValue))
			Dim lastPoint As New PointF(CSng(lastCoordinate.NumericalArgument), CSng(lastCoordinate.NumericalValue))
			Dim bounds As RectangleF = DiagramToPointHelper.CreateRectangle(firstPoint, lastPoint)
			Dim manualPoints As New List(Of PointF)()
			For Each point As SeriesPoint In chart.Series(0).Points
				Dim x As Single = CSng(point.NumericalArgument)
				Dim y As Single = CSng(point.Values(0))
				If bounds.Contains(x, y) Then
					manualPoints.Add(New PointF(x, y))
				End If
			Next point
			If manualPoints.Count > 0 Then
				manualCluster.Calculate(manualPoints)
				FillListBox(manualCluster.SortedPoints)
			End If
		End Sub
		Private Sub FillListBox(ByVal points As List(Of PointF))
			lbSelectedPoints.Items.Clear()
			For Each point As PointF In points
				lbSelectedPoints.Items.Add(New ListBoxItem(point))
			Next point
		End Sub
		Private Sub ProcessSelection(ByVal point As Point)
			SelectCluster(cluster1, point, cluster2, cluster3)
			SelectCluster(cluster2, point, cluster1, cluster3)
			SelectCluster(cluster3, point, cluster1, cluster2)
		End Sub
		Private Sub SelectCluster(ByVal cluster As Cluster, ByVal point As Point, ByVal inactiveCluster1 As Cluster, ByVal inactiveCluster2 As Cluster)
			Dim screenPoints() As Point = GetScreenPoints(cluster.ContourPoints)
			Dim path As New GraphicsPath()
			path.AddPolygon(screenPoints)
			If (Not cluster.IsClusterSelected) AndAlso path.IsVisible(point) Then
				inactiveCluster1.IsClusterSelected = False
				inactiveCluster2.IsClusterSelected = False
				cluster.IsClusterSelected = True
				FillListBox(cluster.SortedPoints)
			End If
			Return
		End Sub
		Private Function GetRangeMinValue(ByVal range As VisualRange) As Double
			Return CDbl(range.MinValue) - range.SideMarginsValue
		End Function
		Private Function GetRangeMaxValue(ByVal range As VisualRange) As Double
			Return CDbl(range.MaxValue) + range.SideMarginsValue
		End Function
		Private Function CalculateDiagramBounds() As Rectangle
			Dim p1 As Point = XYDiagram.DiagramToPoint(GetRangeMinValue(XYDiagram.AxisX.VisualRange), GetRangeMinValue(XYDiagram.AxisY.VisualRange)).Point
			Dim p2 As Point = XYDiagram.DiagramToPoint(GetRangeMaxValue(XYDiagram.AxisX.VisualRange), GetRangeMaxValue(XYDiagram.AxisY.VisualRange)).Point
			Return DiagramToPointHelper.CreateRectangle(p1, p2)
		End Function
		Private Function GetScreenPoints(ByVal contourPoints As List(Of PointF)) As Point()
			Dim screenPoints(contourPoints.Count - 1) As Point
			For i As Integer = 0 To contourPoints.Count - 1
				screenPoints(i) = XYDiagram.DiagramToPoint(contourPoints(i).X, contourPoints(i).Y).Point
			Next i
			Return screenPoints
		End Function
		Private Sub DrawCluster(ByVal cluster As Cluster, ByVal g As Graphics, ByVal color As Color, ByVal borderColor As Color)
			Dim screenPoints() As Point = GetScreenPoints(cluster.ContourPoints)
			If screenPoints.Length > 0 Then
				If cluster.IsClusterSelected Then
					Dim brush As New HatchBrush(HatchStyle.ForwardDiagonal, color, borderColor)
					g.FillPolygon(brush, screenPoints)
					g.DrawPolygon(New Pen(Color.FromArgb(255, borderColor), 2), screenPoints)
				Else
					g.FillPolygon(New SolidBrush(color), screenPoints)
					g.DrawPolygon(New Pen(borderColor), screenPoints)
				End If
			End If
		End Sub
		Private Sub simpleButtonRandom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonRandom.Click
			If (Not ShouldCreateClusters) Then
				Return
			End If
			InitSeries()
			lbSelectedPoints.Items.Clear()
			If cheAutoMode.Checked Then
				ProcessAutoClusters()
			Else
				manualCluster.Clear()
			End If
			chart.Animate()
			chart.Invalidate()
		End Sub
		Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseDown
			If (Not ShouldCreateClusters) Then
				Return
			End If
			If (Not cheAutoMode.Checked) Then
				Dim bounds As Rectangle = CalculateDiagramBounds()
				If bounds.Contains(e.Location) Then
					lastSelectionCorner = e.Location
					firstSelectionCorner = lastSelectionCorner
				End If
			Else
				ProcessSelection(e.Location)
			End If
		End Sub
		Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
			If (Not ShouldCreateClusters) Then
				Return
			End If
			If (Not firstSelectionCorner.IsEmpty) AndAlso (Not cheAutoMode.Checked) Then
				lastSelectionCorner = DiagramToPointHelper.GetLastSelectionCornerPosition(e.Location, CalculateDiagramBounds())
				If (Not lastSelectionCorner.IsEmpty) AndAlso firstSelectionCorner <> lastSelectionCorner Then
					selectionRectangle = DiagramToPointHelper.CreateRectangle(firstSelectionCorner, lastSelectionCorner)
					chart.Invalidate()
				End If
			End If
		End Sub
		Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseUp
			If (Not ShouldCreateClusters) Then
				Return
			End If
			If (Not cheAutoMode.Checked) Then
				If (Not selectionRectangle.IsEmpty) Then
					ProcessManualPoints()
				End If
				lastSelectionCorner = Point.Empty
				firstSelectionCorner = lastSelectionCorner
				selectionRectangle = Rectangle.Empty
			End If
		End Sub
		Private Sub cheAutoMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cheAutoMode.CheckedChanged
			If (Not ShouldCreateClusters) Then
				Return
			End If
			lbSelectedPoints.Items.Clear()
			If cheAutoMode.Checked Then
				ProcessAutoClusters()
				manualCluster.Clear()
			Else
				cluster1.Clear()
				cluster2.Clear()
				cluster3.Clear()
			End If
			chart.Invalidate()
		End Sub
		Private Sub chart_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs) Handles chart.CustomPaint
			If (Not ShouldCreateClusters) Then
				Return
			End If
			Dim g As Graphics = e.Graphics
			g.SetClip(CalculateDiagramBounds())
			g.SmoothingMode = SmoothingMode.AntiAlias
			DrawCluster(cluster1, g, cluster1Color, cluster1BorderColor)
			DrawCluster(cluster2, g, cluster2Color, cluster2BorderColor)
			DrawCluster(cluster3, g, cluster3Color, cluster3BorderColor)
			Dim screenManualPoints() As Point = GetScreenPoints(manualCluster.ContourPoints)
			If screenManualPoints.Length > 0 Then
				g.FillPolygon(New SolidBrush(cluster3Color), screenManualPoints)
				g.DrawPolygon(New Pen(cluster3BorderColor), screenManualPoints)
			End If
			If (Not selectionRectangle.IsEmpty) Then
				g.FillRectangle(New SolidBrush(selectionRectColor), selectionRectangle)
				g.DrawRectangle(New Pen(selectionRectBorderColor), selectionRectangle)
			End If
		End Sub
	End Class


	Public Class ListBoxItem
		Private point_Renamed As PointF

		Public ReadOnly Property Point() As PointF
			Get
				Return point_Renamed
			End Get
		End Property

		Public Sub New(ByVal point As PointF)
			Me.point_Renamed = point
		End Sub

		Public Overrides Function ToString() As String
			Return String.Format(CultureInfo.CurrentCulture, "X={0,5:F2}  Y={1,5:F2} ", point_Renamed.X, point_Renamed.Y)
		End Function
	End Class


	Public Class Cluster
		Private points_Renamed As New List(Of PointF)()
		Private sortedPoints_Renamed As New List(Of PointF)()
		Private contourPoints_Renamed As New List(Of PointF)()
		Private isClusterSelected_Renamed As Boolean = False

		Public ReadOnly Property Points() As List(Of PointF)
			Get
				Return points_Renamed
			End Get
		End Property
		Public ReadOnly Property SortedPoints() As List(Of PointF)
			Get
				Return sortedPoints_Renamed
			End Get
		End Property
		Public ReadOnly Property ContourPoints() As List(Of PointF)
			Get
				Return contourPoints_Renamed
			End Get
		End Property
		Public Property IsClusterSelected() As Boolean
			Get
				Return isClusterSelected_Renamed
			End Get
			Set(ByVal value As Boolean)
				isClusterSelected_Renamed = value
			End Set
		End Property

		Public Sub Calculate(ByVal points As List(Of PointF))
			Me.points_Renamed = points
			sortedPoints_Renamed = DiagramToPointHelper.Sort(points)
			contourPoints_Renamed = DiagramToPointHelper.CreateClosedCircuit(sortedPoints_Renamed)
			isClusterSelected_Renamed = False
		End Sub
		Public Sub Clear()
			points_Renamed.Clear()
			sortedPoints_Renamed.Clear()
			contourPoints_Renamed.Clear()
			isClusterSelected_Renamed = False
		End Sub
	End Class


	Friend NotInheritable Class DiagramToPointHelper
		Private Const Epsilon As Double = 0.001

		Private Sub New()
		End Sub
		Private Shared Function CalcRandomPoint(ByVal random As Random, ByVal xCenter As Integer, ByVal yCenter As Integer) As PointF
			Const dispersion As Integer = 2
			Const expectedSum As Integer = 6
			Dim point As New PointF()
			Dim sum As Double = 0
			For i As Integer = 0 To 11
				sum += random.NextDouble()
			Next i
			Dim radius As Double = (sum - expectedSum) * dispersion
			Dim angle As Double = random.Next(360) * Math.PI / 180
			point.X = CSng(xCenter + radius * Math.Cos(angle))
			point.Y = CSng(yCenter + radius * Math.Sin(angle))
			Return point
		End Function
		Private Shared Function AreEqual(ByVal point1 As PointF, ByVal point2 As PointF) As Boolean
			Return AreEqual(point1.X, point2.X) AndAlso AreEqual(point1.Y, point2.Y)
		End Function
		Private Shared Function AreEqual(ByVal number1 As Double, ByVal number2 As Double) As Boolean
			Dim difference As Double = number1 - number2
			If Math.Abs(difference) <= Epsilon Then
				Return True
			End If
			Return False
		End Function
		Private Shared Function GetClusterCenter(ByVal cluster As List(Of PointF)) As PointF
			If cluster.Count = 0 Then
				Return PointF.Empty
			End If
			Dim centerX As Single = 0
			Dim centerY As Single = 0
			For Each point As PointF In cluster
				centerX += point.X
				centerY += point.Y
			Next point
			centerX /= cluster.Count
			centerY /= cluster.Count
			Return New PointF(centerX, centerY)
		End Function
		Private Shared Sub CreateUpperArc(ByVal cluster As List(Of PointF), ByVal sortedCluster As List(Of PointF))
			For i As Integer = 1 To cluster.Count - 1
				If i + 1 = cluster.Count Then
					sortedCluster.Add(cluster(i))
					Exit For
				End If
				Dim shouldAddPoint As Boolean = False
				Dim x0 As Single = sortedCluster(sortedCluster.Count - 1).X
				Dim y0 As Single = sortedCluster(sortedCluster.Count - 1).Y
				Dim x1 As Single = cluster(i).X
				Dim y1 As Single = cluster(i).Y
				If x1 = x0 Then
					If y0 < y1 Then
						shouldAddPoint = True
					End If
				Else
					For j As Integer = i + 1 To cluster.Count - 1
						If cluster(j).Y >= CDbl(cluster(j).X - x0) * CDbl(y1 - y0) / CDbl(x1 - x0) + y0 Then
							shouldAddPoint = False
							Exit For
						Else
							shouldAddPoint = True
						End If
					Next j
				End If
				If shouldAddPoint Then
					sortedCluster.Add(cluster(i))
				End If
			Next i
		End Sub
		Private Shared Sub CreateBottomArc(ByVal cluster As List(Of PointF), ByVal sortedCluster As List(Of PointF))
			For i As Integer = cluster.Count - 1 To 0 Step -1
				If i = 0 Then
					sortedCluster.Add(cluster(i))
					Exit For
				End If
				Dim shouldAddPoint As Boolean = False
				Dim x0 As Single = sortedCluster(sortedCluster.Count - 1).X
				Dim y0 As Single = sortedCluster(sortedCluster.Count - 1).Y
				Dim x1 As Single = cluster(i).X
				Dim y1 As Single = cluster(i).Y
				If x1 = x0 Then
					If y0 > y1 Then
						shouldAddPoint = True
					End If
				Else
					For j As Integer = i - 1 To 0 Step -1
						If cluster(j).Y <= CDbl(cluster(j).X - x0) * CDbl(y1 - y0) / CDbl(x1 - x0) + y0 Then
							shouldAddPoint = False
							Exit For
						Else
							shouldAddPoint = True
						End If
					Next j
				End If
				If shouldAddPoint Then
					sortedCluster.Add(cluster(i))
				End If
			Next i
		End Sub

		Public Shared Function CreateRectangle(ByVal corner1 As Point, ByVal corner2 As Point) As Rectangle
			Dim x As Integer = If(corner1.X < corner2.X, corner1.X, corner2.X)
			Dim y As Integer = If(corner1.Y < corner2.Y, corner1.Y, corner2.Y)
			Dim width As Integer = Math.Abs(corner1.X - corner2.X)
			Dim height As Integer = Math.Abs(corner1.Y - corner2.Y)
			Return New Rectangle(x, y, width, height)
		End Function
		Public Shared Function CreateRectangle(ByVal corner1 As PointF, ByVal corner2 As PointF) As RectangleF
			Dim x As Single = If(corner1.X < corner2.X, corner1.X, corner2.X)
			Dim y As Single = If(corner1.Y < corner2.Y, corner1.Y, corner2.Y)
			Dim width As Single = Math.Abs(corner1.X - corner2.X)
			Dim height As Single = Math.Abs(corner1.Y - corner2.Y)
			Return New RectangleF(x, y, width, height)
		End Function
		Public Shared Function GetLastSelectionCornerPosition(ByVal p As Point, ByVal bounds As Rectangle) As Point
			If p.X < bounds.Left Then
				p.X = bounds.Left
			ElseIf p.X > bounds.Right Then
				p.X = bounds.Right - 1
			End If
			If p.Y < bounds.Top Then
				p.Y = bounds.Top
			ElseIf p.Y > bounds.Bottom Then
				p.Y = bounds.Bottom - 1
			End If
			Return p
		End Function
		Public Shared Function CalculatePoints(ByVal random As Random, ByVal count As Integer, ByVal xCenter As Integer, ByVal yCenter As Integer) As SeriesPoint()
			Dim seriesPoints(count - 1) As SeriesPoint
			For i As Integer = 0 To count - 1
				Dim point As PointF = CalcRandomPoint(random, xCenter, yCenter)
				seriesPoints(i) = New SeriesPoint(point.X, New Double() { point.Y })
			Next i
			Return seriesPoints
		End Function
		Public Shared Sub CalculateClusters(ByVal seriesPoints As SeriesPointCollection, ByVal cluster1 As List(Of PointF), ByVal cluster2 As List(Of PointF), ByVal cluster3 As List(Of PointF))
			Dim points As New List(Of PointF)()
			For Each point As SeriesPoint In seriesPoints
				points.Add(New PointF(CSng(point.NumericalArgument), CSng(point.Values(0))))
			Next point
			If points.Count < 100 Then
				Return
			End If
			Dim nextCenter1 As PointF = points(0)
			Dim nextCenter2 As PointF = points(50)
			Dim nextCenter3 As PointF = points(100)
			Dim center1 As PointF
			Dim center2 As PointF
			Dim center3 As PointF
			Do
				center1 = nextCenter1
				center2 = nextCenter2
				center3 = nextCenter3
				cluster1.Clear()
				cluster2.Clear()
				cluster3.Clear()
				For Each point As PointF In points
					Dim x As Single = point.X
					Dim y As Single = point.Y
					Dim distance1 As Double = Math.Sqrt((center1.X - x) * (center1.X - x) + (center1.Y - y) * (center1.Y - y))
					Dim distance2 As Double = Math.Sqrt((center2.X - x) * (center2.X - x) + (center2.Y - y) * (center2.Y - y))
					Dim distance3 As Double = Math.Sqrt((center3.X - x) * (center3.X - x) + (center3.Y - y) * (center3.Y - y))
					If distance1 <= distance2 AndAlso distance1 <= distance3 Then
						cluster1.Add(point)
					ElseIf distance2 <= distance1 AndAlso distance2 <= distance3 Then
						cluster2.Add(point)
					Else
						cluster3.Add(point)
					End If
				Next point
				nextCenter1 = GetClusterCenter(cluster1)
				nextCenter2 = GetClusterCenter(cluster2)
				nextCenter3 = GetClusterCenter(cluster3)
			Loop While (Not AreEqual(center1, nextCenter1)) OrElse (Not AreEqual(center2, nextCenter2)) OrElse Not AreEqual(center3, nextCenter3)
		End Sub
		Public Shared Function Sort(ByVal cluster As List(Of PointF)) As List(Of PointF)
			Dim sortedCluster As New List(Of PointF)()
			If cluster.Count = 0 Then
				Return sortedCluster
			End If
			sortedCluster.Add(cluster(0))
			For i As Integer = 1 To cluster.Count - 1
				If sortedCluster(0).X >= cluster(i).X Then
					sortedCluster.Insert(0, cluster(i))
				ElseIf sortedCluster(sortedCluster.Count - 1).X <= cluster(i).X Then
					sortedCluster.Insert(sortedCluster.Count, cluster(i))
				Else
					For j As Integer = 0 To sortedCluster.Count - 2
						If sortedCluster(j).X <= cluster(i).X AndAlso sortedCluster(j + 1).X >= cluster(i).X Then
							sortedCluster.Insert(j + 1, cluster(i))
							Exit For
						End If
					Next j
				End If
			Next i
			Return sortedCluster
		End Function
		Public Shared Function CreateClosedCircuit(ByVal sortedCluster As List(Of PointF)) As List(Of PointF)
			Dim contourPoints As New List(Of PointF)()
			If sortedCluster.Count = 0 Then
				Return contourPoints
			End If
			contourPoints.Add(sortedCluster(0))
			CreateUpperArc(sortedCluster, contourPoints)
			CreateBottomArc(sortedCluster, contourPoints)
			Return contourPoints
		End Function
	End Class
End Namespace
