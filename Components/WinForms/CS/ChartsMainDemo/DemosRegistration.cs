using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.Utils.Frames;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;
using DevExpress.XtraCharts.Designer;

namespace DevExpress.XtraCharts.Demos {
	public class DemosInfo : ModulesInfo {
        static void UpdateModuleInfo(ModuleInfo item) {
            item.RecreateModuleIfNecessary(Assembly.GetCallingAssembly());
        }
        public static TutorialControl DoShowModule(string name, GroupControl group, ApplicationCaption caption, ChartRibbonMenuManager manager) {
            ModuleInfo item = DemosInfo.GetItem(name);
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (Instance.CurrentModuleBase != null) {
                    if (Instance.CurrentModuleBase.Name == name) 
                        return null;
                    Control oldTutorial = ChartModulesPool.GetPreviousModule();
                    if (oldTutorial == null)
                        oldTutorial = Instance.CurrentModuleBase.TModule;
                    if (oldTutorial != null)
                        oldTutorial.Visible = false;
                }
                TutorialControlBase tutorial = (TutorialControlBase)item.TModule;
                tutorial.Bounds = group.DisplayRectangle;
                tutorial.Visible = false;
                tutorial.Capture = true;
                Application.DoEvents();
                tutorial.Capture = false;
                Instance.CurrentModuleBase = item;
                group.Controls.Add(tutorial);
                tutorial.Dock = DockStyle.Fill;
                TutorialControl tc = tutorial as TutorialControl;
                if (tc != null) {
                    ChartModulesPool.RegisterModule(tc);
                    UpdateModuleInfo(item);
                    manager.AllowExport(tc.ExportedObject);
                    manager.ShowReservGroup1(true);
                    manager.ShowReservGroup2(true);
                }
                else {
                    manager.AllowExport(null);
                    manager.ShowReservGroup1(false);
                    manager.ShowReservGroup2(false);
                }
                tutorial.RibbonMenuManager = manager;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;
                tutorial.Visible = true;
                item.WasShown = true;
            }
            finally {
                Cursor.Current = currentCursor;
            }
            RaiseModuleChanged();
            return item.TModule as TutorialControl;
        }
        public static string SetAppearanceName(string appearanceName) {
			if (Instance.CurrentModuleBase != null) {
				ChartDemoBase chartModule = Instance.CurrentModuleBase.TModule as ChartDemoBase;
				if (chartModule != null) {
					chartModule.AppearanceName = appearanceName;
                    return chartModule.PaletteName;
                }
			}
            return String.Empty;
		}
		public static string SetPaletteName(string paletteName) {
			if (Instance.CurrentModuleBase != null) {
				ChartDemoBase chartModule = Instance.CurrentModuleBase.TModule as ChartDemoBase;
				if (chartModule != null) {
					chartModule.PaletteName = paletteName;
                    return chartModule.AppearanceName;
                }
			}
            return String.Empty;
		}
        public static void RunChartWizard() {
            if (Instance.CurrentModuleBase != null) {
                ChartDemoBase chartModule = Instance.CurrentModuleBase.TModule as ChartDemoBase;
                if (chartModule != null) {
                    ChartDesigner chartDesigner = new ChartDesigner(chartModule.ChartControl);
                    chartDesigner.ShowDialog();                    
                    chartModule.UpdateControls();
                }
            }
        }
	}

    public static class ChartModulesPool {
        const int MaxModulesCount = 5;

        static readonly List<TutorialControl> modules = new List<TutorialControl>(MaxModulesCount);

        static void UnregisterModule(TutorialControl module) {
            ModuleInfo moduleInfo = ModulesInfo.GetItem(module.TutorialName);
            moduleInfo.ResetModule();
            module.Dispose();
            modules.Remove(module);
        }
        public static void RegisterModule(TutorialControl module) {
            if (modules.Contains(module)) 
                modules.Remove(module);
            else if (modules.Count == MaxModulesCount)
                UnregisterModule(modules[0]);
            modules.Add(module);
        }
        public static Control GetPreviousModule() {
            return modules.Count > 0 ? modules[modules.Count - 1] : null;
        }
    }
}
