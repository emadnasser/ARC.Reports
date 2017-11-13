Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    ''' <summary>
    ''' Interaction logic for InvoiceReportModule.xaml
    ''' </summary>
    Partial Public Class Invoice
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class InvoiceViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.NorthwindTraders.InvoiceReport()
        End Function
    End Class
End Namespace
