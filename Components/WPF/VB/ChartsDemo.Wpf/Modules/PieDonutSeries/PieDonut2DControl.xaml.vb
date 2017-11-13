Imports System
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PieDonutSeries/PieDonut2DControl(.SL).xaml"), CodeFile("Modules/PieDonutSeries/PieDonut2DControl.xaml.(cs)")>
    Partial Public Class PieDonut2DControl
        Inherits ChartsDemoModule

        Private Const clickDelta As Integer = 200

        Private mouseDownTime As Date
        Private rotate As Boolean
        Private startPosition As Point

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = Pie2DModelKindHelper.FindActualPie2DModelKind(GetType(SimplePie2DModel))
                Series.ToolTipPointPattern = "{A}: {V:0.0}M km²"
        End Sub
        Private Function IsClick(ByVal mouseUpTime As Date) As Boolean
            Return (mouseUpTime.Subtract(mouseDownTime)).TotalMilliseconds < clickDelta
        End Function
        Private Function CalcAngle(ByVal p1 As Point, ByVal p2 As Point) As Double
            Dim center As New Point(chart.Diagram.ActualWidth / 2, chart.ActualHeight / 2)
            Dim relativeP1 As New Point(p1.X - center.X, p1.Y - center.Y)
            Dim relativeP2 As New Point(p2.X - center.X, p2.Y - center.Y)
            Dim angleP1Radian As Double = Math.Atan2(relativeP1.X, relativeP1.Y)
            Dim angleP2Radian As Double = Math.Atan2(relativeP2.X, relativeP2.Y)
            Dim angle As Double = (angleP2Radian - angleP1Radian) * 180 / (Math.PI * 2)
            If angle > 90 Then
                angle = 180 - angle
            ElseIf angle < -90 Then
                angle = 180 + angle
            End If
            Return angle
        End Function
        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.GetPosition(chart))
            rotate = False
            If hitInfo Is Nothing OrElse hitInfo.SeriesPoint Is Nothing OrElse (Not IsClick(Date.Now)) Then
                Return
            End If
            Dim distance As Double = PieSeries.GetExplodedDistance(hitInfo.SeriesPoint)
            Dim storyBoard As New Storyboard()
            Dim animation As New DoubleAnimation()
            animation.Duration = New Duration(New TimeSpan(0, 0, 0, 0, 300))
            animation.To = If(distance > 0, 0, 0.3)
            storyBoard.Children.Add(animation)
            Storyboard.SetTarget(animation, hitInfo.SeriesPoint)
            Storyboard.SetTargetProperty(animation, New PropertyPath(PieSeries.ExplodedDistanceProperty))
            storyBoard.Begin()
        End Sub
        Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            mouseDownTime = Date.Now
            Dim position As Point = e.GetPosition(chart)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(position)
            If hitInfo IsNot Nothing AndAlso hitInfo.SeriesPoint IsNot Nothing Then
                rotate = True
                startPosition = position
            End If
        End Sub
        Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim position As Point = e.GetPosition(chart)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(position)
            If hitInfo Is Nothing Then
                Return
            End If
            If rotate AndAlso (Not IsClick(Date.Now)) Then
                Dim series As PieSeries2D = TryCast(chart.Diagram.Series(0), PieSeries2D)
                Dim angleDelta As Double = CalcAngle(startPosition, position)
                angleDelta *= If(series.SweepDirection = PieSweepDirection.Clockwise, -1.0, 1.0)
                If Math.Abs(slRotation.Value + angleDelta) < 360 Then
                    slRotation.Value += angleDelta
                ElseIf slRotation.Value + angleDelta > 360 Then
                    slRotation.Value = -360
                Else
                    slRotation.Value = 360
                End If
                startPosition = position
            End If
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub rblSweepDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                chart.Animate()
            End If
        End Sub
        Private Sub chart_QueryChartCursor(ByVal sender As Object, ByVal e As QueryChartCursorEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Position)
            If hitInfo IsNot Nothing AndAlso hitInfo.SeriesPoint IsNot Nothing Then
                e.Cursor = Cursors.Hand
            End If
        End Sub
    End Class
End Namespace
