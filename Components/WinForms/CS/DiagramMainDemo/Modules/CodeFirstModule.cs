using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.DXperience.Demos.CodeDemo;
using System.Reflection;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraDiagram.Demos {
    public class CodeFirstModule : CodeTutorialControlBase {
        static CodeFirstModule() {
            using(new DiagramControl()) { }
        }
        protected override ExampleLanguage CurrentExampleLanguage { get { return DemoHelper.GetLanguageString(typeof(CodeFirstModule).Assembly) == "CS" ? ExampleLanguage.Csharp : ExampleLanguage.VB; } }
    }
}
