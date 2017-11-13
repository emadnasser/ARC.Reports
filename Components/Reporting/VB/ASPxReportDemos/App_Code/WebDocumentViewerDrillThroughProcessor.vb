Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web.WebDocumentViewer
Imports XtraReportsDemos.PollingReport

Public Class WebDocumentViewerDrillThroughProcessor
	Implements IWebDocumentViewerDrillThroughProcessor
	Private Function GetResultingData() As IList(Of ResultingData)
		If HttpContext.Current.Session("resultingData") Is Nothing Then
			HttpContext.Current.Session("resultingData") = New List(Of ResultingData)()
		End If
		Return CType(HttpContext.Current.Session("resultingData"), List(Of ResultingData))
	End Function
	Private Function IncrementPollCount() As Integer
		Dim pollCount As Integer = 3
		If HttpContext.Current.Session("pollCount") IsNot Nothing Then
			pollCount = CInt(Fix(HttpContext.Current.Session("pollCount")))
		End If
		pollCount += 1
		HttpContext.Current.Session("pollCount") = pollCount
		Return pollCount
	End Function
	Private Function CreateReport(ByVal context As DrillThroughContext) As XtraReport Implements IWebDocumentViewerDrillThroughProcessor.CreateReport
		If context.CustomData = "showResults" Then
			context.AssignEditingFieldValuesToReport()
			Dim data As IList(Of ResultingData) = GetResultingData()
			CType(context.Report, PollingReport).UpdateData(data)
			Dim resultingReport = New ResultingReport()
			resultingReport.ResultingReportDS.DataSource = data
			resultingReport.Parameters("paramPollCount").Value = IncrementPollCount()
			Return resultingReport
		Else
			Return New PollingReport()
		End If
	End Function
End Class
