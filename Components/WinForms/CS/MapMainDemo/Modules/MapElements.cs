using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.Map;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {

    public partial class MapElements : MapTutorialControl {
        static object imageLocker = new object();
        public static object ImageLocker { get { return imageLocker; } }

        MapElementsOverlayManager overlayManager;
        FlightMapDataGenerator dataGenerator;

        MapElementsOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new MapElementsOverlayManager();
                return overlayManager;
            }
        }
        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        protected override BingMapKind MiniMapBingKind { get { return BingMapKind.Road; } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopLeft; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public MapElements() {
            InitializeComponent();
            mapControl1.SetMapItemFactory(new FlightMapFactory());
            
            dataGenerator = new FlightMapDataGenerator(OverlayManager);
            dataGenerator.DataChanged += OnDataChanged;

            PlanesDataAdapter.DataSource = dataGenerator.Planes;
            PathsDataAdapter.DataSource = dataGenerator.AirPaths; 
            AutoMergeRibbon = true;
        }
        void MapElements_DataLoaded(object sender, DataLoadedEventArgs e) {
            DemoUtils.SetBingMapDataProviderKey(MapBingDataProvider);
            dataGenerator.SelectedPlane = dataGenerator.Planes[0];
            OnActivePlaneChanged();
        }
        void OnDataChanged(object sender, EventArgs e) {
            foreach (PlaneInfo info in dataGenerator.Planes) {
                if (!info.IsLanded) {
                    MapCustomElement item = PlanesLayer.GetMapItemBySourceObject(info) as MapCustomElement;
                    if (item != null) item.Location = new GeoPoint(info.Latitude, info.Longitude);
                }
            }
        }
        void OnActivePlaneChanged() {
            MapItemCollection items = (MapItemCollection)PathsLayer.Data.Items;
            items.BeginUpdate();
            HideLayerItems(PathsLayer);
            List<InfoBase> airPath = dataGenerator.FindAirPath(dataGenerator.SelectedPlane);
            foreach(InfoBase airPathElement in airPath) {
                MapItem item = PathsLayer.GetMapItemBySourceObject(airPathElement);
                if(item != null)
                    item.Visible = true;
            }
            items.EndUpdate();
        }
        void HideLayerItems(VectorItemsLayer layer) {
            foreach(MapItem item in ((IMapDataAdapter)layer.Data).Items)
                item.Visible = false;
        }

        void mapControl1_DrawMapItem(object sender, DrawMapItemEventArgs e) {
            DrawMapPointerEventArgs args = e as DrawMapPointerEventArgs;
            if (args != null) {
                args.DisposeImage = true;
                MapItem item = e.Item;
                InfoBase info = ((VectorItemsLayer)e.Item.Layer).GetItemSourceObject(item) as InfoBase;
                if(info != null) {
                    lock(ImageLocker) {
                        args.Image = info.Icon != null ? (Image)info.Icon.Clone() : null;
                    }
                }
            }
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            dataGenerator.SelectedPlane = e.Selection.Count > 0 ? (PlaneInfo)e.Selection[0] : null;
            OnActivePlaneChanged();
        }
        void mapControl1_SelectionChanging(object sender, MapSelectionChangingEventArgs e) {
            PlaneInfo plainInfo = e.Selection.Count > 0 ? e.Selection[0] as PlaneInfo : null;
            e.Cancel = plainInfo == null;
        }
        void OnDispose(bool disposing) {
            if(this.dataGenerator != null) {
                this.dataGenerator.Dispose();
                this.dataGenerator = null;
            }
            if(this.overlayManager != null) {
                this.overlayManager.Dispose();
                this.overlayManager = null;
            }
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(this.Visible)
                dataGenerator.Start();
            else
                dataGenerator.Stop();
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint(26, -26);
            MapControl.ZoomLevel = 2;
        }
    }

    public abstract class InfoBase {
        protected abstract MapItemType Type { get; }
        public int ItemType { get { return (int)Type; } }
        public virtual Image Icon { get { return null; } }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class AirportInfo : InfoBase {
        static Bitmap icon = new Bitmap(DemoUtils.GetRelativePath("\\Images\\Airport.png"));

        protected override MapItemType Type { get { return MapItemType.Custom; } }
        public override Image Icon { get { return icon; } }

        public AirportInfo(GeoPoint location) {
            this.Latitude = location.Latitude;
            this.Longitude = location.Longitude;
        }
    }

    public class PlaneTrajectory : InfoBase {
        class TrajectoryPart {
            readonly GeoPoint startPointField;
            readonly GeoPoint endPointField;
            readonly double flightTimeField;
            readonly double courseField;

            public GeoPoint StartPoint { get { return startPointField; } }
            public GeoPoint EndPoint { get { return endPointField; } }
            public double FlightTime { get { return flightTimeField; } }
            public double Course { get { return courseField; } }

            public TrajectoryPart(ProjectionBase projection, GeoPoint startPoint, GeoPoint endPoint, double speedInKmH) {
                this.startPointField = startPoint;
                this.endPointField = endPoint;
                MapSize sizeInKm = projection.GeoToKilometersSize(startPoint, new MapSize(Math.Abs(startPoint.Longitude - endPoint.Longitude), Math.Abs(startPoint.Latitude - endPoint.Latitude)));
                double partlength = Math.Sqrt(sizeInKm.Width * sizeInKm.Width + sizeInKm.Height * sizeInKm.Height);
                flightTimeField = partlength / speedInKmH;
                courseField = Math.Atan2((endPoint.Longitude - startPoint.Longitude), (endPoint.Latitude - startPoint.Latitude)) * 180 / Math.PI;
            }
            public GeoPoint GetPointByCurrentFlightTime(double currentFlightTime) {
                if (currentFlightTime > FlightTime)
                    return endPointField;
                double ratio = currentFlightTime / FlightTime;
                return new GeoPoint(startPointField.Latitude + ratio * (endPointField.Latitude - startPointField.Latitude), startPointField.Longitude + ratio * (endPointField.Longitude - startPointField.Longitude));
            }
        }

        readonly SphericalMercatorProjection projection = new SphericalMercatorProjection();
        readonly List<TrajectoryPart> trajectory = new List<TrajectoryPart>();
        readonly AirportInfo startPoint;
        readonly AirportInfo endPoint;
        readonly double speedInKmH;

        protected override MapItemType Type { get { return MapItemType.Polyline; } }
        public AirportInfo StartPoint { get { return startPoint; } }
        public AirportInfo EndPoint { get { return endPoint; } }
        public double FlightTime {
            get {
                double result = 0.0;
                foreach (TrajectoryPart part in trajectory)
                    result += part.FlightTime;
                return result;
            }
        }

        public PlaneTrajectory(List<CoordPoint> points, double speedInKmH) {
            this.speedInKmH = speedInKmH;
            UpdateTrajectory(points);
            startPoint = new AirportInfo((trajectory.Count > 0) ? trajectory[0].StartPoint : new GeoPoint(0, 0));
            endPoint = new AirportInfo((trajectory.Count > 0) ? trajectory[trajectory.Count - 1].EndPoint : new GeoPoint(0, 0));
        }
        public GeoPoint GetPointByCurrentFlightTime(double currentFlightTime) {
            double time = 0.0;
            for (int i = 0; i < trajectory.Count - 1; i++) {
                if (trajectory[i].FlightTime > currentFlightTime - time)
                    return trajectory[i].GetPointByCurrentFlightTime(currentFlightTime - time);
                time += trajectory[i].FlightTime;
            }
            return trajectory[trajectory.Count - 1].GetPointByCurrentFlightTime(currentFlightTime - time);
        }
        public CoordPointCollection GetAirPath() {
            CoordPointCollection result = new CoordPointCollection();
            foreach(TrajectoryPart trajectoryPart in trajectory)
                result.Add(trajectoryPart.StartPoint);
            if(trajectory.Count > 0)
                result.Add(trajectory[trajectory.Count - 1].EndPoint);
            return result;
        }
        public double GetCourseByCurrentFlightTime(double currentFlightTime) {
            double time = 0.0;
            for (int i = 0; i < trajectory.Count - 1; i++) {
                if (trajectory[i].FlightTime > currentFlightTime - time)
                    return trajectory[i].Course;
                time += trajectory[i].FlightTime;
            }
            return trajectory[trajectory.Count - 1].Course;
        }
        public void UpdateTrajectory(List<CoordPoint> points) {
            trajectory.Clear();
            for(int i = 0; i < points.Count - 1; i++)
                trajectory.Add(new TrajectoryPart(projection, (GeoPoint)points[i], (GeoPoint)points[i + 1], speedInKmH));
        }
    }

    public class PlaneInfo : InfoBase {
        static string ConvertPlaneNameToFilePath(string PlaneName) {
            string result = PlaneName.Replace(" ", "");
            result = "\\Images\\Planes\\" + result.Replace("-", "") + ".png";
            return DemoUtils.GetRelativePath(result);
        }

        bool isLandedField = false;
        double currentFlightTime;
        double course;
        Image icon;
        readonly Image sourceIcon;
        readonly string planeIDField;
        readonly string nameField;
        readonly string endPointNameField;
        readonly string startPointNameField;
        readonly double speedInKmHField;
        readonly double flightAltitudeField;
        readonly Image imageField;
        readonly PlaneTrajectory trajectoryField;

        double Course {
            get { return course; }
            set {
                if (course == value)
                    return;
                course = value;
                UpdateIcon();
            }
        }
        protected override MapItemType Type { get { return MapItemType.Custom; } }
        public double CurrentFlightTime {
            get { return currentFlightTime; }
            set {
                if (currentFlightTime == value)
                    return;
                currentFlightTime = value;
                UpdatePosition(currentFlightTime);
            }
        }
        public string PlaneID { get { return planeIDField; } }
        public string Name { get { return nameField; } }
        public string EndPointName { get { return endPointNameField; } }
        public string StartPointName { get { return startPointNameField; } }
        public double SpeedKmH { get { return isLandedField ? 0.0 : speedInKmHField; } }
        public double FlightAltitude { get { return isLandedField ? 0.0 : flightAltitudeField; } }
        public Image Image { get { return imageField; } }
        public bool IsLanded { get { return isLandedField; } }
        public double TotalFlightTime { get { return trajectoryField.FlightTime; } }
        public override Image Icon { get { return icon; } }
        public PlaneTrajectory Trajectory { get { return trajectoryField; } }

        public PlaneInfo(string name, string id, string endPointName, string startPointName, double speedInKmH, double flightAltitude, List<CoordPoint> points, Image sourceIcon) {
            this.nameField = name;
            this.planeIDField = id;
            this.sourceIcon = sourceIcon;
            this.endPointNameField = endPointName;
            this.startPointNameField = startPointName;
            this.speedInKmHField = speedInKmH;
            this.flightAltitudeField = flightAltitude;
            this.imageField = new Bitmap(ConvertPlaneNameToFilePath(name));
            trajectoryField = new PlaneTrajectory(points, speedInKmH);
            UpdatePosition(CurrentFlightTime);
        }
        void UpdatePosition(double flightTime) {
            isLandedField = flightTime >= trajectoryField.FlightTime;
            GeoPoint point = trajectoryField.GetPointByCurrentFlightTime(flightTime);
            Latitude = point.Latitude;
            Longitude = point.Longitude;
            Course = trajectoryField.GetCourseByCurrentFlightTime(flightTime);
        }
        void UpdateIcon() {
            lock(MapElements.ImageLocker) {
                if(icon != null) {
                    icon.Dispose();
                    icon = null;
                }
                icon = DemoUtils.GetRotatedImage(sourceIcon, Course);
            }
        }
    }

    public class FlightMapDataGenerator : IDisposable {
        const double mSecPerHour = 3600000;
        const double SpeedScale = 100.0;

        PlaneInfo selectedPlane;
        DateTime lastTime;
        bool isDisposed;
        readonly List<PlaneInfo> planes = new List<PlaneInfo>();
        readonly List<InfoBase> airPaths = new List<InfoBase>();
        readonly Timer timer = new Timer();
        readonly Image sourcePlaneIcon;
        readonly PlaneInfoVisualizer visualizer;

        public List<PlaneInfo> Planes { get { return planes; } }
        public List<InfoBase> AirPaths { get { return airPaths; } }
        public PlaneInfo SelectedPlane {
            get { return selectedPlane; }
            set {
                if (selectedPlane == value)
                    return;
                selectedPlane = value;
                UpdatePlaneInfo(selectedPlane);
            }
        }

        public FlightMapDataGenerator(MapElementsOverlayManager overlayManager) {
            visualizer = new PlaneInfoVisualizer(overlayManager);
            sourcePlaneIcon = new Bitmap(DemoUtils.GetRelativePath("Images\\Plane.png"));
            LoadFromXML();
            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Interval = 2000;
        }
        ~FlightMapDataGenerator() {
            Dispose(false);
        }

        public event EventHandler DataChanged;

        void RaiseDataChanged() {
            if (DataChanged != null) DataChanged(this, EventArgs.Empty);
        }
        void LoadFromXML() {
            XDocument document = DemoUtils.LoadXml("FlightMap.xml");
            if (document != null) {
                foreach (XElement element in document.Element("Planes").Elements()) {
                    List<CoordPoint> points = new List<CoordPoint>();
                    foreach (XElement infoElement in element.Element("Path").Elements()) {
                        GeoPoint geoPoint = new GeoPoint(Convert.ToDouble(infoElement.Element("Latitude").Value, CultureInfo.InvariantCulture), Convert.ToDouble(infoElement.Element("Longitude").Value, CultureInfo.InvariantCulture));
                        points.Add(geoPoint);
                    }
                    PlaneInfo info = new PlaneInfo(element.Element("PlaneName").Value, element.Element("PlaneID").Value, element.Element("EndPointName").Value, element.Element("StartPointName").Value, Convert.ToInt32(element.Element("Speed").Value), Convert.ToInt32(element.Element("Altitude").Value), points, sourcePlaneIcon);
                    info.CurrentFlightTime = Convert.ToDouble(element.Element("CurrentFlightTime").Value, CultureInfo.InvariantCulture);
                    planes.Add(info);
                    airPaths.Add(info.Trajectory);
                    airPaths.Add(info.Trajectory.StartPoint);
                    airPaths.Add(info.Trajectory.EndPoint);
                }
            }
        }
        void UpdatePlaneInfo(PlaneInfo planeInfo) {
            visualizer.SelectedPlane = planeInfo;
        }
        void OnTimedEvent(object source, EventArgs e) {
            DateTime currentTime = DateTime.Now;
            TimeSpan interval = currentTime.Subtract(lastTime);
            foreach (PlaneInfo info in planes) {
                if (!info.IsLanded)
                    info.CurrentFlightTime += SpeedScale * interval.TotalMilliseconds / mSecPerHour;
            }
            lastTime = currentTime;
            visualizer.Update();
            RaiseDataChanged();
        }
        void Dispose(bool disposing) {
            if (disposing && !isDisposed) {
                isDisposed = true;
                Stop();
                if (timer != null)
                    timer.Dispose();
                if (sourcePlaneIcon != null)
                    sourcePlaneIcon.Dispose();
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Start() {
            lastTime = DateTime.Now;
            timer.Start();
        }
        public void Stop() {
            timer.Stop();
        }
        public List<InfoBase> FindAirPath(PlaneInfo plane) {
            return airPaths.FindAll(airPath => plane.Trajectory == airPath || plane.Trajectory.StartPoint == airPath || plane.Trajectory.EndPoint == airPath);
        }
    }

    public class PlaneInfoVisualizer {
        MapElementsOverlayManager overlayManager;
        PlaneInfo selectedPlane;


        public PlaneInfo SelectedPlane {
            get { return selectedPlane; }
            set {
                if(selectedPlane == value)
                    return;
                selectedPlane = value;
                Update();
            }
        }

        public PlaneInfoVisualizer(MapElementsOverlayManager overlayManager) {
            this.overlayManager = overlayManager;
        }

        public void Update() {
            if(selectedPlane == null) {
                overlayManager.SetOverlaysVisibility(false);
                return;
            }
            overlayManager.SetOverlaysVisibility(true);
            overlayManager.SetTextToItemByKey("name", selectedPlane.Name);
            overlayManager.SetTextToItemByKey("id", selectedPlane.PlaneID);
            overlayManager.SetTextToItemByKey("from", selectedPlane.StartPointName);
            overlayManager.SetTextToItemByKey("to", selectedPlane.EndPointName);
            overlayManager.SetTextToItemByKey("current_time", new TimeSpan(0, 0, (int)Math.Ceiling(selectedPlane.CurrentFlightTime * 3600)).ToString());
            overlayManager.SetTextToItemByKey("flight_time", new TimeSpan(0, 0, (int)Math.Ceiling(selectedPlane.TotalFlightTime * 3600)).ToString());
            overlayManager.SetTextToItemByKey("speed", selectedPlane.SpeedKmH.ToString());
            overlayManager.SetTextToItemByKey("altitude", selectedPlane.FlightAltitude.ToString());
            overlayManager.SetImage(selectedPlane.Image);
        }
    }

    public class FlightMapFactory : DefaultMapItemFactory {
        protected override void InitializeItem(MapItem item, object obj) {
            base.InitializeItem(item, obj);
            
            MapPolyline polyLine = item as MapPolyline;
            PlaneTrajectory trajectory = obj as PlaneTrajectory;
            if (polyLine != null && trajectory != null) {
                polyLine.IsGeodesic = true;
                polyLine.Points = trajectory.GetAirPath();
                polyLine.Fill = Color.Empty;
                polyLine.Stroke = Color.FromArgb(127, 255, 0, 199);
                polyLine.StrokeWidth = 4;
                trajectory.UpdateTrajectory(polyLine.ActualPoints.ToList());
            }
            MapCustomElement customElement = item as MapCustomElement;
            if(customElement != null) {
                customElement.UseAnimation = false;
                customElement.BackgroundDrawingMode = ElementState.None;
            }
        }
    }
}
