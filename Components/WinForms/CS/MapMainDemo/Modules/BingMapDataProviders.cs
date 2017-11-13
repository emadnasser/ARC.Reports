using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {

    public partial class BingMapDataProviders : MapTutorialControl {
        protected override MapOverlay[] Overlays { get { return OverlayUtils.GetBingOverlays(); } }
        public override MapControl MapControl { get { return mapControl1; } }

        public BingMapDataProviders() {
            AutoMergeRibbon = true;
            InitializeComponent();
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider);
            chkBingHybrid.Checked = true;
        }
        void SetBingProviderMapKind(BingMapKind kind) {
            if(BingMapDataProvider != null) {
                mapControl1.BackColor = Object.Equals(kind, BingMapKind.Road) ? Color.FromArgb(187, 208, 237) : Color.FromArgb(1, 7, 21);
                BingMapDataProvider.Kind = kind;
                MiniMapDataProvider.Kind = kind;
            }
        }
        void chkBingArea_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            SetBingProviderMapKind(GetCurrentMapKind());
        }
        BingMapKind GetCurrentMapKind() {
            if(chkBingArea.Checked) return BingMapKind.Area;
            if(chkBingRoad.Checked) return BingMapKind.Road;
            if(chkBingHybrid.Checked) return BingMapKind.Hybrid;
            return BingMapKind.Hybrid;
        }
        
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.Add(rpgDataProviders);
            OptionsPage.Ribbon.Items.AddRange(new BarItem[] { chkBingArea, chkBingHybrid, chkBingRoad });
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint();
            MapControl.ZoomLevel = 2;
        }
    }
}
