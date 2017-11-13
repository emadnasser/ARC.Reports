Imports System
Imports System.Collections
Imports System.Data
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Xpf.NavBar
Imports DevExpress.DemoData.Models
Imports System.Collections.Generic
Imports System.Data.Entity
Imports System.Linq

Namespace NavBarDemo
    Partial Public Class LayoutCustomization
        Inherits NavBarDemoModule

        Private context As New CarsContext()
        Public Sub New()
            InitializeComponent()
            navBar.ItemsSource = context.Cars.ToList()
            itemsPanelListBox.SelectedIndex = 0
        End Sub

        Private Sub UpdateControlAvailability()
            If Not IsInitialized Then
                Return
            End If
            verticalPanelAlignment.IsEnabled = Not(TypeOf navBar.View Is ExplorerBarView)

            If orientationComboBox.SelectedItem IsNot Nothing Then
                Dim orientation As Orientation = CType(orientationComboBox.SelectedItem, Orientation)
                horizontalPanelAlignment.IsEnabled = Not(orientation = System.Windows.Controls.Orientation.Horizontal AndAlso TypeOf navBar.View Is ExplorerBarView)
                verticalPanelAlignment.IsEnabled = Not(orientation = System.Windows.Controls.Orientation.Vertical AndAlso TypeOf navBar.View Is ExplorerBarView)
            End If

            If itemsPanelListBox.SelectedItem IsNot Nothing Then
                Dim isCarouselPanel As Boolean = CStr(itemsPanelListBox.SelectedItem) = "Carousel Panel"
                panelOrientation.IsEnabled = Not isCarouselPanel
                alignmentGroupBox.IsEnabled = Not isCarouselPanel
                displayModeGroupBox.IsEnabled = Not isCarouselPanel
            End If

            textAlignment.IsEnabled = displayModeComboBox.SelectedIndex <> 1
            imageAlignment.IsEnabled = displayModeComboBox.SelectedIndex = 1 OrElse (displayModeComboBox.SelectedIndex = 0 AndAlso (imageDocking.SelectedIndex = 2 OrElse imageDocking.SelectedIndex = 3))
        End Sub

        Protected Overrides Sub SelectView(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If navBarControl Is Nothing Then
                Return
            End If
            MyBase.SelectView(sender, e)
            If TypeOf navBar.View Is ExplorerBarView Then
                itemsPanelListBox.ItemsSource = DirectCast(FindResource("ItemsPanel"), IEnumerable)
                If itemsPanelListBox.SelectedIndex = -1 Then
                    itemsPanelListBox.SelectedIndex = 0
                End If
            Else
                itemsPanelListBox.ItemsSource = DirectCast(FindResource("ItemsPanelExplorerBar"), IEnumerable)
            End If
            ChangePanel()
            UpdateControlAvailability()
        End Sub

        Private Sub OrientationChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangeOrientation()
        End Sub
        Private Sub ChangeOrientation()
            Dim orientation As Orientation = CType(orientationComboBox.SelectedItem, Orientation)
            navBar.HorizontalAlignment = If(orientation = System.Windows.Controls.Orientation.Horizontal, HorizontalAlignment.Stretch, HorizontalAlignment.Left)
            navBar.VerticalAlignment = If(orientation = System.Windows.Controls.Orientation.Vertical, VerticalAlignment.Stretch, VerticalAlignment.Top)
            UpdateControlAvailability()
        End Sub
        Private Sub itemsPanelListBox_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ChangePanel()
        End Sub

        Private Sub ChangePanel()
            Dim panelTemplate As ItemsPanelTemplate
            Select Case CStr(itemsPanelListBox.SelectedItem)
                Case "Stack Panel"
                    panelTemplate = CType(FindResource("stackPanel"), ItemsPanelTemplate)
                    displayModeComboBox.SelectedIndex = 0
                Case "Wrap Panel"
                    panelTemplate = CType(FindResource("wrapPanel"), ItemsPanelTemplate)
                    displayModeComboBox.SelectedIndex = 0
                Case "Carousel Panel"
                    panelTemplate = CType(FindResource("carouselPanel"), ItemsPanelTemplate)
                    displayModeComboBox.SelectedIndex = 1
                Case Else
                    Throw New ArgumentException("Could not find specified panel.")
            End Select
            UpdateItemVisualStyle()
            navBar.View.ItemsPanelTemplate = panelTemplate
            UpdateControlAvailability()
        End Sub

        Private Sub displayMode_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateControlAvailability()
        End Sub
        Private Sub itemImageDocking_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateControlAvailability()
        End Sub
        Protected Overridable Sub UpdateItemVisualStyle()
            If CStr(itemsPanelListBox.SelectedItem) = "Carousel Panel" Then
                navBar.View.ItemVisualStyle = CType(FindResource("carouselItemVisualStyle"), Style)
                Return
            End If
            Dim alignment As HorizontalAlignment = CType(imageAlignment.SelectedItem, HorizontalAlignment)
            If alignment = System.Windows.HorizontalAlignment.Stretch Then
                navBar.View.ItemVisualStyle = CType(FindResource("itemVisualStyle"), Style)
            Else
                navBar.View.ItemVisualStyle = CType(FindResource("nonStretchImageItemVisualStyle"), Style)
            End If
        End Sub
        Private Sub imageAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateItemVisualStyle()
        End Sub
    End Class
    Public Class DoubleToIntConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
        #Region "IValueConverter Members"
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return CInt((DirectCast(value, Double)))
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    Public Class StringToDisplayModeConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
        #Region "IValueConverter Members"
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Select Case DirectCast(value, String)
                Case "Image and Text"
                    Return DisplayMode.ImageAndText
                Case "Image"
                    Return DisplayMode.Image
                Case Else
                    Return DisplayMode.Text
            End Select
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
    Public Class SelectedItemsToLayoutSettingsConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            For Each obj As Object In values
                If obj Is DependencyProperty.UnsetValue Then
                    Return New LayoutSettings()
                End If
            Next obj
            Return New LayoutSettings() With {.TextHorizontalAlignment = DirectCast(values(0), HorizontalAlignment), .ImageHorizontalAlignment = DirectCast(values(1), HorizontalAlignment), .ImageDocking = DirectCast(values(2), Dock)}
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
    Public Class VisibleItemCountToActiveElementIndexConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
        #Region "IValueConverter Members"
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            If targetType IsNot GetType(Integer) Then
                Throw New InvalidOperationException()
            End If
            Return (((DirectCast(value, Integer)) - 1) \ 2)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region
    End Class
End Namespace
