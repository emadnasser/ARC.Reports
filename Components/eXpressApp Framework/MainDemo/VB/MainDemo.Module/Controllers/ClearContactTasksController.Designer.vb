Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Controllers
    Partial Public Class ClearContactTasksController
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
            Me.components = New System.ComponentModel.Container()
            Me.ClearTasksAction = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            ' 
			' ClearTasksAction
            ' 
			Me.ClearTasksAction.Caption = "Clear Tasks"
			Me.ClearTasksAction.ConfirmationMessage = "Are you sure you want to clear the Tasks list?"
			Me.ClearTasksAction.Id = "ClearTasksAction"
            Me.ClearTasksAction.ImageName = "Action_Clear"

			'		  Me.ClearTasksAction.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.ClearTasksAction_Execute);
            ' 
			' ClearTasksController
            ' 
            Me.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView
			'		  Me.Activated += New System.EventHandler(Me.ClearTasksController_Activated);
        End Sub

#End Region

        Private WithEvents ClearTasksAction As DevExpress.ExpressApp.Actions.SimpleAction

    End Class
End Namespace
