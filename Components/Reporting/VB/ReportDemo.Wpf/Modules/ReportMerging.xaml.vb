Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Printing

Namespace ReportWpfDemo
    Partial Public Class ReportMerging
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ReportMergingViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.ReportMerging.MergedReport()
        End Function
    End Class
End Namespace
