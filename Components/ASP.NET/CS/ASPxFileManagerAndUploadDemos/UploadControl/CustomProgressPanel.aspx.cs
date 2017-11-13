using System.Web.UI;
using DevExpress.Web;

public partial class UploadControl_CustomProgressPanel : Page {
    protected void UploadControl_FilesUploadComplete(object sender, FilesUploadCompleteEventArgs e) {
        foreach(UploadedFile file in UploadControl.UploadedFiles) {
            if(!string.IsNullOrEmpty(file.FileName) && file.IsValid)
                e.CallbackData = "success";
        }
    }
}
