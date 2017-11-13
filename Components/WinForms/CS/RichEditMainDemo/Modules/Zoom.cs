using System;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class ZoomModule : DevExpress.XtraRichEdit.Demos.TutorialControl {
        public ZoomModule() {
            InitializeComponent();
            RtfLoadHelper.Load("Zoom.rtf", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
        }

        public override RichEditControl PrintingRichEditControl { get { return richEditControl; } }

        protected override void DoShow() {
            base.DoShow();
            richEditControl.Focus();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            float zoomFactor = richEditControl.ActiveView.ZoomFactor;
            UpdateZoomTrackbarCore(zoomFactor);
            UpdateZoomCaption(zoomFactor);
            SubscribeZoomChangedEvent();
            SubscribeZoomTrackbarEvents();
        }
        void SubscribeZoomTrackbarEvents() {
            zoomTrackBar.Edit.EditValueChanging += new ChangingEventHandler(OnZoomTrackBarEditValueChanging);
        }
        void UnsubscribeZoomTrackbarEvents() {
            zoomTrackBar.Edit.EditValueChanging -= new ChangingEventHandler(OnZoomTrackBarEditValueChanging);
        }
        void SubscribeZoomChangedEvent() {
            richEditControl.ZoomChanged += new EventHandler(OnZoomChanged);
        }
        void UnsubcribeZoomChangedEvent() {
            richEditControl.ZoomChanged -= new EventHandler(OnZoomChanged);
        }
        void OnZoomTrackBarEditValueChanging(object sender, ChangingEventArgs e) {
            OnZoomTrackBarEditValueChangedCore((int)e.NewValue);
        }
        void OnZoomTrackBarEditValueChangedCore(int value) {
            UnsubcribeZoomChangedEvent();
            richEditControl.ActiveView.ZoomFactor = (int)value / 100.0f;
            SubscribeZoomChangedEvent();
        }
        void OnZoomChanged(object sender, EventArgs e) {
            float zoomFactor = richEditControl.ActiveView.ZoomFactor;
            UnsubscribeZoomTrackbarEvents();
            UpdateZoomTrackbarCore(zoomFactor);
            SubscribeZoomTrackbarEvents();
        }
        void UpdateZoomTrackbarCore(float zoomFactor) {
            zoomTrackBar.EditValue = (int)Math.Round(zoomFactor * 100);
        }
        void UpdateZoomCaption(float zoomFactor) {
            zoomTrackBar.Caption = String.Format("{0}%", (int)Math.Round(zoomFactor * 100));
        }
        private void richEditControl_ZoomChanged(object sender, EventArgs e) {
            UpdateZoomCaption(richEditControl.ActiveView.ZoomFactor);
        }
    }
}
