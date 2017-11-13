using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageGallery_CustomImageViewer : Page {
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void cb_Callback(object source, DevExpress.Web.CallbackEventArgs e) {
        ImageGalleryItem item = imageGallery.Items[int.Parse(e.Parameter)];
        e.Result = ResolveUrl(item.ImageUrl);
    }
    protected void imageGallery_DataBound(object sender, EventArgs e) {
        imageGallery.JSProperties["cpCount"] = imageGallery.Items.Count;
    }
}
