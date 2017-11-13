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

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HyperlinksModule : SpreadsheetRibbonTutorialControlBase {
        public HyperlinksModule() {
            InitializeComponent();
            InitializeWorkbook();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            this.spreadsheetControl1.Options.View.ShowPrintArea = false;
        }
        void InitializeWorkbook() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            workbook.LoadDocument(DemoUtils.GetRelativePath("Hyperlinks_template.xlsx"));
        }
    }
}
