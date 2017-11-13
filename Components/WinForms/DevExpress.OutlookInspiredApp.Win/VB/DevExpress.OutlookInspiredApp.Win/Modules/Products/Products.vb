Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Modules

    Partial Public Class Products
        Inherits BaseModuleControl
        Implements IRibbonModule, ISupportZoom

        Public Sub New()
            MyBase.New(GetType(ProductCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
            colDescription.AppearanceCell.ForeColor = ColorHelper.DisabledTextColor
            colDescription.AppearanceCell.Options.UseForeColor = True
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
            InitEditors()
        End Sub
        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            UnsubscribeProductView()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As ProductCollectionViewModel
            Get
                Return GetViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property
        Private privateCollectionPresenter As ProductCollectionPresenter
        Protected Property CollectionPresenter() As ProductCollectionPresenter
            Get
                Return privateCollectionPresenter
            End Get
            Private Set(ByVal value As ProductCollectionPresenter)
                privateCollectionPresenter = value
            End Set
        End Property
        Protected Overridable Function CreateCollectionPresenter() As ProductCollectionPresenter
            Return New ProductCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.ProductEditView))
        End Sub
        Private Sub BindCommands()
            biNewProduct.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewProduct.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintOrderDetail.BindCommand(Sub() ViewModel.PrintOrderDetail(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesSummary(), ViewModel)
            bmiPrintSpecificationSummary.BindCommand(Sub() ViewModel.PrintSpecificationSummary(), ViewModel)
            BindGalleryQuickReportsItem(0, ProductReportType.OrderDetail)
            BindGalleryQuickReportsItem(1, ProductReportType.SalesSummary)
            BindGalleryQuickReportsItem(2, ProductReportType.SpecificationSummary)
            BindGalleryQuickReportsItem(3, ProductReportType.TopSalesperson)
            biSalesAnalysis.BindCommand(Sub() ViewModel.ShowAnalysis(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As ProductReportType)
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
            CollectionPresenter.ExpandCollapseGroups()
        End Sub
        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biAddColumns.CheckedChanged
            CollectionPresenter.AddColumns(biAddColumns)
        End Sub
        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biReverseSort.ItemClick
            CollectionPresenter.ReverseSort(colCategory, colName1)
        End Sub
        Private productView As ProductView
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UnsubscribeProductView()
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            productView = TryCast(moduleLocator.GetModule(ModuleType.ProductView), ProductView)
            SubscribeProductView()
            ViewModelHelper.EnsureModuleViewModel(productView, ViewModel, ViewModel.SelectedEntityKey)
            productView.Dock = DockStyle.Fill
            productView.Parent = pnlView
        End Sub
        Private Sub SubscribeProductView()
            If productView IsNot Nothing Then
                AddHandler productView.ZoomLevelChanged, AddressOf productView_ZoomLevelChanged
            End If
        End Sub
        Private Sub UnsubscribeProductView()
            If productView IsNot Nothing Then
                RemoveHandler productView.ZoomLevelChanged, AddressOf productView_ZoomLevelChanged
            End If
        End Sub
        Private Sub InitEditors()
            colCategory.ColumnEdit = EditorHelpers.CreateEnumImageComboBox(Of ProductCategory)(gridControl)
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
            biShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biShowCarousel.BindCommand(Sub() CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel)
            bmiShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowCarousel.BindCommand(Sub() CollectionUIViewModel.ShowCarousel(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub
        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Select Case CollectionUIViewModel.ViewKind
                Case CollectionViewKind.ListView
                    gridControl.MainView = gridView
                Case CollectionViewKind.CardView
                    layoutView.OptionsView.ViewMode = LayoutViewMode.MultiRow
                    gridControl.MainView = layoutView
                Case CollectionViewKind.Carousel
                    layoutView.OptionsView.ViewMode = LayoutViewMode.Carousel
                    gridControl.MainView = layoutView
            End Select
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
            detailItem.Visibility = If(detailHidden, LayoutVisibility.Never, LayoutVisibility.Always)
            If Not detailHidden Then
                If splitterItem.IsVertical <> CollectionUIViewModel.IsHorizontalLayout Then
                    layoutControlGroup1.RotateLayout()
                End If
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
        #Region "ISupportZoom Members"
        Private Property ISupportZoom_ZoomLevel() As Integer Implements ISupportZoom.ZoomLevel
            Get
                Return If(productView IsNot Nothing, productView.ZoomLevel, 100)
            End Get
            Set(ByVal value As Integer)
                If productView IsNot Nothing Then
                    productView.ZoomLevel = value
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
        Private Sub productView_ZoomLevelChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            RaiseZoomLevelChanged()
        End Sub
        Private Sub RaiseZoomLevelChanged()
            Dim handler = TryCast(Events(zoomLevelChanged), System.EventHandler)
            If handler IsNot Nothing Then
                handler(Me, System.EventArgs.Empty)
            End If
        End Sub
        #End Region
        Private Sub gridView_RowStyle(ByVal sender As Object, ByVal e As XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView.RowStyle
            Dim product As Product = TryCast(gridView.GetRow(e.RowHandle), Product)
            If product IsNot Nothing AndAlso (Not product.Available) Then
                e.Appearance.ForeColor = ColorHelper.DisabledTextColor
            End If
        End Sub
        Private Sub layoutView_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
            If e.Column.FieldName <> colImage.FieldName Then
                Return
            End If
            e.DefaultDraw()
            e.Graphics.DrawRectangle(e.Cache.GetPen(layoutView.Appearance.FieldCaption.ForeColor), e.Bounds)
            e.Handled = True
        End Sub
    End Class
End Namespace
