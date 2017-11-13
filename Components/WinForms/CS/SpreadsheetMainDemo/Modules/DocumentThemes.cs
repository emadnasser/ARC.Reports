using System;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class DocumentThemesModule : SpreadSheetTutorialControlBase {
        SpreadsheetControl spreadsheetControl1;
        DocumentThemesDocumentGenerator generator;

        public DocumentThemesModule() {
            InitializeComponent();
            this.generator = new DocumentThemesDocumentGenerator();
            InitializeBook();
            this.spreadsheetControl1.Options.Culture = DefaultCulture;
            this.spreadsheetControl1.Document.History.Clear();
        }
        void InitializeBook() {
            generator.Generate(spreadsheetControl1.Document);
            comboBoxEdit1.SelectedIndex = 0;
        }
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if (!this.generator.IsValidDocument())
                return;

            spreadsheetControl1.BeginUpdate();

            switch(comboBoxEdit1.SelectedIndex) {
                case 0:
                    this.generator.ApplyThemeGreen();
                    break;
                case 1:
                    this.generator.ApplyThemeOrange();
                    break;
                case 2:
                    this.generator.ApplyThemeRed();
                    break;
                case 3:
                    this.generator.ApplyThemeViolet();
                    break;
                default:
                    this.generator.ApplyThemeBlue();
                    break;
            }

            this.generator.FormatCells();
            spreadsheetControl1.EndUpdate();
            spreadsheetControl1.Document.History.Clear();
        }
        protected override void DoShow() {
            base.DoShow();
            spreadsheetControl1.Focus();
        }
    }
}
