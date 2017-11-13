using System;
using System.Collections.Generic;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Web.Demos;
using System.IO;
using System.Net;
using System.Web.UI.HtmlControls;
using DevExpress.DXperience.Demos;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using DevExpress.Export.Xl;

public partial class Spreadsheet_XLExportAPI : System.Web.UI.Page {
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
        ShowExamplesInTreeList(ASPxTreeList1, this.examples);
        InitializeCodePreview();
    }
    void LoadExamples() {
        string examplePath = MapPath("~/App_Data/ApiExampleCode/XLExport");
        Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
        Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);
        this.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);
        SetIdForExamples(examples);
        CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010");
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
        lblSourceName.Text = GetExampleName(example);

        string formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(CurrentExampleLanguage), example.CodeCS, false);
        HtmlGenericControl csharpCodeHolder = this.ASPxPageControl1.TabPages[0].FindControl("CSharpCodeHolder") as HtmlGenericControl;
        csharpCodeHolder.InnerHtml = formattedCode;

        if (String.IsNullOrEmpty(example.CodeVB))
            return;
        HtmlGenericControl vbCodeHolder = this.ASPxPageControl1.TabPages[1].FindControl("VbCodeHolder") as HtmlGenericControl;

        formattedCode = CodeFormatter.GetFormattedCode(CodeExampleDemoUtils.GetCodeExampleFileExtension(AlternateExampleLanguage), example.CodeVB, false);
        vbCodeHolder.InnerHtml = formattedCode;
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

        string isCSVFormatEnabled = IsCSVFormatEnabled(example.RegionName) ? "true" : "false";
        string isXLSFormatEnabled = IsXLSFormatEnabled(example.RegionName) ? "true" : "false";
        e.Result = String.Format("{0}|{1}|{2}|CSharpCodeHolder${3}${4}|VBCodeHolder${5}${6}", isCSVFormatEnabled, isXLSFormatEnabled, GetExampleName(example), formattedCode.Length, formattedCode, formattedVbCode.Length, formattedVbCode);
    }
    bool IsCSVFormatEnabled(string moduleName) {
        return !XLExportForbiddenCSVExamples.Examples.Contains(moduleName);
    }
    bool IsXLSFormatEnabled(string moduleName) {
        return !XLExportForbiddenXLSExamples.Examples.Contains(moduleName);
    }
    string GetExampleName(CodeExample example) {
        return String.Format("{0} example", example.RegionName);
    }
    protected void btnExportToXLSX_Click(object sender, EventArgs e) {
        ExportFile(XlDocumentFormat.Xlsx);
    }
    protected void btnExportToXLS_Click(object sender, EventArgs e) {
        ExportFile(XlDocumentFormat.Xls);
    }
    protected void btnExportToCSV_Click(object sender, EventArgs e) {
        ExportFile(XlDocumentFormat.Csv);
    }
    void ExportFile(XlDocumentFormat fileFormat) {
        int activeExampleId = 0;
        TreeListNode focusedNode = this.ASPxTreeList1.FocusedNode;
        if (focusedNode != null)
            activeExampleId = Convert.ToInt32(focusedNode.Key);

        CodeExample example = GetExampleById(examples, activeExampleId);
        if (example == null)
            return;

        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";

        using (MemoryStream stream = new MemoryStream()) {
            RunExample(example.CodeCS, stream, fileFormat);

            stream.Seek(0, SeekOrigin.Begin);
            stream.CopyTo(Response.OutputStream);

            Response.StatusCode = (int)HttpStatusCode.OK;
            Response.ContentType = ConvertFileFormatToContentType(fileFormat);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=XLExportApiExample.{0}", ConvertFileFormatToFileExtension(fileFormat)));
            Response.End();
        }
    }
    void RunExample(string exampleCode, Stream stream, XlDocumentFormat documentFormat) {
        XLExportExampleCodeEvaluatorBase evaluator = new XLExportCSExampleCodeEvaluator();
        string imagePath = MapPath("~/App_Data/Images");
        CodeEvaluationResult result = evaluator.ExecuteCodeAndGenerateDocument(exampleCode, new object[] { stream, documentFormat, imagePath });
    }

    string ConvertFileFormatToContentType(XlDocumentFormat fileFormat) {
        switch (fileFormat) {
            case XlDocumentFormat.Xlsx:
                return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            case XlDocumentFormat.Xls:
                return "application/vnd.ms-excel";
            case XlDocumentFormat.Csv:
                return "text/comma-separated-values";
        }
        return String.Empty;
    }
    string ConvertFileFormatToFileExtension(XlDocumentFormat fileFormat) {
        switch (fileFormat) {
            case XlDocumentFormat.Xlsx:
                return "xlsx";
            case XlDocumentFormat.Xls:
                return "xls";
            case XlDocumentFormat.Csv:
                return "csv";
        }
        return String.Empty;
    }

    #region XLExportCSExampleCodeEvaluator
    public class XLExportCSExampleCodeEvaluator : XLExportExampleCodeEvaluatorBase {

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
      "        public static void Process(Stream stream, XlDocumentFormat documentFormat, string imagesPath) { \r\n" +
      "\r\n";

        const string codeEnd =
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
    public class XLExportVBExampleCodeEvaluator : XLExportExampleCodeEvaluatorBase {

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
     "		Public Shared Sub Process(ByVal stream As Stream, ByVal documentFormat As XlDocumentFormat, ByVal imagesPath As String)\r\n" +
     "\r\n";

        const string codeEnd =
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
