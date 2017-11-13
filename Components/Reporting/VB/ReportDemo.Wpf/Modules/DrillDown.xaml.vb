Imports System
Imports DevExpress.XtraReports
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Printing
Imports System.Collections.Generic
Imports System.Windows.Input
Imports XtraReportsDemos.DrillDownReport
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpf.Core.Commands

Namespace ReportWpfDemo
    Partial Public Class DrillDown
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class DrillDownViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.DrillDownReport.DrillDownReport()
        End Function
    End Class
End Namespace
