using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using System.Globalization;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraNavBar.Demos {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments);
            CultureInfo demoCI = (CultureInfo)Application.CurrentCulture.Clone();
            demoCI.NumberFormat.CurrencySymbol = "$";
            demoCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = demoCI;

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(arguments));
        }
    }

    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, RibbonMenuManager manager) {
            ModuleInfo item = ModulesInfo.GetItem(name);
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
    }
}
