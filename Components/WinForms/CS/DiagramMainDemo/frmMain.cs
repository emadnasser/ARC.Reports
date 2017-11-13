using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Frames;
using DevExpress.Tutorials;
using System.Linq;

namespace DevExpress.XtraDiagram.Demos {
    public class frmMain : RibbonMainForm {
        public frmMain() {
        }
        protected override void SetFormParam() {
            var assembly = typeof(frmMain).Assembly;
            this.Icon = ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(x => x.Contains("DemoIcon.ico")), assembly);
        }
        protected override void ShowAbout() {
            DiagramControl.About();
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel, ApplicationCaption caption) {
            DemosInfo.ShowDiagramModule(name, group, caption, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, true, NavBarImage.Large);
        }
        protected override SourceFileType FileType { get { return SourceFileType.CS; } }

        protected override int CustomWidth { get { return 1350; } }
        protected override int CustomHeight { get { return 950; } }

        protected override string DemoName { get { return "The XtraDiagramControl by DevExpress (" + GetLanguageString() + " code)"; } }
        protected override string ProductName { get { return "XtraDiagramControl"; } }

        static string GetLanguageString() {
            string result = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if(result == "CS")
                result = "C#";
            return result;
        }
    }
}
