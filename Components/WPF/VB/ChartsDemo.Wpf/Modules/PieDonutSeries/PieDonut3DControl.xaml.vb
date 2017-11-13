Imports System
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/PieDonutSeries/PieDonut3DControl(.SL).xaml"), CodeFile("Modules/PieDonutSeries/PieDonut3DControl.xaml.(cs)")>
    Partial Public Class PieDonut3DControl
        Inherits ChartsDemoModule

        Private Const clickDelta As Integer = 200

        Private isLeftMouseButtonReleased As Boolean = True
        Private mouseDownTime As Integer

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            lbModel.SelectedItem = Pie3DModelKindHelper.FindActualPie3DModelKind(CType(chart.Diagram.Series(0), PieSeries3D).ActualModel)
            Series.ToolTipPointPattern = "{A}: {V:0.0}M km²"
        End Sub
        Private Function IsClick(ByVal mouseUpTime As Integer) As Boolean
            Return mouseUpTime - mouseDownTime < clickDelta
        End Function
        Private Sub lbModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim modelKind As Pie3DKind = TryCast(lbModel.SelectedItem, Pie3DKind)
            If modelKind IsNot Nothing Then
                Dim type As Type = modelKind.Type
                Pie3DModelKindHelper.SetModel(chart, DirectCast(Activator.CreateInstance(type), Pie3DModel))
                Dim series As PieSeries3D = CType(chart.Diagram.Series(0), PieSeries3D)
                series.HoleRadiusPercent = If(type.Name.StartsWith("Semi"), 0, 50)
                series.DepthTransform = If(type.Name.StartsWith("Semi"), 0.5, 1)
            End If
        End Sub
        Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            mouseDownTime = e.Timestamp
            isLeftMouseButtonReleased = False
        End Sub
        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            isLeftMouseButtonReleased = True
            If Not IsClick(e.Timestamp) Then
                Return
            End If
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.GetPosition(chart))
            If hitInfo Is Nothing OrElse hitInfo.SeriesPoint Is Nothing Then
                Return
            End If
            Dim distance As Double = PieSeries.GetExplodedDistance(hitInfo.SeriesPoint)
            Dim animation As AnimationTimeline = If(distance > 0, CType(TryFindResource("CollapseAnimation"), AnimationTimeline), CType(TryFindResource("ExplodeAnimation"), AnimationTimeline))
            Dim storyBoard As New Storyboard()
            storyBoard.Children.Add(animation)
            Storyboard.SetTarget(animation, hitInfo.SeriesPoint)
            Storyboard.SetTargetProperty(animation, New PropertyPath(PieSeries.ExplodedDistanceProperty))
            storyBoard.Begin()
        End Sub
        Private Sub chbVisible_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                chart.Diagram.Series(0).LabelsVisibility = False
                lbPosition.IsEnabled = False
            End If
        End Sub
        Private Sub chbVisible_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Diagram.Series(0).LabelsVisibility = True
            lbPosition.IsEnabled = True
        End Sub
        Private Sub lbPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                PieSeries.SetLabelPosition(Series.Label, CType(lbPosition.SelectedItem, PieLabelPosition))
            End If
        End Sub
        Private Sub chart_QueryChartCursor(ByVal sender As Object, ByVal e As QueryChartCursorEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Position)
            If hitInfo IsNot Nothing AndAlso hitInfo.SeriesPoint IsNot Nothing AndAlso isLeftMouseButtonReleased Then
                e.Cursor = Cursors.Hand
            End If
        End Sub
    End Class
End Namespace
