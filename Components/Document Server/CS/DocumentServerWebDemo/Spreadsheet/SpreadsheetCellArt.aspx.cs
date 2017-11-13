using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.IO;
using System.Net;
using DevExpress.Spreadsheet;
using System.Drawing;
using DevExpress.Docs.Demos;

public partial class SpreadSheet_SpreadsheetCellArt : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(Request.QueryString.Count < 1)
            return;
        if(Request.QueryString[0].StartsWith("previewImage"))
            LoadPreviewImage();
    }
    protected void OnBtnExportClick(object sender, EventArgs e) {
        using (MemoryStream stream = new MemoryStream(GetPreviewImageBytes())) {
            System.Drawing.Image img = Bitmap.FromStream(stream);
            Bitmap bmp = img as Bitmap;
            if (bmp == null)
                return;
            CellArtDocumentGenerator documentGenerator = new CellArtDocumentGenerator(bmp);
            IWorkbook book = documentGenerator.Generate();
            Stream outputStream = new MemoryStream();
            book.SaveDocument(outputStream, DocumentFormat.OpenXml);
            outputStream.Seek(0, SeekOrigin.Begin);
            outputStream.CopyTo(Response.OutputStream);
        }
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        Response.AddHeader("Content-Disposition", "attachment; filename=DevExpressCellArt.xlsx");
        Response.End();
    }
    protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e) {
        ASPxUploadControl uploadControl = (ASPxUploadControl)sender;
        UploadedFile uploadedFile = uploadControl.UploadedFiles[0];
        if(!IsFileNameCorrect(uploadedFile.FileName)) {
            e.IsValid = false;
            e.ErrorText = "Incorrect file type";
            return;
        }
        if(uploadedFile.IsValid)
            Session["UploadedFile"] = GetBytesFromStream(uploadedFile.FileContent);
        e.CallbackData = Request.Url.AbsolutePath + "?previewImage" + DateTime.Now.Millisecond + "&previewSheet" + DateTime.Now.Millisecond;
    }
    bool IsFileNameCorrect(string fileName) {
        string[] correctNames = new string[] { ".png", ".jpg", ".jpeg", ".jpe", ".gif" };
        int fileNameLength = fileName.Length;
        foreach(string ext in correctNames) {
            int extLength = ext.Length;
            if(fileName.Substring(fileNameLength - extLength, extLength) == ext)
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
    void LoadPreviewImage() {
        Response.StatusCode = (int)HttpStatusCode.OK;
        byte[] imageData = GetPreviewImageBytes();
        Response.ContentType = "image/png";
        Response.BinaryWrite(imageData);
        Response.End();
    }
    byte[] GetPreviewImageBytes() {
        if(Session["UploadedFile"] != null)
            return (byte[])Session["UploadedFile"];
        string path = Page.MapPath("~/App_Data/DevExpress.png");
        FileInfo info = new FileInfo(path);
        using(FileStream stream = info.OpenRead()) {
            return GetBytesFromStream(stream);
        }
    }
}
