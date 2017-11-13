using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Utils;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace PivotGridOlapBrowser.Helpers {
    public class MethodDelayer : IDisposable {
        public delegate void MethodDelegate();

        Timer timer;
        readonly MethodDelegate method;
        readonly int delay;

        public MethodDelayer(MethodDelegate method, int delay) {
            this.method = method;
            this.delay = delay;
        }

        protected Timer Timer {
            get {
                if(timer == null) {
                    timer = new Timer();
                    timer.Interval = this.delay;
                    timer.Enabled = false;
                    timer.Tick += new EventHandler(timer_Tick);
                }
                return timer;
            }
        }

        void timer_Tick(object sender, EventArgs e) {
            Timer.Stop();
            this.method();
        }

        public void Invoke() {
            if(this.delay == 0) {
                this.method();
                return;
            }
            if(Timer.Enabled)
                Timer.Stop();
            Timer.Start();
        }

        #region IDisposable Members
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~MethodDelayer() {
            Dispose(false);
        }
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                if(this.timer != null) {
                    this.timer.Dispose();
                    this.timer = null;
                }
            }
        }
        #endregion
    }

    public abstract class ObjectToolTipController : IDisposable {
        readonly ToolTipController controller;
        readonly Control parent;
        object editObject;
        Point location;

        MethodDelayer delayer;

        public ObjectToolTipController(Control parent) {
            this.parent = parent;
            this.parent.Disposed += OnParentDisposed;
            this.controller = new ToolTipController();
            this.controller.InitialDelay = 0;
            this.controller.ToolTipType = ToolTipType.SuperTip;
            this.controller.AllowHtmlText = true;
            this.controller.ReshowDelay = controller.InitialDelay;
            this.controller.AutoPopDelay = 10000;
            this.delayer = new MethodDelayer(ShowHintCore, 500);
            parent.MouseDown += OnParentMouseDown;
            parent.MouseLeave += OnParentMouseLeave;
            PivotGridControl pivot = parent as PivotGridControl;
            if(pivot != null) {
                pivot.LeftTopCellChanged += OnPivotLeftTopCellChanged;
            }
        }
        void OnParentDisposed(object sender, System.EventArgs e) {
            Dispose();
        }
        void OnParentMouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            HideHint(false);
        }
        void OnParentMouseLeave(object sender, System.EventArgs e) {
            HideHint(true);
        }
        void OnPivotLeftTopCellChanged(object sender, PivotLeftTopCellChangedEventArgs e) {
            HideHint(true);
        }
        public object EditObject { get { return editObject; } }

        public void ShowHint(object editObject, Point location) {
            if(object.Equals(editObject, this.editObject)) return;
            this.editObject = editObject;
            this.location = location;
            this.delayer.Invoke();
        }
        void ShowHintCore() {
            ToolTipControlInfo info = new ToolTipControlInfo();
            ToolTipItem item = new ToolTipItem();
            InitToolTipItem(item);
            item.ImageToTextDistance = 10;
            info.Object = DateTime.Now.Ticks;
            info.SuperTip = new SuperToolTip();
            info.SuperTip.Items.Add(item);
            info.ToolTipPosition = this.parent.PointToScreen(this.location);
            controller.ShowHint(info);
        }
        protected abstract void InitToolTipItem(ToolTipItem item);
        public void HideHint(bool clearCurrentObject) {
            if(clearCurrentObject) this.editObject = null;
            this.controller.HideHint();
        }

        #region IDisposable Members
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                this.controller.Dispose();
                this.delayer.Dispose();
            }
        }
        ~ObjectToolTipController() {
            Dispose(false);
        }
        #endregion
    }

    public abstract class FieldValueTooltipController : ObjectToolTipController {
        public FieldValueTooltipController(PivotGridControl parent)
            : base(parent) {
            parent.FieldTooltipShowing += OnFieldTooltipShowing;
        }

        void OnFieldTooltipShowing(object sender, PivotFieldTooltipShowingEventArgs e) {
            if(e.HitInfo.HitTest == PivotGridHitTest.Value) {
                e.ShowTooltip = false;
            }
        }
    }

    public class MemberPropertiesToolTipController : FieldValueTooltipController {
        const int MaxPhotoWidth = 120, MaxPhotoHeight = 120;

        public MemberPropertiesToolTipController(PivotGridControl parent) 
            : base(parent) { }

        IOLAPMember CurrentMember { get { return EditObject as IOLAPMember; } }

        protected override void InitToolTipItem(ToolTipItem item) {
            if(CurrentMember == null) return;
            StringBuilder text = new StringBuilder();
            text.Append("<b>").Append(CurrentMember.Caption).Append(" (").Append(CurrentMember.Level.Caption).AppendLine(")</b>");
            foreach(OLAPMemberProperty prop in CurrentMember.Properties) {
                text.Append(prop.Name).Append(": ").Append(prop.Value).AppendLine();
            }
            item.Text = text.ToString();
        }
    }
}
