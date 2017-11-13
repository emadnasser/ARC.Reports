Imports System
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.Caching
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.Office
Imports DevExpress.Web.Internal

Public Class DemoUtils

    Private Shared isSiteMode_Renamed? As Boolean

    Public Shared ReadOnly Property IsSiteMode() As Boolean
        Get
            If Not isSiteMode_Renamed.HasValue Then
                Dim siteModeValue As String = System.Web.Configuration.WebConfigurationManager.AppSettings("SiteMode")
                isSiteMode_Renamed = siteModeValue.Equals("true", StringComparison.InvariantCultureIgnoreCase)
            End If
            Return isSiteMode_Renamed.Value
        End Get
    End Property

    Public Shared Function GetSiteModeAppInstance() As DocumentsApp
        Return SiteModeUtils.GetAppInstance()
    End Function

    Public Shared Sub IgnoreDemoClasses(ByVal modelBuilder As System.Data.Entity.DbModelBuilder)
        DemoDataService.IgnoreDemoClasses(modelBuilder)
    End Sub
End Class

Public Class DocumentsDemoApp
    Inherits DocumentsApp

    Private privateId As String
    Public Property Id() As String
        Get
            Return privateId
        End Get
        Private Set(ByVal value As String)
            privateId = value
        End Set
    End Property

    Public Sub New(ByVal id As String)
        MyBase.New()
        Me.Id = id
    End Sub

    Public Overrides Sub Initialize()
        MyBase.Initialize()
        Data = New DemoDataService(Me, Data)
        FileSystem = New DemoFileSystemService(Me)
        Document = New DemoDocumentService(Me)
        Image = New DemoImageService(Me)
    End Sub

    Public Sub Dispose()
        TryCast(Data, DemoDataService).Dispose()
        TryCast(Image, DemoImageService).Dispose()
        TryCast(Document, DemoDocumentService).Dispose()
    End Sub
End Class

Public Class DemoItem
    Inherits Item

    Private Property DataService() As DemoDataService

    Public Property ContentId() As Long?
    Public Property OwnerId() As Long?
    Public Property ParentItemId() As Long?

    Public Sub New(ByVal dataService As DemoDataService)
        Me.DataService = dataService
    End Sub
End Class

Public Class DemoUser
    Inherits User

    Private Property DataService() As DemoDataService

    Public Property AvatarId() As Long?

    Public Sub New(ByVal dataService As DemoDataService)
        Me.DataService = dataService
    End Sub
End Class

Public Class DemoBinaryContent
    Inherits BinaryContent

    Private Property DataService() As DemoDataService
    Public Property IsLoaded() As Boolean

    Public Sub New(ByVal dataService As DemoDataService)
        Me.DataService = dataService
        IsLoaded = False
    End Sub

    Public Overrides Property Data() As Byte()
        Get
            Return DataService.ReadContentBytes(Me)
        End Get
        Set(ByVal value As Byte())
            DataService.WriteContentBytes(Me, value)
        End Set
    End Property
End Class

