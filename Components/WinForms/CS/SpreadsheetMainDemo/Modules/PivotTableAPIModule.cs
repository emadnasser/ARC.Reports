﻿using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.Spreadsheet;
using System.Diagnostics;

namespace DevExpress.XtraSpreadsheet.Demos {
    public class PivotTableAPIModule : SpreadSheetTutorialControlBase {
        //PrintableComponentLinkBase link;
        SplitContainerControl horizontalSplitContainerControl1;
        SplitContainerControl verticalSplitContainerControl1;
        //IContainer components = null;
        
        #region Controls
        private SpreadsheetControl spreadsheet;
        private TreeList treeList1;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraTab.XtraTabPage xtraTabPage1;
        private RichEditControl richEditControlCS;
        private XtraTab.XtraTabPage xtraTabPage2;
        private RichEditControl richEditControlVB; 
        #endregion
        
        LabelControl codeExampleNameLbl;
        ExampleCodeEditor codeEditor;
        ExampleEvaluatorByTimer evaluator;
        List<CodeExampleGroup> examples;
        bool treeListRootNodeLoading = true;
        Worksheet activeWorksheet;
        Range activeCell;

        public PivotTableAPIModule() {
            InitializeComponent();
            string examplePath = CodeExampleDemoUtils.GetExamplePath("CodeExamples\\Pivots");

            Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
            Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);
            DisableTabs(examplesCS.Count, examplesVB.Count);
            this.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);
            RearrangeExamples();
            ShowExamplesInTreeList(treeList1, examples);
            
            this.codeEditor = new ExampleCodeEditor(richEditControlCS, richEditControlVB);
            CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("SpreadsheetMainDemo");
            this.evaluator = new SpreadsheetExampleEvaluatorByTimer(); //this.components
            
            this.evaluator.QueryEvaluate += OnExampleEvaluatorQueryEvaluate;
            this.evaluator.OnBeforeCompile += evaluator_OnBeforeCompile;
            this.evaluator.OnAfterCompile += evaluator_OnAfterCompile;

