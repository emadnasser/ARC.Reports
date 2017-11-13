Imports Microsoft.VisualBasic
Imports System
Imports System.Security
Imports DevExpress.Pdf
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfPasswordProtection
		Inherits TutorialControlBase
		Private Shared ReadOnly path As String = DemoUtils.GetRelativePath("EncryptDemo.pdf")

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			imageComboBoxPrinting.Properties.Items.Add(New ImageComboBoxItem("Not allowed", PdfDocumentPrintingPermissions.NotAllowed, 0))
			imageComboBoxPrinting.Properties.Items.Add(New ImageComboBoxItem("Low quality", PdfDocumentPrintingPermissions.LowQuality, 0))
			imageComboBoxPrinting.Properties.Items.Add(New ImageComboBoxItem("Allowed", PdfDocumentPrintingPermissions.Allowed, 0))
			imageComboBoxPrinting.SelectedIndex = 2
			imageComboBoxDataExtraction.Properties.Items.Add(New ImageComboBoxItem("Not allowed", PdfDocumentDataExtractionPermissions.NotAllowed, 0))
			imageComboBoxDataExtraction.Properties.Items.Add(New ImageComboBoxItem("Accessibility", PdfDocumentDataExtractionPermissions.Accessibility, 0))
			imageComboBoxDataExtraction.Properties.Items.Add(New ImageComboBoxItem("Allowed", PdfDocumentDataExtractionPermissions.Allowed, 0))
			imageComboBoxDataExtraction.SelectedIndex = 2
			imageComboBoxModifying.Properties.Items.Add(New ImageComboBoxItem("Not allowed", PdfDocumentModificationPermissions.NotAllowed, 0))
			imageComboBoxModifying.Properties.Items.Add(New ImageComboBoxItem("Document assembling", PdfDocumentModificationPermissions.DocumentAssembling, 0))
			imageComboBoxModifying.Properties.Items.Add(New ImageComboBoxItem("Allowed", PdfDocumentModificationPermissions.Allowed, 0))
			imageComboBoxModifying.SelectedIndex = 2
			imageComboBoxInteractivity.Properties.Items.Add(New ImageComboBoxItem("Not allowed", PdfDocumentInteractivityPermissions.NotAllowed, 0))
			imageComboBoxInteractivity.Properties.Items.Add(New ImageComboBoxItem("Form filling and signing", PdfDocumentInteractivityPermissions.FormFillingAndSigning, 0))
			imageComboBoxInteractivity.Properties.Items.Add(New ImageComboBoxItem("Allowed", PdfDocumentInteractivityPermissions.Allowed, 0))
			imageComboBoxInteractivity.SelectedIndex = 2
			Enabled = PdfFileHelper.LoadDocument(pdfViewer, path)
		End Sub
		Private Sub OnButtonEncryptClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonEncrypt.Click
			Using documentProcessor As New PdfDocumentProcessor()
				documentProcessor.LoadDocument(path)
				Using ownerPassword As New SecureString()
					For Each c As Char In teOwnerPassword.Text
						ownerPassword.AppendChar(c)
					Next c
					Using userPassword As New SecureString()
						For Each c As Char In teUserPassword.Text
							userPassword.AppendChar(c)
						Next c
						Dim encryptionOptions As New PdfEncryptionOptions()
						encryptionOptions.PrintingPermissions = CType(imageComboBoxPrinting.EditValue, PdfDocumentPrintingPermissions)
						encryptionOptions.DataExtractionPermissions = CType(imageComboBoxDataExtraction.EditValue, PdfDocumentDataExtractionPermissions)
						encryptionOptions.ModificationPermissions = CType(imageComboBoxModifying.EditValue, PdfDocumentModificationPermissions)
						encryptionOptions.InteractivityPermissions = CType(imageComboBoxInteractivity.EditValue, PdfDocumentInteractivityPermissions)
						encryptionOptions.OwnerPassword = ownerPassword
						encryptionOptions.UserPassword = userPassword
						PdfFileHelper.Save(documentProcessor, New PdfSaveOptions() With {.EncryptionOptions = encryptionOptions})
					End Using
				End Using
			End Using
		End Sub
	End Class
End Namespace
