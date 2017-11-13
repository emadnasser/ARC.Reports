using System;
using System.Web.UI;
using DevExpress.Web.Demos;

public partial class ImageGallery_FolderBinding : Page {

    protected void Page_Load(object sender, EventArgs e) {
        imageGallery.SettingsFolder.ImageSourceFolder = cbSelectFolder.Value.ToString();
        imageGallery.SettingsFolder.ImageCacheFolder = chWatermark.Checked ? @"~\Thumb\ImageGalleryThumbWithWaterMark\" : @"~\Thumb\ImageGalleryThumb\";
        if(chWatermark.Checked)
            imageGallery.CustomImageProcessing += imageGallery_CustomImageProcessing;
        imageGallery.UpdateImageCacheFolder();
    }

    void imageGallery_CustomImageProcessing(object source, DevExpress.Web.ImageGalleryCustomImageProcessingEventArgs e) {
        PhotoUtils.DrawWatermarkText(e.Graphics, "ASPxImageGallery", "Arial");
    }
}
