Imports System
Imports DataAccess
Imports DevExpress.Web

Partial Public Class ProductDetails
    Inherits UserControlBase

    Private CityInfoFormatString As String = "{0}, {1} {2}"

    Public Sub LoadContent(ByVal productId As Integer)
        Using productsProvider As New ProductsProvider()
            Dim projectManager As Contact = productsProvider.GetProjectManager(productId)
            Dim supportManager As Contact = productsProvider.GetSupportManager(productId)
            Dim plant As Plant = productsProvider.GetPlant(productId)

            FillPlantInfo(plant)
            FillSupportManagerInfo(supportManager)
            FillProjectManagerInfo(projectManager)
        End Using
        Dim startDate As Date = GetSalesStartDate()
        Dim endDate As Date = GetSalesEndDate()
        RevenueByChannelChart.SetData(SalesProvider.GetSalesGroupedByChannel(productId, startDate, endDate))
        RevenueByRegionChart.SetData(SalesProvider.GetSalesGroupedByRegion(productId, startDate, endDate))
        RevenueBySectorChart.SetData(SalesProvider.GetSalesGroupedBySector(productId, startDate, endDate))
    End Sub
    Private Sub FillPlantInfo(ByVal model As Plant)
        PlantName.Text = model.Name
        PlantAddress.Text = model.Address
        PlantCityInfo.Text = String.Format(CityInfoFormatString, model.City, model.State, model.Zip)
    End Sub
    Private Sub FillSupportManagerInfo(ByVal model As Contact)
        SupportName.Text = model.FullName
        SupportAddress.Text = model.Address
        SupportEmail.Text = model.Email
        SupportPhone.Text = model.Phone
        If HasCityInfo(model) Then
            SupportCityInfo.Text = String.Format(CityInfoFormatString, model.City, model.State, model.Zip)
        End If
    End Sub
    Private Sub FillProjectManagerInfo(ByVal model As Contact)
        PMName.Text = model.FullName
        PMAddress.Text = model.Address
        PMEmail.Text = model.Email
        PMPhone.Text = model.Phone
        If HasCityInfo(model) Then
            PMCityInfo.Text = String.Format(CityInfoFormatString, model.City, model.State, model.Zip)
        End If
    End Sub
    Private Function HasCityInfo(ByVal model As Contact) As Boolean
        Return (Not String.IsNullOrEmpty(model.City)) AndAlso (Not String.IsNullOrEmpty(model.State)) AndAlso Not String.IsNullOrEmpty(model.Zip)
    End Function
End Class
