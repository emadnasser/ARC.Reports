using System;
using System.IO;
using System.Collections.Generic;
using System.Web.SessionState;
using System.Web.UI;
using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.Web.Demos;

public partial class PdfPageMerging : Page {
    class UploadFileInfo {
        readonly string fName;
        readonly string fPath;

        public string Name { get { return fName; } }
        public string Path { get { return fPath; } }

        public UploadFileInfo(string name, string path) {
            fName = name;
            fPath = path;
        }
    }

    const string uploadDirectory = "~/UploadData/";
    const string filesToMergeKey = "FilesToMerge";
    const string mergedFileKey = "MergedFile";
    const string errorKey = "cpError";

    protected void Page_Load(object sender, EventArgs e) {
        List<string> filesList = new List<string>();
        List<UploadFileInfo> fileInfo = Session[filesToMergeKey] as List<UploadFileInfo>;
        if (fileInfo != null)
            foreach (UploadFileInfo file in fileInfo)
                filesList.Add(file.Name + "|" + ResolveClientUrl(file.Path));
        ASPxUploadControl.JSProperties["cpFilesList"] = filesList;
    }
    protected void UploadControl_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        UploadedFile uploadedFile = e.UploadedFile;
        string uploadedFileName = uploadedFile.FileName;
        string uploadedFilePath = uploadDirectory + uploadedFileName;
        string actualUploadedFilePath = MapPath(uploadedFilePath);
        uploadedFile.SaveAs(actualUploadedFilePath);
        UploadingUtils.RemoveFileWithDelay(uploadedFileName, actualUploadedFilePath, 5);
        e.CallbackData = String.Format("{0} ({1}KB)", uploadedFileName, uploadedFile.ContentLength / 1024) + "|" + ResolveClientUrl(uploadedFilePath);
    }
    protected void UploadControl_FilesUploadComplete(object sender, FilesUploadCompleteEventArgs e) {
        ASPxUploadControl uploadControl = ASPxUploadControl;
        try {
            List<UploadFileInfo> fileInfo = new List<UploadFileInfo>();
            UploadedFile[] uploadedFiles = uploadControl.UploadedFiles;
            if (uploadedFiles != null)
                foreach (UploadedFile file in uploadedFiles) {
                    string fileName = file.FileName;
                    if (!String.IsNullOrEmpty(fileName))
                        fileInfo.Add(new UploadFileInfo(fileName, MapPath(uploadDirectory + fileName)));
                }
            HttpSessionState session = Session;
            session[filesToMergeKey] = fileInfo;
            if (fileInfo.Count > 0) {
                MemoryStream stream = new MemoryStream();
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                    documentProcessor.CreateEmptyDocument(stream);
                    foreach (UploadFileInfo uploadFile in fileInfo)
                        documentProcessor.AppendDocument(uploadFile.Path);
                }
                stream.Position = 0;
                session[mergedFileKey] = stream;
            }
            else
                session[mergedFileKey] = null;
            uploadControl.JSProperties[errorKey] = false;
        }
        catch {
            uploadControl.JSProperties[errorKey] = true;
        }
    }
    protected void OnMergeButtonClick(object sender, EventArgs e) {
        Stream stream = (Stream)Session[mergedFileKey];
        if (stream != null)
            using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor()) {
                documentProcessor.LoadDocument(stream);
                PdfDocumentReponse.SendDocument(Response, documentProcessor, "PDF Document Processor - Page Mering", "PDF Page Merging");
            }
    }
}
