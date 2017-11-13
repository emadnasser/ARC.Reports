Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Pdf
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPdfViewer
Imports DevExpress.Docs.Demos.nwindDataSetTableAdapters

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfDocumentCreationAPI
		Inherits TutorialControlBase
		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Enabled = PdfFileHelper.LoadDocument(pdfViewer, DemoUtils.GetRelativePath("PdfDocumentCreationAPIDemo.pdf"))
		End Sub

		Private Sub OnButtonCreateDocumentClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCreateDocument.Click
			Const imageLocationX As Single = 100
			Const imageLocationY As Single = 100
			Try
				Using stream As New MemoryStream()
					Using documentProcessor As New PdfDocumentProcessor()
						documentProcessor.CreateEmptyDocument(stream)
						Dim document As PdfDocument = documentProcessor.Document
						document.Creator = "PDF Document Processor Demo"
						document.Author = "DevExpress Inc."
						document.Keywords = "PDF, document, server, code, generation, creation API"
						document.Subject = "PDF Document Processor - Document Creation API Demo"
						document.Title = "PDF Document Creation API"
						document.Producer = "Developer Express Inc., " & AssemblyInfo.Version
						Dim black As SolidBrush = CType(Brushes.Black, SolidBrush)
						For Each employee As nwindDataSet.EmployeesRow In GetEmployees()
							Using graphics As PdfGraphics = documentProcessor.CreateGraphics()
								graphics.UseKerning = True
								Using image As New Bitmap(New MemoryStream(employee.Photo))
									graphics.DrawImage(image, New RectangleF(imageLocationX, imageLocationY, image.Width / 2.0f, image.Height / 2.0f))
								End Using
								Using font As New Font("Segoe UI", 32, FontStyle.Bold Or FontStyle.Underline)
									Dim name As String = employee.FirstName & " " & employee.LastName
									graphics.DrawString(name, font, black, 300, 90)
								End Using
								Using font As New Font("Segoe UI", 20)
									graphics.DrawString(employee.Title, font, black, 300, 145)
								End Using
								Using font As New Font("Segoe UI", 14)
									graphics.DrawString(employee.HomePhone, font, black, 300, 200)
									graphics.DrawString(employee.FirstName.ToLower() & "." & employee.LastName.ToLower()(0) & "@example.com", font, black, 300, 230)
								End Using
								Dim pageNumber As Integer = documentProcessor.RenderNewPage(PdfPaperSize.Letter, graphics)
								Dim destination As PdfDestination = documentProcessor.CreateDestination(pageNumber, imageLocationX, imageLocationY)
								document.Bookmarks.Add(New PdfBookmark() With {.Title = employee.FirstName & " " & employee.LastName, .Destination = destination})
							End Using
						Next employee

					End Using
					stream.Position = 0
					pdfViewer.LoadDocument(stream)
					pdfViewer.NavigationPaneVisibility = PdfNavigationPaneVisibility.Visible
				End Using
				buttonSave.Enabled = True
			Catch
				XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error")
				Enabled = False
			End Try
		End Sub
		Private Function GetEmployees() As IEnumerable(Of nwindDataSet.EmployeesRow)
			Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
			Dim nwindDataSet As New nwindDataSet()
			Dim employeesTableAdapter As New EmployeesTableAdapter()
			Dim connection As New OleDbConnection()
			DemoUtils.SetConnectionString(connection, path)
			employeesTableAdapter.Connection = connection
			employeesTableAdapter.Fill(nwindDataSet.Employees)
			Dim result As New List(Of nwindDataSet.EmployeesRow)()
			For Each employee As nwindDataSet.EmployeesRow In nwindDataSet.Employees
				result.Add(employee)
			Next employee
			Return result
		End Function

		Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSave.Click
			Dim fileName As String = PdfFileHelper.SaveFileDialog()
			Try
				pdfViewer.DocumentCreator = "PDF Document Processor Demo"
				pdfViewer.DocumentProducer = "Developer Express Inc., " & AssemblyInfo.Version
				pdfViewer.SaveDocument(fileName)
			Catch
				XtraMessageBox.Show(String.Format(PdfFileHelper.SaveErrorMessage, fileName), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			End Try
		End Sub
	End Class
End Namespace
