using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.DataBinding {
    public partial class UsingSeriesTemplatesDemo : ChartDemoBase2D {
        ChartControl chart;
        ComboBoxEdit comboBoxEditSeriesDataMember;
        const string yearSeries = "Year";
        const string countrySeries = "Country";

        protected override bool SeriesSelection { get { return false; } }

        public override ChartControl ChartControl { get { return chart; } }

        public UsingSeriesTemplatesDemo() {
            InitializeComponent();
        }

        void comboBoxEditSeriesDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxEditSeriesDataMember.SelectedIndex == -1)
                return;
            chart.SeriesDataMember = comboBoxEditSeriesDataMember.Text;
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (comboBoxEditSeriesDataMember.Text == yearSeries) {
                chart.SeriesTemplate.ArgumentDataMember = countrySeries;
                diagram.AxisX.Title.Text = "Countries";
            }
            else {
                chart.SeriesTemplate.ArgumentDataMember = yearSeries;
                diagram.AxisX.Title.Text = "Years";
            }
        }

        protected override void InitControls() {
            base.InitControls();
            ShowLabels = false;
            comboBoxEditSeriesDataMember.Properties.Items.Add(yearSeries);
            comboBoxEditSeriesDataMember.Properties.Items.Add(countrySeries);
            comboBoxEditSeriesDataMember.SelectedIndex = 0;
            ChartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:F3}";
            ChartControl.DataSource = GDPofG7.GetData();
            XYDiagram diagram = chart.Diagram as XYDiagram;
            diagram.AxisY.GridLines.MinorVisible = true;
            diagram.AxisX.Title.Visibility = DefaultBoolean.True;
        }
    }
}
