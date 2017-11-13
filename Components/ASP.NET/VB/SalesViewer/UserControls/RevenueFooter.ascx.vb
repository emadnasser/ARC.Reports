Imports System
Imports System.Collections.Generic
Imports DataAccess

Partial Public Class RevenueFooter
    Inherits UserControlBase

    Public Property Title() As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        DoughnutChart.Title = Title
        HorizontalBarChart.SubTitle = Title & " BY RANGE"
        HorizontalBarChart.Title = DateTimeHelper.GetDateRangeString(GetSalesStartDate(), GetSalesEndDate())
    End Sub

    Public Sub SetData(ByVal data As IEnumerable(Of ChartData))
        DoughnutChart.SetData(data)
        HorizontalBarChart.SetData(data)
    End Sub
End Class
