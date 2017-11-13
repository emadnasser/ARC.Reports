using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.Demos;
using DevExpress.Compression;
using System.IO;
using System.Net;

public partial class Compression_Compress : System.Web.UI.Page {
    const string UploadDirectory = "~/UploadData/";
    protected void Page_Load(object sender, EventArgs e) {
    }
    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        string resultFilePath = GetResultFilePath(e.UploadedFile.FileName);
        e.UploadedFile.SaveAs(MapPath(resultFilePath));
        UploadingUtils.RemoveFileWithDelay(e.UploadedFile.FileName, MapPath(resultFilePath), 5);
        string file = string.Format("{0} ({1}KB)", e.UploadedFile.FileName, e.UploadedFile.ContentLength / 1024);
        string url = ResolveClientUrl(resultFilePath);
        e.CallbackData = file + "|" + url;
    }
    protected void UploadControl_FilesUploadComplete(object sender, DevExpress.Web.FilesUploadCompleteEventArgs e){
        List<UploadFileInfo> filesToCompress = new List<UploadFileInfo>();
        ASPxUploadControl uploadControl = sender as ASPxUploadControl;
        if (uploadControl.UploadedFiles != null && uploadControl.UploadedFiles.Length > 0){
            for (int i = 0; i < uploadControl.UploadedFiles.Length; i++){
                UploadedFile file = uploadControl.UploadedFiles[i];
                if (file.FileName != ""){
                    string resultFilePath = GetResultFilePath(file.FileName);
                    filesToCompress.Add(new UploadFileInfo(file.FileName, MapPath(resultFilePath)));
                }
            }
        }
        if (filesToCompress.Count <= 0)
            return;
        Session["FilesToCompress"] = filesToCompress;
    }
    string GetResultFilePath(string fileName) {
        return UploadDirectory + fileName;
    }
    protected void OnBtnCompressClick(object sender, EventArgs e) {
        if (Session["FilesToCompress"] == null)
            return;
        List<UploadFileInfo> files = Session["FilesToCompress"] as List<UploadFileInfo>;
        if (files == null)
            return;
        ZipArchive archive = new ZipArchive();
        foreach (UploadFileInfo uploadFile in files) {
            archive.AddFile(uploadFile.Path, "/");
        }
        using (Stream stream = new MemoryStream()) {
            archive.Save(stream);
            stream.Seek(0, SeekOrigin.Begin);
            Stream outputStream = Response.OutputStream;
            stream.CopyTo(outputStream);
        }
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "application/x-compress";
        Response.AddHeader("Content-Disposition", "attachment; filename=DocumentServerCompressionDemo.zip");
        Response.End();
    }
}
class UploadFileInfo {
    public UploadFileInfo(string name, string path) {
        Name = name;
        Path = path;
    }
    public string Name { get; set; }
    public string Path { get; set; }
}
