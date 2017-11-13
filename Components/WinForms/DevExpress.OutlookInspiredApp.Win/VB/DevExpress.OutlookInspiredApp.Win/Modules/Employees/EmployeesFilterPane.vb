Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters

Namespace DevExpress.DevAV.Modules

    Partial Public Class EmployeesFilterPane
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As EmployeeFilterTreeListPresenter
        Public Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(GetType(EmployeesFilterTreeViewModel), New Object() { collectionViewModel })
            InitializeComponent()
            FiltersTreeListAppearances.Apply(treeList)
            Me.presenterCore = CreatePresenter()
            BindCommands()
        End Sub
        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As EmployeesFilterTreeViewModel
            Get
                Return GetViewModel(Of EmployeesFilterTreeViewModel)()
            End Get
        End Property
        Public ReadOnly Property Presenter() As EmployeeFilterTreeListPresenter
            Get
                Return presenterCore
            End Get
        End Property
        Protected Overridable Function CreatePresenter() As EmployeeFilterTreeListPresenter
            Return New EmployeeFilterTreeListPresenter(treeList, ViewModel)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("Custom Filter", New FilterDialogDocumentManagerService(ModuleType.EmployeesCustomFilter))
            mvvmContext.RegisterService("Group Filter", New FilterDialogDocumentManagerService(ModuleType.EmployeesGroupFilter))
        End Sub
        Protected Overridable Sub BindCommands()
            btnNewEmployee.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
        End Sub
        #Region "ISupportCompactLayout Members"
        Private compactLayout As Boolean = True
        Private Property ISupportCompactLayout_Compact() As Boolean Implements ISupportCompactLayout.Compact
            Get
                Return compactLayout
            End Get
            Set(ByVal value As Boolean)
                If compactLayout = value Then
                    Return
                End If
                compactLayout = value
                UpdateCompactLayout()
            End Set
        End Property
        Private Sub UpdateCompactLayout()
            btnNewEmployeeLayoutControlItem.Visibility = If(compactLayout, LayoutVisibility.Never, LayoutVisibility.Always)
        End Sub
        #End Region
    End Class
End Namespace
