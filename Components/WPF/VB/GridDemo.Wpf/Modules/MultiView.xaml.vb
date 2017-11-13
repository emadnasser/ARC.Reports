Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Threading
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    <CodeFile("ModuleResources/MultiViewTemplates(.SL).xaml"), CodeFile("ModuleResources/MultiViewViewTemplates(.SL).xaml"), CodeFile("ModuleResources/SharedResources(.SL).xaml"), CodeFile("ModuleResources/MultiViewClasses.(cs)"), CodeFile("ModuleResources/MultiViewViewModel.(cs)"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class MultiView
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            AddHandler BeforeModuleDisappear, AddressOf MultiView_BeforeModuleDisappear
        End Sub

        Private Sub MultiView_BeforeModuleDisappear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            multiViewListBox.Items.Clear()
        End Sub
    End Class
End Namespace
