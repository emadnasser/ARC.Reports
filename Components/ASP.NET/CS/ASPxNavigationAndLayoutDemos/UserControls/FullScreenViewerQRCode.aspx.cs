using System;
using System.Drawing.Imaging;
using System.IO;
using DevExpress.Web.Demos;

public partial class FullScreenViewerQRCode : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        string url = Request.QueryString["url"];
        if(string.IsNullOrEmpty(url))
            return;
        using(var image = FullScreenModeUtils.GetQRCodeImage(url)) {
            using(MemoryStream stream = new MemoryStream()) {
                image.Save(stream, ImageFormat.Png);
                stream.WriteTo(Response.OutputStream);
                Response.End();
            }
        }
    }
}
