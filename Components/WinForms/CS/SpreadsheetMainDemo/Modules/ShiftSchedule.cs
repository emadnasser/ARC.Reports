using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class ShiftScheduleModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook book;
        CultureInfo culture;
        ShiftScheduleGenerator generator;

        public ShiftScheduleModule() {
            this.culture = DefaultCulture;
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = culture;
            spreadsheetControl1.BeginUpdate();
            book = spreadsheetControl1.Document;
            generator = new ShiftScheduleGenerator(book);
            book = generator.Generate();
            spreadsheetControl1.EndUpdate();
            spreadsheetControl1.Document.History.Clear();
        }
    }
}
