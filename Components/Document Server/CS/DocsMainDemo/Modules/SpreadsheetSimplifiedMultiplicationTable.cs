using System;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetSimplifiedMultiplicationTableModule : SpreadsheetTutorialControl {

        public SpreadsheetSimplifiedMultiplicationTableModule() {
            InitializeComponent();
            RefreshPreview();
        }

        protected override string DefaultFileName { get { return "Simplified_Multiplication_Table"; } }

        public override IWorkbook CreateBook() {
            SimplifiedMultiplicationTableDocumentGenerator generator = new SimplifiedMultiplicationTableDocumentGenerator(DefaultCulture);
            generator.ColumnCount = (int)columnsSpinEdit.Value;
            generator.TableCount = (int)tableCountSpinEdit.Value;
            generator.FitToPage = FitToPageCheckEdit.Checked;
            return generator.Generate();            
        }
        void spinEdit_EditValueChanged(object sender, EventArgs e) {
            RefreshPreview();
        }
    }
}