Public Class DemoDataService
    Inherits DataService

    Private Const DemoDataRootVirtPath As String = "~\App_Data\DemoData"

    Private Shared Property IsInitialized() As Boolean

    Shared Sub New()
        IsInitialized = False
    End Sub

    Public Shared Sub IgnoreDemoClasses(ByVal modelBuilder As System.Data.Entity.DbModelBuilder)
        modelBuilder.Ignore(Of DemoItem)()
        modelBuilder.Ignore(Of DemoUser)()
        modelBuilder.Ignore(Of DemoBinaryContent)()
    End Sub

    Private dataLoadingLocker As New Object()
    Private itemCacheLocker As New Object()
    Private userCacheLocker As New Object()
    Private binaryContentCacheLocker As New Object()
    Private demoDataLocker As New Object()

    Private ReadOnly Property DemoApp() As DocumentsDemoApp
        Get
            Return TryCast(DocumentsApp, DocumentsDemoApp)
        End Get
    End Property
    Private Property SourceDataService() As DataService

    Private Property IsDataLoaded() As Boolean
    Private Property MaxItemId() As Long
    Private Property MaxBinaryContentId() As Long
    Private Property UserCache() As Dictionary(Of Long, DemoUser)
    Private Property ItemCache() As Dictionary(Of Long, DemoItem)
    Private Property BinaryContentCache() As Dictionary(Of Long, DemoBinaryContent)

    Public Overrides ReadOnly Property Items() As IQueryable(Of Item)
        Get
            EnsureDataLoaded()
            SyncLock Me.itemCacheLocker
                Return ItemCache.Values.ToList().AsQueryable()
            End SyncLock
        End Get
    End Property
    Public Overrides ReadOnly Property Users() As IQueryable(Of User)
        Get
            EnsureDataLoaded()
            SyncLock Me.userCacheLocker
                Return UserCache.Values.ToList().AsQueryable()
            End SyncLock
        End Get
    End Property
    Public Overrides ReadOnly Property BinaryContentSet() As IQueryable(Of BinaryContent)
        Get
            Return New BinaryContent(){}.AsQueryable()
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsDemoApp, ByVal srcDataService As DataService)
        MyBase.New(app)
        SourceDataService = srcDataService
    End Sub

    Public Overrides Sub SaveChanges()
    End Sub
    Public Overrides Sub CloseUnitOfWork()
        SourceDataService.CloseUnitOfWork()
    End Sub
    Public Overrides Function FindUserByAccountName(ByVal accountName As String) As User
        Return Users.FirstOrDefault(Function(user) user.AccountName = accountName)
    End Function
    Public Overrides Function FindUserById(ByVal id As Long) As User
        Return Users.FirstOrDefault(Function(user) user.Id = id)
    End Function
    Public Overrides Function CreateUser() As User
        Return Nothing
    End Function
    Public Overrides Sub DeleteUser(ByVal id As Long)
    End Sub

    Public Overrides Function FindItemById(ByVal id As Long) As Item
        SyncLock Me.itemCacheLocker
            Dim item As DemoItem = Nothing
            If ItemCache.TryGetValue(id, item) Then
                Return item
            End If
            Return Nothing
        End SyncLock
    End Function
    Public Overrides Sub DeleteItem(ByVal item As Item)
        SyncLock Me.itemCacheLocker
            DeleteItemCore(TryCast(item, DemoItem))
        End SyncLock
    End Sub
    Public Overrides Sub AddItem(ByVal item As Item)
        Dim demoItem As New DemoItem(Me) With {.Name = item.Name, .IsFolder = item.IsFolder, .Owner = item.Owner, .OwnerId = If(item.Owner Is Nothing, DirectCast(Nothing, Long?), item.Owner.Id), .ParentItem = item.ParentItem, .ParentItemId = If(item.ParentItem Is Nothing, DirectCast(Nothing, Long?), item.ParentItem.Id), .Content = item.Content, .ContentId = If(item.Content Is Nothing, DirectCast(Nothing, Long?), item.Content.Id), .CreationTime = item.CreationTime, .LastAccessTime = item.LastAccessTime, .LastWriteTime = item.LastWriteTime}
        SyncLock Me.itemCacheLocker
            MaxItemId += 1
            demoItem.Id = MaxItemId
            ItemCache.Add(demoItem.Id, demoItem)
        End SyncLock
        item.Id = demoItem.Id
    End Sub

    Public Overrides Function CreateBinaryContent(ByVal data() As Byte) As BinaryContent
        Dim content As New DemoBinaryContent(Me)
        SyncLock Me.binaryContentCacheLocker
            MaxBinaryContentId += 1
            content.Id = MaxBinaryContentId
            BinaryContentCache.Add(content.Id, content)
        End SyncLock
        content.Data = data
        Return content
    End Function
    Public Overrides Function CreateBinaryContent(ByVal dataStream As Stream) As BinaryContent
        Dim data() As Byte = CommonUtils.ReadAllBytes(dataStream)
        Return CreateBinaryContent(data)
    End Function

    Public Function ReadContentBytes(ByVal content As DemoBinaryContent) As Byte()
        If content.IsLoaded Then
            Dim filePath As String = PrepareContentFilePath(content)
            SyncLock Me.demoDataLocker
                Return File.ReadAllBytes(filePath)
            End SyncLock
        End If
        Dim data() As Byte = SourceDataService.BinaryContentSet.Where(Function(dbContent) dbContent.Id = content.Id).Select(Function(dbContent) dbContent.Data).First()
        WriteContentBytes(content, data)
        Return data
    End Function
    Public Sub WriteContentBytes(ByVal content As DemoBinaryContent, ByVal data() As Byte)
        Dim filePath As String = PrepareContentFilePath(content)
        SyncLock Me.demoDataLocker
            File.WriteAllBytes(filePath, data)
        End SyncLock
        content.IsLoaded = True
    End Sub

    Public Overrides Function ReadFileContent(ByVal fileItem As Item) As Stream
        Return New MemoryStream(fileItem.Content.Data)
    End Function
    Public Overrides Function GetFileSize(ByVal fileItem As Item) As Integer
        Dim item As DemoItem = TryCast(fileItem, DemoItem)
        If item.Content IsNot Nothing Then
            Dim content As DemoBinaryContent = TryCast(item.Content, DemoBinaryContent)
            If content.IsLoaded Then
                Dim filePath As String = PrepareContentFilePath(content)
                SyncLock Me.demoDataLocker
                    Dim file As New FileInfo(filePath)
                    Return CInt(file.Length)
                End SyncLock
            End If
            Return SourceDataService.GetFileSize(fileItem)
        End If
        Return 0
    End Function

    Public Overrides Sub Initialize()
        If Not IsInitialized Then
            SourceDataService.Initialize()
            IsInitialized = True
        End If
    End Sub

    Public Sub Dispose()
        SiteModeUtils.SafeDeleteDirectory(GetDemoDataPath())
    End Sub

    Private Sub EnsureDataLoaded()
        SyncLock Me.dataLoadingLocker
            If Not IsDataLoaded Then
                LoadData()
                IsDataLoaded = True
            End If
        End SyncLock
    End Sub
    Private Sub LoadData()
        MaxItemId = 0
        MaxBinaryContentId = 0
        BinaryContentCache = New Dictionary(Of Long, DemoBinaryContent)()
        LoadUsers()
        LoadItems()
    End Sub
    Private Sub LoadUsers()
        UserCache = SourceDataService.Users.Join(SourceDataService.BinaryContentSet, Function(dbUser) dbUser.Avatar.Id, Function(dbContent) dbContent.Id, Function(dbUser, dbContent) New With {Key .Id = dbUser.Id, Key .AccountName = dbUser.AccountName, Key .Name = dbUser.Name, Key .Password = dbUser.Password, Key .AvatarId = dbContent.Id, Key .AvatarData = dbContent.Data}).ToList().Select(Function(userDto) New DemoUser(Me) With {.Id = userDto.Id, .AccountName = userDto.AccountName, .Name = userDto.Name, .Password = userDto.Password, .AvatarId = userDto.AvatarId, .Avatar = CreateInitialBinaryContent(userDto.AvatarId, userDto.AvatarData)}).ToDictionary(Function(user) user.Id)
    End Sub
    Private Sub LoadItems()
        ItemCache = SourceDataService.Items.Select(Function(dbItem) New With {Key .Id = dbItem.Id, Key .Name = dbItem.Name, Key .IsFolder = dbItem.IsFolder, Key .ContentId = CType(dbItem.Content.Id, Long?), Key .OwnerId = CType(dbItem.Owner.Id, Long?), Key .ParentItemId = CType(dbItem.ParentItem.Id, Long?), Key .CreationTime = dbItem.CreationTime, Key .LastAccessTime = dbItem.LastAccessTime, Key .LastWriteTime = dbItem.LastWriteTime}).ToList().Select(Function(itemDto) New DemoItem(Me) With {.Id = itemDto.Id, .Name = itemDto.Name, .IsFolder = itemDto.IsFolder, .ContentId = itemDto.ContentId, .OwnerId = itemDto.OwnerId, .ParentItemId = itemDto.ParentItemId, .CreationTime = itemDto.CreationTime, .LastAccessTime = itemDto.LastAccessTime, .LastWriteTime = itemDto.LastWriteTime}).ToDictionary(Function(item) item.Id)


        Dim items_Renamed As List(Of DemoItem) = ItemCache.Values.ToList()
        For Each item As DemoItem In items_Renamed
            If MaxItemId < item.Id Then
                MaxItemId = item.Id
            End If
            If item.OwnerId.HasValue Then
                item.Owner = UserCache(item.OwnerId.Value)
            End If
            If item.ParentItemId.HasValue Then
                item.ParentItem = ItemCache(item.ParentItemId.Value)
            End If
            If item.ContentId.HasValue Then
                item.Content = CreateInitialBinaryContent(item.ContentId.Value)
            End If
        Next item
    End Sub
    Private Function CreateInitialBinaryContent(ByVal id As Long) As DemoBinaryContent
        Return CreateInitialBinaryContent(id, Nothing)
    End Function
    Private Function CreateInitialBinaryContent(ByVal id As Long, ByVal data() As Byte) As DemoBinaryContent
        Dim content As New DemoBinaryContent(Me)
        content.Id = id
        If data IsNot Nothing Then
            content.Data = data
        End If
        BinaryContentCache.Add(id, content)
        If MaxBinaryContentId < id Then
            MaxBinaryContentId = id
        End If
        Return content
    End Function
    Private Sub DeleteItemCore(ByVal item As DemoItem)
        ItemCache.Remove(item.Id)
        If item.IsFolder Then
            Dim childItems As List(Of DemoItem) = ItemCache.Values.Where(Function(cacheItem) (Not cacheItem.IsRoot) AndAlso cacheItem.ParentItem.Id = item.Id).ToList()

            For Each childItem As DemoItem In childItems
                DeleteItemCore(childItem)
            Next childItem
        End If
    End Sub
    Private Function GetDemoDataPath() As String
        Dim demoDataVirtPath As String = Path.Combine(DemoDataRootVirtPath, DemoApp.Id)
        Return CommonUtils.MapPath(demoDataVirtPath)
    End Function
    Private Function GetBinaryContentFileName(ByVal content As DemoBinaryContent) As String
        Return content.Id.ToString() & ".tmp"
    End Function
    Private Function PrepareContentFilePath(ByVal content As DemoBinaryContent) As String
        Dim demoDataPath As String = GetDemoDataPath()
        If Not Directory.Exists(demoDataPath) Then
            Directory.CreateDirectory(demoDataPath)
        End If

        Dim fileName As String = GetBinaryContentFileName(content)
        Return Path.Combine(demoDataPath, fileName)
    End Function
