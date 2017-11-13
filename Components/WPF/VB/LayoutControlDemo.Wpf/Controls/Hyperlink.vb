Imports System
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Core
Imports System.Diagnostics
Imports System.Windows.Controls
Imports System.Windows.Interop

Namespace DevExpress.Xpf.LayoutControlDemo
    Public Interface IHyperlink
        Inherits IControl

        Property IsActive() As Boolean
        Property NavigateUri() As String
    End Interface

    <TemplateVisualState(Name := "Active", GroupName := "CommonStates"), TemplatePart(Name := Hyperlink.HeaderControlName, Type := GetType(TextBlock))>
    Public Class Hyperlink
        Inherits DXButton
        Implements IHyperlink

        #Region "Dependency Properties"

        Public Shared ReadOnly HeaderProperty As DependencyProperty = DependencyProperty.Register("Header", GetType(String), GetType(Hyperlink), Nothing)
        Public Shared ReadOnly IsActiveProperty As DependencyProperty = DependencyProperty.Register("IsActive", GetType(Boolean), GetType(Hyperlink), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnIsActiveChanged)))
        Public Shared ReadOnly NavigateUriProperty As DependencyProperty = DependencyProperty.Register("NavigateUri", GetType(String), GetType(Hyperlink), New PropertyMetadata(New PropertyChangedCallback(AddressOf OnNavigateUriChanged)))
        Public Shared ReadOnly SubheaderProperty As DependencyProperty = DependencyProperty.Register("Subheader", GetType(String), GetType(Hyperlink), Nothing)
        Public Shared ReadOnly SubheaderForegroundProperty As DependencyProperty = DependencyProperty.Register("SubheaderForeground", GetType(Brush), GetType(Hyperlink), Nothing)

        Private Shared Sub OnIsActiveChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(o, Hyperlink).OnIsActiveChanged()
        End Sub
        Private Shared Sub OnNavigateUriChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(o, Hyperlink).OnNavigateUriChanged()
        End Sub

        #End Region ' Dependency Properties

        Public Sub New()
            DefaultStyleKey = GetType(Hyperlink)
        End Sub

        Public Shadows ReadOnly Property Controller() As HyperlinkController
            Get
                Return CType(MyBase.Controller, HyperlinkController)
            End Get
        End Property
        Public Property Header() As String
            Get
                Return CStr(GetValue(HeaderProperty))
            End Get
            Set(ByVal value As String)
                SetValue(HeaderProperty, value)
            End Set
        End Property
        Public Property IsActive() As Boolean Implements IHyperlink.IsActive
            Get
                Return CBool(GetValue(IsActiveProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsActiveProperty, value)
            End Set
        End Property
        Public Property NavigateUri() As String Implements IHyperlink.NavigateUri
            Get
                Return CStr(GetValue(NavigateUriProperty))
            End Get
            Set(ByVal value As String)
                SetValue(NavigateUriProperty, value)
            End Set
        End Property
        Public Property Subheader() As String
            Get
                Return CStr(GetValue(SubheaderProperty))
            End Get
            Set(ByVal value As String)
                SetValue(SubheaderProperty, value)
            End Set
        End Property
        Public Property SubheaderForeground() As Brush
            Get
                Return CType(GetValue(SubheaderForegroundProperty), Brush)
            End Get
            Set(ByVal value As Brush)
                SetValue(SubheaderForegroundProperty, value)
            End Set
        End Property

        Protected Overrides Function CreateController() As ControlControllerBase
            Return New HyperlinkController(Me)
        End Function

        #Region "Template"

        Friend Const HeaderControlName As String = "HeaderControl"

        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            HeaderControl = TryCast(GetTemplateChild(HeaderControlName), TextBlock)
            UpdateTemplateHyperlink()
        End Sub

        Protected Sub UpdateTemplateHyperlink()
            If (Not BrowserInteropHelper.IsBrowserHosted) OrElse String.IsNullOrEmpty(NavigateUri) OrElse HeaderControl Is Nothing Then
                Return
            End If
            Dim _hyperlink = New System.Windows.Documents.Hyperlink()
            _hyperlink.Inlines.Add(New System.Windows.Documents.Run(HeaderControl.Text))
            _hyperlink.NavigateUri = New Uri(NavigateUri)
            _hyperlink.TargetName = "_blank"
            _hyperlink.Foreground = HeaderControl.Foreground
            _hyperlink.TextDecorations = Nothing
            HeaderControl.Inlines.Clear()
            HeaderControl.Inlines.Add(_hyperlink)
        End Sub

        Private privateHeaderControl As TextBlock
        Protected Property HeaderControl() As TextBlock
            Get
                Return privateHeaderControl
            End Get
            Private Set(ByVal value As TextBlock)
                privateHeaderControl = value
            End Set
        End Property

        #End Region ' Template

        Protected Overridable Sub OnIsActiveChanged()
            Controller.OnIsActiveChanged()
        End Sub
        Protected Overridable Sub OnNavigateUriChanged()
            UpdateTemplateHyperlink()
        End Sub
    End Class

    Public Class HyperlinkController
        Inherits DXButtonController

        Public Sub New(ByVal control As IHyperlink)
            MyBase.New(control)
        End Sub

        Public Overrides Sub UpdateState(ByVal useTransitions As Boolean)
            If IHyperlink.IsActive Then
                VisualStateManager.GoToState(Control, "Active", useTransitions)
            Else
                MyBase.UpdateState(useTransitions)
            End If
        End Sub

        Public ReadOnly Property IHyperlink() As IHyperlink
            Get
                Return TryCast(IControl, IHyperlink)
            End Get
        End Property

        Protected Sub NavigateToUri()
            Process.Start(IHyperlink.NavigateUri)
        End Sub
        Protected Overrides Sub OnClick()
            If String.IsNullOrEmpty(IHyperlink.NavigateUri) Then
                MyBase.OnClick()
            Else
                If Not BrowserInteropHelper.IsBrowserHosted Then
                    NavigateToUri()
                End If
            End If
        End Sub
        Protected Friend Overridable Sub OnIsActiveChanged()
            UpdateState(False)
        End Sub
    End Class
End Namespace
