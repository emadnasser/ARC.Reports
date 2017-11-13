using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.Utils.Frames;

namespace DevExpress.XtraDiagram.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowDiagramModule(string name, GroupControl group, ApplicationCaption caption, RibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                Control oldTutorial = null;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name) return;
                    oldTutorial = Instance.CurrentModuleBase.TModule;
                }
                Instance.CurrentModuleBase = item;
                TutorialControlBase tutorialBase = item.TModule as TutorialControlBase;
                tutorialBase.Bounds = group.DisplayRectangle;
                tutorialBase.Visible = false;
                group.Controls.Add(tutorialBase);
                tutorialBase.Dock = DockStyle.Fill;
                tutorialBase.RibbonMenuManager = manager;
                tutorialBase.TutorialName = name;
                tutorialBase.Caption = caption;
                tutorialBase.Visible = true;
                DiagramTutorialControl diagramTutorial = item.TModule as DiagramTutorialControl;
                if(diagramTutorial != null) {

                }
                item.WasShown = true;
                if(oldTutorial != null) oldTutorial.Visible = false;
            }
            catch { }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
}
