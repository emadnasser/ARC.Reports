Imports DevExpress.Mvvm.POCO
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Collections.Generic
Imports System.Linq
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class EmployeesReportViewModel
        Inherits ReportViewModelBase(Of EmployeeReportType, Employee, Long, IDevAVDbUnitOfWork)

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As EmployeesReportViewModel
            Return ViewModelSource.Create(Function() New EmployeesReportViewModel())
        End Function
        Protected Sub New()
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub
        Public ReadOnly Property Tasks() As IList(Of EmployeeTask)
            Get
                Return unitOfWork.Tasks.ToList()
            End Get
        End Property
    End Class
End Namespace
