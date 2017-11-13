Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports DevExpress.Web

Public Class FileSystemService
    Inherits ServiceBase

    Private Const MaxRecentFilesCount As Integer = 20
    Private Const MaxFileSizeForUpload As Long = 10485760

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property UserService() As UserService
        Get
            Return DocumentsApp.User
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
    End Sub

    Public Function GetFileFromSource(ByVal filePath As String, ByVal dataSource As String) As Item
        If dataSource = "All" Then
            Return FindItem(filePath)
        End If
        Dim query = GetFilesFromSource(dataSource)
        If query Is Nothing Then
            Return Nothing
        End If
        Dim fileName As String = Path.GetFileName(filePath)
        Return query.FirstOrDefault(Function(file) file.Name = fileName)
    End Function
    Public Function GetFilesFromSource(ByVal dataSource As String) As IEnumerable(Of Item)
        Select Case dataSource
            Case "My"
                Return GetMyFiles()
            Case "Recent"
                Return GetRecentFiles()
            Case "RTFDocs"
                Return GetRTFFiles()
            Case "Sheets"
                Return GetSheetFiles()
        End Select
        Return Nothing
    End Function
    Public Overridable Function CreateNewFileItem(ByVal folderPath As String, ByVal fileName As String) As Item
        Dim folderItem As Item = FindItem(folderPath)
        Dim baseFileName As String = Path.GetFileNameWithoutExtension(fileName)
        Dim fileExtension As String = Path.GetExtension(fileName)
        Dim uniqueFileName As String = fileName
        Dim newFilePath As String = Path.Combine(folderPath, uniqueFileName)
        Dim counter As Integer = 1
        Do While FindItem(newFilePath) IsNot Nothing
            uniqueFileName = baseFileName & " (" & counter & ")" & fileExtension
            newFilePath = Path.Combine(folderPath, uniqueFileName)
            counter += 1
        Loop
        Dim newFileItem As New Item() With {.Name = uniqueFileName, .Content = Nothing, .Owner = UserService.CurrentUser, .ParentItem = folderItem, .CreationTime = Date.UtcNow, .LastAccessTime = Date.UtcNow, .LastWriteTime = Date.UtcNow, .IsFolder = False}
        DataService.AddItem(newFileItem)
        DataService.SaveChanges()
        Return newFileItem
    End Function
    Public Function FindItem(ByVal relativeName As String) As Item
        Dim itemNames() As String = relativeName.Split(Path.DirectorySeparatorChar)
        Dim rootItemName As String = itemNames(0)
        Dim query = DataService.Items.Where(Function(item) item.ParentItem Is Nothing AndAlso item.IsFolder AndAlso item.Name = rootItemName)
        Dim childItemsQuery = DataService.Items.Where(Function(item) item.ParentItem IsNot Nothing)

        For i As Integer = 1 To itemNames.Length - 1
            Dim itemName As String = itemNames(i)
            query = childItemsQuery.Join(query, Function(childItem) childItem.ParentItem.Id, Function(parentItem) parentItem.Id, Function(childItem, parentItem) childItem).Where(Function(item) item.Name = itemName)
        Next i

        Return query.FirstOrDefault()
    End Function
    Public Function GetFolderLastWriteTime(ByVal folderItem As Item) As Date
        Dim result As Date = DataService.Items.Where(Function(item) item.ParentItem IsNot Nothing AndAlso item.ParentItem.Id = folderItem.Id AndAlso (Not item.IsFolder)).Select(Function(item) item.LastWriteTime).OrderByDescending(Function(time) time).FirstOrDefault()

        Dim defaultTime As Date = Nothing
        If result = defaultTime OrElse result < folderItem.LastWriteTime Then
            result = folderItem.LastWriteTime
        End If

        Return result
    End Function
    Public Overridable Function GetMaxFileSizeForUpload() As Long
        Return MaxFileSizeForUpload
    End Function

    Private Function GetAllFiles() As IEnumerable(Of Item)
        Return DataService.Items.Where(Function(item) (Not item.IsFolder))
    End Function
    Private Function GetFilesByExtensions(ByVal extensions() As String) As IEnumerable(Of Item)
        Return GetAllFiles().Where(Function(item) extensions.Contains(Path.GetExtension(item.Name))).OrderByDescending(Function(item) item.LastWriteTime)
    End Function

    Private Function GetMyFiles() As IEnumerable(Of Item)
        Dim currentUser As User = UserService.CurrentUser
        Return GetAllFiles().Where(Function(item) item.Owner.Id = currentUser.Id).OrderByDescending(Function(item) item.LastWriteTime).Take(MaxRecentFilesCount).GroupBy(Function(item) item.Name).Select(Function(itemGroup) itemGroup.First())
    End Function
    Private Function GetRecentFiles() As IEnumerable(Of Item)
        Return GetAllFiles().OrderByDescending(Function(item) item.LastWriteTime).Take(MaxRecentFilesCount).GroupBy(Function(item) item.Name).Select(Function(itemGroup) itemGroup.First())
    End Function
    Private Function GetRTFFiles() As IEnumerable(Of Item)
        Dim extensions() As String = { ".doc", ".docx", ".rtf" }
        Return GetFilesByExtensions(extensions)
    End Function
    Private Function GetSheetFiles() As IEnumerable(Of Item)
        Dim extensions() As String = { ".xlsx" }
        Return GetFilesByExtensions(extensions)
    End Function
