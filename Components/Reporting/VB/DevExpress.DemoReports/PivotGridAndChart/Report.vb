Imports System
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PivotGridAndChart
    Partial Public Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.PivotGridAndChart
            DisplayName = ReportNames.PivotGridAndChart
            parameterViewType.Type = GetType(ViewTypeFiltered)
            parameterViewType.Value = ViewTypeFiltered.StackedSplineArea
            AddHandler Me.BeforePrint, AddressOf Report_BeforePrint
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            xrChart.BeginInit()
            xrChart.SeriesTemplate.ChangeView(CType(parameterViewType.Value, ViewType))
            Dim labelsVisible As Boolean = Convert.ToBoolean(parameterShowLabels.Value)
            xrChart.SeriesTemplate.LabelsVisibility = DefaultBooleanUtils.ToDefaultBoolean(labelsVisible)
            Dim diagram = TryCast(xrChart.Diagram, Diagram3D)
            If diagram IsNot Nothing AndAlso (Not labelsVisible) Then
                diagram.ZoomPercent = 190
                diagram.VerticalScrollPercent = 5
            End If
            xrPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = Convert.ToBoolean(parameterShowRowGrandTotals.Value)
            xrPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = Convert.ToBoolean(parameterShowColumnGrandTotals.Value)
            xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = Convert.ToBoolean(parameterGenerateSeriesFromColumns.Value)
            xrChart.EndInit()
        End Sub
    End Class
End Namespace
