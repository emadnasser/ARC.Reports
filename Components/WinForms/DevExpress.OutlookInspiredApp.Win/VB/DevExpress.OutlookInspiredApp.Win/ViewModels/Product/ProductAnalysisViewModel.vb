Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.DevAVDbDataModel
Imports DevExpress.DevAV
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class ProductAnalysisViewModel
        Inherits DocumentContentViewModelBase

        Private unitOfWork As IDevAVDbUnitOfWork

        Public Shared Function Create() As ProductAnalysisViewModel
            Return ViewModelSource.Create(Function() New ProductAnalysisViewModel())
        End Function
        Protected Sub New()
            unitOfWork = UnitOfWorkSource.GetUnitOfWorkFactory().CreateUnitOfWork()
        End Sub
        Public Function GetFinancialReport() As IEnumerable(Of ProductsAnalysis.Item)
            Return ProductsAnalysis.GetFinancialReport(unitOfWork)
        End Function
        Public Function GetFinancialData() As IEnumerable(Of ProductsAnalysis.Item)
            Return ProductsAnalysis.GetFinancialData(unitOfWork)
        End Function
    End Class
End Namespace
