using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.DXperience.Demos;
using System.Windows.Forms;

namespace SnapDemos {
    public class DemosInfo : ModulesInfo {
        public static void Show(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, RibbonMenuManager manager) {
            DevExpress.DXperience.Demos.ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if (Instance.CurrentModuleBase != null) {
                    if (Instance.CurrentModuleBase.Name == name)
                        return;
                    Instance.CurrentModuleBase.TModule.Visible = false;
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
                tutorial.BringToFront();
                tutorial.Focus();
                if (oldTutorial != null)
                    oldTutorial.Visible = false;
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
}
