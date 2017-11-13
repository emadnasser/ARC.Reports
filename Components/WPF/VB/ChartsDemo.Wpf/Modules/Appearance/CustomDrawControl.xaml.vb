Imports System
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/Appearance/CustomDrawControl(.SL).xaml"), CodeFile("Modules/Appearance/CustomDrawControl.xaml.(cs)")>
    Partial Public Class CustomDrawControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitSeries()
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub InitSeries()
            Dim random As New Random()
            chart.BeginInit()
            Try
                If chart IsNot Nothing AndAlso chart.Diagram.Series.Count > 0 Then
                    Dim series As Series = chart.Diagram.Series(0)
                    series.Points.Clear()
                    For i As Integer = 0 To 19
                        Dim randomValue As Double = Math.Round(random.NextDouble() * 3, 1)
                        Dim value As Double = If(randomValue = 0, 0.1, randomValue)
                        series.Points.Add(New SeriesPoint(i, value))
                    Next i
                End If
            Finally
                chart.EndInit()
            End Try
        End Sub
        Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            If CBool(chbCustomDraw.IsChecked) Then
                Dim color As String = CorrectDrawOptions(e.SeriesPoint.Value, e.DrawOptions)
                If Not String.IsNullOrEmpty(color) Then
                    e.LabelText = color & ": " & e.LabelText
                End If
            End If
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitSeries()
            chart.Animate()
        End Sub
        Private Sub chbCustomDraw_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                chart.UpdateData()
            End If
        End Sub
        Private Sub chbCustomDraw_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chart IsNot Nothing Then
                chart.UpdateData()
            End If
        End Sub
        Private Function CorrectDrawOptions(ByVal val As Double, ByVal drawOptions As DrawOptions) As String
            If drawOptions Is Nothing Then
                Return ""
            End If
            If val < 1 Then
                drawOptions.Color = Color.FromArgb(&HFF, &H51, &H89, &H3)
                Return "Green"
            ElseIf val < 2 Then
                drawOptions.Color = Color.FromArgb(&HFF, &HF9, &HAA, &HF)
                Return "Yellow"
            Else
                drawOptions.Color = Color.FromArgb(&HFF, &HC7, &H39, &HC)
                Return "Red"
            End If
        End Function
    End Class
End Namespace
