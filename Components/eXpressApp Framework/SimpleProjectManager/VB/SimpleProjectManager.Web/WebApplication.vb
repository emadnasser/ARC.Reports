Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.EF
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Internal
Imports System.Configuration

' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/DevExpressExpressAppWebWebApplicationMembersTopicAll.aspx
Partial Public Class SimpleProjectManagerAspNetApplication
    Inherits WebApplication
    Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
    Private module3 As SimpleProjectManager.Module.SimpleProjectManagerModule
    Private module4 As SimpleProjectManager.Module.Web.SimpleProjectManagerAspNetModule
    Private validationModule1 As DevExpress.ExpressApp.Validation.ValidationModule
    Private validationAspNetModule1 As DevExpress.ExpressApp.Validation.Web.ValidationAspNetModule

    Public Sub New()
        InitializeComponent()
    End Sub
    Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
        args.ObjectSpaceProviders.Add(New XPObjectSpaceProvider(DbEngineDetector.PatchConnectionString(ConfigurationManager.ConnectionStrings("ConnectionStringXpo").ConnectionString), Nothing, True))
        args.ObjectSpaceProviders.Add(New EFObjectSpaceProvider(GetType(SimpleProjectManager.Module.SimpleProjectManagerDbContext), DbEngineDetector.PatchConnectionString(ConfigurationManager.ConnectionStrings("ConnectionStringEF").ConnectionString)))
    End Sub
    Private Sub SimpleProjectManagerAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
        e.Updater.Update()
        e.Handled = True
    End Sub
    Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
        Me.module3 = New SimpleProjectManager.Module.SimpleProjectManagerModule()
        Me.module4 = New SimpleProjectManager.Module.Web.SimpleProjectManagerAspNetModule()
        Me.validationModule1 = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.validationAspNetModule1 = New Validation.Web.ValidationAspNetModule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' SimpleProjectManagerAspNetApplication
        ' 
        Me.ApplicationName = "SimpleProjectManager"
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.validationModule1)
        Me.Modules.Add(Me.validationAspNetModule1)
        '			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.SimpleProjectManagerAspNetApplication_DatabaseVersionMismatch)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
End Class
