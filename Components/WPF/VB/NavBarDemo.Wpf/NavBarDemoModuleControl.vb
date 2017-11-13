Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.NavBar
Imports DevExpress.Xpf.Utils
Imports DevExpress.Xpf.Core


Namespace NavBarDemo
    Public Class NavBarDemoModule
        Inherits DemoModule

        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded
            AddHandler Unloaded, AddressOf OnUnloaded
            OnThemeChanged(Nothing, Nothing)
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AddHandler ThemeManager.ThemeChanged, AddressOf OnThemeChanged

            OnThemeChanged(Nothing, Nothing)
        End Sub
        Private Sub OnUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler ThemeManager.ThemeChanged, AddressOf OnThemeChanged
            OnThemeChanged(Nothing, Nothing)
        End Sub
        Private Sub OnThemeChanged(ByVal sender As DependencyObject, ByVal e As ThemeChangedRoutedEventArgs)
            If Not Dispatcher.CheckAccess() Then
                Return
            End If

            If navBarControl IsNot Nothing Then
                navBarControl.ClearValue(ForegroundProperty)
                navBarControl.SetResourceReference(ForegroundProperty, New DevExpress.Xpf.NavBar.Themes.CommonElementsThemeKeyExtension() With {.ResourceKey = DevExpress.Xpf.NavBar.Themes.CommonElementsThemeKeys.ItemForegroundBrush, .ThemeName = ApplicationThemeHelper.ApplicationThemeName})
            End If
            ItemForegroundOnBackgroundPanel = New System.Windows.Media.SolidColorBrush(If(IsDarkBackgroundTheme(), System.Windows.Media.Colors.White, System.Windows.Media.Colors.Black))
        End Sub

        Public Property ItemForegroundOnBackgroundPanel() As System.Windows.Media.SolidColorBrush
            Get
                Return CType(GetValue(ItemForegroundOnBackgroundPanelProperty), System.Windows.Media.SolidColorBrush)
            End Get
            Set(ByVal value As System.Windows.Media.SolidColorBrush)
                SetValue(ItemForegroundOnBackgroundPanelProperty, value)
            End Set
        End Property


        Public Shared ReadOnly ItemForegroundOnBackgroundPanelProperty As DependencyProperty = DependencyPropertyManager.Register("ItemForegroundOnBackgroundPanel", GetType(System.Windows.Media.SolidColorBrush), GetType(NavBarDemoModule), New FrameworkPropertyMetadata(Nothing))


        Public Shared ReadOnly ItemForegroundProperty As DependencyProperty = DependencyPropertyManager.Register("ItemForeground", GetType(System.Windows.Media.SolidColorBrush), GetType(NavBarDemoModule), New FrameworkPropertyMetadata(Nothing))



        Private Shared Function IsDarkTheme() As Boolean
            Return ApplicationThemeHelper.ApplicationThemeName = "Office2010Black" OrElse ApplicationThemeHelper.ApplicationThemeName = "MetropolisDark" OrElse ApplicationThemeHelper.ApplicationThemeName = "VS2010"
        End Function
        Private Shared Function IsDarkBackgroundTheme() As Boolean
            Return ApplicationThemeHelper.ApplicationThemeName = "MetropolisDark" OrElse ApplicationThemeHelper.ApplicationThemeName = "Office2010Black"
        End Function

        Protected Friend Property navBarControl() As NavBarControl

        Protected Overridable Function GetExplorerBarView() As ExplorerBarView
            Return New ExplorerBarView()
        End Function
        Protected Overridable Function GetNavigationPaneView() As NavigationPaneView
            Return New NavigationPaneView()
        End Function
        Protected Overridable Function GetSideBarView() As SideBarView
            Return New SideBarView()
        End Function
        Protected Overridable Sub SelectView(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If navBarControl Is Nothing Then
                Return
            End If
            Dim name As String = CStr(DirectCast(sender, ListBoxEdit).SelectedItem)
            Select Case name
                Case "Explorer Bar"
                    navBarControl.View = GetExplorerBarView()
                Case "Navigation Pane"
                    navBarControl.View = GetNavigationPaneView()
                Case "Side Bar"
                    navBarControl.View = GetSideBarView()
                Case Else
                    Throw New ArgumentException("Could not find specified view.")
            End Select
        End Sub
    End Class
    Public Class DoubleToTextConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return value.ToString()
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Double.Parse(DirectCast(value, String))
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
    Public Class IntToTextConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return (System.Convert.ToInt32(value)).ToString()
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Int32.Parse(DirectCast(value, String))
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
    Public Class ItemToEnabledConverter
        Inherits MarkupExtension
        Implements IValueConverter

        #Region "IValueConverter Members"

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return value IsNot Nothing
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
    Public Class IntToVisibilityConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return If(DirectCast(value, Integer) > 0, Visibility.Visible, Visibility.Collapsed)
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    Public Class IntToBooleanConverter
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return DirectCast(value, Integer) > 1
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    Public Class BooleanInvertAndMultiValueConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Private Function IMultiValueConverter_Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim value As Boolean = True
            For Each obj In values
                value = value And If(TypeOf obj Is Boolean, (Not CBool(obj)), True)
            Next obj
            Return value
        End Function
        Private Function IMultiValueConverter_ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class

    Public Class WidthsToPaddingConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        #Region "IMultiValueConverter Members"

        Private Function IMultiValueConverter_Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            If Not(TypeOf values(0) Is Double) OrElse Not(TypeOf values(1) Is Double) Then
                Return New Thickness()
            End If
            Dim columnWidth As Double = DirectCast(values(0), Double)
            Dim left As Double = 1 - columnWidth + Math.Floor(columnWidth)
            Dim contentWidth As Double = DirectCast(values(1), Double) - left
            Dim right As Double = contentWidth - Math.Floor(contentWidth)
            Return New Thickness(left, 0, right, 0)
        End Function

        Private Function IMultiValueConverter_ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class

    Public Class NavBarDemoGridControl
        Inherits ContentControl

        #Region "Fields"
        Public Shared ReadOnly StretchProperty As DependencyProperty
        Public Shared ReadOnly ContentMinWidthProperty As DependencyProperty
        Public Shared ReadOnly ContentMaxWidthProperty As DependencyProperty
        #End Region
        Shared Sub New()
            StretchProperty = DependencyProperty.Register("Stretch", GetType(Boolean), GetType(NavBarDemoGridControl), New PropertyMetadata(False))
            ContentMinWidthProperty = DependencyProperty.Register("ContentMinWidth", GetType(Double), GetType(NavBarDemoGridControl), New PropertyMetadata(0R))
            ContentMaxWidthProperty = DependencyProperty.Register("ContentMaxWidth", GetType(Double), GetType(NavBarDemoGridControl), New PropertyMetadata(Double.PositiveInfinity))
        End Sub
        Public Sub New()
            Me.SetDefaultStyleKey(GetType(NavBarDemoGridControl))
        End Sub
        #Region "Properties"
        Public Property Stretch() As Boolean
            Get
                Return DirectCast(GetValue(StretchProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(StretchProperty, value)
            End Set
        End Property
        Public Property ContentMinWidth() As Double
            Get
                Return DirectCast(GetValue(ContentMinWidthProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(ContentMinWidthProperty, value)
            End Set
        End Property
        Public Property ContentMaxWidth() As Double
            Get
                Return DirectCast(GetValue(ContentMaxWidthProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(ContentMaxWidthProperty, value)
            End Set
        End Property
        #End Region
        Public Overrides Sub OnApplyTemplate()
            Dim demoControl As DemoModuleControl = DemoModuleControl.FindParentDemoModuleControl(Me)
            If demoControl Is Nothing Then
                Return
            End If
            Dim navBar As NavBarControl = CType(DemoModuleControl.FindDemoContent(GetType(NavBarControl), DirectCast(Me.Content, DependencyObject)), NavBarControl)
            CType(demoControl.DemoModule, NavBarDemoModule).navBarControl = navBar
            demoControl.DataContext = navBar
        End Sub
    End Class
    Public Class RootDemoTreeViewItem
        Inherits TreeViewItem

        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded
            AddHandler Unloaded, AddressOf OnUnloaded
        End Sub

        Private Sub OnUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateForeground()
        End Sub
        Public Property AlternateForeground() As System.Windows.Media.Brush
            Get
                Return DirectCast(GetValue(AlternateForegroundProperty), System.Windows.Media.Brush)
            End Get
            Set(ByVal value As System.Windows.Media.Brush)
                SetValue(AlternateForegroundProperty, value)
            End Set
        End Property
        Public Shared ReadOnly AlternateForegroundProperty As DependencyProperty = DependencyPropertyManager.Register("AlternateForeground", GetType(System.Windows.Media.Brush), GetType(RootDemoTreeViewItem), New FrameworkPropertyMetadata(New System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black)))
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            UpdateForeground()
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Input.MouseEventArgs)
            MyBase.OnMouseMove(e)
            UpdateForeground()
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As System.Windows.Input.MouseEventArgs)
            MyBase.OnMouseLeave(e)
            UpdateForeground()
        End Sub
        Protected Overrides Sub OnMouseEnter(ByVal e As System.Windows.Input.MouseEventArgs)
            MyBase.OnMouseEnter(e)
            UpdateForeground()
        End Sub
        Private Sub UpdateForeground()
            If (Not IsSelected) AndAlso (Not IsMouseOver) Then
                Foreground = AlternateForeground
            Else
                ClearValue(ForegroundProperty)
            End If
        End Sub
    End Class

    Public Class FreezableGetAsFrozenConverterExtension
        Inherits MarkupExtension
        Implements IValueConverter

        Public Sub New()

        End Sub
        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim fvalue As Freezable = TryCast(value, Freezable)
            If fvalue Is Nothing Then
                Return fvalue
            End If
            Return If(fvalue.CanFreeze, fvalue.Clone(), fvalue.GetAsFrozen())
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function
    End Class
End Namespace
