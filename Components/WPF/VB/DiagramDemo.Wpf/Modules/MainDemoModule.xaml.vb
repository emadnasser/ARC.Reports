Imports System.Windows
Imports DevExpress.Xpf.Diagram
Imports DevExpress.Xpf.Ribbon
Imports DevExpress.Diagram.Core
Imports System.Windows.Data

Namespace DiagramDemo
    Partial Public Class MainDemoModule
        Inherits DiagramDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ShowDiagramDesignerControl(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim diagramControl = New DiagramDesignerControl() With {.UseLayoutRounding = True}
            diagramControl.SelectedStencils = New StencilCollection From { BasicShapes.StencilId, ArrowShapes.StencilId, DecorativeShapes.StencilId }
            diagramControl.PropertiesPanelVisibility = PropertiesPanelVisibility.Visible

            Dim window = CreateWindow()
            window.Content = diagramControl
            diagramControl.AttachToWindow()
            Dim titleBinding = New Binding(DiagramDesignerControl.TitleProperty.Name) With {.Source = diagramControl}
            window.SetBinding(DXRibbonWindow.TitleProperty, titleBinding)
            window.ShowDialog()
        End Sub
        Private Function CreateWindow() As DXRibbonWindow
            Dim window = New DXRibbonWindow()
            Const margin As Double = 15
            window.Width = Application.Current.MainWindow.ActualWidth
            window.Height = Application.Current.MainWindow.ActualHeight - 2 * margin
            window.IsAeroMode = False
            window.WindowState = Application.Current.MainWindow.WindowState
            Dim pos As Point = Application.Current.MainWindow.PointToScreen(New Point())
            window.Left = pos.X
            window.Top = pos.Y + margin
            Return window
        End Function
    End Class
End Namespace
