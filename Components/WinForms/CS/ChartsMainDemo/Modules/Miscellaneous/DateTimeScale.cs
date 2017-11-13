using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class DateTimeScaleDemo : ChartDemoBase2D {
        public class ComboBoxItem {
            string titleText;
            Action actionField; 

            public Action ItemAction {
                get { return actionField; }
            }

            public ComboBoxItem(string titleText, Action actionParam) {
                this.titleText = titleText;
                this.actionField = actionParam;
            }
            public override string ToString() {
                return titleText;
            }
        }

        const string OrderDateColumn = "OrderDate";
        const string FreightColumn = "Freight";
        const string SelectQuery = "SELECT OrderDate, Freight FROM Orders";
        const string Title = "Sales Volume by ";

        List<ComboBoxItem> gridAlignmentItems;

        protected XYDiagram Diagram { get { return chart.Diagram as XYDiagram; } }
        protected AxisX AxisX { get { return Diagram.AxisX; } }
        
        public override ChartControl ChartControl { get { return this.chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public DateTimeScaleDemo() {
            InitializeComponent();
        }

        List<ComboBoxItem> CreateGridAlignmentComboBoxItems() {
            return new List<ComboBoxItem>() {
                new ComboBoxItem("Year", SetYearGridAlignment),
                new ComboBoxItem("Quarter", SetQuarterGridAlignment),
                new ComboBoxItem("Month", SetMonthGridAlignment),
                new ComboBoxItem("Week", SetWeekGridAlignment),
                new ComboBoxItem("Day", SetDayGridAlignment),
            };
        }
        void FillScaleMode() {
            List<ComboBoxItem> scaleModeItems = new List<ComboBoxItem>() {
                new ComboBoxItem("Manual", SetManualScaleMode),
                new ComboBoxItem("Continuous", SetContinuousScaleMode),
                new ComboBoxItem("Automatic", SetAutomaticScaleMode)
            };
            cbScaleMode.Properties.Items.AddRange(scaleModeItems);
        }
        void FillMeasureUnit() {
            List<ComboBoxItem> measureUnitItems = new List<ComboBoxItem>() {
                new ComboBoxItem("Year", SetYearMeasureUnit),
                new ComboBoxItem("Quarter", SetQuarterMeasureUnit),
                new ComboBoxItem("Month", SetMonthMeasureUnit),
                new ComboBoxItem("Week", SetWeekMeasureUnit),
                new ComboBoxItem("Day", SetDayMeasureUnit)
            };
            cbMeasureUnit.Properties.Items.AddRange(measureUnitItems);
        }
        void FillFunctions() {
            List<ComboBoxItem> aggregateFunctionItems = new List<ComboBoxItem>() {
                new ComboBoxItem("Average", SetAverageFunctionItems),
                new ComboBoxItem("Minimum", SetMinimumFunctionItems),
                new ComboBoxItem("Maximum", SetMaximumFunctionItems),
                new ComboBoxItem("Sum", SetSumFunctionItems),
                new ComboBoxItem("Count", SetCountFunctionItems)
            };
            cbAggregateFunction.Properties.Items.AddRange(aggregateFunctionItems);
            cbAggregateFunction.SelectedIndex = 3;
        }
        void BindChartToData() {
            DataSet ds = new DataSet();
            using (OleDbConnection connection = new OleDbConnection()) {
                string path = Utils.GetRelativePath("nwind.mdb");
                if (path.Length > 0)
                    Utils.SetConnectionString(connection, path);
                else {
                    XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(SelectQuery, connection)) {
                        adapter.Fill(ds);
                    }
                }
                catch (OleDbException e) {
                    XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Series series = new Series("Primary", ViewType.StackedBar);
            series.DataSource = ds;
            series.ArgumentDataMember = "Table.OrderDate";
            series.ValueDataMembers.AddRange(new string[] { "Table.Freight" });

            chart.Series.Clear();
            chart.Series.Add(series);
        }
        void SetChartTitle(string additionalTitle) {
            if (chart.Titles.Count > 0)
                chart.Titles[0].Text = Title + additionalTitle;
        }
        void ResetAxisOptions() {
            AxisX.DateTimeScaleOptions.GridSpacing = 1;
            AxisX.Tickmarks.MinorVisible = false;
            AxisX.Label.Angle = 0;
        }
        void EnableAggregateFunction(bool isEnabled) {
            cbAggregateFunction.Enabled = isEnabled;
            if (isEnabled)
                ExecuteSelectedItemAction(cbAggregateFunction);
        }
        void EnablebGridAlignment(bool isEnabled) {
            chbAutoGrid.Enabled = isEnabled;
            if (isEnabled)
                UpdateAutoGrid();
            else
                cbGridAlignment.Enabled = isEnabled;
        }
        void SetAxisXGridAlignment(DateTimeGridAlignment gridAlignment) {
            AxisX.DateTimeScaleOptions.GridAlignment = gridAlignment;
        }
        void SetAxisXAggregateFunction(AggregateFunction aggregateFunction) {
            AxisX.DateTimeScaleOptions.AggregateFunction = aggregateFunction;
        }
        void SetManualScaleMode() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            cbMeasureUnit.Enabled = true;
            ExecuteSelectedItemAction(cbMeasureUnit);
            EnablebGridAlignment(true);
            EnableAggregateFunction(true);
        }
        void SetContinuousScaleMode() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            cbMeasureUnit.Enabled = false;
            EnablebGridAlignment(true);
            UpdateGridAlignment(5);
            EnableAggregateFunction(false);
        }
        void SetAutomaticScaleMode() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
            cbMeasureUnit.Enabled = false;
            EnablebGridAlignment(false);
            EnableAggregateFunction(true);
        }
        void SetYearMeasureUnit() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year;
            UpdateGridAlignment(1);
            SetChartTitle("Years");
        }
        void SetQuarterMeasureUnit() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter;
            UpdateGridAlignment(2);
            SetChartTitle("Quarters");
        }
        void SetMonthMeasureUnit() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
            UpdateGridAlignment(3);
            SetChartTitle("Months");
        }
        void SetWeekMeasureUnit() {
            ResetAxisOptions();
            AxisX.Tickmarks.MinorVisible = true;
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
            UpdateGridAlignment(4);
            SetChartTitle("Weeks");
        }
        void SetDayMeasureUnit() {
            ResetAxisOptions();
            AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            UpdateGridAlignment(5);
            SetChartTitle("Days");
        }
        void UpdateGridAlignment(int itemsCount) {
            itemsCount = Math.Max(itemsCount, 1);
            int selectedIndex = Math.Max(cbGridAlignment.SelectedIndex, 0);
            cbGridAlignment.Properties.Items.Clear();
            cbGridAlignment.Properties.Items.AddRange(gridAlignmentItems.GetRange(0, itemsCount));
            cbGridAlignment.SelectedIndex = Math.Min(itemsCount - 1, selectedIndex);
            if (cbGridAlignment.Enabled)
                ExecuteSelectedItemAction(cbGridAlignment);
        }
        void UpdateAutoGrid() {
            bool isAutoGrid = chbAutoGrid.Checked;
            AxisX.DateTimeScaleOptions.AutoGrid = isAutoGrid;
            cbGridAlignment.Enabled = !isAutoGrid;
            if (!isAutoGrid)
                ExecuteSelectedItemAction(cbGridAlignment);
        }
        void SetDayGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Day);
        }
        void SetWeekGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Week);
        }
        void SetMonthGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Month);
        }
        void SetQuarterGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Quarter);
        }
        void SetYearGridAlignment() {
            SetAxisXGridAlignment(DateTimeGridAlignment.Year);
        }
        void SetCountFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Count);
        }
        void SetSumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Sum);
        }
        void SetMaximumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Maximum);
        }
        void SetMinimumFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Average);
        }
        void SetAverageFunctionItems() {
            SetAxisXAggregateFunction(AggregateFunction.Minimum);
        }
        void ExecuteSelectedItemAction(ComboBoxEdit comboBox) {
            ComboBoxItem item = comboBox.SelectedItem as ComboBoxItem;
            if (item != null) {
                Action itemAction = item.ItemAction;
                if (itemAction != null)
                    itemAction();
            }
        }
        void ComboBoxSelectedValueChanged(object sender, EventArgs e) {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            if (comboBox != null)
                ExecuteSelectedItemAction(comboBox);
        }
        void chbAutoGrid_CheckedChanged(object sender, EventArgs e) {
            UpdateAutoGrid();
        }

        protected override void InitControls() {
            base.InitControls();
            ChartControl.CrosshairEnabled = DefaultBoolean.True;
            gridAlignmentItems = CreateGridAlignmentComboBoxItems();
            FillMeasureUnit();
            FillFunctions();
            FillScaleMode();
            BindChartToData();
            cbMeasureUnit.SelectedIndex = 0;
            cbScaleMode.SelectedIndex = 0;
        }
    }
}
