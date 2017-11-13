Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraSplashScreen
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfTextExtraction
		Inherits TutorialControlBase
		Private ReadOnly documentProcessor As New PdfDocumentProcessor()
		Private ReadOnly fileHelper As PdfFileHelper
		Private form As PdfTextExtractionResultsForm

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			fileHelper = New PdfFileHelper(documentProcessor, pdfViewer)
			fileHelper.LoadDocument(DemoUtils.GetRelativePath("TextExtraction.pdf"))
		End Sub
		Private Function GetForm() As PdfTextExtractionResultsForm
			If form Is Nothing OrElse form.IsDisposed Then
				form = New PdfTextExtractionResultsForm()
			End If
			Return form
		End Function
		Private Sub OnDocumentChanged(ByVal sender As Object, ByVal e As PdfDocumentChangedEventArgs) Handles pdfViewer.DocumentChanged
			buttonExtractText.Enabled = Not String.IsNullOrEmpty(pdfViewer.DocumentFilePath)
			Dim form As PdfTextExtractionResultsForm = GetForm()
			If form.Visible Then
				form.Hide()
			End If
		End Sub
		Private Sub OnButtonOpenClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOpen.Click
			fileHelper.OpenFile()
		End Sub
		Private Sub OnButtonExtractClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonExtractText.Click
			SplashScreenManager.ShowDefaultWaitForm("Please wait while", "The text is being extracted")
			Dim text As String = String.Empty
			Try
				text = documentProcessor.Text
			Catch
			End Try
			SplashScreenManager.CloseDefaultWaitForm()
			Dim form As PdfTextExtractionResultsForm = GetForm()
			If form.Visible Then
				form.WindowState = FormWindowState.Normal
				form.Focus()
			Else
				form.SetText(text)
				form.Show()
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
