using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Map;
using DevExpress.Utils;
using DevExpress.XtraMap.Native;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {
    public partial class BingServices : MapTutorialControl {
        readonly Color defaultRouteColor = Color.FromArgb(0xFF, 0x8A, 0xFB, 0xFF);
        public const int DefaultStrokeWidth = 4;

        BingServicesOverlayManager overlayManager;
        RouteHelper routeHelper;
        MapItem activeItem;
        RouteState state = RouteState.Normal;

        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        protected override BingMapKind MiniMapBingKind { get { return BingMapKind.Hybrid; } }
        public override MapControl MapControl { get { return mapControl1; } }

        BingServicesOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new BingServicesOverlayManager();
                return overlayManager;
            }
        }
        protected RouteHelper RouteHelper { 
            get {
                if(routeHelper == null) {
                    routeHelper = new RouteHelper();
                    routeHelper.WaypointsChanged += OnWaypointsChanged;
                }
                return routeHelper; 
            } 
        }

        protected MapItemCollection RouteLayerItems {  get { return  (MapItemCollection)RouteLayer.Data.Items;}}

        public RouteState State {
            get {
                return state;
            }
            set {
                if(state == value)
                    return;
                state = value;
                OnRouteStateChanged();
            }
        }

        public BingServices() {
            InitializeComponent();
            PrepareLayerProviders();
        }
        void UpdateInformationText() {
            OverlayManager.MessageItem.Text = GetActionText();
        }
        void SetRouteLayerStyles(InformationLayer routeLayer) {
            routeLayer.ItemStyle.Stroke = routeLayer.SelectedItemStyle.Stroke = defaultRouteColor;
            routeLayer.ItemStyle.StrokeWidth = routeLayer.SelectedItemStyle.StrokeWidth = DefaultStrokeWidth;
        }
        void PrepareLayerProviders() {
            DemoUtils.SetBingMapDataProviderKey(BingMapDataProvider);
            DemoUtils.SetBingMapDataProviderKey(SearchProvider);
            DemoUtils.SetBingMapDataProviderKey(GeoCodeProvider);
            DemoUtils.SetBingMapDataProviderKey(RouteProvider);
            SetRouteLayerStyles(RouteLayer);
        }
        void OnRouteStateChanged() {
            bool isDriving = State == RouteState.Drive;
            mapControl1.ShowSearchPanel = !isDriving;
            GeoCodeProvider.ProcessMouseEvents = !isDriving;

            switch(State) {
                case RouteState.Drive:
                    RouteHelper.BeginDrive(MapControl, RouteLayer);
                    RouteHelper.DriveModel.ActionTextChanged += (s, e) => OverlayManager.MessageItem.Text = RouteHelper.DriveModel.ActionText;
                    RouteHelper.DriveModel.CurrentLocationChanged += (s, e) => mapControl1.CenterPoint = RouteHelper.DriveModel.CurrentLocation;
                    this.driveButton.Enabled = false;
                    this.stopButton.Enabled = true;
                    this.clearButton.Enabled = false;
                    break;
                case RouteState.Normal:
                    RouteHelper.StopDrive();
                    this.driveButton.Enabled = true;
                    this.stopButton.Enabled = false;
                    this.clearButton.Enabled = true;
                    break;
            }
            UpdateInformationText();
        }
        void OnWaypointsChanged(object sender, EventArgs e) {
            DataAdapter.DataSource = new List<WayPointInfo>(RouteHelper.WaypointInfoList);
            if (RouteHelper.Waypoints.Count > 1) 
                RouteProvider.CalculateRoute(RouteHelper.Waypoints);
            else
                driveButton.Enabled = false;
        }
        void OnRouteLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            if(args.Error == null && !args.Cancelled)
                RouteHelper.ProcessRouteItems(args.Items);
        }
        void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            List<BingRouteResult> results = e.CalculationResult.RouteResults;
            BingRouteResult routeResult = results.Count > 0 ? results[0] : null;
            if(RouteHelper.ProcessRouteResult(routeResult)) {
                DataAdapter.DataSource = null;
                driveButton.Enabled = true;
            }
        }
        void OnGeoCodeAndSearchLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            if(state == RouteState.Drive)
                return;
            foreach(MapItem item in args.Items)
                RouteHelper.AddGeneratedPushpin(item as MapPushpin);

            UpdateInformationText();
        }
        void clearButton_ItemClick(object sender, EventArgs e) {
            RouteHelper.Clear();
            ClearLayerResults();
            RouteLayer.ClearResults();
            SearchProvider.ClearSearchPanel();
            DataAdapter.DataSource = null;
            driveButton.Enabled = false;
            stopButton.Enabled = false;
            UpdateInformationText();
        }
        void ClearLayerResults() {
            SearchLayer.ClearResults();
            GeocodeLayer.ClearResults();
        }
        bool CanRemovePin(MapPushpin pin, MapItemClickEventArgs e) {
            return pin != null && object.Equals(RouteLayer, pin.Layer) && e.MouseArgs.Button == MouseButtons.Right && this.State != RouteState.Drive;
        }
        void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e) {
            MapPushpin pin = e.Item as MapPushpin;
            if(CanRemovePin(pin, e)) {
                this.activeItem = pin;
                popupMenu1.ShowPopup(Cursor.Position);
            }
            if(e.MouseArgs.Button == MouseButtons.Left) {
                if(RouteHelper.GeneratedPushpins.Contains(pin)) {
                    AddPointToRoute(pin);
                    e.Handled = true;
                }
            }
            UpdateInformationText();
        }
        void AddPointToRoute(MapPushpin pushpin) {
            RouteHelper.AddWaypoint(pushpin);
            ClearLayerResults();
        }
        void DeleteWaypoint() {
            int index = CalculatePushpinIndex();
            RouteLayerItems.Remove(this.activeItem);
            RouteHelper.DeleteWaypoint(index);
            ClearRoute();
        }
        void ClearRoute() {
            List<MapItem> itemsToRemove = new List<MapItem>();
            foreach (MapItem item in RouteLayerItems)
                if (item is MapPolyline)
                    itemsToRemove.Add(item);
            foreach (MapItem item in itemsToRemove)
                RouteLayerItems.Remove(item);
        }
        int CalculatePushpinIndex() {
            MapItemCollection items = RouteLayerItems;
            int index = -1;
            for(int i = 0; i < items.Count; i++) {
                if(items[i] is MapPushpin) {
                    index++;
                    if(items[i].Equals(this.activeItem))
                        return index;
                }
            }
            return -1;
        }
        void barDeleteButton_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            DeleteWaypoint();
        }
        void barCloseButton_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            popupMenu1.HidePopup();
        }
        void driveButton_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            State = RouteState.Drive;
        }
        void stopButton_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            State = RouteState.Normal;
        }
        void OnDispose(bool disposing) {
            if(this.routeHelper != null) {
                this.routeHelper.Dispose();
                this.routeHelper = null;
            }
            if(this.overlayManager != null) {
                this.overlayManager.Dispose();
                this.overlayManager = null;
            }
        }
        string GetActionText() {
            if(this.RouteHelper.Waypoints.Count == 0) {
                if(this.RouteHelper.GeneratedPushpins.Count > 0)
                    return "Click the pushpin to set a start point.";
                else
                    return "Click the map or use Search to find a location.";
            }

            if(this.RouteHelper.Waypoints.Count == 1)
                return "Set a finish point to calculate a route.";


            return "Set another finish point or click Drive.";
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            OptionsPage.Groups.Add(actionPageGroup);
            OptionsPage.Ribbon.Items.Add(clearButton);
            OptionsPage.Ribbon.Items.Add(driveButton);
            OptionsPage.Ribbon.Items.Add(stopButton);
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(34.158506, -118.255629);
            MapControl.ZoomLevel = 14;
        }
        protected override void DoHide() {
            if(State == RouteState.Drive)
                State = RouteState.Normal;
            base.DoHide();
        }
    }
    public enum RouteState {
        Normal,
        Drive
    }
    public class WayPointInfo {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Text { get; set; }
        public string ToolTipPattern { get; set; }
        public int Type { get; set; }
    }
    public class RouteHelper : IDisposable {
        bool disposed = false;
        List<MapPushpin> generatedPushpins = new List<MapPushpin>();
        List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
        List<WayPointInfo> waypointsInfoList = new List<WayPointInfo>();
        List<GeoPoint> routePath = new List<GeoPoint>();
        List<BingItineraryItem> itineraryItems = new List<BingItineraryItem>();

        int waypointIndex = 0;

        public List<MapPushpin> GeneratedPushpins { get { return generatedPushpins; } }
        public List<RouteWaypoint> Waypoints { get { return waypoints; } }
        public List<WayPointInfo> WaypointInfoList { get { return waypointsInfoList; } }
        public DriveHelper DriveModel { get; set; }

        public event EventHandler WaypointsChanged;

        public void AddGeneratedPushpin(MapPushpin pushpin) {
            if(pushpin != null && !GeneratedPushpins.Contains(pushpin))
                GeneratedPushpins.Add(pushpin);
        }
        public void Clear() {
            waypointIndex = 0;
            Waypoints.Clear();
            GeneratedPushpins.Clear();
            WaypointInfoList.Clear();
        }
        public void AddWaypoint(MapPushpin generatedPushpin) {
            GeoPoint pushpinLocation = (GeoPoint)generatedPushpin.Location;
            LocationInformation info = generatedPushpin.Information as LocationInformation;
            string description = info != null ? info.DisplayName : string.Empty;
            GeoPoint location = pushpinLocation;
            RouteWaypoint waypoint = new RouteWaypoint(description, location);
            if(waypoints.Contains(waypoint))
                return;

            waypoints.Add(waypoint);
            WayPointInfo pointInfo = CreateWayPointInfo(pushpinLocation, Convert.ToString(info));
            WaypointInfoList.Add(pointInfo);
            GeneratedPushpins.Clear();
            RaiseWayPointChanged();
        }
        WayPointInfo CreateWayPointInfo(GeoPoint location, string info) {
            WayPointInfo pointInfo = new WayPointInfo();
            pointInfo.Type = (int)MapItemType.Pushpin;
            pointInfo.ToolTipPattern = info;
            pointInfo.Text = NextWaypointLetter();
            pointInfo.Latitude = location.Latitude;
            pointInfo.Longitude = location.Longitude;
            return pointInfo;
        }
        void RaiseWayPointChanged() {
            if(WaypointsChanged != null) WaypointsChanged(this, EventArgs.Empty);
        }
        protected string NextWaypointLetter() {
            string letter = "" + (char)((byte)'A' + waypointIndex % 26);
            waypointIndex++;
            return letter;
        }
        protected virtual void Dispose(bool disposing) {
            if (disposed)
                return;
            if (disposing) {
                if (DriveModel != null)
                    DriveModel.Dispose();
            }
            disposed = true;
        }

        public void ProcessRouteItems(MapItem[] items) {
            GeneratedPushpins.Clear();
            WaypointInfoList.Clear();
            waypointIndex = 0;

            foreach(MapItem item in items) {
                MapPushpin pushpin = item as MapPushpin;
                if(pushpin != null) {
                    pushpin.Text = NextWaypointLetter();
                }
            }
        }
        public bool ProcessRouteResult(BingRouteResult result) {
            if(result == null)
                return false;
            routePath = result.RoutePath;
            itineraryItems.Clear();
            foreach(BingRouteLeg leg in result.Legs)
                foreach(BingItineraryItem item in leg.Itinerary)
                    itineraryItems.Add(item);
            return true;
        }

        public void DeleteWaypoint(int index) {
            if(index < 0 || index >= Waypoints.Count)
                return;
            Waypoints.RemoveAt(index);
            RaiseWayPointChanged();
        }
        public void StopDrive() {
            if(DriveModel != null) {
                DriveModel.Cleanup();
                DriveModel.Dispose();
                DriveModel = null;
            }
        }
        public void BeginDrive(MapControl map, InformationLayer routeLayer) {
            if((routePath != null) && (routePath.Count > 1)) {
                StopDrive();
                DriveModel = new DriveHelper(map, routeLayer, routePath, itineraryItems);
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    public class DriveHelper : IDisposable{
        static readonly Bitmap driveMarker = new Bitmap(DemoUtils.GetRelativePath("\\Images\\Pin.png"));

        const double DriveSpeed = 100.0;
        const double ScaleFactor = 5.0;
        const int DriveTimeQuant = 10;
        const double DriveTimeQuantInSeconds = (double)DriveTimeQuant / 1000;
        readonly Color DefaultDriveColor = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
        const int DefaultStrokeWidth = BingServices.DefaultStrokeWidth;

        InformationLayer routeLayer;
        MapItemCollection routeLayerItems;
        List<GeoPoint> routePath;
        MapPolyline drivePath;
        ObservableCollection<MapItem> driveItems;
        MapCustomElement driveCustomElement;
        Timer animationTimer;
        GeoPoint baseLocation = new GeoPoint();
        GeoPoint targetLocation = new GeoPoint();
        MapUnit basePoint;
        MapUnit targetPoint;
        double currentDistance;
        double distance;
        MapUnit currentPoint;
        List<BingItineraryItem> itineraryItems;
        int routeNodeIndex;
        string actionText;
        MapControl map;
        bool disposed = false;

        public GeoPoint CurrentLocation {
            get { return (GeoPoint)map.MapUnitToCoordPoint(currentPoint); }
        }
        public string ActionText {
            get { return actionText; }
            set {
                actionText = value;
                if(ActionTextChanged != null)
                    ActionTextChanged(this, new PropertyChangedEventArgs("ActionText"));
            }
        }
        public Image DriveMarker { get { return driveMarker; } }

        public event PropertyChangedEventHandler CurrentLocationChanged;
        public event PropertyChangedEventHandler ActionTextChanged;

        static public double KilometerPerHourToMapUnitsPerSecond(double kmh) {
            return kmh / 40000.0 / 360.0;
        }
        static public double DistanceBetweenPoints(MapUnit a, MapUnit b) {
            MapUnit vector = new MapUnit(b.X - a.X, b.Y - a.Y);
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public DriveHelper(MapControl map, InformationLayer routeLayer, List<GeoPoint> routePath, List<BingItineraryItem> itineraryItems) {
            this.map = map;
            this.routeLayer = routeLayer;
            this.routeLayerItems = (MapItemCollection)routeLayer.Data.Items;
            this.routePath = routePath;
            this.itineraryItems = CreateItineraryItems(itineraryItems);
            this.drivePath = new MapPolyline() { Stroke = DefaultDriveColor, StrokeWidth = DefaultStrokeWidth };
            this.drivePath.Points.Add(targetLocation);
            this.driveCustomElement = new MapCustomElement() { Location = routePath[0], Visible = true, Image = DriveMarker, UseAnimation = false, BackgroundDrawingMode = ElementState.None };
            this.animationTimer = new Timer();
            this.animationTimer.Interval = DriveTimeQuant;
            this.animationTimer.Tick += new EventHandler(OnTimerTick);
            baseLocation = targetLocation = routePath[0];
            currentPoint = basePoint = map.CoordPointToMapUnit(baseLocation);
            targetPoint = map.CoordPointToMapUnit(targetLocation);
            currentDistance = 0;
            distance = 0;
            routeNodeIndex = 0;
            driveItems = new ObservableCollection<MapItem>();
            driveItems.Add(drivePath);
            driveItems.Add(driveCustomElement);
            this.routeLayerItems.AddRange(driveItems);
            Advance();
        }
        List<BingItineraryItem> CreateItineraryItems(List<BingItineraryItem> itineraryItems) {
            List<BingItineraryItem> items = new List<BingItineraryItem>(itineraryItems.Count);
            for(int i = 0; i < itineraryItems.Count; i++)
                items.Add(itineraryItems[i]);
            return items;
        }

        bool Advance() {
            if(routeNodeIndex < (routePath.Count - 1)) {
                routeNodeIndex++;
                baseLocation = targetLocation;
                currentPoint = map.CoordPointToMapUnit(baseLocation);
                targetLocation = routePath[routeNodeIndex];
                basePoint = map.CoordPointToMapUnit(baseLocation);
                targetPoint = map.CoordPointToMapUnit(targetLocation);
                distance = DriveHelper.DistanceBetweenPoints(targetPoint, basePoint);
                currentDistance = 0;

                drivePath.Points[drivePath.Points.Count - 1] = baseLocation;
                drivePath.Points.Add(baseLocation);

                CheckItinerary();

                if(!animationTimer.Enabled)
                    animationTimer.Start();
                return true;
            } else {
                if(animationTimer.Enabled)
                    animationTimer.Stop();
                driveCustomElement.Visible = false;
                return false;
            }
        }
        void CheckItinerary() {
            GeoPoint location = (GeoPoint)map.MapUnitToCoordPoint(currentPoint);
            BingItineraryItem currentItem = itineraryItems[0];
            MapSize geoSize = new MapSize(Math.Abs(location.Latitude - currentItem.Location.Latitude), Math.Abs(location.Longitude - currentItem.Location.Longitude));
            MapSize metricSize = map.CoordToMeasureUnitSize(location, geoSize);
            double distance = Math.Sqrt(metricSize.Width * metricSize.Width + metricSize.Height * metricSize.Height);
            if(distance < 0.005)
                if(itineraryItems.Count > 1)
                    itineraryItems.Remove(currentItem);
                else
                    distance = 0.0;
            if(distance > 0.0)
                ActionText = itineraryItems[0].Maneuver.ToString() + " after " + ((distance > 0.9) ? String.Format("{0:0} km", Math.Ceiling(distance)) : String.Format("{0:0} m", Math.Ceiling(distance * 10) * 100));
            else
                ActionText = "Finish! Click Stop and Clear to set a new route.";
        }
        void OnTimerTick(object sender, EventArgs e) {
            double scaledTime = DriveTimeQuantInSeconds * ScaleFactor;
            while(scaledTime > 0.0) {
                double quant = Math.Min(scaledTime, DriveTimeQuantInSeconds);
                double excess = Update(quant * DriveHelper.KilometerPerHourToMapUnitsPerSecond(DriveSpeed));
                if(excess > 0.0) {
                    if(!Advance()) {
                        CheckItinerary();
                        PlaceItems((GeoPoint)map.MapUnitToCoordPoint(currentPoint));
                        return;
                    }
                    excess = Update(excess);
                }
                PlaceItems((GeoPoint)map.MapUnitToCoordPoint(currentPoint));
                CheckItinerary();
                scaledTime -= quant;
            }
        }
        double Update(double distanceToGo) {
            currentDistance += distanceToGo;
            if(currentDistance > distance) {
                currentPoint = targetPoint;
                return currentDistance - distance;
            }
            MapUnit offset = GetDirection();
            offset.X *= currentDistance;
            offset.Y *= currentDistance;
            currentPoint = new MapUnit(basePoint.X + offset.X, basePoint.Y + offset.Y);
            return 0.0;
        }
        MapUnit GetDirection() {
            MapUnit direction = new MapUnit(targetPoint.X - basePoint.X, targetPoint.Y - basePoint.Y);
            double length = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            if(length > 0.0) {
                double oneByLenght = 1 / length;
                direction.X *= oneByLenght;
                direction.Y *= oneByLenght;
            }
            return direction;
        }
        void PlaceItems(GeoPoint location) {
            drivePath.Points[drivePath.Points.Count - 1] = location;
            driveCustomElement.Location = location;
            if(CurrentLocationChanged != null)
                CurrentLocationChanged(this, new PropertyChangedEventArgs("CurrentLocation"));
        }

        protected virtual void Dispose(bool disposing) {
            if (disposed)
                return;
            if (disposing) {
                if (animationTimer != null) {
                    animationTimer.Stop();
                    animationTimer.Tick -= new EventHandler(OnTimerTick);
                    animationTimer.Dispose();
                }
            }
            disposed = true;
        }

        public void Cleanup() {
            if(animationTimer.Enabled)
                animationTimer.Stop();
            drivePath.Points.Clear();
            driveCustomElement.Visible = false;
            foreach(MapItem item in driveItems)
                this.routeLayerItems.Remove(item);
            driveItems.Clear();
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
