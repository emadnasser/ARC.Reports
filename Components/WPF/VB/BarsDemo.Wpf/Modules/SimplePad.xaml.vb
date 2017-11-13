Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports System.Windows
Namespace BarsDemo
    <CodeFiles("Modules/SimplePad(.SL).xaml", "Modules/SimplePad.xaml.(cs)", "ViewModels/SimplePadViewModel.(cs)")>
    Partial Public Class SimplePad
        Inherits BarsDemoModule

        Public Sub New()
            InitializeComponent()
            AddHandler ModuleAppear, AddressOf OnModuleAppear
        End Sub

        Private Sub OnModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Not Me.IsInDesignTool() Then
                richControl.SetFocus()
            End If
        End Sub
    End Class
End Namespace
