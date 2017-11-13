using DevExpress.DXperience.Demos;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraRichEdit;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting.Control;
using System.IO;
using System;
using System.Drawing;
using DevExpress.XtraTreeList.Columns;
using System.Text.RegularExpressions;
using System.ComponentModel;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils;
using System.Windows.Forms;
using DevExpress.Spreadsheet;
using DevExpress.XtraRichEdit.API.Native;


namespace DevExpress.Docs.Demos {
    public class RichEditAPIModule : ApiModuleBase {
        RichEditDocumentServer docServer;

        public RichEditAPIModule() 
            :base() {
        }
        public override string ExamplesFolderName { get { return "RichEditCodeExamples"; } }
        public override string DemoProjectName { get { return "DocsMainDemo"; } }
        
        protected override void CreateDemoComponent() {
            this.docServer = new RichEditDocumentServer();
        }
        protected override object GetEvaluationParameter() {
            return docServer.Document;
        }
        protected override ExampleEvaluatorByTimer CreateEvaluator() {
            RichEditExampleEvaluatorByTimer result = new RichEditExampleEvaluatorByTimer(); //this.components
            result.QueryEvaluate += result_QueryEvaluate;
            result.OnBeforeCompile += result_OnBeforeCompile;
            result.OnAfterCompile += result_OnAfterCompile;
            return result;
        }

        void result_QueryEvaluate(object sender, CodeEvaluationEventArgs e) {
            OnExampleEvaluatorQueryEvaluate(sender, e);
        }

        void result_OnAfterCompile(object sender, OnAfterCompileEventArgs args) {
            if (args.Result) {
                PrintableComponentLink.Component = docServer;
                PrintableComponentLink.CreateDocument();
            }
            CodeEditor.AfterCompile(args.Result);
            docServer.EndUpdate();
        }

        void result_OnBeforeCompile(object sender, EventArgs args) {
            docServer.BeginUpdate();
            docServer.CreateNewDocument();
            CodeEditor.BeforeCompile();
        }
    }
    #region RichEditExampleEvaluatorByTimer
    public class RichEditExampleEvaluatorByTimer : ExampleEvaluatorByTimer {
        public RichEditExampleEvaluatorByTimer()
            : base() {
        }

        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language) {
            if (language == ExampleLanguage.VB)
                return new RichEditVbExampleCodeEvaluator();
            return new RichEditCsExampleCodeEvaluator();
        }
    }
    #endregion
}
