Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Data.Common
Imports System.Data.Entity
Imports System.Data.Entity.SqlServer
Imports System.Runtime.Remoting.Messaging
Imports DevExpress.Internal

Public MustInherit Class DataService
    Inherits ServiceBase

    Public Overridable ReadOnly Property Items() As IQueryable(Of Item)
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Public Overridable ReadOnly Property Users() As IQueryable(Of User)
        Get
            Throw New NotImplementedException()
        End Get
    End Property
    Public Overridable ReadOnly Property BinaryContentSet() As IQueryable(Of BinaryContent)
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
    End Sub

    Public Overridable Sub SaveChanges()
        Throw New NotImplementedException()
    End Sub
    Public Overridable Sub CloseUnitOfWork()
        Throw New NotImplementedException()
    End Sub
    Public Overridable Function FindUserByAccountName(ByVal accountName As String) As User
        Throw New NotImplementedException()
    End Function
    Public Overridable Function FindUserById(ByVal id As Long) As User
        Throw New NotImplementedException()
    End Function
    Public Overridable Function CreateUser() As User
        Throw New NotImplementedException()
    End Function
    Public Overridable Sub DeleteUser(ByVal id As Long)
        Throw New NotImplementedException()
    End Sub

    Public Overridable Function FindItemById(ByVal id As Long) As Item
        Throw New NotImplementedException()
    End Function
    Public Overridable Sub DeleteItem(ByVal item As Item)
        Throw New NotImplementedException()
    End Sub
    Public Overridable Sub AddItem(ByVal item As Item)
        Throw New NotImplementedException()
    End Sub

    Public Overridable Function CreateBinaryContent(ByVal data() As Byte) As BinaryContent
        Throw New NotImplementedException()
    End Function
    Public Overridable Function CreateBinaryContent(ByVal dataStream As Stream) As BinaryContent
        Throw New NotImplementedException()
    End Function

    Public Overridable Function ReadFileContent(ByVal fileItem As Item) As Stream
        Throw New NotImplementedException()
    End Function
    Public Overridable Function GetFileSize(ByVal fileItem As Item) As Integer
        Throw New NotImplementedException()
    End Function

    Public Overridable Sub Initialize()
        Throw New NotImplementedException()
    End Sub
End Class

