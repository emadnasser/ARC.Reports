Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private ReadOnly Property DocumentsApp() As DocumentsApp
        Get
            Return DocumentsApp.Instance
        End Get
    End Property

    Private ReadOnly Property SelectedFilter() As String
        Get
            Return FilterMenu.SelectedItem.Name
        End Get
    End Property
    Private ReadOnly Property SelectedFilterText() As String
        Get
            Select Case SelectedFilter
                Case "My"
                    Return "My documents"
                Case "Recent"
                    Return "Recent documents"
                Case "RTFDocs"
                    Return "Rich text documents"
                Case "Sheets"
                    Return "Worksheet documents"
            End Select
            Return FilterMenu.SelectedItem.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        PrepareUserMenu()
        Dim docBrowser As UserControls_DocumentBrowser = CType(LoadControl("~/UserControls/DocumentBrowser.ascx"), UserControls_DocumentBrowser)
        docBrowser.ID = "DocumentBrowserAll"
        docBrowser.FileSystemProvider = CreateFileSystemProvider()
        docBrowser.IsFilterApplied = SelectedFilter <> "All"
        docBrowser.PanelName = SelectedFilterText
        docBrowser.SourceName = SelectedFilter
        CallbackPanel.Controls.Add(docBrowser)
    End Sub
    Protected Function CreateFileSystemProvider() As FileSystemProviderBase
        If SelectedFilter <> "All" Then
            Dim queryProvider As New FilteredFileSystemProvider(DocumentsApp, "")
            queryProvider.FileQuery = DocumentsApp.FileSystem.GetFilesFromSource(SelectedFilter)
            Return queryProvider
        End If
        Return New GeneralFileSystemProvider(DocumentsApp, "Files")
    End Function
    Protected Sub PrepareUserMenu()
        If Not IsPostBack Then
            Dim userItem As DevExpress.Web.MenuItem = UserMenu.Items.FindByName("User")
            userItem.Text = DocumentsApp.User.CurrentUser.Name
            userItem.Image.Url = DocumentsApp.GetCurrentUserAvatarVirtPath()
        End If
    End Sub
    Protected Sub UserMenu_ItemClick(ByVal source As Object, ByVal e As MenuItemEventArgs)
        DocumentsApp.User.SignOut()
    End Sub
End Class
