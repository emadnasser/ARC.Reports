Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports DevExpress.Docs.Text
Imports System.Text
Imports DevExpress.Web
Imports DevExpress.Web.Internal

Partial Public Class Miscellaneous_EncodingDetection
	Inherits System.Web.UI.Page
	Private encodingFiles() As String = { "english.txt", "german.txt", "spanish.txt", "russian.txt", "greek.txt", "chinese.txt", "japanese.txt"}

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
			Return
		End If
		cbLanguage.Items.AddRange(encodingFiles)
		LoadFile(cbLanguage.Items(0).Text)
		UpdateFromSession()
	End Sub
	Protected Sub ASPxUploadControl1_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
		Dim file As UploadedFile = ASPxUploadControl1.UploadedFiles(0)
		Session("CurrentFile") = e.UploadedFile.FileName
		Using stream As Stream = file.FileContent
			ReadText(stream)
		End Using
		Dim bytes() As Byte = file.FileBytes
		DecodeText(bytes)
	End Sub
	Protected Sub CallbackPanel_Callback(ByVal source As Object, ByVal e As CallbackEventArgsBase)
		UpdateFromSession()
	End Sub
	Private Sub UpdateFromSession()
		memoNoEncoding.Text = TryCast(Session("NoEncodingDetect"), String)
		memoEncoding.Text = TryCast(Session("EncodingDetect"), String)
		lblEncoding.Text = TryCast(Session("Encoding"), String)
		lblCurrentFile.Text = TryCast(Session("CurrentFile"), String)
	End Sub
	Protected Sub cbLanguage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If cbLanguage.SelectedIndex <> -1 Then
			Dim fileName As String = cbLanguage.SelectedItem.Text
			LoadFile(fileName)
		End If
	End Sub

	Private Sub LoadFile(ByVal fileName As String)
		Dim path As String = Server.MapPath("~/App_Data/EncodingFiles/") & fileName
		Session("CurrentFile") = fileName
		LoadFileNoDetection(path)
		LoadFileWithDetection(path)
	End Sub
	Private Sub LoadFileNoDetection(ByVal path As String)
		Session("NoEncodingDetect") = File.ReadAllText(path)
	End Sub
	Private Sub LoadFileWithDetection(ByVal path As String)
		Dim bytes() As Byte = File.ReadAllBytes(path)
		DecodeText(bytes)
	End Sub
	Private Sub DecodeText(ByVal bytes() As Byte)
		Dim detector As New EncodingDetector()
		Dim encoding As Encoding = detector.Detect(bytes)
		If encoding Is Nothing Then
			encoding = Encoding.Default
		End If
		Session("Encoding") = encoding.EncodingName & " [" & encoding.BodyName & "]"
		Session("EncodingDetect") = encoding.GetString(bytes)
	End Sub
	Private Sub ReadText(ByVal stream As Stream)
		Dim reader As New StreamReader(stream)
		Session("NoEncodingDetect") = reader.ReadToEnd()
	End Sub
End Class
