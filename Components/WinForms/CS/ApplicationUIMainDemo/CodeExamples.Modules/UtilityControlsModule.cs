using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.DXperience.Demos.CodeDemo;

namespace DevExpress.ApplicationUI.Demos {
    public class UtilityControlsModule : CodeTutorialControlBase {
        public UtilityControlsModule()
            : base() {
        }
        protected override bool UseSameTutorialControlNameForGenerateExample {
            get { return true; }
        }
        //protected override string[] FileNamesForModule {
        //    get { return new string[] { "CommonConcepts.cs", "TabbedView.cs", "WindowsUIView.cs", "WidgetView.cs" }; }
        //}
    }
}
