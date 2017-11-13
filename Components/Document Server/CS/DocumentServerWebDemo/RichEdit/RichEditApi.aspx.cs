using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.ASPxTreeList;
using DevExpress.Docs.Demos;
using DevExpress.Web.Demos;
using System.IO;
using System.Net;
using System.Web.UI.HtmlControls;
using DevExpress.XtraRichEdit;
using System.Text;
using DevExpress.DXperience.Demos;

public partial class RichEdit_RichEditApi : System.Web.UI.Page {
    ExampleEvaluatorByTimer evaluator;
    RichEditDocumentServer docServer;
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
        ShowExamplesInTreeList(this.ASPxTreeList1, examples);
        InitializeCodePreview();
    }
    void RenderHTMLPreview() {
        this.evaluator = new RichEditExampleEvaluatorNoTimer();
        this.evaluator.QueryEvaluate += OnQueryEvaluate;
        this.docServer = new RichEditDocumentServer();
        Response.StatusCode = (int)HttpStatusCode.OK;
        Response.ContentType = "text/html";
        Session["UploadedFile"] = docServer;

        docServer.BeginUpdate();
        docServer.CreateNewDocument();
        evaluator.CompileExample(null, new EventArgs());
        docServer.EndUpdate();
        if (docServer == null)
            Response.BinaryWrite(Encoding.ASCII.GetBytes("Cannot display a preview."));
        else {
            Stream result = null;
            result = new MemoryStream();
            docServer.SaveDocument(result, DocumentFormat.Html);
            if (result != null) {
                result.Seek(0, SeekOrigin.Begin);
                result.CopyTo(Response.OutputStream);
            }
        }
        Response.End();
    }
    void LoadExamples() {
        string examplePath = MapPath("~/App_Data/RichEditApiExampleCode");
        Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
        Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);
        this.examples = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);
        SetIdForExamples(examples);
        CurrentExampleLanguage = CodeExampleDemoUtils.DetectExampleLanguage("DocumentServerDemos.Local.2010");
    }
    void OnQueryEvaluate(object sender, CodeEvaluationEventArgs e) {
        CodeExample example = new CodeExample();
        string sourceIndxString = Request.Params["preview"];
        int sourceIndx = Convert.ToInt32(sourceIndxString);
        example = GetExampleById(examples, sourceIndx);
        e.Result = true;
        e.Code = example.CodeCS;
        e.Language = ExampleLanguage.Csharp;
        e.EvaluationParameter = docServer.Document;
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
        using (MemoryStream stream = new MemoryStream()) {
            RichEditDocumentServer docServer = (RichEditDocumentServer)Session["UploadedFile"];
            int value = (int)cbDownloadType.Value;

            if (docServer != null) {
                if (value == 4) {
                    docServer.ExportToPdf(stream);
                } else {
                    DocumentFormat format = ConvertIndexToFormat(value);
                    docServer.SaveDocument(stream, format);
                }
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(Response.OutputStream);
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            Response.ContentType = ConvertIndexToContentType(value);
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Search.{0}", ConvertIndexToFileExtension(value)));
            Response.End();
        }
    }
    DocumentFormat ConvertIndexToFormat(int value) {
        switch (value) {
            case 1:
                return DocumentFormat.Rtf;
            case 2:
                return DocumentFormat.Doc;
            case 3:
                return DocumentFormat.OpenXml;
            case 5:
                return DocumentFormat.PlainText;
            case 6:
                return DocumentFormat.Mht;
            case 7:
                return DocumentFormat.OpenDocument;
            case 8:
                return DocumentFormat.WordML;
            case 9:
                return DocumentFormat.ePub;

        }
        return DocumentFormat.Undefined;
    }
    string ConvertIndexToContentType(int value) {
        switch (value) {
            case 1:
                return "application/msword";
            case 2:
                return "application/msword";
            case 3:
                return "application/msword";
            case 4:
                return "application/msword";
            case 5:
                return "text/plain";
            case 6:
                return "message/rfc822";
            case 7:
                return "application/msword";
            case 8:
                return "text/xml";
            case 9:
                return "application/msword";
        }
        return String.Empty;
    }
    string ConvertIndexToFileExtension(int value) {
        switch (value) {
            case 1:
                return "rtf";
            case 2:
                return "doc";
            case 3:
                return "docx";
            case 4:
                return "pdf";
            case 5:
                return "txt";
            case 6:
                return "mht";
            case 7:
                return "odt";
            case 8:
                return "xml";
            case 9:
                return "epub";
        }
        return String.Empty;
    }
    #region RichEditExampleEvaluatorNoTimer
    public class RichEditExampleEvaluatorNoTimer : ExampleEvaluatorByTimer {
        public RichEditExampleEvaluatorNoTimer()
            : base(false) {
        }
        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language) {
            if (language == ExampleLanguage.VB)
                return new RichEditVbExampleCodeEvaluator();
            return new RichEditCsExampleCodeEvaluator();
        }
    }
    #endregion
}
