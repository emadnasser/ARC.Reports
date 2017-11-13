Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV

Namespace DevExpress.DevAV.Modules

    Partial Public Class ProductsCustomFilter
        Inherits BaseModuleControl

        Public Sub New(ByVal customFilterViewModel As CustomFilterViewModel)
            MyBase.New(GetType(CustomFilterViewModel), customFilterViewModel)
            InitializeComponent()
            AddHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            bindingSource.DataSource = customFilterViewModel
            BuildFilterColumns()
            BindEditors()
            BindCommands()
            FilterControlWithoutLike.Apply(filterControl)
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.QueryFilterCriteria, AddressOf ViewModel_QueryFilterCriteria
            MyBase.OnDisposing()
        End Sub
        Protected Overrides Sub OnLoad(ByVal ea As System.EventArgs)
            MyBase.OnLoad(ea)
            filterControl.FilterCriteria = ViewModel.FilterCriteria
        End Sub
        Private Sub ViewModel_QueryFilterCriteria(ByVal sender As Object, ByVal e As QueryFilterCriteriaEventArgs)
            e.FilterCriteria = filterControl.FilterCriteria
        End Sub
        Public ReadOnly Overloads Property ViewModel() As CustomFilterViewModel
            Get
                Return GetViewModel(Of CustomFilterViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property
        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Product)(filterControl.FilterColumns)
            builder.AddColumn(Function(e) e.Name).AddColumn(Function(e) e.Available).AddColumn(Function(e) e.Cost).AddColumn(Function(e) e.CurrentInventory).AddColumn(Function(e) e.RetailPrice).AddColumn(Function(e) e.SalePrice).AddDateTimeColumn(Function(e) e.ProductionStart).AddLookupColumn(Function(e) e.Category)
        End Sub
        Private Sub BindEditors()
            Dim errorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
            errorProvider.ContainerControl = Me
            errorProvider.DataSource = bindingSource
        End Sub
        Private Sub BindCommands()
            Me.okBtn.BindCommand(Sub() ViewModel.OK(), ViewModel)
            Me.cancelBtn.BindCommand(Sub() ViewModel.Cancel(), ViewModel)
        End Sub
    End Class
End Namespace
