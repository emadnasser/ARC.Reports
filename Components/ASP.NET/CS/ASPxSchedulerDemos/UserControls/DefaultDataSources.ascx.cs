using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.Demos;

public partial class DefaultDataSources : System.Web.UI.UserControl {
    bool initAppointments = true;
    string uniqueSessionPrefix = String.Empty;
    bool resourceSharing = false;

    public bool InitAppointments { get { return initAppointments; } set { initAppointments = value; } }
    public string UniqueSessionPrefix { get { return uniqueSessionPrefix; } set { uniqueSessionPrefix = value; } }
    string CustomEventsSessionName { get { return UniqueSessionPrefix + "CustomEvents"; } }
    string CustomResourcesSessionName { get { return UniqueSessionPrefix + "CustomResources"; } }
    public bool ResourceSharing { get { return resourceSharing; } set { resourceSharing = value; } }

    public DataSourceControl AppointmentDataSource {
        get { return temporaryAppointmentDataSource; }
    }
    public DataSourceControl ResourceDataSource {
        get { return temporaryResourceDataSource; }
    }

    public void AttachTo(ASPxScheduler control) {
        control.ResourceDataSource = this.ResourceDataSource;
        control.AppointmentDataSource = this.AppointmentDataSource;
        control.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void temporaryAppointmentDataSource_ObjectCreated(object sender, ObjectDataSourceEventArgs e) {
        CustomEventList events = GetCustomEvents();
        e.ObjectInstance = new CustomEventDataSource(events);
    }
    protected void temporaryResourceDataSource_ObjectCreated(object sender, ObjectDataSourceEventArgs e) {
        CustomResourceList resources = GetCustomResources();
        e.ObjectInstance = new CustomResourceDataSource(resources);
    }
    public CustomEventList GetCustomEvents() {
        CustomEventList events = Session[CustomEventsSessionName] as CustomEventList;
        if(events != null)
            return events;

        events = InitAppointments ? SchedulerDemoUtils.CreateCustomEvents(ResourceSharing) : new CustomEventList();
        Session[CustomEventsSessionName] = events;
        return events;
    }
    protected CustomResourceList GetCustomResources() {
        CustomResourceList resources = Session[CustomResourcesSessionName] as CustomResourceList;
        if(resources != null)
            return resources;

        resources = SchedulerDemoUtils.CreateCustomResurces();
        Session[CustomResourcesSessionName] = resources;
        return resources;
    }
}
