Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Controllers
    Partial Public Class ChooseTemplateController
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
            Me.ChooseTemplateAction = New DevExpress.ExpressApp.Actions.SingleChoiceAction(Me.components)
            ' 
            ' ClearFieldsAction
            ' 
            Me.ChooseTemplateAction.Caption = "Page Template"
            Me.ChooseTemplateAction.ItemType = DevExpress.ExpressApp.Actions.SingleChoiceActionItemType.ItemIsMode
            Me.ChooseTemplateAction.Id = "ChooseTemplateAction"
            Me.ChooseTemplateAction.Category = "RootObjectsCreation"
            'Me.ChooseTemplateAction.Execute += New DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(ChooseTemplateAction_Execute);
            ' 
            ' ClearFieldsController
            ' 
            'Me.Activated += New System.EventHandler(ChooseTemplateController_Activated);
            'Me.Deactivated += New System.EventHandler(ChooseTemplateController_Deactivated);
        End Sub


#End Region

        Private WithEvents ChooseTemplateAction As DevExpress.ExpressApp.Actions.SingleChoiceAction

    End Class
End Namespace
