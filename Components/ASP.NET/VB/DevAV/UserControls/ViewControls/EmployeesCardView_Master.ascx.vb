Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_EmployeesCardView_Master
    Inherits MasterUserControl

    Protected Property SelectedEmployeeID() As Long
        Get
            Dim employeeID As Long = Nothing
            Return If(DemoUtils.TryGetClientStateIDValue("ID", employeeID), employeeID, DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            DemoUtils.TrySetClientStateValue(Of Long)("ID", value)
        End Set
    End Property
    Public Overrides Property SelectedItemID() As Long
        Get
            Return SelectedEmployeeID
        End Get
        Set(ByVal value As Long)
            SelectedEmployeeID = value
            BindCardView(True)
        End Set
    End Property
    Protected ReadOnly Property Employees() As List(Of Employee)
        Get
            Return DataProvider.GetEmployees(OwnerPage.FilterBag.GetExpression(True)).ToList()
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Update()
    End Sub

    Protected Sub EditImage_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim image = DirectCast(sender, ASPxImage)
        Dim container = CType(image.NamingContainer, CardViewDataItemTemplateContainer)
        Dim employeeId = container.KeyValue
        image.JSProperties("cpEmployeeID") = employeeId
    End Sub

    Public Overrides Sub Update()
        BindCardView()
    End Sub

    Protected Sub BindCardView(Optional ByVal calcPageIndex As Boolean = False)

        Dim employees_Renamed = Employees
        EmployeeCardView.DataSource = employees_Renamed
        EmployeeCardView.DataBind()

        SelectedEmployeeID = GetVisibleSelectedEmployeeID()

        UpdateDetail()
    End Sub

    Protected Function GetVisibleSelectedEmployeeID() As Long
        Return Convert.ToInt64(EmployeeCardView.GetCardValues(EmployeeCardView.FocusedCardIndex, "Id"))
    End Function

    Protected Function GetEmployeeImageUrl(ByVal id As Long) As String
        Return DemoUtils.ImageLoader.EmployeeImageVirtPath(id)
    End Function
    Protected Function HighlightSearchText(ByVal container As CardViewDataItemTemplateContainer, ByVal fieldName As String) As String
        Dim text = DataBinder.Eval(container.DataItem, fieldName).ToString()
        Return If((Not String.IsNullOrWhiteSpace(text)), DemoUtils.HighlightSearchText(text, EmployeeCardView.SearchPanelFilter), text)
    End Function

    Protected Sub EmployeeCardView_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SelectedEmployeeID = GetVisibleSelectedEmployeeID()
    End Sub
End Class
