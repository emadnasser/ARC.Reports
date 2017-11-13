using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using System.Drawing;
using DevExpress.XtraCharts.Web;

namespace DevExpress.Web.Demos {
    public class ChartBar3DDemoOptions : Chart3DDemoOptions {
        bool showFacet = true;
        string bar3DModel = Bar3DModel.Box.ToString();
        byte transparency = 45;

        public bool ShowFacet {
            get { return showFacet; }
            set { showFacet = value; }
        }
        public string Bar3DModelString {
            get { return bar3DModel; }
            set {
                if (value == null)
                    bar3DModel = Bar3DModel.Box.ToString();
                else
                    bar3DModel = value;
            }
        }
        public byte Transparency {
            get { return transparency; }
            set { transparency = value; }
        }
    }

    public class ChartBarFullStacked3DDemoOptions : ChartBar3DDemoOptions {
        bool valueAsPercent = true;

        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartBarDemoOptions : ChartDemoOptions {
        string labelPosition = BarSeriesLabelPosition.Center.ToString();
        string textOrientation = TextOrientation.Horizontal.ToString();
        int labelIndent = 2;

        public string LabelPositionString {
            get { return labelPosition; }
            set {
                if (value == null)
                    labelPosition = BarSeriesLabelPosition.Center.ToString();
                else
                    labelPosition = value;
            }
        }
        public string TextOrientationString {
            get { return textOrientation; }
            set {
                if (value == null)
                    textOrientation = TextOrientation.Horizontal.ToString();
                else
                    textOrientation = value;
            }
        }
        public int LabelIndent {
            get { return labelIndent; }
            set { labelIndent = value; }
        }
    }

    public class ChartBarFullStackedDemoOptions : ChartBarDemoOptions {
        bool valueAsPercent = true;

        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartSideBySideBarDemoOptions : ChartBarFullStackedDemoOptions {
        GroupBy group = GroupBy.Sex;

        public GroupBy Group {
            get { return group; }
            set { group = value; }
        }
    }

    public class ChartSideBySideBar3DDemoOptions : ChartBarFullStacked3DDemoOptions {
        GroupBy group = GroupBy.Sex;

        public GroupBy Group {
            get { return group; }
            set { group = value; }
        }
    }

    public class ChartStepLineDemoOptions : ChartMarkerDemoOptions {
        bool inverted = false;

        public bool Inverted {
            get { return inverted; }
            set { inverted = value; }
        }
    }

    public class ChartStepLine3DDemoOptions : Chart3DDemoOptions {
        bool inverted = false;

        public bool Inverted {
            get { return inverted; }
            set { inverted = value; }
        }
    }

    public class ChartSplineDemoOptions : ChartMarkerDemoOptions{
        int tension = 75;

        public int Tension {
            get { return tension; }
            set { tension = value; }
        }
    }

    public class ChartDrillDownDemoOptions : ChartDemoOptions {

        Summary summaryFunction = Summary.Min;


        public Summary SummaryFunction {
            get { return summaryFunction; }
            set { summaryFunction = value; }
        }

        public ChartDrillDownDemoOptions() {
        }
    }

    public class ChartToolTipDemoOptions : ChartDemoOptions {
        ToolTipOpenMode openMode = ToolTipOpenMode.OnHover;
        Dictionary<string, int> toolTipImages = new Dictionary<string, int>();
        ToolTipPositions position = ToolTipPositions.Mouse;

        public ToolTipOpenMode OpenMode {
            get { return openMode; }
            set { openMode = value; }
        }
        public Dictionary<string, int> ToolTipImages {
            get { return toolTipImages; }
            set { toolTipImages = value; }
        }
        public ToolTipPositions Position {
            get { return position; }
            set { position = value; }
        }
    }

    public class ChartRangeDemoOptions : ChartMarkerDemoOptions {
        RangeAreaLabelKind labelKinds = RangeAreaLabelKind.TwoLabels;
        bool showMarkers2 = true;
        string marker2Kind = MarkerKind.Circle.ToString();
        int marker2Size = 8;
        int starPoint2Count = 3;

