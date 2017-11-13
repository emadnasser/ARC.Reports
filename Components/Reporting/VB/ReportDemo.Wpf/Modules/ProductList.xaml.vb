Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    ''' <summary>
    ''' Interaction logic for ProductListReportModule.xaml
    ''' </summary>
    Partial Public Class ProductList
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ProductListViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.NorthwindTraders.ProductListReport()
        End Function
    End Class
End Namespace
