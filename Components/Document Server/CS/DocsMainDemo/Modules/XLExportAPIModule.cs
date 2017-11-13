using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Docs.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.Export.Xl;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Microsoft.Build.Evaluation;
using Microsoft.CSharp;

namespace DevExpress.Docs.Demos {
    #region XLExportAPIModule
    public class XLExportAPIModule : TutorialControlBase {
        TreeList treeList1;
        SplitContainerControl verticalSplitContainerControl1;
        XtraTab.XtraTabControl xtraTabControl1;
        XtraTab.XtraTabPage xtraTabPage1;
        RichEditControl richEditControlCS;
        XtraTab.XtraTabPage xtraTabPage2;
        RichEditControl richEditControlVB;
        LabelControl codeExampleNameLbl;
        PanelControl pnlButtons;
        SimpleButton btnExportToCSV;
        SimpleButton btnExportToXLS;
        SimpleButton btnExportToXLSX;

        ExampleCodeEditor codeEditor;
        bool treeListRootNodeLoading = true;
        private CheckEdit chbOpenResultingFile;
        List<CodeExampleGroup> examples;

        public XLExportAPIModule() {
            InitializeComponent();

            string examplePath = CodeExampleDemoUtils.GetExamplePath(ExamplesFolderName);
            Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
            Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);

            DisableTabs(examplesCS.Count, examplesVB.Count);
            DisableButtons(examplesCS.Count, examplesVB.Count);
            examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);

