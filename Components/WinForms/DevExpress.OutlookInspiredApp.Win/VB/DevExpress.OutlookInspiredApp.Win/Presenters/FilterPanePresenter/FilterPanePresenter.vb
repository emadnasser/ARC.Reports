Imports DevExpress.XtraBars.Navigation
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Common.DataModel
Imports System.Linq

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class FilterPanePresenter(Of TEntity As Class, TID, TUnitOfWork As {Class, IUnitOfWork})
        Inherits BasePresenter(Of FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))

        Public Sub New(ByVal navigationBar As OfficeNavigationBar, ByVal viewModel As FilterTreeViewModel(Of TEntity, TID, TUnitOfWork))
            MyBase.New(viewModel)
            Me.navigationBarCore = navigationBar
            If CollectionViewModel IsNot Nothing Then
                SubscribeCollectionViewModelEvents()
            End If
            If OfficeNavigationBar IsNot Nothing Then
                BindItems()
                AddHandler OfficeNavigationBar.SelectedItemChanging, AddressOf navigationBar_SelectedItemChanging
            End If
        End Sub
        Protected Overrides Sub OnDisposing()
            If CollectionViewModel IsNot Nothing Then
                UnsubscribeCollectionViewModelEvents()
            End If
            If OfficeNavigationBar IsNot Nothing Then
                RemoveHandler OfficeNavigationBar.SelectedItemChanging, AddressOf navigationBar_SelectedItemChanging
            End If
            Me.navigationBarCore = Nothing
            MyBase.OnDisposing()
        End Sub
        Private navigationBarCore As OfficeNavigationBar
        Protected ReadOnly Property OfficeNavigationBar() As OfficeNavigationBar
            Get
                Return navigationBarCore
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As CollectionViewModel(Of TEntity, TID, TUnitOfWork)
            Get
                Return ViewModel.CollectionViewModel
            End Get
        End Property
        Protected Overridable Sub SubscribeCollectionViewModelEvents()
            AddHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub
        Protected Overridable Sub UnsubscribeCollectionViewModelEvents()
            RemoveHandler CollectionViewModel.EntitiesCountChanged, AddressOf CollectionViewModel_EntitiesCountChanged
        End Sub
        Private Sub CollectionViewModel_EntitiesCountChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            For Each navItem As NavigationBarItem In OfficeNavigationBar.Items
                navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, CType(navItem.Tag, FilterItemBase))
            Next navItem
        End Sub
        Private Sub navigationBar_SelectedItemChanging(ByVal sender As Object, ByVal e As SelectedItemChangingEventArgs)
            e.Cancel = (e.Item Is allFoldersItem)
        End Sub
        Private Sub BindItems()
            For Each item As FilterItemBase In ViewModel.StaticFilters
                RegisterFilterItem(OfficeNavigationBar, item)
            Next item
            RegisterAllFoldersItem(OfficeNavigationBar)
        End Sub
        Private Sub UpdateSelectedItemByFilter(ByVal item As FilterItemBase)
            Dim result = OfficeNavigationBar.Items.FirstOrDefault(Function(navItem) Object.Equals(navItem.Tag, item))
            If result IsNot Nothing Then
                OfficeNavigationBar.SelectedItem = result
            End If
        End Sub
        Private Sub RegisterFilterItem(ByVal navigationBar As OfficeNavigationBar, ByVal item As FilterItemBase)
            Dim navItem As New NavigationBarItem()
            navItem.Tag = item
            navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, item)
            navItem.Name = "filterItem" & item.Name.Replace(" ", String.Empty)
            navigationBar.Items.Add(navItem)
            navItem.BindCommand(Sub(f) ViewModel.Select(f), ViewModel, Function() (TryCast(item, FilterTreeViewModel(Of TEntity, TID, TUnitOfWork).FilterItem)))
        End Sub
        Private allFoldersItem As NavigationBarItem
        Private Sub RegisterAllFoldersItem(ByVal navigationBar As OfficeNavigationBar)
            allFoldersItem = New NavigationBarItem()
            allFoldersItem.Text = "All Folders"
            allFoldersItem.Name = "itemAllFolders"
            navigationBar.Items.Add(allFoldersItem)
            BindAllFoldersItem(allFoldersItem)
        End Sub
        Protected MustOverride Sub BindAllFoldersItem(ByVal allFoldersItem As NavigationBarItem)
    End Class
End Namespace