Public Class EntityDataService
    Inherits DataService

    Private Const DataContextKey As String = "11F33BBC-0EBC-47DE-857E-9EF6DB452DAC"
    Private Const ConnectionStringName As String = "DocumentsConnectionString"
    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private ReadOnly Property ConnectionString() As String
        Get

            Dim connectionString_Renamed As String = System.Web.Configuration.WebConfigurationManager.ConnectionStrings(ConnectionStringName).ConnectionString
            Return DbEngineDetector.PatchConnectionString(connectionString_Renamed)
        End Get
    End Property
    Private ReadOnly Property DataContext() As DocumentsDb
        Get
            Return If(IsInRequestScope(), GetDataContextInRequestScope(), GetDataContextInCallContextScope())
        End Get
    End Property

    Private Function IsInRequestScope() As Boolean
        Return Context IsNot Nothing
    End Function

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
    End Sub

    Private Function GetDataContextInRequestScope() As DocumentsDb
        If Not Context.Items.Contains(DataContextKey) Then
            Context.Items(DataContextKey) = CreateDataContext()
        End If
        Return DirectCast(Context.Items(DataContextKey), DocumentsDb)
    End Function
    Private Sub DisposeDataContextInRequestScope()
        If Context.Items.Contains(DataContextKey) Then

            Dim dataContext_Renamed As DocumentsDb = DirectCast(Context.Items(DataContextKey), DocumentsDb)
            dataContext_Renamed.Dispose()
            Context.Items.Remove(DataContextKey)
        End If
    End Sub
    Private Function GetDataContextInCallContextScope() As DocumentsDb

        Dim dataContext_Renamed As DocumentsDb = TryCast(CallContext.GetData(DataContextKey), DocumentsDb)
        If dataContext_Renamed Is Nothing Then
            dataContext_Renamed = CreateDataContext()
            CallContext.SetData(DataContextKey, dataContext_Renamed)
        End If
        Return dataContext_Renamed
    End Function
    Private Sub DisposeDataContextInCallContextScope()

        Dim dataContext_Renamed As DocumentsDb = TryCast(CallContext.GetData(DataContextKey), DocumentsDb)
        If dataContext_Renamed IsNot Nothing Then
            dataContext_Renamed.Dispose()
            CallContext.SetData(DataContextKey, Nothing)
        End If
    End Sub
    Private Function CreateDataContext() As DocumentsDb
        Return New DocumentsDb(ConnectionString)
    End Function

    Public Overrides ReadOnly Property Items() As IQueryable(Of Item)
        Get
            Return DataContext.Items
        End Get
    End Property
    Public Overrides ReadOnly Property Users() As IQueryable(Of User)
        Get
            Return DataContext.Users
        End Get
    End Property
    Public Overrides ReadOnly Property BinaryContentSet() As IQueryable(Of BinaryContent)
        Get
            Return DataContext.BinaryContentSet
        End Get
    End Property

    Public Overrides Sub SaveChanges()
        DataContext.SaveChanges()
    End Sub
    Public Overrides Sub CloseUnitOfWork()
        If IsInRequestScope() Then
            DisposeDataContextInRequestScope()
        Else
            DisposeDataContextInCallContextScope()
        End If
    End Sub

    Public Overrides Function FindUserByAccountName(ByVal accountName As String) As User
        Return Users.FirstOrDefault(Function(user) user.AccountName = accountName)
    End Function
    Public Overrides Function FindUserById(ByVal id As Long) As User
        Return DataContext.Users.Find(id)
    End Function
    Public Overrides Function CreateUser() As User
        Dim user As User = DataContext.Users.Create()
        Return DataContext.Users.Add(user)
    End Function
    Public Overrides Sub DeleteUser(ByVal id As Long)
        Dim user As User = FindUserById(id)
        If user Is Nothing Then
            Return
        End If
        DataContext.Users.Remove(user)
        DataContext.SaveChanges()
    End Sub

    Public Overrides Function FindItemById(ByVal id As Long) As Item
        Return DataContext.Items.Find(id)
    End Function
    Public Overrides Sub DeleteItem(ByVal item As Item)
        If item.IsFolder Then
            For Each childItem As Item In item.ChildItems.ToList()
                DeleteItem(childItem)
            Next childItem
        Else
            DataContext.BinaryContentSet.Remove(item.Content)
        End If
        DataContext.Items.Remove(item)
    End Sub
    Public Overrides Sub AddItem(ByVal item As Item)
        If item.Owner IsNot Nothing Then
            item.Owner = FindUserById(item.Owner.Id)
        End If
        DataContext.Items.Add(item)
    End Sub

    Public Overrides Function CreateBinaryContent(ByVal data() As Byte) As BinaryContent
        Dim content As BinaryContent = DataContext.BinaryContentSet.Create()
        content.Data = data
        Return DataContext.BinaryContentSet.Add(content)
    End Function
    Public Overrides Function CreateBinaryContent(ByVal dataStream As Stream) As BinaryContent
        Dim data() As Byte = CommonUtils.ReadAllBytes(dataStream)
        Return CreateBinaryContent(data)
    End Function

    Public Overrides Function ReadFileContent(ByVal fileItem As Item) As Stream
        Return New MemoryStream(fileItem.Content.Data.ToArray())
    End Function
    Public Overrides Function GetFileSize(ByVal fileItem As Item) As Integer
        Dim size As Integer? = Items.Where(Function(item) item.Id = fileItem.Id).Join(BinaryContentSet, Function(item) item.Content.Id, Function(content) content.Id, Function(item, content) content).Select(Function(content) SqlFunctions.DataLength(content.Data)).FirstOrDefault()

        Return size.GetValueOrDefault()
    End Function

    Public Overrides Sub Initialize()
        'Database.SetInitializer(new DemoDataInitializer());
        Database.SetInitializer(Of DocumentsDb)(Nothing)
    End Sub
End Class

Public Class DocumentsDb
    Inherits DbContext

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString)
    End Sub

    Public Property Items() As DbSet(Of Item)
    Public Property Users() As DbSet(Of User)
    Public Property BinaryContentSet() As DbSet(Of BinaryContent)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        Dim itemConfig = modelBuilder.Entity(Of Item)()
        itemConfig.HasKey(Function(i) i.Id)
        itemConfig.Property(Function(i) i.Name).IsRequired()
        itemConfig.Property(Function(i) i.IsFolder).IsRequired()
        itemConfig.HasOptional(Function(i) i.Content)
        itemConfig.HasOptional(Function(i) i.Owner)
        itemConfig.HasOptional(Function(i) i.ParentItem).WithMany(Function(pi) pi.ChildItems)

        Dim userConfig = modelBuilder.Entity(Of User)()
        userConfig.HasKey(Function(u) u.Id)
        userConfig.Property(Function(u) u.Name).IsRequired()
        userConfig.Property(Function(u) u.AccountName).IsRequired()
        userConfig.HasOptional(Function(u) u.Avatar)

        Dim binaryContentConfig = modelBuilder.Entity(Of BinaryContent)()
        binaryContentConfig.HasKey(Function(bc) bc.Id)

        DemoUtils.IgnoreDemoClasses(modelBuilder)

        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class

