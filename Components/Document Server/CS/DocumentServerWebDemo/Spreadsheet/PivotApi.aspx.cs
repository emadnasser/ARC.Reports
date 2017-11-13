using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Docs.Demos;
using DevExpress.Web.Demos;
using System.IO;
using System.Net;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using DevExpress.Spreadsheet.Drawings;
using System.Text;
using System.Web.UI.HtmlControls;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraSpreadsheet.Services;
using DevExpress.XtraSpreadsheet.Services.Implementation;
using DevExpress.Office.Services;
using DevExpress.Web.Office;

public partial class Pivot_Api : System.Web.UI.Page {
    ExampleEvaluatorByTimer evaluator;
    Workbook workbook;
    List<CodeExampleGroup> examples;
    ExampleLanguage currentExampleLanguage;

    ExampleLanguage CurrentExampleLanguage {
        get { return ExampleLanguage.Csharp; }
        set { currentExampleLanguage = value; }
    }
    ExampleLanguage AlternateExampleLanguage {
        get {
            return (CurrentExampleLanguage == ExampleLanguage.Csharp)
            ? ExampleLanguage.VB
            : ExampleLanguage.Csharp;
        }
    }

    protected void Page_Load(object sender, EventArgs e) {
        LoadExamples();
        if (Request.QueryString.Count > 0) {
            RenderHTMLPreview();
            return;
        }
        ShowExamplesInTreeList(ASPxTreeList1, this.examples);
        InitializeCodePreview();
    }
    void RenderHTMLPreview() {
        this.workbook = new Workbook();
        workbook.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
        workbook.AddService(typeof(IChartControllerFactoryService), new ChartControllerFactoryService());
        workbook.AddService(typeof(IChartImageService), new ChartImageService());
        this.evaluator = new SpreadsheetExampleEvaluatorNoTimer();
        this.evaluator.QueryEvaluate += new CodeEvaluationEventHandler(OnEvaluatorQueryEvaluate);
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";

        workbook.BeginUpdate();
        workbook.Options.Culture = CultureInfo.InvariantCulture;
        bool loaded = workbook.LoadDocument(MapPath("~/App_Data/PivotTableTemplate.xlsx"));
        evaluator.CompileExample(null, new EventArgs());
        workbook.EndUpdate();

        Worksheet firstSheet = workbook.Worksheets[0];
        Range usedRange = firstSheet.GetUsedRange();
        firstSheet.SelectedCell = usedRange[usedRange.RowCount * usedRange.ColumnCount - 1].Offset(1, 1);
        if (workbook == null)
            Response.BinaryWrite(Encoding.ASCII.GetBytes("Cannot display a preview."));
        else {
            workbook.Worksheets.ActiveWorksheet.Visible = true;
            HtmlContentGenerator htmlGenerator = new HtmlContentGenerator(Response.OutputStream);
            htmlGenerator.Generate(workbook, workbook.Worksheets.ActiveWorksheet.Index);
        }
        Response.End();
        return;
    }
    void LoadExamples() {
        string examplePath = MapPath("~/App_Data/ApiExampleCode/Pivots");
        Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
        Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);
        this.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);
        RearrangeExamples(examples);
        SetIdForExamples(examples);
        CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010");
    }
    void RearrangeExamples(List<CodeExampleGroup> examples) {
        for (int i = 0; i < examples.Count; i++) {
            CodeExampleGroup group = examples[i];
            if (group.Name == "Pivot Table Actions") {
                examples.RemoveAt(i);
                examples.Insert(0, group);
                break;
            }
        }
    }
    void OnEvaluatorQueryEvaluate(object sender, CodeEvaluationEventArgs e) {
        CodeExample example = new CodeExample();
        string sourceIndxString = Request.Params["preview"];
        int sourceIndx = Convert.ToInt32(sourceIndxString);
        example = GetExampleById(examples, sourceIndx);
        e.Result = true;
        e.Code = example.CodeCS;
        e.Language = ExampleLanguage.Csharp;
        e.EvaluationParameter = workbook;
    }
    void SetIdForExamples(List<CodeExampleGroup> examples) {
        int indx = 0;
        foreach (CodeExampleGroup group in examples) {
            group.Id = indx++;
            foreach (CodeExample example in group.Examples)
                example.Id = indx++;
        }
    }
    CodeExample GetExampleById(List<CodeExampleGroup> exmpls, int id) {
        foreach (CodeExampleGroup group in exmpls) {
            if (group.Id == id && group.Examples.Count > 0)
                return group.Examples[0];
            foreach (var example in group.Examples)
                if (example.Id == id)
                    return example;
        }
        return null;
    }
    void ShowExamplesInTreeList(ASPxTreeList aSPxTreeList, List<CodeExampleGroup> examples) {
        foreach (CodeExampleGroup group in examples) {
            TreeListNode node = CreateNodeCore(group.Id, group.Name, null, null);
            foreach (CodeExample example in group.Examples) {
                CreateNodeCore(example.Id, example.RegionName, node, example);
            }
        }
        if (!IsPostBack)
            ASPxTreeList1.ExpandAll();
    }
    TreeListNode CreateNodeCore(object key, string text, TreeListNode parentNode, CodeExample example) {
        TreeListNode node = ASPxTreeList1.AppendNode(key, parentNode);
        node["Name"] = text;
        node["Value"] = example;
        return node;
    }
    void InitializeCodePreview() {
        int activeExampleId = 0;
        TreeListNode focusedNode = this.ASPxTreeList1.FocusedNode;
        if (IsPostBack && focusedNode != null)
            activeExampleId = Convert.ToInt32(focusedNode.Key);

        CodeExample example = GetExampleById(examples, activeExampleId);
        string formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, false);

        HtmlGenericControl csharpCodeHolder = this.ASPxPageControl1.TabPages[0].FindControl("CSharpCodeHolder") as HtmlGenericControl;
        csharpCodeHolder.InnerHtml = formattedCode;
        lblSourceName.Text = GetExampleName(example);

        if (String.IsNullOrEmpty(example.CodeVB))
            return;
        HtmlGenericControl vbCodeHolder = this.ASPxPageControl1.TabPages[0].FindControl("VbCodeHolder") as HtmlGenericControl;

        formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, false);
        vbCodeHolder.InnerHtml = formattedCode;
        lblSourceName.Text = GetExampleName(example);
    }
    protected void treeList_CustomDataCallback(object sender, TreeListCustomDataCallbackEventArgs e) {
        string key = e.Argument;
        if (this.examples == null)
            return;
        CodeExample example = GetExampleById(examples, Convert.ToInt32(key));
        if (example == null)
            return;
        string formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, false);
        string formattedVbCode = (String.IsNullOrEmpty(example.CodeVB)) ? String.Empty : CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, false);
        e.Result = String.Format("{0}|CSharpCodeHolder${1}${2}|VBCodeHolder${3}${4}", GetExampleName(example), formattedCode.Length, formattedCode, formattedVbCode.Length, formattedVbCode);
    }
    string GetExampleName(CodeExample example) {
        return String.Format("{0} example", example.RegionName);
    }
    protected void btnDownload_Click(object sender, EventArgs e) {
        int activeExampleId = 0;
        TreeListNode focusedNode = this.ASPxTreeList1.FocusedNode;
        if (focusedNode != null)
            activeExampleId = Convert.ToInt32(focusedNode.Key);

        CodeExample example = GetExampleById(examples, activeExampleId);
        if (example == null)
            return;

        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";

        workbook = new Workbook();
        workbook.ReplaceService<IUriStreamService>(new ASPxOfficeUriStreamService());
        workbook.BeginUpdate();
        workbook.Options.Culture = CultureInfo.InvariantCulture;
        workbook.LoadDocument(MapPath("~/App_Data/PivotTableTemplate.xlsx"));
        evaluator = new SpreadsheetExampleEvaluatorNoTimer();
        CodeEvaluationEventArgs codeEvalArgs = new CodeEvaluationEventArgs();
        codeEvalArgs.Result = true;
        codeEvalArgs.Code = example.CodeCS;
        codeEvalArgs.Language = ExampleLanguage.Csharp;
        codeEvalArgs.EvaluationParameter = workbook;
        evaluator.ForceCompile(codeEvalArgs);
        workbook.EndUpdate();
        workbook.Worksheets.ActiveWorksheet.Visible = true;

        using (MemoryStream stream = new MemoryStream()) {
            int value = (int)cbDownloadType.Value;

            if (value == 4) {
                workbook.ExportToPdf(stream);
            } else {
                DocumentFormat format = ConvertIndexToFormat(value);
                workbook.SaveDocument(stream, format);
            }
            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(Response.OutputStream);
            Response.StatusCode = (int)HttpStatusCode.OK;
            Response.ContentType = ConvertIndexToContentType(value);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=SpreadsheetApiExample.{0}", ConvertIndexToFileExtension(value)));
            Response.End();
        }
    }
    DocumentFormat ConvertIndexToFormat(int value) {
        switch (value) {
            case 1:
                return DocumentFormat.OpenXml;
            case 2:
                return DocumentFormat.Xls;
            case 3:
                return DocumentFormat.Csv;
        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch (value) {
            case 1:
                return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            case 2:
                return "application/vnd.ms-excel";
            case 3:
                return "text/comma-separated-values";
            case 4:
                return "application/pdf";
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch (value) {
            case 1:
                return "xlsx";
            case 2:
                return "xls";
            case 3:
                return "csv";
            case 4:
                return "pdf";
        }
        return String.Empty;
    }

    #region SpreadsheetExampleEvaluator
    public class SpreadsheetExampleEvaluatorNoTimer : ExampleEvaluatorByTimer {
        public SpreadsheetExampleEvaluatorNoTimer()
            : base(false) {
        }
        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language) {
            if (language == ExampleLanguage.VB)
                return new SpreadsheetVbExampleCodeEvaluator();
            return new SpreadsheetCSExampleCodeEvaluator();
        }
    }
    #endregion
}
