Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Drawing
Imports System.Drawing.Drawing2D

Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports DevExpress.XtraSpreadsheet.Services.Implementation

Imports DevExpress.Web

Public Class ImageService
    Inherits ServiceBase

    Private Shared ReadOnly FirstThumbnailUpdatingInterval As TimeSpan = TimeSpan.FromSeconds(10)
    Private Shared ReadOnly GeneralThumbnailUpdatingInterval As TimeSpan = TimeSpan.FromMinutes(1)

    Private Property ThumbnailUpdatingEnabled() As Boolean
    Public ReadOnly Property ThumbnailWidth() As Integer
        Get
            Return ThumbnailService.ThumbnailWidth
        End Get
    End Property
    Public ReadOnly Property ThumbnailHeight() As Integer
        Get
            Return ThumbnailService.ThumbnailHeight
        End Get
    End Property
    Public ReadOnly Property LockIconVirtPath() As String
        Get
            Return ThumbnailService.LockIconVirtPath
        End Get
    End Property
    Public ReadOnly Property EditIconVirtPath() As String
        Get
            Return ThumbnailService.EditIconVirtPath
        End Get
    End Property

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property DocumentService() As DocumentService
        Get
            Return DocumentsApp.Document
        End Get
    End Property

    Protected Property AvatarService() As AvatarService
    Protected Property ThumbnailService() As ThumbnailService

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        ThumbnailUpdatingEnabled = False
        AvatarService = New AvatarService(app)
        ThumbnailService = New ThumbnailService(app)
    End Sub

    Public Function GetFolderIconUrl() As String
        Return ThumbnailService.GetFolderIconUrl()
    End Function
    Public Function GetAvatarVirtPath(ByVal user As User) As String
        Return AvatarService.GetAvatarVirtPath(user)
    End Function
    Public Function GetIconVirtPath(ByVal item As Item) As String
        Return ThumbnailService.GetIconVirtPath(item)
    End Function
    Public Function GetThumbnailUrl(ByVal item As Item) As String
        Return ThumbnailService.GetThumbnailUrl(item)
    End Function
    Public Function HasPreview(ByVal item As Item) As Boolean
        Return ThumbnailService.HasPreview(item)
    End Function
    Public Function GetIconUrl(ByVal item As Item) As String
        Return ThumbnailService.GetIconUrl(item)
    End Function
    Public Function GetFooterItemIconVirtPath(ByVal item As Item) As String
        Return ThumbnailService.GetFooterItemIconVirtPath(item)
    End Function
    Public Function GetDetailsViewItemIcon(ByVal item As Item) As String
        Return ThumbnailService.GetDetailsViewItemIcon(item)
    End Function
    Public Sub UpdateThumbnails()
        ThumbnailService.UpdateThumbnails()
    End Sub
    Public Sub EnableThumbnailUpdating()
        ThumbnailUpdatingEnabled = True
        UpdateThumbnailsWithDelaty(FirstThumbnailUpdatingInterval)
    End Sub
    Public Sub DisableThumbnailUpdating()
        ThumbnailUpdatingEnabled = False
    End Sub
    Private Sub UpdateThumbnailsWithDelaty(ByVal delay As TimeSpan)
        CommonUtils.ExecuteActionWithDelay(Sub() OnDelayedThumbnailUpdating(), delay)
    End Sub
    Private Sub OnDelayedThumbnailUpdating()
        If Not ThumbnailUpdatingEnabled Then
            Return
        End If

        Try
            UpdateThumbnails()
        Finally
            UpdateThumbnailsWithDelaty(GeneralThumbnailUpdatingInterval)
            DataService.CloseUnitOfWork()
        End Try
    End Sub
End Class

Public Class AvatarService
    Inherits ServiceBase

    Private Const AvatarFolderVirtPath As String = "~\Content\Images\Avatars"

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property DocumentService() As DocumentService
        Get
            Return DocumentsApp.Document
        End Get
    End Property

    Private loadingLocker As New Object()

    Private avatarFolderPath_Renamed As String
    Private Property IsLoaded() As Boolean
    Private ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private ReadOnly Property AvatarFolderPath() As String
        Get
            If String.IsNullOrEmpty(avatarFolderPath_Renamed) Then
                Me.avatarFolderPath_Renamed = Context.Server.MapPath(GetAvatarFolderVirtPath())
            End If
            Return Me.avatarFolderPath_Renamed
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
    End Sub

    Public Function GetAvatarVirtPath(ByVal user As User) As String
        EnsureAvatarsLoaded()
        Return Path.Combine(GetAvatarFolderVirtPath(), GetAvatarName(user))
    End Function
    Protected Overridable Function GetAvatarFolderVirtPath() As String
        Return AvatarFolderVirtPath
    End Function
    Private Function GetAvatarName(ByVal user As User) As String
        Return user.Id.ToString() & ".jpg"
    End Function
    Private Sub EnsureAvatarsLoaded()
        SyncLock Me.loadingLocker
            If Not IsLoaded Then
                LoadAvatars()
                IsLoaded = True
            End If
        End SyncLock
    End Sub
    Private Sub LoadAvatars()
        If Not Directory.Exists(AvatarFolderPath) Then
            Directory.CreateDirectory(AvatarFolderPath)
        End If
        Dim users As IEnumerable(Of User) = DataService.Users.ToList()
        For Each user As User In users
            LoadAvatar(user)
        Next user
    End Sub
    Private Sub LoadAvatar(ByVal user As User)
        If user.Avatar IsNot Nothing Then
            Dim avatarPath As String = Path.Combine(AvatarFolderPath, GetAvatarName(user))
            File.WriteAllBytes(avatarPath, user.Avatar.Data)
        End If
    End Sub
