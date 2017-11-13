Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFormFilling
		Inherits TutorialControlBase
		Private Shared ReadOnly path As String = DemoUtils.GetRelativePath("FormDemo.pdf")

		Private stream As Stream = New MemoryStream()

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			deDate.Properties.MinValue = New DateTime(1901, 1, 1)
			deDate.Properties.MaxValue = DateTime.Now
			deDate.DateTime = New DateTime(1985, 8, 30)
			Try
				Using documentProcessor As New PdfDocumentProcessor()
					documentProcessor.LoadDocument(path)
					documentProcessor.ResetFormData()
					For Each field As PdfInteractiveFormField In documentProcessor.Document.AcroForm.Fields
						If field.Name = "Nationality" Then
							Dim choiceField As PdfChoiceFormField = TryCast(field, PdfChoiceFormField)
							If choiceField IsNot Nothing Then
								For Each [option] As PdfOptionsFormFieldOption In choiceField.Options
									cbeNationality.Properties.Items.Add([option].ExportText)
								Next [option]
							End If
						End If
					Next field
					documentProcessor.SaveDocument(stream)
				End Using
				Enabled = PdfFileHelper.LoadDocument(pdfViewer, stream)
			Catch
				XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error")
			End Try
		End Sub

		Private Sub SubmitClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSubmit.Click
			Dim formData As New PdfFormData()
			formData("FirstName").Value = teFirstName.Text
			formData("LastName").Value = teLastName.Text
			formData("Gender").Value = If(ceMale.Checked, "Male", "Female")
			Dim dateOfBirth As DateTime = deDate.DateTime
			formData("DD").Value = dateOfBirth.Day.ToString()
			formData("MM").Value = dateOfBirth.Month.ToString()
			formData("YYYY").Value = dateOfBirth.Year.ToString()
			formData("PassportNo").Value = tePassport.Text
			formData("Nationality").Value = cbeNationality.Text
			formData("Address").Value = teAddress.Text
			formData("VisaNo").Value = teVisa.Text
			formData("FlightNo").Value = teFlight.Text
			Using documentProcessor As New PdfDocumentProcessor()
				documentProcessor.LoadDocument(stream)
				documentProcessor.ApplyFormData(formData)
				Using newStream As Stream = New MemoryStream()
					documentProcessor.SaveDocument(newStream)
					stream.Position = 0
					pdfViewer.LoadDocument(newStream)
				End Using
			End Using
		End Sub

		Private Sub DocumentClosing(ByVal sender As Object, ByVal e As PdfDocumentClosingEventArgs) Handles pdfViewer.DocumentClosing
		End Sub
	End Class
End Namespace
