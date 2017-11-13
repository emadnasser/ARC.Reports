Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Windows.Forms
Imports System.IO
Imports System.Collections.Generic

Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditFindAndReplace
		Inherits TutorialControlBase
		Private link As PrintableComponentLinkBase
		Private documentServer As RichEditDocumentServer
		Private prevRanges As List(Of DocumentRange)
		Private activeTextColor As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 201, 233)

		Public Sub New()
			InitializeComponent()

			Me.documentServer = New RichEditDocumentServer()
			Dim path As String = DemoUtils.GetRelativePath("Search.rtf")
			Me.documentServer.LoadDocument(path, DocumentFormat.Rtf)

			Me.printPreviewControl.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()
			Me.link = New DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(Me.printPreviewControl.PrintingSystem)
			Me.documentServer.Options.MailMerge.ViewMergedData = True
			prevRanges = New List(Of DocumentRange)()
			AddHandler Load, AddressOf MailMerge_Load
		End Sub
		Private Sub MailMerge_Load(ByVal sender As Object, ByVal e As EventArgs)
			ProcessSelectedRows()
		End Sub
		Private Sub ProcessSelectedRows()
			link.Component = Me.documentServer
			link.CreateDocument()
		End Sub

		Private Sub findButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles findButton.Click
			ClearPrevSelection()
			FindAll(findTE.Text)
			ProcessSelectedRows()
		End Sub

		Private Sub replaceButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles replaceButton.Click
			ClearPrevSelection()
			ReplaceAll(findTE.Text, replaceTE.Text)
			ProcessSelectedRows()
		End Sub

		Private Sub ReplaceAll(ByVal strFind As String, ByVal strReplace As String)
			If (Not String.IsNullOrEmpty(strFind)) Then
				If strReplace = "null" Then
					strReplace = String.Empty
				End If
				Dim ranges() As DocumentRange = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range)
				For i As Integer = 0 To ranges.Length - 1
					documentServer.Document.Replace(ranges(i), strReplace)
				Next i
				MarkSelection(ranges)
				SavePrevSelection(ranges)
			End If
		End Sub
		Private Sub FindAll(ByVal strFind As String)
			If (Not String.IsNullOrEmpty(strFind)) Then
				Dim ranges() As DocumentRange = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range)
				MarkSelection(ranges)
				SavePrevSelection(ranges)
			End If
		End Sub

		Private Sub MarkSelection(ByVal ranges() As DocumentRange)
			ChangeSelectionBackColor(ranges, activeTextColor)
		End Sub

		Private Sub ClearPrevSelection()
			ChangeSelectionBackColor(prevRanges, System.Drawing.Color.Empty)
		End Sub

		Private Sub ChangeSelectionBackColor(ByVal ranges As IEnumerable(Of DocumentRange), ByVal color As System.Drawing.Color)
			For Each range As DocumentRange In ranges
				ChangeTextBackColor(range, color)
			Next range
		End Sub

		Private Sub SavePrevSelection(ByVal ranges() As DocumentRange)
			prevRanges.Clear()
			prevRanges.AddRange(ranges)
		End Sub

		Private Sub ChangeTextBackColor(ByVal range As DocumentRange, ByVal color As System.Drawing.Color)
			Dim cp As CharacterProperties = documentServer.Document.BeginUpdateCharacters(range)
			cp.BackColor = color
			documentServer.Document.EndUpdateCharacters(cp)
		End Sub

		Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
			Using saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|HyperText Markup Language Format (*.htm, *.html)|*.html|Web Archive, single file (*.mht)|*.mht|Word 2007 Document (*.docx)|*.docx|OpenDocument Text Document (*.odt)|*.odt|Word XML Document (*.xml)|*.xml|Electronic Publication (*.epub)|*.epub|Microsoft Word Document (*.doc)|*.doc|Portable Document Format (*.pdf)|*.pdf"
				If saveFileDialog.ShowDialog() <> DialogResult.OK Then
					Return
				End If
				Using stream As Stream = saveFileDialog.OpenFile()
					Dim fileName As String = saveFileDialog.FileName
					If (Not String.IsNullOrEmpty(fileName)) Then
						Dim ext As String = Path.GetExtension(fileName)
						If ext = ".rtf" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.Rtf)
						ElseIf ext = ".txt" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.PlainText)
						ElseIf ext = ".htm" OrElse ext = ".html" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.Html)
						ElseIf ext = ".mht" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.Mht)
						ElseIf ext = ".docx" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.OpenXml)
						ElseIf ext = ".odt" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.OpenDocument)
						ElseIf ext = ".xml" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.WordML)
						ElseIf ext = ".epub" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.ePub)
						ElseIf ext = ".doc" Then
							Me.documentServer.SaveDocument(stream, DocumentFormat.Doc)
						ElseIf ext = ".pdf" Then
							Me.documentServer.ExportToPdf(stream)
						End If
					End If
				End Using
			End Using
		End Sub
	End Class
End Namespace
