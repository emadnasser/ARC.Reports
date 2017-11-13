Imports System
Imports System.Collections.Generic

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.DC

Imports MainDemo.Module.BusinessObjects
Imports DevExpress.Xpo

Namespace MainDemo.Module.Controllers
	Partial Public Class ClearContactTasksController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub

		Private Sub ClearTasksAction_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles ClearTasksAction.Execute
			While (CType(View.CurrentObject, Contact).Tasks.Count > 0)
				CType(View.CurrentObject, Contact).Tasks.Remove(CType(View.CurrentObject, Contact).Tasks(0))
			End While
			ObjectSpace.SetModified(View.CurrentObject)
		End Sub

		Private Sub ClearTasksController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			ClearTasksAction.Enabled.SetItemValue("EditMode", (CType(View, DetailView)).ViewEditMode = ViewEditMode.Edit)
			AddHandler (CType(View, DetailView)).ViewEditModeChanged, AddressOf ClearTasksController_ViewEditModeChanged
		End Sub
		Private Sub ClearTasksController_ViewEditModeChanged(ByVal sender As Object, ByVal e As EventArgs)
			ClearTasksAction.Enabled.SetItemValue("EditMode", (CType(View, DetailView)).ViewEditMode = ViewEditMode.Edit)
		End Sub
	End Class
End Namespace
