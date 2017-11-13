Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Web
Imports System.Configuration
Imports System.Threading
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo

Namespace MainDemo.Web
    Public Class MainDemoWebApplication
        Inherits WebApplication
        Private systemModule1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private webSystemModule1 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private securityModule1 As SecurityModule
        Private securityStrategyComplex1 As SecurityStrategyComplex
        Private objectsModule1 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private auditTrailModule1 As DevExpress.ExpressApp.AuditTrail.AuditTrailModule
        Private fileAttachmentsWebModule1 As DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule
        Private reportsModuleV21 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsAspNetModuleV21 As DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2
        Private validationModule1 As DevExpress.ExpressApp.Validation.ValidationModule
        Private validationAspNetModule1 As DevExpress.ExpressApp.Validation.Web.ValidationAspNetModule
        Private viewVariantsModule1 As DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule
        Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private mainDemoWebModule1 As MainDemo.Module.Web.MainDemoWebModule
        Private mainDemoModule1 As MainDemo.Module.MainDemoModule
        Private authenticationStandard1 As AuthenticationStandard
        Private schedulerAspNetModule1 As DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule
        Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
        Private pivotChartAspNetModule1 As DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule
        Private pivotChartModuleBase1 As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
        Private htmlPropertyEditorAspNetModule1 As DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule
        Private scriptRecorderAspNetModule1 As DevExpress.ExpressApp.ScriptRecorder.Web.ScriptRecorderAspNetModule
        Private scriptRecorderModuleBase1 As DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase

        Public Sub New()
            InitializeComponent()
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.AllowFilterControlHierarchy = True
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxGridListEditor.MaxFilterControlHierarchyDepth = 3
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxCriteriaPropertyEditor.AllowFilterControlHierarchyDefault = True
            DevExpress.ExpressApp.Web.Editors.ASPx.ASPxCriteriaPropertyEditor.MaxHierarchyDepthDefault = 3
        End Sub
        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
			args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection, True)
        End Sub
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainDemoWebApplication))
            Me.systemModule1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.webSystemModule1 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
            Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
            Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
            Me.objectsModule1 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.auditTrailModule1 = New DevExpress.ExpressApp.AuditTrail.AuditTrailModule()
            Me.fileAttachmentsWebModule1 = New DevExpress.ExpressApp.FileAttachments.Web.FileAttachmentsAspNetModule()
            Me.reportsModuleV21 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsAspNetModuleV21 = New DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2()
            Me.validationModule1 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.validationAspNetModule1 = New Validation.Web.ValidationAspNetModule()
            Me.viewVariantsModule1 = New DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule()
            Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            Me.mainDemoModule1 = New MainDemo.Module.MainDemoModule()
            Me.mainDemoWebModule1 = New MainDemo.Module.Web.MainDemoWebModule()
            Me.schedulerAspNetModule1 = New DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule()
            Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
            Me.pivotChartAspNetModule1 = New DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule()
            Me.pivotChartModuleBase1 = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
            Me.htmlPropertyEditorAspNetModule1 = New DevExpress.ExpressApp.HtmlPropertyEditor.Web.HtmlPropertyEditorAspNetModule()
            Me.scriptRecorderModuleBase1 = New DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase()
            Me.scriptRecorderAspNetModule1 = New DevExpress.ExpressApp.ScriptRecorder.Web.ScriptRecorderAspNetModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' securityComplex1
            ' 
            Me.securityStrategyComplex1.Authentication = Me.authenticationStandard1
            Me.securityStrategyComplex1.RoleType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole)
            Me.securityStrategyComplex1.UserType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser)
            ' 
            ' authenticationStandard1
            ' 
            Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
            Me.authenticationStandard1.UserType = GetType(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser)
            ' 
            ' auditTrailModule1
            ' 
            Me.auditTrailModule1.AuditDataItemPersistentType = GetType(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent)
            ' 
            ' reportsModuleV21
            ' 
            Me.reportsModuleV21.EnableInplaceReports = True
            Me.reportsModuleV21.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
            Me.reportsModuleV21.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML
            Me.reportsAspNetModuleV21.ReportViewerType = DevExpress.ExpressApp.ReportsV2.Web.ReportViewerTypes.HTML5
            ' 
            ' MainDemoWebApplication
            ' 
            Me.ApplicationName = "MainDemo"
            Me.Modules.Add(Me.systemModule1)
            Me.Modules.Add(Me.webSystemModule1)
            Me.Modules.Add(Me.securityModule1)
            Me.Modules.Add(Me.objectsModule1)
            Me.Modules.Add(Me.auditTrailModule1)
            Me.Modules.Add(Me.fileAttachmentsWebModule1)
            Me.Modules.Add(Me.reportsModuleV21)
            Me.Modules.Add(Me.reportsAspNetModuleV21)
            Me.Modules.Add(Me.validationModule1)
            Me.Modules.Add(Me.validationAspNetModule1)
            Me.Modules.Add(Me.viewVariantsModule1)
            Me.Modules.Add(Me.conditionalAppearanceModule1)
            Me.Modules.Add(Me.mainDemoModule1)
            Me.Modules.Add(Me.mainDemoWebModule1)
            Me.Modules.Add(Me.schedulerModuleBase1)
            Me.Modules.Add(Me.schedulerAspNetModule1)
            Me.Modules.Add(Me.pivotChartModuleBase1)
            Me.Modules.Add(Me.pivotChartAspNetModule1)
            Me.Modules.Add(Me.htmlPropertyEditorAspNetModule1)
            Me.Modules.Add(Me.scriptRecorderModuleBase1)
            Me.Modules.Add(Me.scriptRecorderAspNetModule1)
            Me.Security = Me.securityStrategyComplex1
            '			Me.LastLogonParametersRead += New System.EventHandler(Of DevExpress.ExpressApp.LastLogonParametersReadEventArgs)(Me.MainDemoWebApplication_LastLogonParametersRead);
            '			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.MainDemoWebApplication_DatabaseVersionMismatch);
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Private Sub MainDemoWebApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
        Private Sub MainDemoWebApplication_LastLogonParametersRead(ByVal sender As Object, ByVal e As LastLogonParametersReadEventArgs) Handles MyBase.LastLogonParametersRead
            ' Just to read demo user name for logon.
            Dim logonParameters As AuthenticationStandardLogonParameters = TryCast(e.LogonObject, AuthenticationStandardLogonParameters)
            If logonParameters IsNot Nothing Then
                If String.IsNullOrEmpty(logonParameters.UserName) Then
                    logonParameters.UserName = "Sam"
                End If
            End If
        End Sub
    End Class
End Namespace