            ShowFirstExample();
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
        }

        void RearrangeExamples() {
            for (int i = 0; i < examples.Count; i++) {
                CodeExampleGroup group = examples[i];
                if (group.Name == "Pivot Table Actions") {
                    examples.RemoveAt(i);
                    examples.Insert(0, group);
                    break;
                }
            }
        }

        void evaluator_OnAfterCompile(object sender, OnAfterCompileEventArgs args) {
            IWorkbook workbook = spreadsheet.Document;
            foreach (Worksheet sheet in workbook.Worksheets)
                sheet.PrintOptions.PrintGridlines = true;

            activeWorksheet = workbook.Worksheets.ActiveWorksheet;
            activeWorksheet.ScrollTo(0, 0);
            Range usedRange = activeWorksheet.GetUsedRange();
            activeCell = usedRange[usedRange.RowCount * usedRange.ColumnCount - 1].Offset(1, 1);
            activeWorksheet.SelectedCell = activeCell;
            activeWorksheet.Visible = true;

            codeEditor.AfterCompile(args.Result);
            spreadsheet.EndUpdate();
        }

        void evaluator_OnBeforeCompile(object sender, EventArgs e) {
            spreadsheet.BeginUpdate();
            codeEditor.BeforeCompile();

            IWorkbook workbook = spreadsheet.Document;
            workbook.Options.Culture = DefaultCulture;
            bool loaded = workbook.LoadDocument(DemoUtils.GetRelativePath("PivotTableTemplate.xlsx"));
            Debug.Assert(loaded);
        }
        ExampleLanguage CurrentExampleLanguage {
            get { return (ExampleLanguage)xtraTabControl1.SelectedTabPageIndex; }
            set {
                this.codeEditor.CurrentExampleLanguage = value;
                xtraTabControl1.SelectedTabPageIndex = (value == ExampleLanguage.Csharp) ? 0 : 1;
            }
        }
        void ShowExamplesInTreeList(TreeList treeList, List<CodeExampleGroup> examples) {
            #region InitializeTreeList
            treeList.OptionsPrint.UsePrintStyles = true;
            treeList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnNewExampleSelected);
            treeList.OptionsView.ShowColumns = false;
            treeList.OptionsView.ShowIndicator = false;

            
            treeList.VirtualTreeGetChildNodes += treeList_VirtualTreeGetChildNodes;
            treeList.VirtualTreeGetCellValue += treeList_VirtualTreeGetCellValue;
            #endregion
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
            CodeEvaluationEventArgs args = new CodeEvaluationEventArgs();
            InitializeCodeEvaluationEventArgs(args);
            evaluator.ForceCompile(args);
        }
        void InitializeCodeEvaluationEventArgs(CodeEvaluationEventArgs e) {
            e.Result = true;
            e.Code = codeEditor.CurrentCodeEditor.Text;
            e.Language = CurrentExampleLanguage;
            e.EvaluationParameter = spreadsheet.Document;
        }
        void OnExampleEvaluatorQueryEvaluate(object sender, CodeEvaluationEventArgs e) {
            e.Result = false;
            if (codeEditor.RichEditTextChanged) {// && compileComplete) {
                TimeSpan span = DateTime.Now - codeEditor.LastExampleCodeModifiedTime;

                if (span < TimeSpan.FromMilliseconds(1000)) {//CompileTimeIntervalInMilliseconds  1900
                    codeEditor.ResetLastExampleModifiedTime();
                    return;
                }
                //e.Result = true;
                InitializeCodeEvaluationEventArgs(e);
            }
        }
        #region InitializeComponent
        private void InitializeComponent() {
            this.horizontalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlCS = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlVB = new DevExpress.XtraRichEdit.RichEditControl();
            this.codeExampleNameLbl = new DevExpress.XtraEditors.LabelControl();
            this.spreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.verticalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSplitContainerControl1)).BeginInit();
            this.horizontalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).BeginInit();
            this.verticalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalSplitContainerControl1
            // 
            this.horizontalSplitContainerControl1.CaptionImageUri.Uri = "";
            this.horizontalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.horizontalSplitContainerControl1.Horizontal = false;
            this.horizontalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.horizontalSplitContainerControl1.Name = "horizontalSplitContainerControl1";
            this.horizontalSplitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.horizontalSplitContainerControl1.Panel1.Controls.Add(this.codeExampleNameLbl);
            this.horizontalSplitContainerControl1.Panel1.Text = "Panel1";
            this.horizontalSplitContainerControl1.Panel2.Controls.Add(this.spreadsheet);
            this.horizontalSplitContainerControl1.Panel2.Text = "Panel2";
            this.horizontalSplitContainerControl1.Size = new System.Drawing.Size(1005, 694);
            this.horizontalSplitContainerControl1.SplitterPosition = 340;
            this.horizontalSplitContainerControl1.TabIndex = 2;
            this.horizontalSplitContainerControl1.Text = "splitContainerControl1";
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
            this.xtraTabControl1.Size = new System.Drawing.Size(1005, 305);
            this.xtraTabControl1.TabIndex = 11;
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
            this.xtraTabPage1.Size = new System.Drawing.Size(999, 277);
            this.xtraTabPage1.Text = "C#";
            // 
            // richEditControlCS
            // 
            this.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlCS.EnableToolTips = true;
            this.richEditControlCS.Location = new System.Drawing.Point(0, 0);
            this.richEditControlCS.Name = "richEditControlCS";
            this.richEditControlCS.Options.Bookmarks.ConflictNameResolution = DevExpress.XtraRichEdit.ConflictNameAction.Keep;
            this.richEditControlCS.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlCS.Size = new System.Drawing.Size(999, 277);
            this.richEditControlCS.TabIndex = 14;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.richEditControlVB);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(999, 277);
            this.xtraTabPage2.Text = "VB";
            // 
            // richEditControlVB
            // 
            this.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlVB.EnableToolTips = true;
            this.richEditControlVB.Location = new System.Drawing.Point(0, 0);
            this.richEditControlVB.Name = "richEditControlVB";
            this.richEditControlVB.Options.Bookmarks.ConflictNameResolution = DevExpress.XtraRichEdit.ConflictNameAction.Keep;
            this.richEditControlVB.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never;
            this.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlVB.Size = new System.Drawing.Size(999, 277);
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
            this.codeExampleNameLbl.Size = new System.Drawing.Size(72, 44);
            this.codeExampleNameLbl.TabIndex = 10;
            this.codeExampleNameLbl.Text = "label1";
            // 
            // spreadsheet
            // 
            this.spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheet.Location = new System.Drawing.Point(0, 0);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.Options.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.spreadsheet.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheet.Size = new System.Drawing.Size(1005, 340);
            this.spreadsheet.TabIndex = 5;
            // 
            // verticalSplitContainerControl1
            // 
            this.verticalSplitContainerControl1.CaptionImageUri.Uri = "";
            this.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.verticalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1";
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.horizontalSplitContainerControl1);
            this.verticalSplitContainerControl1.Panel1.Text = "Panel1";
            this.verticalSplitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.verticalSplitContainerControl1.Panel2.Text = "Panel2";
            this.verticalSplitContainerControl1.Size = new System.Drawing.Size(1228, 694);
            this.verticalSplitContainerControl1.SplitterPosition = 218;
            this.verticalSplitContainerControl1.TabIndex = 0;
            this.verticalSplitContainerControl1.Text = "verticalSplitContainerControl1";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.treeList1.Appearance.FocusedCell.Options.UseFont = true;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(218, 694);
            this.treeList1.TabIndex = 11;
            // 
            // PivotTableAPIModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalSplitContainerControl1);
            this.Name = "PivotTableAPIModule";
            this.Size = new System.Drawing.Size(1228, 694);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSplitContainerControl1)).EndInit();
            this.horizontalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).EndInit();
            this.verticalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        } 
        #endregion

        void xtraTabControl1_SelectedPageChanged(object sender, XtraTab.TabPageChangedEventArgs e) {
            ExampleLanguage value = (ExampleLanguage)(xtraTabControl1.SelectedTabPageIndex);
            if (codeEditor!=null)
                this.codeEditor.CurrentExampleLanguage = value;
        }
        void SpreadsheetAPIModule_Disposed(object sender, EventArgs e) {
            evaluator.Dispose();
        }
        void DisableTabs(int examplesCSCount, int examplesVBCount) {
            if (examplesCSCount == 0)
                xtraTabControl1.TabPages[(int)ExampleLanguage.Csharp].PageEnabled = false;
            if (examplesVBCount == 0)
                xtraTabControl1.TabPages[(int)ExampleLanguage.VB].PageEnabled = false;
        }

        protected override void DoHide() {
            activeWorksheet.SelectedCell = activeCell;
            base.DoHide();
        }
    }
}