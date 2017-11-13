Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports DevExpress.Web.Internal

Partial Public Class DocumentEditor
    Inherits System.Web.UI.MasterPage

    Private ReadOnly Property DocumentsApp() As DocumentsApp
        Get
            Return DocumentsApp.Instance
        End Get
    End Property

    Public Property StatusMarkText() As String
        Get
            Return StatusMarkLabel.Text
        End Get
        Set(ByVal value As String)
            StatusMarkLabel.Text = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            Dim documentName As String = DocumentsApp.Document.CurrentDocument.Name
            Page.Title = documentName
            TitleLabel.Text = documentName
            Dim userItem As DevExpress.Web.MenuItem = UserMenu.Items.FindByName("User")
            userItem.Text = DocumentsApp.User.CurrentUser.Name
            userItem.Image.Url = DocumentsApp.GetCurrentUserAvatarVirtPath()
        End If
    End Sub
    Protected Sub UserMenu_ItemClick(ByVal source As Object, ByVal e As MenuItemEventArgs)
        DocumentsApp.User.SignOut()
    End Sub
    Protected Sub DialogCallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        Dim dialog As UserControls_SaveAsDocumentDialog = CType(LoadControl("~/UserControls/SaveAsDocumentDialog.ascx"), UserControls_SaveAsDocumentDialog)
        dialog.ID = "SaveAsDocumentDialog"
        dialog.DefaultDocumentName = DocumentsApp.Document.GetDefaultNameForCurrentDocument()
        DialogCallbackPanel.Controls.Add(dialog)
    End Sub
    Protected Sub DocumentEditorCallback_Callback(ByVal source As Object, ByVal e As CallbackEventArgs)
        Dim newDocumentName As String = e.Parameter
        Dim newDocumentUrl As String = Nothing
        Dim commandStatus As DocumentCommandResult = DocumentsApp.Document.TrySaveAsNewDocument(newDocumentName, newDocumentUrl)
        If commandStatus = DocumentCommandResult.OK Then
            ASPxWebControl.RedirectOnCallback(newDocumentUrl)
        Else
            e.Result = If(commandStatus = DocumentCommandResult.DocumentAlreadyExists, "exists", "format")
        End If
    End Sub
End Class
