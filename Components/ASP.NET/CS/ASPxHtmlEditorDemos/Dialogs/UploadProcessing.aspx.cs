using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class Dialogs_UploadProcessing : Page {

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Dialogs/UploadProcessing.html");
    }

    protected void DemoHtmlEditor_ImageFileSaving(object source, FileSavingEventArgs e) {
        using(Stream fileContent = e.UploadedFile.FileContent) {
            ImageFormat imageFormat = null;
            using(Image image = GetImageToSave(fileContent, out imageFormat)) {
                if(!string.IsNullOrEmpty(WatermarkTextBox.Text))
                    PhotoUtils.DrawWatermarkText(image, WatermarkTextBox.Text);
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, imageFormat);

                e.OutputStream = memoryStream;
                if(!string.IsNullOrEmpty(FileNamePrefixTextBox.Text))
                    e.FileName = string.Format("{0}_{1}", FileNamePrefixTextBox.Text, e.FileName); 
            }
        }
    }
    Image GetImageToSave(Stream stream, out ImageFormat originalFormat) {
        Image uploadedImage = Image.FromStream(stream);
        originalFormat = uploadedImage.RawFormat;
        if(uploadedImage.Height < (int)MaxHeightSpinEdit.Number && uploadedImage.Width < (int)MaxWidthSpinEdit.Number)
            return uploadedImage;
        using(uploadedImage) 
            return PhotoUtils.GetReducedImage(uploadedImage, (int)MaxWidthSpinEdit.Number, (int)MaxHeightSpinEdit.Number);
    }
}
