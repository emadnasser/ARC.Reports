using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using DevExpress.Utils;

namespace PivotGridOlapBrowser.Helpers {
    public class BrowserChart : ChartControl, IXRControlCreatable {
        static void InitChart(BrowserChart chart) {
            chart.SeriesDataMember = "Series";
            chart.SeriesTemplate.ArgumentDataMember = "Arguments";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Values" });
            chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;
            chart.Legend.AlignmentVertical = LegendAlignmentVertical.Center;
            PrepareXYDiagram(chart.Diagram as XYDiagram);
        }
        static void PrepareXYDiagram(XYDiagram diagram) {
            if(diagram == null)
                return;
            diagram.AxisX.Label.Angle = -45;
            diagram.AxisX.Label.EnableAntialiasing = DefaultBoolean.True;
            //diagram.AxisX.Label.Staggered = true;
        }

        ViewType fViewType;
        bool showTotals;
        bool? showSelection;
        readonly DataState state;

        public BrowserChart(ViewType viewType, bool showTotals, bool? showSelection, DataState state) {
            BrowserChart.InitChart(this);
            this.showTotals = showTotals;
            this.showSelection = showSelection;
            this.state = state;
            ApplyFilter();
            ViewType = viewType;
        }        
        public bool ShowTotals {
            get { return showTotals; }
            set {
                if(value == showTotals) return;
                this.showTotals = value;
                ApplyFilter();
            }
        }
        public bool? ShowSelection {
            get { return showSelection; }
            set {
                if(value == showSelection) return;
                this.showSelection = value;
                ApplyFilter();
            }
        }
        public ViewType ViewType {
            get {
                return this.fViewType;
            }
            set {
                if(object.Equals(fViewType, value)) return;
                this.fViewType = value;
                SeriesTemplate.ChangeView(this.fViewType);
            }
        }
        protected void ApplyFilter() {
            SeriesTemplate.DataFilters.Clear();
            SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.And;
            if(!this.showTotals) {
                switch(this.state) {
                    case DataState.SingleColumn:
                        AddRowFilter();
                        break;
                    case DataState.SingleRow:
                        AddColumnFilter();
                        break;
                    default:
                        AddColumnFilter();
                        AddRowFilter();
                        break;
                }
            }
            if(this.showSelection == true) {
                AddSelectionFilter();
            }
        }
        void AddRowFilter() {
            SeriesTemplate.DataFilters.AddRange(new DataFilter[] {
                new DataFilter(PivotDataExtractor.ColumnNameIsRowTotal, typeof(bool).Name, DataFilterCondition.Equal, false),
                new DataFilter(PivotDataExtractor.ColumnNameIsRowGrandTotal, typeof(bool).Name, DataFilterCondition.Equal, false)
            });
        }
        void AddColumnFilter() {
            SeriesTemplate.DataFilters.AddRange(new DataFilter[] {
                new DataFilter(PivotDataExtractor.ColumnNameIsColumnTotal, typeof(bool).Name, DataFilterCondition.Equal, false),
                new DataFilter(PivotDataExtractor.ColumnNameIsColumnGrandTotal, typeof(bool).Name, DataFilterCondition.Equal, false)                            
            });
        }
        void AddSelectionFilter() {
            SeriesTemplate.DataFilters.AddRange(new DataFilter[] {
                new DataFilter(PivotDataExtractor.ColumnNameIsSelected, typeof(bool).Name, DataFilterCondition.Equal, true)
            });
        }
        #region IXRControlCreatable Members
        public new XRControl CreateControl() {
            return XRChartEx.Create(this);
        }
        #endregion
    }
}
