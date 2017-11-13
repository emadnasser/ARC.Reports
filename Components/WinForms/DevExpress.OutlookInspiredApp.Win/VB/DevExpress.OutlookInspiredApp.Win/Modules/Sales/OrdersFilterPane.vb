Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters

Namespace DevExpress.DevAV.Modules

    Partial Public Class OrdersFilterPane
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As OrderFilterTreeListPresenter
        Public Sub New(ByVal collectionViewModel As OrderCollectionViewModel)
            MyBase.New(GetType(OrdersFilterTreeViewModel), New Object() { collectionViewModel })
            InitializeComponent()
            FiltersTreeListAppearances.Apply(treeList)
            Me.presenterCore = CreatePresenter()
            BindCommands()
        End Sub
        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrdersFilterTreeViewModel
            Get
                Return GetViewModel(Of OrdersFilterTreeViewModel)()
            End Get
        End Property
        Public ReadOnly Property Presenter() As OrderFilterTreeListPresenter
            Get
                Return presenterCore
            End Get
        End Property
        Protected Overridable Function CreatePresenter() As OrderFilterTreeListPresenter
            Return New OrderFilterTreeListPresenter(treeList, ViewModel)
        End Function
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService("Custom Filter", New FilterDialogDocumentManagerService(ModuleType.OrdersCustomFilter))
        End Sub
        Protected Overridable Sub BindCommands()
            btnNewOrder.BindCommand(Sub() Presenter.CollectionViewModel.[New](), Presenter.CollectionViewModel)
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
            btnNewOrderLayoutControlItem.Visibility = If(compactLayout, LayoutVisibility.Never, LayoutVisibility.Always)
        End Sub
        #End Region
    End Class
End Namespace
