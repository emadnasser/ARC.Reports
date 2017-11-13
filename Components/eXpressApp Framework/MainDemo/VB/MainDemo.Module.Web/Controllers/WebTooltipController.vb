Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Web
Imports DevExpress.ExpressApp.Web.Editors.ASPx

Namespace MainDemo.Module.Web.Controllers
    Partial Public Class WebTooltipController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub

        Private Sub WebTooltipController_ViewControlsCreated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ViewControlsCreated
            Dim listEditor As ASPxGridListEditor = TryCast((CType(View, ListView)).Editor, ASPxGridListEditor)
            If listEditor IsNot Nothing Then
                For Each column As GridViewColumn In listEditor.Grid.Columns
                    If (TryCast(column, GridViewDataColumn)) IsNot Nothing Then
                        column.ToolTip = "Click to sort by " & column.Caption
                    End If
                Next column
            End If
        End Sub
    End Class
End Namespace
