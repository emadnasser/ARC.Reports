using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.iCalendar;
using System.Collections;

public partial class Calendar : System.Web.UI.Page {
    protected void Page_PreInit(object sender, EventArgs e) {        
        Utils.ApplyTheme(this);
    }

    protected void Page_Init(object sender, EventArgs e) {
        if(!IsPostBack)
            Scheduler.Start = new DateTime(DateTime.Now.Year, 04, 06);
        new SchedulerRowInsertionHelper().ProvideRowInsertion(Scheduler, AppointmentDataSource);
        ResourceNavBar.DataBind(); 
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!SchedulerData.GetAppointments().Any())
            ImportCalendarData();
        if(Utils.CurrentTheme == "iOS" || Utils.CurrentTheme == "Material")
            DateNavigator.Properties.Rows = 1;
    }

    protected void Scheduler_FilterAppointment(object sender, PersistentObjectCancelEventArgs e) {
        if(_selectedResourceNameCache == null)
            _selectedResourceNameCache = FindSelectedResourceNames();

        int resourceId;
        Appointment appointment = (Appointment)e.Object;
        if(int.TryParse(appointment.ResourceId.ToString(), out resourceId)) {
            var resource = SchedulerData.GetResources().First(r => r.ID == resourceId);
            e.Cancel = !_selectedResourceNameCache.Contains(resource.Name);
        }
    }

    protected bool GetResourceCheckedState(NavBarItemTemplateContainer container) {
        return container.Item.Group.VisibleIndex == 0 && container.Item.VisibleIndex == 0;
    }
      
    void ImportCalendarData() {
        Scheduler.DataBind();
        new iCalendarImporter(Scheduler.Storage).Import(Server.MapPath("~/App_Data/CalendarData.ics"));
    }

    ISet<string> _selectedResourceNameCache;
    ISet<string> FindSelectedResourceNames() {
        var result = new HashSet<string>();
        for(int i = 0; i < ResourceNavBar.Items.Count; i++) {
            var checkbox = ResourceNavBar.Items[i].FindControl("CheckBox") as ASPxCheckBox;
            if(checkbox != null && checkbox.Checked)
                result.Add(checkbox.Text);
        }
        return result;
    }

}
