using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using DevExpress.Web.Demos;

public partial class Templates_ResourceHeaderTemplate : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!string.IsNullOrEmpty(Request.Params["Image"]))
            PostImage(Request.Params["Image"]);

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
    void PostImage(string id) {
        byte[] image = FindImage(id);
        WriteBinaryImage(image);
    }
    void WriteBinaryImage(byte[] image) {
        if(image != null) {
            Response.ContentType = "image/jpeg";
            using(MemoryStream ms = new MemoryStream(image)) {
                using(Bitmap bmp = (Bitmap)Bitmap.FromStream(ms)) {
                    Bitmap thumb = new Bitmap(bmp, new Size(120, 120));
                    thumb.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        } else {
            Response.ContentType = "image/gif";
        }
        Response.End();
    }
    byte[] FindImage(string id) {
        if(!Utils.IsSiteMode) {
            using(var context = new MedicsSchedulingDBContext()) {
                int medicID = Convert.ToInt32(id);
                return context.Medics.Single(medic => medic.ID.Equals(medicID)).PhotoBytes;
            }
        } else {
            // Site Mode support
            string virtualPath = String.Format("~/App_Data/resource_{0}.jpg", id);
            string path = Page.MapPath(virtualPath);
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists) {
                virtualPath = "~/App_Data/resource_1.jpg";
                path = Page.MapPath(virtualPath);
                fi = new FileInfo(path);
            }
            using (FileStream stream = fi.OpenRead()) {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return bytes;
            }
        }
    }
}
