Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    ''' <summary>
    ''' Interaction logic for OddEvenStylesReportModule.xaml
    ''' </summary>
    Partial Public Class OddEvenStyles
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class OddEvenStylesViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.OddEvenStyles.Report()
        End Function
    End Class
End Namespace
