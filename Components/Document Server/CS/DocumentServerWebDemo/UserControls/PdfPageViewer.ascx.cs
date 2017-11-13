using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.Hosting;
using DevExpress.Pdf;
using DevExpress.Web;

public partial class UserControls_PdfPageViewer : System.Web.UI.UserControl {
    public int PageIndex { 
        get { return (int)Session[Page.AppRelativeVirtualPath + "PageIndex"]; }
        private set { Session[Page.AppRelativeVirtualPath + "PageIndex"] = value; }
    }

    public byte[] DocumentData {
        get { return (byte[])Session[Page.AppRelativeVirtualPath + "DocumentData"]; } 
        private set { 
            Session[Page.AppRelativeVirtualPath + "DocumentData"] = value; 
            PageIndex = 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        if (!ASPxCallbackPanel.IsCallback)
            OnCallback(null, new CallbackEventArgsBase("PN" + PageIndex));
    }
    protected void OnCallback(object source, CallbackEventArgsBase e) {
        Update(e.Parameter);
    }

    private void Update(string parameter) {
        try {
            byte[] documentData = DocumentData;
            if (documentData != null)
                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
                using (MemoryStream dataStream = new MemoryStream(documentData)) {
                    documentProcessor.LoadDocument(dataStream, true);
                    pager.ItemCount = documentProcessor.Document.Pages.Count;
                    int pageIndex;
                    if (String.IsNullOrEmpty(parameter))
                        pageIndex = 0;
                    else {
                        parameter = parameter.Substring(2);
                        if (!Int32.TryParse(parameter, out pageIndex))
                            if (parameter.Equals("P"))
                                pageIndex = 0;
                            else
                                pageIndex = pager.PageCount - 1;
                    }
                    PageIndex = pageIndex;
                    pager.PageIndex = pageIndex;
                    try {
                        using (Bitmap bitmap = documentProcessor.CreateBitmap(pageIndex + 1, 900))
                        using (MemoryStream stream = new MemoryStream()) {
                            bitmap.Save(stream, ImageFormat.Png);
                            pageImage.Src = "data:image/png;base64," + Convert.ToBase64String(stream.GetBuffer());
                        }
                    }
                    catch {
                        pageImage.Src = String.Empty;
                    }
                }
        }
        catch {
        }
    }
    public void UpdateDocument(Stream stream, string parameter) {
        using (BinaryReader reader = new BinaryReader(stream))
            DocumentData = reader.ReadBytes((int)stream.Length);
        Update(parameter);
    }
    public void LoadDocument(string path) {
        using (Stream document = new FileStream(HostingEnvironment.MapPath(path), FileMode.Open, FileAccess.Read))
            LoadDocument(document);
    }
    public void LoadDocument(Stream document) {
        using (BinaryReader reader = new BinaryReader(document))
            DocumentData = reader.ReadBytes((int)document.Length);
    }
    public string LoadDocument(ASPxUploadControl uploadControl) {
        UploadedFile uploadedFile = uploadControl.UploadedFiles[0];
        if (!uploadedFile.IsValid)
            return null;
        DocumentData = uploadedFile.FileBytes;
        try {
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
                using (MemoryStream ms = new MemoryStream(DocumentData))
                    processor.LoadDocument(ms, true);
        }
        catch {
            LoadDocument("~/App_Data/Error.pdf");
        }
        return uploadedFile.FileName;
    }
}
