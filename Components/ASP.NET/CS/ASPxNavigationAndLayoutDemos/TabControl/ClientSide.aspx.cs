using System;
using System.Web.UI;
using DevExpress.Web.Demos;
using DevExpress.CodeParser;

public partial class TabControl_ClientSide : Page {
    const string CSharpCode =
        "protected override void OnLoad(EventArgs e) {\n" +
        "    base.OnLoad(e);\n" +
        "    StyleOptimizer.Instance.RegisterChildControls(Page);\n" +
        "}\n";

    const string VBCode =
        "Protected Overrides Sub OnLoad(ByVal e As EventArgs)\n" +
        "    MyBase.OnLoad(e)\n" +
        "    StyleOptimizer.Instance.RegisterChildControls(Page)\n" +
        "End Sub\n";


    protected void Page_Init(object sender, EventArgs e) {
        CSharpCodeHolder.InnerHtml = 
            CodeFormatter.GetFormattedCode(TokenLanguage.CSharp, CSharpCode);
        VBCodeHolder.InnerHtml = CodeFormatter.GetFormattedCode(TokenLanguage.Basic, VBCode);
    }
}

