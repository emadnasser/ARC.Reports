using System;
using System.Web.UI;
using DevExpress.Web;

public partial class ImageSlider_BinaryImage : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(rbFiltering.SelectedIndex != 0) {
            ImagesDataSource.Where = string.Format("it.CategoryID = {0}", rbFiltering.Value);
        }
    }
}
