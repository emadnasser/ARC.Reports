using System;
using System.IO;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class UploadControl_MultiFileSelection : Page {
    const string UploadDirectory = "~/UploadControl/UploadImages/";
    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        string resultExtension = Path.GetExtension(e.UploadedFile.FileName);
        string resultFileName = Path.ChangeExtension(Path.GetRandomFileName(), resultExtension);
        string resultFileUrl = UploadDirectory + resultFileName;
        string resultFilePath = MapPath(resultFileUrl);
        e.UploadedFile.SaveAs(resultFilePath);

        UploadingUtils.RemoveFileWithDelay(resultFileName, resultFilePath, 5);

        string name = e.UploadedFile.FileName;
        string url = ResolveClientUrl(resultFileUrl);
        long sizeInKilobytes = e.UploadedFile.ContentLength / 1024;
        string sizeText = sizeInKilobytes.ToString() + " KB";
        e.CallbackData = name + "|" + url + "|" + sizeText;
    }
}