            ShowExamplesInTreeList(treeList1, examples);
            this.codeEditor = new ExampleCodeEditor(richEditControlCS, richEditControlVB);
            CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage(DemoProjectName);
            ShowFirstExample();
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
        }

        public string ExamplesFolderName { get { return "CodeExamples\\XLExport"; } }
        public string DemoProjectName { get { return "DocsMainDemo"; } }
        public string DemoName { get { return "XL Export demo"; } }
        protected ExampleCodeEditor CodeEditor { get { return codeEditor; } }

        #region InitializeComponent
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XLExportAPIModule));
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnExportToCSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToXLS = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToXLSX = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlCS = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlVB = new DevExpress.XtraRichEdit.RichEditControl();
            this.codeExampleNameLbl = new DevExpress.XtraEditors.LabelControl();
            this.verticalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chbOpenResultingFile = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).BeginInit();
            this.verticalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chbOpenResultingFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlButtons.Controls.Add(this.chbOpenResultingFile);
            this.pnlButtons.Controls.Add(this.btnExportToCSV);
            this.pnlButtons.Controls.Add(this.btnExportToXLS);
            this.pnlButtons.Controls.Add(this.btnExportToXLSX);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 627);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1000, 67);
            this.pnlButtons.TabIndex = 9;
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToCSV.Image")));
            this.btnExportToCSV.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportToCSV.Location = new System.Drawing.Point(192, 6);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(90, 59);
            this.btnExportToCSV.TabIndex = 2;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnExportToXLS
            // 
            this.btnExportToXLS.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToXLS.Image")));
            this.btnExportToXLS.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportToXLS.Location = new System.Drawing.Point(96, 6);
            this.btnExportToXLS.Name = "btnExportToXLS";
            this.btnExportToXLS.Size = new System.Drawing.Size(90, 59);
            this.btnExportToXLS.TabIndex = 1;
            this.btnExportToXLS.Text = "Export to XLS";
            this.btnExportToXLS.Click += new System.EventHandler(this.btnExportToXLS_Click);
            // 
            // btnExportToXLSX
            // 
            this.btnExportToXLSX.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToXLSX.Image")));
            this.btnExportToXLSX.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExportToXLSX.Location = new System.Drawing.Point(0, 6);
            this.btnExportToXLSX.Name = "btnExportToXLSX";
            this.btnExportToXLSX.Size = new System.Drawing.Size(90, 59);
            this.btnExportToXLSX.TabIndex = 0;
            this.btnExportToXLSX.Text = "Export to XLSX";
            this.btnExportToXLSX.Click += new System.EventHandler(this.btnExportToXLSX_Click);
            // 
            // treeList1
            // 
            this.treeList1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.treeList1.Appearance.FocusedCell.Options.UseFont = true;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(223, 694);
            this.treeList1.TabIndex = 8;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 44);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1000, 583);
            this.xtraTabControl1.TabIndex = 12;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.richEditControlCS);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(994, 555);
            this.xtraTabPage1.Text = "C#";
            // 
            // richEditControlCS
            // 
            this.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlCS.EnableToolTips = true;
            this.richEditControlCS.Location = new System.Drawing.Point(0, 0);
            this.richEditControlCS.Name = "richEditControlCS";
            this.richEditControlCS.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlCS.Size = new System.Drawing.Size(994, 555);
            this.richEditControlCS.TabIndex = 14;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.richEditControlVB);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(994, 555);
            this.xtraTabPage2.Text = "VB";
            // 
            // richEditControlVB
            // 
            this.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlVB.EnableToolTips = true;
            this.richEditControlVB.Location = new System.Drawing.Point(0, 0);
            this.richEditControlVB.Name = "richEditControlVB";
            this.richEditControlVB.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlVB.Size = new System.Drawing.Size(994, 555);
            this.richEditControlVB.TabIndex = 15;
            // 
            // codeExampleNameLbl
            // 
            this.codeExampleNameLbl.Appearance.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeExampleNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeExampleNameLbl.Location = new System.Drawing.Point(0, 0);
            this.codeExampleNameLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.codeExampleNameLbl.Name = "codeExampleNameLbl";
            this.codeExampleNameLbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.codeExampleNameLbl.Size = new System.Drawing.Size(238, 44);
            this.codeExampleNameLbl.TabIndex = 10;
            this.codeExampleNameLbl.Text = "Examples not found";
            // 
            // verticalSplitContainerControl1
            // 
            this.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.verticalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1";
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.codeExampleNameLbl);
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.pnlButtons);
            this.verticalSplitContainerControl1.Panel1.Text = "Panel1";
            this.verticalSplitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.verticalSplitContainerControl1.Panel2.MinSize = 223;
            this.verticalSplitContainerControl1.Panel2.Text = "Panel2";
            this.verticalSplitContainerControl1.Size = new System.Drawing.Size(1228, 694);
            this.verticalSplitContainerControl1.SplitterPosition = 223;
            this.verticalSplitContainerControl1.TabIndex = 0;
            this.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1";
            // 
            // chbOpenResultingFile
            // 
            this.chbOpenResultingFile.EditValue = true;
            this.chbOpenResultingFile.Location = new System.Drawing.Point(292, 6);
            this.chbOpenResultingFile.Name = "chbOpenResultingFile";
            this.chbOpenResultingFile.Properties.Caption = "Open resulting file";
            this.chbOpenResultingFile.Size = new System.Drawing.Size(235, 19);
            this.chbOpenResultingFile.TabIndex = 3;
            // 
            // XLExportAPIModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalSplitContainerControl1);
            this.Name = "XLExportAPIModule";
            this.Size = new System.Drawing.Size(1228, 694);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).EndInit();
            this.verticalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chbOpenResultingFile.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        ExampleLanguage CurrentExampleLanguage {
            get { return (ExampleLanguage)xtraTabControl1.SelectedTabPageIndex; }
            set {
                this.codeEditor.CurrentExampleLanguage = value;
                xtraTabControl1.SelectedTabPageIndex = (value == ExampleLanguage.Csharp) ? 0 : 1;
            }
        }

        void RunExample(string fileName, XlDocumentFormat documentFormat) {
            CodeEditor.BeforeCompile();
            XLExportExampleCodeEvaluator evaluator = CreateEvaluator();
            evaluator.Control = this;
            string imagePath = DemoUtils.GetRelativeDirectoryPath("Images");
            CodeEvaluationResult result = evaluator.ExecuteCodeAndGenerateDocument(codeEditor.CurrentCodeEditor.Text, new object[] { fileName, documentFormat, imagePath });
            CodeEditor.AfterCompile(result != CodeEvaluationResult.CompileErrors);
            if (result == CodeEvaluationResult.Success)
                ShowFile(fileName);
        }

        XLExportExampleCodeEvaluator CreateEvaluator() {
            if (CurrentExampleLanguage == ExampleLanguage.VB)
                return new XLExportVBExampleCodeEvaluator();
            return new XLExportCSExampleCodeEvaluator();
        }

        void DisableTabs(int examplesCSCount, int examplesVBCount) {
            if (examplesCSCount == 0)
                xtraTabControl1.TabPages[(int)ExampleLanguage.Csharp].PageEnabled = false;
            if (examplesVBCount == 0)
                xtraTabControl1.TabPages[(int)ExampleLanguage.VB].PageEnabled = false;
        }

        void DisableButtons(int examplesCSCount, int examplesVBCount) {
            if (examplesCSCount == 0 && examplesVBCount == 0) {
                btnExportToCSV.Enabled = false;
                btnExportToXLS.Enabled = false;
                btnExportToXLSX.Enabled = false;
            }
        }

        void ShowFirstExample() {
            treeList1.ExpandAll();
            if (treeList1.Nodes.Count > 0)
                treeList1.FocusedNode = treeList1.MoveFirst().FirstNode;
        }

        void OnNewExampleSelected(object sender, FocusedNodeChangedEventArgs e) {
            CodeExample newExample = (sender as TreeList).GetDataRecordByNode(e.Node) as CodeExample;
            CodeExample oldExample = (sender as TreeList).GetDataRecordByNode(e.OldNode) as CodeExample;

            if (newExample == null)
                return;

            string exampleCode = codeEditor.ShowExample(oldExample, newExample);
            codeExampleNameLbl.Text = CodeExampleDemoUtils.ConvertStringToMoreHumanReadableForm(newExample.RegionName) + " example";
            EnableButtons(newExample.RegionName);
        }

        void EnableButtons(string exampleName) {
            btnExportToXLS.Enabled = !XLExportForbiddenXLSExamples.Examples.Contains(exampleName);
            btnExportToCSV.Enabled = !XLExportForbiddenCSVExamples.Examples.Contains(exampleName);
        }

        void ShowExamplesInTreeList(TreeList treeList, List<CodeExampleGroup> examples) {
            treeList.OptionsPrint.UsePrintStyles = true;
            treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnNewExampleSelected);
            treeList.OptionsView.ShowColumns = false;
            treeList.OptionsView.ShowIndicator = false;

            treeList.VirtualTreeGetChildNodes += treeList_VirtualTreeGetChildNodes;
            treeList.VirtualTreeGetCellValue += treeList_VirtualTreeGetCellValue;

            TreeListColumn col1 = new TreeListColumn();
            col1.VisibleIndex = 0;
            col1.OptionsColumn.AllowEdit = false;
            col1.OptionsColumn.AllowMove = false;
            col1.OptionsColumn.ReadOnly = true;
            treeList.Columns.AddRange(new TreeListColumn[] { col1 });

            treeList.DataSource = new Object();
            treeList.ExpandAll();
        }

        void treeList_VirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo args) {
            CodeExampleGroup group = args.Node as CodeExampleGroup;
            if (group != null)
                args.CellData = group.Name;

            CodeExample example = args.Node as CodeExample;
            if (example != null)
                args.CellData = example.RegionName;
        }

        void treeList_VirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo args) {
            if (treeListRootNodeLoading) {
                args.Children = examples;
                treeListRootNodeLoading = false;
            }
            else {
                if (args.Node == null)
                    return;
                CodeExampleGroup group = args.Node as CodeExampleGroup;
                if (group != null)
                    args.Children = group.Examples;
            }
        }

        void xtraTabControl1_SelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            ExampleLanguage value = (ExampleLanguage)(xtraTabControl1.SelectedTabPageIndex);
            if (codeEditor != null)
                this.codeEditor.CurrentExampleLanguage = value;
        }

        void ShowFirstExample(TreeList treelist) {
            treelist.ExpandAll();
            if (treelist.Nodes.Count > 0)
                treelist.FocusedNode = treelist.MoveFirst().FirstNode;
        }

        string GetSaveFileName(string filter, string defaulName) {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = filter;
            sfDialog.FileName = defaulName;
            if (sfDialog.ShowDialog() != DialogResult.OK)
                return null;
            return sfDialog.FileName;
        }
        void ShowFile(string fileName) {
            if (!File.Exists(fileName))
                return;
            if (chbOpenResultingFile.Checked)
                Process.Start(fileName);
        }

        void btnExportToXLSX_Click(object sender, EventArgs e) {
            string fileName = GetSaveFileName("Excel Workbook files(*.xlsx)|*.xlsx", "Document.xlsx");
            if (string.IsNullOrEmpty(fileName))
                return;
            RunExample(fileName, XlDocumentFormat.Xlsx);
        }

        void btnExportToXLS_Click(object sender, EventArgs e) {
            string fileName = GetSaveFileName("Excel 97-2003 Workbook files(*.xls)|*.xls", "Document.xls");
            if (string.IsNullOrEmpty(fileName))
                return;
            RunExample(fileName, XlDocumentFormat.Xls);
        }

        void btnExportToCSV_Click(object sender, EventArgs e) {
            string fileName = GetSaveFileName("CSV (Comma delimited files)(*.csv)|*.csv", "Document.csv");
            if (string.IsNullOrEmpty(fileName))
                return;
            RunExample(fileName, XlDocumentFormat.Csv);
        }
    }
    #endregion
    #region XLExportExampleCodeEvaluator
    public abstract class XLExportExampleCodeEvaluator : XLExportExampleCodeEvaluatorBase {
        public XtraUserControl Control { get; set; }

        protected override void ShowErrorMessage(string message) {
            if (Control == null)
                XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                XtraMessageBox.Show(Control.LookAndFeel, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
    #endregion
    #region XLExportCSExampleCodeEvaluator
    public class XLExportCSExampleCodeEvaluator : XLExportExampleCodeEvaluator {

        const string codeStart =
      "using System;\r\n" +
      "using System.Collections.Generic;\r\n" +
      "using System.IO;\r\n" +
      "using System.Text;\r\n" +
      "using System.Diagnostics;\r\n" +
      "using System.Xml;\r\n" +
      "using System.Data;\r\n" +
      "using System.Drawing;\r\n" +
      "using System.Windows.Forms;\r\n" +
      "using System.Globalization;\r\n" +
      "using DevExpress.Export.Xl;\r\n" +
      "using DevExpress.XtraExport.Csv;\r\n" +
      "using DevExpress.Spreadsheet;\r\n" +
      "using DevExpress.Utils;\r\n" +
      "namespace XLExportExampleCode { \r\n" +
      "public class ExampleItem { \r\n" +
      "        public static void Process(string filePath, XlDocumentFormat documentFormat, string imagesPath) { \r\n" +
      "            using (FileStream stream = new FileStream(filePath, FileMode.Create)) { \r\n" +
      "\r\n";

        const string codeEnd =
        "       \r\n }\r\n" +
        "       \r\n }\r\n" +
        "    }\r\n" +
        "}\r\n";

        protected override string CodeStart { get { return codeStart; } }
        protected override string CodeEnd { get { return codeEnd; } }

        protected override CodeDomProvider GetCodeDomProvider() {
            return new CSharpCodeProvider();
        }
    }
    #endregion
    #region XLExportVBExampleCodeEvaluator
    public class XLExportVBExampleCodeEvaluator : XLExportExampleCodeEvaluator {

        const string codeStart =
     "Imports Microsoft.VisualBasic\r\n" +
     "Imports System\r\n" +
     "Imports DevExpress.Spreadsheet\r\n" +
     "Imports DevExpress.Export.Xl\r\n" +
     "Imports DevExpress.XtraExport.Csv\r\n" +
     "Imports System.Drawing\r\n" +
     "Imports System.Windows.Forms\r\n" +
     "Imports DevExpress.Utils\r\n" +
     "Imports System.IO\r\n" +
     "Imports System.Text\r\n" +
     "Imports System.Diagnostics\r\n" +
     "Imports System.Xml\r\n" +
     "Imports System.Data\r\n" +
     "Imports System.Collections.Generic\r\n" +
     "Imports System.Globalization\r\n" +
     "Namespace XLExportExampleCode\r\n" +
     "	Public Class ExampleItem\r\n" +
     "		Public Shared Sub Process(ByVal filePath As String, ByVal documentFormat As XlDocumentFormat, ByVal imagesPath As String)\r\n" +
     "          Using stream As New FileStream(filePath, FileMode.Create)\r\n" +
     "\r\n";

        const string codeEnd =
        "\r\n		End Using\r\n" +
        "\r\n		End Sub\r\n" +
        "	End Class\r\n" +
        "End Namespace\r\n";

        protected override string CodeStart { get { return codeStart; } }
        protected override string CodeEnd { get { return codeEnd; } }
        protected override CodeDomProvider GetCodeDomProvider() {
            return new Microsoft.VisualBasic.VBCodeProvider();
        }
    }
    #endregion
}