End Class

Public Class DemoFileSystemService
    Inherits FileSystemService

    Private Const MaxFileSizeForUpload As Long = 1048576

    Public Sub New(ByVal app As DocumentsDemoApp)
        MyBase.New(app)
    End Sub

    Public Overrides Function CreateNewFileItem(ByVal folderPath As String, ByVal fileName As String) As Item
        Dim item As Item = MyBase.CreateNewFileItem(folderPath, fileName)
        Return DocumentsApp.Data.FindItemById(item.Id)
    End Function
    Public Overrides Function GetMaxFileSizeForUpload() As Long
        Return MaxFileSizeForUpload
    End Function
End Class

Public Class DemoDocumentService
    Inherits DocumentService

    Private Shared Property DocumentAutoSaveEnabled() As Boolean

    Public Sub New(ByVal app As DocumentsDemoApp)
        MyBase.New(app)
    End Sub

    Public Overrides Function GetDocumentIdForEditor(ByVal document As Item) As String
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        Return MyBase.GetDocumentIdForEditor(document) & "#" & appId
    End Function
    Protected Overrides Function ParseDocumentIdFromEditor(ByVal editorDocId As String) As Long
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        If Not DocumentIdBelongsToCurrentApp(editorDocId) Then
            Return -1
        End If
        Dim delimeterIndex As Integer = editorDocId.IndexOf("#"c)
        Dim baseDocId As String = editorDocId.Substring(0, delimeterIndex)
        Return MyBase.ParseDocumentIdFromEditor(baseDocId)
    End Function
    Public Overrides Sub EnableDocumentAutoSave()
        If Not DocumentAutoSaveEnabled Then
            AddHandler DocumentManager.AutoSaving, AddressOf DocumentManager_DemoAutoSaving
            DocumentAutoSaveEnabled = True
        End If

    End Sub
    Private Shared Sub DocumentManager_DemoAutoSaving(ByVal documentInfo As IDocumentInfo, ByVal e As DocumentSavingEventArgs)
        e.Handled = True
    End Sub

    Public Sub Dispose()
        CloseAllDocuments()
    End Sub
    Private Function DocumentIdBelongsToCurrentApp(ByVal editorDocId As String) As Boolean
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        Return editorDocId.IndexOf(appId) <> -1
    End Function
    Private Sub CloseAllDocuments()
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        Dim documents As List(Of IDocumentInfo) = DocumentManager.GetAllDocuments().ToList()
        For Each document As IDocumentInfo In documents
            Try
                If DocumentIdBelongsToCurrentApp(document.DocumentId) Then
                    document.Close()
                End If
            Catch
            End Try
        Next document
    End Sub
