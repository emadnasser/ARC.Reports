Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Namespace PhotoViewer
	Partial Public Class FolderGroupCaptionControl
		Inherits PhotoGroupCaptionControlBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Private folderCore As PathData
		Public Property Folder() As PathData
			Get
				Return folderCore
			End Get
			Set(ByVal value As PathData)
				If Folder Is value Then
					Return
				End If
				folderCore = value
				OnFolderChanged()
			End Set
		End Property
		Protected Overridable Sub OnFolderChanged()
			nameLabel.Text = Folder.Name
			dataLabel.Text = Directory.GetCreationTime(Folder.Path).ToShortDateString()
		End Sub
		Protected Overrides Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim gForm As FolderGalleryForm = TryCast(GalleryForm, FolderGalleryForm)
			If gForm IsNot Nothing Then
                gForm.RemoveFolder()
                gForm.MainForm.UpdateData(False)
                gForm.Close()
			End If
		End Sub
		Protected Overrides Sub OnGroupIconClick(ByVal sender As Object, ByVal e As EventArgs)
			System.Diagnostics.Process.Start(Folder.Path, "")
		End Sub
	End Class
End Namespace
