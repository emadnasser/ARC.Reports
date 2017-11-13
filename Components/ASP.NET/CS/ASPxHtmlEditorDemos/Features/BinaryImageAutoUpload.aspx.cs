using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using DevExpress.Web;
using DevExpress.Web.ASPxHtmlEditor;
using DevExpress.Web.Demos;

public partial class Features_BinaryImageAutoUpload : System.Web.UI.Page {

    public bool IsAzureAccessKeyNotDefined { get { return string.IsNullOrEmpty(UploadingUtils.GetAzureAccessKey()); } }

    protected void Page_Load(object sender, EventArgs e) {
        DemoFormLayout.Visible = !IsAzureAccessKeyNotDefined;
        WarningDiv.Visible = IsAzureAccessKeyNotDefined;

        DemoHtmlEditor.Settings.AllowSaveBinaryImageToServer = AllowSaveBinaryImageToServerCb.Checked;
        if(!IsPostBack)
            HtmlEditorUtils.SetHtml(this, DemoHtmlEditor, "Features/BinaryImageAutoUploadContent.html");
    }
    protected void DemoHtmlEditor_ImageFileSaving(object source, FileSavingEventArgs e) {
        using(Stream fileContent = e.UploadedFile.FileContent) {
            ImageFormat imageFormat = null;
            using(Image image = GetImageToSave(fileContent, out imageFormat)) {
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, imageFormat);
                e.OutputStream = memoryStream;
                e.FileName = string.Format("{0}_{1}{2}", Path.GetFileNameWithoutExtension(e.FileName), Guid.NewGuid(), Path.GetExtension(e.FileName));
                RemoveFileWithDelay(e.FileName, 5);
            }
        }
        Thread.Sleep(2000);
    }

    void RemoveFileWithDelay(string fileName, int delayInMinutes) {
        UploadControlAzureSettings azureSettings = DemoHtmlEditor.SettingsDialogs.InsertImageDialog.SettingsImageUpload.AzureSettings;
        UploadingUtils.RemoveFileFromAzureWithDelay(fileName, azureSettings.AccountName, azureSettings.ContainerName, 1);
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
