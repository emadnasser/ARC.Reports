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
Imports DevExpress.Utils

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class ContainersModule
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
            diagramControl.OptionsView.PropertiesPanelVisibility = PropertiesPanelVisibility.Collapsed
            LoadDocument("Containers.xml")
            AddHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
        End Sub
        Private Sub OnSizeChangedHandler(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagramControl = DirectCast(sender, DiagramControl)
            RemoveHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
            diagramControl.FitToWidth()
            diagramControl.AlignCanvas(HorzAlignment.Center, VertAlignment.Top)
        End Sub
    End Class
End Namespace
