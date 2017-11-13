using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using System.Reflection;
using DevExpress.XtraMap.Native;

namespace DevExpress.XtraMap.Demos {
    public class DemosInfo : ModulesInfo {
        static void UpdateModuleInfo(ModuleInfo item) {
            item.RecreateModuleIfNecessary(Assembly.GetCallingAssembly());
        }
        public static void DoShowModule(string name, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.Utils.Frames.ApplicationCaption caption, MapRibbonMenuManager manager) {
            Cursor currentCursor = Cursor.Current;
            try {
                ModuleInfo item = DemosInfo.GetItem(name);
                TutorialControlBase tutorial = (TutorialControlBase)item.TModule;
                Cursor.Current = Cursors.WaitCursor;
                if(Instance.CurrentModuleBase != null) {
                    if(Instance.CurrentModuleBase.Name == name)
                        return;
                    TutorialControlBase oldTutorial = MapModulesPool.GetPreviousModule();
                    if(oldTutorial == null)
                        oldTutorial = (TutorialControlBase)Instance.CurrentModuleBase.TModule;
                    if(oldTutorial != null) {
                        oldTutorial.Visible = false;
                        MapTutorialControl mapTutorialControl = oldTutorial as MapTutorialControl;
                        if(mapTutorialControl != null)
                            MapUtils.ReleaseMapHandle(mapTutorialControl.MapControl);
                    }
                }
                tutorial.Bounds = groupControl.DisplayRectangle;
                Instance.CurrentModuleBase = item;
                tutorial.Visible = false;
                groupControl.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                MapTutorialControl tc = tutorial as MapTutorialControl;
                if(tc != null) {
                    MapModulesPool.RegisterModule(tc);
                    UpdateModuleInfo(item);
                    tc.AppendOverlays();
                }
                manager.AllowExport(tc != null ? tc.MapControl : null);

                //-----Set----
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;
                //------------

                tutorial.Visible = true;
                item.WasShown = true;
                //manager.RichEditControl = tutorial.PrintingRichEditControl;
            } finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
        }
    }
}
