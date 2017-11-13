Imports System.ComponentModel
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraDiagram.Utils

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class DiagramTutorialControl
        Inherits DiagramTutorialControlBase

        Protected Overrides ReadOnly Property Ribbon() As RibbonControl
            Get
                Return If(containerControl Is Nothing, Nothing, containerControl.Controls.OfType(Of RibbonControl)().FirstOrDefault())
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Diagram.CreateDocking()
            Diagram.CreateRibbon()
        End Sub
    End Class
End Namespace
