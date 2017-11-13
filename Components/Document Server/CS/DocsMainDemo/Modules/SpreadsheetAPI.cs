using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using System;
using System.Diagnostics;
using System.Globalization;

namespace DevExpress.Docs.Demos {
    public class SpreadsheetAPIModule : ApiModuleBase {
        IWorkbook workbook;

        public SpreadsheetAPIModule()
            : base() {

        }
        public override string ExamplesFolderName { get { return "CodeExamples"; } }
        public override string DemoProjectName { get { return "DocsMainDemo"; } }
        public string TestDocumentName { get { return "Document.xlsx"; } }

        protected override void CreateDemoComponent() {
            this.workbook = new Workbook();
        }
        protected override object GetEvaluationParameter() {
            return workbook;
        }
        protected override ExampleEvaluatorByTimer CreateEvaluator() {
            ExampleEvaluatorByTimer evaluator = new SpreadsheetExampleEvaluatorByTimer();

            evaluator.QueryEvaluate += evaluator_QueryEvaluate;
            evaluator.OnBeforeCompile += evaluator_OnBeforeCompile;
            evaluator.OnAfterCompile += evaluator_OnAfterCompile;
            return evaluator;
        }

        void evaluator_QueryEvaluate(object sender, CodeEvaluationEventArgs e) {
            OnExampleEvaluatorQueryEvaluate(sender, e);
        }

        void evaluator_OnAfterCompile(object sender, OnAfterCompileEventArgs args) {
            foreach (Worksheet sheet in workbook.Worksheets)
                sheet.PrintOptions.PrintGridlines = true;

            Worksheet activeSheet = workbook.Worksheets.ActiveWorksheet;
            Range printableRange = activeSheet.GetPrintableRange();
            activeSheet.SelectedCell = printableRange[printableRange.RowCount * printableRange.ColumnCount - 1].Offset(1, 1);
            activeSheet.Visible = true;

            CodeEditor.AfterCompile(args.Result);
            workbook.EndUpdate();
            if (args.Result) {
                PrintableComponentLink.Component = workbook.Worksheets.ActiveWorksheet as DevExpress.XtraPrinting.IPrintable;
                PrintableComponentLink.CreateDocument();
            }
        }

        void evaluator_OnBeforeCompile(object sender, EventArgs e) {
            workbook.BeginUpdate();
            CodeEditor.BeforeCompile();

            workbook.Options.Culture = CultureInfo.InvariantCulture;
            bool loaded = workbook.LoadDocument(DemoUtils.GetRelativePath(TestDocumentName));
            Debug.Assert(loaded);
        }
    }
}
