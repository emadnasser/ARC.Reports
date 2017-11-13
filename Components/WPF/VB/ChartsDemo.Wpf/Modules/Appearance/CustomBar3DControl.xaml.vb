Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Appearance/CustomBar3DControl(.SL).xaml"), CodeFile("Modules/Appearance/CustomBar3DControl.xaml.(cs)")>
    Partial Public Class CustomBar3DControl
        Inherits ChartsDemoModule

        Private Const clickDelta As Integer = 200
        Private Const chair As String = "Chair"

        Private mouseDownTime As Integer
        Private isLeftMouseButtonReleased As Boolean = True
        Private initialAnimation As Storyboard
        Private seriesPointAnimationStoryboard As Storyboard

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
   initialAnimation = TryCast(TryFindResource("InitialAnimation"), Storyboard)
   seriesPointAnimationStoryboard = TryCast(TryFindResource("SeriesPointAnimationStoryboard"), Storyboard)
            If seriesPointAnimationStoryboard IsNot Nothing AndAlso seriesPointAnimationStoryboard.Children.Count > 0 Then
                Storyboard.SetTarget(seriesPointAnimationStoryboard.Children(0), SeriesPointAnimationRecord)
            End If
        End Sub
        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
        Private Function GetPencilPoints() As List(Of SeriesPoint)
            Dim points As New List(Of SeriesPoint)()
            points.Add(New SeriesPoint(1, 65))
            points.Add(New SeriesPoint(2, 78))
            points.Add(New SeriesPoint(3, 95))
            points.Add(New SeriesPoint(4, 110))
            points.Add(New SeriesPoint(5, 108))
            points.Add(New SeriesPoint(6, 52))
            points.Add(New SeriesPoint(7, 46))
            Return points
        End Function
        Private Function GetChairPoints() As List(Of SeriesPoint)
            Dim points As New List(Of SeriesPoint)()
            points.Add(New SeriesPoint(1, 55))
            points.Add(New SeriesPoint(2, 70))
            points.Add(New SeriesPoint(3, 40))
            Return points
        End Function
        Private Function IsClick(ByVal mouseUpTime As Integer) As Boolean
            Return mouseUpTime - mouseDownTime < clickDelta
        End Function
        Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            mouseDownTime = e.Timestamp
            isLeftMouseButtonReleased = False
        End Sub
        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            isLeftMouseButtonReleased = True
            If seriesPointAnimationStoryboard Is Nothing OrElse SeriesPointAnimation Is Nothing OrElse (Not IsClick(e.Timestamp)) Then
                Return
            End If
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.GetPosition(chart))
            If hitInfo IsNot Nothing AndAlso hitInfo.SeriesPoint IsNot Nothing Then
                SeriesPointAnimation.TargetSeriesPoint = hitInfo.SeriesPoint
                seriesPointAnimationStoryboard.Begin(chart)
            End If
        End Sub
        Private Sub ChangeModel(ByVal selectedItem As ListBoxItem)
            If selectedItem Is Nothing Then
                Return
            End If
            Dim modelName As String = DirectCast(selectedItem.Content, String)
            Dim model As CustomBar3DModel = TryCast(TryFindResource(modelName), CustomBar3DModel)
            If model Is Nothing Then
                Return
            End If
            series.Points.Clear()
            series.DisplayName = modelName
            series.Model = model
            If modelName = chair Then
                series.Points.AddRange(GetChairPoints())
                series.BarWidth = 0.9
                diagram.SeriesPadding = 0.5
            Else
                series.Points.AddRange(GetPencilPoints())
                series.BarWidth = 0.45
                diagram.SeriesPadding = 0.3
            End If
        End Sub
        Private Sub lbModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If series IsNot Nothing Then
                ChangeModel(TryCast(lbModel.SelectedItem, ListBoxItem))
            End If
        End Sub
        Private Sub chart_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangeModel(TryCast(lbModel.SelectedItem, ListBoxItem))
        End Sub
        Private Sub chart_QueryChartCursor(ByVal sender As Object, ByVal e As QueryChartCursorEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Position)
            If hitInfo IsNot Nothing AndAlso hitInfo.SeriesPoint IsNot Nothing AndAlso isLeftMouseButtonReleased Then
                e.Cursor = Cursors.Hand
            End If
        End Sub
    End Class
End Namespace
