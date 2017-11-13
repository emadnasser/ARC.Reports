Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextSearch
		Inherits TutorialControlBase
		Private ReadOnly documentProcessor As New PdfDocumentProcessor()
		Private ReadOnly fileHelper As PdfFileHelper
		Private form As PdfTextSearchResultsForm

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			fileHelper = New PdfFileHelper(documentProcessor, pdfViewer)
			Enabled = fileHelper.LoadDocument(DemoUtils.GetRelativePath("TextSearch.pdf"))
		End Sub
		Private Function GetForm() As PdfTextSearchResultsForm
			If form Is Nothing OrElse form.IsDisposed Then
				form = New PdfTextSearchResultsForm()
			End If
			Return form
		End Function
		Private Sub OnDocumentChanged(ByVal sender As Object, ByVal e As PdfDocumentChangedEventArgs) Handles pdfViewer.DocumentChanged
			Dim form As PdfTextSearchResultsForm = GetForm()
			If form.Visible Then
				form.Hide()
			End If
			buttonSearch.Enabled = Not String.IsNullOrEmpty(pdfViewer.DocumentFilePath)
		End Sub
		Private Sub OnButtonOpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOpen.Click
			fileHelper.OpenFile()
		End Sub
		Private Sub OnButtonSearchClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSearch.Click
			Dim textToFind As String = textEditTextToFind.Text
			Dim wordCount As Integer = Convert.ToInt32(spinEditWordCount.Value)
			Dim items As New List(Of String)()
			Try
				Do While documentProcessor.FindText(textToFind).Status = PdfTextSearchStatus.Found
					Dim text As New StringBuilder()
					For i As Integer = 0 To wordCount - 1
						Dim nextWord As PdfWord = documentProcessor.NextWord()
						If nextWord Is Nothing Then
							Exit For
						End If
						text.Append(nextWord.Text)
						text.Append(" ")
					Next i
					items.Add(text.ToString())
				Loop
			Catch
			End Try
			Dim form As PdfTextSearchResultsForm = GetForm()
			If form.Visible Then
				form.WindowState = FormWindowState.Normal
				form.Focus()
			Else
				form.SetItems(items)
				form.Show(Me)
			End If
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				documentProcessor.Dispose()
				fileHelper.Dispose()
				If form IsNot Nothing Then
					form.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
