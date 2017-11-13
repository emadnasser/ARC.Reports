using System;
using DevExpress.Web;
using System.IO;
using DevExpress.XtraRichEdit;
using System.Net;
using DevExpress.Office.Services;
using DevExpress.Web.Office;

public partial class RichEdit_Export : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        lblCurrentDocument.Text = GetFileName();
        UpdateDocumentPreview();
    }
    bool UpdateDocumentPreview() {
        return true;
    }

    RichEditDocumentServer CreateDocumentServer() {
        RichEditDocumentServer documentServer = new RichEditDocumentServer();
        documentServer.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
        using (Stream documentStream = GetDocumentStream()) {
            documentServer.LoadDocument(documentStream, GetDocumentType());
        }
        documentServer.Options.Export.Html.EmbedImages = true;
        return documentServer;
    }
    protected void OnBtnExportClick(object sender, EventArgs e) {
        RichEditDocumentServer documentServer = CreateDocumentServer();
        using (MemoryStream stream = new MemoryStream()) {
            int value = (int)cbDownloadType.Value;
            if (value == 4) {
                documentServer.ExportToPdf(stream);
            } else {
                DocumentFormat format = ConvertIndexToFormat(value);
                documentServer.SaveDocument(stream, format);
            }
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(Response.OutputStream);
            Response.StatusCode = (int)HttpStatusCode.OK;
            Response.ContentType = ConvertIndexToContentType(value);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Export.{0}", ConvertIndexToFileExtension(value)));
            Response.End();
        }
    }
    DocumentFormat ConvertIndexToFormat(int value) {
        switch (value) {
            case 1:
                return DocumentFormat.Rtf;
            case 2:
                return DocumentFormat.Doc;
            case 3:
                return DocumentFormat.OpenXml;
            case 5:
                return DocumentFormat.PlainText;
            case 6:
                return DocumentFormat.Mht;
            case 7:
                return DocumentFormat.OpenDocument;
            case 8:
                return DocumentFormat.WordML;
            case 9:
                return DocumentFormat.ePub;
            case 10:
                return DocumentFormat.Html;
        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch (value) {
            case 1:
                return "application/msword";
            case 2:
                return "application/msword";
            case 3:
                return "application/msword";
            case 4:
                return "application/msword";
            case 5:
                return "text/plain";
            case 6:
                return "message/rfc822";
            case 7:
                return "application/msword";
            case 8:
                return "text/xml";
            case 9:
                return "application/msword";
            case 10:
                return "text/html";
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch (value) {
            case 1:
                return "rtf";
            case 2:
                return "doc";
            case 3:
                return "docx";
            case 4:
                return "pdf";
            case 5:
                return "txt";
            case 6:
                return "mht";
            case 7:
                return "odt";
            case 8:
                return "xml";
            case 9:
                return "epub";
            case 10:
                return "html";
        }
        return String.Empty;
    }
    protected void ASPxUploadControl1_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
        ASPxUploadControl uploadControl = (ASPxUploadControl)sender;
        UploadedFile uploadedFile = uploadControl.UploadedFiles[0];
        if (!IsFileNameCorrect(uploadedFile.FileName)) {
            e.IsValid = false;
            e.ErrorText = "Incorrect file type";
            return;
        }
        if (uploadedFile.IsValid) {
            Session["UploadedFile"] = GetBytesFromStream(uploadedFile.FileContent);
            Session["FileName"] = uploadedFile.FileName;
            e.CallbackData = uploadedFile.FileName;
        }
    }
    bool IsFileNameCorrect(string fileName) {
        string[] correctNames = new string[] { ".rtf", ".doc", ".docx", ".txt", ".mht", ".odt", ".xml", ".epub", ".html" };
        int fileNameLength = fileName.Length;
        foreach (string ext in correctNames) {
            int extLength = ext.Length;
            if (fileName.Substring(fileNameLength - extLength, extLength) == ext)
                return true;
        }
        return false;
    }
    byte[] GetBytesFromStream(Stream stream) {
        stream.Position = 0;
        byte[] buf = new byte[stream.Length];
        stream.Read(buf, 0, (int)stream.Length);
        return buf;
    }
    Stream GetDocumentStream() {
        if (Session["UploadedFile"] != null) {
            byte[] resultBytes = (byte[])Session["UploadedFile"];
            return new MemoryStream(resultBytes);
        }
        return null;
    }
    String GetFileName() {
        if (Session["FileName"] != null)
            return Session["FileName"] as string;
        return String.Empty;
    }
    String GetFileExtension() {
        String fileName = GetFileName();
        int indx = fileName.IndexOf(".");
        if (indx < 0)
            return fileName;
        indx++;
        return fileName.Substring(indx, fileName.Length - indx);
    }
    DocumentFormat GetDocumentType() {
        string extension = GetFileExtension();
        switch (extension) {
            case "rtf":
                return DocumentFormat.Rtf;
            case "doc":
                return DocumentFormat.Doc;
            case "docx":
                return DocumentFormat.OpenXml;
            case "txt":
                return DocumentFormat.PlainText;
            case "mht":
                return DocumentFormat.Mht;
            case "odt":
                return DocumentFormat.OpenDocument;
            case "xml":
                return DocumentFormat.WordML;
            case "epub":
                return DocumentFormat.ePub;
            case "html":
                return DocumentFormat.Html;
        }
        return DocumentFormat.OpenXml;
    }
}
