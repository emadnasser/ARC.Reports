using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Office.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.Web.Demos {
    public partial class RichEditController : DemoController {
        const string FindAndReplaceFilePath = "~/App_Data/Search.rtf";

        public ActionResult FindAndReplace() {
            RichEditFindAndReplaceModel model = new RichEditFindAndReplaceModel();
            return DemoView("FindAndReplace", model);
        }
        public ActionResult PreviewFindAndReplace(RichEditFindAndReplaceModel model) {
            Stream stream = ExecuteFindAndReplace(DocumentFormat.Html, model.Find, model.Replace, model.ActionToExec);
            return CreatePreviewResult(stream);
        }
        public ActionResult FindAndReplaceExportTo(RichEditFindAndReplaceModel model) {
            DocumentFormat documentFormat = ConvertIndexToFormat(model.ExportToDocumentType);
            Stream stream = ExecuteFindAndReplace(documentFormat, model.Find, model.Replace, model.ActionToExec);
            if (stream == null)
                return new EmptyResult();
            return CreateFileStreamResult(stream, model.ExportToDocumentType);
        }
        Stream ExecuteFindAndReplace(DocumentFormat documentFormat, string find, string replace, string action) {
            RichEditDocumentServer documentServer = CreateDocumentServer();
            documentServer.LoadDocument(MapPath(FindAndReplaceFilePath));
            documentServer.Options.Export.Html.EmbedImages = true;
            switch (action) {
                case "replace":
                    ReplaceAll(documentServer, find, replace);
                    break;
                case "find":
                    FindAll(documentServer, find);
                    break;
            }
            MemoryStream result = new MemoryStream();
            if (documentFormat == DocumentFormat.Undefined) 
                documentServer.ExportToPdf(result);
            else
                documentServer.SaveDocument(result, documentFormat);
            result.Seek(0, SeekOrigin.Begin);
            return result;
        }
        void ReplaceAll(RichEditDocumentServer documentServer, string strFind, string strReplace) {
            if (!String.IsNullOrEmpty(strFind)) {
                DocumentRange[] ranges = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range);
                for (int i = 0; i < ranges.Length; i++) {
                    if (strReplace == "null")
                        strReplace = String.Empty;
                    documentServer.Document.Replace(ranges[i], strReplace);
                    CharacterProperties cp = documentServer.Document.BeginUpdateCharacters(ranges[i]);
                    cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233);
                    documentServer.Document.EndUpdateCharacters(cp);
                };
            }
        }
        void FindAll(RichEditDocumentServer documentServer, string strFind) {
            if (!String.IsNullOrEmpty(strFind)) {
                DocumentRange[] ranges = documentServer.Document.FindAll(strFind, SearchOptions.None, documentServer.Document.Range);
                for (int i = 0; i < ranges.Length; i++) {
                    CharacterProperties cp = documentServer.Document.BeginUpdateCharacters(ranges[i]);
                    cp.BackColor = System.Drawing.Color.FromArgb(180, 201, 233);
                    documentServer.Document.EndUpdateCharacters(cp);
                };
            }
        }
    }  
}
