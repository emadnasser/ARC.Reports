Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_StoresImageSlider
    Inherits DetailUserControl

    Protected ReadOnly Property SelectedCustomer() As Customer
        Get
            Return DataProvider.Customers.FirstOrDefault(Function(c) c.Id = OwnerPage.SelectedItemID)
        End Get
    End Property

    Public Overrides Sub Update()
        Dim customer = SelectedCustomer
        If customer IsNot Nothing Then
            Dim storeList As New List(Of CustomerStore)()
            For Each employee In customer.Employees
                Dim store = employee.CustomerStore
                If storeList.Find(Function(s) s.Address.Equals(store.Address)) Is Nothing Then
                    storeList.Add(store)
                End If
            Next employee
            ImageSlider.DataSource = storeList
        End If
        ImageSlider.DataBind()
    End Sub

    Protected Function GetThumbnailImageUrl(ByVal container As ImageSliderItemTemplateContainer) As String
        Dim store = TryCast(container.Item.DataItem, CustomerStore)
        Return DemoUtils.ImageLoader.CrestImageVirtPath(store.Crest.Id)
    End Function
End Class
