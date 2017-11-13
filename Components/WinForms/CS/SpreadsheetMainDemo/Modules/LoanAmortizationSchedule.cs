using System;
using System.Drawing;
using DevExpress.Spreadsheet;
using DevExpress.DXperience.Demos;
using System.Globalization;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class LoanAmortizationScheduleModule : SpreadsheetRibbonTutorialControlBase {
        IWorkbook book;
        LoanAmortizationScheduleDocumentGenerator generator;

        public LoanAmortizationScheduleModule() {
            InitializeComponent();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            InitializeDocument();
            this.spreadsheetControl1.Document.History.Clear();
        }

        void InitializeDocument() {
            spreadsheetControl1.BeginUpdate();
            book = spreadsheetControl1.Document;
            generator = new LoanAmortizationScheduleDocumentGenerator(book);
            generator.Generate();
            spreadsheetControl1.EndUpdate();
        }

        protected override void spreadsheetControl1_CellValueChangedOverride(object sender, SpreadsheetCellEventArgs e) {
            if (generator == null)
                return;

            if ((e.ColumnIndex == 4) && ((e.RowIndex >= 3) && (e.RowIndex <= 8))) {
                spreadsheetControl1.BeginUpdate();
                generator.Generate();
                spreadsheetControl1.EndUpdate();
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            if (radioGroup1.SelectedIndex == 1)
                generator.AnnuityPayments = false;
            else
                generator.AnnuityPayments = true;
            spreadsheetControl1.BeginUpdate();
            generator.Generate();
            spreadsheetControl1.EndUpdate();
        }

        protected override void spreadsheetControl1_CellEndEditOverride(object sender, SpreadsheetCellValidatingEventArgs e) {
            if (e.ColumnIndex == 4 && e.RowIndex == 5) {
                int value;
                if (!int.TryParse(e.EditorText, out value) || value < 1 || value > 10) {
                    System.Windows.Forms.MessageBox.Show("Please enter a whole number of years from 1 to 10");
                    e.Cancel = true;
                }
            }
        }
    }
}
