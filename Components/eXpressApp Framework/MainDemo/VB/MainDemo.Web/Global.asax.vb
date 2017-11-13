Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Globalization
Imports System.Reflection
Imports System.Web

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Web

Imports MainDemo.Module
Imports System.Web.Configuration
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.TestScripts
Imports DevExpress.Persistent.AuditTrail
Imports DevExpress.ExpressApp.Security
Imports DevExpress.Web
Imports MainDemo.Module.BusinessObjects
Imports DevExpress.ExpressApp.MiddleTier
Imports DevExpress.ExpressApp.Security.ClientServer
Imports DevExpress.Internal
Imports DevExpress.Persistent.Base

Namespace MainDemo.Web
    Public Class [Global]
        Inherits System.Web.HttpApplication
        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            AddHandler ASPxWebControl.CallbackError, AddressOf Application_Error
#If DEBUG Then
            TestScriptsManager.EasyTestEnabled = True
#End If
        End Sub
        Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
            Tracing.Initialize()
            WebApplication.SetInstance(Session, New MainDemoWebApplication())
            AddHandler AuditTrailService.Instance.CustomizeAuditTrailSettings, AddressOf Instance_CustomizeAuditTrailSettings
            AddHandler AuditTrailService.Instance.QueryCurrentUserName, AddressOf Instance_QueryCurrentUserName
            AddHandler WebApplication.Instance.LastLogonParametersReading, AddressOf Instance_LastLogonParametersReading
            AddHandler WebApplication.Instance.CustomizeFormattingCulture, AddressOf Instance_CustomizeFormattingCulture
            AddHandler WebApplication.Instance.CreateCustomObjectSpaceProvider, AddressOf Instance_CreateCustomObjectSpaceProvider
            Dim connectionStringSettings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ConnectionString")
            If connectionStringSettings IsNot Nothing Then
                WebApplication.Instance.ConnectionString = connectionStringSettings.ConnectionString
            ElseIf String.IsNullOrEmpty(WebApplication.Instance.ConnectionString) And WebApplication.Instance.Connection Is Nothing Then
                connectionStringSettings = ConfigurationManager.ConnectionStrings("SqlExpressConnectionString")
                If connectionStringSettings IsNot Nothing Then
                    WebApplication.Instance.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString)
                End If
            End If
            DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderControllerBase.ScriptRecorderEnabled = True
            DefaultVerticalTemplateContentNew.ClearSizeLimit()
            WebApplication.Instance.SwitchToNewStyle()
            WebApplication.Instance.Setup()
            WebApplication.Instance.Start()
        End Sub
        Private Sub Instance_CreateCustomObjectSpaceProvider(ByVal sender As Object, ByVal e As CreateCustomObjectSpaceProviderEventArgs)
            Dim application As MainDemoWebApplication = DirectCast(sender, MainDemoWebApplication)
            e.ObjectSpaceProvider = New SecuredObjectSpaceProvider(DirectCast(application.Security, ISelectDataSecurityProvider), application.ConnectionString, application.Connection)
        End Sub
        Private Sub Instance_CustomizeFormattingCulture(ByVal sender As Object, ByVal e As CustomizeFormattingCultureEventArgs)
            e.FormattingCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US")
        End Sub
        Private Sub Instance_LastLogonParametersReading(ByVal sender As Object, ByVal e As LastLogonParametersReadingEventArgs)
            If String.IsNullOrEmpty(e.SettingsStorage.LoadOption("", "UserName")) Then
                e.SettingsStorage.SaveOption("", "UserName", "Sam")
            End If
        End Sub
        Private Sub Instance_QueryCurrentUserName(ByVal sender As Object, ByVal e As QueryCurrentUserNameEventArgs)
            e.CurrentUserName = String.Format("Web user ({0})", HttpContext.Current.Request.UserHostAddress)
        End Sub
        Private Sub Instance_CustomizeAuditTrailSettings(ByVal sender As Object, ByVal e As CustomizeAuditTrailSettingsEventArgs)
            e.AuditTrailSettings.Clear()
            e.AuditTrailSettings.AddType(GetType(Contact), True)
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
End Namespace
