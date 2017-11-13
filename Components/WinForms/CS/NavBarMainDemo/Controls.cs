using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraNavBar.Demos {
    public class TutorialControl : TutorialControlBase {
        protected PanelControl contentPanel;
        public TutorialControl() {
            this.contentPanel = CreateContentPanel();
            OnAddContentPanel();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateContentLocation();
            SizeChanged += (sender, ee) => UpdateContentLocation();
        }
        protected virtual void OnAddContentPanel() {
            Controls.Add(ContentPanel);
            ContentPanel.Padding = new System.Windows.Forms.Padding(4);
            ContentPanel.Dock = DockStyle.Fill;
            if(!AllowContentBorders) {
                ContentPanel.BorderStyle = BorderStyles.NoBorder;
            }
        }
        void UpdateContentLocation() {
            if(DesignMode) return;
            Rectangle outerBounds = CalcOuterBounds();
            if(outerBounds.IsEmpty)
                return;
            int xoffset = (ContentPanel.Width / 2 - outerBounds.Left - outerBounds.Width / 2);
            int yoffset = (ContentPanel.Height / 2 - outerBounds.Top - outerBounds.Height / 2);

            foreach(Control control in GetContentControls()) {
                Point pt = control.Location;
                pt.Offset(xoffset, yoffset);
                control.Location = pt;
            }
        }
        Rectangle CalcOuterBounds() {
            var controls = GetContentControls();
            if(controls.Count() == 0)
                return Rectangle.Empty;
            int left = int.MaxValue, right = 0, top = int.MaxValue, bottom = 0;
            foreach(Control control in controls) {
                if(control.Left < left)
                    left = control.Left;
                if(control.Right > right)
                    right = control.Right;
                if(control.Top < top)
                    top = control.Top;
                if(control.Bottom > bottom)
                    bottom = control.Bottom;
            }
            return Rectangle.FromLTRB(left, top, right, bottom);
        }
        IEnumerable<Control> GetContentControls() {
            List<Control> list = new List<Control>();
            foreach(Control control in ContentPanel.Controls) {
                if(control is BarDockControl) continue;
                list.Add(control);
            }
            return list;
        }
        
        protected virtual bool AllowContentBorders { get { return true; } }
        protected virtual PanelControl CreateContentPanel() {
            return new PanelControl();
        }
        protected PanelControl ContentPanel { get { return contentPanel; } }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        public override bool AllowPrintOptions { get { return false; } }
    }
}
