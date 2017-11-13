Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.NavBar
Imports System.Windows.Media
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Utils

Namespace NavBarDemo
    Partial Public Class CustomTheming
        Inherits NavBarDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    Public Class SlideNavBarGroup
        Inherits NavBarGroup

        Public Shared ReadOnly ItemVisibleIndexProperty As DependencyProperty
        Public Shared ReadOnly BackgroundProperty As DependencyProperty
        Public Shared ReadOnly RadioButtonStyleProperty As DependencyProperty

        Shared Sub New()
            BackgroundProperty = DependencyProperty.Register("Background", GetType(Brush), GetType(SlideNavBarGroup), New PropertyMetadata(New SolidColorBrush(Colors.Transparent)))
            ItemVisibleIndexProperty = DependencyProperty.Register("ItemVisibleIndex", GetType(Integer), GetType(SlideNavBarGroup), New PropertyMetadata(0))
            RadioButtonStyleProperty = DependencyProperty.Register("RadioButtonStyle", GetType(Style), GetType(SlideNavBarGroup), New PropertyMetadata(Nothing))
        End Sub
        Public Property Background() As Brush
            Get
                Return CType(GetValue(BackgroundProperty), Brush)
            End Get
            Set(ByVal value As Brush)
                SetValue(BackgroundProperty, value)
            End Set
        End Property
        Public Property ItemVisibleIndex() As Integer
            Get
                Return CInt((GetValue(ItemVisibleIndexProperty)))
            End Get
            Set(ByVal value As Integer)
                SetValue(ItemVisibleIndexProperty, value)
            End Set
        End Property
        Public Property RadioButtonStyle() As Style
            Get
                Return CType(GetValue(RadioButtonStyleProperty), Style)
            End Get
            Set(ByVal value As Style)
                SetValue(RadioButtonStyleProperty, value)
            End Set
        End Property
    End Class
    Public Class PageSmoothScroller
        Inherits NavBarSmoothScroller

        #Region "static"
        Public Shared ReadOnly ItemVisibleIndexProperty As DependencyProperty

        Shared Sub New()
            ItemVisibleIndexProperty = DependencyProperty.Register("ItemVisibleIndex", GetType(Integer), GetType(PageSmoothScroller), New PropertyMetadata(2, New PropertyChangedCallback(AddressOf OnCurrentVisibleItemPropertyChanged)))
        End Sub
        Protected Shared Sub OnCurrentVisibleItemPropertyChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, PageSmoothScroller).OnCurrentVisibleItemChanged()
        End Sub
        #End Region
        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetBinding(ItemVisibleIndexProperty, New Binding("ItemVisibleIndex") With {.Mode = BindingMode.TwoWay})
        End Sub
        Public Property ItemVisibleIndex() As Integer
            Get
                Return CInt((GetValue(ItemVisibleIndexProperty)))
            End Get
            Set(ByVal value As Integer)
                SetValue(ItemVisibleIndexProperty, value)
            End Set
        End Property
        Protected Friend ReadOnly Property NextChildOffset() As Double
            Get
                Dim height As Double = 0
                Dim itemsPanel As StackPanel = CType(GetItemsPanel(Me), StackPanel)
                If itemsPanel Is Nothing Then
                    Return height
                End If
                If ItemVisibleIndex = itemsPanel.Children.Count - 1 Then
                    Return ContentHeight - CType(itemsPanel.Children(ItemVisibleIndex), FrameworkElement).ActualHeight + 15
                End If
                For i As Integer = 0 To ItemVisibleIndex - 1
                    height += CType(itemsPanel.Children(i), FrameworkElement).ActualHeight
                Next i
                Return height
            End Get
        End Property
        Protected Overrides Sub OnMouseWheel(ByVal e As System.Windows.Input.MouseWheelEventArgs)
        End Sub
        Protected Overrides Sub PerformScrollDownCommand()
            Dim visibleIndex As Integer = ItemVisibleIndex + 1
            If ActualHeight * visibleIndex > ContentHeight Then
                Return
            End If
            ItemVisibleIndex += 1
        End Sub
        Protected Overrides Sub PerformScrollUpCommand()
            Dim visibleIndex As Integer = ItemVisibleIndex - 1
            If visibleIndex < 0 Then
                Return
            End If
            ItemVisibleIndex -= 1
        End Sub
        Protected Friend Sub OnCurrentVisibleItemChanged()
            StartAnimation()
        End Sub
        Private Function GetItemsPanel(ByVal reference As DependencyObject) As FrameworkElement
            Dim childrenCount As Integer = VisualTreeHelper.GetChildrenCount(reference)
            If childrenCount > 0 Then
                Dim child As FrameworkElement = CType(VisualTreeHelper.GetChild(reference, 0), FrameworkElement)
                If child.Name = "itemsPanel" Then
                    Return child
                Else
                    Return GetItemsPanel(child)
                End If
            End If
            Return Nothing
        End Function
        Private Sub StartAnimation()
            Dim storyBoard As New Storyboard()
            Storyboard.SetTargetProperty(storyBoard, New PropertyPath(ChildOffsetProperty))
            Dim scrollAnimation As New DoubleAnimation()

            scrollAnimation.From = ChildOffset
            scrollAnimation.To = NextChildOffset
            scrollAnimation.Duration = New Duration(TimeSpan.FromMilliseconds(500))

            Dim opacityAnimation As New DoubleAnimationUsingKeyFrames()
            opacityAnimation.KeyFrames.Add(New EasingDoubleKeyFrame() With {.KeyTime = KeyTime.FromTimeSpan(New TimeSpan(0, 0, 0, 0, 200)), .Value = 0.5})
            opacityAnimation.KeyFrames.Add(New EasingDoubleKeyFrame() With {.KeyTime = KeyTime.FromTimeSpan(New TimeSpan(0, 0, 0, 0, 500)), .Value = 0.5})
            opacityAnimation.KeyFrames.Add(New EasingDoubleKeyFrame() With {.KeyTime = KeyTime.FromTimeSpan(New TimeSpan(0, 0, 0, 0, 600)), .Value = 1})
            Storyboard.SetTargetProperty(opacityAnimation, New PropertyPath(UIElement.OpacityProperty))
            Storyboard.SetTarget(opacityAnimation, Child)

            storyBoard.Children.Add(scrollAnimation)
            storyBoard.Children.Add(opacityAnimation)
            storyBoard.Begin(Me, True)
        End Sub
    End Class
    Public Class RadioButtonsPanel
        Inherits StackPanel

        Public Shared ReadOnly RadioButtonStyleProperty As DependencyProperty
        Public Shared ReadOnly SelectedItemIndexProperty As DependencyProperty

        Shared Sub New()
            RadioButtonStyleProperty = DependencyProperty.Register("RadioButtonStyle", GetType(Style), GetType(RadioButtonsPanel), New PropertyMetadata(Nothing))
            SelectedItemIndexProperty = DependencyProperty.Register("SelectedItemIndex", GetType(Integer), GetType(RadioButtonsPanel), New PropertyMetadata(0, New PropertyChangedCallback(AddressOf OnSelectedItemIndexPropertyChanged)))
        End Sub

        Public Sub New()
            AddHandler Loaded, AddressOf OnLoaded
        End Sub

        Public Property RadioButtonStyle() As Style
            Get
                Return DirectCast(GetValue(RadioButtonStyleProperty), Style)
            End Get
            Set(ByVal value As Style)
                SetValue(RadioButtonStyleProperty, value)
            End Set
        End Property
        Public Property SelectedItemIndex() As Integer
            Get
                Return DirectCast(GetValue(SelectedItemIndexProperty), Integer)
            End Get
            Set(ByVal value As Integer)
                SetValue(SelectedItemIndexProperty, value)
            End Set
        End Property

        Public Shared Sub OnSelectedItemIndexPropertyChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, RadioButtonsPanel).UpdateSelectedItemIndex()
        End Sub
        Private Sub GenerateContent()
            If DataContext Is Nothing OrElse Children.Count = DirectCast(DataContext, NavBarGroup).Items.Count Then
                Return
            End If
            Dim itemsCount As Integer = DirectCast(DataContext, NavBarGroup).Items.Count
            For i As Integer = itemsCount - 1 To 0 Step -1
                Dim rb As New RadioButton() With {.Style = RadioButtonStyle, .Content = i}
                If i = 0 Then
                    rb.Margin = New Thickness(2, 2, 4, 2)
                End If
                If i = itemsCount - 1 Then
                    rb.Margin = New Thickness(4, 2, 2, 2)
                End If
                AddHandler rb.Click, AddressOf OnRadioButtonClick
                Children.Add(rb)
            Next i
        End Sub
        Private Overloads Sub OnInitialized()
            SetBinding(SelectedItemIndexProperty, New Binding("ItemVisibleIndex"))
            GenerateContent()
            UpdateSelectedItemIndex()
        End Sub
        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            OnInitialized()
        End Sub
        Private Sub OnRadioButtonClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim rb As RadioButton = DirectCast(sender, RadioButton)
            If rb.IsChecked.HasValue AndAlso rb.IsChecked.Value Then
                DirectCast(DataContext, SlideNavBarGroup).ItemVisibleIndex = Int32.Parse((rb).Content.ToString())
            End If

        End Sub
        Private Sub UpdateSelectedItemIndex()
            If SelectedItemIndex >= Children.Count Then
                Return
            End If
            CType(Children(Children.Count - SelectedItemIndex - 1), RadioButton).IsChecked = True
        End Sub
    End Class

    Public Class ItemContent
        Inherits BindableBase

        Public Sub New()
            Description = String.Empty
            Header = String.Empty
        End Sub
        Public Property Description() As String
            Get
                Return GetProperty(Function() Description)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Description, value)
            End Set
        End Property
        Public Property Header() As String
            Get
                Return GetProperty(Function() Header)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Header, value)
            End Set
        End Property
        Public Property ImageSource() As ImageSource
            Get
                Return GetProperty(Function() ImageSource)
            End Get
            Set(ByVal value As ImageSource)
                SetProperty(Function() ImageSource, value)
            End Set
        End Property
        Public Property ImageHeight() As Double
    End Class

    Public Class HeaderContent
        Inherits BindableBase

        Public Property ImageSource() As ImageSource
            Get
                Return GetProperty(Function() ImageSource)
            End Get
            Set(ByVal value As ImageSource)
                SetProperty(Function() ImageSource, value)
            End Set
        End Property
    End Class
End Namespace
