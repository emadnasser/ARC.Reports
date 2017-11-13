Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class VerticalAnchoring
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class VerticalAnchoringViewModel
        Inherits ReportModuleViewModelBase

        Protected Overrides Function CreateReport() As IReport
            Return New XtraReportsDemos.AnchorVertical.Report()
        End Function
    End Class
End Namespace
