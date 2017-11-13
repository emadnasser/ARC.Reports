Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_ContactsImageSlider
    Inherits DetailUserControl

    Protected ReadOnly Property SelectedCustomer() As Customer
        Get
            Return DataProvider.Customers.FirstOrDefault(Function(c) c.Id = OwnerPage.SelectedItemID)
        End Get
    End Property

    Public Overrides Sub Update()
        Dim customer = SelectedCustomer
        If customer IsNot Nothing Then
            ImageSlider.DataSource = customer.Employees
        End If
        ImageSlider.DataBind()
    End Sub

    Protected Sub EditImage_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim image = TryCast(sender, ASPxImage)
        Dim container = TryCast(image.NamingContainer, ImageSliderItemTemplateContainer)
        Dim customerEmployee = TryCast(container.Item.DataItem, CustomerEmployee)
        If customerEmployee IsNot Nothing Then
            image.JSProperties("cpCustomerEmployeeID") = customerEmployee.Id
        End If
    End Sub

    Protected Function GetThumbnailImageUrl(ByVal container As ImageSliderItemTemplateContainer) As String
        Dim customerEmployee = CType(container.Item.DataItem, CustomerEmployee)
        Return DemoUtils.ImageLoader.CustomerEmployeeImageVirtPath(customerEmployee.Id)
    End Function
End Class
