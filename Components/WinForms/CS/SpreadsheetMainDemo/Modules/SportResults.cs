using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using System.Globalization;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SportResultsModule : SpreadsheetRibbonTutorialControlBase {
        public SportResultsModule() {
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            IWorkbook book = spreadsheetControl1.Document;
            GenerateDocument(book);
            book.History.Clear();
        }
        void GenerateDocument(IWorkbook book) {
            spreadsheetControl1.BeginUpdate();
            try {
                SportResultsDocumentGenerator generator = new SportResultsDocumentGenerator(book);
                generator.Generate();
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }
    }
}
