Imports System.Configuration
Imports DevExpress.Internal
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base

Friend NotInheritable Class Program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub
    <STAThread> _
    Shared Sub Main()
#If DEBUG Then
        DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        EditModelPermission.AlwaysGranted = Debugger.IsAttached
        Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath
        Tracing.Initialize()
        Dim winApplication As New SimpleProjectManagerWindowsFormsApplication()
        ' Refer to the https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112680.aspx help article for more details on how to provide a custom splash form.
        'winApplication.SplashScreen = New DevExpress.ExpressApp.Win.Utils.DXSplashScreen("YourSplashImage.png")
        If System.Diagnostics.Debugger.IsAttached Then
            winApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
        End If
        Try
            winApplication.Setup()
            winApplication.Start()
        Catch e As Exception
            winApplication.HandleException(e)
        End Try
    End Sub
End Class
