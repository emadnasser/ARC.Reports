Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/ChartElements/CustomAxisLabelsControl(.SL).xaml"), CodeFile("Modules/ChartElements/CustomAxisLabelsControl.xaml.(cs)")>
    Partial Public Class CustomAxisLabelsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            FillCustomAxisLabels()
            axisYLabel.TextPattern = "{A} minutes"
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub ClearCustomAxisLabels()
            CType(chart.Diagram, XYDiagram2D).AxisY.CustomLabels.Clear()
        End Sub
        Private Sub FillCustomAxisLabels()
            Dim diagram As XYDiagram2D = CType(chart.Diagram, XYDiagram2D)
            For i As Integer = 0 To 999 Step 120
                Dim duration As TimeSpan = TimeSpan.FromMinutes(i)
                diagram.AxisY.CustomLabels.Add(New CustomAxisLabel(i, String.Format("{0} hours", duration.Hours.ToString())))
            Next i
        End Sub
        Private Sub chbEnable_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ClearCustomAxisLabels()
            FillCustomAxisLabels()
        End Sub
        Private Sub chbEnable_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ClearCustomAxisLabels()
        End Sub

        Private Sub chartToolTipControler_ToolTipOpening(ByVal sender As Object, ByVal e As ChartToolTipEventArgs)
            e.Hint = GetHoursAndMinutesAsString(e.SeriesPoint.Value)
        End Sub
        Private Function GetHoursAndMinutesAsString(ByVal flyDuration As Double) As String
            Const minutesInHour As Integer = 60
            Dim hours As String = (CInt((flyDuration)) \ minutesInHour).ToString("D2")
            Dim minutes As String = CInt((flyDuration Mod minutesInHour)).ToString("D2")
            Return hours & ":" & minutes
        End Function
    End Class
End Namespace
