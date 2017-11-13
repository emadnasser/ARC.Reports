using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleChartRangeControlClients : TutorialControl {
        const int seriesCount = 3;
        const int pointCount = 50;
        const double valueLevelThreshold = 100;
        const string argumentColumn = "Argument";
        const string valueColumn = "Value";
        const string seriesColumn = "Series";

        readonly DataTable numericDataSource;
        readonly DataTable dateTimeDataSource;
        readonly DateTime baseDate;

        public ModuleChartRangeControlClients() {
            InitializeComponent();
            TutorialInfo.AboutFile = null;
            TutorialInfo.Description = "";
            TutorialInfo.TutorialName = "Chart Range Control Clients Tutorial";
            TutorialInfo.WhatsThisCodeFile = "";
            TutorialInfo.WhatsThisXMLFile = "";
            TutorialInfo.WhatsThisCodeFile = "CS\\EditorsMainDemo\\Modules\\ModuleChartRangeControlClients.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraEditors.Demos.CodeInfo.chartRangeControlClients.xml";

            this.numericDataSource = new DataTable();
            this.dateTimeDataSource = new DataTable();
            this.baseDate = DateTime.Now;

            SetClientDateSource(dateTimeClient, dateTimeDataSource, typeof(DateTime));
            SetClientDateSource(numericClient, numericDataSource, typeof(double));

            radioGroupView.SelectedIndex = 1;

            InitPalettes();

            checkEditNumericAuto.Checked = true;
            checkEditDateTimeAuto.Checked = true;

            FillDateTimeComboBox(comboBoxDateTimeGridAlignment);
            FillDateTimeComboBox(comboBoxDateTimeSnapAlignment);
        }

        void FillDateTimeComboBox(ComboBoxEdit comboBox) {
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Day);
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Week);
            comboBox.Properties.Items.Add(RangeControlDateTimeGridAlignment.Month);
        }
        object GetArgumentByIndex(Type argumentType, int index) {
            if (argumentType == typeof(DateTime))
                return baseDate.AddDays(index * 7);
            return (double)(index * 10000);
        }
        void SetClientDateSource(ChartRangeControlClientBase client, DataTable dataSource, Type argumentType) {
            dataSource.Columns.Add(seriesColumn, typeof(string));
            dataSource.Columns.Add(argumentColumn, argumentType);
            dataSource.Columns.Add(valueColumn, typeof(double));

            Random rand = new Random((int)DateTime.Now.Ticks);

            double valueLevel = valueLevelThreshold * seriesCount;

            for (int seriesIndex = 0; seriesIndex < seriesCount; seriesIndex++) {
                for (int pointIndex = 0; pointIndex < pointCount; pointIndex++)
                    dataSource.Rows.Add("Series " + seriesIndex.ToString(), GetArgumentByIndex(argumentType, pointIndex), rand.NextDouble() * valueLevelThreshold + valueLevel);
                valueLevel -= valueLevelThreshold;
            }

            client.DataProvider.SeriesDataMember = seriesColumn;
            client.DataProvider.ArgumentDataMember = argumentColumn;
            client.DataProvider.ValueDataMember = valueColumn;
            client.DataProvider.DataSource = dataSource;
        }
        void InitPalettes() {
            foreach (string paletteName in ChartRangeControlClientBase.PredefinedPalettes)
                comboBoxPalette.Properties.Items.Add(paletteName);

            comboBoxPalette.SelectedItem = numericClient.PaletteName;
        }
        void SetTrackBarRange(TrackBarControl trackBar, int min, int max) {
            trackBar.Properties.BeginUpdate();
            trackBar.Properties.Minimum = 0;
            trackBar.Properties.Maximum = int.MaxValue;
            trackBar.Value = min;
            trackBar.Properties.Minimum = min;
            trackBar.Properties.Maximum = max;
            trackBar.Properties.EndUpdate();
        }
        void SetSpacingTrackBarRange(TrackBarControl trackBar, RangeControlDateTimeGridAlignment alignment) {
            switch (alignment) {
                case RangeControlDateTimeGridAlignment.Day:
                    SetTrackBarRange(trackBar, 40, 60);
                    break;
                case RangeControlDateTimeGridAlignment.Week:
                    SetTrackBarRange(trackBar, 6, 12);
                    break;
                default:
                case RangeControlDateTimeGridAlignment.Month:
                    SetTrackBarRange(trackBar, 2, 6);
                    break;
            }
        }

        // <radioGroupView>
        void radioGroupView_SelectedIndexChanged(object sender, EventArgs e) {
            int viewType = (int)radioGroupView.SelectedIndex;

            ChartRangeControlClientView clientView = null;

            switch (viewType) {
                case 0:
                    clientView = new LineChartRangeControlClientView();
                    break;
                default:
                case 1:
                    clientView = new AreaChartRangeControlClientView();
                    break;
            }

            dateTimeClient.DataProvider.TemplateView = clientView;
            numericClient.DataProvider.TemplateView = clientView;
        }
        // </radioGroupView>
        // <comboBoxPalette>
        void comboBoxPalette_SelectedIndexChanged(object sender, EventArgs e) {
            string paletteName = (string)comboBoxPalette.SelectedItem;
            numericClient.PaletteName = paletteName;
            dateTimeClient.PaletteName = paletteName;
        }
        // </comboBoxPalette>
        // <checkEditNumericAuto>
        void checkEditNumericAuto_CheckedChanged(object sender, EventArgs e) {
            NumericChartRangeControlClientGridOptions gridOptions = numericClient.GridOptions;

            gridOptions.Auto = checkEditNumericAuto.Checked;

            trackBarNumericGridSpacing.Enabled = !gridOptions.Auto;
            trackBarNumericSnapSpacing.Enabled = !gridOptions.Auto;

            if (!gridOptions.Auto) {
                trackBarNumericGridSpacing.Value = (int)gridOptions.GridSpacing;
                trackBarNumericSnapSpacing.Value = (int)gridOptions.SnapSpacing;
            }
        }
        // </checkEditNumericAuto>
        // <checkEditDateTimeAuto>
        void checkEditDateTimeAuto_CheckedChanged(object sender, EventArgs e) {
            DateTimeChartRangeControlClientGridOptions gridOptions = dateTimeClient.GridOptions;

            gridOptions.Auto = checkEditDateTimeAuto.Checked;

            trackBarDateTimeGridSpacing.Enabled = !gridOptions.Auto;
            trackBarDateTimeSnapSpacing.Enabled = !gridOptions.Auto;
            comboBoxDateTimeGridAlignment.Enabled = !gridOptions.Auto;
            comboBoxDateTimeSnapAlignment.Enabled = !gridOptions.Auto;

            if (!gridOptions.Auto) {
                comboBoxDateTimeGridAlignment.SelectedItem = gridOptions.GridAlignment;
                comboBoxDateTimeSnapAlignment.SelectedItem = gridOptions.SnapAlignment;
                trackBarDateTimeSnapSpacing.Value = (int)gridOptions.SnapSpacing;
                trackBarDateTimeGridSpacing.Value = (int)gridOptions.GridSpacing;
            }
        }
        // </checkEditDateTimeAuto>
        // <trackBarNumericGridSpacing>
        void trackBarNumericGridSpacing_EditValueChanged(object sender, EventArgs e) {
            numericClient.GridOptions.GridSpacing = (double)trackBarNumericGridSpacing.Value;
        }
        // </trackBarNumericGridSpacing>
        // <trackBarNumericSnapSpacing>
        void trackBarNumericSnapSpacing_EditValueChanged(object sender, EventArgs e) {
            numericClient.GridOptions.SnapSpacing = (double)trackBarNumericSnapSpacing.Value;
        }
        // </trackBarNumericSnapSpacing>
        // <trackBarDateTimeGridSpacing>
        void trackBarDateTimeGridSpacing_EditValueChanged(object sender, EventArgs e) {
            dateTimeClient.GridOptions.GridSpacing = (double)trackBarDateTimeGridSpacing.Value;
        }
        // </trackBarDateTimeGridSpacing>
        // <trackBarDateTimeSnapSpacing>
        void trackBarDateTimeSnapSpacing_EditValueChanged(object sender, EventArgs e) {
            dateTimeClient.GridOptions.SnapSpacing = (double)trackBarDateTimeSnapSpacing.Value;
        }
        // </trackBarDateTimeSnapSpacing>
        // <comboBoxDateTimeGridAlignment>
        void comboBoxDateTimeGridAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlDateTimeGridAlignment alignment = (RangeControlDateTimeGridAlignment)comboBoxDateTimeGridAlignment.SelectedItem;
            dateTimeClient.GridOptions.GridAlignment = alignment;
            SetSpacingTrackBarRange(trackBarDateTimeGridSpacing, alignment);
        }
        // </comboBoxDateTimeGridAlignment>
        // <comboBoxDateTimeSnapAlignment>
        void comboBoxDateTimeSnapAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            RangeControlDateTimeGridAlignment alignment = (RangeControlDateTimeGridAlignment)comboBoxDateTimeSnapAlignment.SelectedItem;
            dateTimeClient.GridOptions.SnapAlignment = alignment;
            SetSpacingTrackBarRange(trackBarDateTimeSnapSpacing, alignment);
        }
        // </comboBoxDateTimeSnapAlignment>

        void trackBarNumeric_EditValueChanging(object sender, ChangingEventArgs e) {
            e.NewValue = Math.Round(Convert.ToDouble(e.NewValue) / 10000.0) * 10000.0;
        }
    }
}
