Imports System
Imports System.Linq
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_EmployeesGridView_Master
    Inherits MasterUserControl

    Public Overrides Property SelectedItemID() As Long
        Get
            Dim employeeID = EmployeesGrid.GetRowValues(EmployeesGrid.FocusedRowIndex, EmployeesGrid.KeyFieldName)
            Return If(employeeID IsNot Nothing, CLng((employeeID)), DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            BindGrid()
            EmployeesGrid.FocusedRowIndex = EmployeesGrid.FindVisibleIndexByKeyValue(value)
            UpdateDetail()
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Update()
    End Sub

    Public Overrides Sub Update()
        BindGrid()
        UpdateDetail()
    End Sub

    Protected Sub BindGrid()
        EmployeesGrid.DataSource = DataProvider.Employees.ToList()
        EmployeesGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(False)
        EmployeesGrid.DataBind()
    End Sub
End Class
