Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Controllers
    Partial Public Class FindBySubjectController
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
            Me.FindBySubjectAction = New DevExpress.ExpressApp.Actions.ParametrizedAction(Me.components)
            ' 
            ' FindBySubjectAction
            ' 
            Me.FindBySubjectAction.Caption = "Find Task by Subject"
            Me.FindBySubjectAction.Id = "FindBySubjectAction"
            Me.FindBySubjectAction.ImageName = "Action_Search_Object_FindObjectByID"
            Me.FindBySubjectAction.Category = "View"
            Me.FindBySubjectAction.NullValuePrompt = "Type subject..."

            '			Me.FindBySubjectAction.Execute += New DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(FindBySubjectAction_Execute);
            ' 
            ' FindBySubjectController
            ' 
            Me.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
            '			Me.Activated += New System.EventHandler(FindBySubjectController_Activated);

        End Sub

#End Region
        Private WithEvents FindBySubjectAction As DevExpress.ExpressApp.Actions.ParametrizedAction
    End Class
End Namespace
