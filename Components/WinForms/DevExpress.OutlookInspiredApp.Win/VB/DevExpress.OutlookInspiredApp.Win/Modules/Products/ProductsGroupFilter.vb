Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters

Namespace DevExpress.DevAV.Modules

    Partial Public Class ProductsGroupFilter
        Inherits BaseModuleControl

        Private presenterCore As ProductsGroupFilterPresenter
        Public Sub New(ByVal groupFilterViewModel As GroupFilterViewModel)
            MyBase.New(GetType(GroupFilterViewModel), groupFilterViewModel)
            InitializeComponent()
            GroupFiltersListViewAppearances.Apply(winExplorerView)
            presenterCore = CreatePresenter()
            BindEditors()
            BindCommands()
        End Sub
        Protected Overrides Sub OnDisposing()
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Presenter.Load()
        End Sub
        Public ReadOnly Property Presenter() As ProductsGroupFilterPresenter
            Get
                Return presenterCore
            End Get
        End Property
        Protected Overridable Function CreatePresenter() As ProductsGroupFilterPresenter
            Return New ProductsGroupFilterPresenter(winExplorerView, ViewModel)
        End Function
        Public ReadOnly Overloads Property ViewModel() As GroupFilterViewModel
            Get
                Return GetViewModel(Of GroupFilterViewModel)()
            End Get
        End Property
        Private Sub BindEditors()
            bindingSource.DataSource = ViewModel
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
