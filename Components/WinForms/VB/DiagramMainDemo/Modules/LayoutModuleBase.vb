Imports System
Imports DevExpress.Diagram.Core
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class LayoutModuleBase
        Inherits DiagramTutorialControl

        Protected Property IsLoaded() As Boolean

        Public Sub New()
            InitializeComponent()
            AddHandler diagramControl.RelayoutItemsCompleted, Sub(_o, _e) Diagram.FitToPage()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            IsLoaded = True
            RelayoutDiagram()
        End Sub
        Protected Sub RelayoutDiagram()
            If Diagram Is Nothing OrElse (Not IsLoaded) Then
                Return
            End If

            RelayoutDiagramCore()
        End Sub
        Protected Overridable Sub RelayoutDiagramCore()
        End Sub
    End Class
End Namespace
