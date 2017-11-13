Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace XtraReportsDemos.MasterDetailReport
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.MasterDetailReport
            DisplayName = ReportNames.MasterDetailReport
        End Sub

        Private Sub xrTableCell54_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrTableCell54.BeforePrint
            DirectCast(sender, XRControl).Text = DirectCast(sender, XRControl).Text.Replace("#"c, " "c)
        End Sub
    End Class
End Namespace
