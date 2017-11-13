using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraEditors.Demos {
    public class TutorialControl : TutorialControlBase {
        List<Panel> centerControls = new List<Panel>();
        protected virtual bool AllowCenterControls { get { return true; } }
        public TutorialControl() {
            this.Padding = new Padding(5, 0, 0, 5);
            this.SizeChanged += (s, e) => UpdatePosition();
            SubscribeOnEvents();
        }
        void UpdatePosition() {
            foreach(Panel pnl in centerControls) {
                if(pnl.Parent == null) 
                    continue;
                pnl.Location = new Point((pnl.Parent.Width - pnl.Width) / 2, (pnl.Parent.Height - pnl.Height) / 2);
            }
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            GridControl grid = ctrl as GridControl;
            if(grid != null) grid.MenuManager = manager;
            PropertyGridControl pGrid = ctrl as PropertyGridControl;
            if(pGrid != null) pGrid.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        public override bool AllowPrintOptions { get { return false; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(AllowCenterControls) {
                foreach(Control ctrl in this.Controls) {
                    XtraTabControl tabControl = ctrl as XtraTabControl;
                    if(tabControl != null) UpdateTabControlPosition(tabControl);
                }
                UpdatePosition();
            }
            CalcContentCore();
        }
        protected virtual void CalcContentCore() { }
        protected virtual void OnLookAndFeelChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        protected virtual void SubscribeOnEvents() {
            if(LookAndFeel != null)
                LookAndFeel.StyleChanged += OnLookAndFeelChanged;
        }
        protected virtual void UnsubscribeOnEvents() {
            if(LookAndFeel != null)
                LookAndFeel.StyleChanged -= OnLookAndFeelChanged;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            CalcContentCore();
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(Visible) CalcContentCore();
        }
        protected void CalcLayoutControlBounds(DevExpress.XtraLayout.LayoutControl layout) {
            if(layout == null || layout.Parent == null || !layout.Parent.IsHandleCreated)
                return;
            Size bestSize = layout.GetPreferredSize(Size.Empty);
            int bestWidth = Math.Max(0, Math.Min(layout.Parent.Width, bestSize.Width));
            int bestHeight = Math.Max(0, Math.Min(layout.Parent.Height, bestSize.Height));
            layout.SetBounds((layout.Parent.Width - bestWidth) / 2, (layout.Parent.Height - bestHeight) / 2, bestWidth, bestHeight);
        }

        protected virtual void UpdateTabControlPosition(XtraTabControl tabControl) {
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
                if(ctrl is PopupContainerControl || ctrl is PopupControlContainer || ctrl is FlyoutPanel) continue;
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
        protected override void Dispose(bool disposing) {
            UnsubscribeOnEvents();
            base.Dispose(disposing);
        }
    }
}
