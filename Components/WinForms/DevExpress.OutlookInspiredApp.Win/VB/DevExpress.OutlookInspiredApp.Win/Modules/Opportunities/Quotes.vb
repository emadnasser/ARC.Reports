Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.MVVM
Imports DevExpress.DevAV.ViewModels
Imports System.Windows.Forms
Imports System.Linq
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class Quotes
        Inherits BaseModuleControl
        Implements IRibbonModule

        Private entitiesBinding As IPropertyBinding
        Public Sub New()
            MyBase.New(GetType(QuoteCollectionViewModel))
            InitializeComponent()
            CollectionUIViewModel = DevExpress.Mvvm.POCO.ViewModelSource.Create(Of CollectionUIViewModel)()
            entitiesBinding = mvvmContext.SetBinding(pivotGridControl, Function(p) p.DataSource, "Entities")
            OnReloadEntities()
            AddHandler ViewModel.Reload, AddressOf ViewModel_Reload
            AddHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
            BindCommands()
            InitViewKind()
            InitViewLayout()
            InitEditors()
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.EntitiesCountChanged, AddressOf ViewModel_EntitiesCountChanged
            RemoveHandler ViewModel.Reload, AddressOf ViewModel_Reload
            entitiesBinding.Dispose()
            MyBase.OnDisposing()
        End Sub
        Private Sub ViewModel_Reload(ByVal sender As Object, ByVal e As System.EventArgs)
            OnReloadEntities()
        End Sub
        Private Sub ViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub
        Private Sub OnReloadEntities()
            UpdateEntitiesCountRelatedUI(ViewModel.Entities.Count)
        End Sub
        Private Sub UpdateEntitiesCountRelatedUI(ByVal count As Integer)
            hiItemsCount.Caption = String.Format("RECORDS: {0}", count)
            UpdateAdditionalButtons(count > 0)
        End Sub
        Public ReadOnly Overloads Property ViewModel() As QuoteCollectionViewModel
            Get
                Return GetViewModel(Of QuoteCollectionViewModel)()
            End Get
        End Property
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New NotImplementedDetailFormDocumentManagerService(ModuleType.QuoteEditView))
        End Sub
        Private Sub BindCommands()
            biNewQuote.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.Enabled = False
            bmiNewQuote.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.Enabled = False
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintInvoice.Enabled = False
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
        Private quoteView As QuoteView
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            quoteView = TryCast(moduleLocator.GetModule(ModuleType.QuoteView), QuoteView)
            ViewModelHelper.EnsureModuleViewModel(quoteView, ViewModel, ViewModel.SelectedEntityKey)
            quoteView.Dock = DockStyle.Fill
            quoteView.Parent = pnlView
            quoteView.DataSource = ViewModel.GetOpportunities()
        End Sub
        Private Sub InitEditors()
            dateTimeChartRangeControlClient.DataProvider.DataSource = ViewModel.GetEntities().ToList()
            dateTimeChartRangeControlClient.DataProvider.ValueDataMember = "Total"
            dateTimeChartRangeControlClient.DataProvider.ArgumentDataMember = "Date"
            AddHandler rangeControl.RangeChanged, AddressOf rangeControl_RangeChanged
        End Sub
        Private Sub rangeControl_RangeChanged(ByVal sender As Object, ByVal range As RangeControlRangeEventArgs)
            Dim min As Date = CDate(range.Range.Minimum)
            Dim max As Date = CDate(range.Range.Maximum)
            ViewModel.FilterExpression = Function(e) (e.Date > min) AndAlso (e.Date < max)
            quoteView.DataSource = ViewModel.GetOpportunities()
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
            biShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            bmiShowList.BindCommand(Sub() CollectionUIViewModel.ShowList(), CollectionUIViewModel)
            biResetView.BindCommand(Sub() CollectionUIViewModel.ResetView(), CollectionUIViewModel)
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
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
        Private allExpanded As Boolean = True
        Private Sub UpdateAdditionalButtons(ByVal hasRecords As Boolean)
            biReverseSort.Enabled = hasRecords
            biExpandCollapse.Enabled = hasRecords AndAlso (CollectionUIViewModel.ViewKind = CollectionViewKind.ListView)
            biAddColumns.Enabled = biExpandCollapse.Enabled
        End Sub
        Private Sub biExpandCollapse_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biExpandCollapse.ItemClick
            If allExpanded Then
                pivotGridControl.CollapseAllRows()
            Else
                pivotGridControl.ExpandAllRows()
            End If
            allExpanded = Not allExpanded
        End Sub
        Private Sub biAddColumns_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biAddColumns.CheckedChanged
            If Not biAddColumns.Checked Then
                pivotGridControl.DestroyCustomization()
            Else
                pivotGridControl.FieldsCustomization()
                AddHandler pivotGridControl.HideCustomizationForm, AddressOf pivotGridControl_HideCustomizationForm
            End If
        End Sub
        Private Sub pivotGridControl_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs)
            RemoveHandler pivotGridControl.HideCustomizationForm, AddressOf pivotGridControl_HideCustomizationForm
            biAddColumns.Checked = False
        End Sub
        Private Sub biReverseSort_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biReverseSort.ItemClick
            pivotGridControl.ChangeFieldSortOrderAsync(fieldCity)
        End Sub
        Private Sub pivotGridControl_CustomCellValue(ByVal sender As Object, ByVal e As XtraPivotGrid.PivotCellValueEventArgs) Handles pivotGridControl.CustomCellValue
            If e.DataField Is fieldPercentage Then
                e.Value = Convert.ToDouble(e.Value) * 100
            End If
        End Sub
    End Class
End Namespace
