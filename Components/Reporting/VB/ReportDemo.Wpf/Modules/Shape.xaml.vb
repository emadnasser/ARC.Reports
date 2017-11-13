Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class Shape
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class ShapeViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.Shape.Report()
        End Function
    End Class
End Namespace
