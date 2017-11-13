Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting

Namespace XtraReportsDemos.CharacterComb
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ReportFooter_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
            ccDay.Text = String.Format("{0:dd}", Date.Today)
            ccMonth.Text = String.Format("{0:MM}", Date.Today)
            ccYear.Text = String.Format("{0:yyyy}", Date.Today)
        End Sub
    End Class
End Namespace
