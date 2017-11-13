Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module
	Partial Public Class MainDemoModule
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            '
            'MainDemoModule
            '
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.BaseObject))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Task))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PhoneNumber))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PhoneType))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.RoleBase))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Role))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Party))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Person))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Note))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.[Event]))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Resource))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PersistentPermission))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Organization))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.HCategory))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PropertyBagDescriptor))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Country))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.State))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Address))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.FileAttachmentBase))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.User))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.SimpleUser))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.BasicUser))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Analysis))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.FileData))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PropertyDescriptor))
            Me.Description = "MainDemo module"
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Validation.ValidationModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Security.SecurityModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.ReportsV2.ReportsModuleV2))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.PivotChart.PivotChartModuleBase))

        End Sub

		#End Region
	End Class
End Namespace
