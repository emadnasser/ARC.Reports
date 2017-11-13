using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DevExpress.Web.Demos;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

public partial class Customization_ResourceHeaderLayout : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerDemoUtils.ApplyDefaults(this, DemoScheduler);
        SchedulerDemoUtils.ApplyWorkTime(this, DemoScheduler);
        DataHelper.SetupDefaultMappings(DemoScheduler, true);
        DataHelper.ProvideRowInsertion(DemoScheduler, AppointmentDataSource);
        DataHelper.SetupStatuses(DemoScheduler);
        DataHelper.SetupLabels(DemoScheduler);
        if(!IsPostBack) {
            cbRotateCaption.Checked = DemoScheduler.OptionsView.ResourceHeaders.RotateCaption;
            cbShowCaption.Checked = DemoScheduler.OptionsView.ResourceHeaders.ShowCaption;
            cbResourceColorFillArea.Value = (int)DemoScheduler.OptionsView.ResourceColorFillArea;
            cbImageAlign.Value = (int)DemoScheduler.OptionsView.ResourceHeaders.ImageAlign;
        }
        else {
            DemoScheduler.OptionsView.ResourceHeaders.RotateCaption = cbRotateCaption.Checked;
            DemoScheduler.OptionsView.ResourceHeaders.ShowCaption = cbShowCaption.Checked;
            DemoScheduler.OptionsView.ResourceHeaders.ImageAlign = (HeaderImageAlign)(int)cbImageAlign.Value;
            DemoScheduler.OptionsView.ResourceColorFillArea = (ResourceColorFillArea)(int)cbResourceColorFillArea.Value;
        }
        DemoScheduler.DataBind();
    }
}
