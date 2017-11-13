using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos {
    public partial class ChartEditor : TutorialControl {
        string query = "SELECT Employees.EmployeeID, Categories.CategoryName, Sum([Order Details].Quantity) AS SumOfQuantity FROM Categories INNER JOIN (Products INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Categories.CategoryID = Products.CategoryID GROUP BY Employees.EmployeeID, Categories.CategoryName;";
        string queryName = "SalesByCategory";
        DataSet ds = new DataSet();
        private GridControl CurrentGrid { get { return gridControl1; } }
        public ChartEditor() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesAnyControl\\ChartEditor.cs;CS\\GridMainDemo\\ModulesAnyControl\\AnyChartEditor.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.ChartEditor.xml";
            InitNWindData();
            RepositoryItemPictureEdit photoEditor = new RepositoryItemPictureEdit();
            photoEditor.Caption.Appearance.BackColor = Color.FromArgb(200, Color.White);
            photoEditor.Caption.Appearance.ForeColor = Color.FromArgb(40,40,40);
            photoEditor.Caption.Text = "{FirstName} <b>{LastName}</b>";
            gridControl1.RepositoryItems.Add(photoEditor);
            colPhoto.ColumnEdit = photoEditor;

            
        }
        protected override void InitMDBData(string connectionString) {
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Employees", connectionString);
            SetWaitDialogCaption(Properties.Resources.LoadingEmployees);
            oleDbDataAdapter.Fill(ds, "Employees");
            CurrentGrid.DataSource = ds.Tables["Employees"];

            oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, connectionString);
            oleDbDataAdapter.Fill(ds, queryName);
        }
        SeriesBase ChartSeries { get { return chartControl1.Series[0]; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitChartTypeEdit();
            ChartSeries.ArgumentDataMember = "CategoryName";
            ChartSeries.ValueDataMembers.AddRange("Quantity");
            //<gridControl1>
            CreateChartEdit(colChart, chartControl1);
            //</gridControl1>
        }
        //<icbChartType>
        void InitChartTypeEdit() {
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Pie", typeof(DevExpress.XtraCharts.PieSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Doughnut", typeof(DevExpress.XtraCharts.DoughnutSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Bar", typeof(DevExpress.XtraCharts.StackedBarSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Line", typeof(DevExpress.XtraCharts.LineSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Funnel", typeof(DevExpress.XtraCharts.FunnelSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Area", typeof(DevExpress.XtraCharts.StackedAreaSeriesView), -1));
            icbChartType.Properties.Items.Add(new ImageComboBoxItem("Spline Area", typeof(DevExpress.XtraCharts.StackedSplineAreaSeriesView), -1));
            icbChartType.EditValue = ChartSeries.View.GetType();
        }
        //</icbChartType>
        //<gridControl1>
        static void CreateChartEdit(GridColumn column, ChartControl chartControl) {
            if(column.ColumnEdit != null) return;
            RepositoryItemAnyControl item = new RepositoryItemAnyControl();
            item.Control = new EmbeddedChartControl(chartControl);
            column.View.GridControl.RepositoryItems.Add(item);
            ((GridView)column.View).OptionsSelection.EnableAppearanceHideSelection = false;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsFilter.AllowFilter = false;
            column.OptionsColumn.AllowGroup = Utils.DefaultBoolean.False;
            column.OptionsColumn.AllowSort = Utils.DefaultBoolean.False;
            column.ColumnEdit = item;
        }
        
        private void gridView1_CustomUnboundColumnData(object sender, Views.Base.CustomColumnDataEventArgs e) {
            if(e.IsGetData) e.Value = GetChartData(e.Row);
        }
        Dictionary<int, List<EmployeeSalesByCategoryChartData>> chartData = new Dictionary<int, List<EmployeeSalesByCategoryChartData>>();
        object GetChartData(object val) {
            DataRowView row = val as DataRowView;
            if(row == null) return null;
            int key = (int)row["EmployeeID"];
            if(!chartData.ContainsKey(key))
                chartData.Add(key, GetEmployeeSalesByCategoryChartData(key));
            return chartData[key];
        }
        List<EmployeeSalesByCategoryChartData> GetEmployeeSalesByCategoryChartData(int key) {
            List<EmployeeSalesByCategoryChartData> ret = new List<EmployeeSalesByCategoryChartData>();
            foreach(DataRow row in ds.Tables[queryName].Rows) {
                if(key.Equals(row["EmployeeID"]))
                    ret.Add(new EmployeeSalesByCategoryChartData() { CategoryName = row["CategoryName"].ToString(), Quantity = (double)row["SumOfQuantity"] });
            }
            return ret;
        }
        //</gridControl1>
        //<icbChartType>
        private void icbChartType_SelectedIndexChanged(object sender, EventArgs e) {
            Type viewType = icbChartType.EditValue as Type;
            ChartSeries.View.Dispose();
            ChartSeries.View = Activator.CreateInstance(viewType) as SeriesViewBase;
            RepositoryItemAnyControl edit = colChart.ColumnEdit as RepositoryItemAnyControl;
            if(edit != null) edit.RefreshControl();

            
        }
        //</icbChartType>
        //<gridControl1>
        public class EmployeeSalesByCategoryChartData {
            public string CategoryName { get; set; }
            public double Quantity { get; set; }
        }
        //</gridControl1>
        private void advBandedGridView1_CustomColumnDisplayText(object sender, Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column == colHireDate || e.Column == colHomePhone)
                e.DisplayText = string.Format("{0}: {1:d}", e.Column.GetCaption(), e.Value);
        }

        private void advBandedGridView1_CustomDrawCell(object sender, Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column == colPhoto) {
                var cell = e.Cell as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridCellInfo;
                PictureEditViewInfo pic = cell.ViewInfo as PictureEditViewInfo;
                //if(pic != null) pic.CaptionText = advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colFirstName) + "  " + advBandedGridView1.GetRowCellDisplayText(e.RowHandle, colLastName);
            }
        }
    }
}
