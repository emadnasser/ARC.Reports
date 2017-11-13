Imports DevExpress.XtraReports
Imports DevExpress.Xpf.DemoBase
Imports System.IO
Imports System.Data
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace ReportWpfDemo
    Partial Public Class MasterDetail
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class MasterDetailViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.MasterDetailReport.Report()
        End Function
    End Class
End Namespace
