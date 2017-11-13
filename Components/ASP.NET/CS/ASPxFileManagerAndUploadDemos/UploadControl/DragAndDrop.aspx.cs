using System;
using System.Drawing;
using System.IO;
using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.Web.Internal;

public partial class UploadControl_DragAndDrop : System.Web.UI.Page {
    const string UploadDirectory = "~/UploadControl/UploadImages/";

    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        e.CallbackData = SavePostedFile(e.UploadedFile);
    }
    protected string SavePostedFile(UploadedFile uploadedFile) {
        if(!uploadedFile.IsValid)
            return string.Empty;
        string fileName = Path.ChangeExtension(Path.GetRandomFileName(), ".jpg");
        string fullFileName = CombinePath(fileName);
        using(Image original = Image.FromStream(uploadedFile.FileContent))
        using(Image thumbnail = new ImageThumbnailCreator(original).CreateImageThumbnail(new Size(350, 350)))
            ImageUtils.SaveToJpeg((Bitmap)thumbnail, fullFileName);
        UploadingUtils.RemoveFileWithDelay(fileName, fullFileName, 5);
        return fileName;
    }
    protected string CombinePath(string fileName) {
        return Path.Combine(Server.MapPath(UploadDirectory), fileName);
    }
}
