Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports DevExpress.Snap.Core.API
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit.UI
Imports DevExpress.Snap.Extensions.UI
Imports DevExpress.XtraRichEdit.API.Native

Namespace SnapDemos.Modules
	Partial Public Class Events
		Inherits SnapTutorialControlBase
		Public Sub New()
			InitializeComponent()
			CType(New SnapDemoExceptionsHandler(snapControl1), SnapDemoExceptionsHandler).Install()
			Using dlg As New WaitDialogForm("Please wait", "Loading...")
				LoadDocument()
				SetDataSource()
				SubscribeEvents()
			End Using
		End Sub

		Protected Overrides ReadOnly Property RibbonControl() As RibbonControl
			Get
				Return ribbonControl1
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryChangeTableStyleItem() As GalleryChangeTableStyleItem
			Get
				Return galleryChangeTableStyleItem1
			End Get
		End Property
		Protected Overrides ReadOnly Property GalleryChangeTableCellStyleItem() As GalleryChangeTableCellStyleItem
			Get
				Return galleryChangeTableCellStyleItem1
			End Get
		End Property

		Private Sub LoadDocument()
			Dim path As String = FindFilePathByName("Events")
			If File.Exists(path) Then
				Me.snapControl1.Document.LoadDocument(path, SnapDocumentFormat.Snap)
			End If
		End Sub
		Private Sub SetDataSource()
			Dim dataSource As Object = New EventsDataProvider().GetDataSource()
			snapControl1.DataSource = dataSource
		End Sub
		Private Sub SubscribeEvents()
			AddHandler snapControl1.Document.PrepareSnList, AddressOf OnPrepareSnList
			AddHandler snapControl1.Document.PrepareSnListColumns, AddressOf OnPrepareSnListColumns
			AddHandler snapControl1.Document.PrepareSnListDetail, AddressOf OnPrepareSnListDetail
		End Sub

		Private Sub OnBeforeInsertSnList(ByVal sender As Object, ByVal e As BeforeInsertSnListEventArgs)
			e.DataFields = ShowColumnChooserDialog(e.DataFields)
		End Sub

		Private Sub OnBeforeInsertSnListColumns(ByVal sender As Object, ByVal e As BeforeInsertSnListColumnsEventArgs)
			e.DataFields = ShowColumnChooserDialog(e.DataFields)
		End Sub

		Private Sub OnBeforeInsertSnListDetail(ByVal sender As Object, ByVal e As BeforeInsertSnListDetailEventArgs)
			e.DataFields = ShowColumnChooserDialog(e.DataFields)
		End Sub

		Private Function ShowColumnChooserDialog(ByVal dataFields As List(Of DataFieldInfo)) As List(Of DataFieldInfo)
			Dim dlg As New ColumnChooserDialog()
			dlg.SetFieldList(dataFields)
			dlg.ShowDialog()
			Return dlg.Result
		End Function

		Private Sub OnPrepareSnList(ByVal sender As Object, ByVal e As PrepareSnListEventArgs)
			e.Template.InsertHtmlText(e.Template.Range.Start, "<h1>Auto-generated header</h1>")
		End Sub

		Private Sub OnPrepareSnListColumns(ByVal sender As Object, ByVal e As PrepareSnListColumnsEventArgs)
			e.Header.InsertHtmlText(e.Header.Range.Start, "<u>Auto-generated header for column</u>" & Constants.vbCrLf)
		End Sub

		Private Sub OnPrepareSnListDetail(ByVal sender As Object, ByVal e As PrepareSnListDetailEventArgs)
			e.Template.InsertHtmlText(e.Template.Range.Start, "<h2>Auto-generated header for detail level</h2>")
		End Sub

		Private Sub ResetCellStyle(ByVal cell As TableCell, ByVal rowIndex As Integer, ByVal cellIndex As Integer)
			cell.Style = snapControl1.Document.TableCellStyles(0)
		End Sub

		Private Sub SetCellStyle(ByVal cell As TableCell, ByVal rowIndex As Integer, ByVal cellIndex As Integer)
			If rowIndex Mod 2 = cellIndex Mod 2 Then
				cell.Style = snapControl1.Document.TableCellStyles(3)
			End If
		End Sub

		Private Sub PaintTable()
			Dim document As SnapDocument = snapControl1.Document
			Dim tables As TableCollection = document.Tables
			If tables.Count = 0 Then
				Return
			End If
			document.BeginUpdate()
			For k As Integer = 0 To tables.Count - 1
				Dim table As Table = tables(k)
				Dim reset As TableCellProcessorDelegate = AddressOf ResetCellStyle
				table.ForEachCell(reset)
				Dim setStyle As TableCellProcessorDelegate = AddressOf SetCellStyle
				table.ForEachCell(setStyle)
			Next k
			document.EndUpdate()
		End Sub

		Private Sub OnAfterInsertSnList(ByVal sender As Object, ByVal e As AfterInsertSnListEventArgs)
			PaintTable()
			snapControl1.Document.Selection = e.Range
		End Sub

		Private Sub OnAfterInsertSnListColumns(ByVal sender As Object, ByVal e As AfterInsertSnListColumnsEventArgs)
			PaintTable()
			snapControl1.Document.Selection = e.SnList.Field.Range
		End Sub
		Private Sub OnAfterInsertSnListDetail(ByVal sender As Object, ByVal e As AfterInsertSnListDetailEventArgs)
			PaintTable()
			snapControl1.Document.Selection = e.Master.Field.Range
		End Sub

		Private Sub OnBeforeListCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkBeforeList.CheckedChanged
			If chkBeforeList.Checked Then
				AddHandler snapControl1.Document.BeforeInsertSnList, AddressOf OnBeforeInsertSnList
			Else
				RemoveHandler snapControl1.Document.BeforeInsertSnList, AddressOf OnBeforeInsertSnList
			End If
		End Sub

		Private Sub OnBeforeColumnsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkBeforeColumns.CheckedChanged
			If chkBeforeColumns.Checked Then
				AddHandler snapControl1.Document.BeforeInsertSnListColumns, AddressOf OnBeforeInsertSnListColumns
			Else
				RemoveHandler snapControl1.Document.BeforeInsertSnListColumns, AddressOf OnBeforeInsertSnListColumns
			End If
		End Sub

		Private Sub OnBeforeDetailCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkBeforeDetail.CheckedChanged
			If chkBeforeDetail.Checked Then
				AddHandler snapControl1.Document.BeforeInsertSnListDetail, AddressOf OnBeforeInsertSnListDetail
			Else
				RemoveHandler snapControl1.Document.BeforeInsertSnListDetail, AddressOf OnBeforeInsertSnListDetail
			End If
		End Sub

		Private Sub OnPrepareListCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPrepareList.CheckedChanged
			If chkPrepareList.Checked Then
				AddHandler snapControl1.Document.PrepareSnList, AddressOf OnPrepareSnList
			Else
				RemoveHandler snapControl1.Document.PrepareSnList, AddressOf OnPrepareSnList
			End If
		End Sub

		Private Sub OnPrepareColumnsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPrepareColumns.CheckedChanged
			If chkPrepareColumns.Checked Then
				AddHandler snapControl1.Document.PrepareSnListColumns, AddressOf OnPrepareSnListColumns
			Else
				RemoveHandler snapControl1.Document.PrepareSnListColumns, AddressOf OnPrepareSnListColumns
			End If
		End Sub

		Private Sub OnPrepareDetailCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPrepareDetail.CheckedChanged
			If chkPrepareDetail.Checked Then
				AddHandler snapControl1.Document.PrepareSnListDetail, AddressOf OnPrepareSnListDetail
			Else
				RemoveHandler snapControl1.Document.PrepareSnListDetail, AddressOf OnPrepareSnListDetail
			End If
		End Sub

		Private Sub OnAfterListCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAfterList.CheckedChanged
			If chkAfterList.Checked Then
				AddHandler snapControl1.Document.AfterInsertSnList, AddressOf OnAfterInsertSnList
			Else
				RemoveHandler snapControl1.Document.AfterInsertSnList, AddressOf OnAfterInsertSnList
			End If
		End Sub

		Private Sub OnAfterColumnsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAfterColumns.CheckedChanged
			If chkAfterColumns.Checked Then
				AddHandler snapControl1.Document.AfterInsertSnListColumns, AddressOf OnAfterInsertSnListColumns
			Else
				RemoveHandler snapControl1.Document.AfterInsertSnListColumns, AddressOf OnAfterInsertSnListColumns
			End If
		End Sub

		Private Sub OnAfterDetailCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAfterDetail.CheckedChanged
			If chkAfterDetail.Checked Then
				AddHandler snapControl1.Document.AfterInsertSnListDetail, AddressOf OnAfterInsertSnListDetail
			Else
				RemoveHandler snapControl1.Document.AfterInsertSnListDetail, AddressOf OnAfterInsertSnListDetail
			End If
		End Sub
	End Class
End Namespace
