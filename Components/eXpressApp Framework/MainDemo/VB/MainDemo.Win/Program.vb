Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win
Imports System.Threading
Imports DevExpress.ExpressApp.AuditTrail
Imports MainDemo.Module
Imports DevExpress.Persistent.AuditTrail
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.MiddleTier
Imports DevExpress.ExpressApp.Security.ClientServer
Imports DevExpress.Internal
Imports System.Windows.Forms
Imports DevExpress.Persistent.Base

Namespace MainDemo.Win
    Public Class Program
        Private Shared Sub winApplication_CustomizeFormattingCulture(ByVal sender As Object, ByVal e As CustomizeFormattingCultureEventArgs)
            e.FormattingCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US")
        End Sub
        <STAThread()> _
        Public Shared Sub Main(ByVal arguments() As String)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath
            Tracing.Initialize()
            Dim winApplication As New MainDemoWinApplication()
#If DEBUG Then
            Try
                DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
            Catch e1 As Exception
            End Try
#End If
            AddHandler winApplication.CustomizeFormattingCulture, AddressOf winApplication_CustomizeFormattingCulture
            Try
                AddHandler AuditTrailService.Instance.QueryCurrentUserName, AddressOf Instance_QueryCurrentUserName
                AddHandler winApplication.LastLogonParametersReading, AddressOf winApplication_LastLogonParametersReading
                AddHandler winApplication.CreateCustomObjectSpaceProvider, AddressOf winApplication_CreateCustomObjectSpaceProvider
                Dim connectionStringSettings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ConnectionString")
                If connectionStringSettings IsNot Nothing Then
                    winApplication.ConnectionString = connectionStringSettings.ConnectionString
                ElseIf String.IsNullOrEmpty(winApplication.ConnectionString) And winApplication.Connection Is Nothing Then
                    connectionStringSettings = ConfigurationManager.ConnectionStrings("SqlExpressConnectionString")
                    If connectionStringSettings IsNot Nothing Then
                        winApplication.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString)
                    End If
                End If
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
        Private Shared Sub winApplication_LastLogonParametersReading(ByVal sender As Object, ByVal e As LastLogonParametersReadingEventArgs)
            If String.IsNullOrEmpty(e.SettingsStorage.LoadOption("", "UserName")) Then
                e.SettingsStorage.SaveOption("", "UserName", "Sam")
            End If
        End Sub
        Private Shared Sub winApplication_CreateCustomObjectSpaceProvider(ByVal sender As Object, ByVal e As CreateCustomObjectSpaceProviderEventArgs)
            Dim application As MainDemoWinApplication = DirectCast(sender, MainDemoWinApplication)
            e.ObjectSpaceProvider = New SecuredObjectSpaceProvider(DirectCast(application.Security, ISelectDataSecurityProvider), application.ConnectionString, application.Connection)
        End Sub
        Private Shared Sub Instance_QueryCurrentUserName(ByVal sender As Object, ByVal e As QueryCurrentUserNameEventArgs)
            e.CurrentUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name
        End Sub
    End Class
End Namespace
