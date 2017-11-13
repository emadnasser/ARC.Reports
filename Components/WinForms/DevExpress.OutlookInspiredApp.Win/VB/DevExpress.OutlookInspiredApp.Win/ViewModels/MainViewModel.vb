Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.Services
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class MainViewModel
        Implements IZoomViewModel

        #Region "static"
        Shared Sub New()
            DevExpress.Mvvm.ServiceContainer.Default.RegisterService(New Services.ModuleResourceProvider())
            DevExpress.Mvvm.ServiceContainer.Default.RegisterService(New Services.ModuleTypesResolver())
        End Sub
        #End Region ' static
        Protected Sub New(ByVal mainModule As IMainModule)
            RegisterServices(mainModule)
        End Sub
        Private Sub RegisterServices(ByVal mainModule As IMainModule)
            Dim mainModuleType = DirectCast(mainModule, Object).GetType()
            Dim localServices As ISupportServices = DirectCast(Me, ISupportServices)
            localServices.ServiceContainer.RegisterService(New Services.WaitingService())
            localServices.ServiceContainer.RegisterService(New Services.ModuleActivator(mainModuleType.Assembly, mainModuleType.Namespace & ".Modules"))
            localServices.ServiceContainer.RegisterService(New Services.ReportActivator())
            localServices.ServiceContainer.RegisterService(New Services.ModuleLocator(localServices.ServiceContainer))
            localServices.ServiceContainer.RegisterService(New Services.ReportLocator(localServices.ServiceContainer))
            localServices.ServiceContainer.RegisterService(New Services.TransitionService(mainModule))
            localServices.ServiceContainer.RegisterService(New Services.PeekModulesHostingService(mainModule))
            localServices.ServiceContainer.RegisterService(New Services.WorkspaceService(mainModule))
        End Sub
        #Region "Properties"
        Public Overridable Property SelectedModuleType() As ModuleType
        Public Overridable Property SelectedModule() As Object
        Public ReadOnly Property SelectedNavPaneModuleType() As ModuleType
            Get
                Return GetNavPaneModuleType(SelectedModuleType)
            End Get
        End Property
        Public ReadOnly Property SelectedPeekModuleType() As ModuleType
            Get
                Return GetPeekModuleType(SelectedModuleType)
            End Get
        End Property
        Public ReadOnly Property SelectedNavPaneHeaderModuleType() As ModuleType
            Get
                Return GetNavPaneModuleType(SelectedModuleType, True)
            End Get
        End Property
        Public ReadOnly Property SelectedExportModuleType() As ModuleType
            Get
                Return GetExportModuleType(SelectedModuleType)
            End Get
        End Property
        Public ReadOnly Property SelectedPrintModuleType() As ModuleType
            Get
                Return GetPrintModuleType(SelectedModuleType)
            End Get
        End Property
        Public ReadOnly Property SelectedModuleViewModel() As Object
            Get
                Return DirectCast(SelectedModule, Modules.ISupportViewModel).ViewModel
            End Get
        End Property
        #End Region ' Properties
        #Region "Commands"
        Public Function CanSelectModule(ByVal moduleType As ModuleType) As Boolean
            Return SelectedModuleType <> moduleType
        End Function
        <Command>
        Public Sub SelectModule(ByVal moduleType As ModuleType)
            SelectedModuleType = moduleType
        End Sub
        Public Function CanDockPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return Not Me.GetService(Of IPeekModulesHostingService)().IsDocked(peekModuleType)
        End Function
        <Command>
        Public Sub DockPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Me.GetService(Of IPeekModulesHostingService)().DockModule(peekModuleType)
        End Sub
        Public Function CanUndockPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return Me.GetService(Of IPeekModulesHostingService)().IsDocked(peekModuleType)
        End Function
        <Command>
        Public Sub UndockPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Me.GetService(Of IPeekModulesHostingService)().UndockModule(peekModuleType)
        End Sub
        Public Function CanShowPeekModule(ByVal moduleType As ModuleType) As Boolean
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Return Not Me.GetService(Of IPeekModulesHostingService)().IsDocked(peekModuleType)
        End Function
        <Command>
        Public Sub ShowPeekModule(ByVal moduleType As ModuleType)
            Dim peekModuleType = GetPeekModuleType(moduleType)
            Me.GetService(Of IPeekModulesHostingService)().ShowModule(peekModuleType)
        End Sub
        <Command>
        Public Sub GetStarted()
            AppHelper.ProcessStart(AssemblyInfo.DXLinkGetStarted)
        End Sub
        <Command>
        Public Sub GetSupport()
            AppHelper.ProcessStart(AssemblyInfo.DXLinkGetSupport)
        End Sub
        <Command>
        Public Sub BuyNow()
            AppHelper.ProcessStart(AssemblyInfo.DXLinkBuyNow)
        End Sub
        <Command>
        Public Sub About()
            DevExpress.Utils.About.AboutHelper.Show(DevExpress.Utils.About.ProductKind.DXperienceWin, New DevExpress.Utils.About.ProductStringInfoWin("Outlook Inspired App"))
        End Sub
        #End Region
        #Region "FiltersVisibility"
        Public Overridable Property IsReadingMode() As Boolean
        <Command>
        Public Sub TurnOnReadingMode()
            IsReadingMode = True
        End Sub
        Public Function CanTurnOnReadingMode() As Boolean
            Return Not IsReadingMode
        End Function
        <Command>
        Public Sub TurnOffReadingMode()
            IsReadingMode = False
        End Sub
        Public Function CanTurnOffReadingMode() As Boolean
            Return IsReadingMode
        End Function
        Public Overridable Property FiltersVisibility() As CollectionViewFiltersVisibility
        <Command>
        Public Sub ShowFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Visible
        End Sub
        Public Function CanShowFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Visible
        End Function
        <Command>
        Public Sub MinimizeFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Minimized
        End Sub
        Public Function CanMinimizeFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Minimized
        End Function
        <Command>
        Public Sub HideFilters()
            FiltersVisibility = CollectionViewFiltersVisibility.Hidden
        End Sub
        Public Function CanHideFilters() As Boolean
            Return FiltersVisibility <> CollectionViewFiltersVisibility.Hidden
        End Function
        Public Event IsReadingModeChanged As EventHandler
        Protected Overridable Sub OnIsReadingModeChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.TurnOnReadingMode())
            Me.RaiseCanExecuteChanged(Sub(x) x.TurnOffReadingMode())
            RaiseIsReadingModeChanged()
        End Sub
        Private Sub RaiseIsReadingModeChanged()
            Dim handler As EventHandler = IsReadingModeChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Public Event ViewFiltersVisibilityChanged As EventHandler
        Protected Overridable Sub OnFiltersVisibilityChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowFilters())
            Me.RaiseCanExecuteChanged(Sub(x) x.MinimizeFilters())
            Me.RaiseCanExecuteChanged(Sub(x) x.HideFilters())
            RaiseFiltersVisibilityChanged()
        End Sub
        Private Sub RaiseFiltersVisibilityChanged()
            Dim handler As EventHandler = ViewFiltersVisibilityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        #End Region
        Private Function IsModuleLoaded(ByVal type As ModuleType) As Boolean
            Return Me.GetService(Of Services.IModuleLocator)().IsModuleLoaded(type)
        End Function
        Public Function GetModule(ByVal type As ModuleType) As Object
            Return Me.GetService(Of Services.IModuleLocator)().GetModule(type)
        End Function
        Public Function GetModule(ByVal type As ModuleType, ByVal viewModel As Object) As Object
            Return Me.GetService(Of Services.IModuleLocator)().GetModule(type, viewModel)
        End Function
        Public Function GetModuleName(ByVal type As ModuleType) As String
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetName(type)
        End Function
        Public Function GetModuleID(ByVal type As ModuleType) As System.Guid
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetId(type)
        End Function
        Public Function GetModuleCaption(ByVal type As ModuleType) As String
            Return Me.GetService(Of Services.IModuleResourceProvider)().GetCaption(type)
        End Function
        Public Function GetModuleSmallImageUri(ByVal type As ModuleType) As String
            Return Me.GetService(Of Services.IModuleResourceProvider)().GetModuleImageUri(type, True)
        End Function
        Public Function GetModuleImageUri(ByVal type As ModuleType) As String
            Return Me.GetService(Of Services.IModuleResourceProvider)().GetModuleImageUri(type)
        End Function
        Public Function GetMainModuleType(ByVal type As ModuleType) As ModuleType
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetMainModuleType(type)
        End Function
        Public Function GetNavPaneModuleType(ByVal type As ModuleType, Optional ByVal collapsed As Boolean = False) As ModuleType
            Dim resolver = Me.GetService(Of Services.IModuleTypesResolver)()
            Return If(collapsed, resolver.GetNavPaneHeaderModuleType(type), resolver.GetNavPaneModuleType(type))
        End Function
        Public Function GetPeekModuleType(ByVal type As ModuleType) As ModuleType
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetPeekModuleType(type)
        End Function
        Public Function GetExportModuleType(ByVal type As ModuleType) As ModuleType
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetExportModuleType(type)
        End Function
        Public Function GetPrintModuleType(ByVal type As ModuleType) As ModuleType
            Return Me.GetService(Of Services.IModuleTypesResolver)().GetPrintModuleType(type)
        End Function
        #Region "Selected Module"
        Protected Overridable Sub OnSelectedModuleTypeChanged(ByVal oldType As ModuleType)
            Dim transitionService = Me.GetService(Of Services.ITransitionService)()
            Dim effective As Boolean = (SelectedModuleType <> ModuleType.Unknown) AndAlso (oldType <> ModuleType.Unknown)
            Dim waitParameter As Object = If((Not IsModuleLoaded(SelectedModuleType)), DirectCast(SelectedModuleType, Object), Nothing)
            Using transitionService.EnterTransition(effective, (CInt(SelectedModuleType) > CInt(oldType)), waitParameter)
                Dim workspaceService = Me.GetService(Of Services.IWorkspaceService)()
                Dim resolver = Me.GetService(Of IModuleTypesResolver)()
                If oldType <> ModuleType.Unknown Then
                    workspaceService.SaveWorkspace(resolver.GetName(oldType))
                Else
                    workspaceService.SetupDefaultWorkspace()
                End If
                Try
                    SelectedModule = GetModule(SelectedModuleType)
                    RaiseSelectedModuleTypeChanged()
                Catch e As Exception
                    Dim entryAsm = System.Reflection.Assembly.GetEntryAssembly()
                    Dim msg As String = "Navigation Error: [" & oldType.ToString() & "=>" & SelectedModuleType.ToString() & Environment.NewLine & (If(entryAsm IsNot Nothing, "StartUp:" & entryAsm.Location, String.Empty))
                    Throw New ApplicationException(msg, e)
                End Try
                If SelectedModuleType <> ModuleType.Unknown Then
                    workspaceService.RestoreWorkspace(resolver.GetName(SelectedModuleType))
                End If
            End Using
        End Sub
        Protected Overridable Sub OnSelectedModuleChanged(ByVal oldModule As Object)
            If oldModule IsNot Nothing Then
                RaiseEvent ModuleRemoved(oldModule, EventArgs.Empty)
            End If
            RaiseEvent SelectedModuleChanged(Me, EventArgs.Empty)
            If SelectedModule IsNot Nothing Then
                ViewModelHelper.EnsureModuleViewModel(SelectedModule, Me)
                RaiseEvent ModuleAdded(SelectedModule, EventArgs.Empty)
            End If
        End Sub
        Protected Overridable Sub RaiseSelectedModuleTypeChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.SelectModule(ModuleType.Unknown))
            Me.RaisePropertyChanged(Function(x) SelectedNavPaneModuleType)
            Me.RaisePropertyChanged(Function(x) SelectedNavPaneHeaderModuleType)
            RaiseEvent SelectedModuleTypeChanged(Me, EventArgs.Empty)
        End Sub
        Public Event ModuleAdded As EventHandler
        Public Event ModuleRemoved As EventHandler
        Public Event SelectedModuleChanged As EventHandler
        Public Event SelectedModuleTypeChanged As EventHandler
        #End Region ' Selected Module
        #Region "Print & Reports"
        Public Event Print As EventHandler(Of PrintEventArgs)
        Private privateReportParameter As Object
        Public Property ReportParameter() As Object
            Get
                Return privateReportParameter
            End Get
            Private Set(ByVal value As Object)
                privateReportParameter = value
            End Set
        End Property
        Private currentReportModule As ModuleType
        Friend Sub BeforeReportShown(ByVal moduleType As ModuleType)
            If ReportParameter IsNot Nothing Then
                Return
            End If
            Select Case moduleType
                Case DevExpress.DevAV.ModuleType.EmployeesExport, DevExpress.DevAV.ModuleType.EmployeesPrint
                    ReportParameter = EmployeeReportType.Profile
                Case DevExpress.DevAV.ModuleType.CustomersExport, DevExpress.DevAV.ModuleType.CustomersPrint
                    ReportParameter = CustomerReportType.Profile
                Case DevExpress.DevAV.ModuleType.ProductsExport, DevExpress.DevAV.ModuleType.ProductsPrint
                    ReportParameter = ProductReportType.OrderDetail
                Case DevExpress.DevAV.ModuleType.OrdersExport, DevExpress.DevAV.ModuleType.OrdersPrint
                    ReportParameter = SalesReportType.Invoice
            End Select
        End Sub
        Friend Sub AfterReportShown(ByVal moduleType As ModuleType)
            If currentReportModule <> moduleType Then
                Dim reportChanged As Boolean = currentReportModule <> DevExpress.DevAV.ModuleType.Unknown
                Me.currentReportModule = moduleType
                If reportChanged AndAlso moduleType <> DevExpress.DevAV.ModuleType.Unknown Then
                    Dim reportViewModel = TryCast(DirectCast(GetModule(moduleType), Modules.ISupportViewModel).ViewModel, ReportViewModelBase)
                    If reportViewModel IsNot Nothing Then
                        reportViewModel.OnReload()
                    End If
                End If
            End If
        End Sub
        Friend Sub AfterReportHidden()
            Me.currentReportModule = ModuleType.Unknown
            ReportParameter = Nothing
        End Sub
        Friend Sub RaisePrint(ByVal parameter As Object)
            ReportParameter = parameter
            Dim handler As EventHandler(Of PrintEventArgs) = PrintEvent
            If handler IsNot Nothing Then
                handler(Me, New PrintEventArgs(parameter))
            End If
        End Sub
        #End Region ' Print & Reports
        Public Event ShowAllFolders As EventHandler
        Friend Sub RaiseShowAllFolders()
            Dim handler As EventHandler = ShowAllFoldersEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        #Region "ISupportZoomModule Members"
        Private ReadOnly Property IZoomViewModel_ZoomModule() As Object Implements IZoomViewModel.ZoomModule
            Get
                Return SelectedModule
            End Get
        End Property
        Private Custom Event ZoomModuleChanged As EventHandler Implements IZoomViewModel.ZoomModuleChanged
            AddHandler(ByVal value As EventHandler)
                AddHandler SelectedModuleChanged, value
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                RemoveHandler SelectedModuleChanged, value
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
                RaiseEvent SelectedModuleChanged(sender, e)
            End RaiseEvent
        End Event
        #End Region
    End Class
    Public Class PrintEventArgs
        Inherits EventArgs

        Public Sub New(ByVal parameter As Object)
            Me.Parameter = parameter
        End Sub
        Private privateParameter As Object
        Public Property Parameter() As Object
            Get
                Return privateParameter
            End Get
            Private Set(ByVal value As Object)
                privateParameter = value
            End Set
        End Property
    End Class
End Namespace
