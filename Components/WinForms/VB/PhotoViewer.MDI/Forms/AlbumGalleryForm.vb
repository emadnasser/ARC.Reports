Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports PhotoViewer.Data

Namespace PhotoViewer
	Public Class AlbumGalleryForm
		Inherits GalleryForm
		Public Sub New(ByVal controller As PhotoViewerDataController, ByVal album As AlbumData)
			MyBase.New(controller)
			Me.albumCore = album
			Text = album.Name
			UpdateGalleryContent(True)
		End Sub
		Private albumCore As AlbumData
		Public ReadOnly Property Album() As AlbumData
			Get
				Return albumCore
			End Get
		End Property
		Protected Overrides Sub UpdateGalleryContent(ByVal forceProcess As Boolean)
			If Album Is Nothing Then
				ClearGalleryAndImages()
				Return
			End If
			If forceProcess Then
				ProcessAlbum()
			End If
			ScrollToAlbum(Album, (Not forceProcess))
			UpdateItemsEnabledState()
		End Sub
		Protected Overrides Sub RemoveImagesCore(ByVal images As List(Of GalleryItem))
			controller.RemoveImagesFromAlbum(GetSelectedItems(images), Album, Me)
		End Sub
		Private Sub ProcessAlbum()
			gallery.Gallery.BeginUpdate()
			Try
				ClearGalleryAndImages()
				ProcessAlbum(Album)
			Finally
				gallery.Gallery.EndUpdate()
			End Try
		End Sub
		Private Sub ProcessAlbum(ByVal albumData As AlbumData, ByVal showEditButtons As Boolean)
			Dim group As GalleryItemGroup = CreateAlbumGroup(albumData)
			Dim control As AlbumGroupCaptionControl = CType(group.CaptionControl, AlbumGroupCaptionControl)
			If (Not showEditButtons) Then
				control.HideEditButtons()
			End If
			gallery.Gallery.Groups.Add(group)
			For Each pData As PathData In albumData.Files
				group.Items.Add(CreatePhotoGalleryItem(pData.Path))
			Next pData
		End Sub
		Private Sub ProcessAlbum(ByVal albumData As AlbumData)
			ProcessAlbum(albumData, controller.CanEditAlbum(albumData))
		End Sub
		Friend Sub RemoveAlbum()
			controller.RemoveAlbum(Album, Me)
		End Sub
		Friend Sub EditAlbum()
			AlbumPropertiesForm.EditAlbum(controller, Album, Me)
		End Sub
		Private Function CreateAlbumGroup(ByVal albumData As AlbumData) As GalleryItemGroup
			Dim group As GalleryItemGroup = New GalleryItemGroup()
			group.Tag = albumData
			group.Caption = albumData.Name
			group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch
			group.CaptionControl = CreateAlbumGroupCaptionControl(albumData)
			Return group
		End Function
		Private Function CreateAlbumGroupCaptionControl(ByVal albumData As AlbumData) As Control
			Dim control As AlbumGroupCaptionControl = New AlbumGroupCaptionControl()
			control.Album = albumData
			control.GalleryForm = Me
			Return control
		End Function
	End Class
End Namespace
