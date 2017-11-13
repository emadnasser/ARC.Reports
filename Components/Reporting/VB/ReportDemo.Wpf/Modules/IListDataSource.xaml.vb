Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    ''' <summary>
    ''' Interaction logic for IListDataSourceReportModule.xaml
    ''' </summary>
    Partial Public Class IListDataSource
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class IListDataSourceViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.IListDatasource.Report()
        End Function
    End Class
End Namespace
