Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Controllers
    Partial Public Class TaskActionsController
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
            Me.SetTaskAction = New DevExpress.ExpressApp.Actions.SingleChoiceAction(Me.components)
            ' 
            ' SetPriorityAction
            ' 
            Me.SetTaskAction.Caption = "Set Task"
            Me.SetTaskAction.Category = DevExpress.Persistent.Base.PredefinedCategory.Edit.ToString()
            Me.SetTaskAction.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireMultipleObjects
            Me.SetTaskAction.Id = "SetTaskAction"
            Me.SetTaskAction.ImageName = "BO_Task"
            Me.SetTaskAction.ItemType = DevExpress.ExpressApp.Actions.SingleChoiceActionItemType.ItemIsOperation
            Me.TargetObjectType = GetType(MainDemo.Module.BusinessObjects.DemoTask)
            '		 Me.SetTaskAction.Execute += New DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(Me.SetTaskAction_Execute);
            ' 
            ' SetPriorityController
            ' 
            '		 Me.Activated += New System.EventHandler(Me.TaskActionsController_Activated);

        End Sub

#End Region

        Private WithEvents SetTaskAction As DevExpress.ExpressApp.Actions.SingleChoiceAction
    End Class
End Namespace