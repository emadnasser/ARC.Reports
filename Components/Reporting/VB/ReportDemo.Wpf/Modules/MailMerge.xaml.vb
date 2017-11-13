Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    ''' <summary>
    ''' Interaction logic for MailMergeReportModule.xaml
    ''' </summary>
    Partial Public Class MailMerge
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MailMergeViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.MailMerge.Report()
        End Function
    End Class
End Namespace