End Class

Public Class FilteredFileSystemProvider
    Inherits FileSystemProviderBase

    Private Property DocumentsApp() As DocumentsApp
    Private ReadOnly Property Data() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property

    Private Property FileSizeCache() As Dictionary(Of Long, Long)

    Public Sub New(ByVal app As DocumentsApp, ByVal rootFolder As String)
        MyBase.New(rootFolder)
        DocumentsApp = app
        FileSizeCache = New Dictionary(Of Long, Long)()
    End Sub


    Private fileQuery_Renamed As IEnumerable(Of Item)
    Public Property FileQuery() As IEnumerable(Of Item)
        Get
            Return Me.fileQuery_Renamed
        End Get
        Set(ByVal value As IEnumerable(Of Item))
            Me.fileQuery_Renamed = value
            Me.fileQueryInternal_Renamed = Nothing
        End Set
    End Property

    Private fileQueryInternal_Renamed As IEnumerable(Of Item)
    Private ReadOnly Property FileQueryInternal() As IEnumerable(Of Item)
        Get
            If Me.fileQueryInternal_Renamed Is Nothing Then
                Me.fileQueryInternal_Renamed = FileQuery.ToList()
            End If
            Return Me.fileQueryInternal_Renamed
        End Get
    End Property

    Private Function FindFileItem(ByVal file As FileManagerFile) As Item
        Return FileQueryInternal.FirstOrDefault(Function(item) item.Id.ToString() = file.Id)
    End Function
    Private Function IsRootFolder(ByVal folder As FileManagerFolder) As Boolean
        Return String.IsNullOrEmpty(folder.RelativeName)
    End Function

    Public Overrides ReadOnly Property RootFolderDisplayName() As String
        Get
            Return ""
        End Get
    End Property

    Public Overrides Function GetFiles(ByVal folder As FileManagerFolder) As IEnumerable(Of FileManagerFile)
        If Not IsRootFolder(folder) Then
            Return New FileManagerFile(){}
        End If
        Return FileQueryInternal.Select(Function(item) New FileManagerFile(Me, folder, item.Name, item.Id.ToString()))
    End Function
    Public Overrides Function GetFolders(ByVal parentFolder As FileManagerFolder) As IEnumerable(Of FileManagerFolder)
        Return New FileManagerFolder(){}
    End Function
    Public Overrides Function Exists(ByVal file As FileManagerFile) As Boolean
        Return FindFileItem(file) IsNot Nothing
    End Function
    Public Overrides Function Exists(ByVal folder As FileManagerFolder) As Boolean
        Return IsRootFolder(folder)
    End Function
    Public Overrides Function ReadFile(ByVal file As FileManagerFile) As Stream
        Dim fileItem As Item = FindFileItem(file)
        Return Data.ReadFileContent(fileItem)
    End Function
    Public Overrides Function GetLastWriteTime(ByVal file As FileManagerFile) As Date
        Dim fileItem As Item = FindFileItem(file)
        Return fileItem.LastWriteTime
    End Function

    Public Overrides Function GetThumbnailUrl(ByVal file As FileManagerFile) As String
        Dim fileItem As Item = FindFileItem(file)
        Return DocumentsApp.Image.GetThumbnailUrl(fileItem)
    End Function

    Public Overrides Sub CreateFolder(ByVal parent As FileManagerFolder, ByVal name As String)
    End Sub
    Public Overrides Sub DeleteFile(ByVal file As FileManagerFile)
        Dim fileItem As Item = FindFileItem(file)
        Data.DeleteItem(fileItem)
        Data.SaveChanges()
    End Sub
    Public Overrides Sub DeleteFolder(ByVal folder As FileManagerFolder)
    End Sub
    Public Overrides Sub MoveFile(ByVal file As FileManagerFile, ByVal newParentFolder As FileManagerFolder)
    End Sub
    Public Overrides Sub MoveFolder(ByVal folder As FileManagerFolder, ByVal newParentFolder As FileManagerFolder)
    End Sub
    Public Overrides Sub RenameFile(ByVal file As FileManagerFile, ByVal name As String)
    End Sub
    Public Overrides Sub RenameFolder(ByVal folder As FileManagerFolder, ByVal name As String)
    End Sub
    Public Overrides Sub UploadFile(ByVal folder As FileManagerFolder, ByVal fileName As String, ByVal content As Stream)
    End Sub
    Public Overrides Sub CopyFile(ByVal file As FileManagerFile, ByVal newParentFolder As FileManagerFolder)
    End Sub
    Public Overrides Sub CopyFolder(ByVal folder As FileManagerFolder, ByVal newParentFolder As FileManagerFolder)
    End Sub
    Public Overrides Function GetLength(ByVal file As FileManagerFile) As Long
        Dim result As Long = Nothing
        Dim fileItem As Item = FindFileItem(file)
        If Not FileSizeCache.TryGetValue(fileItem.Id, result) Then
            result = Data.GetFileSize(fileItem)
            FileSizeCache.Add(fileItem.Id, result)
        End If
        Return result
    End Function
