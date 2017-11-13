Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Public Class DocumentsApp
    Private Shared appInstance As DocumentsApp

    Public Shared ReadOnly Property Instance() As DocumentsApp
        Get
            Return GetInstance()
        End Get
    End Property

    Shared Function GetInstance() As DocumentsApp
        If DemoUtils.IsSiteMode Then
            Return DemoUtils.GetSiteModeAppInstance()
        Else
            If appInstance Is Nothing Then
                appInstance = New DocumentsApp()
                appInstance.Initialize()
            End If
            Return appInstance
        End If
    End Function

    Private privateData As DataService
    Public Property Data() As DataService
        Get
            Return privateData
        End Get
        Protected Set(ByVal value As DataService)
            privateData = value
        End Set
    End Property
    Private privateFileSystem As FileSystemService
    Public Property FileSystem() As FileSystemService
        Get
            Return privateFileSystem
        End Get
        Protected Set(ByVal value As FileSystemService)
            privateFileSystem = value
        End Set
    End Property
    Private privateDocument As DocumentService
    Public Property Document() As DocumentService
        Get
            Return privateDocument
        End Get
        Protected Set(ByVal value As DocumentService)
            privateDocument = value
        End Set
    End Property
    Private privateUser As UserService
    Public Property User() As UserService
        Get
            Return privateUser
        End Get
        Protected Set(ByVal value As UserService)
            privateUser = value
        End Set
    End Property
    Private privateImage As ImageService
    Public Property Image() As ImageService
        Get
            Return privateImage
        End Get
        Protected Set(ByVal value As ImageService)
            privateImage = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Overridable Sub Start()
        Data.Initialize()
        Image.EnableThumbnailUpdating()
        User.CheckActivityWithDelay()
        Document.EnableDocumentAutoSave()
    End Sub
    Public Overridable Sub [End]()
        Document.SaveAllDocuments()
        Data.CloseUnitOfWork()
    End Sub
    Public Function GetCurrentUserAvatarVirtPath() As String
        Return Image.GetAvatarVirtPath(User.CurrentUser)
    End Function
    Public Function TryLockDocument(ByVal item As Item) As Boolean
        Return Document.TryLockDocument(item, User.CurrentUser)
    End Function

    Public Overridable Sub Initialize()
        Data = New EntityDataService(Me)
        FileSystem = New FileSystemService(Me)
        Document = New DocumentService(Me)
        User = New UserService(Me)
        Image = New ImageService(Me)
    End Sub
End Class

Public Class ServiceBase
    Private privateDocumentsApp As DocumentsApp
    Public Property DocumentsApp() As DocumentsApp
        Get
            Return privateDocumentsApp
        End Get
        Private Set(ByVal value As DocumentsApp)
            privateDocumentsApp = value
        End Set
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        DocumentsApp = app
    End Sub
End Class
