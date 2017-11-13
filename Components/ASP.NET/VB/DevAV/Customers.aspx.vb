Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class Customers
    Inherits MasterDetailPage


    Private detailUC_Renamed As DetailUserControl
    Public Overrides ReadOnly Property FilterBag() As FilterBag
        Get
            Return DemoUtils.CustomerFilter
        End Get
    End Property
    Public Overrides ReadOnly Property PageName() As String
        Get
            Return "Customers"
        End Get
    End Property
    Public Overrides ReadOnly Property MasterUC() As MasterUserControl
        Get
            Return TryCast(Customers_Master, MasterUserControl)
        End Get
    End Property
    Public Overrides ReadOnly Property DetailUC() As DetailUserControl
        Get
            Return detailUC_Renamed
        End Get
    End Property

    Public Overrides Sub OnFilterChanged()
        Update()
    End Sub

    Protected Sub DetailsCallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        Dim args = DemoUtils.DeserializeCallbackArgs(e.Parameter)
        If args.Count = 0 Then
            Return
        End If
        Dim callbackName = args(0)
        If callbackName = "SaveEditForm" Then
            CustomerEmployeeEditForm.SaveChanges(args(2))
            UpdateDetail()
        End If
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim viewMode = If(DemoUtils.IsContactImageSliderMode, "Contacts", "Stores")
        Me.detailUC_Renamed = TryCast(LoadControl(String.Format("~/UserControls/ViewControls/{0}ImageSlider.ascx", viewMode)), DetailUserControl)
        DetailsCallbackPanel.Controls.Add(DetailUC)
    End Sub

    Public Overrides Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
        Dim result = New ArrayList()
        result.Add(New FilterControlTextColumn() With {.PropertyName = "BillingAddress.City", .DisplayName = "City"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Name"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "BillingAddress.Line", .DisplayName = "Address"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "BillingAddress.State", .DisplayName = "State"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Phone"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Fax"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Website"})
        result.Add(New FilterControlSpinEditColumn() With {.PropertyName = "AnnualRevenue"})
        result.Add(New FilterControlComboBoxColumn() With {.PropertyName = "Status"}, GetType(CustomerStatus))
        result.Add(New FilterControlSpinEditColumn() With {.PropertyName = "TotalStores"})
        result.Add(New FilterControlSpinEditColumn() With {.PropertyName = "TotalEmployees"})
        Return result.OfType(Of FilterControlColumn)()
    End Function

    Protected Sub Customers_Master_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim selectedCustomer = DataProvider.Customers.FirstOrDefault(Function(c) c.Id = SelectedItemID)
        If selectedCustomer Is Nothing Then
            ImageSliderMenuContainer.Visible = False
        Else
            ImageSliderMenuContainer.Visible = True
            SliderMenu.Items(0).Text = If(DemoUtils.IsContactImageSliderMode, "Contacts", "Stores")
            SliderMenu.Items(0).Items(If(DemoUtils.IsContactImageSliderMode, 1, 0)).Selected = True
            CustomerNameText.InnerHtml = selectedCustomer.Name
        End If
    End Sub
End Class
