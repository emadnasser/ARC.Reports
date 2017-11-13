Imports System

Namespace XtraReportsDemos.MailMerge
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.MailMerge
            DisplayName = ReportNames.MailMerge
        End Sub

        Private Sub xrRichText1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrRichText1.BeforePrint
            Const wrongString As String = " and reports to "
            If String.IsNullOrEmpty(TryCast(GetCurrentColumnValue("ReportsToInfo"), String)) Then
                xrRichText1.Rtf = xrRichText1.Rtf.Replace(wrongString, String.Empty)
            End If
        End Sub
    End Class
End Namespace
