Imports System
Imports System.Collections.Generic
Imports System.Drawing.Imaging
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraCharts.Web

Partial Public Class UserControls_Charts_ProductSalesOpportunitiesChart
    Inherits ChartUserControl


    Private selectedItemID_Renamed As Long = DataProvider.emptyEntryID

    Public Overrides ReadOnly Property Chart() As WebChartControl
        Get
            Return SalesOpportunitiesChart
        End Get
    End Property

    Public Overrides Property SelectedItemID() As Long
        Get
            Return selectedItemID_Renamed
        End Get
        Set(ByVal value As Long)
            selectedItemID_Renamed = value
            LoadChartData()
        End Set
    End Property
    Public ReadOnly Property SelectedProduct() As Product
        Get
            Return DataProvider.Products.FirstOrDefault(Function(p) p.Id = SelectedItemID)
        End Get
    End Property

    Protected Sub LoadChartData()
        Dim product = SelectedProduct
        If product Is Nothing Then
            Return
        End If

        SalesOpportunitiesChart.GetSeriesByName("Sales").DataSource = DataProvider.GetProductSalesChartData(product)
        SalesOpportunitiesChart.GetSeriesByName("Opportunities").DataSource = DataProvider.GetProductOpportunitiesChartData(product)
    End Sub

    Public Sub CreateImage(ByVal imagePath As String, ByVal sales As List(Of DataEntryInfo), ByVal opportunities As List(Of DataEntryInfo))
        SalesOpportunitiesChart.GetSeriesByName("Sales").DataSource = sales
        SalesOpportunitiesChart.GetSeriesByName("Opportunities").DataSource = opportunities
        DirectCast(SalesOpportunitiesChart, IChartContainer).Chart.ExportToImage(imagePath, ImageFormat.Png)
    End Sub
End Class
