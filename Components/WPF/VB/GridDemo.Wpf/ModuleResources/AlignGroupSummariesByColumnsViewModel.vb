Imports System.Collections
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class AlignGroupSummariesByColumnsViewModel
        Inherits BindableBase

        Private privateSalesByYearReport As IList
        Public Property SalesByYearReport() As IList
            Get
                Return privateSalesByYearReport
            End Get
            Private Set(ByVal value As IList)
                privateSalesByYearReport = value
            End Set
        End Property
        Private privateSalesByMonthReport As IList
        Public Property SalesByMonthReport() As IList
            Get
                Return privateSalesByMonthReport
            End Get
            Private Set(ByVal value As IList)
                privateSalesByMonthReport = value
            End Set
        End Property
        Public ReadOnly Property ReportTypes() As String()
            Get
                Return New String() { "by Year", "by Month" }
            End Get
        End Property

        Private actualSalesReport_Renamed As IList
        Public Property ActualSalesReport() As IList
            Get
                Return actualSalesReport_Renamed
            End Get
            Set(ByVal value As IList)
                SetProperty(actualSalesReport_Renamed, value, Function() ActualSalesReport)
            End Set
        End Property

        Private reportTypeIndex_Renamed As Integer
        Public Property ReportTypeIndex() As Integer
            Get
                Return reportTypeIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                SetProperty(reportTypeIndex_Renamed, value, Function() ReportTypeIndex)
                UpdateActualSalesReport()
            End Set
        End Property

        Private allowCascadeUpdate_Renamed As Boolean
        Public Property AllowCascadeUpdate() As Boolean
            Get
                Return allowCascadeUpdate_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(allowCascadeUpdate_Renamed, value, Function() AllowCascadeUpdate)
            End Set
        End Property
        Public Sub New()
            SalesByYearReport = SalesByYearData.GetSalesByYearData(False)
            SalesByMonthReport = SalesByYearData.GetSalesByYearData(True)
            UpdateActualSalesReport()
            allowCascadeUpdate_Renamed = True
        End Sub
        Private Sub UpdateActualSalesReport()
            ActualSalesReport = If(ReportTypeIndex = 0, SalesByYearReport, SalesByMonthReport)
        End Sub
    End Class
End Namespace
