using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.MVVM.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;
                tutorial.Visible = true;
                item.WasShown = true;
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
        public static string GetLoremIpsumText(int seed) {
            return string.Format("{0} {1}", texts[seed % texts.Length], texts[(seed + 2) % texts.Length]);
        }
        static string[] texts = new string[]{ 
            "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.",
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.",
            "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."
        };
    }
    //
    public class TutorialControl : TutorialControlBase {
        public TutorialControl() {
            this.Padding = new Padding(5, 0, 0, 5);
        }
        protected void LoadSourceCode(DevExpress.DXperience.Demos.CodeDemo.RichEditUserControl sourceCode, string methodName, System.Type moduleType = null, bool append = false) {
            sourceCode.richEditControl.InitializeDocument += (s, e) =>
            {
                sourceCode.InitializeSyntaxHighlight(DXperience.Demos.CodeDemo.ExampleLanguage.Csharp);
            };
            string code = DevExpress.DXperience.Demos.CodeDemo.CodeTutorialControlBase.GetModuleMethodCode(moduleType ?? GetType(), methodName);
            sourceCode.RichText = append ? sourceCode.RichText + System.Environment.NewLine + code : code;
            sourceCode.richEditControl.ReadOnly = true;
        }
    }
}
