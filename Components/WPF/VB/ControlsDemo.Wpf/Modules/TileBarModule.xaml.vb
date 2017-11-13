Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.WindowsUI
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Interop
Imports System.Windows.Controls
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Navigation
Namespace ControlsDemo
    <CodeFile("ViewModels/TileNavBaseViewModel.(cs)"), CodeFile("ViewModels/TileBarViewModel.(cs)"), CodeFile("Modules/Views/TileNavDetailsView.xaml"), CodeFile("Modules/Views/TileNavDetailsView.xaml.(cs)"), CodeFile("Modules/Views/TileBarHomeView.xaml"), CodeFile("Modules/Views/TileBarHomeView.xaml.(cs)"), CodeFile("Services/TileBarService.(cs)")>
    Partial Public Class TileBarModule
        Inherits ControlsDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If Object.Equals(e.NewValue, True) Then
                tileBar.CloseFlyout()
            End If
        End Sub
    End Class
End Namespace
