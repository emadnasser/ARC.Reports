using System;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.DataBinding {
	public partial class BindingIndividualSeriesDemo : ChartDemoBase2D {
		struct SortingKeys {
			public const string Argument = "Products";
			public const string Value = "Price";
		}
	
		ChartControl chart;
        ComboBoxEdit comboBoxEditFilter;
		OleDbConnection oleDbConnection1;
		OleDbDataAdapter oleDbDataAdapterCategories;
		OleDbCommand oleDbSelectCommand1;
		OleDbCommand oleDbInsertCommand1;
		OleDbCommand oleDbUpdateCommand1;
		OleDbCommand oleDbDeleteCommand1;
		OleDbCommand oleDbSelectCommand2;
		OleDbCommand oleDbInsertCommand2;
		OleDbCommand oleDbUpdateCommand2;
		OleDbCommand oleDbDeleteCommand2;
		OleDbDataAdapter oleDbDataAdapterProducts;
        DS ds1;
		ComboBoxEdit comboBoxEditSortOrder;
        ComboBoxEdit comboBoxEditSortBy;

		public override ChartControl ChartControl { get { return this.chart; } }

		public BindingIndividualSeriesDemo() {
			InitializeComponent();
		}
		
		void comboBoxEditFilter_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.comboBoxEditFilter.SelectedIndex == -1 || this.chart.Series.Count == 0) 
                return;
			this.chart.Series[0].DataFilters.Clear();
			int id = this.ds1.Categories[this.comboBoxEditFilter.SelectedIndex].CategoryID;            
			this.chart.Series[0].DataFilters.Add(new DataFilter(this.ds1.Categories.CategoryIDColumn.ColumnName, id.GetType().FullName, DataFilterCondition.Equal, id));
		}
		void comboBoxEditSortOrder_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditSortOrder.SelectedIndex == -1 || this.chart.Series.Count == 0) 
                return;
			if(this.comboBoxEditSortOrder.Text == SortingMode.Ascending.ToString())
				this.chart.Series[0].SeriesPointsSorting = SortingMode.Ascending;
			else if(this.comboBoxEditSortOrder.Text == SortingMode.Descending.ToString())
                this.chart.Series[0].SeriesPointsSorting = SortingMode.Descending;
			else
                this.chart.Series[0].SeriesPointsSorting = SortingMode.None;
			UpdateControls();
		}
		void comboBoxEditSortBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.comboBoxEditSortBy.SelectedIndex == -1 || this.chart.Series.Count == 0) 
                return;
			switch(this.comboBoxEditSortBy.Text) {
				case SortingKeys.Argument:
					this.chart.Series[0].SeriesPointsSortingKey = SeriesPointKey.Argument;
					break;
				case SortingKeys.Value:
                    this.chart.Series[0].SeriesPointsSortingKey = SeriesPointKey.Value_1;
					break;
			}
		}
        void chart_BoundDataChanged(object sender, EventArgs e) {
            if (chart.Titles.Count == 0)
                return;
            ChartTitle dataInfoTitle = chart.Titles[0];
            int categoryIndex = this.comboBoxEditFilter.SelectedIndex;
            if (categoryIndex >= 0) {
                string categoryName = this.ds1.Categories[categoryIndex].CategoryName;
                dataInfoTitle.Text = "Category: " + categoryName;
                Series series = chart.Series[0];
                if (series.Points.Count > 0) {
                    double minValue = Math.Round(CalcMinValue(series), 2);
                    double maxValue = Math.Round(CalcMaxValue(series), 2);
                    double averageValue = Math.Round(CalcAverageValue(series), 2);
                    dataInfoTitle.Text +=
                        "\nMin price: " + minValue.ToString() +
                        "\nMax price: " + maxValue.ToString() +
                        "\nAverage price: " + averageValue.ToString();
                }
            }
            else
                dataInfoTitle.Text = String.Empty;
            ChartControl.Animate();
        }
        double CalcMinValue(Series series) {
            double min = double.MaxValue;
            foreach(SeriesPoint point in series.Points)
                min = Math.Min(min, point.Values[0]);
            return min;
        }
        double CalcMaxValue(Series series) {
            double max = double.MinValue;
            foreach(SeriesPoint point in series.Points)
                max = Math.Max(max, point.Values[0]);
            return max;
        }
        double CalcAverageValue(Series series) {
            double sum = 0;
            foreach(SeriesPoint point in series.Points)
                sum += point.Values[0];
            return sum / series.Points.Count;
        }
        
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = true;
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
            string path = Utils.GetRelativePath("nwind.mdb");
            if (path.Length > 0)
                Utils.SetConnectionString(this.oleDbConnection1, path);
            else {
                XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                this.oleDbDataAdapterCategories.Fill(this.ds1);
                this.oleDbDataAdapterProducts.Fill(this.ds1);
            }
            catch (OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DS.CategoriesRow row in this.ds1.Categories)
                this.comboBoxEditFilter.Properties.Items.Add(row.CategoryName);
            this.comboBoxEditFilter.SelectedIndex = 2;
            this.comboBoxEditSortOrder.Properties.Items.AddRange(new string[] { SortingMode.None.ToString(), SortingMode.Ascending.ToString(), SortingMode.Descending.ToString() });
            this.comboBoxEditSortOrder.SelectedIndex = 1;
            this.comboBoxEditSortBy.Properties.Items.AddRange(new string[] { SortingKeys.Argument, SortingKeys.Value });
            this.comboBoxEditSortBy.SelectedIndex = 1;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (this.chart.Series.Count > 0) {
                bool sortingEnabled = this.chart.Series[0].SeriesPointsSorting != SortingMode.None;
                this.comboBoxEditSortBy.Enabled = sortingEnabled;
                this.labelSortBy.Enabled = sortingEnabled;
            }
        }
	}
}
