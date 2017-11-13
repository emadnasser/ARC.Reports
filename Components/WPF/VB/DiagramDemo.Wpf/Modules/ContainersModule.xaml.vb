Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace DiagramDemo
    Partial Public Class ContainersModule
        Inherits DiagramDemoModule

        Public Sub New()
            InitializeComponent()
            diagramControl.LoadDemoData("Containers.xml")
            AddHandler diagramControl.Loaded, Sub(o, e) diagramControl.AlignCanvas(HorizontalAlignment.Center, VerticalAlignment.Top)
        End Sub
    End Class
End Namespace