End Class

Public Class DemoImageService
    Inherits ImageService

    Public Sub New(ByVal app As DocumentsDemoApp)
        MyBase.New(app)
        AvatarService = New DemoAvatarService(app)
        ThumbnailService = New DemoThumbnailService(app)
    End Sub

    Public Sub Dispose()
        DisableThumbnailUpdating()
        TryCast(AvatarService, DemoAvatarService).Dispose()
        TryCast(ThumbnailService, DemoThumbnailService).Dispose()
    End Sub
End Class

Public Class DemoAvatarService
    Inherits AvatarService

    Public Sub New(ByVal app As DocumentsDemoApp)
        MyBase.New(app)
    End Sub

    Protected Overrides Function GetAvatarFolderVirtPath() As String
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        Return Path.Combine(MyBase.GetAvatarFolderVirtPath(), appId)
    End Function

    Public Sub Dispose()
        Dim avatarFolderPath As String = CommonUtils.MapPath(GetAvatarFolderVirtPath())
        SiteModeUtils.SafeDeleteDirectory(avatarFolderPath)
    End Sub
End Class

Public Class DemoThumbnailService
    Inherits ThumbnailService

    Public Sub New(ByVal app As DocumentsDemoApp)
        MyBase.New(app)
    End Sub

    Protected Overrides Function GetThumbnailFolderVirtPath() As String
        Dim appId As String = (TryCast(DocumentsApp, DocumentsDemoApp)).Id
        Return Path.Combine(MyBase.GetThumbnailFolderVirtPath(), appId)
    End Function

    Public Sub Dispose()
        Dim thumbnailFolderPath As String = CommonUtils.MapPath(GetThumbnailFolderVirtPath())
        SiteModeUtils.SafeDeleteDirectory(thumbnailFolderPath)
    End Sub
