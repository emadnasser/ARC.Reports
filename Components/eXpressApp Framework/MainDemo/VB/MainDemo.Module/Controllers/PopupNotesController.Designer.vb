Imports Microsoft.VisualBasic
Imports System
Namespace MainDemo.Module.Controllers
    Partial Public Class PopupNotesController
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
            Me.ShowNotesAction = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
            ' 
            ' ShowNotesAction
            ' 
            Me.ShowNotesAction.Caption = "Show Notes"
            Me.ShowNotesAction.Category = DevExpress.Persistent.Base.PredefinedCategory.Edit.ToString()
            Me.ShowNotesAction.Id = "ShowNotesAction"
            Me.ShowNotesAction.ImageName = "BO_Note"
            '			Me.ShowNotesAction.Execute += New DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(Me.ShowNotesAction_Execute);
            '			Me.ShowNotesAction.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.ShowNotesAction_CustomizePopupWindowParams);
            ' 
            ' PopupNotesController
            ' 
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView
            '			Me.Activated += New System.EventHandler(Me.PopupNotesController_Activated);

        End Sub

        Private WithEvents ShowNotesAction As DevExpress.ExpressApp.Actions.PopupWindowShowAction
#End Region

    End Class
End Namespace
