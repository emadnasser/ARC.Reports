Imports System
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.Xpf.Utils


Namespace RichEditDemo
    Public Class RichEditDemoModule
        Inherits DemoModule

        Public Shared ReadOnly RichEditControlProperty As DependencyProperty

        Shared Sub New()
            RichEditControlProperty = DependencyPropertyManager.Register("RichEditControl", GetType(RichEditControl), GetType(RichEditDemoModule), New FrameworkPropertyMetadata(Nothing))
        End Sub

        Public Property RichEditControl() As RichEditControl
            Get
                Return CType(GetValue(RichEditControlProperty), RichEditControl)
            End Get
            Set(ByVal value As RichEditControl)
                SetValue(RichEditControlProperty, value)
            End Set
        End Property

        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            If RichEditControl IsNot Nothing Then
                RemoveHandler RichEditControl.Loaded, AddressOf OnRichEditControlLoaded
                RichEditControl = Nothing
            End If
            ObtainRichEditControl()
        End Sub

        Private Sub OnRichEditControlLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetFocus(RichEditControl)
        End Sub
        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            ObtainRichEditControl()
            SetFocus(RichEditControl)
        End Sub

        Protected Overrides Function GetModuleDataContext() As Object
            Return FindRichEdit()
        End Function
        Private Sub ObtainRichEditControl()
            If RichEditControl Is Nothing Then
                RichEditControl = FindRichEdit()
            End If
            If RichEditControl IsNot Nothing Then
                AddHandler RichEditControl.Loaded, AddressOf OnRichEditControlLoaded
                CType(New RichEditDemoExceptionsHandler(RichEditControl), RichEditDemoExceptionsHandler).Install()
            End If
        End Sub
        Private Function FindRichEdit() As RichEditControl
            Return CType(DemoModuleControl.FindDemoContent(GetType(RichEditControl), CType(Content, DependencyObject)), RichEditControl)
        End Function
        Protected Friend Overridable Sub SetFocus(ByVal control As RichEditControl)
            If control Is Nothing Then
                Return
            End If
            If control.KeyCodeConverter IsNot Nothing Then
                control.KeyCodeConverter.Focus()
            End If
        End Sub
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If RichEditControl IsNot Nothing Then
                RichEditControl.ShowHoverMenu = Not IsPopupContentInvisible
            End If
        End Sub

        Protected Overrides ReadOnly Property XamlSuffix() As String
            Get
                Return ".xaml"
            End Get
        End Property
    End Class
End Namespace
