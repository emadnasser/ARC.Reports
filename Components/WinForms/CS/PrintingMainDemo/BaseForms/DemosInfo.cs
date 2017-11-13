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

namespace XtraPrintingDemos {
	public class DemosInfo : ModulesInfo {
		public static void ActivateModule(string name, DevExpress.Utils.Frames.ApplicationCaption caption, Action<Control> callBack) {
            if(Instance.CurrentModuleBase != null && Instance.CurrentModuleBase.Name == name)
                return;

            ModuleInfo item = DemosInfo.GetItem(name);
			Cursor currentCursor = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
            try {
                if(Instance.CurrentModuleBase != null)
                    Instance.CurrentModuleBase.TModule.Visible = false;

                TutorialControlBase tutorial = item.TModule as TutorialControlBase;
                tutorial.TutorialName = name;
                tutorial.Caption = caption;           
                Instance.CurrentModuleBase = item;
                callBack(tutorial);

                if(!item.WasShown && !(tutorial is MainFeaturesControl))
                    item.WasShown = true;
            }
			finally {
				Cursor.Current = currentCursor;
			}
			RaiseModuleChanged();
		}
	}
}

