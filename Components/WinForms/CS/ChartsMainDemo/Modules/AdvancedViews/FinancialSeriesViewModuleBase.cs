using System;

namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	public partial class FinancialSeriesViewDemoBase : ChartDemoBase2D {
        #region Nested clas: StockLevelItem
        public class StockLevelItem {
			StockLevel level;

			public StockLevel Level { get { return this.level; } }

			public StockLevelItem(StockLevel level) {
				this.level = level;
			}
			public override string ToString() {
				return this.level.ToString();
			}
		}
		#endregion

        public FinancialSeriesViewDemoBase() {
			InitializeComponent();
		}

    	void comboBoxEditLabelLevel_SelectedIndexChanged(object sender, EventArgs e) {
			if (seriesSelected == null)
				return;
            switch(((StockLevelItem)comboBoxEditLabelLevel.SelectedItem).Level){
                case StockLevel.Low:
                    seriesSelected.Label.TextPattern = "{LV:G4}";
                    break;
                case StockLevel.High:
                    seriesSelected.Label.TextPattern = "{HV:G4}";
                    break;
                case StockLevel.Open:
                    seriesSelected.Label.TextPattern = "{OV:G4}";
                    break;
                case StockLevel.Close:
                    seriesSelected.Label.TextPattern = "{CV:G4}";
                    break;
                default:
                    seriesSelected.Label.TextPattern = "{CV:G4}";
                    break;
            }
		}
		void comboBoxEditReductionLevel_SelectedIndexChanged(object sender, EventArgs e) {
			if (seriesSelected == null) 
				return;
            FinancialSeriesViewBase view = seriesSelected.View as FinancialSeriesViewBase;
            if (view != null)
			    view.ReductionOptions.Level = ((StockLevelItem)comboBoxEditReductionLevel.SelectedItem).Level;
		}
        void checkEditWorkdaysOnly_CheckedChanged(object sender, EventArgs e) {
            IXYDiagram2D diagram = ChartControl.Diagram as IXYDiagram2D;
            if (diagram != null)
                diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly = checkEditWorkdaysOnly.Checked;
        }
        void LoadSeriesData() {
            if (seriesSelected == null)
                return;
            seriesSelected.ValueDataMembers.AddRange("Low", "High", "Open", "Close");
            seriesSelected.ArgumentDataMember = "Date";
            seriesSelected.DataSource = MarketPrices.GetGoogleStockPrices();
        }
        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            StockLevelItem[] items = new StockLevelItem[] { new StockLevelItem(StockLevel.Low), new StockLevelItem(StockLevel.High), new StockLevelItem(StockLevel.Open), new StockLevelItem(StockLevel.Close) };
            comboBoxEditLabelLevel.Properties.Items.AddRange(items);
            comboBoxEditLabelLevel.SelectedIndex = 3;
            comboBoxEditReductionLevel.Properties.Items.AddRange(items);
            comboBoxEditReductionLevel.SelectedIndex = 3;
            LoadSeriesData();
        }
        public override void UpdateControls() {
            base.UpdateControls();
            comboBoxEditLabelLevel.Enabled = ShowLabels;
            labelLabelLevel.Enabled = ShowLabels;
            IXYDiagram2D diagram = ChartControl.Diagram as IXYDiagram2D;
            if (diagram == null)
                checkEditWorkdaysOnly.Enabled = false;
            else {
                checkEditWorkdaysOnly.Enabled = true;
                checkEditWorkdaysOnly.Checked = diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly;
            }
        }
    }
}
