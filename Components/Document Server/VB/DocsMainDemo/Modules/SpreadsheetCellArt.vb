Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.DXperience.Demos

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetCellArtModule
		Inherits TutorialControlBase
		Public Sub New()
			InitializeComponent()
			pictureEdit.Image = Image.FromFile(DemoUtils.GetRelativePath("DevExpress.png"))
		End Sub
		Private Sub loadButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadButton.Click
			Dim ofd As New OpenFileDialog()
			ofd.Filter = "All image files (*.bmp,*.jpg,*.jpeg,*.png,*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|BMP files(*.bmp)|*.bmp|JPG files(*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG files(*.png)|*.png|GIF files(*.gif)|*.gif|All files (*.*)|*.*"
			If ofd.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			pictureEdit.Image = Image.FromFile(ofd.FileName)
		End Sub
		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			Dim fileName As String = SpreadsheetTutorialControl.GetSaveFileName("Cell_Art")
			If pictureEdit.Image Is Nothing OrElse String.IsNullOrEmpty(fileName) Then
				Return
			End If
			Dim bitmap As Bitmap = TryCast(pictureEdit.Image, Bitmap)
			If bitmap Is Nothing Then
				Return
			End If
			Dim documentGenerator As New CellArtDocumentGenerator(bitmap)
			Dim book As IWorkbook = documentGenerator.Generate()
			book.SaveDocument(fileName, DocumentFormat.OpenXml)
			SpreadsheetTutorialControl.ShowFile(fileName, Me)
		End Sub
	End Class
End Namespace
