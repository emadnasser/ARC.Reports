Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports PhotoViewer.Data

Namespace PhotoViewer
	Public Class FolderGalleryForm
		Inherits GalleryForm
		Public Sub New(ByVal controller As PhotoViewerDataController, ByVal folder As PathData)
			MyBase.New(controller)
			Me.folderCore = folder
			Text = folder.Name
			UpdateGalleryContent(True)
		End Sub
		Private folderCore As PathData
		Public ReadOnly Property Folder() As PathData
			Get
				Return folderCore
			End Get
		End Property
		Protected Overrides Sub UpdateGalleryContent(ByVal forceProcess As Boolean)
			If Folder Is Nothing Then
				ClearGalleryAndImages()
				Return
			End If
			If forceProcess Then
				ProcessFolder()
			End If
			ScrollToFolder(Folder, (Not forceProcess))
			UpdateItemsEnabledState()
		End Sub
		Protected Overrides Sub RemoveImagesCore(ByVal images As List(Of GalleryItem))

		End Sub
		Private Sub ProcessFolder(ByVal folder As PathData)
			Dim group As GalleryItemGroup = CreateFolderGroup(folder)
			gallery.Gallery.Groups.Add(group)
			Dim files As List(Of String) = controller.GetImagesInFolder(folder)
			For Each fileName As String In files
				group.Items.Add(CreatePhotoGalleryItem(fileName))
			Next fileName
		End Sub
		Private Sub ProcessFolder()
			gallery.Gallery.BeginUpdate()
			Try
				ClearGalleryAndImages()
				ProcessFolder(Folder)
			Finally
				gallery.Gallery.EndUpdate()
			End Try
		End Sub
		Friend Sub RemoveFolder()
			controller.RemoveFolder(Folder, Me)
		End Sub
		Private Function CreateFolderGroup(ByVal folder As PathData) As GalleryItemGroup
			Dim group As GalleryItemGroup = New GalleryItemGroup()
			group.Tag = folder
			group.Caption = folder.Name
			group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch
			group.CaptionControl = CreateFolderGroupCaptionControl(folder)
			Return group
		End Function
		Private Function CreateFolderGroupCaptionControl(ByVal folder As PathData) As Control
			Dim control As FolderGroupCaptionControl = New FolderGroupCaptionControl()
			control.Folder = folder
			control.GalleryForm = Me
			Return control
		End Function
	End Class
End Namespace
