Imports System
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.ReportMerging
    Public Class MergedReport
        Inherits NorthwindTraders.CatalogReport

        Private fChartsReport As Charts.Report = New XtraReportsDemos.Charts.Report()
        Private categoryStartPage As Page

        Public ReadOnly Property ChartsReport() As Charts.Report
            Get
                Return fChartsReport
            End Get
        End Property
        Protected Overrides ReadOnly Property EnableGroupsSorting() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            AddHandler AfterPrint, AddressOf ReportAfterPrint
            GroupHeader.PageBreak = PageBreak.BeforeBand

            fChartsReport.RemoveReportHeader()

            AddHandler lbCategoryName.PrintOnPage, AddressOf lbCategoryName_PrintOnPage
        End Sub

        Private Sub lbCategoryName_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs)
            If IsDisposed OrElse categoryStartPage IsNot Nothing Then
                Return
            End If
            categoryStartPage = Pages(e.PageIndex)
        End Sub
        Private Sub ReportAfterPrint(ByVal sender As Object, ByVal e As EventArgs)
            If IsDisposed OrElse categoryStartPage Is Nothing Then
                Return
            End If
            fChartsReport.CreateDocument()
            Dim categoryStartPageIndex As Integer = categoryStartPage.Index
            categoryStartPage = Nothing
            For i As Integer = 0 To fChartsReport.Pages.Count - 1
                Dim insertIndex As Integer = categoryStartPageIndex + 1 + i * 2
                If insertIndex >= Pages.Count Then
                    Exit For
                End If
                Pages.Insert(insertIndex, fChartsReport.Pages(i))
            Next i
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                RemoveHandler AfterPrint, AddressOf ReportAfterPrint
                RemoveHandler lbCategoryName.PrintOnPage, AddressOf lbCategoryName_PrintOnPage
                If fChartsReport IsNot Nothing Then
                    fChartsReport.Dispose()
                    fChartsReport = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
