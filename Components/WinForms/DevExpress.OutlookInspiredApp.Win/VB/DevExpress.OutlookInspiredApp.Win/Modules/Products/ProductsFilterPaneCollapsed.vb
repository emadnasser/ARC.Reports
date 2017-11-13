Imports DevExpress.XtraLayout.Utils
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters

Namespace DevExpress.DevAV.Modules

    Partial Public Class ProductsFilterPaneCollapsed
        Inherits BaseModuleControl
        Implements ISupportCompactLayout

        Private presenterCore As ProductFilterPanePresenter
        Public Sub New(ByVal collectionViewModel As ProductCollectionViewModel)
            MyBase.New(GetType(ProductsFilterTreeViewModel), New Object() { collectionViewModel })
            InitializeComponent()
            presenterCore = CreatePresenter()
            BindCommands()
        End Sub
        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As ProductsFilterTreeViewModel
            Get
                Return GetViewModel(Of ProductsFilterTreeViewModel)()
            End Get
        End Property
        Public ReadOnly Property Presenter() As ProductFilterPanePresenter
            Get
                Return presenterCore
            End Get
        End Property
        Protected Overridable Function CreatePresenter() As ProductFilterPanePresenter
            Return New ProductFilterPanePresenter(navigationBar, ViewModel)
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