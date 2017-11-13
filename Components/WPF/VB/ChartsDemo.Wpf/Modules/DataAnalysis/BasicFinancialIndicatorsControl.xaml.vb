Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/DataAnalysis/BasicFinancialIndicatorsControl(.SL).xaml"), CodeFile("Modules/DataAnalysis/BasicFinancialIndicatorsControl.xaml.(cs)")>
    Partial Public Class BasicFinancialIndicatorsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ComboBoxEdit_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Select Case cbeIndicatorKind.SelectedIndex
                Case 0
                    ShowTrendLines()
                Case 1
                    ShowRegressionLine()
                Case 2
                    ShowFibonacciRetracement()
                Case 3
                    ShowFibonacciFans()
                Case 4
                    ShowFibonacciArcs()
            End Select
        End Sub
        Private Sub ShowFibonacciArcs()
            HideAllIndicators()
            fibonacciArcs.Visible = True
        End Sub
        Private Sub ShowFibonacciFans()
            HideAllIndicators()
            fibonacciFans.Visible = True
        End Sub
       Private Sub ShowFibonacciRetracement()
            HideAllIndicators()
            fibonacciRetracement.Visible = True
       End Sub
        Private Sub ShowRegressionLine()
            HideAllIndicators()
            regressionLine.Visible = True
        End Sub
        Private Sub ShowTrendLines()
            HideAllIndicators()
            trendLine1.Visible = True
            trendLine2.Visible = True
        End Sub
        Private Sub HideAllIndicators()
            For Each indicator As Indicator In series.Indicators
                indicator.Visible = False
            Next indicator
        End Sub

        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class
End Namespace
