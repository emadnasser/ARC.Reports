using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace DevExpress.ApplicationUI.Demos {
    public class DemosInfo : ModulesInfo {
        public static void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.Utils.Frames.ApplicationCaption caption, RibbonMenuManager manager) {
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

                //TutorialControl tc = tutorial as TutorialControl;
                //if(tc != null)
                //    manager.AllowExport(tc.ExportControl);
                //else manager.AllowExport(null);
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
        public static string GetLoremIpsumText(int seed) {
            return string.Format("{0} {1}", texts[seed % texts.Length], texts[(seed + 2) % texts.Length]);
        }
        static string[] texts = new string[]{ 
            "Vestibulum sem nunc, cursus sit amet placerat id, scelerisque at tortor. Nullam sit amet felis eros, ac imperdiet quam. Aliquam eu ipsum dui.",
            "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Curabitur sit amet sapien metus, eget pharetra velit.",
            "Duis sagittis iaculis nisl, sit amet ultricies lectus porttitor nec. Suspendisse id venenatis sem. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
            "Aliquam erat volutpat. Ut sit amet purus. Nullam a lectus. Duis in elit. Ut nonummy est pellentesque eros. Sed ultrices convallis nulla. Phasellus urna lorem, mattis a, luctus congue, dictum in, nunc."
        };
    }
    //
    public class TutorialControl : TutorialControlBase {
        public TutorialControl() {
            this.Padding = new Padding(5, 0, 0, 5);
            this.SizeChanged += (s, e) => UpdatePosition();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            foreach(Control ctrl in this.Controls) {
                XtraTabControl tabControl = ctrl as XtraTabControl;
                if(tabControl != null) UpdateTabControlPosition(tabControl);
            }
            UpdatePosition();
        }
        List<Panel> centerControls = new List<Panel>();
        void UpdatePosition() {
            foreach(Panel pnl in centerControls)
                pnl.Location = new Point((pnl.Parent.Width - pnl.Width) / 2, (pnl.Parent.Height - pnl.Height) / 2);
        }
        void UpdateTabControlPosition(XtraTabControl tabControl) {
            tabControl.SelectedPageChanged += (s, e) => UpdatePosition();
            foreach(XtraTabPage page in tabControl.TabPages) {
                if(page != null) UpdatePagePosition(page);
            }
        }
        void UpdatePagePosition(XtraTabPage page) {
            Panel pnl = new Panel();
            int left = 100, right = 0, top = 100, bottom = 0;
            for(int i = page.Controls.Count - 1; i >= 0; i--) {
                Control ctrl = page.Controls[i];
                if(ctrl is DevExpress.XtraBars.BarDockControl) continue;
                if(ctrl is DevExpress.Utils.FlyoutPanel) continue;
                if(ctrl is PopupContainerControl || ctrl is PopupControlContainer) continue;
                if(left > ctrl.Left) left = ctrl.Left;
                if(right < ctrl.Right) right = ctrl.Right;
                if(top > ctrl.Top) top = ctrl.Top;
                if(bottom < ctrl.Bottom) bottom = ctrl.Bottom;
                ctrl.Parent = pnl;
            }
            pnl.Parent = page;
            pnl.Size = new Size(right + left, bottom + top);
            centerControls.Add(pnl);
        }
    }
}
