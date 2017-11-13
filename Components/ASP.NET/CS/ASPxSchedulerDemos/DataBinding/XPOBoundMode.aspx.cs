using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.Demos;
using DevExpress.Xpo;

public partial class DataBinding_XPOBoundMode : System.Web.UI.Page {
    Session xpoSession;
    object lastInsertedId;

    protected void Page_Init(object sender, EventArgs e) {
        InitDataSources();
        SetupMappings();
    }

    void InitDataSources() {
        this.xpoSession = XpoHelper.GetNewSession();
        appointmentDataSource.Session = this.xpoSession;
        resourceDataSource.Session = this.xpoSession;
        appointmentDataSource.Inserted += appointmentDataSource_OnInserted;
    }
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        AttachDataSources();
        if (IsStorageEmpty())
            PopulateDataSources();
        this.xpoSession.BeforeCommitTransaction +=new SessionManipulationEventHandler(xpoSession_BeforeCommitTransaction);
        ASPxScheduler1.OptionsBehavior.ShowDetailedErrorInfo = false;
    }
    void xpoSession_BeforeCommitTransaction(object sender, SessionManipulationEventArgs e) {
        Utils.AssertNotReadOnlyText();
    }
    protected override void OnUnload(EventArgs e) {
        base.OnUnload(e);
        if (this.xpoSession != null)
            this.xpoSession.Dispose();
    }

    private void AttachDataSources() {
        ASPxScheduler1.AppointmentDataSource = appointmentDataSource;
        ASPxScheduler1.ResourceDataSource = resourceDataSource;
        ASPxScheduler1.DataBind();
    }
    private bool IsStorageEmpty() {
        return ASPxScheduler1.Storage.Appointments.Count == 0;
    }

    void SetupMappings() {
        ASPxScheduler1.Storage.BeginUpdate();
        try {
            ASPxAppointmentMappingInfo aptMappings = ASPxScheduler1.Storage.Appointments.Mappings;
            aptMappings.AllDay = "AllDay";
            aptMappings.Description = "Description";
            aptMappings.End = "Finish";
            aptMappings.Label = "Label";
            aptMappings.Location = "Location";
            aptMappings.RecurrenceInfo = "Recurrence";
            aptMappings.ReminderInfo = "Reminder";
            aptMappings.ResourceId = "Employee!Key";
            aptMappings.Start = "Created";
            aptMappings.Status = "Status";
            aptMappings.Subject = "Subject";
            aptMappings.Type = "AppointmentType";
            aptMappings.AppointmentId = "Oid";

            ASPxResourceMappingInfo resourceMappings = ASPxScheduler1.Storage.Resources.Mappings;
            resourceMappings.Caption = "Name";
            resourceMappings.ResourceId = "Oid";
        }
        finally {
            ASPxScheduler1.Storage.EndUpdate();
        }
    }
    void appointmentDataSource_OnInserted(object sender, XpoDataSourceInsertedEventArgs e) {
        this.lastInsertedId = ((XPObject)e.Value).Oid;
    }
    protected void ASPxScheduler1_AppointmentRowInserted(object sender, ASPxSchedulerDataInsertedEventArgs e) {
        e.KeyFieldValue = this.lastInsertedId;
    }

    #region Populate database with initial data
    void PopulateDataSources() {
        for (int i = 0; i < 5; i++) {
            Employee employee = AddEmployee(SchedulerDemoUtils.Users[i]);
            AddTasks(employee);
        }
        ASPxScheduler1.DataBind();
    }
    Employee AddEmployee(string name) {
        Employee employee = new Employee(this.xpoSession);
        employee.Name = name;
        employee.Save();
        return employee;
    }
    void AddTasks(Employee employee) {
        AddTask(employee, "meeting", 2, 5);
        AddTask(employee, "travel", 3, 6);
        AddTask(employee, "phone call", 0, 10);
    }
    void AddTask(Employee employee, string taskName, int status, int label) {
        Task task = new Task(this.xpoSession);
        task.Employee = employee;
        task.Subject = employee.Name + "'s " + taskName;

        int rangeInHours = 72;
        task.Created = SchedulerDemoUtils.BaseDate + TimeSpan.FromHours(SchedulerDemoUtils.RandomInstance.Next(0, rangeInHours));
        task.Finish = task.Created + TimeSpan.FromHours(SchedulerDemoUtils.RandomInstance.Next(0, rangeInHours / 12));

        task.Status = status;
        task.Label = label;

        task.Save();
    }
    #endregion
}
