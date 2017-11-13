Imports System.Windows
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports
Imports DevExpress.XtraPrinting

Namespace ReportWpfDemo
    Partial Public Class MultiColumn
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MultiColumnViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.MultiColumnReport.Report()
        End Function
    End Class
End Namespace
