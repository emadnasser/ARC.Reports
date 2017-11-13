Imports System
Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.Xpf.Core.Native
Imports System.Windows.Controls.Primitives
Imports System.Windows.Markup
Imports System.Windows.Input
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Mvvm

Namespace GridDemo
    <CodeFile("ModuleResources/RoutedEventsHelper.(cs)"), CodeFile("ModuleResources/FixedDataColumnsTemplates(.SL).xaml"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class FixedDataColumns
        Inherits GridDemoModule

        Public Sub New()
            ClosePopupCommand = New DelegateCommand(Of RoutedEventHandlerArgs)(AddressOf ClosePopup)
            DataContext = Me
            InitializeComponent()
        End Sub
        Private Sub ClosePopup(ByVal obj As RoutedEventHandlerArgs)
            RadioButtonList_SelectionChanged(obj.Sender, CType(obj.Args, EditValueChangedEventArgs))
        End Sub
        Private Sub RadioButtonList_SelectionChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Dim popupRoot As FrameworkElement = TryCast(LayoutHelper.FindRoot(DirectCast(sender, DependencyObject)), FrameworkElement)
            If (popupRoot IsNot Nothing) AndAlso (TypeOf popupRoot.Parent Is Popup) Then
                TryCast(popupRoot.Parent, Popup).IsOpen = False
            End If
        End Sub
        Private privateClosePopupCommand As ICommand
        Public Property ClosePopupCommand() As ICommand
            Get
                Return privateClosePopupCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateClosePopupCommand = value
            End Set
        End Property
    End Class
End Namespace
