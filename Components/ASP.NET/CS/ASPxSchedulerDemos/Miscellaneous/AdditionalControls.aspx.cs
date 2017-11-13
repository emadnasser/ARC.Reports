using System;
using System.Drawing;
using System.Web.UI.WebControls;

public partial class Miscellaneous_AdditionalControls : System.Web.UI.Page {
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

        SetRelatedControlStyles();
    }
    protected void SetRelatedControlStyles() {
        ASPxResourceNavigator1.Images.Assign(ASPxScheduler1.Images.ResourceNavigator);
        ASPxResourceNavigator1.Styles.Assign(ASPxScheduler1.Styles.ResourceNavigator);
        ASPxResourceNavigator1.ControlStyle.Width = Unit.Pixel(648);
        ASPxResourceNavigator1.ControlStyle.BackColor = Color.Transparent;
        ASPxResourceNavigator1.ControlStyle.BorderStyle = BorderStyle.None;
        ASPxViewNavigator1.Images.Assign(ASPxScheduler1.Images.ViewNavigator);
        ASPxViewNavigator1.Styles.Assign(ASPxScheduler1.Styles.ViewNavigator);
        ASPxViewSelector1.Styles.Assign(ASPxScheduler1.Styles.ViewSelector);
        ASPxViewSelector1.Styles.ControlStyle.BackColor = Color.Transparent;
        ASPxViewSelector1.Styles.ControlStyle.BackgroundImage.ImageUrl = "None";
        ASPxViewSelector1.Styles.Button.Width = Unit.Pixel(240);
        ASPxViewSelector1.Styles.ControlStyle.Paddings.Padding = Unit.Pixel(0);
        ASPxViewSelector1.Styles.ControlStyle.Paddings.PaddingBottom = Unit.Pixel(0);
    }
}
