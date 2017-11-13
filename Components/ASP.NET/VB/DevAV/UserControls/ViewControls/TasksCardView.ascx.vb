Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_TasksCardView
    Inherits ViewUserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        BindCardView()
    End Sub

    Protected Property SelectedTaskID() As Long
        Get
            Dim taskID As Long = Nothing
            Return If(DemoUtils.TryGetClientStateIDValue("ID", taskID), taskID, DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            DemoUtils.TrySetClientStateValue(Of Long)("ID", value)
        End Set
    End Property

    Public Overrides Property SelectedItemID() As Long
        Get
            Return SelectedTaskID
        End Get
        Set(ByVal value As Long)
            SelectedTaskID = value
            BindCardView(True)
        End Set
    End Property

    Private Function GetVisibleSelectedTaskID() As Long
        Return Convert.ToInt64(TaskCardView.GetCardValues(TaskCardView.FocusedCardIndex, "Id"))
    End Function

    Protected Function GetTasks() As List(Of EmployeeTask)
        Return DataProvider.GetEmployeeTasks(Filter.GetExpression(True)).ToList()
    End Function

    Public Function GetCheckedState(ByVal container As CardViewDataItemTemplateContainer) As Boolean
        Dim status = DirectCast(DataBinder.Eval(container.DataItem, "Status"), EmployeeTaskStatus)
        Return status.Equals(EmployeeTaskStatus.Completed)
    End Function
    Protected Sub TaskCardView_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.CustomJSPropertiesEventArgs)
        e.Properties("cpSelectedItemID") = If(SelectedTaskID <> DataProvider.emptyEntryID, SelectedTaskID.ToString(), String.Empty)
    End Sub

    Protected Sub BindCardView(Optional ByVal calcPageIndex As Boolean = False)
        Dim tasks = GetTasks()
        TaskCardView.DataSource = tasks
        TaskCardView.DataBind()

        SelectedTaskID = GetVisibleSelectedTaskID()
    End Sub

    Protected Sub EditButton_Load(ByVal sender As Object, ByVal e As EventArgs)
        LoadTaskID(DirectCast(sender, ASPxButton))
    End Sub
    Protected Sub ViewButton_Load(ByVal sender As Object, ByVal e As EventArgs)
        LoadTaskID(DirectCast(sender, ASPxButton))
    End Sub
    Protected Sub DeleteButton_Load(ByVal sender As Object, ByVal e As EventArgs)
        LoadTaskID(DirectCast(sender, ASPxButton))
    End Sub
    Protected Sub LoadTaskID(ByVal button As ASPxButton)
        Dim container = CType(button.NamingContainer, CardViewDataItemTemplateContainer)
        button.JSProperties("cpTaskID") = DataBinder.Eval(container.DataItem, "Id")
    End Sub

    Protected Function HighlightSearchText(ByVal container As CardViewDataItemTemplateContainer, ByVal fieldName As String) As String
        Dim text = DataBinder.Eval(container.DataItem, fieldName).ToString()
        Return If((Not String.IsNullOrWhiteSpace(text)), DemoUtils.HighlightSearchText(text, TaskCardView.SearchPanelFilter), text)
    End Function

    Public Overrides Sub Update()
        BindCardView()
    End Sub

    Protected Sub TaskCardView_PageIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SelectedTaskID = GetVisibleSelectedTaskID()
    End Sub

    Protected Function GetPriorityImageUrl(ByVal container As CardViewDataItemTemplateContainer) As String
        Dim priority = DirectCast(DataBinder.Eval(container.DataItem, "Priority"), EmployeeTaskPriority)
        Return DemoUtils.ImageLoader.GetPriorityImageUrl(priority)
    End Function
End Class
