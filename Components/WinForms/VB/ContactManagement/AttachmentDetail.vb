Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace ContactManagement
	''' <summary>
	''' Summary description for AttachmentDetail.
	''' </summary>
	Public Partial Class AttachmentDetail
		Inherits System.Windows.Forms.Form
		Private Sub SetupBindings()
			txtOID.DataBindings.Add("Text", theAttachment, "Oid")
			txtAttachmentName.DataBindings.Add("Text", theAttachment, "Name")
			If Not theAttachment.Document Is Nothing Then
				Dim stream As Stream = New MemoryStream()
				stream.Write(theAttachment.Document, 0, theAttachment.Document.Length)
				stream.Position = 0
				txtDocument.LoadFile(stream, RichTextBoxStreamType.RichText)
			End If
		End Sub

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Public WriteOnly Property Attachment() As Attachment
			Set
				theAttachment = Value
				SetupBindings()
			End Set
		End Property

		Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
			Dim fd As OpenFileDialog = New OpenFileDialog()
			fd.CheckFileExists = True
			fd.CheckPathExists = True
			fd.Filter = "Rich Text Format(*.rtf)|*.rtf"
			fd.FilterIndex = 0
			If fd.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				txtDocument.LoadFile(fd.OpenFile(), RichTextBoxStreamType.RichText)
			End If
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
			Dim stream As MemoryStream = New MemoryStream()
			txtDocument.SaveFile(stream, RichTextBoxStreamType.RichText)
			stream.Close()
			theAttachment.Document = stream.GetBuffer()
			theAttachment.Save()
		End Sub
	End Class
End Namespace
