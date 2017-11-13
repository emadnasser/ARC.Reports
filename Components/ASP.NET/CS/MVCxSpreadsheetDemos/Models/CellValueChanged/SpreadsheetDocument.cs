using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;
using DevExpress.XtraSpreadsheet;

namespace DevExpress.Web.Demos {
    public class SpreadsheetDocument {
        public string DocumentId { get; private set; }
        public DocumentFormat DocumentFormat { get; private set; }
        public byte[] Document { get; private set; }
        public SpreadsheetDocument() : this(string.Empty, DocumentFormat.Xls) { }
        public SpreadsheetDocument(string fileName, DocumentFormat format) {
            var templatePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, fileName);
            DocumentId = DocumentIdGenerator.GenerateDocumentId();
            DocumentFormat = format;
            if (File.Exists(templatePath))
                Document = File.ReadAllBytes(templatePath);
        }
    }

    public static class DocumentIdGenerator {
        public const string CellValueChangedDocumentIdPrefix = "CellValueChangedDemo_";

        public static string GenerateDocumentId() {
            return CellValueChangedDocumentIdPrefix + Guid.NewGuid().ToString();
        }
    }
}
