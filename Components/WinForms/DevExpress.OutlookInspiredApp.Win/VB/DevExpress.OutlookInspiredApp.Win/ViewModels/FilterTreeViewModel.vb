Imports System.Linq.Expressions
Imports DevExpress.Data.Utils
Imports System.Collections.ObjectModel
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Common.Utils
Imports DevExpress.DevAV.Common.DataModel
Imports DevExpress.Data.Filtering
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System.Collections
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class FilterTreeViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As {Class, IUnitOfWork})
        Inherits FilterTreeViewModelBase

        Public Const StaticFiltersName As String = "Favorites"
        Public Const CustomFiltersName As String = "Custom Filters"
        Public Const GroupFiltersName As String = "Groups"


        Public Sub New(ByVal collectionViewModel_Renamed As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork), ByVal settings As IFilterTreeModelPageSpecificSettings)
            MyBase.New(settings)
            SetViewModel(collectionViewModel_Renamed)
            ViewModelHelper.EnsureViewModel(Me, collectionViewModel_Renamed)
            Init()
            Dim scf As ISupportCustomFilters = TryCast(collectionViewModel_Renamed, ISupportCustomFilters)
            If scf IsNot Nothing Then
                AddHandler scf.CustomFiltersReset, AddressOf scf_CustomFiltersReset
            End If
        End Sub
        Private Sub scf_CustomFiltersReset(ByVal sender As Object, ByVal e As EventArgs)
            ResetCustomFilters()
        End Sub
        Protected Friend ReadOnly Property CollectionViewModel() As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork)
            Get
                Return DirectCast(ViewModel, CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork))
            End Get
        End Property
        Protected Overridable Sub OnSelectedItemChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.Select(Nothing))
            RaiseSelectedItemChanged()
            ApplyFilter(SelectedItem)
        End Sub
        Public Function CanSelectModule(ByVal item As FilterItem) As Boolean
            Return SelectedItem IsNot item
        End Function
        <Command>
        Public Sub [Select](ByVal item As FilterItem)
            SelectedItem = item
        End Sub
        Public Event SelectedItemChanged As EventHandler
        Private Sub RaiseSelectedItemChanged()
            RaiseEvent SelectedItemChanged(Me, EventArgs.Empty)
        End Sub

        Private Sub ApplyFilter(ByVal filterItem_Renamed As FilterItemBase)
            If filterItem_Renamed IsNot Nothing AndAlso (Not Object.ReferenceEquals(filterItem_Renamed.FilterCriteria, Nothing)) Then
                CollectionViewModel.FilterExpression = GetFilterExpression(filterItem_Renamed)
            Else
                CollectionViewModel.FilterExpression = Nothing
            End If
        End Sub
        Public Event FilterTreeChanged As EventHandler
        Private Sub RaiseFilterTreeChanged()
            RaiseEvent FilterTreeChanged(Me, EventArgs.Empty)
        End Sub
        Protected Overrides Function CreateFilterItem(ByVal name As String, ByVal filterCriteria As CriteriaOperator, ByVal imageUri As String) As FilterItemBase
            Return FilterItem.Create(name, filterCriteria)
        End Function
        <Command>
        Public Sub [New]()
            Dim newFilterItem = CreateFilterItem(Nothing, Nothing, Nothing)

            Dim viewModel_Renamed As CustomFilterViewModel = CreateCustomFilterViewModel(Of CustomFilterViewModel)(newFilterItem)
            If ShowFilterDialog(viewModel_Renamed, "Custom Filter") Then
                If viewModel_Renamed.Save Then
                    AddNewCustomFilter(newFilterItem)
                    RaiseFilterTreeChanged()
                End If
                SelectedItem = newFilterItem
            End If
        End Sub
        <Command>
        Public Sub Modify(ByVal item As FilterItem)

            Dim viewModel_Renamed As CustomFilterViewModel = CreateCustomFilterViewModel(Of CustomFilterViewModel)(item)
            If ShowFilterDialog(viewModel_Renamed, "Custom Filter") Then
                If viewModel_Renamed.Save Then
                    SaveCustomFilters()
                    RaiseFilterTreeChanged()
                End If
                ApplyFilter(item)
            End If
        End Sub
        <Command>
        Public Sub Delete(ByVal item As FilterItem)
            DeleteCustomFilter(item)
            RaiseFilterTreeChanged()
            If SelectedItem Is item Then
                SelectedItem = Nothing
            End If
        End Sub
        <Command>
        Public Sub NewGroup()
            NewGroupCore(CreateFilterItem(Nothing, Nothing, Nothing))
        End Sub
        <Command>
        Public Sub NewGroupFromSelection(ByVal selection As IEnumerable(Of TEntity))
            NewGroupCore(CreateFilterItem(Nothing, CollectionViewModel.GetInOperator(selection), Nothing))
        End Sub

        Public Overridable Property Groups() As ObservableCollection(Of FilterItemBase)

        Public Overridable Sub AddNewGroupFilter(ByVal filterItem_Renamed As FilterItemBase)
            Groups.Add(filterItem_Renamed)
            SaveGroupFilters()
        End Sub

        Public Overridable Sub DeleteGroupFilter(ByVal filterItem_Renamed As FilterItemBase)
            Groups.Remove(filterItem_Renamed)
            SaveGroupFilters()
        End Sub

        Public Overridable Sub ModifyGroupFilter(ByVal filterItem_Renamed As FilterItemBase)
            SaveGroupFilters()
        End Sub
        Private Sub SaveGroupFilters()
            settings.GroupFilters = SaveToSettings(Groups)
            settings.Settings.Save()
        End Sub

        Public Overrides Sub Init()
            Groups = CreateFilterItems(settings.GroupFilters)
            MyBase.Init()
        End Sub

        Private Sub NewGroupCore(ByVal newFilterItem As FilterItemBase)

            Dim viewModel_Renamed As GroupFilterViewModel = CreateCustomFilterViewModel(Of GroupFilterViewModel)(newFilterItem)
            If ShowFilterDialog(viewModel_Renamed, "Group Filter") Then
                If viewModel_Renamed.Save Then
                    AddNewGroupFilter(newFilterItem)
                    RaiseFilterTreeChanged()
                End If
                SelectedItem = newFilterItem
            End If
        End Sub
        <Command>
        Public Sub ModifyGroup(ByVal item As FilterItem)

            Dim viewModel_Renamed As GroupFilterViewModel = CreateCustomFilterViewModel(Of GroupFilterViewModel)(item)
            If ShowFilterDialog(viewModel_Renamed, "Group Filter") Then
                If viewModel_Renamed.Save Then
                    ModifyGroupFilter(item)
                    RaiseFilterTreeChanged()
                End If
                ApplyFilter(item)
            End If
        End Sub
        <Command>
        Public Sub DeleteGroup(ByVal item As FilterItem)
            DeleteGroupFilter(item)
            RaiseFilterTreeChanged()
            If SelectedItem Is item Then
                SelectedItem = Nothing
            End If
        End Sub
        Public Overrides Sub ResetCustomFilters()
            MyBase.ResetCustomFilters()
            RaiseFilterTreeChanged()
        End Sub

        Protected Overridable Function CreateCustomFilterViewModel(Of T As {FilterViewModelBase, New})(ByVal filterItem_Renamed As FilterItemBase) As T

            Dim viewModel_Renamed As T = ViewModelSource.Create(Of T)()
            ViewModelHelper.EnsureViewModel(viewModel_Renamed, CollectionViewModel, filterItem_Renamed)
            Return viewModel_Renamed
        End Function
        Private Function ShowFilterDialog(ByVal viewModel As FilterViewModelBase, ByVal key As String) As Boolean
            Dim service = Me.GetService(Of IDocumentManagerService)(key)
            If service IsNot Nothing Then
                Dim document = service.CreateDocument(key, viewModel, Nothing, CollectionViewModel)
                viewModel.Document = document
                document.Show()
                Return viewModel.Result.GetValueOrDefault()
            End If
            Return False
        End Function
        Protected Overridable ReadOnly Property EnableGroups() As Boolean
            Get
                Return True
            End Get
        End Property
        Public Function GetFilterName(ByVal filtersCollection As Object, ByVal filter As FilterItemBase) As String
            If filter IsNot Nothing Then
                Dim count = CollectionViewModel.GetEntities(GetFilterExpression(filter)).Count()
                If count > 0 Then
                    Return filter.Name & " (" & count & ")"
                Else
                    Return filter.Name
                End If
            Else
                If Object.Equals(filtersCollection, StaticFilters) Then
                    Return StaticFiltersName
                End If
                If Object.Equals(filtersCollection, CustomFilters) Then
                    Return CustomFiltersName
                End If
                If Object.Equals(filtersCollection, Groups) Then
                    Return GroupFiltersName
                End If
            End If
            Return Nothing
        End Function
        Public Function GetСhildren(ByVal dataItem As Object) As IList
            If dataItem Is Me Then
                If EnableGroups Then
                    Return DirectCast(New List(Of Object) From {StaticFilters, CustomFilters, Groups}, IList)
                Else
                    Return DirectCast(New List(Of Object) From {StaticFilters, CustomFilters}, IList)
                End If
            End If
            If TypeOf dataItem Is System.Collections.ObjectModel.ObservableCollection(Of FilterItemBase) Then
                Return DirectCast(dataItem, IList)
            End If
            Return Nothing
        End Function
        Friend Shared Function GetFilterExpression(ByVal criteria As CriteriaOperator) As Expression(Of Func(Of TEntity, Boolean))
            Try
                Return CriteriaOperatorToExpressionConverter.GetGenericWhere(Of TEntity)(criteria)
            Catch e As Exception
                Throw New NotSupportedException("Error in Filter:" & CriteriaOperator.ToString(criteria), e)
            End Try
        End Function
        Private Shared Function GetFilterExpression(ByVal filter As FilterItemBase) As Expression(Of Func(Of TEntity, Boolean))
            Return GetFilterExpression(filter.FilterCriteria)
        End Function
        #Region "Filter Item ViewModels"
        Public Class FilterItem
            Inherits FilterItemBase

            Public Shared Function Create(ByVal name As String, ByVal filterCriteria As CriteriaOperator) As FilterItem
                Return ViewModelSource.Create(Function() New FilterItem(name, filterCriteria))
            End Function
            Protected Sub New(ByVal name As String, ByVal filterCriteria As CriteriaOperator)
                Me.Name = name
                Me.FilterCriteria = filterCriteria
            End Sub
        End Class
        #End Region ' Items
    End Class
    #Region "Custom Filter ViewModel"
    <POCOViewModelAttribute(ImplementIDataErrorInfo := True)>
    Public MustInherit Class FilterViewModelBase
        Implements ISupportParameter

        Public Sub New()
            Save = True
        End Sub
        Private filterItem As FilterItemBase
        Public Property Document() As IDocument
        Private privateResult? As Boolean
        Public Property Result() As Boolean?
            Get
                Return privateResult
            End Get
            Private Set(ByVal value? As Boolean)
                privateResult = value
            End Set
        End Property
        Public Overridable Property Save() As Boolean
        <Required>
        Public Overridable Property Name() As String
        Public ReadOnly Property FilterCriteria() As CriteriaOperator
            Get
                Return filterItem.FilterCriteria
            End Get
        End Property
        Public Event QueryFilterCriteria As EventHandler(Of QueryFilterCriteriaEventArgs)
        Private Sub RaiseQueryFilterCriteria()
            Dim handler As EventHandler(Of QueryFilterCriteriaEventArgs) = QueryFilterCriteriaEvent
            If handler IsNot Nothing Then
                handler(Me, New QueryFilterCriteriaEventArgs(filterItem))
            End If
        End Sub
        Protected ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return Me.GetService(Of IMessageBoxService)()
            End Get
        End Property
        Protected MustOverride Function GetDefaultName() As String
        <Command>
        Public Sub OK()
            Result = True
            If String.IsNullOrEmpty(Name) Then
                Name = GetDefaultName()
            End If
            If Save Then
                filterItem.Name = Name
            End If
            RaiseQueryFilterCriteria()
            Document.Close()
        End Sub
        <Command>
        Public Sub Cancel()
            Result = False
            Document.Close()
        End Sub
        Private Property ISupportParameter_Parameter() As Object Implements ISupportParameter.Parameter
            Get
                Return filterItem
            End Get
            Set(ByVal value As Object)
                filterItem = DirectCast(value, FilterItemBase)
                Name = filterItem.Name
            End Set
        End Property
    End Class
    Public Class QueryFilterCriteriaEventArgs
        Inherits EventArgs

        Private item As FilterItemBase
        Public Sub New(ByVal item As FilterItemBase)
            Me.item = item
        End Sub
        Public Property FilterCriteria() As CriteriaOperator
            Get
                Return item.FilterCriteria
            End Get
            Set(ByVal value As CriteriaOperator)
                item.FilterCriteria = value
            End Set
        End Property
    End Class
    Public Class CustomFilterViewModel
        Inherits FilterViewModelBase

        Private Shared id As Integer = 0
        Protected Overrides Function GetDefaultName() As String
            Dim tempVar As Integer = id
            id += 1
            Return "Custom Filter " & (tempVar).ToString()
        End Function
    End Class
    Public Class GroupFilterViewModel
        Inherits FilterViewModelBase

        Private Shared id As Integer = 0
        Protected Overrides Function GetDefaultName() As String
            Dim tempVar As Integer = id
            id += 1
            Return "Group " & (tempVar).ToString()
        End Function
    End Class
    #End Region
End Namespace
