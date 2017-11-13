Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.MultiColumnReport
    ''' <summary>
    ''' Summary description for Report.
    ''' </summary>
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.MultiColumnReport
            DisplayName = ReportNames.MultiColumnReport

            AddHandler BeforePrint, AddressOf Report_BeforePrint
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            Dim report As Report = TryCast(sender, Report)
            Dim detailBand As DetailBand = TryCast(report.Bands(BandKind.Detail), DetailBand)
            If CBool(report.Parameters("ColumnLayoutParameter").Value) Then
                detailBand.MultiColumn.Layout = ColumnLayout.AcrossThenDown
            Else
                detailBand.MultiColumn.Layout = ColumnLayout.DownThenAcross
            End If
        End Sub
    End Class
End Namespace
