Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class Table
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class TableViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport

            Dim report_Renamed = New XtraReportsDemos.TableReport.Report()
            SuppressHamburgerImage(report_Renamed)
            Return report_Renamed
        End Function

        Private Sub SuppressHamburgerImage(ByVal report As XtraReportsDemos.TableReport.Report)
            report.FindControl("xrPictureBox2", False).Visible = False
            report.FindControl("xrLabel2", False).Visible = False
        End Sub
    End Class
End Namespace
