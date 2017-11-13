Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV

Namespace DevExpress.DevAV.Modules

    Partial Public Class CustomersCustomFilter
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
        Public ReadOnly Property CollectionViewModel() As CustomerCollectionViewModel
            Get
                Return GetParentViewModel(Of CustomerCollectionViewModel)()
            End Get
        End Property
        Private Sub BuildFilterColumns()
            Dim builder = New FilterColumnCollectionBuilder(Of Customer)(filterControl.FilterColumns)
            builder.AddColumn(Function(c) c.Name).AddColumn(Function(c) c.HomeOffice.Line).AddColumn(Function(c) c.Phone).AddColumn(Function(c) c.Fax).AddColumn(Function(c) c.Website).AddColumn(Function(c) c.TotalEmployees).AddColumn(Function(c) c.TotalStores).AddLookupColumn(Function(c) c.Status).AddLookupColumn(Function(c) c.HomeOffice.State)
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
