Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Native

Namespace XtraReportsDemos.ReportMerging
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            printControl.SetDocumentMapVisibility(False)
            printControl.SetThumbnailsVisibility(False)
            printControl.SetPageView(3, 2)
            printControl.PrintingSystem = Nothing
            barButtonItem2.Enabled = False
        End Sub
        Protected Overrides Function CreateReport() As XtraReport
            Return New XtraReportsDemos.ReportMerging.MergedReport()
        End Function
    End Class
End Namespace
