Imports DevExpress.DemoData.Models
Imports DevExpress.Mvvm.POCO
Imports System.Collections.Generic
Imports System.Linq

Namespace ControlsDemo.TabControl.CustomTheme
    Public Class MainViewModel
        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function
        Protected Sub New()
            If Me.IsInDesignMode() Then
                Return
            End If
            Employees = NWindContext.Create().Employees.ToList()
        End Sub

        Private privateEmployees As List(Of Employee)
        Public Overridable Property Employees() As List(Of Employee)
            Get
                Return privateEmployees
            End Get
            Protected Set(ByVal value As List(Of Employee))
                privateEmployees = value
            End Set
        End Property
    End Class
End Namespace
