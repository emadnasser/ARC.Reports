Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_Index
    Inherits System.Web.UI.UserControl
    Implements IPageUserControl

    Public Sub LoadState(ByVal state As SearchState) Implements IPageUserControl.LoadState
        CheckInDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(1))
        CheckInDateEdit.MinDate = Date.Now.Add(TimeSpan.FromDays(1))
        CheckOutDateEdit.Value = Date.Now.Add(TimeSpan.FromDays(3))
    End Sub
    Protected Sub LoginCaptcha_Load(ByVal sender As Object, ByVal e As EventArgs)
        LoginCaptcha.ChallengeImage.BackgroundColor = Color.FromArgb(178, 178, 178)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If IsPostBack Then
            LoginCaptcha.IsValid = LoginCaptcha.Code = LoginCaptchaEditor.Text
        End If
    End Sub
End Class
