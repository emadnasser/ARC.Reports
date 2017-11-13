Imports System
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Charts
Imports System.Diagnostics
Imports System.Windows.Documents
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ChartElements/ChartTitlesControl(.SL).xaml"), CodeFile("Modules/ChartElements/ChartTitlesControl.xaml.(cs)")>
    Partial Public Class ChartTitlesControl
        Inherits ChartsDemoModule

        Private Const pointsCount As Integer = 40

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            CreatePoints(chart.Diagram.Series(0))
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub CreatePoints(ByVal series As Series)
            Dim random As New Random()
            For i As Integer = 0 To pointsCount - 1
                series.Points.Add(New SeriesPoint(i, random.NextDouble() + 1))
            Next i
        End Sub
        Private Sub Hyperlink_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim source As Hyperlink = TryCast(sender, Hyperlink)
            If source IsNot Nothing Then
                Process.Start(source.NavigateUri.ToString())
            End If
        End Sub

        Protected Overrides Function ArrangeOverride(ByVal finalSize As Size) As Size
            Dim clipGeometry As New RectangleGeometry()
            clipGeometry.Rect = New Rect(0, 0, finalSize.Width, finalSize.Height)
            Clip = clipGeometry
            Return MyBase.ArrangeOverride(finalSize)
        End Function
    End Class
End Namespace
