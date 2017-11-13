Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Windows.Threading
Imports System.Threading
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports System.Windows.Markup
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.Collections
Imports DevExpress.Xpf.Utils


Namespace GridDemo
    <ContentProperty("Storyboard")>
    Public Class StoryboardContainer
        Inherits Control

        Public Shared Function CreateStoryboard(ByVal resourceHolder As Control, ByVal resourceName As String) As Storyboard
            Dim c As New ContentControl() With {.Template = DirectCast(resourceHolder.Resources(resourceName), ControlTemplate)}
            c.ApplyTemplate()
            Dim container As StoryboardContainer = CType(VisualTreeHelper.GetChild(c, 0), StoryboardContainer)
            Return container.Storyboard
        End Function
        Public Property Storyboard() As Storyboard
    End Class
End Namespace