        public string Marker2KindString {
            get { return marker2Kind; }
            set {
                if (value == null)
                    marker2Kind = MarkerKind.Circle.ToString();
                else if (value.Contains(ChartDemoHelper.StarKey)) {
                    starPoint2Count = Int32.Parse(value.Remove(0, ChartDemoHelper.StarKey.Length));
                    marker2Kind = MarkerKind.Star.ToString();
                }
                else
                    marker2Kind = value;
            }
        }
        public bool ShowMarkers2 {
            get { return showMarkers2; }
            set { showMarkers2 = value; }
        }
        public int StarPoint2Count { get { return starPoint2Count; } }
        public int Marker2Size {
            get { return marker2Size; }
            set { marker2Size = value; }
        }
        public RangeAreaLabelKind LabelKind {
            get { return labelKinds; }
            set { labelKinds = value; }
        }
    }

    public class ChartRange3DDemoOptions : Chart3DDemoOptions {
        RangeAreaLabelKind labelKinds = RangeAreaLabelKind.TwoLabels;

        public RangeAreaLabelKind LabelKind {
            get { return labelKinds; }
            set { labelKinds = value; }
        }
    }

    public class ChartPieDoughnutDemoOptions : ChartNestedDoughnutDemoOptions {
        static List<string> listExplodeModes = new List<string>(){
            PieExplodeMode.None.ToString(),
            PieExplodeMode.All.ToString(),
            PieExplodeMode.MinValue.ToString(),
            PieExplodeMode.MaxValue.ToString()
        };
        int holeRadiusPercentDoughnut = 60;
        string explodedPoints = PieExplodeMode.None.ToString();
        string explodePoint;
        PieExplodeMode explodeMode = PieExplodeMode.None;
        PieSeriesLabelPosition labelPosition = PieSeriesLabelPosition.Radial;
        int eplodeDistance = 1;
        bool valueAsPercent = true;

        public PieSeriesLabelPosition LabelPosition {
            get { return labelPosition; }
            set { labelPosition = value; }
        }
        public string ExplodedPoints {
            get { return explodedPoints; }
            set {
                explodedPoints = value;
                if (listExplodeModes.Contains(value)) {
                    explodePoint = null;
                    explodeMode = (PieExplodeMode)Enum.Parse(typeof(PieExplodeMode), value);
                }
                else
                    explodePoint = value;
            }
        }
        public int EplodeDistance {
            get { return eplodeDistance; }
            set { eplodeDistance = value; }
        }
        public string ExplodePoint { get { return explodePoint; } }
        public PieExplodeMode ExplodeMode { get { return explodeMode; } }
        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
        public int HoleRadiusPercentDoughnut {
            get { return holeRadiusPercentDoughnut; }
            set { holeRadiusPercentDoughnut = value; }
        }

        public ChartPieDoughnutDemoOptions() {
            View = DevExpress.XtraCharts.ViewType.Pie;
        }
    }

    public class ChartNestedDoughnutDemoOptions : ChartDemoOptions {
        bool showAgeStruct = true;
        int holeRadiusPercent = 40;
        double innerIndent = 5;

        public bool ShowAgeStruct {
            get { return showAgeStruct; }
            set { showAgeStruct = value; }
        }
        public int HoleRadiusPercent {
            get { return holeRadiusPercent; }
            set { holeRadiusPercent = value; }
        }
        public double InnerIndent {
            get { return innerIndent; }
            set { innerIndent = value; }
        }

        public ChartNestedDoughnutDemoOptions() {
            View = DevExpress.XtraCharts.ViewType.NestedDoughnut;
        }
    }

    public class ChartBubbleDemoOptions : ChartMarkerDemoOptions {
        decimal minBubbleSize = 1.0M;
        decimal maxBubbleSize = 3.5M;
        byte transparency = 90;

        protected override PointLabelPosition DefaultLabelPosition { get { return PointLabelPosition.Center; } }

        public decimal MinBubbleSize {
            get { return minBubbleSize; }
            set {
                if (value < maxBubbleSize)
                    minBubbleSize = value;
            }
        }
        public decimal MaxBubbleSize {
            get { return maxBubbleSize; }
            set {
                if (value > minBubbleSize)
                    maxBubbleSize = value;
            }
        }
        public byte Transparency {
            get { return transparency; }
            set { transparency = value; }
        }
    }

    public class ChartScatterDemoOptions : ChartMarkerDemoOptions {
        ScatterFunctions function = ScatterFunctions.ArchimedeanSpiral;

        public ScatterFunctions Function {
            get { return function; }
            set { function = value; }
        }
    }

