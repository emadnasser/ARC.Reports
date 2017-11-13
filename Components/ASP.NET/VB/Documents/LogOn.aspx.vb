Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class LogOn
    Inherits System.Web.UI.Page

    Private ReadOnly Property UserService() As UserService
        Get
            Return DocumentsApp.Instance.User
        End Get
    End Property

    Private Property UserAccountName() As String
        Get
            Return AccountNameTextBox.Text
        End Get
        Set(ByVal value As String)
            AccountNameTextBox.Text = value
        End Set
    End Property
    Private Property UserPasswordText() As String
        Get
            Return UserPasswordTextBox.Text
        End Get
        Set(ByVal value As String)
            UserPasswordTextBox.Text = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If IsPostBack Then
            If Not UserService.SignIn(UserAccountName, Nothing) Then
                LogonContainer.Attributes("class") &= " LogonError"
                FormLayout.FindItemOrGroupByName("Error").Visible = True
                ErrorLabel.Text = String.Format("Login failed for '{0}'. Make sure your account name is correct and retype the password in the correct case.", UserAccountName)
            End If
        Else
            UserAccountName = UserService.DefaultUserAccountName
        End If
    End Sub
End Class
