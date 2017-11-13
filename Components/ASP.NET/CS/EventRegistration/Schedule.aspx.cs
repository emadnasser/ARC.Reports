using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.Web.Internal;
using DevExpress.XtraScheduler;
using EventRegistration;

public partial class Schedule : System.Web.UI.Page {
    ASPxSchedulerStorage Storage { get { return ASPxScheduler1.Storage; } }
    Object lastInsertedAppointmentId;

    bool Attending {
        get {
            return !IsCallback && AttendingSession != null;
        }
    }
    Session AttendingSession {
        get {
            return CurrentData.Sessions.GetById(HttpUtility.UrlEncode(Request.QueryString["attend"]));
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        SetupMappings();
        SetupSchedule();
        FillCategoriesView(DataHelper.Data.Categories);

        if(Attending)
            AttendingSession.Interest = 2;

        ASPxScheduler1.DataBind();

        if(Attending)
            ShowSessionDetails();
    }
    void SetupSchedule() {
        for(int i = 0; i < DataHelper.Data.Days.Count; i++) {
            DateTime date = DataHelper.Data.GetDate(i);
            ASPxTabControl1.Tabs.Add(
                string.Format("{0:MMMM d}", date),
                date.ToString("d", CultureInfo.InvariantCulture)
            );
        }
        
        SelectEventDay(CurrentData.SelectedDayIndex);
        DataHelper.Setup(Storage);
    }
    void SelectEventDay(int dayIndex) {
        ASPxTabControl1.ActiveTabIndex = dayIndex;
        ASPxScheduler1.Start = DataHelper.Data.GetDate(ASPxTabControl1.ActiveTabIndex);
    }

    void FillCategoriesView(List<Category> categories) {
        rpCategories.DataSource = categories;
        rpCategories.DataBind();
    }

    void ShowSessionDetails() {
        SelectEventDay(DataHelper.Data.GetDay(AttendingSession.StartTime.Date));
        Items["attending"] = true;
        ShowAppointmentFormByServerIdCallbackCommand showAppFormCallbackCommand = new ShowAppointmentFormByServerIdCallbackCommand(ASPxScheduler1);
        showAppFormCallbackCommand.Execute(AttendingSession.Id);
    }
    #region #setupmappings
    void SetupMappings() {
        ASPxAppointmentMappingInfo mappings = Storage.Appointments.Mappings;
        Storage.BeginUpdate();
        try {
            mappings.AppointmentId = "Id";
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.Description = "Description";
            mappings.Label = "Interest";
            mappings.ResourceId = "Location";
            mappings.Status = "CategoryId";
        }
        finally {
            Storage.EndUpdate();
        }
        ASPxAppointmentCustomFieldMappingCollection customMappings =
            Storage.Appointments.CustomFieldMappings;
        customMappings.BeginUpdate();
        try {
            customMappings.Add(new AppointmentCustomFieldMapping(CustomFileldNames.Speaker, "Speaker", FieldValueType.String));
            customMappings.Add(new AppointmentCustomFieldMapping(CustomFileldNames.CategoryName, "CategoryName", FieldValueType.String));
            customMappings.Add(new AppointmentCustomFieldMapping(CustomFileldNames.Level, "Level", FieldValueType.Integer));
        }
        finally {
            customMappings.EndUpdate();
        }
    }
    #endregion #setupmappings

    //Initializing ObjectDataSource
    #region #objectcreated
    protected void appointmentsDataSource_ObjectCreated(object sender, ObjectDataSourceEventArgs e) {
        e.ObjectInstance = new SessionDataSource(CurrentData.Sessions);
    }
    #endregion #objectcreated

    // User generated appointment id
    #region #appointmentid
    protected void ASPxScheduler1_AppointmentInserted(object sender, PersistentObjectsEventArgs e) {
        SetAppointmentId(sender, e);
    }
    protected void appointmentsDataSource_Inserted(object sender, ObjectDataSourceStatusEventArgs e) {
        this.lastInsertedAppointmentId = e.ReturnValue;
    }
    void SetAppointmentId(object sender, PersistentObjectsEventArgs e) {
        ASPxSchedulerStorage storage = (ASPxSchedulerStorage)sender;
        Appointment apt = (Appointment)e.Objects[0];
        storage.SetAppointmentId(apt, this.lastInsertedAppointmentId);
    }
    #endregion #appointmentid

    protected void ASPxScheduler1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
        e.Menu.Items.Clear();
    }

    protected void ASPxScheduler1_PrepareAppointmentFormPopupContainer(object sender, ASPxSchedulerPrepareFormPopupContainerEventArgs e) {
        e.Popup.HeaderText = e.Popup.HeaderText.Replace(" - Appointment", "");
        e.Popup.Height = 0;
        e.Popup.ShowShadow = false;
    }

    protected void ASPxScheduler1_HtmlTimeCellPrepared(object sender, ASPxSchedulerTimeCellPreparedEventArgs e) {
        ASPxScheduler scheduler = sender as ASPxScheduler;
        bool isBreak = false;
        for(int i = 0; i < DataHelper.Data.Breaks.Count && !isBreak; i++)
            isBreak = e.Interval.IntersectsWithExcludingBounds(DataHelper.Data.Breaks[i]);        
        string cellCssClass = isBreak
            ? "breakCell "
            : "";

        ASPxResourceStorage resources = scheduler.Storage.Resources;
        if (e.Resource.MatchIds(resources[0]))
            cellCssClass += "leftCell ";
        if(e.Resource.MatchIds(resources[resources.Count - 1]))
            cellCssClass += "rightCell ";
        if(e.Interval.End.Minute == 0)
            cellCssClass += "lastInHourCell";
        e.Cell.CssClass = RenderUtils.CombineCssClasses(cellCssClass, e.Cell.CssClass);
    }
    protected void ASPxScheduler1_VisibleIntervalChanged(object sender, EventArgs e)
    {
        CurrentData.SelectedDayIndex = DataHelper.Data.GetDay((sender as ASPxScheduler).Start);        
    }
}