End Class

Public Class DemoAppRegistryEntry
    Public Property DemoApp() As DocumentsDemoApp
    Public Property LastAccessTime() As Date

    Public Sub New(ByVal app As DocumentsDemoApp)
        DemoApp = app
    End Sub
    Public Sub UpdateLastUsageTime()
        LastAccessTime = Date.UtcNow
    End Sub
End Class

Public Class DemoAppRegistry
    Private Shared ReadOnly FirstAppDisposingInterval As TimeSpan = TimeSpan.FromMinutes(21)
    Private Shared ReadOnly GeneralAppDisposingInterval As TimeSpan = TimeSpan.FromSeconds(30)
    Private Shared ReadOnly AppDisposeTimeout As TimeSpan = TimeSpan.FromMinutes(21)

    Private Property AppDictionary() As ConcurrentDictionary(Of String, DemoAppRegistryEntry)
    Private Property AppDisposingActivated() As Boolean

    Public Sub New()
        AppDictionary = New ConcurrentDictionary(Of String, DemoAppRegistryEntry)()
        AppDisposingActivated = False
    End Sub

    Public Function GetDemoApp(ByVal appId As String) As DocumentsDemoApp
        Dim entry As DemoAppRegistryEntry = Nothing
        If Not AppDictionary.TryGetValue(appId, entry) Then
            Return Nothing
        End If
        entry.UpdateLastUsageTime()
        Return entry.DemoApp
    End Function

    Public Sub RegisterDemoApp(ByVal app As DocumentsDemoApp)
        Dim entry As New DemoAppRegistryEntry(app)
        entry.UpdateLastUsageTime()
        AppDictionary.AddOrUpdate(app.Id, entry, Function(appId, oldEntry) entry)
        EnsureAppDisposingActivated()
    End Sub

    Private Sub EnsureAppDisposingActivated()
        If Not AppDisposingActivated Then
            DisposeOldAppsWithDelay(FirstAppDisposingInterval)
            AppDisposingActivated = True
        End If
    End Sub
    Private Sub DisposeOldAppsWithDelay(ByVal delay As TimeSpan)
        CommonUtils.ExecuteActionWithDelay(Sub() OnDelayedOldAppsDisposing(), delay)
    End Sub
    Private Sub OnDelayedOldAppsDisposing()
        Try
            DisposeOldApps()
        Finally
            DisposeOldAppsWithDelay(GeneralAppDisposingInterval)
        End Try
    End Sub
    Private Sub DisposeOldApps()
        Dim appEntries As List(Of DemoAppRegistryEntry) = AppDictionary.Values.ToList()
        Dim timeLowerBoundary As Date = Date.UtcNow.Subtract(AppDisposeTimeout)
        For Each appEntry As DemoAppRegistryEntry In appEntries
            If appEntry.LastAccessTime <= timeLowerBoundary Then
                Dim removedEntry As DemoAppRegistryEntry = Nothing
                AppDictionary.TryRemove(appEntry.DemoApp.Id, removedEntry)
                appEntry.DemoApp.Dispose()
            End If
        Next appEntry
    End Sub
