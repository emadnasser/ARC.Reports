Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.DevAV.Common.DataModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DevExpress.DevAV.Common.ViewModel
    Partial Public Class CollectionViewModel(Of TEntity As Class, TPrimaryKey, TUnitOfWork As IUnitOfWork)
        Implements ISupportParameter, IDocumentContent

        Protected Overrides Sub OnInitializeInRuntime()
            MyBase.OnInitializeInRuntime()
            Messenger.Default.Register(Of SelectedItemSynchronizationMessage(Of TEntity))(Me, Sub(x) OnSelectedItemSynchronizationMessage(x))
            Messenger.Default.Register(Of EntityMessage(Of TEntity, TPrimaryKey))(Me, Sub(x) OnEntityMessage(x))
        End Sub
        Private Sub OnEntityMessage(ByVal m As EntityMessage(Of TEntity, TPrimaryKey))
            If m.MessageType = EntityMessageType.Changed Then
                Dim entity As TEntity = DirectCast(ChangeTracker, EntitiesChangeTracker(Of TPrimaryKey)).FindLocalProjectionByKey(m.PrimaryKey)
                If entity IsNot Nothing Then
                    OnEntityChanged(entity)
                End If
                RaiseEntityChanged(m.PrimaryKey)
            Else
                RaiseEntitiesCountChanged(Entities.Count)
            End If
        End Sub
        Protected Overridable Sub OnEntityChanged(ByVal entity As TEntity)
        End Sub
        Protected Overrides Sub OnIsLoadingChanged()
            MyBase.OnIsLoadingChanged()
            If Not IsLoading Then
                RaiseEntitiesCountChanged(Entities.Count)
            End If
        End Sub
        Public Event EntitiesCountChanged As EventHandler(Of EntitiesCountEventArgs)
        Public Event EntityChanged As EventHandler(Of EntityEventArgs(Of TPrimaryKey))
        Private Sub RaiseEntityChanged(ByVal key As TPrimaryKey)
            Dim handler As EventHandler(Of EntityEventArgs(Of TPrimaryKey)) = EntityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, New EntityEventArgs(Of TPrimaryKey)(key))
            End If
        End Sub
        Private Sub RaiseEntitiesCountChanged(ByVal count As Integer)
            Dim handler As EventHandler(Of EntitiesCountEventArgs) = EntitiesCountChangedEvent
            If handler IsNot Nothing Then
                handler(Me, New EntitiesCountEventArgs(count))
            End If
        End Sub
        <Command, Display(AutoGenerateField := False)>
        Public Overridable Sub OnLoaded()
        End Sub
        Public Event SelectedEntityChanged As EventHandler
        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            Messenger.Default.Send(New SelectedItemSynchronizationMessage(Of TEntity)(SelectedEntity))
            RaiseEvent SelectedEntityChanged(Me, EventArgs.Empty)
        End Sub
        Private Sub OnSelectedItemSynchronizationMessage(ByVal message As SelectedItemSynchronizationMessage(Of TEntity))
        End Sub
        Public Event ParameterChanged As EventHandler
        Protected Overridable Function GetTitle() As Object
            Return Nothing
        End Function
        #Region "ISupportParameter"
        Private parameterCore As Object
        Protected Property Parameter() As Object
            Get
                Return parameterCore
            End Get
            Private Set(ByVal value As Object)
                parameterCore = value
                Dim handler As EventHandler = ParameterChangedEvent
                If handler IsNot Nothing Then
                    handler(Me, EventArgs.Empty)
                End If
            End Set
        End Property
        Private Property ISupportParameter_Parameter() As Object Implements ISupportParameter.Parameter
            Get
                Return Parameter
            End Get
            Set(ByVal value As Object)
                Parameter = value
            End Set
        End Property
        #End Region
        Protected ReadOnly Property DocumentManagerService() As IDocumentManagerService
            Get
                Return GetDocumentManagerService()
            End Get
        End Property
        Protected Function FindDocument(Of TViewModel)() As IDocument
            If DocumentManagerService Is Nothing Then
                Return Nothing
            End If
            Return DocumentManagerService.Documents.FirstOrDefault(Function(d) TypeOf d.Content Is TViewModel)
        End Function
        Protected Function FindDocument(Of TViewModel)(ByVal key As TPrimaryKey) As IDocument
            If DocumentManagerService Is Nothing Then
                Return Nothing
            End If
            For Each document As IDocument In DocumentManagerService.Documents
                Dim entityViewModel As ISingleObjectViewModel(Of TEntity, TPrimaryKey) = TryCast(document.Content, ISingleObjectViewModel(Of TEntity, TPrimaryKey))
                If entityViewModel IsNot Nothing AndAlso TypeOf entityViewModel Is TViewModel AndAlso Object.Equals(entityViewModel.PrimaryKey, key) Then
                    Return document
                End If
            Next document
            Return Nothing
        End Function
        Public ReadOnly Property SelectedEntityKey() As TPrimaryKey
            Get
                Return If(SelectedEntity IsNot Nothing, CreateRepository().GetPrimaryKey(SelectedEntity), Nothing)
            End Get
        End Property
        Public Overridable Function GetEntities(Optional ByVal filter As Expression(Of Func(Of TEntity, Boolean)) = Nothing) As IQueryable(Of TEntity)
            Try
                Return getRepositoryFunc(CreateUnitOfWork()).GetFilteredEntities(filter)
            Catch e As Exception
                Throw New NotSupportedException("Error in Expression:" & filter.ToString(), e)
            End Try
        End Function
        Public Function GetInOperator(ByVal entities As IEnumerable(Of TEntity)) As Data.Filtering.CriteriaOperator
            Dim keyName As String = CType(CreateRepository().GetPrimaryKeyExpression.Body, MemberExpression).Member.Name
            Return New Data.Filtering.InOperator(keyName, entities.Select(Function(e) CreateRepository().GetPrimaryKey(e)))
        End Function
    End Class
End Namespace
