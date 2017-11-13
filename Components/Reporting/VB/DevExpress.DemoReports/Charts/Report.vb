Imports System.Linq
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.Parameters

Namespace XtraReportsDemos.Charts
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.Charts
            DisplayName = ReportNames.Charts

            Dim lookups = xrChart1.GetAppearanceNames().Select(Function(x) New LookUpValue With {.Value = x})

            AppearanceParameter.Value = xrChart1.AppearanceName
            CType(AppearanceParameter.LookUpSettings, StaticListLookUpSettings).LookUpValues.AddRange(lookups)
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            xrChart1.AppearanceName = CStr(AppearanceParameter.Value)

            Dim colorEach As Boolean = CBool(ColorEachParameter.Value)
            For Each series As Series In xrChart1.Series
                If TypeOf series.View Is SeriesViewColorEachSupportBase Then
                    CType(series.View, SeriesViewColorEachSupportBase).ColorEach = colorEach
                ElseIf TypeOf series.View Is SeriesView3DColorEachSupportBase Then
                    CType(series.View, SeriesView3DColorEachSupportBase).ColorEach = colorEach
                End If
            Next series
        End Sub

        Public Sub RemoveReportHeader()
            ReportHeader.Visible = False
        End Sub
    End Class
End Namespace
