using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraNavBar;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
	public class DemosInfo : ModulesInfo {
		static BaseView GetBaseViewByControl(Control control) {
			if(control == null) return null;
			foreach(Control cntl in control.Controls) 
				if(cntl is GridControl)
					return ((GridControl)cntl).MainView;
            //due latest changes within demos - need to do it recursive
            return CheckControl(control, true);
		}

        static BaseView CheckControl(Control cntl, bool checkChildren) {
            if(cntl is GridControl)
                return ((GridControl)cntl).MainView;
            if(!checkChildren) return null;
            foreach(Control c in cntl.Controls) {
                var res = CheckControl(c, checkChildren);
                if(res != null) return res;
            }
            return null;
        }

		static void CloseCustomizationForm(Control control) {
			if(control == null) return;
			foreach(Control ctrl in control.Controls)
				CloseCustomizationForm(ctrl);
			BaseView view = GetBaseViewByControl(control);
			if(view == null) return;
			foreach(BaseView bView in view.GridControl.Views)
				if(bView is GridView)
					((GridView)bView).DestroyCustomization();
		}

 		public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, GridRibbonMenuManager manager) {
            if(Instance.CurrentModuleBase != null)
                if(Instance.CurrentModuleBase.TModule is TutorialControl && ((TutorialControl)Instance.CurrentModuleBase.TModule).IsActiveDemo) return;
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

                TutorialControl tc = item.TModule as TutorialControl;
                CloseCustomizationForm(oldTutorial);
                if(tc != null) {
                    manager.AllowExport(tc.ExportView);
                    manager.RefreshOptionsMenu(tc.ShowViewOptions ? GetBaseViewByControl(tutorial) : null);
                    //SetTestMode(tc);
                }
                else {
                    manager.AllowExport(null);
                    manager.RefreshOptionsMenu(null);
                }
                manager.InitBlendingMenu(null);
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
