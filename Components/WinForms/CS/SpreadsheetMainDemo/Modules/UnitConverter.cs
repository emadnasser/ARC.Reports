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

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class UnitConverterModule : SpreadSheetTutorialControlBase {
        public UnitConverterModule() {
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            this.spreadsheetControl1.Options.Behavior.Selection.MoveActiveCellMode = MoveActiveCellModeOnEnterPress.None;
            InitializeWorkbook();
        }

        void InitializeWorkbook() {
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.LoadDocument(DemoUtils.GetRelativePath("UnitConverter_template.xlsx"));
        }

        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
}
