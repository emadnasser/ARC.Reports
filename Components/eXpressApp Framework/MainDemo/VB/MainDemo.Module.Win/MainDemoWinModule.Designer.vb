Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Win
	Partial Public Class MainDemoWinModule
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
            'MainDemoWinModule
            '
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.ExpressApp.Validation.ResultsHighlightController))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.ExpressApp.Validation.AllContextsView.DisplayableValidationResultItem))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.ExpressApp.Validation.AllContextsView.ContextValidationResult))
            Me.AdditionalExportedTypes.Add(GetType(DevExpress.ExpressApp.Validation.AllContextsView.ValidationResults))
            Me.Description = "MainDemo Win module"
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.HtmlPropertyEditor.Win.HtmlPropertyEditorWindowsFormsModule))
            Me.RequiredModuleTypes.Add(GetType(MainDemo.[Module].MainDemoModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Validation.ValidationModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Scheduler.SchedulerModuleBase))
            Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule))

        End Sub
		#End Region
	End Class
End Namespace
