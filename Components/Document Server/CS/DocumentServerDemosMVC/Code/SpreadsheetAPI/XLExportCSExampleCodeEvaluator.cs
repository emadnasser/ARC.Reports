using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace DevExpress.DXperience.Demos {
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
}
