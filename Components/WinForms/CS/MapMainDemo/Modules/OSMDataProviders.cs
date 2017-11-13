using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {

    public partial class OSMDataProviders : MapTutorialControl {
        protected override MapOverlay[] Overlays { get { return new MapOverlay[] { OverlayUtils.OSMCopyrightOverlay }; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public OSMDataProviders() {
            InitializeComponent();
            InitializeListboxes();
            AutoMergeRibbon = true;
        }
        void InitializeListboxes() {
            listBoxControl1.Items.AddRange(DemoUtils.GetOSMBaseLayers());
            listBoxControl1.SelectedIndex = 0;
            listBoxControl2.Items.AddRange(DemoUtils.GetOSMOverlays());
            listBoxControl2.SelectedIndex = 0;
        }
        void listBoxControl1_SelectedValueChanged(object sender, EventArgs e) {
            BaseProvider.Kind = (OpenStreetMapKind)listBoxControl1.SelectedItem;
            MiniMapDataProvider.Kind = (OpenStreetMapKind)listBoxControl1.SelectedItem;
        }
        void listBoxControl2_SelectedValueChanged(object sender, EventArgs e) {
            if(listBoxControl2.SelectedIndex == 0)
                OverlayLayer.Visible = false;
            else {
                OverlayLayer.Visible = true;
                OverlayProvider.Kind = (OpenStreetMapKind)listBoxControl2.SelectedItem;
            }
            MoveMap(listBoxControl2.SelectedIndex);
        }
        void trackBarControl1_EditValueChanged(object sender, EventArgs e) {
            TilesLayer.Transparency = (byte)trackBarControl1.Value;
        }
        void trackBarControl2_EditValueChanged(object sender, EventArgs e) {
            OverlayLayer.Transparency = (byte)trackBarControl2.Value;
        }
        void MoveMap(int index) {
            switch(index) {
                case 0: { mapControl1.CenterPoint = new GeoPoint(50.067, 14.417); ; mapControl1.ZoomLevel = 5; break; }
                case 1: { mapControl1.CenterPoint = new GeoPoint(54.15, 11.75); mapControl1.ZoomLevel = 14; break; }
                case 2: { mapControl1.CenterPoint = new GeoPoint(41.5, 2.0); mapControl1.ZoomLevel = 11; break; }
                case 3: { mapControl1.CenterPoint = new GeoPoint(51.5, -3.2); mapControl1.ZoomLevel = 13; break; }
                case 4: { mapControl1.CenterPoint = new GeoPoint(48.85, 2.3); mapControl1.ZoomLevel = 11; break; }
            }
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(50.067, 14.417);
            MapControl.ZoomLevel = 5;
        }
    }
}
