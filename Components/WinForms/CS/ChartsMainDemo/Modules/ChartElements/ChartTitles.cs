using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos.ChartElements {
    public partial class ChartTitlesDemo : ChartDemoBase {
        ChartControl chart;
        ChartTitle selectedChartTitle;
        string[] alignment = { "Near", "Center", "Far" };
        string[] dockSyle = { "Top", "Bottom", "Left", "Right" };

        public override ChartControl ChartControl { get { return this.chart; } }

        public ChartTitlesDemo() {
            InitializeComponent();
            Random random = new Random();
            for (int i = 0; i < 40; i++)
                chart.Series[0].Points.Add(new SeriesPoint(i, new double[] { random.NextDouble() + 1 }));
        }

        void PrepareCombobox(ComboBoxEdit combobox, string[] items) {
            combobox.Properties.Items.Clear();
            combobox.Properties.Items.AddRange(items);
        }
        void EnableCombobox(ComboBoxEdit combobox, int selectedIndex) {
            combobox.SelectedIndex = selectedIndex;
            combobox.Enabled = true;
        }
        void DisableCombobox(ComboBoxEdit combobox) {
            combobox.SelectedIndex = -1;
            combobox.Enabled = false;
        }
        void chart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if (e.Object is ChartTitle)
                selectedChartTitle = (ChartTitle)e.Object;
            else
                e.Cancel = true;
            UpdateControls();
        }
        void meeText_TextChanged(object sender, EventArgs e) {
            if (meeText.Lines.Length > 0)
                selectedChartTitle.Lines = meeText.Lines;
        }
        void cmbAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbAlignment.SelectedIndex > -1)
                selectedChartTitle.Alignment = (StringAlignment)cmbAlignment.SelectedIndex;
        }
        void cmbDock_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbDock.SelectedIndex > -1)
                selectedChartTitle.Dock = (ChartTitleDockStyle)cmbDock.SelectedIndex;
        }
        void ChartDemoChartTitles_Load(object sender, EventArgs e) {
            PrepareCombobox(cmbAlignment, alignment);
            PrepareCombobox(cmbDock, dockSyle);
            selectedChartTitle = chart.Titles[0];
            chart.SetObjectSelection(selectedChartTitle);
            UpdateControls();
        }
        void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (!(e.Object is ChartTitle))
                e.Cancel = true;
        }
        void chbWordWrap_CheckedChanged(object sender, EventArgs e) {
            selectedChartTitle.WordWrap = chbWordWrap.Checked;
        }

        public override void UpdateControls() {
            base.UpdateControls();
            if (selectedChartTitle != null) {
                EnableCombobox(cmbAlignment, (int)selectedChartTitle.Alignment);
                EnableCombobox(cmbDock, (int)selectedChartTitle.Dock);
                chbWordWrap.Enabled = true;
                chbWordWrap.Checked = selectedChartTitle.WordWrap;
                meeText.Text = selectedChartTitle.Text;
                meeText.Enabled = true;
                lblAlignment.Enabled = true;
                lblDock.Enabled = true;
                lblText.Enabled = true;
            }
            else {
                DisableCombobox(cmbAlignment);
                DisableCombobox(cmbDock);
                chbWordWrap.Enabled = false;
                meeText.Text = string.Empty;
                meeText.Enabled = false;
                lblAlignment.Enabled = false;
                lblDock.Enabled = false;
                lblText.Enabled = false;
            }
        }
    }
}
