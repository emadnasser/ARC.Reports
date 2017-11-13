Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Win
	Partial Public Class MainDemoWinApplication
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub DisposeCore()
			If (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.DisposeCore()
		End Sub

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.systemModule1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.winSystemModule1 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.mainDemoWinModule1 = New MainDemo.Module.Win.MainDemoWinModule()
			Me.viewVariantsModule1 = New DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule()
			Me.validationModule1 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.mainDemoModule1 = New MainDemo.Module.MainDemoModule()
			Me.objectsModule1 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.reportsModuleV21 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsWindowsFormsModuleV21 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
			Me.validationWinModule1 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
			Me.fileAttachmentsWinModule1 = New DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule()
			Me.auditTrailModule1 = New DevExpress.ExpressApp.AuditTrail.AuditTrailModule()
            Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            Me.securityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
            Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
            Me.pivotChartWindowsFormsModule1 = New DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule()
			Me.pivotChartModuleBase1 = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
			Me.schedulerWindowsFormsModule1 = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
			Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
			Me.htmlPropertyEditorWindowsFormsModule1 = New DevExpress.ExpressApp.HtmlPropertyEditor.Win.HtmlPropertyEditorWindowsFormsModule()
			Me.scriptRecorderModuleBase1 = New DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase()
            Me.scriptRecorderWindowsFormsModule1 = New DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
            ' reportsModuleV21
			' 
            Me.reportsModuleV21.EnableInplaceReports = True
            Me.reportsModuleV21.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
            Me.reportsModuleV21.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML
            ' 
            ' auditTrailModule1
            ' 
            Me.auditTrailModule1.AuditDataItemPersistentType = GetType(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent)
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
            ' MainDemoWinApplication
            ' 
            Me.ApplicationName = "MainDemo"
            Me.Modules.Add(Me.systemModule1)
			Me.Modules.Add(Me.winSystemModule1)
			Me.Modules.Add(Me.viewVariantsModule1)
			Me.Modules.Add(Me.validationModule1)
			Me.Modules.Add(Me.securityModule1)
			Me.Modules.Add(Me.objectsModule1)
            Me.Modules.Add(Me.conditionalAppearanceModule1)
			Me.Modules.Add(Me.mainDemoModule1)
			Me.Modules.Add(Me.mainDemoWinModule1)
            Me.Modules.Add(Me.reportsModuleV21)
            Me.Modules.Add(Me.reportsWindowsFormsModuleV21)
			Me.Modules.Add(Me.validationWinModule1)
			Me.Modules.Add(Me.fileAttachmentsWinModule1)
			Me.Modules.Add(Me.auditTrailModule1)
            Me.Modules.Add(Me.pivotChartModuleBase1)
			Me.Modules.Add(Me.pivotChartWindowsFormsModule1)
			Me.Modules.Add(Me.schedulerModuleBase1)
			Me.Modules.Add(Me.schedulerWindowsFormsModule1)
			Me.Modules.Add(Me.htmlPropertyEditorWindowsFormsModule1)
			Me.Modules.Add(Me.scriptRecorderModuleBase1)
            Me.Modules.Add(Me.scriptRecorderWindowsFormsModule1)
            Me.UseOldTemplates = False
            Me.Security = Me.securityStrategyComplex1
            '			Me.LastLogonParametersRead += New System.EventHandler(Of DevExpress.ExpressApp.LastLogonParametersReadEventArgs)(Me.MainDemoWebApplication_LastLogonParametersRead);
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.MainDemoWinApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private systemModule1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private winSystemModule1 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private mainDemoWinModule1 As MainDemo.Module.Win.MainDemoWinModule
		Private viewVariantsModule1 As DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule
		Private validationModule1 As DevExpress.ExpressApp.Validation.ValidationModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private mainDemoModule1 As MainDemo.Module.MainDemoModule
		Private objectsModule1 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private reportsModuleV21 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsWindowsFormsModuleV21 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
		Private validationWinModule1 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
		Private fileAttachmentsWinModule1 As DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
		Private auditTrailModule1 As DevExpress.ExpressApp.AuditTrail.AuditTrailModule
        Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private securityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex
		Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard
        Private pivotChartWindowsFormsModule1 As DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule
		Private pivotChartModuleBase1 As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
		Private schedulerWindowsFormsModule1 As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
		Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
		Private htmlPropertyEditorWindowsFormsModule1 As DevExpress.ExpressApp.HtmlPropertyEditor.Win.HtmlPropertyEditorWindowsFormsModule
		Private scriptRecorderWindowsFormsModule1 As DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule
		Private scriptRecorderModuleBase1 As DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase
    End Class
End Namespace
