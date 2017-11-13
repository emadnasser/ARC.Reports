using System;
using System.Drawing;
using DevExpress.Spreadsheet;
using System.Globalization;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetMultiplicationTableModule : SpreadsheetTutorialControl {

        public SpreadsheetMultiplicationTableModule() {
            InitializeComponent();
            RefreshPreview();
        }

        protected override string DefaultFileName { get { return "Multiplication_Table"; } }

        public override IWorkbook CreateBook() {
            MultiplicationTableDocumentGenerator generator = new MultiplicationTableDocumentGenerator(DefaultCulture);
            generator.Width = (int)widthSpinEdit.Value;;
            generator.Height = (int)heightSpinEdit.Value;
            generator.FitToPage = FitToPageCheckEdit.Checked;
            generator.CreateInfoCells = createInfoCellsCheckEdit.Checked;
            generator.UseSharedFormula = useSharedFormulaCheckEdit.Checked;
            return generator.Generate();
        }

        void ParametersChanged(object sender, EventArgs e) {
            RefreshPreview();
        }
    }
}
