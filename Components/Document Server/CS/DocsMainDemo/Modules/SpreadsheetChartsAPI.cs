using DevExpress.DXperience.Demos;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace DevExpress.Docs.Demos {
    public class ChartsAPIModule : ApiModuleBase {
        IWorkbook workbook;

        public ChartsAPIModule()
            : base() {

        }
        public override string ExamplesFolderName { get { return "CodeExamples\\Charts"; } }
        public override string DemoProjectName { get { return "DocsMainDemo"; } }
        public string TestDocumentName { get { return "Document.xlsx"; } }

        protected override void CreateDemoComponent() {
            this.workbook = new Workbook();
            workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
            workbook.AddService(typeof(IChartImageService), new ChartImageService());
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
            foreach (Worksheet sheet in workbook.Worksheets) {
                sheet.PrintOptions.PrintGridlines = false;
            }

            Worksheet firstSheet = workbook.Worksheets[0];
            Range usedRange = firstSheet.GetUsedRange();
            firstSheet.SelectedCell = usedRange[usedRange.RowCount * usedRange.ColumnCount - 1].Offset(1, 1);

            CodeEditor.AfterCompile(args.Result);
            workbook.EndUpdate();
            if (args.Result) {
                workbook.Worksheets.ActiveWorksheet.Visible = true;
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

        protected override void RearrangeExamples(List<CodeExampleGroup> examples) {
            for (int i = 0; i < examples.Count; i++) {
                CodeExampleGroup group = examples[i];
                if (group.Name == "Charts") {
                    examples.RemoveAt(i);
                    examples.Insert(0, group);
                    break;
                }
            }
            for (int i = 0; i < examples.Count; i++) {
                CodeExampleGroup group = examples[i];
                if (group.Name.StartsWith("Creation")) {
                    examples.RemoveAt(i);
                    examples.Insert(1, group);
                    break;
                }
            }
        }
    }
}
