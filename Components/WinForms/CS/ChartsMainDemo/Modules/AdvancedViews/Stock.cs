using System;

namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	public partial class StockDemo : FinancialSeriesViewDemoBase {
		#region inner classes
		public class StockTypeItem {
			StockType stockType;		
			public StockType StockType { get { return this.stockType; } }

			public StockTypeItem(StockType stockType) {
				this.stockType = stockType;
			}
			public override string ToString() {
				return this.stockType.ToString();
			}
		}
		#endregion

		DevExpress.XtraCharts.ChartControl chart;
        DevExpress.XtraEditors.ComboBoxEdit comboBoxEditStockType;

		public override ChartControl ChartControl { get { return this.chart; } }
		
		public StockDemo() {
			InitializeComponent();
			this.seriesSelected = this.chart.Series[0];
		}
		protected override void InitControls() {
			base.InitControls();
            ChartControl.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowForNearestSeries;
            StockTypeItem[] items = new StockTypeItem[] { new StockTypeItem(StockType.Both), new StockTypeItem(StockType.Close), new StockTypeItem(StockType.Open) };
			this.comboBoxEditStockType.Properties.Items.AddRange(items);
			this.comboBoxEditStockType.SelectedIndex = 0;
		}
		void comboBoxEditStockType_SelectedIndexChanged(object sender, EventArgs e) {
			if (this.seriesSelected == null) 
				return;
            StockSeriesView view = seriesSelected.View as StockSeriesView;
            if (view != null)
			    view.ShowOpenClose = ((StockTypeItem)this.comboBoxEditStockType.SelectedItem).StockType;
		}
	}
}

