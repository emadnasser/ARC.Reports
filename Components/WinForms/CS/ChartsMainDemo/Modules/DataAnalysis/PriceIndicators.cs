using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    public partial class PriceIndicatorsDemo : ChartDemoBase2D {
        #region PriceIndicatorItem class
        class PriceIndicatorItem {
            readonly Indicator indicator;

            public Indicator Indicator { get { return indicator; } }

            public PriceIndicatorItem(Indicator indicator) {
                this.indicator = indicator;
            }
            public override string ToString() {
                return indicator.Name;
            }
        }
        #endregion

        Indicator SelectedIndicator {
            get {
                PriceIndicatorItem priceIndicatorItem = cbePriceIndicator.SelectedItem as PriceIndicatorItem;
                if (priceIndicatorItem != null)
                    return priceIndicatorItem.Indicator;
                return null;
            }
        }

        public override ChartControl ChartControl { get { return chart; } }
        public override bool AnimateChartControlOnDemoAppear { get { return false; } }

        public PriceIndicatorsDemo() {
            InitializeComponent();
            InitializePriceIndicators();
            UpdateControls();
        }

        void InitializePriceIndicators() {
            var view = (FinancialSeriesViewBase)chart.Series[0].View;
            foreach (Indicator indicator in view.Indicators) {
                PriceIndicatorItem indicatorItem = new PriceIndicatorItem(indicator);
                cbePriceIndicator.Properties.Items.Add(indicatorItem);
            }
            cbePriceIndicator.SelectedIndex = 0;
        }
        void cbePriceIndicator_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateControls();
        }
        void speThickness_EditValueChanged(object sender, EventArgs e) {
            if(SelectedIndicator != null)
                SelectedIndicator.LineStyle.Thickness = Convert.ToInt32(speThickness.EditValue);
        }
        void clreColor_EditValueChanged(object sender, EventArgs e) {
            if (SelectedIndicator != null)
                SelectedIndicator.Color = (Color)clreColor.EditValue;
        }
        void cbDashStyle_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectedIndicator != null)
                SelectedIndicator.LineStyle.DashStyle = (DashStyle)(cbDashStyle.SelectedIndex + 1);
        }
        protected override void InitControls() {
            base.InitControls();
            ChartControl.Series[0].DataSource = MarketPrices.GetAppleStockPrices();
        }
        public override void UpdateControls() {
            base.UpdateControls();
            foreach (PriceIndicatorItem item in cbePriceIndicator.Properties.Items) {
                item.Indicator.Visible = cbePriceIndicator.SelectedItem == item;
            }
            if (SelectedIndicator != null) {
                speThickness.EditValue = SelectedIndicator.LineStyle.Thickness;
                clreColor.EditValue = SelectedIndicator.Color;
                cbDashStyle.SelectedIndex = (int)SelectedIndicator.LineStyle.DashStyle - 1;
            }
        }
    }
}
