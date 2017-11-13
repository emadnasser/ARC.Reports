using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web;
using DevExpress.XtraCharts.Web;
using DevExpress.XtraCharts;

namespace DevExpress.Web.Demos {
    public static class ChartDemoHelper {
        public const string OptionsKey = "Options";
        public const string CategoryKey = "Category";
        public const string StarKey = "star:";
        public const string CompletedDateKey = "CompletedDate";
        public const string ModelKey = "Model";

        public static bool IsSideBySideStackedView(DevExpress.XtraCharts.ViewType view) {
            return view == DevExpress.XtraCharts.ViewType.SideBySideStackedBar
                || view == DevExpress.XtraCharts.ViewType.SideBySideStackedBar3D
                || view == DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar
                || view == DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar3D;
        }
        public static bool IsPolarView(DevExpress.XtraCharts.ViewType view) {
            return view == DevExpress.XtraCharts.ViewType.PolarPoint
                || view == DevExpress.XtraCharts.ViewType.PolarLine
                || view == DevExpress.XtraCharts.ViewType.PolarArea
                || view == DevExpress.XtraCharts.ViewType.PolarRangeArea;
        }
        public static bool IsPolarScatterView(DevExpress.XtraCharts.ViewType view) {
            return view == DevExpress.XtraCharts.ViewType.ScatterPolarLine
                || view == DevExpress.XtraCharts.ViewType.ScatterRadarLine;
        }
        public static List<SelectListItem> GetBarViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Bar", Value = DevExpress.XtraCharts.ViewType.Bar.ToString() },
                new SelectListItem() { Text = "Stacked Bar", Value = DevExpress.XtraCharts.ViewType.StackedBar.ToString() },
                new SelectListItem() { Text = "Full-Stacked Bar", Value = DevExpress.XtraCharts.ViewType.FullStackedBar.ToString() },
                new SelectListItem() { Text = "Side-by-Side Stacked Bar", Value = DevExpress.XtraCharts.ViewType.SideBySideStackedBar.ToString() },
                new SelectListItem() { Text = "Side-by-Side Full-Stacked Bar", Value = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar.ToString() },
                new SelectListItem() { Text = "3D Bar", Value = DevExpress.XtraCharts.ViewType.Bar3D.ToString() },
                new SelectListItem() { Text = "3D Manhattan Bar", Value = DevExpress.XtraCharts.ViewType.ManhattanBar.ToString() },
                new SelectListItem() { Text = "3D Stacked Bar", Value = DevExpress.XtraCharts.ViewType.StackedBar3D.ToString() },
                new SelectListItem() { Text = "3D Full-Stacked Bar", Value = DevExpress.XtraCharts.ViewType.FullStackedBar3D.ToString() },
                new SelectListItem() { Text = "3D Side-by-Side Stacked Bar", Value = DevExpress.XtraCharts.ViewType.SideBySideStackedBar3D.ToString() },
                new SelectListItem() { Text = "3D Side-by-Side Full-Stacked Bar", Value = DevExpress.XtraCharts.ViewType.SideBySideFullStackedBar3D.ToString() }
            };
        }
        public static List<SelectListItem> GetPointLineViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Point", Value = DevExpress.XtraCharts.ViewType.Point.ToString() },
                new SelectListItem() { Text = "Bubble", Value = DevExpress.XtraCharts.ViewType.Bubble.ToString() },
                new SelectListItem() { Text = "Line", Value = DevExpress.XtraCharts.ViewType.Line.ToString() },
                new SelectListItem() { Text = "Scatter Line", Value = DevExpress.XtraCharts.ViewType.ScatterLine.ToString() },
                new SelectListItem() { Text = "Step Line", Value = DevExpress.XtraCharts.ViewType.StepLine.ToString() },
                new SelectListItem() { Text = "Stacked Line", Value = DevExpress.XtraCharts.ViewType.StackedLine.ToString() },
                new SelectListItem() { Text = "Full-Stacked Line", Value = DevExpress.XtraCharts.ViewType.FullStackedLine.ToString() },
                new SelectListItem() { Text = "Spline", Value = DevExpress.XtraCharts.ViewType.Spline.ToString() },
                new SelectListItem() { Text = "3D Line", Value = DevExpress.XtraCharts.ViewType.Line3D.ToString() },
                new SelectListItem() { Text = "3D Step Line", Value = DevExpress.XtraCharts.ViewType.StepLine3D.ToString() },
                new SelectListItem() { Text = "3D Stacked Line", Value = DevExpress.XtraCharts.ViewType.StackedLine3D.ToString() },
                new SelectListItem() { Text = "3D Full-Stacked Line", Value = DevExpress.XtraCharts.ViewType.FullStackedLine3D.ToString() },
                new SelectListItem() { Text = "3D Spline", Value = DevExpress.XtraCharts.ViewType.Spline3D.ToString() }
            };
        }
        public static List<SelectListItem> GetAreaViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Area", Value = DevExpress.XtraCharts.ViewType.Area.ToString() },
                new SelectListItem() { Text = "Stacked Area", Value = DevExpress.XtraCharts.ViewType.StackedArea.ToString() },
                new SelectListItem() { Text = "Full-Stacked Area", Value = DevExpress.XtraCharts.ViewType.FullStackedArea.ToString() },
                new SelectListItem() { Text = "Full-Stacked Step Area", Value = DevExpress.XtraCharts.ViewType.FullStackedStepArea.ToString() },
                new SelectListItem() { Text = "Spline Area", Value = DevExpress.XtraCharts.ViewType.SplineArea.ToString() },
                new SelectListItem() { Text = "Stacked Spline Area", Value = DevExpress.XtraCharts.ViewType.StackedSplineArea.ToString() },
                new SelectListItem() { Text = "Full-Stacked Spline Area", Value = DevExpress.XtraCharts.ViewType.FullStackedSplineArea.ToString() },
                new SelectListItem() { Text = "Step Area", Value = DevExpress.XtraCharts.ViewType.StepArea.ToString() },
                new SelectListItem() { Text = "3D Area", Value = DevExpress.XtraCharts.ViewType.Area3D.ToString() },
                new SelectListItem() { Text = "3D Stacked Area", Value = DevExpress.XtraCharts.ViewType.StackedArea3D.ToString() },
                new SelectListItem() { Text = "3D Full-Stacked Area", Value = DevExpress.XtraCharts.ViewType.FullStackedArea3D.ToString() },
                new SelectListItem() { Text = "3D Spline Area", Value = DevExpress.XtraCharts.ViewType.SplineArea3D.ToString() },
                new SelectListItem() { Text = "3D Stacked Spline Area", Value = DevExpress.XtraCharts.ViewType.StackedSplineArea3D.ToString() },
                new SelectListItem() { Text = "3D Full-Stacked Spline Area", Value = DevExpress.XtraCharts.ViewType.FullStackedSplineArea3D.ToString() },
                new SelectListItem() { Text = "3D Step Area", Value = DevExpress.XtraCharts.ViewType.StepArea3D.ToString() },
            };
        }
        public static List<SelectListItem> GetPieViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Pie", Value = DevExpress.XtraCharts.ViewType.Pie.ToString() },
                new SelectListItem() { Text = "Doughnut", Value = DevExpress.XtraCharts.ViewType.Doughnut.ToString() },
                new SelectListItem() { Text = "3D Pie", Value = DevExpress.XtraCharts.ViewType.Pie3D.ToString() },
                new SelectListItem() { Text = "3D Doughnut", Value = DevExpress.XtraCharts.ViewType.Doughnut3D.ToString() },
            };
        }
        public static List<SelectListItem> GetPointLabelPositions(bool isOutsideByDefault) {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Center", Value = PointLabelPosition.Center.ToString(), Selected = !isOutsideByDefault },
                new SelectListItem() { Text = "Outside", Value = PointLabelPosition.Outside.ToString(), Selected = isOutsideByDefault },
            };
        }
        public static List<SelectListItem> GetPieLabelPositions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Radial", Value = PieSeriesLabelPosition.Radial.ToString() },
                new SelectListItem() { Text = "Inside", Value = PieSeriesLabelPosition.Inside.ToString() },
                new SelectListItem() { Text = "Outside", Value = PieSeriesLabelPosition.Outside.ToString() },
                new SelectListItem() { Text = "Two Columns", Value = PieSeriesLabelPosition.TwoColumns.ToString() },
            };
        }
        public static List<SelectListItem> GetPieExplodePoints() {
            List<SelectListItem> explodePoints = new List<SelectListItem>() {
                new SelectListItem() { Text = "None", Value = PieExplodeMode.None.ToString() },
                new SelectListItem() { Text = "All", Value = PieExplodeMode.All.ToString() },
                new SelectListItem() { Text = "Min Value", Value = PieExplodeMode.MinValue.ToString() },
                new SelectListItem() { Text = "Max Value", Value = PieExplodeMode.MaxValue.ToString() },
            };
            foreach(Country country in CountriesProvider.GetCountries())
                explodePoints.Add(new SelectListItem() { Text = country.Name, Value = country.Name });
            return explodePoints;
        }
        public static List<SelectListItem> GetFunnelViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Funnel", Value = DevExpress.XtraCharts.ViewType.Funnel.ToString() },
                new SelectListItem() { Text = "3D Funnel", Value = DevExpress.XtraCharts.ViewType.Funnel3D.ToString() },
            };
        }
        public static List<SelectListItem> GetFunnelLabelPositions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Right", Value = FunnelSeriesLabelPosition.Right.ToString() },
                new SelectListItem() { Text = "Left", Value = FunnelSeriesLabelPosition.Left.ToString() },
                new SelectListItem() { Text = "Center", Value = FunnelSeriesLabelPosition.Center.ToString() },
                new SelectListItem() { Text = "Right Column", Value = FunnelSeriesLabelPosition.RightColumn.ToString() },
                new SelectListItem() { Text = "Left Column", Value = FunnelSeriesLabelPosition.LeftColumn.ToString() },
            };
        }
        public static List<SelectListItem> GetRadarPolarViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Radar Point", Value = DevExpress.XtraCharts.ViewType.RadarPoint.ToString() },
                new SelectListItem() { Text = "Radar Line", Value = DevExpress.XtraCharts.ViewType.RadarLine.ToString() },
                new SelectListItem() { Text = "Radar Area", Value = DevExpress.XtraCharts.ViewType.RadarArea.ToString() },
                new SelectListItem() { Text = "Scatter Radar Line", Value = DevExpress.XtraCharts.ViewType.ScatterRadarLine.ToString() },
                new SelectListItem() { Text = "Polar Point", Value = DevExpress.XtraCharts.ViewType.PolarPoint.ToString() },
                new SelectListItem() { Text = "Polar Line", Value = DevExpress.XtraCharts.ViewType.PolarLine.ToString() },
                new SelectListItem() { Text = "Polar Area", Value = DevExpress.XtraCharts.ViewType.PolarArea.ToString() },
                new SelectListItem() { Text = "Scatter Polar Line", Value = DevExpress.XtraCharts.ViewType.ScatterPolarLine.ToString() }
            };
        }
        public static List<SelectListItem> GetMarkerKinds() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Circle", Value = DevExpress.XtraCharts.MarkerKind.Circle.ToString() },
                new SelectListItem() { Text = "Cross", Value = DevExpress.XtraCharts.MarkerKind.Cross.ToString() },
                new SelectListItem() { Text = "Diamond", Value = DevExpress.XtraCharts.MarkerKind.Diamond.ToString() },
                new SelectListItem() { Text = "Hexagon", Value = DevExpress.XtraCharts.MarkerKind.Hexagon.ToString() },
                new SelectListItem() { Text = "Inverted Triangle", Value = DevExpress.XtraCharts.MarkerKind.InvertedTriangle.ToString() },
                new SelectListItem() { Text = "Pentagon", Value = DevExpress.XtraCharts.MarkerKind.Pentagon.ToString() },
                new SelectListItem() { Text = "Plus", Value = DevExpress.XtraCharts.MarkerKind.Plus.ToString() },
                new SelectListItem() { Text = "Square", Value = DevExpress.XtraCharts.MarkerKind.Square.ToString() },
                new SelectListItem() { Text = "Triangle", Value = DevExpress.XtraCharts.MarkerKind.Triangle.ToString() },
                new SelectListItem() { Text = "Star 3-points", Value = StarKey + "3" },
                new SelectListItem() { Text = "Star 4-points", Value = StarKey + "4" },
                new SelectListItem() { Text = "Star 5-points", Value = StarKey + "5" },
                new SelectListItem() { Text = "Star 6-points", Value = StarKey + "6" },
                new SelectListItem() { Text = "Star 10-points", Value = StarKey + "10" }
            };
        }
        public static List<SelectListItem> GetMarkerKindsForStepLine() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Circle", Value = DevExpress.XtraCharts.MarkerKind.Circle.ToString() },
                new SelectListItem() { Text = "Cross", Value = DevExpress.XtraCharts.MarkerKind.Cross.ToString() },
                new SelectListItem() { Text = "Diamond", Value = DevExpress.XtraCharts.MarkerKind.Diamond.ToString() },
                new SelectListItem() { Text = "Hexagon", Value = DevExpress.XtraCharts.MarkerKind.Hexagon.ToString() },
                new SelectListItem() { Text = "Inverted Triangle", Value = DevExpress.XtraCharts.MarkerKind.InvertedTriangle.ToString() },
                new SelectListItem() { Text = "Pentagon", Value = DevExpress.XtraCharts.MarkerKind.Pentagon.ToString() },
                new SelectListItem() { Text = "Plus", Value = DevExpress.XtraCharts.MarkerKind.Plus.ToString() },
                new SelectListItem() { Text = "Square", Value = DevExpress.XtraCharts.MarkerKind.Square.ToString(), Selected = true },
                new SelectListItem() { Text = "Triangle", Value = DevExpress.XtraCharts.MarkerKind.Triangle.ToString() },
                new SelectListItem() { Text = "Star 3-points", Value = StarKey + "3" },
                new SelectListItem() { Text = "Star 4-points", Value = StarKey + "4" },
                new SelectListItem() { Text = "Star 5-points", Value = StarKey + "5" },
                new SelectListItem() { Text = "Star 6-points", Value = StarKey + "6" },
                new SelectListItem() { Text = "Star 10-points", Value = StarKey + "10" }
            };
        }
        public static List<SelectListItem> GetBarLabelPositions(bool isStacked) {
             List<SelectListItem> barLabelPositions = new List<SelectListItem>() {
                new SelectListItem() { Text = "Top Inside", Value = BarSeriesLabelPosition.TopInside.ToString() },
                new SelectListItem() { Text = "Center", Value = BarSeriesLabelPosition.Center.ToString(), Selected = true },
                new SelectListItem() { Text = "Bottom Inside", Value = BarSeriesLabelPosition.BottomInside.ToString() },
            };
             if (!isStacked)
                 barLabelPositions.Insert(0, new SelectListItem() { Text = "Top", Value = BarSeriesLabelPosition.Top.ToString() });
             return barLabelPositions;
        }
            
        public static List<SelectListItem> GetTextOrientations() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Horizontal", Value = TextOrientation.Horizontal.ToString() },
                new SelectListItem() { Text = "TopToBottom", Value = TextOrientation.TopToBottom.ToString() },
                new SelectListItem() { Text = "BottomToTop", Value = TextOrientation.BottomToTop.ToString() },
            };
        }
        public static List<SelectListItem> GetRangeViews() {
            return new List<SelectListItem>(){
                new SelectListItem() { Text = "Range Bar", Value = DevExpress.XtraCharts.ViewType.RangeBar.ToString() },
                new SelectListItem() { Text = "Side-by-Side Range Bar", Value = DevExpress.XtraCharts.ViewType.SideBySideRangeBar.ToString() },
                new SelectListItem() { Text = "Range Area", Value = DevExpress.XtraCharts.ViewType.RangeArea.ToString() },
                new SelectListItem() { Text = "3D Range Area", Value = DevExpress.XtraCharts.ViewType.RangeArea3D.ToString() },
            };
        }
        public static List<SelectListItem> GetGanttViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Gantt", Value = DevExpress.XtraCharts.ViewType.Gantt.ToString() },
                new SelectListItem() { Text = "Side-by-Side Gantt", Value = DevExpress.XtraCharts.ViewType.SideBySideGantt.ToString() }
            };
        }
        public static List<SelectListItem> GetFinancialViews() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Stock", Value = DevExpress.XtraCharts.ViewType.Stock.ToString() },
                new SelectListItem() { Text = "Candle Stick", Value = DevExpress.XtraCharts.ViewType.CandleStick.ToString() }
            };
        }
        public static List<SelectListItem> GetFinancialLabelLevels() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Close", Value = StockLevel.Close.ToString() },
                new SelectListItem() { Text = "High", Value = StockLevel.High.ToString() },
                new SelectListItem() { Text = "Low", Value = StockLevel.Low.ToString() },
                new SelectListItem() { Text = "Open", Value = StockLevel.Open.ToString() }
            };
        }
        public static List<SelectListItem> GetSortValues() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Products", Value = SeriesPointKey.Argument.ToString() },
                new SelectListItem() { Text = "Price", Value = SeriesPointKey.Value_1.ToString(), Selected = true }
            };
        }
        public static List<SelectListItem> GetSeriesDataMembers() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = ChartSeriesTemplateBindingDemoOptions.Year, Value = ChartSeriesTemplateBindingDemoOptions.Year, Selected = true },
                new SelectListItem() { Text = ChartSeriesTemplateBindingDemoOptions.Country, Value = ChartSeriesTemplateBindingDemoOptions.Country }
            };
        }
        public static List<SelectListItem> GetRadarDiagramTypes() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Circle", Value = RadarDiagramDrawingStyle.Circle.ToString(), Selected = true },
                new SelectListItem() { Text = "Polygon", Value = RadarDiagramDrawingStyle.Polygon.ToString() }
            };
        }
        public static List<SelectListItem> GetAgeStructureModes() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Age", Value = "true", Selected = true },
                new SelectListItem() { Text = "Sex", Value = "false" }
            };
        }
        public static List<SelectListItem> GetTransparency(string defaultValue) {
            string[] transparency = new string[] { "0", "45", "90", "135", "180", "225", "255"};
            List<SelectListItem> listTransparency = new List<SelectListItem>();
            for (int i = 0; i < transparency.Length; i++) {
                SelectListItem selectedItem = new SelectListItem() { Text = transparency[i], Value = transparency[i]};
                if (transparency[i] == defaultValue)
                    selectedItem.Selected = true;
                listTransparency.Add(selectedItem);
            }
            return listTransparency;
        }
        public static List<SelectListItem> GetPerspectiveAngle() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "0", Value = "0"},
                new SelectListItem() { Text = "30", Value = "30"},
                new SelectListItem() { Text = "45", Value = "45", Selected = true},
                new SelectListItem() { Text = "60", Value = "60"},
                new SelectListItem() { Text = "90", Value = "90"},
                new SelectListItem() { Text = "120", Value = "120"},
                new SelectListItem() { Text = "135", Value = "135"},
                new SelectListItem() { Text = "150", Value = "150"}
            };
        }
        public static List<SelectListItem> GetLabelAngle(string defaultValue) {
            string[] labelAngles = new string[] { "0", "45", "90", "135", "180", "225", "270", "315"};
            List<SelectListItem> listLabelAngles = new List<SelectListItem>();
            for (int i = 0; i < labelAngles.Length; i++) {
                SelectListItem selectedItem = new SelectListItem() { Text = labelAngles[i], Value = labelAngles[i] };
                if (labelAngles[i] == defaultValue)
                    selectedItem.Selected = true;
                listLabelAngles.Add(selectedItem);
            }
            return listLabelAngles;
        }
        public static List<SelectListItem> GetGroupByValues() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Sex", Value = GroupBy.Sex.ToString(), Selected = true},
                new SelectListItem() { Text = "Age", Value = GroupBy.Age.ToString()}
            };
        }
        public static List<SelectListItem> GetTextDirections(RadarAxisXLabelTextDirection defaultValue) {
            List<SelectListItem> listTextDirections = new List<SelectListItem>();
            for (int i = 0; i < Enum.GetNames(typeof(RadarAxisXLabelTextDirection)).Length; i++)
            {
                SelectListItem selectListItem = new SelectListItem() { Text = Enum.GetName(typeof(RadarAxisXLabelTextDirection), i), Value = Enum.GetName(typeof(RadarAxisXLabelTextDirection), i) };
                if (Enum.GetName(typeof(RadarAxisXLabelTextDirection), i) == defaultValue.ToString())
                    selectListItem.Selected = true;
                listTextDirections.Add(selectListItem);
            }
            return listTextDirections;
        }
        public static List<SelectListItem> GetTextDirections() {
            return GetTextDirections(RadarAxisXLabelTextDirection.Radial);
        }
        public static List<SelectListItem> GetSummary() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Min", Value = Summary.Min.ToString(), Selected = true},
                new SelectListItem() { Text = "Max", Value = Summary.Max.ToString()},
                new SelectListItem() { Text = "Average", Value = Summary.Average.ToString()}
            };
        }
        public static List<SelectListItem> GetLabelKinds() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "One Label", Value = RangeAreaLabelKind.OneLabel.ToString()},
                new SelectListItem() { Text = "Two Label", Value = RangeAreaLabelKind.TwoLabels.ToString(), Selected = true},
                new SelectListItem() { Text = "Min Value", Value = RangeAreaLabelKind.MinValueLabel.ToString()},
                new SelectListItem() { Text = "Max Value", Value = RangeAreaLabelKind.MaxValueLabel.ToString()},
                new SelectListItem() { Text = "Value 1 Label", Value = RangeAreaLabelKind.MinValueLabel.ToString()},
                new SelectListItem() { Text = "Value 2 Label", Value = RangeAreaLabelKind.MinValueLabel.ToString()},
            };
        }
        public static List<SelectListItem> GetMarkerSize(string defaultValue) {
            string[] markerSizes = new string[] { "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30" };
            List<SelectListItem> listMarkerSize = new List<SelectListItem>();
            for (int i = 0; i < markerSizes.Length; i++) {
                SelectListItem selectedItem = new SelectListItem() { Text = markerSizes[i], Value = markerSizes[i] };
                if (markerSizes[i] == defaultValue)
                    selectedItem.Selected = true;
                listMarkerSize.Add(selectedItem);
            }
            return listMarkerSize;
        }
        public static List<SelectListItem> GetHeightToWidthRatio(){
            string[] ratios = new string[] { "0.1", "0.25", "0.5", "0.75", "1", "2", "4", "6", "8", "10" };
            List<SelectListItem> listRatios= new List<SelectListItem>();
            for (int i = 0; i < ratios.Length; i++)
			{
                SelectListItem selectListItem = new SelectListItem() { Text = ratios[i], Value = ratios[i] };
                if (ratios[i] == "1")
                    selectListItem.Selected = true;
                listRatios.Add(selectListItem);
			}
            return listRatios;
        }
        
        public static List<SelectListItem> GetLineTensions(){
            string[] tension = new string[] { "0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" };
            List<SelectListItem> listTensions = new List<SelectListItem>();
            for (int i = 0; i < tension.Length; i++)
			{
                SelectListItem selectListItem = new SelectListItem() { Text = tension[i], Value = tension[i] };
                if (tension[i] == "70")
                    selectListItem.Selected = true;
                listTensions.Add(selectListItem);
			}
            return listTensions;
        }
        public static List<SelectListItem> GetDoughnutHoleRadiuses(){
            string[] holeRadiuses = new string[] { "0", "15", "30", "50", "60", "75", "90", "100"};
            List<SelectListItem> listRadiuses= new List<SelectListItem>();
            for (int i = 0; i < holeRadiuses.Length; i++)
			{
                SelectListItem selectedItem = new SelectListItem() { Text = holeRadiuses[i] + "%", Value = holeRadiuses[i] };
                if (holeRadiuses[i] == "60") {
                    selectedItem.Text = "Default (" + holeRadiuses[i] + "%)";
                    selectedItem.Selected = true;
                }
                listRadiuses.Add(selectedItem);
			}
            return listRadiuses;
        }
        public static List<SelectListItem> GetLabelkind(){
            string[] kinds = new string[] { "One Label", "Two Labels", "Min Value Label", "Max Value Label" };
            List<SelectListItem> listLabelKinds = new List<SelectListItem>();
            for (int i = 0; i < kinds.Length; i++)
			{
                SelectListItem selectListItem = new SelectListItem() { Text = kinds[i], Value = kinds[i] };
                if (kinds[i] == "Two Labels")
                    selectListItem.Selected = true;
                listLabelKinds.Add(selectListItem);
			}
            return listLabelKinds;
        }
        public static List<SelectListItem> GetScatterFunctions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Archimedean Spiral", Value =  ScatterFunctions.ArchimedeanSpiral.ToString() },
                new SelectListItem() { Text = "Cardioid", Value =  ScatterFunctions.Cardioid.ToString() },
                new SelectListItem() { Text = "Cartesian Folium", Value =  ScatterFunctions.CartesianFolium.ToString() },
            };
        }
        public static List<SelectListItem> GetScatterRadarFunctions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Archimedean Spiral", Value =  ScatterRadarFunctions.ArchimedeanSpiral.ToString() },
                new SelectListItem() { Text = "Polar Rose", Value =  ScatterRadarFunctions.PolarRose.ToString() },
                new SelectListItem() { Text = "Polar Folium", Value =  ScatterRadarFunctions.PolarFolium.ToString() }
            };
        }
        public static List<SelectListItem> GetPolarFunctions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Circles", Value =  PolarFunctions.Circles.ToString() },
                new SelectListItem() { Text = "Cardioid", Value =  PolarFunctions.Cardioid.ToString() },
                new SelectListItem() { Text = "Lemniscate", Value =  PolarFunctions.Lemniscate.ToString() }
            };
        }
        public static List<SelectListItem> GetPolarFunctionsForRadarCharts() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Circles", Value =  PolarFunctions.Circles.ToString() },
                new SelectListItem() { Text = "Cardioid", Value =  PolarFunctions.Cardioid.ToString() },
                new SelectListItem() { Text = "Lemniscate", Value =  PolarFunctions.Lemniscate.ToString(), Selected = true }
            };
        }
        public static List<SelectListItem> GetToolTipPositions() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "Mouse", Value =  ToolTipPositions.Mouse.ToString(), Selected = true },
                new SelectListItem() { Text = "Relative", Value =  ToolTipPositions.Relative.ToString() },
                new SelectListItem() { Text = "Free", Value =  ToolTipPositions.Free.ToString() }
                };
        }
        public static List<SelectListItem> GetToolTipOpenModes() {
            return new List<SelectListItem> {
                new SelectListItem() { Text = "On hover", Value = ToolTipOpenMode.OnHover.ToString(), Selected = true},
                new SelectListItem() { Text = "On click", Value = ToolTipOpenMode.OnClick.ToString()}
            };
        }
        public static List<SelectListItem> GetBar3DModel(){
            string[] models = new string[] { "Box", "Cylinder", "Cone", "Pyramid" };
            List<SelectListItem> list3DModel = new List<SelectListItem>();
            for (int i = 0; i < models.Length ; i++)
			{
                list3DModel.Add(new SelectListItem() { Text = models[i], Value = models[i] });
			}
            return list3DModel;
        }
        public static List<SelectListItem> GetZoomPercent() {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "50", Value = "50"},
                new SelectListItem() { Text = "75", Value = "75"},
                new SelectListItem() { Text = "100", Value = "100"},
                new SelectListItem() { Text = "120", Value = "120"},
                new SelectListItem() { Text = "140", Value = "140", Selected = true},
                new SelectListItem() { Text = "170", Value = "170"},
                new SelectListItem() { Text = "200", Value = "200"},
                new SelectListItem() { Text = "250", Value = "250"},
                new SelectListItem() { Text = "300", Value = "300"}
            };
        }
        public static List<SelectListItem> GetPredefinedHoleRadiuses() {
            const int minRadius = 30;
            const int step = 5;
            const int itemsCount = 8;
            const int defaultRadius = 40;
            List<SelectListItem> items = new List<SelectListItem>();
            for(int itemIndex = 0; itemIndex < itemsCount; itemIndex++) {
                int radius = minRadius + step * itemIndex;
                string radiusString = radius.ToString();
                items.Add(new SelectListItem() {
                    Text = radiusString,
                    Value = radiusString,
                    Selected = radius == defaultRadius
                });
            }
            return items;
        }
        public static List<SelectListItem> GetPredefinedInnerIndents() {
            const int itemsCount = 11;
            const int defaultIndentIndex = 5;
            List<SelectListItem> items = new List<SelectListItem>();
            for(int itemIndex = 0; itemIndex < itemsCount; itemIndex++) {
                string indent = itemIndex.ToString();
                items.Add(new SelectListItem() {
                    Text = indent,
                    Value = indent,
                    Selected = itemIndex == defaultIndentIndex
                });
            }
            return items;
        }
        public static List<string> GetExportFormats() {
            return new List<string>() { "pdf", "xls", "xlsx", "rtf", "mht", "png", "jpeg", "bmp", "tiff", "gif" };
        }
    }
    public static class XMLUtils {
        public static DataTable LoadDataTableFromXml(string fileName, string tableName) {
            DataSet xmlDataSet = new DataSet();
            using (Stream xmlStream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/" + fileName))) {
                xmlDataSet.ReadXml(xmlStream);
                xmlStream.Close();
            }
            return xmlDataSet.Tables[tableName];
        }
    }
}
