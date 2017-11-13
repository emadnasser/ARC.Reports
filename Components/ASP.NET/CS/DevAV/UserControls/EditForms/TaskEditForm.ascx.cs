using System;
using System.Linq;
using DevExpress.DevAV;
using DevExpress.Web;

public partial class UserControls_EditForms_TaskEditForm : EditFormUserControl {
    protected void Page_Init(object sender, EventArgs e) {
        DemoUtils.BindComboBoxToEnum(PriorityComboBox, typeof(EmployeeTaskPriority));
        DemoUtils.BindComboBoxToEnum(StatusComboBox, typeof(EmployeeTaskStatus));
        foreach(ListEditItem item in PriorityComboBox.Items)
            item.ImageUrl = DemoUtils.ImageLoader.GetPriorityImageUrl((EmployeeTaskPriority)item.Value);
        TaskEditPopup.JSProperties["cpEditFormName"] = "Task";
    }

    protected void TaskEditPopup_WindowCallback(object source, PopupWindowCallbackArgs e) {
        FillEmployeeComboBoxes();

        var args = e.Parameter.Split('|');
        var id = !string.IsNullOrEmpty(args[1]) ? long.Parse(args[1]) : DataProvider.emptyEntryID;
        switch(args[0]) {
            case "New":
                PrepareNewForm(id);
                break;
            case "Edit":
                PrepareEditForm(id, false);
                break;
            case "Show":
                PrepareEditForm(id, true);
                break;
        }
    }

    protected void PrepareNewForm(long employeeID) {
        StartDateEdit.Date = DateTime.Now;
        DueDateEdit.Date = DateTime.Now.AddDays(1);
        PriorityComboBox.Value = EmployeeTaskPriority.Low;
        StatusComboBox.Value = EmployeeTaskStatus.NotStarted;

        var headerText = "New Task";
        var employee = DataProvider.Employees.FirstOrDefault(em => em.Id == employeeID);
        if(employee != null) {
            AssignedToComboBox.Value = employee.Id.ToString(); // TODO
            headerText = string.Format("{0} ({1} {2})", headerText, employee.FirstName, employee.LastName);
        }
        TaskEditPopup.JSProperties["cpHeaderText"] = headerText;
    }

    protected void PrepareEditForm(long taskID, bool readOnly) {
        var task = DataProvider.EmployeeTasks.FirstOrDefault(t => t.Id == taskID);
        if(task == null)
            return;
        OwnerComboBox.Value = task.Owner.Id.ToString();
        AssignedToComboBox.Value = task.AssignedEmployee.Id.ToString();
        TaskSubjectTextBox.Text = task.Subject;
        DetailsMemo.Text = task.Description;
        StartDateEdit.Date = (DateTime)task.StartDate;
        DueDateEdit.Date = (DateTime)task.DueDate;
        PriorityComboBox.Value = task.Priority.ToString();
        StatusComboBox.Value = task.Status;
        CompletedTrackBar.Value = task.Completion;

        OwnerComboBox.ReadOnly = readOnly;
        AssignedToComboBox.ReadOnly = readOnly;
        TaskSubjectTextBox.ReadOnly = readOnly;
        DetailsMemo.ReadOnly = readOnly;
        StartDateEdit.ReadOnly = readOnly;
        DueDateEdit.ReadOnly = readOnly;
        PriorityComboBox.ReadOnly = readOnly;
        StatusComboBox.ReadOnly = readOnly;
        CompletedTrackBar.ReadOnly = readOnly;
        TaskSaveButton.Visible = !readOnly;

        TaskEditPopup.JSProperties["cpHeaderText"] = string.Format("{0}Task ({1} {2})", readOnly ? string.Empty : "Edit ", task.AssignedEmployee.FirstName, task.AssignedEmployee.LastName);
        if(!readOnly)
            TaskEditPopup.JSProperties["cpTaskID"] = task.Id;
    }

    public override long SaveChanges(string args) {
        var callbackArgs = DemoUtils.DeserializeCallbackArgs(args);
        EmployeeTask task = null;
        if(callbackArgs[0] == "New")
            task = DataProvider.CreateTask();
        else if(callbackArgs[0] == "Edit") {
            long id = long.Parse(callbackArgs[1]);
            task = DataProvider.EmployeeTasks.FirstOrDefault(t => t.Id == id);
        }
        if(task == null)
            return DataProvider.emptyEntryID;

        if(OwnerComboBox.Value != null) {
            long id = long.Parse(OwnerComboBox.Value.ToString());
            task.Owner = DataProvider.Employees.FirstOrDefault(e => e.Id == id);
        }
        if(AssignedToComboBox.Value != null) {
            long id = long.Parse(AssignedToComboBox.Value.ToString());
            task.AssignedEmployee = DataProvider.Employees.FirstOrDefault(e => e.Id == id);
        }
        task.Completion = Convert.ToInt32(CompletedTrackBar.Value);
        task.Description = DetailsMemo.Text;
        task.DueDate = DueDateEdit.Date;
        task.StartDate = StartDateEdit.Date;
        if(task.StartDate > task.DueDate)
            task.StartDate = task.DueDate;
        task.Priority = (EmployeeTaskPriority)Enum.Parse(typeof(EmployeeTaskPriority), PriorityComboBox.Value.ToString());
        if(task.Completion == 100 || task.Completion == 0)
            task.Status = task.Completion == 100 ? EmployeeTaskStatus.Completed : EmployeeTaskStatus.NotStarted;
        else
            task.Status = (EmployeeTaskStatus)Enum.Parse(typeof(EmployeeTaskStatus), StatusComboBox.Value.ToString());
        task.Subject = TaskSubjectTextBox.Text;
        DataProvider.SaveChanges();
        return task.Id;
    }

    protected void FillEmployeeComboBoxes() {
        foreach(var employee in DataProvider.Employees) {
            var fullname = employee.FirstName + " " + employee.LastName;
            OwnerComboBox.Items.Add(fullname, employee.Id);
            AssignedToComboBox.Items.Add(fullname, employee.Id);
        }
    }
}
