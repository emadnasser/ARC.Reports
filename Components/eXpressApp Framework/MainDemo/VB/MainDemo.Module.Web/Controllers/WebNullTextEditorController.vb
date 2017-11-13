Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.DC
Imports System.Web
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Editors
Imports DevExpress.Web

Namespace MainDemo.Module.Controllers
    Partial Public Class WebNullTextEditorController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub

        Private Sub InitNullText(ByVal propertyEditor As WebPropertyEditor)
            If propertyEditor.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit Then
                CType(propertyEditor.Editor, ASPxDateEdit).NullText = "N/A"
            End If
        End Sub
        Private Sub WebNullTextEditorController_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ViewControlsCreated
            Dim propertyEditor As WebPropertyEditor = TryCast((CType(View, DetailView)).FindItem("Anniversary"), WebPropertyEditor)
            If propertyEditor IsNot Nothing Then
                If propertyEditor.Control IsNot Nothing Then
                    InitNullText(propertyEditor)
                Else
                    AddHandler propertyEditor.ControlCreated, AddressOf propertyEditor_ControlCreated
                End If
            End If
        End Sub
        Private Sub propertyEditor_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            InitNullText(CType(sender, WebPropertyEditor))
        End Sub
    End Class
End Namespace
