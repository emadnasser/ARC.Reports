Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class Tasks
    Inherits BasePage


    Private viewControl_Renamed As ViewUserControl

    Public Overrides ReadOnly Property FilterBag() As FilterBag
        Get
            Return DemoUtils.TaskFilter
        End Get
    End Property
    Public Overrides ReadOnly Property PageName() As String
        Get
            Return "Tasks"
        End Get
    End Property

    Protected ReadOnly Property ViewControl() As ViewUserControl
        Get
            Return viewControl_Renamed
        End Get
    End Property

    Public Overrides Sub OnFilterChanged()
        ViewControl.Update()
    End Sub

    Public Overrides Sub SaveEditFormChanges(ByVal parameters As String)
        ViewControl.SelectedItemID = TaskEditForm.SaveChanges(parameters)
    End Sub
    Public Overrides Sub DeleteEntry(ByVal taskID As String)
        DataProvider.DeleteTask(Long.Parse(taskID))
        OnFilterChanged() 'TODO Rename Function
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        LoadUserControlView()
    End Sub

    Public Overrides Sub PrepareToolbarItem(ByVal item As DevExpress.Web.MenuItem)
        MyBase.PrepareToolbarItem(item)
        If item.Name = "GridView" Then
            item.Checked = DemoUtils.IsTaskGridViewMode
        End If
        If item.Name = "CardsView" Then
            item.Checked = Not DemoUtils.IsTaskGridViewMode
        End If
    End Sub

    Private Sub LoadUserControlView()
        Dim viewMode = If(DemoUtils.IsTaskGridViewMode, "GridView", "CardView")
        Me.viewControl_Renamed = TryCast(LoadControl(String.Format("~/UserControls/ViewControls/Tasks{0}.ascx", viewMode)), ViewUserControl)
        MainContentContainer.Controls.Add(ViewControl)
    End Sub

    Public Overrides Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
        Dim result = New ArrayList()
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Subject"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Description"})
        result.Add(New FilterControlDateColumn() With {.PropertyName = "StartDate"})
        result.Add(New FilterControlDateColumn() With {.PropertyName = "DueDate"})

        result.Add(New FilterControlComboBoxColumn() With {.PropertyName = "Status"}, GetType(EmployeeTaskStatus))
        result.Add(New FilterControlComboBoxColumn() With {.PropertyName = "Priority"}, GetType(EmployeeTaskPriority))

        Dim spinColumn = result.Add(Of FilterControlSpinEditColumn)(New FilterControlSpinEditColumn() With {.PropertyName = "Completion"})
        spinColumn.PropertiesSpinEdit.MinValue = 0
        spinColumn.PropertiesSpinEdit.MaxValue = 100
        spinColumn.PropertiesSpinEdit.NumberType = SpinEditNumberType.Integer

        Return result.OfType(Of FilterControlColumn)()
    End Function
End Class
