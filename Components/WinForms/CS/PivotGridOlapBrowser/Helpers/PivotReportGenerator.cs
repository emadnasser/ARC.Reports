using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace PivotGridOlapBrowser.Helpers {
    interface IXRControlCreatable {
        XRControl CreateControl();
    }
    interface IInitializable {
        bool Initialize(Control control);
    }
    public class XRPivotGridEx : XRPivotGrid, IInitializable {
        const string PivotName = "xrPivot";

        public static XRPivotGridEx Create(BrowserPivot browser) {
            XRPivotGridEx xrPivot = new XRPivotGridEx();
            xrPivot.Initialize(browser, true);
            return xrPivot;
        }

        BrowserPivot pivot;
        bool Initialize(BrowserPivot pivot, bool loadLayout) {
            this.pivot = pivot;
            if(pivot == null) return false;
            this.Name = PivotName;
            if(loadLayout) {
                LoadLayout(pivot);
            }
            LoadDataSource(pivot);
            LoadCollapsedState(pivot);
            return true;
        }
        void LoadLayout(BrowserPivot pivot) {
            using(MemoryStream stream = new MemoryStream()) {
                pivot.SaveLayoutToStream(stream);
                stream.Position = 0;
                this.RestoreLayoutCore(new XmlXtraSerializer(), stream, OptionsLayoutBase.FullLayout);
            }
        }
        void LoadDataSource(BrowserPivot pivot) {
            IPivotGridDataSource pivotDataSource = pivot.DataSourceClone as IPivotGridDataSource;
            if(pivotDataSource != null) {
                this.Data.PivotDataSource = pivotDataSource;
            }
        }
        void LoadCollapsedState(BrowserPivot pivot) {
            using(MemoryStream stream = new MemoryStream()) {
                pivot.SaveCollapsedStateToStream(stream);
                stream.Position = 0;
                this.Data.LoadCollapsedStateFromStream(stream);
            }
        }

        #region IInitializable Members
        bool IInitializable.Initialize(Control control) {
            return this.Initialize(control as BrowserPivot, false);
        }
        #endregion
    }

    public class XRChartEx : XRChart, IInitializable {
        const string ChartName = "xrChart";

        public static XRChartEx Create(BrowserChart chart) {
            XRChartEx xrChart = new XRChartEx();
            xrChart.Initialize(chart);
            return xrChart;
        }

        bool Initialize(BrowserChart chart) {
            if(chart == null) return false;
            Name = ChartName;
            ((IChartContainer)this).Chart.Assign(((IChartContainer)chart).Chart);
            return true;
        }
	    #region IInitializable Members
        bool IInitializable.Initialize(Control control) {
            return Initialize(control as BrowserChart);
        }
        #endregion
    }

    public class XRGridEx : XRTable, IInitializable {
        const string GridName = "xrGrid";
        const float DefaultRowHeight = 25;
        public static XRGridEx Create(BrowserGrid grid) {
            XRGridEx xrGrid = new XRGridEx();
            xrGrid.Initialize(grid);
            return xrGrid;
        }

        BrowserGrid grid;

        bool Initialize(BrowserGrid grid) {
            this.grid = grid;
            if(grid == null) return false;
            this.Name = GridName;

            DataSet gridData = FillDatasetFromGrid((GridView)grid.MainView);
            PrepareCells(gridData.Tables[0]);
            return true;
        }

        #region Convert grid to report objects
        DataSet FillDatasetFromGrid(GridView gridView) {
            DataSet ds = new DataSet();
            DataTable dataTable = ds.Tables.Add();
            foreach(GridColumn gridColumn in gridView.Columns) {
                if(IsColumnVisible(gridColumn)) {
                    dataTable.Columns.Add(new DataColumn(gridColumn.GetCaption()));
                }
            }
            for(int i = 0; i < gridView.RowCount; i++) {
                int rowHandle = gridView.GetVisibleRowHandle(i);
                if(!gridView.IsGroupRow(rowHandle)) {
                    PivotDrillDownDataRow drillDownRow = (PivotDrillDownDataRow)gridView.GetRow(rowHandle);
                    ArrayList values = new ArrayList();
                    foreach(GridColumn gridColumn in gridView.Columns) {
                        if(IsColumnVisible(gridColumn)) {
                            values.Add(drillDownRow[gridColumn.FieldName]);
                        }
                    }
                    dataTable.Rows.Add(values.ToArray());
                }
            }
            return ds;
        }
        bool IsColumnVisible(GridColumn gridColumn) {
            return gridColumn.Visible && gridColumn.GroupIndex < 0;
        }
        void PrepareCells(DataTable dataTable) {
            int colCount = dataTable.Columns.Count;
            int rowCount = dataTable.Rows.Count;

            this.HeightF = DefaultRowHeight * (rowCount + 1);
            this.Borders = BorderSide.All;
            this.BeginInit();
            this.Rows.Clear();
            XRTableRow row = new XRTableRow();
            // Header
            for(int i = 0; i < colCount; i++) {
                XRTableCell cell = new XRTableCell();
                cell.Text = dataTable.Columns[i].Caption;
                cell.TextAlignment = TextAlignment.MiddleCenter;
                row.Cells.Add(cell);
            }
            this.Rows.Add(row);
            // Content
            for(int i = 0; i < rowCount; i++) {
                row = new XRTableRow();
                for(int j = 0; j < colCount; j++) {
                    XRTableCell cell = new XRTableCell();
                    cell.Text = dataTable.Rows[i][j].ToString();
                    cell.TextAlignment = TextAlignment.MiddleCenter;
                    row.Cells.Add(cell);
                }
                this.Rows.Add(row);
            }
            this.AdjustSize();
            this.EndInit();
        }
        #endregion
        
        #region IInitializable Members
        bool IInitializable.Initialize(Control control) {
            return this.Initialize(control as BrowserGrid);
        }
        #endregion
    }

    public class BrowserReport : XtraReport {
        const float DefaultControlHeight = 250;

        readonly List<Control> reportControls;
        readonly Dictionary<string, Control> relationDic;

        public BrowserReport(List<Control> reportControls)
            : base() {
            this.reportControls = reportControls;
            List<XRControl> xrControls = ReportControlsFactory.Create(this.reportControls);
            this.relationDic = new Dictionary<string, Control>();
            for(int i = 0; i < this.reportControls.Count; i++) {
                if(string.IsNullOrEmpty(xrControls[i].Name)) continue;
                this.relationDic.Add(xrControls[i].Name, this.reportControls[i]);
            }
            AddControls(xrControls);
        }
        protected override void OnBeforePrint(System.Drawing.Printing.PrintEventArgs e) {
            base.OnBeforePrint(e);
            DetailBand detail = GetDetail();
            foreach(XRControl control in detail.Controls) {
                Control baseControl = null;
                if(!relationDic.TryGetValue(control.Name, out baseControl)) 
                    continue;
                IInitializable initializableControl = control as IInitializable;
                if(initializableControl != null) {
                    initializableControl.Initialize(baseControl);
                    continue;
                }
            }
        }
        void AddControls(List<XRControl> xrControls) {
            DetailBand detail = GetDetail();
            foreach(XRControl xrControl in xrControls) {
                this.Add(detail, xrControl);
            }
        }
        void Add(DetailBand detail, XRControl xrControl) {
            InitSize(detail, xrControl);
            detail.Controls.Add(xrControl);
        }
        void InitSize(DetailBand detail, XRControl xrControl) {
            xrControl.LocationF = new PointF(0, detail.HeightF);
            if(xrControl.HeightF < DefaultControlHeight) {
                xrControl.HeightF = DefaultControlHeight;
            }
            xrControl.WidthF = PageWidth - (Margins.Left + Margins.Right);
            detail.HeightF += xrControl.HeightF;
        }
        DetailBand GetDetail() {
            DetailBand detail = (DetailBand)this.Bands[BandKind.Detail];
            if(detail == null) {
                InitBands();
                detail = (DetailBand)this.Bands[BandKind.Detail];
            }
            return detail;
        }
        void InitBands() {
            // Create bands
            DetailBand detail = new DetailBand();
            PageHeaderBand pageHeader = new PageHeaderBand();
            ReportFooterBand reportFooter = new ReportFooterBand();
            detail.Height = 20;
            reportFooter.Height = 380;
            pageHeader.Height = 20;
            // Place the bands onto a report
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { detail, pageHeader, reportFooter });
        }
        protected override XtraReport CreateClone() {
            return new BrowserReport(reportControls);
        }
    }

    public static class PivotReportGenerator {
        public static XtraReport GenerateReport(List<Control> reportControls) {
            BrowserReport rep = new BrowserReport(reportControls);            
            return rep;
        }
    }

    public static class ReportControlsFactory {
        public static List<XRControl> Create(List<Control> reportControls) {
            List<XRControl> xrControls = new List<XRControl>();
            foreach(Control control in reportControls) {
                IXRControlCreatable xrControlCreatable = control as IXRControlCreatable;
                if(xrControlCreatable == null) continue;

                XRControl xrControl = xrControlCreatable.CreateControl();
                xrControl.Name += Convert.ToString(xrControls.Count);
                xrControls.Add(xrControl);
            }
            return xrControls;
        }
    }
}
