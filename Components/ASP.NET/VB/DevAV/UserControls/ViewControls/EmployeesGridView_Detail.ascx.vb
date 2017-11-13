Imports System.Linq
Imports DevExpress.DevAV

Partial Public Class UserControls_ViewControls_EmployeesGridView_Detail
    Inherits DetailUserControl

    Protected ReadOnly Property SelectedEmployee() As Employee
        Get
            Return DataProvider.Employees.FirstOrDefault(Function(e) e.Id = SelectedItemID)
        End Get
    End Property

    Public Overrides Sub Update()
        Dim employee = SelectedEmployee
        If employee IsNot Nothing Then
            DetailsPageControl.Visible = True

            EmployeeImage.ImageUrl = DemoUtils.ImageLoader.EmployeeImageVirtPath(employee.Id)
            EditImage.JSProperties("cpEmployeeID") = employee.Id

            DetailsHeaderHeadLine.NavigateUrl = String.Format("javascript:ShowEmployeeEditForm('{0}')", employee.Id)
            DetailsHeaderHeadLine.HeaderText = String.Format("{0} {1}", employee.FirstName, employee.LastName)
            DetailsHeaderHeadLine.ContentText = employee.Title

            Dim address = employee.Address
            DetailsAddressText.InnerHtml = address.Line & "<br />" & address.City & ", " & address.State & ", " & address.ZipCode
            DetailsPhoneText.InnerHtml = employee.HomePhone
            DetailsEmailText.InnerHtml = employee.Email
        Else
            DetailsPageControl.Visible = False
            EmployeeImage.ImageUrl = String.Empty

            DetailsHeaderHeadLine.HeaderText = "None"
            DetailsHeaderHeadLine.ContentText = "None"

            DetailsAddressText.InnerHtml = "None"
            DetailsPhoneText.InnerHtml = "None"
            DetailsEmailText.InnerHtml = "None"
        End If
        BindEvaluationGrid(employee)
        BindTaskGridView(employee)
    End Sub

    Protected Sub BindTaskGridView(ByVal employee As Employee)
        TasksGrid.DataSource = If(employee IsNot Nothing, employee.AssignedTasks, Nothing)
        TasksGrid.DataBind()
        DemoUtils.EnsureGridFocusedRowIndex(TasksGrid)
    End Sub
    Protected Sub BindEvaluationGrid(ByVal employee As Employee)
        EvaluationGrid.DataSource = If(employee IsNot Nothing, employee.Evaluations, Nothing)
        EvaluationGrid.DataBind()
        DemoUtils.EnsureGridFocusedRowIndex(EvaluationGrid)
    End Sub
End Class