    public class ChartAreaDemoOptions : ChartMarkerDemoOptions {
        byte transparency = 135;

        public byte Transparency {
            get { return transparency; }
            set { transparency = value; }
        }
    }

    public class ChartAreaFullStckedDemoOptions : ChartAreaDemoOptions {
        bool valueAsPercent;

        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartStepAreaFullStckedDemoOptions : ChartAreaFullStckedDemoOptions {
        bool inverted = false;

        public bool Inverted {
            get { return inverted; }
            set { inverted = value; }
        }
    }

    public class ChartArea3DDemoOptions : Chart3DDemoOptions {
        byte transparency = 135;

        public byte Transparency {
            get { return transparency; }
            set { transparency = value; }
        }
    }

    public class ChartAreaFullStcked3DDemoOptions : ChartArea3DDemoOptions {
        bool valueAsPercent = true;

        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartStepAreaDemoOptions : ChartAreaDemoOptions  {
        bool inverted = false;

        public bool Inverted {
            get { return inverted; }
            set { inverted = value; }
        }
    }

    public class ChartStepArea3DDemoOptions : ChartArea3DDemoOptions {
        bool inverted = false;

        public bool Inverted {
            get { return inverted; }
            set { inverted = value; }
        }
    }

    public class ChartLineFullStckedDemoOptions : ChartMarkerDemoOptions{
        bool valueAsPercent = true;

        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartFunnelDemoOptions : ChartDemoOptions {
        FunnelSeriesLabelPosition labelPosition = FunnelSeriesLabelPosition.Right;
        int distance = 1;
        double heightToWidthRatio = 1;
        bool valueAsPercent = true;
        
        public FunnelSeriesLabelPosition LabelPosition {
            get { return labelPosition; }
            set { labelPosition = value; }
        }
        public int Distance {
            get { return distance; }
            set { distance = value; }
        }
        public double HeightToWidthRatio {
            get { return heightToWidthRatio; }
            set { heightToWidthRatio = value; }
        }
        public ChartFunnelDemoOptions() {
            View = DevExpress.XtraCharts.ViewType.Funnel;
        }
        public bool ValueAsPercent {
            get { return valueAsPercent; }
            set { valueAsPercent = value; }
        }
    }

    public class ChartFunnel2DDemoOptions : ChartFunnelDemoOptions {
        bool alignToCenter = false;
        bool heightToWidthRatioAuto = false;
        
        public bool AlignToCenter {
            get { return alignToCenter; }
            set { alignToCenter = value; }
        }
        public bool HeightToWidthRatioAuto {
            get { return heightToWidthRatioAuto; }
            set { heightToWidthRatioAuto = value; }
        }
    }

    public class ChartFunnel3DDemoOptions : ChartFunnelDemoOptions {
        int holeRadius = 90;

        public int HoleRadius {
            get { return holeRadius; }
            set { holeRadius = value; }
        }
    }

    public class ChartRadarDemoOptions : ChartMarkerDemoOptions {
        RadarDiagramDrawingStyle diagramStyle = RadarDiagramDrawingStyle.Circle;
        PolarFunctions polarFunction = PolarFunctions.Circles;
        RadarAxisXLabelTextDirection textDirection = RadarAxisXLabelTextDirection.Radial;
        ScatterRadarFunctions scatterFunction = ScatterRadarFunctions.ArchimedeanSpiral;

        public PolarFunctions PolarFunction {
            get { return polarFunction; }
            set { polarFunction = value; }
        }
        public RadarDiagramDrawingStyle DiagramStyle {
            get { return diagramStyle; }
            set { diagramStyle = value; }
        }
        public RadarAxisXLabelTextDirection TextDirection {
            get { return textDirection; }
            set { textDirection = value; }
        }
        public ScatterRadarFunctions ScatterFunction {
            get { return scatterFunction; }
            set { scatterFunction = value; }
        }

        public ChartRadarDemoOptions() {
            View = DevExpress.XtraCharts.ViewType.RadarPoint;
            MarkerSize = 8;
        }
    }

    public class ChartRadarRangeDemoOptions : ChartRadarDemoOptions {
        RangeAreaLabelKind labelKinds = RangeAreaLabelKind.TwoLabels;
        bool showMarkers2 = true;
        string marker2Kind = MarkerKind.Circle.ToString();
        int marker2Size = 8;
        int starPoint2Count = 3;

