using System;
using System.Web.UI;

public partial class ImageSlider_FolderBinding : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            ASPxImageSlider1.ImageSourceFolder = cbSelectFolder.Value.ToString();
    }
    protected void cbSelectFolder_SelectedIndexChanged(object sender, EventArgs e) {
        ASPxImageSlider1.ImageSourceFolder = cbSelectFolder.Value.ToString();
    }
}
