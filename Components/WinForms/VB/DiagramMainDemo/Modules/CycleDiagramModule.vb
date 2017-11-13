Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraDiagram.Demos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Diagram.Core

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class CycleDiagramModule
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            LoadDocument("CycleDiagram.xml")
            Diagram.OptionsView.Theme = DiagramThemes.Linear
        End Sub
    End Class
End Namespace
