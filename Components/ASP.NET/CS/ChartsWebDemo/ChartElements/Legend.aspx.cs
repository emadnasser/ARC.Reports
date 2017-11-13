using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;

public partial class LegendDemo : ChartBasePage {
    Legend Legend { get { return WebChartControl1.Legend; } }
    bool HorizontalDirection { get { return Legend.Direction == LegendDirection.LeftToRight || Legend.Direction == LegendDirection.RightToLeft; } }
    bool HorizontalAlignmentInside { get { return Legend.AlignmentHorizontal == LegendAlignmentHorizontal.Left || Legend.AlignmentHorizontal == LegendAlignmentHorizontal.Center || Legend.AlignmentHorizontal == LegendAlignmentHorizontal.Right; } }
    bool VerticalAlignmentInside { get { return Legend.AlignmentVertical == LegendAlignmentVertical.Top || Legend.AlignmentVertical == LegendAlignmentVertical.Center || Legend.AlignmentVertical == LegendAlignmentVertical.Bottom; } }

	protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
			InitSeries();
			UpdateEquallySpacedItemsEnable();				
            ComboBoxHelper.PrepareComboBox(cbDirection, Legend.Direction);
            ComboBoxHelper.PrepareComboBox(cbVertAlignment, Legend.AlignmentVertical);
            ComboBoxHelper.PrepareComboBox(cbHorAlignment, Legend.AlignmentHorizontal);
            ComboBoxHelper.PrepareLegendPercentComboBox(cbMaxHorPercentage, Legend.MaxHorizontalPercentage);
            ComboBoxHelper.PrepareLegendPercentComboBox(cbMaxVertPercentage, Legend.MaxVerticalPercentage);
		}
	}
    protected void WebChartControl1_CustomCallback(object sender, CustomCallbackEventArgs e) {
        switch (e.Parameter) {
            case "HorAligment":
                PerformHorAligmentAction();
                break;
            case "VerAligment":
                PerformVerAligmentAction();
                break;
            case "MaxHorPrctg":
                PerformMaxHorPrctgAction();
                break;
            case "MaxVerPrctg":
                PerformMaxVerPrctgAction();
                break;
            case "EqSpaced":
                PerformEqSpacedAction();
                break;
            case "Direction":
                PerformDirectionAction();
                break;
        }
    }
    void InitSeries() {
        Random random = new Random();
        for (int i = 0; i < WebChartControl1.Series.Count; i++) {
            WebChartControl1.Series[i].Points.Clear();
            List<Point> points = new List<Point>();
            int min = 1;
            int max = 10;
            while (points.Count < 5) {
                Point point = new Point(random.Next(min, max), random.Next(min, max));
                if (!points.Contains(point)) {
                    points.Add(point);
                    WebChartControl1.Series[i].Points.Add(new SeriesPoint(point.X, point.Y));
                }
            }
        }
    }
    void UpdateEquallySpacedItemsEnable() {
        chbEquallySpaced.Checked = Legend.EquallySpacedItems;
    }
    void UpdateLegendMargins() {
        if (HorizontalAlignmentInside && VerticalAlignmentInside)
            WebChartControl1.Legend.Margins.All = 10;
        else
            WebChartControl1.Legend.Margins.All = 5;
    }
    void PerformHorAligmentAction() {
        Legend.AlignmentHorizontal = (LegendAlignmentHorizontal)cbHorAlignment.SelectedIndex;
        UpdateLegendMargins();
    }
    void PerformVerAligmentAction() {
        Legend.AlignmentVertical = (LegendAlignmentVertical)cbVertAlignment.SelectedIndex;
        UpdateLegendMargins();
    }
    void PerformMaxHorPrctgAction() {        
        Legend.MaxHorizontalPercentage = ComboBoxHelper.GetSelectedLegendPercent(cbMaxHorPercentage);
    }
    void PerformMaxVerPrctgAction() {        
        Legend.MaxVerticalPercentage = ComboBoxHelper.GetSelectedLegendPercent(cbMaxVertPercentage);
    }
    void PerformEqSpacedAction() {
        if (HorizontalDirection)
            Legend.EquallySpacedItems = chbEquallySpaced.Checked;
    }
    void PerformDirectionAction() {
        Legend.Direction = (LegendDirection)cbDirection.SelectedIndex;
        UpdateEquallySpacedItemsEnable();
    }
}
