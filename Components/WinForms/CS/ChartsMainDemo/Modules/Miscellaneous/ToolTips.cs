using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos.Miscellaneous {
    public partial class ToolTipsDemo : ChartDemoBase2D {
        ChartControl chart;
        ToolTipMousePosition toolTipMousePosition = new ToolTipMousePosition();
        ToolTipRelativePosition toolTipRelativePosition = new ToolTipRelativePosition();
        ToolTipFreePosition toolTipFreePosition = new ToolTipFreePosition();
        bool isFirstLoading = true;

        public override ChartControl ChartControl { get { return chart; } }

        public ToolTipsDemo() {
            InitializeComponent();
            toolTipFreePosition.DockTarget = ((XYDiagram2D)chart.Diagram).DefaultPane;
            toolTipFreePosition.DockCorner = ToolTipDockCorner.TopLeft;
            toolTipFreePosition.OffsetX = 10;
            toolTipFreePosition.OffsetY = 10;
            chart.DataSource = GDPofG7.GetDataByMember();
        }

        void cbToolTipPosition_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbToolTipPosition.SelectedIndex) {
                case 0:
                    chart.ToolTipOptions.ToolTipPosition = toolTipMousePosition;
                    defaultToolTipController.DefaultController.ShowBeak = true;
                    break;
                case 1:
                    chart.ToolTipOptions.ToolTipPosition = toolTipRelativePosition;
                    defaultToolTipController.DefaultController.ShowBeak = true;
                    break;
                case 2:
                    chart.ToolTipOptions.ToolTipPosition = toolTipFreePosition;
                    defaultToolTipController.DefaultController.ShowBeak = false;
                    break;
            }
        }
        void defaultToolTipController_DefaultController_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            ToolTipController controller = sender as ToolTipController;
            SeriesPoint seriesPoint = controller.ActiveObject as SeriesPoint;
            if (seriesPoint != null) {
                G7Member g7Member = seriesPoint.Tag as G7Member;
                string chartTitle = g7Member.CountryName + " GDP History";
                e.ToolTipImage = CreateChart(g7Member.GDPs, chartTitle, GetColorFromPaletteByNumber(g7Member.ColorNumberInPalette));
                e.ToolTip = "";
            }
        }
        Color GetColorFromPaletteByNumber(int colorNumber) {
            PaletteEntry[] entries = chart.GetPaletteEntries(8);
            return entries[colorNumber].Color;
        }
        Image CreateChart(List<GDP> toolTipChartDataSource, string chartTitleText, Color seriesColor) {
            ChartControl chart = new ChartControl();
            chart.BorderOptions.Visibility = DefaultBoolean.False;
            chart.Series.Add(new Series("GDP Dynamic", ViewType.Line));
            chart.DataSource = toolTipChartDataSource;
            chart.Series[0].ValueDataMembers.AddRange("Product");
            chart.Series[0].ArgumentDataMember = "Year";
            chart.Series[0].LabelsVisibility = DefaultBoolean.False;
            chart.Series[0].View.Color = seriesColor;
            chart.Series[0].ArgumentScaleType = ScaleType.Numerical;
            chart.Legend.Visibility = DefaultBoolean.False;
            XYDiagram xyDiagram = chart.Diagram as XYDiagram;
            ChartTitle chartTitle = new ChartTitle() { Text = chartTitleText, Font = new Font("Tahoma", 12) };
            xyDiagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            chart.Titles.Add(chartTitle);
            Image chartAsImage;
            using (MemoryStream stream = new MemoryStream()) {
                chart.ExportToImage(stream, ImageFormat.Png);
                chartAsImage = new Bitmap(stream);
            }
            return chartAsImage;
        }
        
        protected override void DoHide() {
            base.DoHide();
            defaultToolTipController.DefaultController.BeforeShow -= defaultToolTipController_DefaultController_BeforeShow;
            defaultToolTipController.DefaultController.Rounded = false;
            defaultToolTipController.DefaultController.ShowBeak = false;
        }
        protected override void DoShow() {
            base.DoShow();
            if (!isFirstLoading) {
                defaultToolTipController.DefaultController.Rounded = true;
                defaultToolTipController.DefaultController.ShowBeak = true;
                defaultToolTipController.DefaultController.BeforeShow += defaultToolTipController_DefaultController_BeforeShow;
            } else
                isFirstLoading = false;
        }
    }
}
