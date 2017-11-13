Imports DevExpress.Mvvm
Imports DevExpress.DevAV.Common.ViewModel
Imports DevExpress.DevAV.Common.DataModel
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public MustInherit Class ReportViewModelBase
        Protected Friend MustOverride ReadOnly Property IsLoaded() As Boolean
        Protected Friend MustOverride Sub OnReload()
    End Class
    Public MustInherit Class ReportViewModelBase(Of TReportType As Structure)
        Inherits ReportViewModelBase
        Implements ISupportParameter

        Public Overridable Overloads Property ReportType() As TReportType
        Protected Overridable Overloads Sub OnReportTypeChanged()
            If IsLoaded Then
                RaiseReportTypeChanged()
            End If
        End Sub
        Public Event ReportTypeChanged As EventHandler
        Private Overloads Sub RaiseReportTypeChanged()
            Dim handler As EventHandler = ReportTypeChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        #Region "ISupportParameter"
        Private Property ISupportParameter_Parameter() As Object Implements ISupportParameter.Parameter
            Get
                Return ReportType
            End Get
            Set(ByVal value As Object)
                ReportType = DirectCast(value, TReportType)
                OnParameterChanged()
            End Set
        End Property
        Protected Overridable Overloads Sub OnParameterChanged()
        End Sub
        #End Region
    End Class
    Public Class ReportViewModelBase(Of TReportType As Structure, TEntity As Class, TPrimaryKey, TUnitOfWork As {Class, IUnitOfWork})
        Inherits ReportViewModelBase(Of TReportType)

        Protected Overrides Sub OnParameterChanged()
            MyBase.OnParameterChanged()
            CheckReportEntityKey()
        End Sub
        Public Overridable Overloads Property ReportEntityKey() As Object
        Protected Overridable Overloads Sub OnReportEntityKeyChanged()
            RaiseReportEntityKeyChanged()
        End Sub
        Public Event ReportEntityKeyChanged As EventHandler
        Protected Friend Overrides Sub OnReload()
            If Not IsLoaded Then
                Return
            End If
            CheckReportEntityKey()
            RaiseReload()
        End Sub
        Public Event Reload As EventHandler
        Private isLoadedCore As Boolean
        Protected Friend Overrides ReadOnly Property IsLoaded() As Boolean
            Get
                Return isLoadedCore
            End Get
        End Property
        Public Overloads Sub OnLoad()
            CheckReportEntityKey()
            isLoadedCore = True
        End Sub
        Private Overloads Sub CheckReportEntityKey()

            Dim collectionViewModel_Renamed = GetCollectionViewModel()
            If collectionViewModel_Renamed IsNot Nothing Then
                ReportEntityKey = collectionViewModel_Renamed.SelectedEntityKey
            End If
        End Sub
        Protected Overloads Function GetCollectionViewModel() As CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork)
            Dim supportParent As ISupportParentViewModel = TryCast(Me, ISupportParentViewModel)
            If supportParent IsNot Nothing Then
                Return TryCast(supportParent.ParentViewModel, CollectionViewModel(Of TEntity, TPrimaryKey, TUnitOfWork))
            End If
            Return Nothing
        End Function
        Private Overloads Sub RaiseReportEntityKeyChanged()
            Dim handler As EventHandler = ReportEntityKeyChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Overloads Sub RaiseReload()
            Dim handler As EventHandler = ReloadEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
