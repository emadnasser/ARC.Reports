using System;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;
using DevExpress.XtraScheduler;

public partial class Customization_CustomMenu : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        /*
            The following code utilizes the DataHelper class, which is implemented
            solely for the ASPxScheduler Demo project.
            It is intended to hide unnecessary details and clarify the main idea.
            For the recommended data binding techniques, please refer to the
            Data Binding section modules:
              ~/DataBinding/BoundMode.aspx for MS Access database
              ~/DataBinding/ListBoundMode.aspx for the object with IBindingList interface.
              ~/DataBinding/XPOBoundMode.aspx for XPO data framework.
        */
        SchedulerDemoUtils.ApplyDefaults(this, ASPxScheduler1);
        SchedulerDemoUtils.ApplyWorkTime(this, ASPxScheduler1);
        DataHelper.SetupDefaultMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, AppointmentDataSource);
        DataHelper.SetupStatuses(ASPxScheduler1);
        DataHelper.SetupLabels(ASPxScheduler1);
        ASPxScheduler1.DataBind();
    }

    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == "MNUVIEW")
            e.Command = new CustomMenuViewCallbackCommand(ASPxScheduler1);
        else if(e.CommandId == "USRAPTMENU")
            e.Command = new CustomMenuAppointmentCallbackCommand(ASPxScheduler1);
    }
    protected void ASPxScheduler1_PopupMenuShowing(object sender, DevExpress.Web.ASPxScheduler.PopupMenuShowingEventArgs e) {
        ASPxSchedulerPopupMenu menu = e.Menu;
        MenuItemCollection menuItems = menu.Items;
        if(menu.MenuId.Equals(SchedulerMenuItemId.DefaultMenu)) {
            ClearUnusedDefaultMenuItems(menu);
            AddScheduleNewEventSubMenu(menu, "Schedule New Event");
        } else if(menu.MenuId.Equals(SchedulerMenuItemId.AppointmentMenu)) {
            menu.ClientSideEvents.ItemClick = String.Format("function(s, e) {{ DefaultAppointmentMenuHandler({0}, s, e); }}", ASPxScheduler1.ClientID);
            menu.Items.Clear();
            AddScheduleNewEventSubMenu(menu, "Change Event");
            MenuItem deleteItem = new MenuItem("Delete", "DeleteId");
            deleteItem.BeginGroup = true;
            menuItems.Add(deleteItem);
        }
    }
    protected void AddScheduleNewEventSubMenu(ASPxSchedulerPopupMenu menu, string caption) {
        MenuItem newWithTemplateItem = new MenuItem(caption, "TemplateEvents");
        newWithTemplateItem.BeginGroup = true;
        menu.Items.Insert(0, newWithTemplateItem);
        AddTemplatesSubMenuItems(newWithTemplateItem);
    }
    private static void AddTemplatesSubMenuItems(MenuItem parentMenuItem) {
        parentMenuItem.Items.Add(new MenuItem("Routine", "Routine"));
        parentMenuItem.Items.Add(new MenuItem("Follow-Up", "FollowUp"));
        parentMenuItem.Items.Add(new MenuItem("Urgent", "Urgent"));
        parentMenuItem.Items.Add(new MenuItem("Lab Testing", "LabTesting"));
        parentMenuItem.Items.Add(new MenuItem("Service", "Service"));
    }
    protected void ClearUnusedDefaultMenuItems(ASPxSchedulerPopupMenu menu) {
        RemoveMenuItem(menu, "NewAppointment");
        RemoveMenuItem(menu, "NewAllDayEvent");
        RemoveMenuItem(menu, "NewRecurringAppointment");
        RemoveMenuItem(menu, "NewRecurringEvent");
        RemoveMenuItem(menu, "GotoToday");
        RemoveMenuItem(menu, "GotoDate");
    }
    protected void RemoveMenuItem(ASPxSchedulerPopupMenu menu, string menuItemName) {
        MenuItem item = menu.Items.FindByName(menuItemName);
        if(item != null)
            menu.Items.Remove(item);
    }
}

#region CustomMenuViewCallbackCommand
public enum CustomLabel {
    Routine = 1,
    FollowUp = 2,
    Urgent = 3,
    LabTesting = 4,
    Service = 5
}
public enum CustomStatus {
    Confirmed = 1,
    AwaitingConfirmation = 2,
    Cancelled = 3
}
public class CustomMenuViewCallbackCommand : MenuViewCallbackCommand {
    string myMenuItemId;

