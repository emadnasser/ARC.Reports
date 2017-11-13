Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Partial Public Class UserControls_DocumentBrowser
    Inherits System.Web.UI.UserControl

    Private ReadOnly Property DocumentsApp() As DocumentsApp
        Get
            Return DocumentsApp.Instance
        End Get
    End Property

    Private ReadOnly Property CurrentViewModeName() As String
        Get
            Return DocumentsApp.User.CurrentViewModeName
        End Get
    End Property
    Private ReadOnly Property IsDetailsViewMode() As Boolean
        Get
            Return CurrentViewModeName = "Details"
        End Get
    End Property
    Private ReadOnly Property CurrentViewMode() As FileListView
        Get
            Return If(IsDetailsViewMode, FileListView.Details, FileListView.Thumbnails)
        End Get
    End Property
    Private Property CurrentItem() As Item

    Public Property FileSystemProvider() As FileSystemProviderBase
    Public Property IsFilterApplied() As Boolean
    Public Property PanelName() As String
    Public Property SourceName() As String

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        CustomizeFileManagerByItemsFilter()
        BrowserPanel.Visible = IsFilterApplied
        If BrowserPanel.Visible Then
            BrowserContainer.Attributes("class") &= " ShowPanel"
            FilterNameLabel.Text = PanelName
        End If
    End Sub

    Private Sub CustomizeFileManagerByItemsFilter()
        FileManager.ID = (If(IsFilterApplied, "Filtered", "")) & "FileManager"
        FileManager.CustomFileSystemProvider = FileSystemProvider
        FileManager.SettingsUpload.Enabled = Not IsFilterApplied
        FileManager.SettingsUpload.ShowUploadPanel = IsFilterApplied
        FileManager.SettingsUpload.ValidationSettings.MaxFileSize = DocumentsApp.FileSystem.GetMaxFileSizeForUpload()
        FileManager.SettingsBreadcrumbs.Visible = Not IsFilterApplied
        FileManager.Images.FileAreaFolder.Url = Page.ResolveUrl(DocumentsApp.Image.GetFolderIconUrl())
        FileManager.SettingsFileList.ThumbnailsViewSettings.ThumbnailWidth = Unit.Pixel(DocumentsApp.Image.ThumbnailWidth)
        FileManager.SettingsFileList.ThumbnailsViewSettings.ThumbnailHeight = Unit.Pixel(DocumentsApp.Image.ThumbnailHeight)
        FileManager.StylesDetailsView.CommandColumn.Width = Unit.Pixel(80)

        FileManager.SettingsEditing.AllowCopy = Not IsFilterApplied
        FileManager.SettingsEditing.AllowDelete = Not IsFilterApplied
        FileManager.SettingsEditing.AllowRename = Not IsFilterApplied
        FileManager.SettingsEditing.AllowMove = Not IsFilterApplied
        FileManager.SettingsEditing.AllowCreate = Not IsFilterApplied
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        FileManager.SettingsFileList.View = CurrentViewMode
        Dim viewModeClass As String = If(IsDetailsViewMode, "DetailsView", "ThumbnailsView")
        FileManager.CssClass = "FileManager " & viewModeClass

        If IsDetailsViewMode Then
            FileManager.Styles.File.Width = Unit.Empty
            FileManager.Styles.File.Height = Unit.Empty
        Else
            FileManager.Styles.File.Width = Unit.Pixel(270)
            FileManager.Styles.File.Height = Unit.Pixel(270)
        End If
        Dim viewModeItem As DevExpress.Web.MenuItem = ViewModeMenu.Items.FindByName(CurrentViewModeName)
        If viewModeItem IsNot Nothing Then
            viewModeItem.Selected = True
        End If
    End Sub

    Protected Sub ItemTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerThumbnailsViewItemTemplateContainer)).Item
        Dim itemId As Long = Long.Parse(fileManagerItem.Id)
        Dim item As Item = DocumentsApp.Data.FindItemById(itemId)

        Dim thumbDiv As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemThumbDiv")
        thumbDiv.Style.Add("background-image", fileManagerItem.ThumbnailUrl)

        Dim iconImage As HtmlImage = CommonUtils.FindControl(Of HtmlImage)(placeHolder, "ItemIconImage")
        Dim iconImageSrc As String = DocumentsApp.Image.GetFooterItemIconVirtPath(item)
        iconImage.Src = iconImageSrc
        iconImage.Alt = "Item type here"
        If String.IsNullOrEmpty(iconImageSrc) Then
            iconImage.Visible = False
        End If

        Dim infoDiv As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemInfoDiv")
        infoDiv.InnerText = "Modified " & GetModifiedInfoString(fileManagerItem.LastWriteTime)

        Dim holderLink As HtmlAnchor = CommonUtils.FindControl(Of HtmlAnchor)(placeHolder, "ItemHolderLink")
        PrepareItemLink(holderLink, item.IsFolder, fileManagerItem.FullName, item)

        Dim itemLocked As Boolean = CheckAndPrepareLockedState(placeHolder, item)
        If itemLocked Then
            Dim footerDiv As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemFooterDiv")
            footerDiv.Attributes("class") &= " itemLocked"
        End If
    End Sub
    Protected Sub ThumbnailCellTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)

        Dim holderLink As HtmlAnchor = CommonUtils.FindControl(Of HtmlAnchor)(placeHolder, "ItemLink")
        PrepareItemLink(holderLink, CurrentItem.IsFolder, fileManagerItem.FullName, CurrentItem)

        Dim iconImage As HtmlImage = CommonUtils.FindControl(Of HtmlImage)(placeHolder, "ItemIcon")
        Dim iconImageSrc As String = If(DocumentsApp.Image.GetDetailsViewItemIcon(CurrentItem), fileManagerItem.ThumbnailUrl)
        iconImage.Src = iconImageSrc
    End Sub
    Protected Sub NameCellTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)

        Dim holderLink As HtmlAnchor = CommonUtils.FindControl(Of HtmlAnchor)(placeHolder, "ItemLink")
        PrepareItemLink(holderLink, CurrentItem.IsFolder, fileManagerItem.FullName, CurrentItem)
    End Sub
    Protected Sub ModifiedDateCellTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)


        Dim itemLastWriteTimeSpan_Renamed As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemLastWriteTimeSpan")
        itemLastWriteTimeSpan_Renamed.InnerText = GetModifiedInfoString(fileManagerItem.LastWriteTime)
    End Sub
    Protected Sub SizeCellTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)


        Dim itemSizeSpan_Renamed As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemSizeSpan")
        If CurrentItem.IsFolder Then
            itemSizeSpan_Renamed.Visible = False
        Else
            itemSizeSpan_Renamed.InnerText = CommonUtils.GetSizeString(fileManagerItem.Length)
        End If
    End Sub
    Protected Sub OwnerCellTemplate_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)


        Dim itemOwnerSpan_Renamed As HtmlGenericControl = CommonUtils.FindControl(Of HtmlGenericControl)(placeHolder, "ItemOwnerSpan")
        itemOwnerSpan_Renamed.InnerText = GetOwnerString(CurrentItem)
    End Sub
    Protected Sub LockImageCell_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim placeHolder As PlaceHolder = DirectCast(sender, PlaceHolder)
        Dim fileManagerItem As FileManagerItem = (TryCast(placeHolder.NamingContainer, FileManagerDetailsViewItemTemplateContainer)).Item
        EnsureCurrentItemUpdated(fileManagerItem)

        CheckAndPrepareLockedState(placeHolder, CurrentItem)
    End Sub
    Private Sub PrepareItemLink(ByVal itemLink As HtmlAnchor, ByVal itemIsFolder As Boolean, ByVal itemFullName As String, ByVal item As Item)
        itemLink.Attributes.Add("onmousedown", "App.onItemLinkMouseDown(event)")
        If itemIsFolder Then
            itemLink.Attributes.Add("onclick", "App.onFolderItemLinkClick(event)")
        Else
            itemLink.Attributes.Add("onclick", "App.onFileItemLinkClick(event)")
            If DocumentsApp.Document.IsDocumentEditingAllowed(item) Then
                itemLink.Target = "_blank"
            End If
            Dim itemUrl As String = DocumentsApp.Document.GetDocumentEditorRequestUrl(itemFullName, SourceName)
            itemLink.HRef = Server.HtmlEncode(itemUrl)
        End If
    End Sub
    Private Function CheckAndPrepareLockedState(ByVal container As Control, ByVal item As Item) As Boolean
        Dim user As User = DocumentsApp.Document.GetDocumentLockOwner(item)
        If user IsNot Nothing Then

            Dim itemLockImage_Renamed As HtmlImage = CommonUtils.FindControl(Of HtmlImage)(container, "ItemLockImage")
            itemLockImage_Renamed.Visible = True
            Dim iconUrl, tooltip As String
            If user.Id = DocumentsApp.User.CurrentUser.Id Then
                iconUrl = DocumentsApp.Image.EditIconVirtPath
                tooltip = "Opened by Me"
            Else
                iconUrl = DocumentsApp.Image.LockIconVirtPath
                tooltip = "Locked by " & user.Name
            End If
            itemLockImage_Renamed.Src = iconUrl
            itemLockImage_Renamed.Alt = tooltip
            itemLockImage_Renamed.Attributes("title") = tooltip
            Return True
        End If
        Return False
    End Function
    Private Function GetModifiedInfoString(ByVal [date] As Date) As String
        Dim format As String = If([date].Date = Date.Today, "H:mm", "d MMM yyy")
        Return [date].ToString(format)
    End Function
    Private Function GetOwnerString(ByVal item As Item) As String
        If item.Owner Is Nothing Then
            Return String.Empty
        End If
        Return If(item.Owner.Id = DocumentsApp.User.CurrentUser.Id, "Me", item.Owner.Name)
    End Function
    Private Sub EnsureCurrentItemUpdated(ByVal fileManagerItem As FileManagerItem)
        Dim currentItemId As Long = Long.Parse(fileManagerItem.Id)
        If CurrentItem Is Nothing OrElse CurrentItem.Id <> currentItemId Then
            CurrentItem = DocumentsApp.Data.FindItemById(currentItemId)
        End If
    End Sub
End Class
