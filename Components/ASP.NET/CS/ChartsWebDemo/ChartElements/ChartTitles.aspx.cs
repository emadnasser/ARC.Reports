using System;
using System.Drawing;
using System.Web.UI;
using DevExpress.Web;
using DevExpress.XtraCharts;

public partial class Miscellaneous_ChartTitles : ChartBasePage {
    const string selectedTitleIndexKey = "SelectedTitleIndex";

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Random random = new Random();
            for (int i = 0; i < 40; i++)
                WebChartControl1.Series[0].Points.Add(new SeriesPoint(i, new double[] { random.NextDouble() + 1}));
            int selectedTitleIndex = 0;
            Page.Session[selectedTitleIndexKey] = selectedTitleIndex;
            cmbAlignment.SelectedIndex = (int)WebChartControl1.Titles[selectedTitleIndex].Alignment;
            cmbDock.SelectedIndex = (int)WebChartControl1.Titles[selectedTitleIndex].Dock;
            mmoText.Text = WebChartControl1.Titles[selectedTitleIndex].Text;
            chbWordWrap.Checked = WebChartControl1.Titles[selectedTitleIndex].WordWrap;
            WebChartControl1.SetObjectSelection(WebChartControl1.Titles[selectedTitleIndex]);
        }
    }
    protected void WebChartControl1_CustomCallback(object sender, DevExpress.XtraCharts.Web.CustomCallbackEventArgs e) {
        string[] parametrs = e.Parameter.Split('|');
        int selectedTitleIndex;
        if (parametrs.Length > 0 && parametrs[0] == "ChartTitle") {
            selectedTitleIndex = int.Parse(parametrs[1]);
            Page.Session[selectedTitleIndexKey] = selectedTitleIndex;
            WebChartControl1.Titles[selectedTitleIndex].Alignment = (StringAlignment)int.Parse(parametrs[2]);
            WebChartControl1.Titles[selectedTitleIndex].Dock = (ChartTitleDockStyle)int.Parse(parametrs[3]);
            WebChartControl1.Titles[selectedTitleIndex].Lines = parametrs[4].Split(new string[] { "\r\n" }, StringSplitOptions.None);
            WebChartControl1.Titles[selectedTitleIndex].WordWrap = bool.Parse(parametrs[5]);
        }
        selectedTitleIndex = (int)Page.Session[selectedTitleIndexKey];
        if (selectedTitleIndex > -1)
            WebChartControl1.SetObjectSelection(WebChartControl1.Titles[selectedTitleIndex]);
    }
    protected void WebChartControl1_ObjectSelected(object sender, HotTrackEventArgs e) {
        ChartTitle selectedTitle = e.Object as ChartTitle;
        if (selectedTitle == null)
            e.Cancel = true;
        for (int i = 0; i < WebChartControl1.Titles.Count; i++)
            if (selectedTitle == WebChartControl1.Titles[i]) {
                Page.Session[selectedTitleIndexKey] = i;
                break;
            }
    }
    protected void WebChartControl1_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        object selectedTitleIndexValue = Page.Session[selectedTitleIndexKey];
        if (selectedTitleIndexValue != null) {
            int selectedTitleIndex = (int)selectedTitleIndexValue;
            if (selectedTitleIndex > -1)
                e.Properties.Add("cp_wordwrap", WebChartControl1.Titles[selectedTitleIndex].WordWrap);
        }
    }
}
