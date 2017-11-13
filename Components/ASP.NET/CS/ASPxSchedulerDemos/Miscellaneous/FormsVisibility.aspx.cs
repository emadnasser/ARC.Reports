using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;

public partial class Miscellaneous_FormsVisibility : System.Web.UI.Page {
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

        ApplyOptions();
    }
    void ApplyOptions() {
        ASPxSchedulerOptionsForms options = ASPxScheduler1.OptionsForms;
        options.BeginUpdate();
        try {
            SchedulerFormVisibility value = (SchedulerFormVisibility)rbVisibility.Value;
            options.AppointmentFormVisibility = value;
            options.GotoDateFormVisibility = value;
        } finally {
            options.EndUpdate();
        }
    }
}
