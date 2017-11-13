using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Tutorials;
using DevExpress.XtraEditors;

namespace XtraPrintingDemos {
	public class PrintingAppearanceMenu : DevExpress.DXperience.Demos.LookAndFeelMenu {
		public PrintingAppearanceMenu(BarManager manager, DefaultLookAndFeel lookAndFeel, string about, bool showHelpMenu) : base(manager, lookAndFeel, about) {
			miHelp.Visibility = showHelpMenu ? BarItemVisibility.Always : BarItemVisibility.Never;
		}
		protected override string ProductName { get { return "XtraPrinting"; } }
		protected override void biProductWebPage_Click(object sender, ItemClickEventArgs e) {
			System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraPrinting/");
		}
		protected override void miAboutProduct_Click(object sender, ItemClickEventArgs e) {
			DevExpress.XtraPrinting.PrintingSystem.About();
		}
	}
	public class TutorialsInfo : ModulesInfo {
		const string languageDir = "CS\\";
		
		public static void CloseCustomizationForm(Control control) {
			if(control == null) return;
            foreach(object obj in control.Controls) {
                RibbonControl ribbonControl = obj as RibbonControl;
                if(ribbonControl == null)
                    continue;
                ribbonControl.Visible = false;
                ribbonControl.Visible = true;
            }
		}

		public static DevExpress.Tutorials.ModuleBase ShowModuleEx(string name, DevExpress.XtraEditors.GroupControl groupControl, LookAndFeelMenu menu, DefaultLookAndFeel lookAndFeel) {
			DevExpress.DXperience.Demos.ModuleInfo item = TutorialsInfo.GetItem(name);
			Cursor currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			groupControl.Parent.SuspendLayout();
			groupControl.SuspendLayout();
			try {
				Control oldTutorial = null;
				if(Instance.CurrentModuleBase != null) 
					oldTutorial = Instance.CurrentModuleBase.TModule;
                Instance.CurrentModuleBase = item;
                XtraUserControl tutorialBase = item.TModule as XtraUserControl;
                if(tutorialBase != null) {
                    tutorialBase.Bounds = groupControl.DisplayRectangle;
                    tutorialBase.Visible = false;
                    groupControl.Controls.Add(tutorialBase);
                    tutorialBase.Dock = DockStyle.Fill;

                    TutorialModuleControl tutorial = item.TModule as TutorialModuleControl;
                    if(tutorial != null)
                        tutorial.Activate();

                    CloseCustomizationForm(oldTutorial);
                    menu.InitLookAndFeelMenu(lookAndFeel);

                    tutorialBase.Visible = true;
                }
				if(oldTutorial != null) oldTutorial.Visible = false;
			}
			finally {
				groupControl.ResumeLayout(true);
				groupControl.Parent.ResumeLayout(true);
				Cursor.Current = currentCursor;
			}
			RaiseModuleChanged();
            ModuleBase module = Instance.CurrentModuleBase.TModule as ModuleBase;
			if(module != null) {
                module.TutorialInfo.Description = Instance.CurrentModuleBase.Description;
                module.TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name;
                module.TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile;
                module.TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile;
                string xmlFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisXMLFile, false);
                string codeFile = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, module.TutorialInfo.WhatsThisCodeFile, false);
                if(xmlFile == "") module.TutorialInfo.WhatsThisXMLFile = DemoHelper.StringComposite(module.TutorialInfo.WhatsThisXMLFile, languageDir);
                if(codeFile == "") module.TutorialInfo.WhatsThisCodeFile = DemoHelper.StringComposite(module.TutorialInfo.WhatsThisCodeFile, languageDir);
			}
			return module;
		}
	}
}