Public Class DemoDataInitializer
    Inherits CreateDatabaseIfNotExists(Of DocumentsDb)

    Private Const FilesVirtPath As String = "~\App_Data\SampleData\Files"
    Private Const UsersVirtPath As String = "~\App_Data\SampleData\Users"

    Private Shared ReadOnly Property FilesPath() As String
        Get
            Return CommonUtils.MapPath(FilesVirtPath)
        End Get
    End Property
    Private Shared ReadOnly Property UsersPath() As String
        Get
            Return CommonUtils.MapPath(UsersVirtPath)
        End Get
    End Property

    Protected Overrides Sub Seed(ByVal context As DocumentsDb)
        MyBase.Seed(context)

        Dim users() As User = CreateUsers(context)
        LoadDirectoryToDb(FilesPath, context, Nothing, users, 0)

        context.SaveChanges()
    End Sub
    Private Function CreateUsers(ByVal context As DocumentsDb) As User()
        Dim benAvatarPath As String = Path.Combine(UsersPath, "Ben Stevenson.jpg")
        Dim maryAvatarPath As String = Path.Combine(UsersPath, "Maria Hernandez.jpg")
        Dim gabeAvatarPath As String = Path.Combine(UsersPath, "Gabriel Santiago.jpg")

        Dim users() As User = {
            New User With {.AccountName = "Ben", .Name = "Ben Stevenson", .Avatar = CreateBinaryContent(context, benAvatarPath)},
            New User With {.AccountName = "Mary", .Name = "Maria Hernandez", .Avatar = CreateBinaryContent(context, maryAvatarPath)},
            New User With {.AccountName = "Gabe", .Name = "Gabriel Santiago", .Avatar = CreateBinaryContent(context, gabeAvatarPath)}
        }
        For Each user As User In users
            context.Users.Add(user)
        Next user

        Return users
    End Function
    Private Function CreateBinaryContent(ByVal context As DocumentsDb, ByVal filePath As String) As BinaryContent
        Dim content As New BinaryContent()
        content.Data = File.ReadAllBytes(filePath)
        context.BinaryContentSet.Add(content)
        Return content
    End Function
    Private Sub LoadDirectoryToDb(ByVal dirPath As String, ByVal context As DocumentsDb, ByVal parentItem As Item, ByVal users() As User, ByVal itemIndex As Integer)
        Dim dirInfo As New DirectoryInfo(dirPath)
        Dim dirItem As Item = CreateItemFromFileSystemInfo(dirInfo, True, parentItem)
        If itemIndex <> 0 Then
            dirItem.Owner = users(itemIndex Mod users.Length)
        End If
        context.Items.Add(dirItem)
        itemIndex += 1
        For Each fileInfo As FileInfo In dirInfo.EnumerateFiles()
            Dim fileItem As Item = CreateItemFromFileSystemInfo(fileInfo, False, dirItem)
            fileItem.Owner = users(itemIndex Mod users.Length)
            fileItem.Content = CreateBinaryContent(context, fileInfo.FullName)
            context.Items.Add(fileItem)
            itemIndex += 1
        Next fileInfo
        For Each subDirInfo As DirectoryInfo In dirInfo.EnumerateDirectories()
            LoadDirectoryToDb(subDirInfo.FullName, context, dirItem, users, itemIndex)
        Next subDirInfo

    End Sub
    Private Function CreateItemFromFileSystemInfo(ByVal fsi As FileSystemInfo, ByVal isFolder As Boolean, ByVal parentItem As Item) As Item
        Return New Item() With {.ParentItem = parentItem, .Name = fsi.Name, .IsFolder = isFolder, .CreationTime = fsi.CreationTimeUtc, .LastAccessTime = fsi.LastAccessTimeUtc, .LastWriteTime = fsi.LastWriteTimeUtc}
    End Function
End Class
