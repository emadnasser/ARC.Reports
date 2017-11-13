using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

public partial class RichEdit_FindAndReplace : System.Web.UI.Page {
    #region Fields
    const string ServerFilePath = "~/App_Data/Search.rtf";
    RichEditDocumentServer docServer = null;
    #endregion

    public RichEdit_FindAndReplace()
        : base() {
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(Request.QueryString.Count > 0 && Request.QueryString[0].StartsWith("preview")) {
            string strFind = Request.Params["find"];
            if(string.IsNullOrEmpty(strFind))
                strFind = String.Empty;
            string strReplace = Request.Params["replace"];
            if(string.IsNullOrEmpty(strReplace))
                strReplace = String.Empty;
            string strAction = Request.Params["action"];
            if(string.IsNullOrEmpty(strAction))
                strAction = String.Empty;
            RefreshPreview(strFind, strReplace, strAction);
        }
    }
    protected void OnBtnExportClick(object sender, EventArgs e) {
        using (MemoryStream stream = new MemoryStream()) {
            docServer = (RichEditDocumentServer)Session["UploadedFile"];
            int value = (int)cbDownloadType.Value;
            if (EnforceDocServer()) {
                if (value == 4) {
                    docServer.ExportToPdf(stream);
                } else {
                    DocumentFormat format = ConvertIndexToFormat(value);
                    docServer.SaveDocument(stream, format);
                }
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(Response.OutputStream);
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            Response.ContentType = ConvertIndexToContentType(value);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Search.{0}", ConvertIndexToFileExtension(value)));
            Response.End();
        }
    }
    DocumentFormat ConvertIndexToFormat(int value) {
        switch(value) {
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

        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch(value) {
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
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch(value) {
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
        }
        return String.Empty;
    }
    void RefreshPreview(string strFind, string strReplace, string strAction) {
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";
        if(EnforceDocServer()) {
            using (Stream outputStream = CreateOutputStream(strFind, strReplace, strAction)) {
                if (outputStream != null) {
                    outputStream.Seek(0, SeekOrigin.Begin);
                    outputStream.CopyTo(Response.OutputStream);
                }
            }
        }
        Response.End();
    }
    Stream CreateOutputStream(string strFind, string strReplace, string strAction) {
        Stream result = null;
        if(tbFind == null)
            return null;

        docServer.LoadDocument(Page.MapPath(ServerFilePath));
        Session["UploadedFile"] = docServer;
        docServer.Options.Export.Html.EmbedImages = true;
        result = new MemoryStream();
        switch(strAction) {
            case "replace":
                ReplaceAll(strFind, strReplace);
                break;
            case "find":
                FindAll(strFind);
                break;
        }
        docServer.SaveDocument(result, DocumentFormat.Html);
        return result;
    }
    bool EnforceDocServer() {
        if(docServer == null) {
            docServer = new RichEditDocumentServer();
        }
        if(docServer == null) {
            return false;
        }
        return true;
    }
    private void ReplaceAll(string strFind, string strReplace) {
        if(!String.IsNullOrEmpty(strFind)) {
            DocumentRange[] ranges = docServer.Document.FindAll(strFind, SearchOptions.None, docServer.Document.Range);
            for(int i = 0; i < ranges.Length; i++) {
                if(strReplace == "null")
                    strReplace = String.Empty;
                docServer.Document.Replace(ranges[i], strReplace);
                CharacterProperties cp = docServer.Document.BeginUpdateCharacters(ranges[i]);
                cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233);
                docServer.Document.EndUpdateCharacters(cp);
            };
        }
    }
    private void FindAll(string strFind) {
        if(!String.IsNullOrEmpty(strFind)) {
            DocumentRange[] ranges = docServer.Document.FindAll(strFind, SearchOptions.None, docServer.Document.Range);
            for(int i = 0; i < ranges.Length; i++) {
                CharacterProperties cp = docServer.Document.BeginUpdateCharacters(ranges[i]);
                cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233);
                docServer.Document.EndUpdateCharacters(cp);
            };
        }
    }

}
