using System;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI;

public partial class Multiselection  : ChartBasePage {
    const string YearDataMember = "Year";
    const string RegionDataMember = "Region";

    Dictionary<string, int> colorIndices;
    List<int> paletteIndices = new List<int>();

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            cbShowLabels.Checked = WebChartControlBars.SeriesTemplate.LabelsVisibility == DefaultBoolean.True;
            WebChartControlBars.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            ComboBoxHelper.PrepareComboBox(cbSelectionMode, Enum.GetNames(typeof(ElementSelectionMode)), ElementSelectionMode.Multiple.ToString());
        }
        else {
            WebChartControlBars.DataBind();
            WebChartControlPie.SelectionMode = (ElementSelectionMode)Enum.Parse(typeof(ElementSelectionMode), cbSelectionMode.SelectedItem.ToString());
            WebChartControlBars.SeriesTemplate.LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            WebChartControlBars.CrosshairEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
            WebChartControlPie.Series[0].LabelsVisibility = cbShowLabels.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            WebChartControlPie.ToolTipEnabled = cbShowLabels.Checked ? DefaultBoolean.False : DefaultBoolean.True;
        }
    }
    void InitColorIndices() {
        colorIndices = new Dictionary<string, int>();
        for (int i = 0; i < WebChartControlPie.Series[0].Points.Count; i++)
            colorIndices.Add(WebChartControlPie.Series[0].Points[i].Argument, i);
    }
    
    void ChangeSeriesVisibility() {
        InitColorIndices();
        paletteIndices = new List<int>();
        List<DataFilter> filters = new List<DataFilter>();
        WebChartControlBars.SeriesTemplate.DataFilters.Clear();
        WebChartControlBars.SeriesTemplate.DataFilters.ConjunctionMode = ConjunctionTypes.Or;
        foreach (List<object> dataList in WebChartControlPie.SelectedItems) {
            if (dataList.Count > 0) {
                DataRowView dataRow = dataList[0] as DataRowView;
                string region = (string)dataRow.Row["REGION"];
                DataFilter selectedSeriesFilter = new DataFilter("REGION", typeof(string).FullName, DataFilterCondition.Equal, region);
                filters.Add(selectedSeriesFilter);
                paletteIndices.Add(colorIndices[region]);
            }
        }
        WebChartControlBars.SeriesTemplate.DataFilters.AddRange(filters.ToArray());
    }
    void UpdateSeriesColors(List<int> paletteIndices) {
        PaletteEntry[] paletteEntries = WebChartControlPie.GetPaletteEntries(WebChartControlPie.Series[0].Points.Count);
        for (int i = 0; i < paletteIndices.Count; i++) {
            WebChartControlBars.Series[i].View.Color = paletteEntries[paletteIndices[i]].Color;
            ((BarSeriesView)WebChartControlBars.Series[i].View).FillStyle.FillMode = FillMode.Solid;
        }
    }

    protected void WebChartControlPie_ObjectSelected(object sender, HotTrackEventArgs e) {
        if (!(e.Object is Series)) {
            e.Cancel = true;
            WebChartControlPie.SelectedItems.Clear();
        }
    }
    protected void WebChartControlPie_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e) {
        ChangeSeriesVisibility();
    }
    protected void WebChartControlBars_BoundDataChanged(object sender, EventArgs e) {
        UpdateSeriesColors(paletteIndices);
    }
}
