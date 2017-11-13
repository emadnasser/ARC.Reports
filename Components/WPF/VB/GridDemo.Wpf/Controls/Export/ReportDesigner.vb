Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Reports.UserDesigner
Imports DevExpress.XtraExport
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing
Imports DevExpress.Xpf.Printing

Namespace GridDemo
    Friend NotInheritable Class ReportDesignerHelper

        Private Sub New()
        End Sub

        Public Shared Sub ShowDesigner(ByVal owner As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper))
            Dim report As New XtraReport()
            ReportGenerationExtensions(Of ColumnWrapper, RowBaseWrapper).Generate(report, owner)
            Dim reportDesigner = New ReportDesigner()
            AddHandler reportDesigner.Loaded, Sub(s, e) reportDesigner.OpenDocument(report)
            reportDesigner.ShowWindow(TryCast(owner, FrameworkElement))
        End Sub
        Public Shared Sub ShowDesignerPrintPreview(ByVal report As XtraReport)
            Dim preview As New DocumentPreviewControl()
            preview.DocumentSource = report
            Dim w As New Window()
            w.Content = preview
            report.CreateDocument(True)
            w.ShowDialog()
        End Sub
    End Class
End Namespace