        public string Marker2KindString {
            get { return marker2Kind; }
            set {
                if (value == null)
                    marker2Kind = MarkerKind.Circle.ToString();
                else if (value.Contains(ChartDemoHelper.StarKey)) {
                    starPoint2Count = Int32.Parse(value.Remove(0, ChartDemoHelper.StarKey.Length));
                    marker2Kind = MarkerKind.Star.ToString();
                }
                else
                    marker2Kind = value;
            }
        }
        public bool ShowMarkers2 {
            get { return showMarkers2; }
            set { showMarkers2 = value; }
        }
        public int StarPoint2Count { get { return starPoint2Count; } }
        public int Marker2Size {
            get { return marker2Size; }
            set { marker2Size = value; }
        }
        public RangeAreaLabelKind LabelKind {
            get { return labelKinds; }
            set { labelKinds = value; }
        }
    }

    public class ChartFinacialDemoOptions : ChartDemoOptions {
        bool workDaysOnly = true;
        StockLevel reductionLevel = StockLevel.Close;
        StockLevel labelLevel = StockLevel.Close;

        public bool WorkDaysOnly {
            get { return workDaysOnly; }
            set { workDaysOnly = value; }
        }
        public StockLevel ReductionLevel {
            get { return reductionLevel; }
            set { reductionLevel = value; }
        }
        public StockLevel LabelLevel {
            get { return labelLevel; }
            set { labelLevel = value; }
        }

        public ChartFinacialDemoOptions() {
            View = DevExpress.XtraCharts.ViewType.Stock;
        }
    }

    public class Chart3DDemoOptions : ChartDemoOptions {
        int perspectiveAngle = 45;
        int zoomPercent = 140;

        public int PerspectiveAngle {
            get { return perspectiveAngle; }
            set { perspectiveAngle = value; }
        }
        public int ZoomPercent {
            get { return zoomPercent; }
            set { zoomPercent = value; }
        }
    }

    public class ChartMarkerDemoOptions : ChartDemoOptions {
        int markerSize = 10;
        string markerKind = MarkerKind.Circle.ToString();
        PointLabelPosition labelPosition;
        int starPointCount = 3;
        bool showMarkers = true;
        int labelAngle = 45;

        protected virtual PointLabelPosition DefaultLabelPosition { get { return PointLabelPosition.Outside; } }

        public string MarkerKindString {
            get { return markerKind; }
            set {
                if (value == null)
                    markerKind = MarkerKind.Circle.ToString();
                else if (value.Contains(ChartDemoHelper.StarKey)) {
                    starPointCount = Int32.Parse(value.Remove(0, ChartDemoHelper.StarKey.Length));
                    markerKind = MarkerKind.Star.ToString();
                }
                else
                    markerKind = value;
            }
        }
        public PointLabelPosition LabelPosition {
            get { return labelPosition; }
            set { labelPosition = value; }
        }
        public int StarPointCount { get { return starPointCount; } }
        public int MarkerSize {
            get { return markerSize; }
            set { markerSize = value; }
        }
        public bool ShowMarkers {
            get { return showMarkers; }
            set { showMarkers = value; }
        }
        public int LabelAngle {
            get { return labelAngle; }
            set { labelAngle = value; }
        }
        public ChartMarkerDemoOptions() {
            this.labelPosition = DefaultLabelPosition;
        }
    }

    public class ChartDemoOptions {
        DevExpress.XtraCharts.ViewType view;   
        bool showLabels;

        public bool ShowLabels {
            get { return showLabels; }
            set { showLabels = value; }
        }
        public DevExpress.XtraCharts.ViewType View {
            get { return view; }
            set { view = value; }
        }
   
        public ChartDemoOptions() {
        }
    }

    public enum GroupBy{
        Sex,
        Age
    }
    public enum ScatterFunctions {
        ArchimedeanSpiral,
        Cardioid,
        CartesianFolium
    }
    public enum PolarFunctions {
        Circles,
        Cardioid,
        Lemniscate
    }
    public enum ScatterRadarFunctions {
        ArchimedeanSpiral,
        PolarRose,
        PolarFolium
    }
    public enum ToolTipPositions {
        Relative,
        Free,
        Mouse
    }
    public enum Summary {
        Min,
        Max,
        Average
    }
}

