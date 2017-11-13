﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraMap.Demos {
    public partial class WebMapService : MapTutorialControl {
        static readonly Color SelectionColor = Color.FromArgb(128, 135, 135, 135);
        static readonly Color HotTrackedColor = Color.FromArgb(62, Color.Gray);
        static readonly Padding ItemMargin = new Padding(2);

        bool selectionLocked = false;
        readonly MapOverlay menu = new MapOverlay() { Alignment = ContentAlignment.TopRight, Margin = new Padding(10) };
        MapOverlay Menu { get { return menu; } }
        protected override MapOverlay[] Overlays { get { return new MapOverlay[] { OverlayUtils.OSMCopyrightOverlay, Menu }; } }

        public override MapControl MapControl { get { return mapControl1; } }

        public WebMapService() {
            InitializeComponent();
            AutoMergeRibbon = true;
        }

        LayerOverlayMenuItem CreateMenuItem(WmsLayer layer) {
            LayerOverlayMenuItem layerItem = new LayerOverlayMenuItem(layer.Name) {
                Padding = new Padding(10),
                Margin = ItemMargin,
                Text = layer.Name,
                JoiningOrientation = Orientation.Vertical
            };
            ((RepositoryItemComboBox)editWebMapSevice.Edit).Items.Add(layerItem);
            layerItem.HotTrackedStyle.Fill = HotTrackedColor;
            return layerItem;
        }
        MapOverlayTextItem CreateHeader() {
            MapOverlayTextItem header = new MapOverlayTextItem() {
                Padding = new Padding(10, 10, 10, 20),
                Text = "Available layers",
                JoiningOrientation = Orientation.Vertical
            };
            header.TextStyle.Font = new Font("Arial", 14);
            return header;
        }
        void OnOverlaysArranged(object sender, OverlaysArrangedEventArgs e) {
            OverlayArrangement[] overlays = e.OverlayArrangements;
            OverlayArrangement menu = overlays[1];
            for(int i = 1; i < menu.ItemLayouts.Length; i++) {
                Rectangle itemRect = menu.ItemLayouts[i];
                menu.ItemLayouts[i] = new Rectangle(itemRect.Location, new Size(menu.OverlayLayout.Width - ItemMargin.Size.Width, itemRect.Height));
            }
        }
        void OnResponseCapabilities(object sender, CapabilitiesResponsedEventArgs e) {
            GenerateMenu(e.Layers);
            SetOverlayMenuSelection(Menu.Items[1] as LayerOverlayMenuItem);
        }
        void OnMapControlMouseUp(object sender, MouseEventArgs e) {
            MapHitInfo hitInfo = MapControl.CalcHitInfo(e.Location);
            LayerOverlayMenuItem clickedItem = OverlayUtils.GetClickedOverlayItem(hitInfo) as LayerOverlayMenuItem;
            if(clickedItem == null)
                return;
            ResetMenuItemsBackground();
            SetOverlayMenuSelection(clickedItem);
        }
        void SetOverlayMenuSelection(LayerOverlayMenuItem clickedItem) {
            selectionLocked = true;
            clickedItem.BackgroundStyle.Fill = SelectionColor;
            Provider.ActiveLayerName = clickedItem.LayerName;
            editWebMapSevice.EditValue = clickedItem;
            selectionLocked = false;
        }
        void GenerateMenu(WmsLayerCollection layers) {
            Menu.Items.Clear();
            Menu.Items.Add(CreateHeader());
            foreach(WmsLayer layer in layers) 
                Menu.Items.Add(CreateMenuItem(layer));
        }
        void ResetMenuItemsBackground() {
            foreach(MapOverlayItemBase item in Menu.Items) {
                LayerOverlayMenuItem layerItem = item as LayerOverlayMenuItem;
                if(layerItem != null)
                    layerItem.BackgroundStyle.Fill = Color.Transparent;
            }
        }
        void editWebMapSevice_EditValueChanged(object sender, System.EventArgs e) {
            if (!selectionLocked) {
                ResetMenuItemsBackground();
                SetOverlayMenuSelection(((BarEditItem)sender).EditValue as LayerOverlayMenuItem);
            }
        }
        LayerOverlayMenuItem FindOverlayItem(string layerName) {
            foreach (MapOverlayTextItem item in Menu.Items) {
                LayerOverlayMenuItem findItem = item as LayerOverlayMenuItem;
                if (findItem != null && findItem.LayerName == layerName)
                    return findItem;
                }
            return null;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(34.5, -91.5);
            MapControl.ZoomLevel = 4;
        }
    }

    public class LayerOverlayMenuItem : MapOverlayTextItem {
        readonly string layerName;
        public string LayerName { get { return layerName; } }

        public LayerOverlayMenuItem(string name) {
            this.layerName = name;
        }

        public override string ToString() {
            return layerName;
        }
    }
}
