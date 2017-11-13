Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Modules

    Partial Public Class Orders
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportZoom

        Public Sub New()
            MyBase.New(GetType(OrderCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
        End Sub
        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            UnsubscribeOrderViewEvents()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrderCollectionViewModel
            Get
                Return GetViewModel(Of OrderCollectionViewModel)()
            End Get
        End Property
        Private privateCollectionPresenter As OrderCollectionPresenter
        Protected Property CollectionPresenter() As OrderCollectionPresenter
            Get
                Return privateCollectionPresenter
            End Get
            Private Set(ByVal value As OrderCollectionPresenter)
                privateCollectionPresenter = value
            End Set
        End Property
        Protected Overridable Function CreateCollectionPresenter() As OrderCollectionPresenter
            Return New OrderCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.OrderEditView))
        End Sub
        Private Sub BindCommands()
            biNewOrder.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.Enabled = False
            bmiNewOrder.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.Enabled = False
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintInvoice.BindCommand(Sub() ViewModel.PrintInvoice(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesReport(), ViewModel)
            bmiPrintSalesAnalysis.BindCommand(Sub() ViewModel.PrintSalesByStore(), ViewModel)
            BindGalleryQuickReportsItem(0, SalesReportType.SalesReport)
            BindGalleryQuickReportsItem(1, SalesReportType.ThankYou)
            BindGalleryQuickReportsItem(2, SalesReportType.SalesByStore)
            BindGalleryQuickReportsItem(3, SalesReportType.Invoice)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As SalesReportType)
            galleryQuickReports.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickReport(parameter), ViewModel, Function() parameter)
        End Sub
        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("RECORDS: {0}", count)
            UpdateAdditionalButtons(count > 0)
        End Sub
        Private Sub UpdateAdditionalButtons(ByVal hasRecords As Boolean)
            biReverseSort.Enabled = hasRecords
            biExpandCollapse.Enabled = hasRecords AndAlso (CollectionUIViewModel.ViewKind = CollectionViewKind.ListView)
            biAddColumns.Enabled = biExpandCollapse.Enabled
        End Sub
        Private Sub biExpandCollapse_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biExpandCollapse.ItemClick
            CollectionPresenter.ExpandCollapseMasterRows()
        End Sub
        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biAddColumns.CheckedChanged
            CollectionPresenter.AddColumns(biAddColumns)
        End Sub
        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biReverseSort.ItemClick
            CollectionPresenter.ReverseSort(gridView, colOrderDate)
        End Sub
        Private orderView As OrderView
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UnsubscribeOrderViewEvents()
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            orderView = TryCast(moduleLocator.GetModule(ModuleType.OrderView), OrderView)
            SubscribeOrderViewEvents()
            ViewModelHelper.EnsureModuleViewModel(orderView, ViewModel, ViewModel.SelectedEntityKey)
            orderView.Dock = DockStyle.Fill
            orderView.Parent = pnlView
            gridView.ExpandMasterRow(0)
        End Sub
        Private Sub UnsubscribeOrderViewEvents()
            If orderView IsNot Nothing Then
                RemoveHandler orderView.ZoomLevelChanged, AddressOf orderView_ZoomLevelChanged
            End If
        End Sub
        Private Sub SubscribeOrderViewEvents()
            If orderView IsNot Nothing Then
                AddHandler orderView.ZoomLevelChanged, AddressOf orderView_ZoomLevelChanged
            End If
        End Sub
        #Region "ViewKind"
        Private privateCollectionUIViewModel As CollectionUIViewModel
        Protected Property CollectionUIViewModel() As CollectionUIViewModel
            Get
                Return privateCollectionUIViewModel
            End Get
            Private Set(ByVal value As CollectionUIViewModel)
                privateCollectionUIViewModel = value
            End Set
        End Property
        Private Sub InitViewKind()
            AddHandler CollectionUIViewModel.ViewKindChanged, AddressOf ViewModel_ViewKindChanged
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub
        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If CollectionUIViewModel.ViewKind = CollectionViewKind.ListView Then
                gridControl.MainView = gridView
            End If
            UpdateAdditionalButtons(ViewModel.Entities.Count > 0)
            GridHelper.SetFindControlImages(gridControl)
        End Sub
        #End Region
        #Region "ViewLayout"
        Private Sub InitViewLayout()
            AddHandler CollectionUIViewModel.ViewLayoutChanged, AddressOf ViewModel_ViewLayoutChanged
            bmiHorizontalLayout.BindCommand(Sub() CollectionUIViewModel.ShowHorizontalLayout(), CollectionUIViewModel)
            bmiVerticalLayout.BindCommand(Sub() CollectionUIViewModel.ShowVerticalLayout(), CollectionUIViewModel)
            bmiHideDetail.BindCommand(Sub() CollectionUIViewModel.HideDetail(), CollectionUIViewModel)
        End Sub
        Private Sub ViewModel_ViewLayoutChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim detailHidden As Boolean = CollectionUIViewModel.IsDetailHidden
            splitterItem.Visibility = If(detailHidden, LayoutVisibility.Never, LayoutVisibility.Always)
            masterItem.Visibility = If(detailHidden, LayoutVisibility.Never, LayoutVisibility.Always)
            If Not detailHidden Then
                If splitterItem.IsVertical <> CollectionUIViewModel.IsHorizontalLayout Then
                    layoutControlGroup1.RotateLayout()
                End If
            End If
        End Sub
        #End Region
        #Region "ISupportZoom Members"
        Private Property ISupportZoom_ZoomLevel() As Integer Implements ISupportZoom.ZoomLevel
            Get
                Return If(orderView IsNot Nothing, orderView.ZoomLevel, 100)
            End Get
            Set(ByVal value As Integer)
                If orderView IsNot Nothing Then
                    orderView.ZoomLevel = value
                End If
            End Set
        End Property
        Private Shared ReadOnly zoomLevelChanged As New Object()
        Private Custom Event ZoomChanged As System.EventHandler Implements ISupportZoom.ZoomChanged
            AddHandler(ByVal value As System.EventHandler)
                Events.AddHandler(zoomLevelChanged, value)
            End AddHandler
            RemoveHandler(ByVal value As System.EventHandler)
                Events.RemoveHandler(zoomLevelChanged, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
            End RaiseEvent
        End Event
        Private Sub orderView_ZoomLevelChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            RaiseZoomLevelChanged()
        End Sub
        Private Sub RaiseZoomLevelChanged()
            Dim handler = TryCast(Events(zoomLevelChanged), System.EventHandler)
            If handler IsNot Nothing Then
                handler(Me, System.EventArgs.Empty)
            End If
        End Sub
        #End Region
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
    End Class
End Namespace
