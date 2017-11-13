using System;
using System.Web.UI;
using DevExpress.Web.ASPxScheduler;

public partial class Miscellaneous_ClientRenderingMode : System.Web.UI.Page {
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
        SchedulerDemoUtils.ApplyDefaults(this, DemoScheduler);
        DataHelper.SetupDefaultMappings(DemoScheduler);
        DataHelper.ProvideRowInsertion(DemoScheduler, AppointmentDataSource);
        DataHelper.SetupStatuses(DemoScheduler);
        DataHelper.SetupLabels(DemoScheduler);
        if(!IsPostBack)
            cbEnableClientRender.Checked = DemoScheduler.EnableClientRender;
        else
            DemoScheduler.EnableClientRender = cbEnableClientRender.Checked;
        DemoScheduler.DataBind();

    }
}
