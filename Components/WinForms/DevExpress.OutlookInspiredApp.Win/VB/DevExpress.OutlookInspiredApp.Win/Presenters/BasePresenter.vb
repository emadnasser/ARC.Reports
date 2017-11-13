Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports System.Linq

Namespace DevExpress.DevAV.Presenters
'    using IServiceContainer = DevExpress.Mvvm.IServiceContainer

    Public MustInherit Class BasePresenter(Of TViewModel As Class)
        Public Sub New(ByVal viewModel As TViewModel)
            Me.viewModelCore = viewModel
        End Sub
        Private isDisposing As Boolean
        Public Sub Dispose()
            If Not isDisposing Then
                isDisposing = True
                OnDisposing()
                Me.viewModelCore = Nothing
            End If
        End Sub
        Private viewModelCore As TViewModel
        Public ReadOnly Property ViewModel() As TViewModel
            Get
                Return viewModelCore
            End Get
        End Property
        Protected Function GetParentViewModel(Of TParentViewModel)() As TParentViewModel
            Return CType(DirectCast(viewModelCore, ISupportParentViewModel).ParentViewModel, TParentViewModel)
        End Function
        Protected Overloads Function GetService(Of TService As Class)() As TService
            Dim serviceContainer = GetServiceContainer()
            Return If(serviceContainer IsNot Nothing, serviceContainer.GetService(Of TService)(), Nothing)
        End Function
        Private Function GetServiceContainer() As Mvvm.IServiceContainer
            If Not(TypeOf viewModelCore Is ISupportServices) Then
                Return Nothing
            End If
            Return DirectCast(viewModelCore, ISupportServices).ServiceContainer
        End Function
        Protected Overridable Sub OnDisposing()
        End Sub
    End Class
End Namespace
