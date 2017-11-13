Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.Charts
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            printControl.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth)
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Return New Charts.Report()
        End Function
    End Class
End Namespace
