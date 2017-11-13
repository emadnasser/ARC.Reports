Imports System
Imports System.Linq
Imports DevExpress.DevAV
Imports DevExpress.Web

Partial Public Class UserControls_EditForms_TaskEditForm
    Inherits EditFormUserControl

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        DemoUtils.BindComboBoxToEnum(PriorityComboBox, GetType(EmployeeTaskPriority))
        DemoUtils.BindComboBoxToEnum(StatusComboBox, GetType(EmployeeTaskStatus))
        For Each item As ListEditItem In PriorityComboBox.Items
            item.ImageUrl = DemoUtils.ImageLoader.GetPriorityImageUrl(CType(item.Value, EmployeeTaskPriority))
        Next item
        TaskEditPopup.JSProperties("cpEditFormName") = "Task"
    End Sub

    Protected Sub TaskEditPopup_WindowCallback(ByVal source As Object, ByVal e As PopupWindowCallbackArgs)
        FillEmployeeComboBoxes()

        Dim args = e.Parameter.Split("|"c)

        Dim id_Renamed = If((Not String.IsNullOrEmpty(args(1))), Long.Parse(args(1)), DataProvider.emptyEntryID)
        Select Case args(0)
            Case "New"
                PrepareNewForm(id_Renamed)
            Case "Edit"
                PrepareEditForm(id_Renamed, False)
            Case "Show"
                PrepareEditForm(id_Renamed, True)
        End Select
    End Sub

    Protected Sub PrepareNewForm(ByVal employeeID As Long)
        StartDateEdit.Date = Date.Now
        DueDateEdit.Date = Date.Now.AddDays(1)
        PriorityComboBox.Value = EmployeeTaskPriority.Low
        StatusComboBox.Value = EmployeeTaskStatus.NotStarted

        Dim headerText = "New Task"
        Dim employee = DataProvider.Employees.FirstOrDefault(Function(em) em.Id = employeeID)
        If employee IsNot Nothing Then
            AssignedToComboBox.Value = employee.Id.ToString() ' TODO
            headerText = String.Format("{0} ({1} {2})", headerText, employee.FirstName, employee.LastName)
        End If
        TaskEditPopup.JSProperties("cpHeaderText") = headerText
    End Sub

    Protected Sub PrepareEditForm(ByVal taskID As Long, ByVal [readOnly] As Boolean)
        Dim task = DataProvider.EmployeeTasks.FirstOrDefault(Function(t) t.Id = taskID)
        If task Is Nothing Then
            Return
        End If
        OwnerComboBox.Value = task.Owner.Id.ToString()
        AssignedToComboBox.Value = task.AssignedEmployee.Id.ToString()
        TaskSubjectTextBox.Text = task.Subject
        DetailsMemo.Text = task.Description
        StartDateEdit.Date = CDate(task.StartDate)
        DueDateEdit.Date = CDate(task.DueDate)
        PriorityComboBox.Value = task.Priority.ToString()
        StatusComboBox.Value = task.Status
        CompletedTrackBar.Value = task.Completion

        OwnerComboBox.ReadOnly = [readOnly]
        AssignedToComboBox.ReadOnly = [readOnly]
        TaskSubjectTextBox.ReadOnly = [readOnly]
        DetailsMemo.ReadOnly = [readOnly]
        StartDateEdit.ReadOnly = [readOnly]
        DueDateEdit.ReadOnly = [readOnly]
        PriorityComboBox.ReadOnly = [readOnly]
        StatusComboBox.ReadOnly = [readOnly]
        CompletedTrackBar.ReadOnly = [readOnly]
        TaskSaveButton.Visible = Not [readOnly]

        TaskEditPopup.JSProperties("cpHeaderText") = String.Format("{0}Task ({1} {2})",If([readOnly], String.Empty, "Edit "), task.AssignedEmployee.FirstName, task.AssignedEmployee.LastName)
        If Not [readOnly] Then
            TaskEditPopup.JSProperties("cpTaskID") = task.Id
        End If
    End Sub

    Public Overrides Function SaveChanges(ByVal args As String) As Long
        Dim callbackArgs = DemoUtils.DeserializeCallbackArgs(args)
        Dim task As EmployeeTask = Nothing
        If callbackArgs(0) = "New" Then
            task = DataProvider.CreateTask()
        ElseIf callbackArgs(0) = "Edit" Then

            Dim id_Renamed As Long = Long.Parse(callbackArgs(1))
            task = DataProvider.EmployeeTasks.FirstOrDefault(Function(t) t.Id = id_Renamed)
        End If
        If task Is Nothing Then
            Return DataProvider.emptyEntryID
        End If

        If OwnerComboBox.Value IsNot Nothing Then

            Dim id_Renamed As Long = Long.Parse(OwnerComboBox.Value.ToString())
            task.Owner = DataProvider.Employees.FirstOrDefault(Function(e) e.Id = id_Renamed)
        End If
        If AssignedToComboBox.Value IsNot Nothing Then

            Dim id_Renamed As Long = Long.Parse(AssignedToComboBox.Value.ToString())
            task.AssignedEmployee = DataProvider.Employees.FirstOrDefault(Function(e) e.Id = id_Renamed)
        End If
        task.Completion = Convert.ToInt32(CompletedTrackBar.Value)
        task.Description = DetailsMemo.Text
        task.DueDate = DueDateEdit.Date
        task.StartDate = StartDateEdit.Date
        If task.StartDate > task.DueDate Then
            task.StartDate = task.DueDate
        End If
        task.Priority = DirectCast(System.Enum.Parse(GetType(EmployeeTaskPriority), PriorityComboBox.Value.ToString()), EmployeeTaskPriority)
        If task.Completion = 100 OrElse task.Completion = 0 Then
            task.Status = If(task.Completion = 100, EmployeeTaskStatus.Completed, EmployeeTaskStatus.NotStarted)
        Else
            task.Status = DirectCast(System.Enum.Parse(GetType(EmployeeTaskStatus), StatusComboBox.Value.ToString()), EmployeeTaskStatus)
        End If
        task.Subject = TaskSubjectTextBox.Text
        DataProvider.SaveChanges()
        Return task.Id
    End Function

    Protected Sub FillEmployeeComboBoxes()
        For Each employee In DataProvider.Employees
            Dim fullname = employee.FirstName & " " & employee.LastName
            OwnerComboBox.Items.Add(fullname, employee.Id)
            AssignedToComboBox.Items.Add(fullname, employee.Id)
        Next employee
    End Sub
End Class
