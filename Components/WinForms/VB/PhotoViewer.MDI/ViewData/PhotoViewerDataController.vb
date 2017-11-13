Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace PhotoViewer.Data
	Public Class PhotoViewerDataController
		Private ReadOnly Data As PhotoViewerData
		Public Event DataChanged As EventHandler
		Public Sub New(ByVal data As PhotoViewerData)
			Me.Data = data
		End Sub
		Public Sub AddToOthers(ByVal items() As String, ByVal owner As Form)
			If items.Length > 0 Then
				Dim addedCount As Integer = 0
				For Each item As String In items
					If (Not IsFileAdded(item)) Then
						Data.Others.Files.Add(CreateFilePathData(item))
						addedCount += 1
					End If
				Next item
				If addedCount > 0 Then
					RaiseDataChanged(Data.Others)
				End If
			End If
		End Sub
		Public Sub AddToAlbum(ByVal items() As String, ByVal album As AlbumData, ByVal owner As Form)
			If album Is Nothing Then
				album = AddNewAlbum(owner)
			End If
			If album Is Nothing Then
				Return
			End If
			If items.Length > 0 Then
				Dim addedCount As Integer = 0
				For Each item As String In items
					If (Not album.Files.Contains(item)) Then
						album.Files.Add(CreateFilePathData(item))
						addedCount += 1
					End If
				Next item
				If addedCount > 0 Then
					RaiseDataChanged(album)
				End If
			End If
		End Sub
		Public Sub RemoveImagesFromAlbum(ByVal items() As String, ByVal album As AlbumData, ByVal owner As Form)
			Dim messageText As String = String.Empty
			messageText = "Are you sure you want to remove checked items from album '" & album.Name & "'?"
			If XtraMessageBox.Show(owner, messageText, owner.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then
				Return
			End If
			If items.Length > 0 Then
				Dim removeCount As Integer = 0
				For Each file As String In items
					If album.Files.Remove(file) Then
						removeCount += 1
					End If
				Next file
				If removeCount > 0 Then
					RaiseDataChanged(album)
				End If
			End If
		End Sub
		Public Function AddAlbum(ByVal albumName As String, ByVal description As String, ByVal files As List(Of String)) As AlbumData
			Return AddAlbum(albumName, DateTime.Now, description, files)
		End Function
		Public Function AddAlbum(ByVal albumName As String, ByVal albumDate As DateTime, ByVal description As String, ByVal files As List(Of String)) As AlbumData
			Dim album As AlbumData = New AlbumData()
			album.Name = albumName
			album.Date = albumDate
			album.Description = description
			If files IsNot Nothing Then
				For Each file As String In files
					Dim pData As PathData = New PathData()
					pData.Path = file
					album.Files.Add(pData)
				Next file
				RaiseDataChanged(album)
			End If
			Data.Albums.Add(album)
			Return album
		End Function
		Public Function AddFolder(ByVal path As String) As PathData
			If (Not Directory.Exists(path)) Then
				Return Nothing
			End If
			Dim pathData As PathData = CreateFilePathData(path)
			Data.Folders.Add(pathData)
			RaiseDataChanged(pathData)
			Return pathData
		End Function
		Public Function IsFolderAdded(ByVal folderPath As String) As Boolean
			Return Data.Folders.Contains(folderPath)
		End Function
		Public Function IsFileAdded(ByVal fileName As String) As Boolean
			Return Data.Others.Files.Contains(fileName)
		End Function
		Private Function CreateFilePathData(ByVal fileName As String) As PathData
			Dim pdata As PathData = New PathData()
			pdata.Path = fileName
			pdata.Name = Path.GetFileName(fileName)
			Return pdata
		End Function
		Public Sub GenerateSampleData()
			Data.Clear()
			Dim f0 As PathData = AddFolder(DataPath & "\SamplePhotos\Photo1")
			Dim f1 As PathData = AddFolder(DataPath & "\SamplePhotos\Photo2")
			Dim f2 As PathData = AddFolder(DataPath & "\SamplePhotos\Photo3")
			Dim f3 As PathData = AddFolder(DataPath & "\SamplePhotos\Photo4")
			If Data.Folders.Count > 1 Then
				Dim files As List(Of String) = New List(Of String)()
				files.AddRange(GetImagesInFolder(f0))
				files.AddRange(GetImagesInFolder(f1))
				AddAlbum("Sample Album 1", "This is a sample album 1", files)
			End If
			If Data.Folders.Count > 3 Then
				Dim files As List(Of String) = New List(Of String)()
				files.AddRange(GetImagesInFolder(f2))
				files.AddRange(GetImagesInFolder(f3))
				AddAlbum("Sample Album 2", "This is a sample album 2", files)
			End If
			Data.Others.Name = "Other"
			Data.Others.Date = DateTime.Now
			Data.Others.Description = "Other image files"
		End Sub
		Public Function GetImagesInFolder(ByVal folder As PathData) As List(Of String)
			Dim strFilter() As String = New String() { "*bmp", "*tga", "*.jpg", "*.png", "*.gif" }
			Dim files As List(Of String) = New List(Of String)()
			For Each filter As String In strFilter
				Dim str() As String = Directory.GetFiles(folder.Path, filter)
				files.AddRange(str)
			Next filter
			Return files
		End Function
		Public Sub SaveData()
			Data.FirstRun = False
			Dim path As String = ViewDataFile
			If File.Exists(path) Then
				Data.SaveLayoutToXml(path)
			End If
		End Sub
		Public Sub LoadData()
			Data.Clear()
			Dim path As String = ViewDataFile
			If File.Exists(path) Then
				Data.RestoreLayoutFromXml(path)
			End If
			If Data.FirstRun Then
				GenerateSampleData()
			End If
		End Sub
		Public Function CanEditAlbum(ByVal album As AlbumData) As Boolean
			Return Data.Others IsNot album
		End Function
		Public ReadOnly Property ThumbPath() As String
			Get
				Return DataPath & "\Thumbs\"
			End Get
		End Property
		Public ReadOnly Property ViewDataFile() As String
			Get
				Return DataPath & "\data.xml"
			End Get
		End Property
		Protected Function GetDataDir() As String
			Dim path As String = AppDomain.CurrentDomain.BaseDirectory
			For i As Integer = 0 To 9
				path &= "..\"
				If Directory.Exists(path & "Data") Then
					Return path & "Data"
				End If
			Next i
			Return String.Empty
		End Function
		Protected ReadOnly Property DataPath() As String
			Get
				Dim path As String = GetDataDir() & "\PhotoViewer"
				If Directory.Exists(path) Then
					Return path
				End If
				Return String.Empty
			End Get
		End Property
		Public Function GetAlbums() As IEnumerable
			Return Data.Albums
		End Function
		Public Function GetFolders() As IEnumerable
			Return Data.Folders
		End Function
		Public Function RemoveAlbum(ByVal album As AlbumData, ByVal owner As Form) As Boolean
			If XtraMessageBox.Show(owner, "Are you really want to remove album?", owner.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				Data.Albums.Remove(album)
				Return True
			End If
			Return False
		End Function
		Public Function RemoveFolder(ByVal folder As PathData, ByVal owner As Form) As Boolean
			If XtraMessageBox.Show(owner, "Are you really want to remove folder?", owner.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
				Data.Folders.Remove(folder)
				Return True
			End If
			Return False
		End Function
		Public Function AddNewAlbum(ByVal owner As Form) As AlbumData
			Dim form As AlbumPropertiesForm = New AlbumPropertiesForm(Me)
			form.Text = "New album properties"
			form.Owner = owner
			If form.ShowDialog() = DialogResult.OK Then
				Return AddAlbum(form.AlbumName, form.AlbumDate, form.AlbumDescription, Nothing)
			End If
			Return Nothing
		End Function
		Protected Friend Sub RaiseDataChanged(ByVal data As Object)
			RaiseEvent DataChanged(data, EventArgs.Empty)
		End Sub
	End Class
End Namespace
