Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Timers
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports System.Windows.Media
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Editors

Namespace DockingDemo
    Partial Public Class PanelAnimation
        Inherits DockingDemoModule

        #Region "static"
        Public Shared ReadOnly TileLayoutProperty As DependencyProperty
        Private Shared Duration As New TimeSpan(0, 0, 0, 0, 500)
        Private Shared ZeroLength As New GridLength(0, GridUnitType.Star)
        Shared Sub New()
            TileLayoutProperty = DependencyProperty.Register("TileLayout", GetType(TileLayout), GetType(PanelAnimation), New PropertyMetadata(TileLayout.Default, AddressOf OnTileLayoutChanged))
        End Sub
        Private Shared Sub OnTileLayoutChanged(ByVal dObj As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(dObj, PanelAnimation).OnTileLayoutChanged(DirectCast(e.NewValue, TileLayout))
        End Sub
        #End Region ' static
        Private isExpanded As Boolean
        Private ReadOnly widths As IDictionary(Of BaseLayoutItem, GridLength)
        Private ReadOnly heights As IDictionary(Of BaseLayoutItem, GridLength)
        Private DataTimer As Timer
        Private animationLock As Integer = 0
        Private ReadOnly panelContentList As New List(Of PanelContentControl)()
        Private ReadOnly indicies() As String = { "DJA", "IIX", "NASD", "NIKKEY", "NYA", "RUA", "SPX", "SOXX", "XAX" }
        Public Sub New()
            InitializeComponent()
            widths = New Dictionary(Of BaseLayoutItem, GridLength)()
            heights = New Dictionary(Of BaseLayoutItem, GridLength)()
            AddHandler dockManager.Loaded, AddressOf ManagerLoaded
            AddHandler dockManager.Unloaded, AddressOf ManagerUnloaded
        End Sub
        Protected Overrides Sub RaiseAfterModuleDisappear()
            MyBase.RaiseAfterModuleDisappear()
            If DataTimer IsNot Nothing Then
                DataTimer.Dispose()
                DataTimer = Nothing
            End If
        End Sub
        Public Property TileLayout() As TileLayout
            Get
                Return CType(GetValue(TileLayoutProperty), TileLayout)
            End Get
            Set(ByVal value As TileLayout)
                SetValue(TileLayoutProperty, value)
            End Set
        End Property
        Private Sub ManagerUnloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If DataTimer IsNot Nothing Then
                DataTimer.Stop()
            End If
        End Sub
        Private Sub ManagerLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            SetBinding(TileLayoutProperty, New Binding("SelectedItem.Id") With {.Source = tileLayoutListBox})
            SetupTimer()
        End Sub
        Private Sub SetupTimer()
            If DataTimer Is Nothing Then
                DataTimer = New Timer()
            End If
            DataTimer.Interval = 1000
            AddHandler DataTimer.Elapsed, AddressOf ChangeIndexes
            DataTimer.Start()
        End Sub
        Private Sub OnTileLayoutChanged(ByVal value As TileLayout)
            rootGroup.Clear()
            Dim rowCount As Integer = TileLayoutExtension.GetRowCount(value)
            Dim columnCount As Integer = TileLayoutExtension.GetColumnsCount(value)
            Dim rows(rowCount - 1) As BaseLayoutItem
            panelContentList.Clear()
            For i As Integer = 0 To rowCount - 1
                rows(i) = CreateRow(i, columnCount)
            Next i
            rootGroup.AddRange(rows)
            dockManager.Update()
        End Sub
        Private Function CreateRow(ByVal row As Integer, ByVal itemsCount As Integer) As LayoutGroup
            Dim group As New LayoutGroup() With {.AllowSplitters = False}
            Dim items(itemsCount - 1) As BaseLayoutItem
            For i As Integer = 0 To itemsCount - 1
                items(i) = CreateItem(row * itemsCount + i)
            Next i
            group.AddRange(items)
            Return group
        End Function
        Private Function CreateItem(ByVal index As Integer) As LayoutPanel
            Dim panel As New LayoutPanel()
            Dim random As New Random(Date.Now.Millisecond)

            Dim panelContentControl_Renamed As New PanelContentControl() With {.IndexName = indicies(index), .CurrentValue = random.Next(400, 1000), .CurrentChange = Math.Round(random.NextDouble() - 0.5, 3)}
            For i As Integer = 0 To 6
                panelContentControl_Renamed.Data.Add(New Point(i, random.Next(0, 300)))
            Next i
            AddHandler panelContentControl_Renamed.MouseLeftButtonDown, AddressOf OnPanelContentControlMouseLeftButtonDown
            AddHandler panelContentControl_Renamed.BackButtonClicked, AddressOf panelContentControlBackButtonClicked
            panelContentList.Add(panelContentControl_Renamed)
            panel.Content = panelContentControl_Renamed
            Return panel
        End Function
        Private Sub DoExpand(ByVal clickItem As BaseLayoutItem)
            If clickItem IsNot Nothing Then
                tileLayoutListBox.IsEnabled = isExpanded
                Dim itemsToAnimate = GetItemsToAnimate(clickItem)
                For Each item As BaseLayoutItem In itemsToAnimate
                    If item IsNot clickItem AndAlso item IsNot clickItem.Parent Then
                        Animate(item, isExpanded)
                    End If
                Next item
                isExpanded = Not isExpanded
            End If
        End Sub
        Private Function GetItemsToAnimate(ByVal target As BaseLayoutItem) As IEnumerable(Of BaseLayoutItem)
            Dim animationGroup As LayoutGroup = target.Parent
            Return From item In dockManager.GetItems()
                   Where (item IsNot target AndAlso item IsNot animationGroup) AndAlso (Object.Equals(item.Parent, animationGroup) OrElse Object.Equals(item.Parent, animationGroup.Parent))
                   Select item
        End Function
        Private Sub Animate(ByVal layoutItem As BaseLayoutItem, ByVal expanded As Boolean)
            Dim w As GridLength = layoutItem.ItemWidth
            Dim h As GridLength = layoutItem.ItemHeight
            If Not expanded Then
                widths(layoutItem) = w
                heights(layoutItem) = h
            Else
                w = widths(layoutItem)
                h = heights(layoutItem)
            End If
            animationLock += 2
            layoutItem.BeginWidthAnimation(If(expanded, ZeroLength, w),If(expanded, w, ZeroLength), Duration, AddressOf AnimationCompleted)
            layoutItem.BeginHeightAnimation(If(expanded, ZeroLength, h),If(expanded, h, ZeroLength), Duration, AddressOf AnimationCompleted)
        End Sub
        Private Sub AnimationCompleted(ByVal sender As Object, ByVal e As EventArgs)
            animationLock -= 1
        End Sub
        Private Sub ChangeIndexes(ByVal sender As Object, ByVal e As ElapsedEventArgs)
            Dispatcher.BeginInvoke(New Action(AddressOf UpdateIndexes), System.Windows.Threading.DispatcherPriority.Loaded)
        End Sub
        Private Sub UpdateIndexes()
            Dim random As New Random(Date.Now.Millisecond)
            For Each p As PanelContentControl In panelContentList
                p.CurrentValue += Math.Round(random.NextDouble() - 0.5, 3)
                For i As Integer = 0 To 5
                    p.Data(i) = New Point(i, p.Data(i + 1).Y)
                Next i
                p.Data(6) = New Point(6, random.Next(0, 300))
            Next p
        End Sub
        Private Sub panelContentControlBackButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
            If animationLock > 0 Then
                Return
            End If
            Dim pcc As PanelContentControl = DirectCast(sender, PanelContentControl)
            DoExpand(DockLayoutManager.GetLayoutItem(pcc))
            pcc.IsExpanded = Not pcc.IsExpanded
        End Sub
        Private Sub OnPanelContentControlMouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            If animationLock > 0 Then
                Return
            End If
            Dim pcc As PanelContentControl = DirectCast(sender, PanelContentControl)
            If Not pcc.IsExpanded Then
                DoExpand(DockLayoutManager.GetLayoutItem(pcc))
                pcc.IsExpanded = Not pcc.IsExpanded
            End If
        End Sub
    End Class
    Public Class PanelContentControl
        Inherits ContentControl

        #Region "static"
        Public Shared ReadOnly IndexNameProperty As DependencyProperty
        Public Shared ReadOnly CurrentChangeProperty As DependencyProperty
        Public Shared ReadOnly CurrentValueProperty As DependencyProperty
        Public Shared ReadOnly IsChangePositiveProperty As DependencyProperty
        Public Shared ReadOnly IsExpandedProperty As DependencyProperty
        Public Shared ReadOnly DataProperty As DependencyProperty
        Shared Sub New()
            IndexNameProperty = DependencyProperty.Register("IndexName", GetType(String), GetType(PanelContentControl))
            CurrentChangeProperty = DependencyProperty.Register("CurrentChange", GetType(Double), GetType(PanelContentControl), New PropertyMetadata(0.0, AddressOf OnCurrentChangeChanged))
            CurrentValueProperty = DependencyProperty.Register("CurrentValue", GetType(Double), GetType(PanelContentControl), New PropertyMetadata(0.0, AddressOf OnCurrentValueChanged))
            IsChangePositiveProperty = DependencyProperty.Register("IsChangePositive", GetType(Boolean?), GetType(PanelContentControl), New PropertyMetadata(Nothing, AddressOf OnIsChangePositiveChanged))
            IsExpandedProperty = DependencyProperty.Register("IsExpanded", GetType(Boolean), GetType(PanelContentControl), New PropertyMetadata(False, AddressOf OnIsExpandedChanged))
            DataProperty = DependencyProperty.Register("Data", GetType(ObservableCollection(Of Point)), GetType(PanelContentControl))
        End Sub
        Private Shared Sub OnCurrentValueChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)

            Dim panelContentControl_Renamed As PanelContentControl = CType(d, PanelContentControl)
            panelContentControl_Renamed.CurrentChange = Math.Round(DirectCast(e.NewValue, Double) - DirectCast(e.OldValue, Double), 3)
        End Sub
        Private Shared Sub OnCurrentChangeChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)

            Dim panelContentControl_Renamed As PanelContentControl = CType(d, PanelContentControl)
            panelContentControl_Renamed.IsChangePositive = If(DirectCast(e.NewValue, Double) = 0, Nothing, CType(DirectCast(e.NewValue, Double) > 0, Boolean?))
        End Sub
        Private Shared Sub OnIsChangePositiveChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, PanelContentControl).UpdateVisualState()
        End Sub
        Private Shared Sub OnIsExpandedChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, PanelContentControl).UpdateVisualState()
        End Sub
        #End Region
        Public Sub New()
            DefaultStyleKey = GetType(PanelContentControl)
            Background = Brushes.Transparent
            Data = New ObservableCollection(Of Point)()
            AddHandler Unloaded, AddressOf PanelContentControl_Unloaded
            AddHandler SizeChanged, AddressOf PanelContentControl_SizeChanged
            Cursor = Cursors.Hand
        End Sub
        Private Sub PanelContentControl_Unloaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If PartBackButton IsNot Nothing Then
                RemoveHandler PartBackButton.Click, AddressOf PartBackButton_Click
            End If
        End Sub
        Private Sub PanelContentControl_SizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
            UpdateVisualState()
        End Sub
        Public Event BackButtonClicked As EventHandler
        Protected Sub RaiseBackButtonClicked()
            RaiseEvent BackButtonClicked(Me, EventArgs.Empty)
        End Sub
        Private Property PartBackButton() As Button
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            UpdateVisualState()
            PartBackButton = TryCast(GetTemplateChild("PART_BackButton"), Button)
            If PartBackButton IsNot Nothing Then
                AddHandler PartBackButton.Click, AddressOf PartBackButton_Click
            End If
        End Sub
        Private Sub PartBackButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RaiseBackButtonClicked()
        End Sub
        Protected Overrides Sub OnMouseEnter(ByVal e As MouseEventArgs)
            MyBase.OnMouseEnter(e)
            UpdateVisualState()
        End Sub
        Protected Overrides Sub OnMouseLeave(ByVal e As MouseEventArgs)
            MyBase.OnMouseEnter(e)
            UpdateVisualState()
        End Sub
        Private Sub UpdateVisualState()
            VisualStateManager.GoToState(Me,If(IsMouseOver, "MouseOver", "Normal"), True)
            If IsChangePositive Is Nothing Then
                VisualStateManager.GoToState(Me, "Zero", False)
            End If
            If IsChangePositive = True Then
                VisualStateManager.GoToState(Me, "Positive", False)
            End If
            If IsChangePositive = False Then
                VisualStateManager.GoToState(Me, "Negative", False)
            End If
            If IsExpanded Then
                Cursor = Cursors.Arrow
                VisualStateManager.GoToState(Me, "Checked", False)
            Else
                Cursor = Cursors.Hand
                VisualStateManager.GoToState(Me, "Unchecked", False)
            End If
            VisualStateManager.GoToState(Me,If(RenderSize.Width < 165, "CompactView", "AdvancedView"), False)
        End Sub
        Public Property IndexName() As String
            Get
                Return DirectCast(GetValue(IndexNameProperty), String)
            End Get
            Set(ByVal value As String)
                SetValue(IndexNameProperty, value)
            End Set
        End Property
        Public Property CurrentChange() As Double
            Get
                Return DirectCast(GetValue(CurrentChangeProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(CurrentChangeProperty, value)
            End Set
        End Property
        Public Property CurrentValue() As Double
            Get
                Return DirectCast(GetValue(CurrentValueProperty), Double)
            End Get
            Set(ByVal value As Double)
                SetValue(CurrentValueProperty, value)
            End Set
        End Property
        Public Property IsChangePositive() As Boolean?
            Get
                Return DirectCast(GetValue(IsChangePositiveProperty), Boolean?)
            End Get
            Set(ByVal value? As Boolean)
                SetValue(IsChangePositiveProperty, value)
            End Set
        End Property
        Public Property IsExpanded() As Boolean
            Get
                Return DirectCast(GetValue(IsExpandedProperty), Boolean)
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsExpandedProperty, value)
            End Set
        End Property
        Public Property Data() As ObservableCollection(Of Point)
            Get
                Return DirectCast(GetValue(DataProperty), ObservableCollection(Of Point))
            End Get
            Set(ByVal value As ObservableCollection(Of Point))
                SetValue(DataProperty, value)
            End Set
        End Property
    End Class
    Public Class SimpleChartControl
        Inherits ItemsControl

        Public Sub New()
            DefaultStyleKey = GetType(SimpleChartControl)
        End Sub
        Protected Overrides Function GetContainerForItemOverride() As DependencyObject
            Return New SimpleChartItem()
        End Function
        Protected Overrides Function IsItemItsOwnContainerOverride(ByVal item As Object) As Boolean
            Return TypeOf item Is SimpleChartItem
        End Function
        Protected Overrides Sub PrepareContainerForItemOverride(ByVal element As DependencyObject, ByVal item As Object)
            MyBase.PrepareContainerForItemOverride(element, item)
            Dim simpleChartItem As SimpleChartItem = TryCast(element, SimpleChartItem)
            If simpleChartItem IsNot Nothing Then
                Dim p As Point = DirectCast(item, Point)
                Dim left As Double = If(p.X = 0, 45, 90)
                simpleChartItem.Margin = New Thickness(left, p.Y, 0, 0)
            End If
        End Sub
    End Class
    Public Class SimpleChartItem
        Inherits Control

        Public Sub New()
            DefaultStyleKey = GetType(SimpleChartItem)
        End Sub
    End Class
End Namespace
