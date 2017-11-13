Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class LargeQuantityOfData
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class LargeQuantityOfDataViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.HugeAmountRecords.Report()
        End Function
    End Class
End Namespace