End Class

Public Class SiteModeUtils
    Private Const AppInstanceContextKey As String = "AppInstanceContextKey_05D8E19B-428C-45BC-B1A0-14C974A994D6"
    Private Const AppInstanceSessionKey As String = "AppInstanceSessionKey_10747C68-A09D-4909-B4FE-C06BF4F8DCDB"
    Private Shared ReadOnly AppInstanceSlidingExpiration As TimeSpan = TimeSpan.FromMinutes(20)
    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private Shared Property DemoAppRegistry() As DemoAppRegistry
    Private Shared ReadOnly instanceGetterLocker As New Object()

    Shared Sub New()
        DemoAppRegistry = New DemoAppRegistry()
    End Sub

    Public Shared Function GetAppInstance() As DocumentsApp
        If Context.Items.Contains(AppInstanceContextKey) Then
            Return TryCast(Context.Items(AppInstanceContextKey), DocumentsDemoApp)
        End If

        Dim app As DocumentsDemoApp = Nothing
        SyncLock instanceGetterLocker
            Dim appId As String = TryCast(Context.Session(AppInstanceSessionKey), String)
            If appId IsNot Nothing Then
                app = DemoAppRegistry.GetDemoApp(appId)
            Else
                appId = Guid.NewGuid().ToString()
                app = New DocumentsDemoApp(appId)
                app.Initialize()
                app.Start()
                DemoAppRegistry.RegisterDemoApp(app)
                Context.Session(AppInstanceSessionKey) = appId
            End If
        End SyncLock

        Context.Items(AppInstanceContextKey) = app
        Return app
    End Function

    Public Shared Sub SafeDeleteDirectory(ByVal dirPath As String)
        Try
            If Directory.Exists(dirPath) Then
                Directory.Delete(dirPath, True)
            End If
        Catch
        End Try
    End Sub
End Class
