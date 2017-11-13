using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DevExpress.XtraMap.Demos {
    public partial class PhotoGallery : MapTutorialControl {
        ViewType currentViewType;
        bool dataLoaded;
        WorldCitiesInfo citiesInfo;
        UIControls uiControls;
        PhotoGalleryOverlayManager overlayManager;

        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        protected PhotoGalleryOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new PhotoGalleryOverlayManager();
                return overlayManager;
            }
        }
        protected UIControls UIControls {
            get {
                if(uiControls == null)
                    uiControls = new UIControls() {
                        Gallery = galleryControl1,
                        Map = mapControl1,
                        Preview = mapControl1.MiniMap
                    };
                return uiControls;
            }
        }
        protected WorldCitiesInfo CitiesInfo {
            get {
                if(citiesInfo == null)
                    citiesInfo = new WorldCitiesInfo();
                return citiesInfo;
            }
        }
        public override MapControl MapControl { get { return mapControl1; } }

        public PhotoGallery() {
            AutoMergeRibbon = true;
            InitializeComponent();
            ViewMap();
            
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            DemoUtils.SetBingMapDataProviderKey(MiniMapDataProvider);
        }

        void TilesLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            TilesLayer.DataLoaded -= TilesLayer_DataLoaded;
            ListSourceDataAdapter.DataSource = CitiesInfo.Cities;
            FillMiniMapData();
        }

        void FillMiniMapData() {
            foreach(CityInfo city in CitiesInfo.Cities) {
                MiniMapData.Items.Add(new MapDot() { Location = new GeoPoint(city.Latitude, city.Longitude), Size = 8 });
            }
        }
        void ItemsLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            ItemsLayer.DataLoaded -= ItemsLayer_DataLoaded;
            StartImagesChanging();
            dataLoaded = true;
        }
        void timer1_Tick(object sender, EventArgs e) {
            ChangeImages();
        }
        void SetChkShowMinimapState(bool enable) {
            ChkShowMinimap.Enabled = enable;
            ChkShowMinimap.Checked = enable;
        }
        void MapControl_Click(object sender, EventArgs e) {
            ResetCityGallery();
            ViewMap();
        }
        void StartImagesChanging() {
            MapControl.ImageList = CitiesInfo.GetImages();
            ChangeImages();
            this.timer1.Start();
        }
        void ChangeImages() {
            int imageListTotalIndex = 0;
            foreach(CityInfo city in CitiesInfo.Cities) {
                MapCustomElement mapElement = (MapCustomElement)ItemsLayer.GetMapItemBySourceObject(city);
                if(mapElement != null)
                    mapElement.ImageIndex = imageListTotalIndex + city.CurrentImageIndex;
                city.CurrentImageIndex++;
                imageListTotalIndex += city.Places.Count;
            }
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            if(e.Selection.Count == 0)
                return;
            CityInfo city = e.Selection[0] as CityInfo;
            if(city == null)
                return;
            ViewCityGallery(city);
        }
        void ViewMap() {
            SetChkShowMinimapState(true);
            ItemsLayer.SelectedItems.Clear();
            currentViewType = new MapViewType(UIControls, OverlayManager);
            mapControl1.SelectionChanged += mapControl1_SelectionChanged;
        }
        void ViewCityGallery(CityInfo city) {
            SetChkShowMinimapState(false);
            mapControl1.SelectionChanged -= mapControl1_SelectionChanged;
            MapControl.Click += MapControl_Click;
            currentViewType = new GalleryViewType(UIControls, city, OverlayManager);
            ((GalleryViewType)currentViewType).ApplyGalleryOptions();
        }
        void ViewPlace(PlaceInfo place) {
            currentViewType = new DetailViewType(UIControls, place, OverlayManager);
        }
        void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e) {
            ResetCityGallery();
            PlaceInfo place = (PlaceInfo)e.Item.Value;
            ViewPlace(place);
        }
        void ResetCityGallery() {
            MapControl.Click -= MapControl_Click;
            galleryControl1.Gallery.Groups.Clear();
        }
        void PerviousPlace() {
            PlaceInfo activePlace = ((DetailViewType)currentViewType).Place;
            CityInfo activeCity = (CityInfo)ItemsLayer.SelectedItem;
            ViewPlace(activeCity.GetPreviousPlace(activePlace));
        }
        void NextPlace() {
            PlaceInfo activePlace = ((DetailViewType)currentViewType).Place;
            CityInfo activeCity = (CityInfo)ItemsLayer.SelectedItem;
            ViewPlace(activeCity.GetNextPlace(activePlace));
        }
        void lblMapView_Click(object sender, EventArgs e) {
            ViewMap();
        }
        void mapControl1_MouseUp(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            MapHitInfo hitInfo = MapControl.CalcHitInfo(e.Location);
            MapOverlayItemBase clickedItem = OverlayUtils.GetClickedOverlayItem(hitInfo);
            if(clickedItem == null)
                return;
            if(OverlayManager.BackIconOverlay.Items.Contains(clickedItem))
                ViewMap();
            else if(clickedItem == OverlayManager.PlacePrevImage)
                PerviousPlace();
            else if(clickedItem == OverlayManager.PlaceNextImage)
                NextPlace();
        }
        void OnDispose(bool disposing) {
            if(uiControls != null) {
                uiControls.Dispose();
                uiControls = null;
            }
            if(overlayManager != null) {
                overlayManager.Dispose();
                overlayManager = null;
            }
        }
        void PhotoGallery_Load(object sender, EventArgs e) {
            OnStyleChanged();
        }
        protected override void DoHide() {
            base.DoHide();
            this.timer1.Stop();
        }
        protected override void DoShow() {
            base.DoShow();
            if(this.dataLoaded)
                this.timer1.Start();
        }
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            OverlayManager.RepaintImages(MapControl.LookAndFeel);
        }
        protected override void RestoreInitialView() {
            ViewMap();
            MapControl.CenterPoint = new GeoPoint(47.5, 2);
            MapControl.ZoomLevel = 0.5;
        }
    }
    public class WorldCitiesInfo {
        readonly List<CityInfo> cities;
        string imagesPath = DemoUtils.GetRelativeDirectoryPath(@"Images\PhotoGallery");

        public List<CityInfo> Cities { get { return cities; } }

        public WorldCitiesInfo() {
            this.cities = LoadDataFromXML();
        }
        List<CityInfo> LoadDataFromXML() {
            List<CityInfo> cities = new List<CityInfo>();

            String path = DemoUtils.GetRelativePath("CitiesPlacesData.xml");
            XDocument document = XDocument.Load(path);
            if(document != null) {
                foreach(XElement cityElement in document.Element("Cities").Elements()) {
                    string cityName = cityElement.Element("CityName").Value;
                    double latitude = Convert.ToDouble(cityElement.Element("Latitude").Value, CultureInfo.InvariantCulture);
                    double longitude = Convert.ToDouble(cityElement.Element("Longitude").Value, CultureInfo.InvariantCulture);
                    List<PlaceInfo> places = new List<PlaceInfo>();
                    foreach(XElement placeElement in cityElement.Element("Places").Elements()) {
                        string name = placeElement.Element("Name").Value;
                        double placeLat = Convert.ToDouble(placeElement.Element("Latitude").Value, CultureInfo.InvariantCulture);
                        double placeLon = Convert.ToDouble(placeElement.Element("Longitude").Value, CultureInfo.InvariantCulture);
                        string description = placeElement.Element("Description").Value;
                        string imageUri = placeElement.Element("ImageUri").Value;
                        places.Add(new PlaceInfo() {
                            Name = name,
                            Latitude = placeLat,
                            Longitude = placeLon,
                            Description = description,
                            ImageUri = imagesPath + imageUri,
                            City = cityName
                        });
                    }
                    cities.Add(new CityInfo(places) { CityName = cityName, Latitude = latitude, Longitude = longitude });
                }
            }
            return cities;
        }

        public ImageList GetImages() {
            ImageList images = new ImageList() { ImageSize = new Size(110, 82), ColorDepth = ColorDepth.Depth32Bit };
            foreach(CityInfo city in cities)
                foreach(PlaceInfo place in city.Places)
                    images.Images.Add(DemoUtils.GetInflatedImage(place.ImageUri, 14, 12));
            return images;
        }
    }
    public class CityInfo {
        readonly List<PlaceInfo> places;

        int currentImageIndex = 0;

        public string CityName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<PlaceInfo> Places { get { return places; } }
        public int CurrentImageIndex {
            get { return currentImageIndex; }
            set {
                if(value < 0 || value >= Places.Count)
                    value = 0;
                currentImageIndex = value;
            }
        }

        public CityInfo(List<PlaceInfo> places) {
            this.places = places;
        }
        public PlaceInfo GetNextPlace(PlaceInfo place) {
            int index = Places.FindIndex(p => place.Name == p.Name);
            index = index != Places.Count - 1 ? index + 1 : 0;
            return Places[index];
        }
        public PlaceInfo GetPreviousPlace(PlaceInfo place) {
            int index = Places.FindIndex(p => place.Name == p.Name);
            index = index != 0 ? index - 1 : Places.Count - 1;
            return Places[index];
        }
    }
    public class PlaceInfo {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public string City { get; set; }
    }
    public class UIControls : IDisposable {
        public MapControl Map { get; set; }
        public MiniMap Preview { get; set; }
        public GalleryControl Gallery { get; set; }
        public PanelControl InfoPanel { get; set; }
        public LabelControl City { get; set; }
        public LabelControl Place { get; set; }
        public LabelControl Description { get; set; }
        public PictureEdit ImageBox { get; set; }

        #region IDisposable implementation
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                if(Map != null) {
                    Map.Dispose();
                    Map = null;
                }
                if(Preview != null) {
                    Preview.Dispose();
                    Preview = null;
                }
                if(Gallery != null) {
                    Gallery.Dispose();
                    Gallery = null;
                }
                if(InfoPanel != null) {
                    InfoPanel.Dispose();
                    InfoPanel = null;
                }
                if(City != null) {
                    City.Dispose();
                    City = null;
                }
                if(Place != null) {
                    Place.Dispose();
                    Place = null;
                }
                if(Description != null) {
                    Description.Dispose();
                    Description = null;
                }
                if(ImageBox != null) {
                    ImageBox.Dispose();
                    ImageBox = null;
                }
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~UIControls() {
            Dispose(false);
        }
        #endregion
    }
    public abstract class ViewType {
        PhotoGalleryOverlayManager overlayManager;
        UIControls uiControls;

        protected PhotoGalleryOverlayManager OverlayManager { get { return overlayManager; } }
        protected UIControls UIControls { get { return uiControls; } }
        protected MapControl Map { get { return UIControls.Map; } }
        protected GalleryControl Gallery { get { return UIControls.Gallery; } }
        protected VectorItemsLayer ItemsLayer { get { return (VectorItemsLayer)Map.Layers["ItemsLayer"]; } }
        protected VectorItemsLayer PushpinLayer { get { return (VectorItemsLayer)Map.Layers["PushpinLayer"]; } }
        protected abstract double MaxZoomLevel { get; }
        protected abstract double MinZoomLevel { get; }
        protected abstract bool MapViewItemsVisible { get; }
        protected abstract bool GalleryViewItemsVisible { get; }
        protected abstract bool DetailViewItemsVisible { get; }

        protected ViewType(UIControls controls, PhotoGalleryOverlayManager overlayManager) {
            this.overlayManager = overlayManager;
            this.uiControls = controls;
            ApplyOptions();
        }
        void Gallery_Paint(object sender, PaintEventArgs e) {
            Gallery.Paint -= Gallery_Paint;
            DevExpress.XtraMap.Native.OverlapFlickeringSolver.Refresh(Map.FindForm());
        }
        protected virtual void ApplyOptions() {
            SetMinMaxZoomLevel();
            Map.EnableScrolling = !GalleryViewItemsVisible;
            Map.EnableZooming = !GalleryViewItemsVisible;
            ItemsLayer.Visible = MapViewItemsVisible;
            PushpinLayer.Visible = DetailViewItemsVisible;
            if(GalleryViewItemsVisible)
                Gallery.Paint += Gallery_Paint;
            Gallery.Visible = GalleryViewItemsVisible;
            uiControls.Preview.Visible = MapViewItemsVisible;
            overlayManager.BackIconOverlay.Visible = DetailViewItemsVisible;
            overlayManager.PlaceOverlay.Visible = DetailViewItemsVisible;
            overlayManager.NavigationOverlay.Visible = DetailViewItemsVisible;
            overlayManager.DescriptionOverlay.Visible = DetailViewItemsVisible;
        }
        void SetMinMaxZoomLevel() {
            if(Map.MaxZoomLevel < MinZoomLevel) {
                Map.MaxZoomLevel = MaxZoomLevel;
                Map.MinZoomLevel = MinZoomLevel;
            } else {
                Map.MinZoomLevel = MinZoomLevel;
                Map.MaxZoomLevel = MaxZoomLevel;
            }
        }
    }
    public class MapViewType : ViewType {
        const int MaxZoom = 7;
        const int MinZoom = 5;

        protected override double MaxZoomLevel { get { return MaxZoom; } }
        protected override double MinZoomLevel { get { return MinZoom; } }
        protected override bool MapViewItemsVisible { get { return true; } }
        protected override bool GalleryViewItemsVisible { get { return false; } }
        protected override bool DetailViewItemsVisible { get { return false; } }

        public MapViewType(UIControls controls, PhotoGalleryOverlayManager overlayManager)
            : base(controls, overlayManager) {
        }
        protected override void ApplyOptions() {
            base.ApplyOptions();
            Map.ZoomLevel = MinZoomLevel;
        }
    }
    public class GalleryViewType : ViewType {
        const int MaxZoom = 7;
        const int MinZoom = 5;

        CityInfo city;

        protected override double MaxZoomLevel { get { return MaxZoom; } }
        protected override double MinZoomLevel { get { return MinZoom; } }
        protected override bool MapViewItemsVisible { get { return false; } }
        protected override bool GalleryViewItemsVisible { get { return true; } }
        protected override bool DetailViewItemsVisible { get { return false; } }
        public CityInfo City { get { return city; } }

        public GalleryViewType(UIControls controls, CityInfo city, PhotoGalleryOverlayManager overlayManager)
            : base(controls, overlayManager) {
            this.city = city;
        }
        public void ApplyGalleryOptions() {
            GalleryItemGroup galleryGroup = new GalleryItemGroup() { Caption = city.CityName, CaptionAlignment = GalleryItemGroupCaptionAlignment.Center };
            foreach(PlaceInfo place in city.Places) {
                GalleryItem item = new GalleryItem(Image.FromFile(place.ImageUri), place.Name, "");
                item.Value = place;
                galleryGroup.Items.Add(item);
            }
            Gallery.Gallery.Groups.Add(galleryGroup);
            Image img = DemoUtils.GetBackGroundImage(Map, new Rectangle(Gallery.Location, Gallery.Size), 0.5f);
            if(img != null)
                Gallery.Gallery.BackgroundImage = img;
        }
    }
    public class DetailViewType : ViewType {
        const int MaxZoom = 18;
        const int MinZoom = 15;

        PlaceInfo place;

        MapPushpin Pushpin { get { return (MapPushpin)(((MapItemStorage)(PushpinLayer).Data).Items[0]); } }
        LabelControl LabelCity { get { return UIControls.City; } }
        LabelControl LabelPlace { get { return UIControls.Place; } }
        LabelControl LabelDescription { get { return UIControls.Description; } }
        PictureEdit ImageBox { get { return UIControls.ImageBox; } }
        protected override double MaxZoomLevel { get { return MaxZoom; } }
        protected override double MinZoomLevel { get { return MinZoom; } }
        protected override bool MapViewItemsVisible { get { return false; } }
        protected override bool GalleryViewItemsVisible { get { return false; } }
        protected override bool DetailViewItemsVisible { get { return true; } }
        public PlaceInfo Place { get { return place; } }

        public DetailViewType(UIControls controls, PlaceInfo place, PhotoGalleryOverlayManager overlayManager)
            : base(controls, overlayManager) {
            this.place = place;
            ApplyPlaceOptions();
        }
        void ApplyPlaceOptions() {
            Map.CenterPoint = new GeoPoint(place.Latitude, place.Longitude);
            Pushpin.Location = Map.CenterPoint;
            OverlayManager.PlaceImage.Image = Image.FromFile(place.ImageUri);
            OverlayManager.CityName.Text = place.City;
            OverlayManager.PlaceName.Text = place.Name;
            OverlayManager.PlaceDescription.Text = place.Description;
        }
    }
}
