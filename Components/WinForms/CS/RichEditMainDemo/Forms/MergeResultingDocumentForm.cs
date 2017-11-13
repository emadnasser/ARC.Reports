using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class MergeResultingDocumentForm : RibbonForm {
        public MergeResultingDocumentForm() {
            InitializeComponent();
        }
        public Document Document { get { return richEditControl.Document; } }

        private void ribbonControl1_ApplicationButtonDoubleClick(object sender, EventArgs e) {
            this.Close();
        }

        private void MergeResultingDocumentForm_Load(object sender, EventArgs e) {
            float zoomFactor = richEditControl.ActiveView.ZoomFactor;
            UpdateZoomTrackbarCore(zoomFactor);
            UpdateZoomCaption(zoomFactor);
            SubscribeZoomChangedEvent();
            SubscribeZoomTrackbarEvents();
        }
        void SubscribeZoomTrackbarEvents() {
            repositoryItemZoomTrackBar1.EditValueChanging += new ChangingEventHandler(OnZoomTrackBarEditValueChanging);
        }
        void UnsubscribeZoomTrackbarEvents() {
            repositoryItemZoomTrackBar1.EditValueChanging -= new ChangingEventHandler(OnZoomTrackBarEditValueChanging);
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
