Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.XtraGrid.Columns
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Editors

Namespace MainDemo.Module.Win.Controllers
    Partial Public Class WinTooltipController
        Inherits ViewController
        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub

        Private Sub WinTooltipController_ViewControlsCreated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ViewControlsCreated
            Dim listEditor As GridListEditor = TryCast((CType(View, ListView)).Editor, GridListEditor)
            If listEditor IsNot Nothing Then
                For Each column As GridColumn In listEditor.GridView.Columns
                    column.ToolTip = "Click to sort by " & column.Caption
                Next column
            End If
        End Sub
    End Class
End Namespace
