using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraRichEdit.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.Utils.Frames.ApplicationCaption caption, RichEditRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if (Instance.CurrentModuleBase != null) {
                    if (Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;

                TutorialControl tc = item.TModule as TutorialControl;
                if (tc != null) {
                    manager.AllowExport(tc.PrintingRichEditControl);
                }
                else {
                    manager.AllowExport(null);
                }

                //-----Set----
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;
                //------------

                tutorial.Visible = true;
                item.WasShown = true;
                //manager.RichEditControl = tutorial.PrintingRichEditControl;
                if (oldTutorial != null) {
                    oldTutorial.Visible = false;
                }
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
}
