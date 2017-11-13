Imports DevExpress.XtraReports
Imports System.Data
Imports DevExpress.Xpf.DemoBase

Namespace ReportWpfDemo
    Partial Public Class PivotGrid
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class PivotGridViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.PivotGrid.Report()
        End Function
    End Class
End Namespace
