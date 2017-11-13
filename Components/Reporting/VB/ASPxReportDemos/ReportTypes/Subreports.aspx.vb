Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.XtraReports.Web

Partial Public Class ReportTypes_Subreports
	Inherits PageBase(Of XtraReportsDemos.Subreports.MasterReport)
	Protected Sub documentViewer_CustomizeParameterEditors(ByVal sender As Object, ByVal e As CustomizeParameterEditorsEventArgs)
		Dim dateEdit = CType(e.Editor, ASPxDateEdit)
		dateEdit.MinDate = New DateTime(2016, 1, 1)
		dateEdit.MaxDate = New DateTime(2016, 12, 31)
		dateEdit.ValidationSettings.ErrorText = "The end date should be grater than the start date."
		dateEdit.ClientInstanceName = e.Parameter.Name
		dateEdit.ID = e.Parameter.Name
		dateEdit.ClientSideEvents.Init = "editorInitialized"
		If dateEdit.ID = "toDateParameter" Then
			dateEdit.DateRangeSettings.StartDateEditID = "fromDateParameter"
		End If
	End Sub
End Class
