Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.EF
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Internal
Imports System.Configuration

' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/DevExpressExpressAppWinWinApplicationMembersTopicAll.aspx
Partial Public Class SimpleProjectManagerWindowsFormsApplication
    Inherits WinApplication
    Public Sub New()
        InitializeComponent()
    End Sub
    Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
        args.ObjectSpaceProviders.Add(New XPObjectSpaceProvider(DbEngineDetector.PatchConnectionString(ConfigurationManager.ConnectionStrings("ConnectionStringXpo").ConnectionString), Nothing, False))
        args.ObjectSpaceProviders.Add(New EFObjectSpaceProvider(GetType(SimpleProjectManager.Module.SimpleProjectManagerDbContext), DbEngineDetector.PatchConnectionString(ConfigurationManager.ConnectionStrings("ConnectionStringEF").ConnectionString)))
    End Sub
    Private Sub SimpleProjectManagerWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
        e.Updater.Update()
        e.Handled = True
    End Sub
End Class
