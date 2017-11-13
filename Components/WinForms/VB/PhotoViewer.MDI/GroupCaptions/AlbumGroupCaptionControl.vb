Imports Microsoft.VisualBasic
Imports System

Namespace PhotoViewer
	Partial Public Class AlbumGroupCaptionControl
		Inherits PhotoGroupCaptionControlBase
		Public Sub New()
			InitializeComponent()
		End Sub
		Private albumCore As AlbumData
		Public Property Album() As AlbumData
			Get
				Return albumCore
			End Get
			Set(ByVal value As AlbumData)
				If Album Is value Then
					Return
				End If
				albumCore = value
				OnAlbumChanged()
			End Set
		End Property
		Protected Overridable Sub OnAlbumChanged()
			nameLabel.Text = Album.Name
			dataLabel.Text = Album.Date.ToLongDateString()
		End Sub
		Protected Overrides Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim gForm As AlbumGalleryForm = TryCast(GalleryForm, AlbumGalleryForm)
			If gForm IsNot Nothing Then
                gForm.RemoveAlbum()
                gForm.MainForm.UpdateData(True)
                gForm.Close()
			End If
		End Sub
		Protected Overrides Sub OnEditButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim gForm As AlbumGalleryForm = TryCast(GalleryForm, AlbumGalleryForm)
			If gForm IsNot Nothing Then
				gForm.EditAlbum()
			End If
		End Sub
		Public Sub HideEditButtons()
			removeLabel.Visible = False
			editLabel.Visible = False
			separatorLabel.Visible = False
		End Sub
	End Class
End Namespace
