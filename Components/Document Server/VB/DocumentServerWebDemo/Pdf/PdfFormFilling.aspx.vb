Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Web.UI
Imports DevExpress.Pdf
Imports DevExpress.Web
Imports DevExpress.Web.Demos
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Web.Hosting

Partial Public Class PdfFormFilling
	Inherits Page
	Private Const formKey As String = "Form"

	Private Function CreateDocumentProcessor() As PdfDocumentProcessor
		Dim documentProcessor As New PdfDocumentProcessor()
		Dim stream As Stream = TryCast(Session(formKey), Stream)
		If stream Is Nothing Then
			documentProcessor.LoadDocument(HostingEnvironment.MapPath("~/App_Data/FormDemo.pdf"))
			documentProcessor.ResetFormData()
		Else
			documentProcessor.LoadDocument(stream, True)
		End If
		Return documentProcessor
	End Function
	Private Sub UpdateImage()
		Using documentProcessor As PdfDocumentProcessor = CreateDocumentProcessor()
		Using bitmap As Bitmap = documentProcessor.CreateBitmap(1, 900)
		Using outStream As New MemoryStream()
			bitmap.Save(outStream, ImageFormat.Png)
			pageImage.Src = "data:image/png;base64," & Convert.ToBase64String(outStream.GetBuffer())
		End Using
		End Using
		End Using
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Utils.RegisterCssLink(Me, "~/Content/PdfDemos.css")
		ASPxWebControl.SetIECompatibilityModeEdge()
		If (Not IsPostBack) Then
			UpdateImage()
			Dim selectedIndex As Integer = 0
			Using documentProcessor As PdfDocumentProcessor = CreateDocumentProcessor()
				For Each field As PdfInteractiveFormField In documentProcessor.Document.AcroForm.Fields
					If field.Name = "Nationality" Then
						Dim choiceField As PdfChoiceFormField = TryCast(field, PdfChoiceFormField)
						If choiceField IsNot Nothing Then
							For i As Integer = 0 To choiceField.Options.Count - 1
								Dim [option] As PdfOptionsFormFieldOption = choiceField.Options(i)
								If [option].ExportText = "United States" Then
									selectedIndex = i
								End If
								cbeNationality.Items.Add([option].ExportText)
							Next i
						End If
					End If
				Next field
			End Using
			cbeNationality.SelectedIndex = selectedIndex
		End If
	End Sub

	Protected Sub OnCallback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		Dim formData As New PdfFormData()
		formData("FirstName").Value = tbFirstName.Text
		formData("LastName").Value = tbLastName.Text
		formData("Gender").Value = If(rbMale.Checked, "Male", "Female")
		Dim dateOfBirth As DateTime = deDate.Date
		formData("DD").Value = dateOfBirth.Day.ToString()
		formData("MM").Value = dateOfBirth.Month.ToString()
		formData("YYYY").Value = dateOfBirth.Year.ToString()
		formData("PassportNo").Value = tePassport.Text
		formData("Nationality").Value = cbeNationality.Text
		formData("Address").Value = tbAddress.Text
		formData("VisaNo").Value = tbVisa.Text
		formData("FlightNo").Value = tbFlight.Text
		UpdateImage()
		Using documentProcessor As PdfDocumentProcessor = CreateDocumentProcessor()
			If formData.Value IsNot Nothing Then
				documentProcessor.ApplyFormData(formData)
			End If
			Dim stream As Stream = New MemoryStream()
			documentProcessor.SaveDocument(stream, True)
			Session(formKey) = stream
		End Using
		UpdateImage()
	End Sub
End Class
