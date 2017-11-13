Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class Employees
    Inherits MasterDetailPage


    Private masterUC_Renamed As MasterUserControl

    Private detailUC_Renamed As DetailUserControl

    Public Overrides ReadOnly Property FilterBag() As FilterBag
        Get
            Return DemoUtils.EmployeeFilter
        End Get
    End Property
    Public Overrides ReadOnly Property PageName() As String
        Get
            Return "Employees"
        End Get
    End Property
    Public Overrides ReadOnly Property MasterUC() As MasterUserControl
        Get
            Return masterUC_Renamed
        End Get
    End Property
    Public Overrides ReadOnly Property DetailUC() As DetailUserControl
        Get
            Return detailUC_Renamed
        End Get
    End Property

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        LoadUserControls()
    End Sub

    Public Overrides Sub PrepareToolbarItem(ByVal item As DevExpress.Web.MenuItem)
        MyBase.PrepareToolbarItem(item)
        If item.Name = "ColumnsCustomization" Then
            item.ClientEnabled = DemoUtils.IsEmployeeGridViewMode
        End If
        If item.Name = "GridView" Then
            item.Checked = DemoUtils.IsEmployeeGridViewMode
        End If
        If item.Name = "CardsView" Then
            item.Checked = Not DemoUtils.IsEmployeeGridViewMode
        End If
    End Sub

    Protected Sub LoadUserControls()
        Dim viewMode = If(DemoUtils.IsEmployeeGridViewMode, "GridView", "CardView")
        Me.masterUC_Renamed = TryCast(LoadControl(String.Format("~/UserControls/ViewControls/Employees{0}_Master.ascx", viewMode)), MasterUserControl)
        Me.detailUC_Renamed = TryCast(LoadControl(String.Format("~/UserControls/ViewControls/Employees{0}_Detail.ascx", viewMode)), DetailUserControl)
        MasterContainer.Controls.Add(MasterUC)
        DetailsCallbackPanel.Controls.Add(DetailUC)
    End Sub

    Protected Sub DetailsCallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase) ' TODO refactor
        Dim args = DemoUtils.DeserializeCallbackArgs(e.Parameter)
        If args.Count = 0 Then
            Return
        End If
        Dim callbackName = args(0)
        If callbackName = "SaveEditForm" Then
            GetEditForm(args(1)).SaveChanges(args(2))
        End If
        If callbackName = "DeleteEntry" Then
            Dim entryID As Long = Long.Parse(args(2))
            If entryID = DataProvider.emptyEntryID Then
                Return
            End If
            Select Case args(1)
                Case "Task"
                    DataProvider.DeleteTask(entryID)
                Case "Evaluation"
                    DataProvider.DeleteEvaluation(entryID)
            End Select
        End If
        UpdateDetail()
    End Sub

    Public Overrides Sub OnFilterChanged()
        Update()
    End Sub
    Public Overrides Sub SaveEditFormChanges(ByVal parameters As String)
        MasterUC.SelectedItemID = EmployeeEditForm.SaveChanges(parameters) ' TODO rename SaveChanges
    End Sub
    Public Overrides Sub DeleteEntry(ByVal employeeID As String)
        DataProvider.DeleteEmployee(Long.Parse(employeeID))
        MasterUC.Update()
    End Sub

    Public Overrides Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
        Dim result = New ArrayList()
        result.Add(New FilterControlTextColumn() With {.PropertyName = "FirstName"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "LastName"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "FullName"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Address"})
        result.Add(New FilterControlDateColumn() With {.PropertyName = "BirthDate"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Department"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Email"})
        result.Add(New FilterControlDateColumn() With {.PropertyName = "HireDate"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "HomePhone"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "MobilePhone"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Prefix"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Skype"})
        result.Add(New FilterControlTextColumn() With {.PropertyName = "Title"})
        result.Add(New FilterControlComboBoxColumn() With {.PropertyName = "Status"}, GetType(EmployeeStatus))
        Return result.OfType(Of FilterControlColumn)()
    End Function

    Private Function GetEditForm(ByVal name As String) As EditFormUserControl
        If name = "Task" Then
            Return TaskEditForm
        End If
        If name = "Evaluation" Then
            Return EvaluationEditForm
        End If
        Return Nothing
    End Function
End Class
