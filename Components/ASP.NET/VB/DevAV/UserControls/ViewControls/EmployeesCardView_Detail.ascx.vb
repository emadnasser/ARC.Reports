Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_EmployeesCardView_Detail
    Inherits DetailUserControl

    Protected ReadOnly Property SelectedEmployee() As Employee
        Get
            Return DataProvider.Employees.FirstOrDefault(Function(e) e.Id = SelectedItemID)
        End Get
    End Property

    Public Overrides Sub Update()
        Dim employee = SelectedEmployee
        If employee Is Nothing Then
            DetailsPageControl.Visible = False
            EmployeeNameText.InnerHtml = ""
            EmployeeDepartmentText.InnerHtml = ""
        Else
            DetailsPageControl.Visible = True
            EmployeeNameText.InnerHtml = employee.FullName
            EmployeeDepartmentText.InnerHtml = employee.Department.ToString()
        End If

        BindTaskGrid(employee)
        BindEvaluationGrid(employee)
    End Sub

    Protected Sub BindTaskGrid(ByVal employee As Employee)
        CVTasksGridView.DataSource = If(employee IsNot Nothing, employee.AssignedTasks, Nothing)
        CVTasksGridView.DataBind()
        DemoUtils.EnsureGridFocusedRowIndex(CVTasksGridView)
    End Sub
    Protected Sub BindEvaluationGrid(ByVal employee As Employee)
        EvaluationGridView.DataSource = If(employee IsNot Nothing, employee.Evaluations, Nothing)
        EvaluationGridView.DataBind()
        DemoUtils.EnsureGridFocusedRowIndex(EvaluationGridView)
    End Sub

    Protected Function GetPriorityImageUrl(ByVal container As GridViewDataItemTemplateContainer) As String
        Dim priority = CType(container.Grid.GetRowValues(container.VisibleIndex, "Priority"), EmployeeTaskPriority)
        Return DemoUtils.ImageLoader.GetPriorityImageUrl(priority)
    End Function
End Class
