using DevExpress.Demos.DayAndNightLineCalculator;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraMap.Demos {
    public partial class DayAndNight : MapTutorialControl {
        const double DiscreteHoursStep = 0.5;
        const double SteadilyHoursStep = 24.5;

        bool isDataLoaded = false;

        MapCustomElement Sun { get { return (MapCustomElement)Data.Items[0]; } }
        MapCustomElement Moon { get { return (MapCustomElement)Data.Items[2]; } }
        MapPolygon DayAndNightLine { get { return (MapPolygon)Data.Items[1]; } }
        DateTime ActualDateTime {
            get { return barEditCalendar.EditValue != null ? (DateTime)barEditCalendar.EditValue : DateTime.UtcNow; }
            set { barEditCalendar.EditValue = value; }
        }

        public override MapControl MapControl { get { return mapControl1; } }

        public DayAndNight() {
            AutoMergeRibbon = true;
            InitializeComponent();
            listBoxControl1.SelectedIndex = 8;
            ShapefileDataAdapter.FileUri = new Uri("file:\\\\" + DemoUtils.GetRelativePath("Countries.shp"), UriKind.RelativeOrAbsolute);
            UpdateCurrentDayAndNightLine();
        }
        void UpdateCurrentDayAndNightLine() {
            DateTime dt = DateTime.UtcNow;
            ActualDateTime = dt;
            UpdateDayAndNightLine(dt);
        }
        void UpdateDayAndNightLine(DateTime dt) {
            double[] sun3DPosition = DayAndNightLineCalculator.CalculateSunPosition(dt);
            GeoPoint sunLocation = new GeoPoint(sun3DPosition[1], sun3DPosition[0]);
            GeoPoint moonLocation = GetOppositePoint(sunLocation);
            CoordPointCollection dayAndNightLineVertices = GetdayAndNightLineVertices(sunLocation, 0.1);
            bool isNorthNight = DayAndNightLineCalculator.CalculateIsNorthNight(sun3DPosition);
            if (isNorthNight)
                AddNorthContour(dayAndNightLineVertices);
            else
                AddSouthContour(dayAndNightLineVertices);
            Sun.Location = sunLocation;
            Moon.Location = moonLocation;
            DayAndNightLine.Points = dayAndNightLineVertices;
        }
        CoordPointCollection GetdayAndNightLineVertices(GeoPoint sunLocation, double step) {
            CoordPointCollection result = new CoordPointCollection();
            IList<double> latitudes = DayAndNightLineCalculator.GetDayAndNightLineLatitudes(sunLocation.Latitude, sunLocation.Longitude, step);
            double lon = -180;
            foreach (double lat in latitudes) {
                result.Add(new GeoPoint(lat, lon));
                lon += step;
            }
            return result;
        }
        GeoPoint GetOppositePoint(GeoPoint sunLocation) {
            double lat = -sunLocation.Latitude;
            double lon = sunLocation.Longitude + 180;
            if (lon > 180)
                lon -= 360;
            return new GeoPoint(lat, lon);
        }
        void AddNorthContour(CoordPointCollection dayAndNightLineVertices) {
            double initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[dayAndNightLineVertices.Count - 1]).Latitude);
            for (double latForward = initLat; latForward <= 90.0; latForward++)
                dayAndNightLineVertices.Add(new GeoPoint(latForward, 180));
            for (double lon = 180; lon >= -180; lon--)
                dayAndNightLineVertices.Add(new GeoPoint(90, lon));
            initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[0]).Latitude);
            for (double latBackward = 90; latBackward >= initLat; latBackward--)
                dayAndNightLineVertices.Add(new GeoPoint(latBackward, -180));
        }
        void AddSouthContour(CoordPointCollection dayAndNightLineVertices) {
            double initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[dayAndNightLineVertices.Count - 1]).Latitude);
            for (double lat = initLat; lat >= -90.0; lat --)
                dayAndNightLineVertices.Add(new GeoPoint(lat, 180));
            for (double lon = 180; lon >= -180; lon--)
                dayAndNightLineVertices.Add(new GeoPoint(-90, lon));
            initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[0]).Latitude);
            for (double lat = -90; lat <= initLat; lat++)
                dayAndNightLineVertices.Add(new GeoPoint(lat, -180));
        }
        void UpdateTimerEnabled(bool enabled) {
            this.timer.Enabled = enabled;
            this.chkSteadily.Checked = enabled;
        }

        bool IsDateOverFlow(DateTime currentDate, double stepHours) {
            long hoursTicks = (long)(stepHours * TimeSpan.TicksPerHour + currentDate.Ticks);
            return hoursTicks >= DateTime.MaxValue.Ticks | hoursTicks <= DateTime.MinValue.Ticks;
        }

        DateTime GetNextDateTime(DateTime dt) {
            double step = chkSteadily.Checked ? SteadilyHoursStep : DiscreteHoursStep;
            return IsDateOverFlow(dt, step) ? DateTime.MaxValue: dt.AddHours(step);
        }
        DateTime GetPreviousDateTime(DateTime dt) {
            return IsDateOverFlow(dt, -DiscreteHoursStep) ? DateTime.MinValue : dt.AddHours(-DiscreteHoursStep);
        }
        void timer_Tick(object sender, EventArgs e) {
            ActualDateTime = GetNextDateTime(ActualDateTime);
        }
        void DayAndNight_DataLoaded(object sender, DataLoadedEventArgs e) {
            isDataLoaded = true;
        }
        void barEditItem2_EditValueChanged(object sender, EventArgs e) {
            UpdateDayAndNightLine(ActualDateTime);
        }
        void btnCurrent_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            UpdateCurrentDayAndNightLine();
        }
        void chkSteadily_CheckedChanged(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(chkSteadily.Checked);
        }
        void btnPlus_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            ActualDateTime = GetNextDateTime(ActualDateTime);
        }
        void btnMinus_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            ActualDateTime = GetPreviousDateTime(ActualDateTime);
        }
        void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            var cs = (GeoMapCoordinateSystem)mapControl1.CoordinateSystem;
            switch (listBoxControl1.SelectedIndex) {
                case 0: cs.Projection = new SphericalMercatorProjection(); break;
                case 1: cs.Projection = new EqualAreaProjection(); break;
                case 2: cs.Projection = new EquirectangularProjection(); break;
                case 3: cs.Projection = new EllipticalMercatorProjection(); break;
                case 4: cs.Projection = new MillerProjection(); break;
                case 5: cs.Projection = new EquidistantProjection(); break;
                case 6: cs.Projection = new LambertCylindricalEqualAreaProjection(); break;
                case 7: cs.Projection = new BraunStereographicProjection(); break;
                case 8: cs.Projection = new KavrayskiyProjection(); break;
                case 9: cs.Projection = new SinusoidalProjection(); break;
                case 10: cs.Projection = new EPSG4326Projection(); break;
            }
            if (isDataLoaded)
                ZoomLayersToFit();
        }
        void ZoomLayersToFit() {
            MapControl.EnableZooming = true;
            MapControl.ZoomToFitLayerItems(0.3);
            MapControl.EnableZooming = false;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            DisableZoomOptions();
            ChkShowMinimap.Enabled = false;
            OptionsPage.Groups.AddRange(new RibbonPageGroup[] { rpgInteractivity, rpgDateTime });
            OptionsPage.Ribbon.Items.Add(barEditCalendar);
        }
        protected override void ChangeEnableNavigation(bool enable) {
            MapControl.EnableScrolling = enable;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint();
        }
        protected override void DoHide() {
            base.DoHide();
            UpdateTimerEnabled(false);
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateTimerEnabled(true);
        }
    }
}
