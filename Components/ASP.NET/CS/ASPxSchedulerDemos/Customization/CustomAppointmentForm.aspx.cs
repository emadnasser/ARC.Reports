using System;
using DevExpress.Web.ASPxScheduler;

public partial class Customization_CustomAppointmentForm : System.Web.UI.Page {
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
    protected void ASPxScheduler1_AppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
        e.Container = new MyAppointmentFormTemplateContainer((ASPxScheduler)sender);
    }
    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, SchedulerCallbackCommandEventArgs e) {
        if(e.CommandId == SchedulerCallbackCommandId.AppointmentSave)
            e.Command = new MyAppointmentSaveCallbackCommand((ASPxScheduler)sender);
    }
}

