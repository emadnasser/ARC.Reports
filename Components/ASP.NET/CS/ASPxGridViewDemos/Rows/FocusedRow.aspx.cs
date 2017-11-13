using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

public partial class Rows_FocusedRow : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!string.IsNullOrEmpty(Request.Params["Photo"])) {
            PostImage(Request.Params["Photo"]);
        }
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
                    bmp.Save(Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        } else {
            Response.ContentType = "image/gif";
        }
        Response.End();
    }
    byte[] FindImage(string id) {
        using(NorthwindContext context = new NorthwindContext()) {
            int employeeId = Convert.ToInt32(id);
            var employee = context.Employees.Single(em => em.EmployeeID == employeeId);
            return employee.Photo;
        }
    }

}
