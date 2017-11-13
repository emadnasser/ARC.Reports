Imports DevExpress.Xpf.DemoBase.DemoTesting
Imports System.Threading
Imports System.Windows.Threading
Imports DevExpress.Xpf.Core.Native
Imports System
Imports DevExpress.Xpf.NavBar
Imports System.Collections
Imports System.Windows.Controls
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Editors
Imports System.Windows.Controls.Primitives
Imports System.Windows.Media.Animation
Imports DevExpress.Xpf.Core
Imports System.Linq

Namespace NavBarDemo.Tests
    Public Class NavBarCheckAllDemosFixture
        Inherits CheckAllDemosFixture

        Private skipMemoryLeaksCheckModules() As Type = { }
        Protected Overrides Function CheckMemoryLeaks(ByVal moduleType As Type) As Boolean
            Return Not skipMemoryLeaksCheckModules.Contains(moduleType)
        End Function
        Protected Overrides Sub CreateSwitchAllThemesActions()
            MyBase.CreateSwitchAllThemesActions()
        End Sub
    End Class
    #Region "NavBarDemoModulesAccessor"
    Public Class NavBarDemoModulesAccessor
        Inherits DemoModulesAccessor(Of NavBarDemoModule)

        Public Sub New(ByVal fixture As BaseDemoTestingFixture)
            MyBase.New(fixture)
        End Sub
        Public ReadOnly Property NavBarControl() As NavBarControl
            Get
                Return DemoModule.navBarControl
            End Get
        End Property
        Public ReadOnly Property View() As NavBarViewBase
            Get
                Return NavBarControl.View
            End Get
        End Property
        Public ReadOnly Property ExplorerBarView() As ExplorerBarView
            Get
                Return CType(View, ExplorerBarView)
            End Get
        End Property
        Public ReadOnly Property NavigationPaneView() As NavigationPaneView
            Get
                Return CType(View, NavigationPaneView)
            End Get
        End Property
        Public ReadOnly Property SideBarView() As SideBarView
            Get
                Return CType(View, SideBarView)
            End Get
        End Property
        Public ReadOnly Property GroupsAndItemsModule() As GroupsAndItems
            Get
                Return CType(DemoModule, GroupsAndItems)
            End Get
        End Property
    End Class
    #End Region
    Public MustInherit Class BaseNavBarTestingFixture
        Inherits BaseDemoTestingFixture

        Private ReadOnly modulesAccessor As NavBarDemoModulesAccessor
        Public Sub New()
            modulesAccessor = New NavBarDemoModulesAccessor(Me)
        End Sub
        Public ReadOnly Property NavBarControl() As NavBarControl
            Get
                Return modulesAccessor.NavBarControl
            End Get
        End Property
        Public ReadOnly Property View() As NavBarViewBase
            Get
                Return modulesAccessor.View
            End Get
        End Property
        Public ReadOnly Property ExplorerBarView() As ExplorerBarView
            Get
                Return modulesAccessor.ExplorerBarView
            End Get
        End Property
        Public ReadOnly Property NavigationPaneView() As NavigationPaneView
            Get
                Return modulesAccessor.NavigationPaneView
            End Get
        End Property
        Public ReadOnly Property SideBarView() As SideBarView
            Get
                Return modulesAccessor.SideBarView
            End Get
        End Property
        Public ReadOnly Property GroupsAndItemsModule() As GroupsAndItems
            Get
                Return CType(DemoBaseTesting.CurrentDemoModule, GroupsAndItems)
            End Get
        End Property
        Public ReadOnly Property Events() As Events
            Get
                Return CType(DemoBaseTesting.CurrentDemoModule, Events)
            End Get
        End Property
    End Class
    Public Class CheckDemoOptionsFixture
        Inherits BaseNavBarTestingFixture

        Protected Overrides Sub CreateActions()
            MyBase.CreateActions()
            AddSimpleAction(AddressOf CreateCheckDemosActions)
        End Sub
        Private Sub CreateCheckDemosActions()
            CreateCheckTableViewDemoActions()
            CreateCheckLayoutCustomizationDemoActions()
            CreateEventsDemoActions()
            CreateSetCurrentDemoActions(Nothing, False)
        End Sub
        #Region "GroupsAndItems"
        Private Sub CreateCheckTableViewDemoActions()
            AddLoadModuleActions(GetType(GroupsAndItems))
            AddSimpleAction(Sub()
                Assert.AreEqual(0, GroupsAndItemsModule.viewsList.SelectedIndex)
                AssertGroupsAndItemsModuleView(GetType(ExplorerBarView))
                GroupsAndItemsModule.viewsList.SelectedIndex = 1
                UpdateLayoutAndDoEvents()
                AssertGroupsAndItemsModuleView(GetType(NavigationPaneView))
                GroupsAndItemsModule.viewsList.SelectedIndex = 2
                UpdateLayoutAndDoEvents()
                AssertGroupsAndItemsModuleView(GetType(SideBarView))
            End Sub)
        End Sub
        Private Sub AssertGroupsAndItemsModuleView(ByVal viewType As Type)
            Dim images As ArrayList = (CType(GroupsAndItemsModule.FindResource("Images"), ArrayList))
            Assert.AreEqual(viewType, View.GetType())
            Assert.IsTrue(GroupsAndItemsModule.addGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.addNewItemButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)

            Assert.AreEqual(0, GroupsAndItemsModule.newGroupImageStyleList.SelectedIndex)
            Assert.AreEqual(0, GroupsAndItemsModule.newItemImageList.SelectedIndex)

            Assert.AreEqual(2, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 1", NavBarControl.Groups(0).Header)
            Assert.AreEqual(1, NavBarControl.Groups(0).Items.Count)
            Assert.AreEqual("Item 1", CType(NavBarControl.Groups(0).Items(0), NavBarItem).Content)
            Assert.AreEqual("Group 2", NavBarControl.Groups(1).Header)
            Assert.AreEqual(1, NavBarControl.Groups(1).Items.Count)
            Assert.AreEqual("Item 1", CType(NavBarControl.Groups(1).Items(0), NavBarItem).Content)

            UIAutomationActions.ClickButton(GroupsAndItemsModule.addGroupButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(3, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 3", NavBarControl.Groups(2).Header)
            Assert.AreEqual(0, NavBarControl.Groups(2).Items.Count)
            Assert.AreEqual(DirectCast(images(0), Image).Source, NavBarControl.Groups(2).ImageSource)
            Assert.AreEqual(16R, NavBarControl.Groups(2).ItemImageSettings.Height)
            Assert.AreEqual(16R, NavBarControl.Groups(2).ItemImageSettings.Width)

            GroupsAndItemsModule.newItemImageList.SelectedIndex = 1
            GroupsAndItemsModule.newGroupImageStyleList.SelectedIndex = 1
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addGroupButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(4, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 4", NavBarControl.Groups(3).Header)
            Assert.AreEqual(0, NavBarControl.Groups(3).Items.Count)
            Assert.AreEqual(DirectCast(images(1), Image).Source, NavBarControl.Groups(3).ImageSource)
            Assert.AreEqual(32R, NavBarControl.Groups(3).ItemImageSettings.Height)
            Assert.AreEqual(32R, NavBarControl.Groups(3).ItemImageSettings.Width)
            Assert.AreEqual(System.Windows.HorizontalAlignment.Center, NavBarControl.Groups(3).ItemLayoutSettings.ImageHorizontalAlignment)
            Assert.AreEqual(System.Windows.HorizontalAlignment.Center, NavBarControl.Groups(3).ItemLayoutSettings.TextHorizontalAlignment)
            Assert.AreEqual(Dock.Top, NavBarControl.Groups(3).ItemLayoutSettings.ImageDocking)

            Assert.IsTrue(GroupsAndItemsModule.addGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.addNewItemButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)

            NavBarControl.ActiveGroup = NavBarControl.Groups(2)
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addNewItemButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(1, NavBarControl.Groups(2).Items.Count)
            Assert.AreEqual("Item 1", CType(NavBarControl.Groups(2).Items(0), NavBarItem).Content)
            Assert.AreEqual((DirectCast(images(1), Image)).Source, CType(NavBarControl.Groups(2).Items(0), NavBarItem).ImageSource)

            GroupsAndItemsModule.newItemImageList.SelectedIndex = 2
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addNewItemButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(2, NavBarControl.Groups(2).Items.Count)
            Assert.AreEqual("Item 2", CType(NavBarControl.Groups(2).Items(1), NavBarItem).Content)
            Assert.AreEqual((DirectCast(images(2), Image)).Source, CType(NavBarControl.Groups(2).Items(1), NavBarItem).ImageSource)

            Assert.IsTrue(GroupsAndItemsModule.addGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.addNewItemButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)

            NavBarControl.ActiveGroup.SelectedItem = CType(NavBarControl.Groups(2).Items(1), NavBarItem)
            UpdateLayoutAndDoEvents()
            Assert.IsTrue(GroupsAndItemsModule.addGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.addNewItemButton.IsEnabled)
            Assert.IsTrue(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)

            UIAutomationActions.ClickButton(GroupsAndItemsModule.deleteSelectedItemButton)
            UpdateLayoutAndDoEvents()
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            Assert.AreEqual(1, NavBarControl.Groups(2).Items.Count)
            Assert.AreEqual("Item 1", CType(NavBarControl.Groups(2).Items(0), NavBarItem).Content)

            NavBarControl.ActiveGroup.SelectedItem = CType(NavBarControl.Groups(2).Items(0), NavBarItem)
            UpdateLayoutAndDoEvents()
            Assert.IsTrue(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            UIAutomationActions.ClickButton(GroupsAndItemsModule.deleteSelectedItemButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(0, NavBarControl.Groups(2).Items.Count)

            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            UIAutomationActions.ClickButton(GroupsAndItemsModule.deleteLastGroupButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(3, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 3", NavBarControl.Groups(2).Header)

            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            UIAutomationActions.ClickButton(GroupsAndItemsModule.deleteLastGroupButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(2, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 2", NavBarControl.Groups(1).Header)

            Assert.IsTrue(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            UIAutomationActions.ClickButton(GroupsAndItemsModule.deleteLastGroupButton)
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(1, NavBarControl.Groups.Count)
            Assert.AreEqual("Group 1", NavBarControl.Groups(0).Header)

            Assert.IsFalse(GroupsAndItemsModule.deleteLastGroupButton.IsEnabled)
            Assert.IsFalse(GroupsAndItemsModule.deleteSelectedItemButton.IsEnabled)
            NavBarControl.Groups.RemoveAt(0)

            GroupsAndItemsModule.newGroupImageStyleList.SelectedIndex = 0
            GroupsAndItemsModule.newItemImageList.SelectedIndex = 0
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addGroupButton)
            UpdateLayoutAndDoEvents()
            NavBarControl.ActiveGroup = NavBarControl.Groups(0)
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addNewItemButton)
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addGroupButton)
            UpdateLayoutAndDoEvents()
            NavBarControl.ActiveGroup = NavBarControl.Groups(1)
            UpdateLayoutAndDoEvents()
            UIAutomationActions.ClickButton(GroupsAndItemsModule.addNewItemButton)
            UpdateLayoutAndDoEvents()
        End Sub
        #End Region
        Private Sub CreateCheckLayoutCustomizationDemoActions()
            AddLoadModuleActions(GetType(LayoutCustomization))
        End Sub
        Private Sub CreateEventsDemoActions()
            AddLoadModuleActions(GetType(Events))
            AddSimpleAction(AddressOf ClearEventCheckBoxes)

            AddCheckCommonEventsActions()
            AddCheckExplorerBarGroupExpandedEventsActions()

            AddSimpleAction(Sub()
                Events.viewsList.SelectedIndex = 1
                UpdateLayoutAndDoEvents()
            End Sub)
            AddCheckCommonEventsActions()
            AddCheckNavigationPaneExpandedEventsActions()

            AddSimpleAction(Sub()
                Events.viewsList.SelectedIndex = 2
                UpdateLayoutAndDoEvents()
            End Sub)
            AddCheckCommonEventsActions()

            AddSimpleAction(Sub()
                Events.viewsList.SelectedIndex = 0
                UpdateLayoutAndDoEvents()
            End Sub)
            AddCheckCommonEventsActions()
            AddCheckExplorerBarGroupExpandedEventsActions()
        End Sub

        Private Sub AddCheckCommonEventsActions()
            Dim collapsingStoryboard As Storyboard = CreateDXExpanderAnimation(0)
            Dim expandingStoryboard As Storyboard = CreateDXExpanderAnimation(1)
            AddSimpleAction(Sub() ToggleCheckEditAndRaiseEvent(Events.mouseDownCheckbox, "MouseDown", New MouseButtonEventArgs(Mouse.PrimaryDevice, Environment.TickCount, MouseButton.Left) With {.RoutedEvent = UIElement.PreviewMouseDownEvent}))
            AddSimpleAction(Sub() ToggleCheckEditAndRaiseEvent(Events.mouseMoveCheckbox, "MouseMove", New MouseEventArgs(Mouse.PrimaryDevice, Environment.TickCount) With {.RoutedEvent = UIElement.MouseMoveEvent}))
            AddSimpleAction(Sub() ToggleCheckEditAndRaiseEvent(Events.mouseUpCheckbox, "MouseUp", New MouseButtonEventArgs(Mouse.PrimaryDevice, Environment.TickCount, MouseButton.Left) With {.RoutedEvent = UIElement.PreviewMouseUpEvent}))

            AddSimpleAction(Sub() ToggleCheckEditAndRaiseEvent(Events.clickCheckbox, "Click", New MouseEventArgs(Mouse.PrimaryDevice, Environment.TickCount) With {.RoutedEvent = ButtonBase.ClickEvent}))
            AddSimpleAction(Sub() ToggleCheckEditAndPerformAction(Events.selectionChangingCheckbox, "ItemSelecting", AddressOf SelectFirstItem, AddressOf SelectSecondItem))
            AddSimpleAction(Sub() ToggleCheckEditAndPerformAction(Events.selectionChangedCheckbox, "ItemSelected", AddressOf SelectFirstItem, AddressOf SelectSecondItem))
            AddWaitUntilAnimationInProgress()
            AddSimpleAction(Sub()
                NavBarAnimationOptions.SetCollapseStoryboard(Me.NavBarControl.View, collapsingStoryboard)
                NavBarAnimationOptions.SetExpandStoryboard(Me.NavBarControl.View, expandingStoryboard)
                ToggleCheckEditAndPerformAction(Events.activeGroupChangingCheckbox, "ActiveGroupChanging", AddressOf SelectSecondGroup, AddressOf SelectFirstGroup)
            End Sub)
            AddWaitUntilAnimationInProgress()
            AddSimpleAction(Sub()
                NavBarAnimationOptions.SetCollapseStoryboard(Me.NavBarControl.View, collapsingStoryboard)
                NavBarAnimationOptions.SetExpandStoryboard(Me.NavBarControl.View, expandingStoryboard)
                ToggleCheckEditAndPerformAction(Events.activeGroupChangedCheckbox, "ActiveGroupChanged", AddressOf SelectSecondGroup, AddressOf SelectFirstGroup)
            End Sub)
            AddWaitUntilAnimationInProgress()
        End Sub

        Private Sub SelectSecondGroup()
            Events.navBar.ActiveGroup = Events.navBar.Groups(1)
        End Sub
        Private Sub SelectFirstGroup()
            Events.navBar.ActiveGroup = Events.navBar.Groups(0)
        End Sub

        Private Sub SelectFirstItem()
            Events.navBar.ActiveGroup.SelectedItemIndex = 0
        End Sub
        Private Sub SelectSecondItem()
            Events.navBar.ActiveGroup.SelectedItemIndex = 2
        End Sub

        Private Sub AddWaitUntilAnimationInProgress()
            AddConditionAction(AddressOf WaitUntilAnimationInProgressCondition, Nothing)
        End Sub
        Private Function WaitUntilAnimationInProgressCondition() As Boolean
            For Each group As NavBarGroup In Events.navBar.Groups
                If group.IsExpanding OrElse group.IsCollapsing Then
                    Return False
                End If
            Next group
            Return True
        End Function
        Private Sub AddCheckExplorerBarGroupExpandedEventsActions()
            AddSimpleAction(Sub()
                ToggleCheckEditAndPerformAction(Events.groupExpandedChangingCheckbox, "GroupExpandedChanging", Sub() Events.navBar.ActiveGroup.IsExpanded = Not Events.navBar.ActiveGroup.IsExpanded)
            End Sub)
            AddSimpleAction(Sub()
                ToggleCheckEditAndPerformAction(Events.groupExpandedChangedCheckbox, "GroupExpandedChanged", Sub() Events.navBar.ActiveGroup.IsExpanded = Not Events.navBar.ActiveGroup.IsExpanded)
            End Sub)
        End Sub
        Private Function CreateDXExpanderAnimation(ByVal toValue As Double) As Storyboard
            Dim stb As New Storyboard()
            Dim da As New DoubleAnimation(toValue, New Duration())
            Storyboard.SetTargetName(da, "PART_DXExpander")
            Storyboard.SetTargetProperty(da, New PropertyPath(DXExpander.AnimationProgressProperty))
            Return stb
        End Function
        Private Sub AddCheckNavigationPaneExpandedEventsActions()
            AddSimpleAction(Sub()
                ToggleCheckEditAndPerformAction(Events.navPaneExpandedChangingCheckbox, "NavPaneExpandedChanging", Sub() CType(Events.navBar.View, NavigationPaneView).IsExpanded = Not CType(Events.navBar.View, NavigationPaneView).IsExpanded)
            End Sub)
            AddSimpleAction(Sub()
                ToggleCheckEditAndPerformAction(Events.navPaneExpandedChangedCheckbox, "NavPaneExpandedChanged", Sub() CType(Events.navBar.View, NavigationPaneView).IsExpanded = Not CType(Events.navBar.View, NavigationPaneView).IsExpanded)
            End Sub)
        End Sub

        Private Sub ClearEventCheckBoxes()
            Events.mouseDownCheckbox.IsChecked = False
            Events.mouseMoveCheckbox.IsChecked = False
            Events.mouseUpCheckbox.IsChecked = False
            Events.clickCheckbox.IsChecked = False
            Events.selectionChangingCheckbox.IsChecked = False
            Events.selectionChangedCheckbox.IsChecked = False
            Events.activeGroupChangingCheckbox.IsChecked = False
            Events.activeGroupChangedCheckbox.IsChecked = False
            Events.groupExpandedChangingCheckbox.IsChecked = False
            Events.groupExpandedChangedCheckbox.IsChecked = False
            Events.navPaneExpandedChangingCheckbox.IsChecked = False
            Events.navPaneExpandedChangedCheckbox.IsChecked = False
        End Sub
        Private Sub ToggleCheckEditAndPerformAction(ByVal checkEdit As CheckEdit, ByVal message As String, ByVal action As Action)
            ToggleCheckEditAndPerformAction(checkEdit, message, action, Sub()
            End Sub)
        End Sub
        Private Sub ToggleCheckEditAndRaiseEvent(ByVal checkEdit As CheckEdit, ByVal message As String, ByVal eventArgs As RoutedEventArgs)
            Dim item As FrameworkElement = HelperActions.FindElementByType(Of NavBarItemControl)(Events.navBar)
            ToggleCheckEditAndPerformAction(checkEdit, message, Sub() item.RaiseEvent(eventArgs))
        End Sub
        Private Sub ToggleCheckEditAndPerformAction(ByVal checkEdit As CheckEdit, ByVal message As String, ByVal action As Action, ByVal rollBack As Action)
            action()
            UpdateLayoutAndDoEvents()
            Assert.AreEqual(String.Empty, Events.textBox.Text)
            rollBack()
            UpdateLayoutAndDoEvents()

            checkEdit.IsChecked = True
            action()
            UpdateLayoutAndDoEvents()
            Assert.IsTrue(Events.textBox.Text.Contains(message))
            rollBack()

            UIAutomationActions.ClickButton(Events.clearButton)
            checkEdit.IsChecked = False
            UpdateLayoutAndDoEvents()
        End Sub
    End Class
End Namespace
