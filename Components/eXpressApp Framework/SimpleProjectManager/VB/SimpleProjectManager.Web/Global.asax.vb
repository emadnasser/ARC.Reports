Imports System.Configuration
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web
Imports DevExpress.Web
Imports DevExpress.Internal
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.Persistent.Base

Public Class [Global]
    Inherits HttpApplication
    Public Sub New()
        InitializeComponent()
    End Sub
    Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler ASPxWebControl.CallbackError, AddressOf Application_Error

#If DEBUG Then
        DevExpress.ExpressApp.Web.TestScripts.TestScriptsManager.EasyTestEnabled = True
#End If

    End Sub
    Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Tracing.Initialize()
        WebApplication.SetInstance(Session, New SimpleProjectManagerAspNetApplication())
        If System.Diagnostics.Debugger.IsAttached Then
            WebApplication.Instance.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
        End If
        DefaultVerticalTemplateContentNew.ClearSizeLimit()
        WebApplication.Instance.SwitchToNewStyle()
        WebApplication.Instance.Setup()
        WebApplication.Instance.Start()
    End Sub
    Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Protected Sub Application_EndRequest(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ErrorHandling.Instance.ProcessApplicationError()
    End Sub
    Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        WebApplication.LogOff(Session)
        WebApplication.DisposeInstance(Session)
    End Sub
    Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
#Region "Web Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
    End Sub
#End Region
End Class
