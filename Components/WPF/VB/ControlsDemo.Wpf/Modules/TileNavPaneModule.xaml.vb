Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.WindowsUI
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Interop
Imports DevExpress.Mvvm
Namespace ControlsDemo
    <CodeFile("ViewModels/TileNavBaseViewModel.(cs)"), CodeFile("ViewModels/TileNavPaneViewModel.(cs)"), CodeFile("Modules/Views/TileNavDetailsView.xaml"), CodeFile("Modules/Views/TileNavDetailsView.xaml.(cs)"), CodeFile("Modules/Views/TileNavPaneHomeView.xaml"), CodeFile("Modules/Views/TileNavPaneHomeView.xaml.(cs)")>
    Partial Public Class TileNavPaneModule
        Inherits ControlsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If Object.Equals(e.NewValue, True) Then
                tileNavPane.CloseFlyout()
            End If
        End Sub
    End Class
End Namespace
