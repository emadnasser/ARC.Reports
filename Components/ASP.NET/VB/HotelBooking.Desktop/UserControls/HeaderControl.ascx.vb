﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class UserControls_HeaderControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Protected Sub btnLoginNow_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Captcha.IsValid Then
            LogonControl.ShowOnPageLoad = False
        End If
    End Sub
End Class