Imports System

Namespace DockingDemo
    Partial Public Class BarsIntegration
        Inherits DockingDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            InvalidateVisual()
        End Sub
    End Class
End Namespace
