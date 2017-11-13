Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.XtraReports.Web

Partial Public Class WebSpecificFeatures_ReportDesigner
	Inherits PageBase(Of XtraReportsDemos.MasterDetailReport.Report)
	Private Property DocumentStream() As MemoryStream
		Get
			Return TryCast(Session(ReportTypeName & ".Designer"), MemoryStream)
		End Get
		Set(ByVal value As MemoryStream)
			Session(ReportTypeName & ".Designer") = value
		End Set
	End Property

	Protected Sub documentViewer_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
		DocumentStream = e.SaveDocumentToMemoryStream()
	End Sub

	Protected Sub documentViewer_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As RestoreReportDocumentFromCacheEventArgs)
		If DocumentStream IsNot Nothing Then
			e.RestoreDocumentFromStream(DocumentStream)
		End If
	End Sub

	Protected Overrides Sub CleanDocument()
		DocumentStream = Nothing
	End Sub
End Class
