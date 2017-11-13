Imports Microsoft.VisualBasic
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Office
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Snap.Core.API

Namespace SnapDemos.Modules
	Public Class MultipleDatasources
		Inherits BaseTutorial
		Public Sub New()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				SetDataSource()
				SetDocumentContent()
			End Using
		End Sub
		Private Sub SetDataSource()
			Dim orders As Object = New CalculatedFieldsDataProvider().GetDataSource()
			Me.snapControl1.DataSources.Add(New DataSourceInfo("Orders", orders))
			Dim fishes As Object = New IListDatasourceProvider().GetDataSource()
			Me.snapControl1.DataSources.Add(New DataSourceInfo("Fishes", fishes))
		End Sub
		Private Sub SetDocumentContent()
			Dim path As String = FindFilePathByName("IListDataSource")
			If File.Exists(path) Then
				Me.snapControl1.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
			Dim snapDocument As SnapDocument = Me.snapControl1.Document
			Dim field As Field = snapDocument.Fields.Create(snapDocument.Range.Start, "TOC \o \f tocID \h")
			snapDocument.InsertText(field.Range.End, Characters.PageBreak.ToString())

			snapDocument.InsertText(snapDocument.Range.End, Characters.PageBreak.ToString())
			path = FindFilePathByName("CalculatedFields")
			If File.Exists(path) Then
				snapDocument.InsertDocumentContent(snapDocument.Range.End, path, SnapDocumentFormat.Snap)
			End If
			snapDocument.Fields.Update()
			field.Update()
		End Sub
	End Class
End Namespace
