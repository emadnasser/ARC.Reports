Imports Microsoft.VisualBasic
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Options

Namespace SnapDemos.Modules
	Partial Public Class MailMergeReports
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				LoadDocument()
				SetDataSource()
				SubscribeEvents()
			End Using
		End Sub
		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("MailMergeReports")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New MailMergeReportsDataProvider().GetDataSource()
			Me.snapControl1.DataSource = dataSource
		End Sub
		Private Sub SubscribeEvents()
			AddHandler Me.snapControl1.MailMergeExportFormShowing, AddressOf OnMailMergeExportFormShowing
		End Sub

		Private Sub OnMailMergeExportFormShowing(ByVal sender As Object, ByVal e As MailMergeExportFormShowingEventArgs)
			e.Options.HeaderFooterLinkToPrevious = False
			e.Options.RecordSeparator = RecordSeparator.SectionNextPage
		End Sub
	End Class
End Namespace
