Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Modules

    Partial Public Class Customers
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(CustomerCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickReports)
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
            lvEmployees.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor
            lvEmployees.Appearance.FieldCaption.Options.UseForeColor = True
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            CollectionPresenter = CreateCollectionPresenter()
            CollectionPresenter.ReloadEntities(mvvmContext)
            BindCommands()
            InitViewKind()
            InitViewLayout()
        End Sub
        Protected Overrides Sub OnDisposing()
            CollectionPresenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As CustomerCollectionViewModel
            Get
                Return GetViewModel(Of CustomerCollectionViewModel)()
            End Get
        End Property
        Private privateCollectionPresenter As CustomerCollectionPresenter
        Protected Property CollectionPresenter() As CustomerCollectionPresenter
            Get
                Return privateCollectionPresenter
            End Get
            Private Set(ByVal value As CustomerCollectionPresenter)
                privateCollectionPresenter = value
            End Set
        End Property
        Protected Overridable Function CreateCollectionPresenter() As CustomerCollectionPresenter
            Return New CustomerCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.CustomerEditView))
        End Sub
        Private Sub BindCommands()
            biNewCustomer.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewCustomer.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintProfile.BindCommand(Sub() ViewModel.PrintProfile(), ViewModel)
            bmiPrintContactDirectory.BindCommand(Sub() ViewModel.PrintContactDirectory(), ViewModel)
            bmiPrintSalesSummary.BindCommand(Sub() ViewModel.PrintSalesSummary(), ViewModel)
            bmiPrintSalesDetail.BindCommand(Sub() ViewModel.PrintSalesDetail(), ViewModel)
            BindGalleryQuickReportsItem(0, CustomerReportType.SalesSummary)
            BindGalleryQuickReportsItem(1, CustomerReportType.LocationsDirectory)
            BindGalleryQuickReportsItem(2, CustomerReportType.SelectedContactDirectory)
            biSalesAnalysis.BindCommand(Sub() ViewModel.ShowAnalysis(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
        Private Sub BindGalleryQuickReportsItem(ByVal index As Integer, ByVal parameter As CustomerReportType)
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
            CollectionPresenter.ReverseSort(colName, colName1)
        End Sub
        Private customerView As CustomerView
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            customerView = TryCast(moduleLocator.GetModule(ModuleType.CustomerView), CustomerView)
            ViewModelHelper.EnsureModuleViewModel(customerView, ViewModel, ViewModel.SelectedEntityKey)
            customerView.Dock = DockStyle.Fill
            customerView.Parent = pnlView
            gridView.ExpandMasterRow(0)
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
            bmiShowCard.BindCommand(Sub() CollectionUIViewModel.ShowCard(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
        End Sub
        Private Sub ViewModel_ViewKindChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If CollectionUIViewModel.ViewKind = CollectionViewKind.CardView Then
                gridControl.MainView = layoutView
            Else
                gridControl.MainView = gridView
                gridView.ExpandMasterRow(0)
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
            detailItem.Visibility = If(detailHidden, LayoutVisibility.Never, LayoutVisibility.Always)
            If Not detailHidden Then
                If splitterItem.IsVertical <> CollectionUIViewModel.IsHorizontalLayout Then
                    layoutControlGroup1.RotateLayout()
                End If
                customerView.IsHorizontalLayout = CollectionUIViewModel.IsHorizontalLayout
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
        Private Sub lvEmployees_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles lvEmployees.CustomDrawCardFieldValue
            If e.Column.FieldName <> colPhoto.FieldName Then
                Return
            End If
            e.DefaultDraw()
            e.Graphics.DrawRectangle(e.Cache.GetPen(lvEmployees.Appearance.FieldCaption.ForeColor), e.Bounds)
            e.Handled = True
        End Sub
    End Class
End Namespace
