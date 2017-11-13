Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV

Namespace DevExpress.DevAV.Modules

    Partial Public Class CustomerView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedCustomerViewModel))
            InitializeComponent()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            ItemForHomeOffice.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor
            ItemForHomeOffice.AppearanceItemCaption.Options.UseForeColor = True
        End Sub
        Public ReadOnly Overloads Property ViewModel() As CustomerViewModel
            Get
                Return GetViewModel(Of CustomerViewModel)()
            End Get
        End Property
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.OnDisposing()
        End Sub
        Public Property IsHorizontalLayout() As Boolean
            Get
                Return winExplorerView.OptionsView.Style = XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large
            End Get
            Set(ByVal value As Boolean)
                winExplorerView.OptionsView.Style = If(value, XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large, XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium)
            End Set
        End Property
        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateUI(ViewModel.Entity)
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UpdateUI(ViewModel.Entity)
        End Sub
        Private Sub UpdateUI(ByVal customer As Customer)
            If customer IsNot Nothing Then
                If Not Object.Equals(bindingSource.DataSource, customer) Then
                    bindingSource.DataSource = customer
                Else
                    bindingSource.ResetBindings(False)
                End If
                gridControl.DataSource = customer.CustomerStores
            End If
            moduleLayout.Visible = (customer IsNot Nothing)
        End Sub
    End Class
End Namespace
