using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Frames;
using DevExpress.XtraEditors;

namespace DashboardMainDemo {
    public class DemosInfo : ModulesInfo {
        public static void Show(string name, GroupControl group, ApplicationCaption caption, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    Instance.CurrentModuleBase.TModule.Visible = false;
                }
                TutorialControlBase tutorial = (TutorialControlBase)item.TModule;
                tutorial.Bounds = group.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;
                tutorial.Visible = true;
                tutorial.BringToFront();
                tutorial.Focus();
                if(oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
}
