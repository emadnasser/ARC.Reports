Imports Microsoft.VisualBasic
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Pdf
Imports DevExpress.XtraEditors

Namespace DevExpress.Docs.Demos
	Partial Public Class PdfSignatureDemo
		Inherits TutorialControlBase
		Private Class CertItem
			Private privateName As String
			Public Property Name() As String
				Get
					Return privateName
				End Get
				Set(ByVal value As String)
					privateName = value
				End Set
			End Property
			Private privateCert As X509Certificate2
			Public Property Cert() As X509Certificate2
				Get
					Return privateCert
				End Get
				Set(ByVal value As X509Certificate2)
					privateCert = value
				End Set
			End Property

			Public Overrides Function ToString() As String
				Return Name
			End Function
		End Class

		Private Shared Function SelectCertificates() As X509Certificate2Collection
			Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
			store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
			Dim collection As X509Certificate2Collection = store.Certificates
			collection = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, True)
			collection = collection.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, True)
			Return collection
		End Function

		Private ReadOnly documentProcessor As New PdfDocumentProcessor()

		Public Overrides ReadOnly Property NoGap() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Try
				Dim path As String = DemoUtils.GetRelativePath("SignDemo.pdf")
				If PdfFileHelper.LoadDocument(pdfViewer, path) Then
					documentProcessor.LoadDocument(path)
					Dim newCert As New X509Certificate2(DemoUtils.GetRelativePath("SignDemo.pfx"), "dxdemo")
					lbCerts.Items.Add((New CertItem() With {.Name = newCert.Subject, .Cert = newCert}))
					lbCerts.SelectedIndex = 0
					For Each cert As X509Certificate2 In SelectCertificates()
						lbCerts.Items.Add(New CertItem() With {.Name = cert.Subject, .Cert = cert})
					Next cert
					lbCerts.DisplayMember = "Subject"
				Else
					Enabled = False
				End If
			Catch
				XtraMessageBox.Show(PdfFileHelper.DemoOpeningErrorMessage, "Error")
				Enabled = False
			End Try
		End Sub
		Private Sub OnButtonSignClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSign.Click
			Dim signature As New PdfSignature((CType(lbCerts.SelectedItem, CertItem)).Cert) With {.Location = teLocation.Text, .ContactInfo = teContactInfo.Text, .Reason = teReason.Text}
			PdfFileHelper.Save(documentProcessor, New PdfSaveOptions() With {.Signature = signature})
		End Sub
		Private Sub OnButtonNewCertificateClick(ByVal sender As Object, ByVal e As EventArgs) Handles buttonNewCertificate.Click
			Using openDialog As New OpenFileDialog()
				openDialog.Filter = "X.509 Certificate (*.cer; *.crt, *.pfx)|*.cer;*.crt;*.pfx"
				openDialog.RestoreDirectory = True
				If openDialog.ShowDialog() = DialogResult.OK Then
					Try
						Dim newCert As New X509Certificate2(openDialog.FileName)
						If newCert.HasPrivateKey Then
							AddCertificate(newCert)
						Else
							XtraMessageBox.Show("The certificate must contain a private key.", "Invalid certificate", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End If
					Catch
						Try
							Dim password As New PasswordForm(openDialog.FileName)
							If password.ShowDialog() = DialogResult.OK Then
								Dim newCert As New X509Certificate2(openDialog.FileName, password.Password)
								AddCertificate(newCert)
							End If
						Catch
							XtraMessageBox.Show("The password for the certificate is incorrect.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error)
						End Try
					End Try
				End If
			End Using
		End Sub
		Private Sub AddCertificate(ByVal newCert As X509Certificate2)
			lbCerts.Items.Add((New CertItem() With {.Name = newCert.Subject, .Cert = newCert}))
			lbCerts.SelectedIndex = lbCerts.Items.Count - 1
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
				documentProcessor.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
