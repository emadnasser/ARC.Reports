Imports System
Imports System.Linq
Imports DevExpress.Web

Partial Public Class UserControls_ViewControls_TasksGridView
    Inherits ViewUserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        BindGrid()
    End Sub

    Public Overrides Property SelectedItemID() As Long
        Get
            Dim taskID = TaskGrid.GetRowValues(TaskGrid.FocusedRowIndex, TaskGrid.KeyFieldName)
            Return If(taskID IsNot Nothing, CLng((taskID)), DataProvider.emptyEntryID)
        End Get
        Set(ByVal value As Long)
            BindGrid()
            TaskGrid.FocusedRowIndex = TaskGrid.FindVisibleIndexByKeyValue(value)
        End Set
    End Property

    Protected Sub BindGrid()
        TaskGrid.DataSource = DataProvider.EmployeeTasks.ToList()
        TaskGrid.FilterExpression = OwnerPage.FilterBag.GetExpression(False)
        TaskGrid.SearchPanelFilter = OwnerPage.FilterBag.SearchText
        TaskGrid.DataBind()
    End Sub

    Protected Function GetDescription(ByVal container As GridViewPreviewRowTemplateContainer) As String
        Return OwnerPage.HighlightSearchText(container.Text).Replace("&", "&amp;")
    End Function

    Public Overrides Sub Update()
        BindGrid()
    End Sub
End Class
