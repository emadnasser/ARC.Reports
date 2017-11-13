Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Utils
Imports System.Collections
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Mvvm
Imports DevExpress.DemoData

Namespace GridDemo
    Public Class MultiViewViewItem
        Public Property Content() As Object
        Public Property DisplayName() As String
    End Class

    Public MustInherit Class MultiViewViewModelBase
        Inherits BindableBase

        Private privateEmployees As Object
        Public Property Employees() As Object
            Get
                Return privateEmployees
            End Get
            Private Set(ByVal value As Object)
                privateEmployees = value
            End Set
        End Property


        Private columnInfoFieldName_Renamed As String = "HomePhone"
        Public Property ColumnInfoFieldName() As String
            Get
                Return columnInfoFieldName_Renamed
            End Get
            Set(ByVal value As String)
                SetProperty(columnInfoFieldName_Renamed, value, Function() ColumnInfoFieldName)
            End Set
        End Property

        Public Sub New()
            Employees = (New NWindDataLoader()).Employees
            ChangeFieldNameCommand = New DelegateCommand(Of Object)(AddressOf OnChangeFieldName)
        End Sub
        Private privateChangeFieldNameCommand As DelegateCommand(Of Object)
        Public Property ChangeFieldNameCommand() As DelegateCommand(Of Object)
            Get
                Return privateChangeFieldNameCommand
            End Get
            Private Set(ByVal value As DelegateCommand(Of Object))
                privateChangeFieldNameCommand = value
            End Set
        End Property
        Private ReadOnly Property CanExecuteCommand() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Sub OnChangeFieldName(ByVal param As Object)
            ColumnInfoFieldName = DirectCast(param, String)
        End Sub
    End Class
    Public Class MultiViewTableViewViewModel
        Inherits MultiViewViewModelBase

    End Class
    Public Class MultiViewTreeListViewViewModel
        Inherits MultiViewViewModelBase

    End Class
    Public Class MultiViewCardViewViewModel
        Inherits MultiViewViewModelBase

    End Class
    Public Class MultiViewBandedTableViewViewModel
        Inherits MultiViewViewModelBase

    End Class
    Public Class MultiViewBandedTreeListViewViewModel
        Inherits MultiViewViewModelBase

    End Class
End Namespace