    public CustomMenuViewCallbackCommand(ASPxScheduler control)
        : base(control) {
    }

    public string MyMenuItemId { get { return myMenuItemId; } }

    protected override void ParseParameters(string parameters) {
        this.myMenuItemId = parameters;
        base.ParseParameters(parameters);
    }
    protected override void ExecuteCore() {
        ExecuteUserMenuCommand(MyMenuItemId);
        base.ExecuteCore();
    }
    protected internal virtual void ExecuteUserMenuCommand(string menuItemId) {
        if(menuItemId == "Routine")
            CreateAppointment("Name", "Contact info:", CustomStatus.Cancelled, CustomLabel.Routine);
        else if(menuItemId == "FollowUp")
            CreateAppointment("Name", "Contact info:", CustomStatus.AwaitingConfirmation, CustomLabel.FollowUp);
        else if(menuItemId == "Urgent")
            CreateAppointment("Name", "Contact info:", CustomStatus.Confirmed, CustomLabel.Urgent);
        else if(menuItemId == "LabTesting")
            CreateAppointment("Lab Testing", string.Empty, CustomStatus.Confirmed, CustomLabel.LabTesting);
        else if(menuItemId == "Service")
            CreateAppointment("Routine Maintenance", string.Empty, CustomStatus.Cancelled, CustomLabel.Service);
    }
    protected void CreateAppointment(string subject, string description, CustomStatus statusKey, CustomLabel labelKey) {
        Appointment apt = Control.Storage.CreateAppointment(AppointmentType.Normal);
        apt.Subject = subject;
        apt.Description = description;
        apt.Start = Control.SelectedInterval.Start;
        apt.End = Control.SelectedInterval.End;
        apt.ResourceId = Control.SelectedResource.Id;
        apt.StatusKey = (int)statusKey;
        apt.LabelKey = (int)labelKey;
        Control.Storage.Appointments.Add(apt);
    }
}
#endregion

#region CustomMenuAppointmentCallbackCommand
public class CustomMenuAppointmentCallbackCommand : SchedulerCallbackCommand {
    string menuItemId = String.Empty;

    public CustomMenuAppointmentCallbackCommand(ASPxScheduler control)
        : base(control) {
    }

    public override string Id { get { return "USRAPTMENU"; } }
    public string MenuItemId { get { return menuItemId; } }

    protected override void ParseParameters(string parameters) {
        this.menuItemId = parameters;
    }
    protected override void ExecuteCore() {
        Appointment apt = Control.SelectedAppointments[0];
        if(MenuItemId == "DeleteId")
            apt.Delete();
        else if(MenuItemId == "Routine")
            UpdateAppointment(apt, string.Empty, CustomStatus.Cancelled, CustomLabel.Routine);
        else if(MenuItemId == "FollowUp")
            UpdateAppointment(apt, string.Empty, CustomStatus.AwaitingConfirmation, CustomLabel.FollowUp);
        else if(MenuItemId == "Urgent")
            UpdateAppointment(apt, string.Empty, CustomStatus.Confirmed, CustomLabel.Urgent);
        else if(MenuItemId == "LabTesting")
            UpdateAppointment(apt, "Lab Testing", CustomStatus.Confirmed, CustomLabel.LabTesting);
        else if(MenuItemId == "Service")
            UpdateAppointment(apt, "Routine Maintenance", CustomStatus.Cancelled, CustomLabel.Service);
    }
    protected void UpdateAppointment(Appointment apt, string subject, CustomStatus statusKey, CustomLabel labelKey) {
        if(labelKey.Equals(CustomLabel.Service) || labelKey.Equals(CustomLabel.LabTesting)) {
            apt.Subject = subject;
            apt.Description = string.Empty;
        }
        else if((apt.LabelKey.Equals((int)CustomLabel.Service) || apt.LabelKey.Equals((int)CustomLabel.LabTesting)) && !labelKey.Equals(CustomLabel.Service) && !labelKey.Equals(CustomLabel.LabTesting)) {
            apt.Subject = "Name";
            apt.Description = "Contact info:";
        }
        apt.StatusKey = (int)statusKey;
        apt.LabelKey = (int)labelKey;
    }
}
#endregion
