using System;
using System.Drawing;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class TrackBarFilterParams : SimpleFilterParams {
        public TrackBarFilterParams() {
            InitializeComponent();
            LayoutControlItem trackBarItem = new LayoutControlItem(this.SimpleFilterParamsConvertedLayout, this.trackBar);
            trackBarItem.Text = FilterText;
            trackBarItem.SizeConstraintsType = SizeConstraintsType.Custom;
            trackBarItem.MinSize = new Size(25, 50);
            trackBarItem.MaxSize = new Size(0, 50);
            trackBarItem.Move(this.applyButtonItem, DevExpress.XtraLayout.Utils.InsertType.Top);
        }
        public override object[] GetParams() {
            return new object[] { GetValue() };
        }
        protected virtual void OnBeforeShowTrackBarValueToolTip(object sender, TrackBarValueToolTipEventArgs e) {
            e.ShowArgs.ToolTip = GetValue().ToString();
        }
        protected virtual float GetValue() { return trackBar.Value * 0.001f; }

        void trackBar_EditValueChanged(object sender, EventArgs e) {
            UpdatePreview();
        }
        protected virtual string FilterText { get { return ""; } }
    }

    public partial class BrightnessFilterParams : TrackBarFilterParams {
        protected override string FilterText {
            get { return "Brightness"; }
        }
        protected override float GetValue() {
            return trackBar.Value * 0.002f - 1.0f;
        }
    }

    public partial class ContrastFilterParams : TrackBarFilterParams {
        protected override string FilterText {
            get { return "Contrast"; }
        }
        protected override float GetValue() {
            return trackBar.Value * 0.002f;
        }
    }

    public partial class SaturationFilterParams : TrackBarFilterParams {
        protected override string FilterText {
            get { return "Saturation"; }
        }
        protected override float GetValue() {
            return trackBar.Value * 0.001f;
        }
    }
}