End Class

Public Class ThumbnailService
    Inherits ServiceBase

    Private Const ThumbnailFolderVirtPath As String = "~\Content\Images\Thumb"
    Private Const PredefinedImagesFolderVirtPath As String = "~\Content\Images\Predefined"
    Private Const IconsFolderVirtPath As String = "~\Content\Images\Icons"
    Private Const DetailsIconsFolderVirtPath As String = "~\Content\Images\Icons\Details"
    Private Const EmptyThumbnailName As String = "EmptyPreview.png"
    Private Const FolderIconName As String = "Folder.png"
    Private Const LockIconName As String = "Lock.png"
    Private Const EditIconName As String = "Edit.png"
    Public Const ThumbnailWidth As Integer = 240
    Public Const ThumbnailHeight As Integer = 195

    Private updateLocker As New Object()

    Private ReadOnly Property DataService() As DataService
        Get
            Return DocumentsApp.Data
        End Get
    End Property
    Private ReadOnly Property DocumentService() As DocumentService
        Get
            Return DocumentsApp.Document
        End Get
    End Property

    Private Property ImageExtensions() As String()
    Private ReadOnly Property EmptyThumbnailVirtPath() As String
        Get
            Return Path.Combine(PredefinedImagesFolderVirtPath, EmptyThumbnailName)
        End Get
    End Property

    Public ReadOnly Property LockIconVirtPath() As String
        Get
            Return Path.Combine(IconsFolderVirtPath, LockIconName)
        End Get
    End Property
    Public ReadOnly Property EditIconVirtPath() As String
        Get
            Return Path.Combine(IconsFolderVirtPath, EditIconName)
        End Get
    End Property

    Public Sub New(ByVal app As DocumentsApp)
        MyBase.New(app)
        ImageExtensions = New String() { ".png", ".gif", ".jpg", ".jpeg", ".ico", ".bmp" }
    End Sub

    Public Function GetThumbnailUrl(ByVal item As Item) As String
        Dim thumbVirtPath As String = If(HasPreview(item), GetThumbnailVirtPathInternal(item), GetIconVirtPath(item))
        Return If(String.IsNullOrEmpty(thumbVirtPath), Nothing, CommonUtils.ConvertVirtPathToUrl(thumbVirtPath))
    End Function
    Public Function HasPreview(ByVal item As Item) As Boolean
        Dim thumbVirtPath As String = GetThumbnailVirtPathInternal(item)
        Dim thumbPath As String = CommonUtils.MapPath(thumbVirtPath)
        Return File.Exists(thumbPath)
    End Function
    Public Function GetIconUrl(ByVal item As Item) As String
        Dim iconVirtPath As String = GetIconVirtPath(item)
        Return If(String.IsNullOrEmpty(iconVirtPath), Nothing, CommonUtils.ConvertVirtPathToUrl(iconVirtPath))
    End Function
    Public Function GetIconVirtPath(ByVal item As Item) As String
        Dim iconName As String = GetIconName(item)
        Return If(String.IsNullOrEmpty(iconName), Nothing, Path.Combine(PredefinedImagesFolderVirtPath, iconName))
    End Function
    Public Function GetFooterItemIconVirtPath(ByVal item As Item) As String
        Dim iconName As String = DocumentService.GetIconName(item)
        Return If(String.IsNullOrEmpty(iconName), Nothing, Path.Combine(IconsFolderVirtPath, iconName))
    End Function
    Public Function GetDetailsViewItemIcon(ByVal item As Item) As String
        Dim iconName As String = GetIconName(item)
        Return If(String.IsNullOrEmpty(iconName), Nothing, Path.Combine(DetailsIconsFolderVirtPath, iconName))
    End Function
    Public Function GetFolderIconVirtPath() As String
        Return Path.Combine(PredefinedImagesFolderVirtPath, FolderIconName)
    End Function
    Public Function GetFolderIconUrl() As String
        Return CommonUtils.ConvertVirtPathToUrl(GetFolderIconVirtPath())
    End Function
    Private Function GetIconName(ByVal item As Item) As String
        If item.IsFolder Then
            Return FolderIconName
        End If
        Dim iconName As String = DocumentService.GetIconName(item)
        If String.IsNullOrEmpty(iconName) Then
            iconName = GetIconNameInternal(item)
        End If
        Return iconName
    End Function
    Private Function GetIconNameInternal(ByVal item As Item) As String
        Dim extension As String = Path.GetExtension(item.Name)
        If Array.Exists(ImageExtensions, Function(str) str.Equals(extension, StringComparison.OrdinalIgnoreCase)) Then
            Return Nothing
        End If
        Select Case extension
            Case ".avi"
                Return "Video.png"
            Case ".mp3"
                Return "Audio.png"
        End Select
        Return "Generic.png"
    End Function
    Private Function GetThumbnailName(ByVal item As Item) As String
        Return String.Format("{0}_{1}.png", item.Name, item.Id.ToString())
    End Function
    Private Function GetThumbnailVirtPathInternal(ByVal item As Item) As String
        Dim thumbName As String = item.Id.ToString() & ".png"
        Return Path.Combine(GetThumbnailFolderVirtPath(), thumbName)
    End Function
    Protected Overridable Function GetThumbnailFolderVirtPath() As String
        Return ThumbnailFolderVirtPath
    End Function

    Public Sub UpdateThumbnails()
        SyncLock Me.updateLocker
            Dim thumbFolderPath As String = CommonUtils.MapPath(GetThumbnailFolderVirtPath())
            If Not Directory.Exists(thumbFolderPath) Then
                Directory.CreateDirectory(thumbFolderPath)
            End If
            Dim fileItems As List(Of Item) = DataService.Items.Where(Function(item) (Not item.IsFolder)).ToList()
            For Each fileItem As Item In fileItems
                Try
                    GenerateThumbnail(fileItem)
                Catch
                End Try
            Next fileItem

        End SyncLock
    End Sub
    Private Sub GenerateThumbnail(ByVal item As Item)
        Dim thumbPath As String = GetThumbnailPath(item)
        Dim thumbFile As New FileInfo(thumbPath)
        If (Not thumbFile.Exists) OrElse item.LastWriteTime >= thumbFile.LastWriteTimeUtc Then
            GenerateThumbnailCore(item)
        End If
    End Sub
    Private Sub GenerateThumbnailCore(ByVal item As Item)
        Dim component As IPrintable = DocumentService.CreatePrintableComponent(item)
        If component Is Nothing Then
            Return
        End If

        Dim pcl As New PrintableComponentLinkBase(New PrintingSystemBase())
        pcl.Component = component
        pcl.CreateDocument()
        Dim imgOptions As New ImageExportOptions()
        imgOptions.ExportMode = ImageExportMode.SingleFilePageByPage
        imgOptions.Format = System.Drawing.Imaging.ImageFormat.Png
        imgOptions.PageRange = "1"
        imgOptions.PageBorderWidth = 0
        Dim stream As New MemoryStream()
        pcl.ExportToImage(stream, imgOptions)

        stream.Position = 0
        Dim thumbPath As String = GetThumbnailPath(item)
        GenerateThumbnailInternal(stream, thumbPath, ThumbnailWidth, ThumbnailHeight)

        Dim disposableComponent As IDisposable = TryCast(component, IDisposable)
        If disposableComponent IsNot Nothing Then
            disposableComponent.Dispose()
        End If
    End Sub
    Private Function GetThumbnailPath(ByVal item As Item) As String
        Dim thumbVirtPath As String = GetThumbnailVirtPathInternal(item)
        Return CommonUtils.MapPath(thumbVirtPath)
    End Function


    Private Sub GenerateThumbnailInternal(ByVal file As Stream, ByVal thumbnailPath As String, ByVal width As Integer, ByVal height As Integer)
        Using original As System.Drawing.Image = System.Drawing.Image.FromStream(file)
            Using thumbnail As System.Drawing.Bitmap = ChangeImageSize(original, width, height)
                thumbnail.Save(thumbnailPath)
            End Using
        End Using
    End Sub
    Private Function ChangeImageSize(ByVal original As Image, ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim scaleThumbnail As Single = CSng(height) / CSng(width)

        Dim srcRect As New RectangleF(0.0F, 0.0F, original.Width, original.Width * scaleThumbnail)
        Dim dstRect As New RectangleF(0.0F, 0.0F, width, height)

        Dim thumbnail As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(thumbnail)

        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.DrawImage(original, dstRect, srcRect, GraphicsUnit.Pixel)

        Return thumbnail
    End Function
End Class
