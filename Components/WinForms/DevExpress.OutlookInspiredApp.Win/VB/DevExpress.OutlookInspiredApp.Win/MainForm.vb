Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DevAV.Modules
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraNavBar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.Utils.Taskbar

Namespace DevExpress.DevAV
    Partial Public Class MainForm
        Inherits RibbonForm
        Implements IMainModule, ISupportViewModel

        Public Sub New()
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, Me)
            AppHelper.MainForm = Me
            DevExpress.DevAV.StartUpProcess.OnStart("When Only the Best Will Do")
            InitializeComponent()
            DevExpress.DevAV.StartUpProcess.OnRunning("Initializing...")
            Icon = AppHelper.AppIcon
            mvvmContext.ViewModelConstructorParameter = Me
            AddHandler ViewModel.ModuleAdded, AddressOf viewModel_ModuleAdded
            AddHandler ViewModel.ModuleRemoved, AddressOf viewModel_ModuleRemoved
            AddHandler ViewModel.SelectedModuleTypeChanged, AddressOf viewModel_SelectedModuleTypeChanged
            AddHandler ViewModel.Print, AddressOf viewModel_Print
            AddHandler ViewModel.ShowAllFolders, AddressOf viewModel_ShowAllFolders
            AddHandler ViewModel.IsReadingModeChanged, AddressOf viewModel_IsReadingModeChanged
            AddHandler ribbonControl.MinimizedChanged, AddressOf Ribbon_MinimizedChanged
            ribbonControl.ForceInitialize()
            Dim TempZoomLevelManager As ZoomLevelManager = New ZoomLevelManager(beZoomLevel, bbiZoomDialog, ViewModel)
            AddHandler officeNavigationBar.SynchronizeNavigationClientSelectedItem, AddressOf officeNavigationBar_SynchronizeNavigationClientSelectedItem
            AddHandler officeNavigationBar.QueryPeekFormContent, AddressOf officeNavigationBar_QueryPeekFormContent
            AddHandler officeNavigationBar.PopupMenuShowing, AddressOf officeNavigationBar_PopupMenuShowing
            AddHandler navBar.ActiveGroupChanged, AddressOf navBar_ActiveGroupChanged
            AddHandler backstageViewControl.SelectedTabChanged, AddressOf backstageViewControl_SelectedTabChanged
            AddHandler backstageViewControl.Shown, AddressOf backstageViewControl_Shown
            AddHandler backstageViewControl.Hidden, AddressOf backstageViewControl_Hidden
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = ColorHelper.GetControlColor(LookAndFeel)
            backstageViewControl.BackstageViewShowRibbonItems = BackstageViewShowRibbonItems.None
            BindCommands()
            BindFiltersVisibility()
            InitNotifications()
            InitTaskBarCommands()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, New OutlookInspiredAppWin())
            Me.outlookBehavior = New OutlookReadingModeBehavior(navBar, officeNavigationBar)
        End Sub
        Public ReadOnly Property ViewModel() As MainViewModel
            Get
                Return mvvmContext.GetViewModel(Of MainViewModel)()
            End Get
        End Property
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            backstageViewControl.Office2013StyleOptions.HeaderBackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub
        Protected Overrides ReadOnly Property ShowMode() As XtraEditors.FormShowMode
            Get
                Return XtraEditors.FormShowMode.AfterInitialization
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitializePeekPanels()
            ViewModel.SelectedModuleType = ModuleType.Employees
            Dim types = New ModuleType() { ModuleType.Employees, ModuleType.Customers, ModuleType.Products, ModuleType.Orders, ModuleType.Quotes }
            RegisterNavigationMenuItems(barNavigationItem, types)
            RegisterNavPanes(navBar, types)
            DevExpress.DevAV.StartUpProcess.OnRunning("Successfully loaded.")
        End Sub
        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            DevExpress.DevAV.StartUpProcess.OnComplete()
        End Sub
        Protected Overrides Sub OnClosed(ByVal e As EventArgs)
            ViewModel.SelectedModuleType = ModuleType.Unknown
            MyBase.OnClosed(e)
        End Sub
        Private Sub BindCommands()
            mvvmContext.BindCommand(Of MainViewModel)(biGetStarted, Sub(x) x.GetStarted())
            mvvmContext.BindCommand(Of MainViewModel)(biGetSupport, Sub(x) x.GetSupport())
            mvvmContext.BindCommand(Of MainViewModel)(biBuyNow, Sub(x) x.BuyNow())
            mvvmContext.BindCommand(Of MainViewModel)(biAbout, Sub(x) x.About())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewGetStarted, Sub(x) x.GetStarted())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewGetSupport, Sub(x) x.GetSupport())
            mvvmContext.BindCommand(Of MainViewModel)(biBackstageViewBuyNow, Sub(x) x.BuyNow())
            mvvmContext.BindCommand(Of MainViewModel)(bbiNormal, Sub(x) x.TurnOffReadingMode())
            mvvmContext.BindCommand(Of MainViewModel)(bbiReading, Sub(x) x.TurnOnReadingMode())
            Dim btnDockThePeek = CType(officeNavigationBar.OptionsPeekFormButtonPanel.Buttons(0), PeekFormButton)
            btnDockThePeek.BindCommand(Sub() ViewModel.DockPeekModule(ModuleType.Unknown), ViewModel, Function() GetActivePeekModule())
        End Sub
        Private Function GetActivePeekModule() As ModuleType
            Return If(officeNavigationBar.PeekItem IsNot Nothing, CType(officeNavigationBar.PeekItem.Tag, ModuleType), ModuleType.Unknown)
        End Function
        Private Sub viewModel_ModuleAdded(ByVal sender As Object, ByVal e As EventArgs)
            Dim moduleControl = TryCast(sender, Control)
            moduleControl.Dock = DockStyle.Fill
            moduleControl.Parent = modulesContainer
            navBar.SendToBack()
            Text = String.Format("{1} - {0}", ViewModel.GetModuleCaption(ViewModel.SelectedModuleType), "DevAV")
            Dim ribbonModuleControl As IRibbonModule = TryCast(moduleControl, IRibbonModule)
            If ribbonModuleControl IsNot Nothing Then
                Ribbon.MergeRibbon(ribbonModuleControl.Ribbon)
                Ribbon.StatusBar.MergeStatusBar(ribbonModuleControl.Ribbon.StatusBar)
            Else
                Ribbon.UnMergeRibbon()
                Ribbon.StatusBar.UnMergeStatusBar()
            End If
        End Sub
        Private Sub viewModel_ModuleRemoved(ByVal sender As Object, ByVal e As EventArgs)
            Dim moduleControl = TryCast(sender, Control)
            GridHelper.HideCustomization(moduleControl)
            moduleControl.Parent = Nothing
        End Sub
        Private Sub viewModel_SelectedModuleTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            If ViewModel.SelectedNavPaneModuleType <> ModuleType.Unknown Then
                navBar.ActiveGroup = GetNavBarGroup(ViewModel.SelectedNavPaneModuleType)
            End If
            UpdateCompactLayout((Not ribbonControl.Minimized))
        End Sub
        Private Sub viewModel_ShowAllFolders(ByVal sender As Object, ByVal e As EventArgs)
            navBar.ShowNavPaneForm()
        End Sub
        Private outlookBehavior As OutlookReadingModeBehavior
        Private Sub viewModel_IsReadingModeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.outlookBehavior.ReadingMode = ViewModel.IsReadingMode
        End Sub
        Private Sub Ribbon_MinimizedChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCompactLayout((Not ribbonControl.Minimized))
        End Sub
        Private Sub UpdateCompactLayout(ByVal compact As Boolean)
            If ViewModel.SelectedNavPaneModuleType <> ModuleType.Unknown Then
                UpdateCompactLayout(TryCast(GetNavPaneModule(ViewModel.SelectedNavPaneModuleType), ISupportCompactLayout), compact)
            End If
            If ViewModel.SelectedNavPaneHeaderModuleType <> ModuleType.Unknown Then
                UpdateCompactLayout(TryCast(GetNavPaneModule(ViewModel.SelectedNavPaneHeaderModuleType), ISupportCompactLayout), compact)
            End If
        End Sub
        Private Sub UpdateCompactLayout(ByVal [module] As ISupportCompactLayout, ByVal compact As Boolean)
            If [module] IsNot Nothing Then
                [module].Compact = compact
            End If
        End Sub
        Private Sub backstageViewControl_SelectedTabChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
            If e.Item Is tabBackstageViewExport Then
                AddBackStageViewModule(ViewModel.SelectedExportModuleType, tabBackstageViewExport)
            End If
            If e.Item Is tabBackstageViewPrint Then
                AddBackStageViewModule(ViewModel.SelectedPrintModuleType, tabBackstageViewPrint)
            End If
        End Sub
        Private Sub viewModel_Print(ByVal sender As Object, ByVal e As PrintEventArgs)
            backstageViewControl.SelectedTab = tabBackstageViewPrint
            ribbonControl.ShowApplicationButtonContentControl()
        End Sub
        Private Sub backstageViewControl_Shown(ByVal sender As Object, ByVal e As EventArgs)
            tabBackstageViewExport.Enabled = ViewModel.SelectedExportModuleType <> ModuleType.QuotesExport
            tabBackstageViewPrint.Enabled = ViewModel.SelectedPrintModuleType <> ModuleType.QuotesPrint
        End Sub
        Private Sub backstageViewControl_Hidden(ByVal sender As Object, ByVal e As EventArgs)
            If backstageViewControl.SelectedTab IsNot tabBackstageViewAbout Then
                ViewModel.AfterReportHidden()
            End If
            backstageViewControl.SelectedTab = tabBackstageViewAbout
        End Sub
        Private Sub AddBackStageViewModule(ByVal moduleType As ModuleType, ByVal tabItem As BackstageViewTabItem)
            ViewModel.BeforeReportShown(moduleType)
            tabItem.ContentControl.Controls.Clear()
            Dim moduleControl = GetReportModule(moduleType)
            ViewModel.AfterReportShown(moduleType)
            moduleControl.Dock = DockStyle.Fill
            moduleControl.Parent = tabItem.ContentControl
        End Sub
        #Region "Filters Visibility"
        Private Sub BindFiltersVisibility()
            AddHandler navBar.NavPaneStateChanged, AddressOf navBar_NavPaneStateChanged
            AddHandler ViewModel.ViewFiltersVisibilityChanged, AddressOf ViewModel_ViewFiltersVisibilityChanged
            bmiFolderNormal.BindCommand(Sub() ViewModel.ShowFilters(), ViewModel)
            bmiFolderMinimized.BindCommand(Sub() ViewModel.MinimizeFilters(), ViewModel)
            bmiFolderOff.BindCommand(Sub() ViewModel.HideFilters(), ViewModel)
        End Sub
        Private Sub navBar_NavPaneStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If navBar.OptionsNavPane.NavPaneState = NavPaneState.Collapsed Then
                ViewModel.FiltersVisibility = CollectionViewFiltersVisibility.Minimized
            Else
                ViewModel.FiltersVisibility = CollectionViewFiltersVisibility.Visible
            End If
        End Sub
        Private Sub ViewModel_ViewFiltersVisibilityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Select Case ViewModel.FiltersVisibility
                Case CollectionViewFiltersVisibility.Visible
                    navBar.OptionsNavPane.NavPaneState = XtraNavBar.NavPaneState.Expanded
                    navBar.Visible = True
                Case CollectionViewFiltersVisibility.Minimized
                    navBar.OptionsNavPane.NavPaneState = XtraNavBar.NavPaneState.Collapsed
                    navBar.Visible = True
                Case CollectionViewFiltersVisibility.Hidden
                    navBar.Visible = False
            End Select
        End Sub
        #End Region
        #Region "Services"
        Private Function IsDockedCore(ByVal peekModuleType As ModuleType) As Boolean
            Dim panel As DockPanel = GetPanel(peekModuleType)
            Return (panel IsNot Nothing) AndAlso (panel.Visibility = DockVisibility.Visible)
        End Function
        Private Function IPeekModulesHost_IsDocked(ByVal moduleType As ModuleType) As Boolean Implements IPeekModulesHost.IsDocked
            Return IsDockedCore(moduleType)
        End Function
        Private Sub IPeekModulesHost_DockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHost.DockModule
            officeNavigationBar.HidePeekForm()
            Dim panel As DockPanel = GetPanel(moduleType)
            If panel IsNot Nothing Then
                panel.Restore()
            End If
        End Sub
        Private Sub IPeekModulesHost_UndockModule(ByVal moduleType As ModuleType) Implements IPeekModulesHost.UndockModule
            Dim panel As DockPanel = GetPanel(moduleType)
            If panel IsNot Nothing Then
                panel.Close()
            End If
        End Sub
        Private Sub IPeekModulesHost_ShowPeek(ByVal moduleType As ModuleType) Implements IPeekModulesHost.ShowPeek
            officeNavigationBar.ShowPeekForm(GetNavigationBarItem(moduleType))
        End Sub
        Private Sub ISupportTransitions_StartTransition(ByVal forward As Boolean, ByVal waitParameter As Object) Implements ISupportTransitions.StartTransition
            Dim transition = transitionManager.Transitions(modulesContainer)
            Dim animator = TryCast(transition.TransitionType, DevExpress.Utils.Animation.SlideFadeTransition)
            animator.Parameters.EffectOptions = If(forward, Utils.Animation.PushEffectOptions.FromRight, Utils.Animation.PushEffectOptions.FromLeft)
            If waitParameter Is Nothing Then
                transition.ShowWaitingIndicator = DefaultBoolean.False
            Else
                transition.ShowWaitingIndicator = DefaultBoolean.True
                transition.WaitingIndicatorProperties.Caption = DevExpress.XtraEditors.EnumDisplayTextHelper.GetDisplayText(waitParameter)
                transition.WaitingIndicatorProperties.Description = "Loading..."
                transition.WaitingIndicatorProperties.ContentMinSize = New System.Drawing.Size(160, 0)
            End If
            transitionManager.StartTransition(modulesContainer)
        End Sub
        Private Sub ISupportTransitions_EndTransition() Implements ISupportTransitions.EndTransition
            transitionManager.EndTransition()
        End Sub
        Private Sub ISupportModuleLayout_SaveLayoutToStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.SaveLayoutToStream
            dockManager.SaveLayoutToStream(ms)
        End Sub
        Private Sub ISupportModuleLayout_RestoreLayoutFromStream(ByVal ms As MemoryStream) Implements ISupportModuleLayout.RestoreLayoutFromStream
            dockManager.RestoreLayoutFromStream(ms)
        End Sub
        #End Region ' Services
        #Region "Navigation Menu"
        Private Sub RegisterNavigationMenuItems(ByVal menuItem As BarLinkContainerItem, ByVal types() As ModuleType)
            For i As Integer = 0 To types.Length - 1
                RegisterNavigationMenuItem(menuItem, types(i))
            Next i
        End Sub
        Private Sub RegisterNavigationMenuItem(ByVal menuItem As BarLinkContainerItem, ByVal type As ModuleType)
            Dim biModule As New BarCheckItem()
            biModule.Caption = ViewModel.GetModuleCaption(type)
            biModule.Name = "biModule" & ViewModel.GetModuleName(type)
            biModule.ImageUri.Uri = ViewModel.GetModuleImageUri(type)
            biModule.AllowGlyphSkinning = DefaultBoolean.True
            biModule.ImageUri.ResourceType = GetType(MainForm)
            biModule.GroupIndex = 1
            biModule.BindCommand(Sub(t) ViewModel.SelectModule(t), ViewModel, Function() type)
            menuItem.AddItem(biModule)
        End Sub
        #End Region ' Navigation Menu
        #Region "Navigation Bar"
        Private Sub RegisterNavPanes(ByVal navBar As NavBarControl, ByVal types() As ModuleType)
            For i As Integer = 0 To types.Length - 1
                RegisterNavPane(navBar, ViewModel.GetNavPaneModuleType(types(i)))
            Next i
            AddHandler officeNavigationBar.RegisterItem, AddressOf officeNavigationBar_RegisterItem
            officeNavigationBar.NavigationClient = navBar
        End Sub
        Private Sub RegisterNavPane(ByVal navBar As NavBarControl, ByVal type As ModuleType)
            Dim navGroup As New NavBarGroup()
            navGroup.Tag = type
            navGroup.Name = "navGroup" & ViewModel.GetModuleName(type)
            navGroup.Caption = ViewModel.GetModuleCaption(type)
            navGroup.ImageUri = ViewModel.GetModuleSmallImageUri(type)
            navGroup.ImageUri.ResourceType = GetType(MainForm)
            navGroup.GroupStyle = NavBarGroupStyle.ControlContainer
            navGroup.ControlContainer = New NavBarGroupControlContainer()
            navBar.Controls.Add(navGroup.ControlContainer)
            navBar.Groups.Add(navGroup)
        End Sub
        Private Sub officeNavigationBar_RegisterItem(ByVal sender As Object, ByVal e As NavigationBarNavigationClientItemEventArgs)
            Dim navGroup As NavBarGroup = CType(e.NavigationItem, NavBarGroup)
            Dim type = ViewModel.GetMainModuleType(CType(navGroup.Tag, ModuleType))
            e.Item.Tag = ViewModel.GetPeekModuleType(type)
            e.Item.Text = ViewModel.GetModuleCaption(type)
            e.Item.Name = "navItem" & ViewModel.GetModuleName(type)
            If type = ModuleType.Orders OrElse type = ModuleType.Quotes Then
                e.Item.ShowPeekFormOnItemHover = Utils.DefaultBoolean.False
            End If
            e.Item.BindCommand(Sub(t) ViewModel.SelectModule(t), ViewModel, Function() type)
        End Sub
        Private Sub officeNavigationBar_QueryPeekFormContent(ByVal sender As Object, ByVal e As QueryPeekFormContentEventArgs)
            Dim peekModuleType As ModuleType = CType(e.Item.Tag, ModuleType)
            If Not IsDockedCore(peekModuleType) Then
                e.Control = GetModule(peekModuleType)
            End If
        End Sub
        Private Sub officeNavigationBar_PopupMenuShowing(ByVal sender As Object, ByVal e As NavigationBarPopupMenuShowingEventArgs)
            If e.MenuKind = NavigationBarMenuKind.Item Then
                If e.Item.ShowPeekFormOnItemHover <> Utils.DefaultBoolean.False Then
                    CreateMenu(e.Menu, CType(e.Item.Tag, ModuleType))
                Else
                    e.Cancel = True
                End If
            End If
        End Sub
        Private Sub CreateMenu(ByVal menu As DevExpress.Utils.Menu.DXPopupMenu, ByVal peekModuleType As ModuleType)
            If IsDockedCore(peekModuleType) Then
                Dim undockItem = New DevExpress.Utils.Menu.DXMenuItem()
                undockItem.Caption = "Hide the peek"
                undockItem.BindCommand(Sub(t) ViewModel.UndockPeekModule(t), ViewModel, Function() peekModuleType)
                menu.Items.Add(undockItem)
            Else
                Dim dockItem = New DevExpress.Utils.Menu.DXMenuItem()
                dockItem.Caption = "Dock the peek"
                dockItem.BindCommand(Sub(t) ViewModel.DockPeekModule(t), ViewModel, Function() peekModuleType)
                Dim showItem = New DevExpress.Utils.Menu.DXMenuItem()
                showItem.Caption = "Show the peek"
                showItem.BindCommand(Sub(t) ViewModel.ShowPeekModule(t), ViewModel, Function() peekModuleType)
                menu.Items.Add(dockItem)
                menu.Items.Add(showItem)
            End If
        End Sub
        Private Sub officeNavigationBar_SynchronizeNavigationClientSelectedItem(ByVal sender As Object, ByVal e As NavigationBarNavigationClientSynchronizeItemEventArgs)
            Dim peekModuleType = CType(e.Item.Tag, ModuleType)
            If ViewModel.SelectedPeekModuleType <> peekModuleType Then
                ViewModel.SelectedModuleType = ViewModel.GetMainModuleType(peekModuleType)
            End If
        End Sub
        Private Sub navBar_ActiveGroupChanged(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
            Dim navPaneModuleType = CType(e.Group.Tag, ModuleType)
            Dim moduleControl As Control = GetNavPaneModule(navPaneModuleType)
            moduleControl.Dock = DockStyle.Fill
            e.Group.ControlContainer.Controls.Add(moduleControl)

            Dim collapsedGroupModuleType = ViewModel.GetNavPaneModuleType(navPaneModuleType, True)
            e.Group.CollapsedNavPaneContentControl = GetNavPaneModule(collapsedGroupModuleType)
        End Sub
        #End Region ' Navigation Bar
        #Region "Peek Panels"
        Private Sub InitializePeekPanels()
            Dim types = New ModuleType() { ModuleType.Employees, ModuleType.Customers, ModuleType.Products }
            CType(New PeekPanelsRegistrator(ViewModel), PeekPanelsRegistrator).RegisterPeekPanels(dockManager, types)
        End Sub
        Private Class PeekPanelsRegistrator
            Private viewModel As MainViewModel
            Public Sub New(ByVal viewModel As MainViewModel)
                Me.viewModel = viewModel
            End Sub
            Public Sub RegisterPeekPanels(ByVal dockManager As DockManager, ByVal types() As ModuleType)
                AddHandler dockManager.ClosedPanel, AddressOf dockManager_ClosedPanel
                AddHandler dockManager.VisibilityChanged, AddressOf dockManager_VisibilityChanged
                AddHandler dockManager.StartDocking, AddressOf dockManager_StartDocking
                dockManager.BeginInit()
                RegisterPeekPanelsCore(dockManager, Array.ConvertAll(types, AddressOf viewModel.GetPeekModuleType))
                dockManager.EndInit()
            End Sub
            Private Sub RegisterPeekPanelsCore(ByVal dockManager As DockManager, ByVal types() As ModuleType)
                For i As Integer = 0 To types.Length - 1
                    RegisterPeekPanel(dockManager, types(i))
                Next i
            End Sub
            Private Sub RegisterPeekPanel(ByVal dockManager As DockManager, ByVal type As ModuleType)
                Dim panel = New DockPanel()
                panel.ID = viewModel.GetModuleID(type)
                panels.Add(panel.ID, type)
                panel.Name = "peekPanel" & viewModel.GetModuleName(type)
                panel.Options.AllowDockBottom = False
                panel.Options.AllowDockLeft = False
                panel.Options.AllowDockTop = False
                panel.Options.AllowFloating = False
                panel.Text = viewModel.GetModuleCaption(type)
                panel.Visibility = DockVisibility.Hidden
                panel.SavedDock = DockingStyle.Right
                panel.OriginalSize = New System.Drawing.Size(200, 200)
                If dockManager.HiddenPanels.Count > 0 Then
                    panel.SavedParent = dockManager.HiddenPanels(0)
                    panel.Dock = DockingStyle.Fill
                    panel.SavedDock = DockingStyle.Fill
                    panel.SavedIndex = dockManager.HiddenPanels.Count - 1
                End If
                Dim container = New ControlContainer()
                container.Name = panel.Name & "_ControlContainer"
                panel.Controls.Add(container)
                panel.Register(dockManager)
                dockManager.HiddenPanels.AddRange(New DockPanel() { panel })
            End Sub
            Private Sub dockManager_StartDocking(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
                e.Cancel = True
            End Sub
            Private Sub dockManager_VisibilityChanged(ByVal sender As Object, ByVal e As VisibilityChangedEventArgs)
                If e.Visibility = DockVisibility.Visible AndAlso panels.ContainsKey(e.Panel.ID) Then
                    Dim [module] As Control = GetPeekModuleControl(e.Panel)
                    ViewModelHelper.EnsureModuleViewModel([module], viewModel)
                    [module].Dock = DockStyle.Fill
                    e.Panel.ControlContainer.Controls.Add([module])
                End If
            End Sub
            Private Sub dockManager_ClosedPanel(ByVal sender As Object, ByVal e As DockPanelEventArgs)
                Dim [module] As Control = GetPeekModuleControl(e.Panel)
                e.Panel.ControlContainer.Controls.Remove([module])
            End Sub
            Private Shared panels As IDictionary(Of Guid, ModuleType) = New Dictionary(Of Guid, ModuleType)()
            Private Function GetPeekModuleControl(ByVal panel As DockPanel) As Control
                Return TryCast(viewModel.GetModule(panels(panel.ID)), Control)
            End Function
        End Class
        #End Region ' Peek Panels
        #Region "Resolve ModuleType"
        Private Function GetPanel(ByVal peekModuleType As ModuleType) As DockPanel
            Dim id = ViewModel.GetModuleID(peekModuleType)
            Return dockManager.Panels.Concat(dockManager.HiddenPanels).FirstOrDefault(Function(p) p.ID = id)
        End Function
        Private Function GetNavigationBarItem(ByVal peekModuleType As ModuleType) As NavigationBarItem
            Return officeNavigationBar.Items.FirstOrDefault(Function(item) Object.Equals(item.Tag, peekModuleType))
        End Function
        Private Function GetNavBarGroup(ByVal navPaneModuleType As ModuleType) As NavBarGroup
            Return navBar.Groups.FirstOrDefault(Function(g) Object.Equals(g.Tag, navPaneModuleType))
        End Function
        Private Function GetModule(ByVal moduleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModel.GetModule(moduleType), Control)
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel)
            Return moduleControl
        End Function
        Private Function GetNavPaneModule(ByVal navPaneModuleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModel.GetModule(navPaneModuleType, ViewModel.SelectedModuleViewModel), Control)
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel)
            Return moduleControl
        End Function
        Private Function GetReportModule(ByVal moduleType As ModuleType) As Control
            Dim moduleControl As Control = TryCast(ViewModel.GetModule(moduleType), Control)
            ViewModelHelper.EnsureModuleViewModel(moduleControl, ViewModel.SelectedModuleViewModel, ViewModel.ReportParameter)
            Return moduleControl
        End Function
        #End Region
        #Region "ISupportViewModel"
        Private ReadOnly Property ISupportViewModel_ViewModel() As Object Implements ISupportViewModel.ViewModel
            Get
                Return ViewModel
            End Get
        End Property
        Private Sub ISupportViewModel_ParentViewModelAttached() Implements ISupportViewModel.ParentViewModelAttached
        End Sub
        #End Region
        #Region "Notifications"
        Private notificationsTimer As Timer
        Private alertControl As DevExpress.XtraBars.Alerter.AlertControl
        Private Sub InitNotifications()
            If CanUseToastNotifications() Then
                notificationManager.TryCreateApplicationShortcut()
                AddHandler notificationManager.Activated, AddressOf notificationsManager_Activated
            Else
                alertControl = New XtraBars.Alerter.AlertControl()
                alertControl.AllowHtmlText = True
                alertControl.FormLocation = XtraBars.Alerter.AlertFormLocation.TopRight
                alertControl.ShowPinButton = False
                AddHandler alertControl.AlertClick, AddressOf alertControl_AlertClick
            End If
            EnsureNotificationsTimer()
        End Sub
        Private Sub EnsureNotificationsTimer()
            If notificationsTimer Is Nothing Then
                notificationsTimer = New Timer()
                notificationsTimer.Interval = 15000
                AddHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
            End If
            notificationsTimer.Start()
        End Sub
        Private Sub DestroyNotificationsTimer()
            notificationsTimer.Stop()
            RemoveHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
            notificationsTimer.Dispose()
            notificationsTimer = Nothing
        End Sub
        Private notificationsCount As Integer
        Private Sub notificationsTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If notificationsCount < notificationManager.Notifications.Count Then
                notificationsTimer.Interval = 5000
                ShowNotification(notificationsCount)
                notificationsCount += 1
            Else
                DestroyNotificationsTimer()
            End If
        End Sub
        Private Sub alertControl_AlertClick(ByVal sender As Object, ByVal e As XtraBars.Alerter.AlertClickEventArgs)
            Dim notificationID As Object = e.Info.Tag
            e.AlertForm.Close()
            OnNotificationClick(notificationID)
        End Sub
        Private Sub notificationsManager_Activated(ByVal sender As Object, ByVal e As XtraBars.ToastNotifications.ToastNotificationEventArgs)
            OnNotificationClick(e.NotificationID)
        End Sub
        Private Function CanUseToastNotifications() As Boolean
            Return DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager.AreToastNotificationsSupported
        End Function
        Private Sub ShowNotification(ByVal index As Integer)
            Dim notification = notificationManager.Notifications(index)
            If CanUseToastNotifications() Then
                notificationManager.ShowNotification(notification)
            Else
                Dim alertCaption As String = "<b>" & notification.Header & "</b>"
                Dim alertText As String = notification.Body & " " & notification.Body2
                alertControl.Show(Me, New XtraBars.Alerter.AlertInfo(alertCaption, alertText, AppHelper.AppImage) With {.Tag = notification.ID})
            End If
        End Sub
        Private Sub OnNotificationClick(ByVal notificationID As Object)
            Dim backstageViewForm = backstageViewControl.FindForm()
            If backstageViewForm IsNot Nothing AndAlso backstageViewForm IsNot Me Then
                backstageViewForm.Hide()
                ribbonControl.HideApplicationButtonContentControl()
            End If
            If notificationID Is notificationManager.Notifications(0).ID Then
                ViewModel.SelectedModuleType = ModuleType.Orders
            End If
            If notificationID Is notificationManager.Notifications(1).ID Then
                Dim supportMap As ISupportMap = TryCast(ViewModel.SelectedModuleViewModel, ISupportMap)
                If supportMap IsNot Nothing AndAlso supportMap.CanShowMap() Then
                    supportMap.ShowMap()
                End If
            End If
            If notificationID Is notificationManager.Notifications(2).ID Then
                ViewModel.SelectedModuleType = ModuleType.Products
            End If
            If notificationID Is notificationManager.Notifications(3).ID Then
                If Not(TypeOf ViewModel.SelectedModuleViewModel Is ISupportAnalysis) Then
                    ViewModel.SelectedModuleType = ModuleType.Customers
                End If
                Dim supportAnalysis As ISupportAnalysis = TryCast(ViewModel.SelectedModuleViewModel, ISupportAnalysis)
                If supportAnalysis IsNot Nothing Then
                    supportAnalysis.ShowAnalysis()
                End If
            End If
        End Sub
        #End Region ' Notifications
        #Region "TaskBar"
        Private taskNewEmployee, taskSalesMap, taskOpportunities As JumpListItemTask
        Private Sub InitTaskBarCommands()
            TaskbarAssistant.Default.BeginUpdate()
            taskNewEmployee = CreateJumpListTask("New Employee", "Employee.ico")
            AddHandler taskNewEmployee.Click, AddressOf taskNewEmployee_Click
            taskSalesMap = CreateJumpListTask("Sales Map", "Map.ico")
            AddHandler taskSalesMap.Click, AddressOf taskSalesMap_Click
            taskOpportunities = CreateJumpListTask("Opportunities", "Opportunities.ico")
            taskOpportunities.BindCommand(Sub(m) ViewModel.SelectModule(m), ViewModel, Function() ModuleType.Quotes)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskNewEmployee)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskSalesMap)
            TaskbarAssistant.Default.JumpListTasksCategory.Add(taskOpportunities)
            TaskbarAssistant.Default.EndUpdate()
        End Sub
        Private Sub taskNewEmployee_Click(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.SelectedModuleType = ModuleType.Employees
            Dim collection = TryCast(ViewModel.SelectedModuleViewModel, EmployeeCollectionViewModel)
            If collection IsNot Nothing Then
                collection.[New]()
            End If
        End Sub
        Private Sub taskSalesMap_Click(ByVal sender As Object, ByVal e As EventArgs)
            ViewModel.SelectedModuleType = ModuleType.Products
            Dim collection = TryCast(ViewModel.SelectedModuleViewModel, ProductCollectionViewModel)
            If collection IsNot Nothing Then
                collection.ShowMap()
            End If
        End Sub
        Private Function CreateJumpListTask(ByVal caption As String, ByVal iconName As String) As JumpListItemTask
            Dim task As New JumpListItemTask(caption)
            task.IconPath = TaskbarHelper.GetIconPath(iconName)
            task.IconIndex = 0
            Return task
        End Function
        #End Region ' TaskBar
    End Class
    Public Class OutlookInspiredAppWin
    End Class
End Namespace