End Class

Public Class GeneralFileSystemProvider
    Inherits FileSystemProviderBase

    Private Property DocumentsApp() As DocumentsApp
    Private ReadOnly Property Data() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property

    Private Property FolderCache() As Dictionary(Of Long, Item)
    Private Property FolderLastWriteTimeCache() As Dictionary(Of Long, DateTime)
    Private Property FileSizeCache() As Dictionary(Of Long, Long)
    Private Property RootItem() As Item

    Public Sub New(ByVal app As DocumentsApp, ByVal rootFolder As String)
        MyBase.New(rootFolder)
        DocumentsApp = app
        FolderLastWriteTimeCache = New Dictionary(Of Long, DateTime)()
        FileSizeCache = New Dictionary(Of Long, Long)()
        RefreshFolderCache()
    End Sub

    Public Overrides ReadOnly Property RootFolderDisplayName() As String
        Get
            Return RootItem.Name
        End Get
    End Property

    Public Overrides Function GetFiles(ByVal folder As FileManagerFolder) As IEnumerable(Of FileManagerFile)
        Dim folderId As Long = GetItemId(folder)
        Return Data.Items.Where(Function(item) item.ParentItem IsNot Nothing AndAlso item.ParentItem.Id = folderId AndAlso (Not item.IsFolder)).ToList().Select(Function(item) New FileManagerFile(Me, folder, item.Name, item.Id.ToString()))
    End Function
    Public Overrides Function GetFolders(ByVal parentFolder As FileManagerFolder) As IEnumerable(Of FileManagerFolder)
        Dim folderItem As Item = FindFolderItem(parentFolder)
        Return FolderCache.Values.Where(Function(item) item.ParentItem Is folderItem AndAlso item.IsFolder).Select(Function(item) New FileManagerFolder(Me, parentFolder, item.Name, item.Id.ToString()))
    End Function
    Public Overrides Function Exists(ByVal file As FileManagerFile) As Boolean
        Return FindFileItem(file) IsNot Nothing
    End Function
    Public Overrides Function Exists(ByVal folder As FileManagerFolder) As Boolean
        Return FindFolderItem(folder) IsNot Nothing
    End Function
    Public Overrides Function ReadFile(ByVal file As FileManagerFile) As Stream
        Dim fileItem As Item = FindFileItem(file)
        Return Data.ReadFileContent(fileItem)
    End Function
    Public Overrides Function GetLastWriteTime(ByVal file As FileManagerFile) As Date
        Dim fileItem As Item = FindFileItem(file)
        Return fileItem.LastWriteTime
    End Function
    Public Overrides Function GetLastWriteTime(ByVal folder As FileManagerFolder) As Date
        Dim result As Date = Nothing
        Dim folderItem As Item = FindFolderItem(folder)
        If Not FolderLastWriteTimeCache.TryGetValue(folderItem.Id, result) Then
            result = DocumentsApp.FileSystem.GetFolderLastWriteTime(folderItem)
            FolderLastWriteTimeCache.Add(folderItem.Id, result)
        End If
        Return result
    End Function

    Public Overrides Function GetThumbnailUrl(ByVal file As FileManagerFile) As String
        Dim fileItem As Item = FindFileItem(file)
        Return DocumentsApp.Image.GetThumbnailUrl(fileItem)
    End Function

    Public Overrides Sub CreateFolder(ByVal parent As FileManagerFolder, ByVal name As String)
        UpdateAndSaveChanges(parent, Sub(parentItem) Data.AddItem(New Item() With {.IsFolder = True, .Owner = DocumentsApp.User.CurrentUser, .CreationTime = Date.UtcNow, .LastAccessTime = Date.UtcNow, .LastWriteTime = Date.UtcNow, .Name = name, .ParentItem = parentItem}))
    End Sub
    Public Overrides Sub DeleteFile(ByVal file As FileManagerFile)
        UpdateAndSubmitChanges(file, Sub(item) Data.DeleteItem(item))
    End Sub
    Public Overrides Sub DeleteFolder(ByVal folder As FileManagerFolder)
        UpdateAndSaveChanges(folder, Sub(item) Data.DeleteItem(item))
    End Sub
    Public Overrides Sub MoveFile(ByVal file As FileManagerFile, ByVal newParentFolder As FileManagerFolder)
        UpdateAndSubmitChanges(file, Sub(item) item.ParentItem = FindFolderItem(newParentFolder))
    End Sub
    Public Overrides Sub MoveFolder(ByVal folder As FileManagerFolder, ByVal newParentFolder As FileManagerFolder)
        UpdateAndSaveChanges(folder, Sub(item) item.ParentItem = FindFolderItem(newParentFolder))
    End Sub
    Public Overrides Sub RenameFile(ByVal file As FileManagerFile, ByVal name As String)
        UpdateAndSubmitChanges(file, Sub(item) item.Name = name)
    End Sub
    Public Overrides Sub RenameFolder(ByVal folder As FileManagerFolder, ByVal name As String)
        UpdateAndSaveChanges(folder, Sub(item) item.Name = name)
    End Sub
    Public Overrides Sub UploadFile(ByVal folder As FileManagerFolder, ByVal fileName As String, ByVal content As Stream)
        UpdateAndSaveChanges(folder, Sub(folderItem) Data.AddItem(New Item() With {.Name = fileName, .Content = Data.CreateBinaryContent(content), .Owner = DocumentsApp.User.CurrentUser, .ParentItem = folderItem, .CreationTime = Date.UtcNow, .LastAccessTime = Date.UtcNow, .LastWriteTime = Date.UtcNow, .IsFolder = False}))
    End Sub
    Public Overrides Sub CopyFile(ByVal file As FileManagerFile, ByVal newParentFolder As FileManagerFolder)
        Dim fileItem As Item = FindFileItem(file)
        CopyCore(fileItem, newParentFolder.RelativeName, False)
    End Sub
    Public Overrides Sub CopyFolder(ByVal folder As FileManagerFolder, ByVal newParentFolder As FileManagerFolder)
        Dim folders As New List(Of FileManagerFolder)()
        FillSubFoldersList(folder, folders)
        Dim folderNameOffset As Integer = If((Not String.IsNullOrEmpty(folder.Parent.RelativeName)), folder.Parent.RelativeName.Length + 1, 0)

        For Each copyingFolder As FileManagerFolder In folders
            Dim folderItem As Item = FindFolderItem(copyingFolder)
            Dim folderPath As String = newParentFolder.RelativeName
            If copyingFolder IsNot folder Then
                folderPath = Path.Combine(folderPath, copyingFolder.Parent.RelativeName.Substring(folderNameOffset))
            End If
            CopyCore(folderItem, folderPath, True)
            For Each currentFile As FileManagerFile In copyingFolder.GetFiles()
                Dim fileItem As Item = FindFileItem(currentFile)
                CopyCore(fileItem, Path.Combine(folderPath, copyingFolder.Name), False)
            Next currentFile
        Next copyingFolder
    End Sub
    Private Sub FillSubFoldersList(ByVal folder As FileManagerFolder, ByVal list As List(Of FileManagerFolder))
        list.Add(folder)
        For Each subFolder As FileManagerFolder In folder.GetFolders()
            FillSubFoldersList(subFolder, list)
        Next subFolder
    End Sub
    Private Sub CopyCore(ByVal item As Item, ByVal path As String, ByVal isFolder As Boolean)
        Dim newParentFolder As New FileManagerFolder(Me, path, DirectCast(Nothing, String))
        UpdateAndSaveChanges(newParentFolder, Sub(newParentItem) Data.AddItem(New Item() With {.Name = item.Name, .Content = If(item.IsFolder, Nothing, Data.CreateBinaryContent(item.Content.Data)), .ParentItem = newParentItem, .Owner = DocumentsApp.User.CurrentUser, .CreationTime = Date.UtcNow, .LastAccessTime = Date.UtcNow, .LastWriteTime = Date.UtcNow, .IsFolder = isFolder}))
    End Sub
    Protected Sub UpdateAndSubmitChanges(ByVal file As FileManagerFile, ByVal update As Action(Of Item))
        UpdateAndSubmitChangesCore(FindFileItem(file), update)
    End Sub
    Protected Sub UpdateAndSaveChanges(ByVal folder As FileManagerFolder, ByVal update As Action(Of Item))
        UpdateAndSubmitChangesCore(FindFolderItem(folder), update)
    End Sub
    Protected Sub UpdateAndSubmitChangesCore(ByVal item As Item, ByVal update As Action(Of Item))
        update(item)
        Data.SaveChanges()
        RefreshFolderCache()
        ClearFolderLastWriteTimeCache()
        If (Not item.IsFolder) AndAlso FileSizeCache.ContainsKey(item.Id) Then
            FileSizeCache.Remove(item.Id)
        End If
    End Sub
    Protected Function FindFileItem(ByVal file As FileManagerFile) As Item
        If file.Id Is Nothing Then
            Return FindFileItemByParentFolder(file.Name, file.Folder)
        End If

        Dim fileId As Long = GetItemId(file)
        Return Data.FindItemById(fileId)
    End Function
    Protected Function FindFolderItem(ByVal folder As FileManagerFolder) As Item
        If folder.Id Is Nothing Then
            Return FindFolderItemByRelativeName(folder)
        End If

        Dim folderId As Long = GetItemId(folder)
        Return FolderCache(folderId)
    End Function
    Protected Function FindFileItemByParentFolder(ByVal itemName As String, ByVal parentFolder As FileManagerFolder) As Item
        Dim parentItem As Item = FindFolderItemByRelativeName(parentFolder)
        Return Data.Items.FirstOrDefault(Function(item) item.ParentItem IsNot Nothing AndAlso item.ParentItem.Id = parentItem.Id AndAlso (Not item.IsFolder) AndAlso item.Name = itemName)
    End Function
    Protected Function GetItemId(ByVal fileManagerItem As FileManagerItem) As Long
        If String.IsNullOrEmpty(fileManagerItem.RelativeName) Then
            Return RootItem.Id
        End If
        Return Long.Parse(fileManagerItem.Id)
    End Function
    Protected Function FindFolderItemByRelativeName(ByVal folder As FileManagerFolder) As Item
        Return FolderCache.Values.Where(Function(item) item.IsFolder AndAlso GetRelativeName(item) = folder.RelativeName).FirstOrDefault()
    End Function
    Protected Function GetRelativeName(ByVal folderItem As Item) As String
        If folderItem.IsRoot Then
            Return String.Empty
        End If
        If folderItem.ParentItem.IsRoot Then
            Return folderItem.Name
        End If
        Dim name As String = GetRelativeName(folderItem.ParentItem)
        Return Path.Combine(name, folderItem.Name)
    End Function

    Protected Sub RefreshFolderCache()
        FolderCache = Data.Items.Where(Function(item) item.IsFolder).ToDictionary(Function(item) item.Id)

        RootItem = FolderCache.Values.First(Function(item) item.IsRoot)
    End Sub
    Protected Sub ClearFolderLastWriteTimeCache()
        FolderLastWriteTimeCache.Clear()
    End Sub

    Public Overrides Function GetLength(ByVal file As FileManagerFile) As Long
        Dim result As Long = Nothing
        Dim fileItem As Item = FindFileItem(file)
        If Not FileSizeCache.TryGetValue(fileItem.Id, result) Then
            result = Data.GetFileSize(fileItem)
            FileSizeCache.Add(fileItem.Id, result)
        End If
        Return result
    End Function
End Class
