Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV
Imports System.Windows.Forms

Namespace DevExpress.DevAV.Modules

    Partial Public Class Employees
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(EmployeeCollectionViewModel))
            InitializeComponent()
            GalleryItemAppearances.Apply(galleryQuickLetters)
            layoutView.Appearance.FieldCaption.ForeColor = ColorHelper.DisabledTextColor
            layoutView.Appearance.FieldCaption.Options.UseForeColor = True
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
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As EmployeeCollectionViewModel
            Get
                Return GetViewModel(Of EmployeeCollectionViewModel)()
            End Get
        End Property
        Private privateCollectionPresenter As EmployeeCollectionPresenter
        Protected Property CollectionPresenter() As EmployeeCollectionPresenter
            Get
                Return privateCollectionPresenter
            End Get
            Private Set(ByVal value As EmployeeCollectionPresenter)
                privateCollectionPresenter = value
            End Set
        End Property
        Protected Overridable Function CreateCollectionPresenter() As EmployeeCollectionPresenter
            Return New EmployeeCollectionPresenter(gridControl, ViewModel, AddressOf UpdateEntitiesCountRelatedUI)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("View Settings", New ViewSettingsDialogDocumentManagerService(Function() CollectionUIViewModel))
            mvvmContext.RegisterService(New DetailFormDocumentManagerService(ModuleType.EmployeeEditView))
        End Sub
        Private Sub BindCommands()
            biNewEmployee.BindCommand(Sub() ViewModel.[New](), ViewModel)
            biNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            bmiNewEmployee.BindCommand(Sub() ViewModel.[New](), ViewModel)
            bmiNewGroup.BindCommand(Sub() ViewModel.GroupSelection(), ViewModel)
            biEdit.BindCommand(Sub(e) ViewModel.Edit(e), ViewModel, Function() ViewModel.SelectedEntity)
            biDelete.BindCommand(Sub(e) ViewModel.Delete(e), ViewModel, Function() ViewModel.SelectedEntity)
            biMap.BindCommand(Sub() ViewModel.ShowMap(), ViewModel)
            biNewCustomFilter.BindCommand(Sub() ViewModel.NewCustomFilter(), ViewModel)
            bmiPrintProfile.BindCommand(Sub() ViewModel.PrintProfile(), ViewModel)
            bmiPrintSummary.BindCommand(Sub() ViewModel.PrintSummary(), ViewModel)
            bmiPrintDirectory.BindCommand(Sub() ViewModel.PrintDirectory(), ViewModel)
            bmiPrintTaskList.BindCommand(Sub() ViewModel.PrintTaskList(), ViewModel)
            biMailMerge.BindCommand(Sub() ViewModel.MailMerge(), ViewModel)
            BindGalleryQuickLettersItem(0, EmployeeMailTemplate.ThankYouNote)
            BindGalleryQuickLettersItem(1, EmployeeMailTemplate.EmployeeOfTheMonth)
            BindGalleryQuickLettersItem(2, EmployeeMailTemplate.ServiceExcellence)
            BindGalleryQuickLettersItem(3, EmployeeMailTemplate.ProbationNotice)
            BindGalleryQuickLettersItem(4, EmployeeMailTemplate.WelcomeToDevAV)
            biMeeting.BindCommand(Sub() ViewModel.ShowMeeting(), ViewModel)
            biTask.BindCommand(Sub() ViewModel.ShowTask(), ViewModel)
            biViewSettings.BindCommand(Sub() ViewModel.ShowViewSettings(), ViewModel)
        End Sub
        Private Sub BindGalleryQuickLettersItem(ByVal index As Integer, ByVal parameter As EmployeeMailTemplate)
            galleryQuickLetters.Gallery.Groups(0).Items(index).BindCommand(Sub() ViewModel.QuickLetter(parameter), ViewModel, Function() parameter)
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
            CollectionPresenter.ReverseSort(colDepartment, colFullName1)
        End Sub
        Private employeeView As EmployeeView
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            employeeView = TryCast(moduleLocator.GetModule(ModuleType.EmployeeView), EmployeeView)
            ViewModelHelper.EnsureModuleViewModel(employeeView, ViewModel, ViewModel.SelectedEntityKey)
            employeeView.Dock = DockStyle.Fill
            employeeView.Parent = pnlView
        End Sub
        Private Sub InitEditors()
            colPrefix.ColumnEdit = EditorHelpers.CreatePersonPrefixImageComboBox(Nothing, gridControl.RepositoryItems)
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
                employeeView.IsHorizontalLayout = CollectionUIViewModel.IsHorizontalLayout
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
        Private Sub layoutView_CustomDrawCardFieldValue(ByVal sender As Object, ByVal e As XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles layoutView.CustomDrawCardFieldValue
            If e.Column IsNot colPhoto Then
                Return
            End If
            e.DefaultDraw()
            e.Graphics.DrawRectangle(e.Cache.GetPen(layoutView.Appearance.FieldCaption.ForeColor), e.Bounds)
            e.Handled = True
        End Sub
    End Class
End Namespace
