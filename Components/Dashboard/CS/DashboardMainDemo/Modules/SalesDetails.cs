using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.ViewerData;
using DevExpress.DashboardWin;
using DevExpress.XtraEditors;

namespace DashboardMainDemo.Modules {
    public partial class SalesDetails : DashboardTutorialControl {
        bool apiDisabled = false;

        protected override bool CalculateHiddenTotals { get { return true; } }

        public SalesDetails() {
            InitializeComponent();
        }

        protected override void SubscribeDashboardEvents() {
            DashboardViewer.DashboardItemClick += DashboardViewer_DashboardItemClick;
            DashboardViewer.DashboardItemVisualInteractivity += OnDashboardItemVisualInteractivity;
        }
        void OnDashboardItemVisualInteractivity(object sender, DashboardItemVisualInteractivityEventArgs e) {
            if(e.DashboardItemName == "cardSalesByProduct") {
                e.EnableHighlighting = true;
            }
        }
        void DashboardViewer_DashboardItemClick(object sender, DashboardItemMouseActionEventArgs e) {
            if(!apiDisabled && e.DashboardItemName == "cardSalesByProduct") {
                AxisPoint axisPoint = e.GetAxisPoint();
                if(axisPoint != null)
                    using(SalesDetailsPopupForm form = new SalesDetailsPopupForm()) {
                        form.SetGridDataSource(CreateGridData(e));
                        form.SetPieData(CreatePieData(e));
                        form.SetChartData(CreateChartData(e));
                        form.PrepareChart(e);
                        form.SetUnitsInStock(GetUnitsInStock(e));
                        form.Text = axisPoint.Value.ToString();
                        form.ShowDialog();
                    }
            }
        }
        private object GetUnitsInStock(DashboardItemMouseActionEventArgs e) {
            MultiDimensionalData clickedItemData = e.Data.GetSlice(e.GetAxisPoint());
            List<MeasureDescriptor> measures = new List<MeasureDescriptor>(e.Data.GetMeasures());
            MeasureDescriptor unitsInStockMeasure = measures.Find((descriptor) => { return descriptor.DataMember == "UnitsInStock"; });
            return clickedItemData.GetValue(unitsInStockMeasure).DisplayText;
        }
        private DashboardUnderlyingDataSet CreateGridData(DashboardItemMouseActionEventArgs e) {
            IList<string> columnNames = e.Data.GetDataMembers();
            return e.GetUnderlyingData(new List<string> { columnNames[7], columnNames[1], columnNames[5], columnNames[6],
                columnNames[9], columnNames[10], columnNames[3], columnNames[4], columnNames[8] });
        }
        private DataTable CreatePieData(DashboardItemMouseActionEventArgs e) {
            AxisPoint axisPoint = e.GetAxisPoint();
            MultiDimensionalData data = e.Data;
            DeltaDescriptor delta = e.GetDeltas()[0];

            DataTable table = new DataTable();

            table.Columns.Add("Argument", typeof(string));
            table.Columns.Add("Value", typeof(decimal));

            DataRow row = null;
            row = table.NewRow();
            row["Argument"] = axisPoint.Value.ToString();
            decimal deltaValue = Convert.ToDecimal(data.GetSlice(axisPoint).GetDeltaValue(delta).ActualValue.Value);
            row["Value"] = deltaValue;
            table.Rows.Add(row);
            row = table.NewRow();
            decimal totalValue = Convert.ToDecimal(data.GetSlice(axisPoint.Parent).GetDeltaValue(delta).ActualValue.Value);
            row["Argument"] = "Other " + axisPoint.Parent.Value.ToString();
            row["Value"] = (totalValue - deltaValue).ToString();
            table.Rows.Add(row);

            return table;
        }
        private DataTable CreateChartData(DashboardItemMouseActionEventArgs e) {
            MultiDimensionalData clickedItemData = e.Data.GetSlice(e.GetAxisPoint());
            DeltaDescriptor delta = e.GetDeltas()[0];

            DataTable table = new DataTable();

            table.Columns.Add("Argument", typeof(int));
            table.Columns.Add("Actual", typeof(double));
            table.Columns.Add("Target", typeof(double));

            foreach(AxisPoint point in clickedItemData.GetAxisPoints("Sparkline")) {
                object argumentValue = point.Value;
                if(argumentValue is int) {
                    DataRow row = table.NewRow();
                    row["Argument"] = argumentValue;
                    DeltaValue deltaValue = clickedItemData.GetSlice(point).GetDeltaValue(delta);
                    row["Actual"] = deltaValue.ActualValue.Value;
                    row["Target"] = deltaValue.TargetValue.Value;
                    table.Rows.Add(row);
                }
            }

            return table;
        }
        protected override void EditDashboard() {
            if(apiDisabled || XtraMessageBox.Show(LookAndFeel, this, "If you proceed and modify this dashboard, the capability to pop up detail windows for individual cards will be disabled. Do you wish to continue?", "Sales Details", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                base.EditDashboard();
                if(!apiDisabled && DashboardModified)
                    apiDisabled = true;
            }
        }
    }
}
