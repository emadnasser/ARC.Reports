Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters

Namespace DevExpress.DevAV.Modules

    Partial Public Class EmployeesFilterPaneCollapsed
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As EmployeeFilterPanePresenter
        Public Sub New(ByVal collectionViewModel As EmployeeCollectionViewModel)
            MyBase.New(GetType(EmployeesFilterTreeViewModel), New Object() { collectionViewModel })
            InitializeComponent()
            presenterCore = CreatePresenter()
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
        Public ReadOnly Property Presenter() As EmployeeFilterPanePresenter
            Get
                Return presenterCore
            End Get
        End Property
        Protected Overridable Function CreatePresenter() As EmployeeFilterPanePresenter
            Return New EmployeeFilterPanePresenter(navigationBar, ViewModel)
        End Function
        Protected Overridable Sub BindCommands()
            btnNew.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
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
            btnNewLayoutControlItem.Visibility = If(compactLayout, LayoutVisibility.Never, LayoutVisibility.Always)
        End Sub
        #End Region
    End Class
End Namespace
