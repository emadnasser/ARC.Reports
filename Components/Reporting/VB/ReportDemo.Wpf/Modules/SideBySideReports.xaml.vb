Imports DevExpress.XtraReports
Imports System.Data
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.DemoBase
Imports System.Linq
Imports System
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Editors
Imports System.Windows.Data
Imports System.Collections.Generic

Namespace ReportWpfDemo
    Partial Public Class SideBySideReports
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class SideBySideReportsViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.SideBySideReports.EmployeeComparisonReport()
        End Function
    End Class
End Namespace
