using System;
using System.Web.UI;
using DevExpress.XtraPivotGrid;

public partial class OLAP_KPI : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string error = OLAPConnector.TryConnect(pivotGrid);
        if(!string.IsNullOrEmpty(error)) {
            Control errorPanel = OLAPConnector.CreateErrorPanel(error);
            pivotGrid.Parent.Controls.AddAt(0, errorPanel);
            panelOptions.Visible = false;
        }

		if(IsPostBack) return;

		ddlStatusGraphics.Items.Clear();
		ddlStatusGraphics.Items.Add("None", PivotKPIGraphic.None);
		ddlStatusGraphics.Items.Add("ServerDefined", PivotKPIGraphic.ServerDefined);
		ddlStatusGraphics.Items.Add("Cylinder", PivotKPIGraphic.Cylinder);
		ddlStatusGraphics.Items.Add("Faces", PivotKPIGraphic.Faces);
		ddlStatusGraphics.Items.Add("Gauge", PivotKPIGraphic.Gauge);
		ddlStatusGraphics.Items.Add("RoadSigns", PivotKPIGraphic.RoadSigns);
		ddlStatusGraphics.Items.Add("Shapes", PivotKPIGraphic.Shapes);
		ddlStatusGraphics.Items.Add("Thermometer", PivotKPIGraphic.Thermometer);
		ddlStatusGraphics.Items.Add("TrafficLights", PivotKPIGraphic.TrafficLights);
		ddlStatusGraphics.Items.Add("VarianceArrow", PivotKPIGraphic.VarianceArrow);
		ddlStatusGraphics.Items.Add("ReversedCylinder", PivotKPIGraphic.ReversedCylinder);
		ddlStatusGraphics.Items.Add("ReversedGauge", PivotKPIGraphic.ReversedGauge);
		ddlStatusGraphics.Items.Add("ReversedThermometer", PivotKPIGraphic.ReversedThermometer);		
		ddlStatusGraphics.SelectedIndex = 1;

		ddlTrendGraphics.Items.Clear();
		ddlTrendGraphics.Items.Add("None", PivotKPIGraphic.None);
		ddlTrendGraphics.Items.Add("ServerDefined", PivotKPIGraphic.ServerDefined);
		ddlTrendGraphics.Items.Add("StandardArrow", PivotKPIGraphic.StandardArrow);
		ddlTrendGraphics.Items.Add("StatusArrow", PivotKPIGraphic.StatusArrow);
		ddlTrendGraphics.Items.Add("ReversedStatusArrow", PivotKPIGraphic.ReversedStatusArrow);
		ddlTrendGraphics.Items.Add("Faces", PivotKPIGraphic.Faces);
		ddlTrendGraphics.SelectedIndex = 1;
    }
	protected void ddlStatusGraphics_SelectedIndexChanged(object sender, EventArgs e) {
		pivotGrid.Fields["fieldStatus"].KPIGraphic = (PivotKPIGraphic)Enum.Parse(typeof(PivotKPIGraphic), ddlStatusGraphics.SelectedItem.Text);
	}
	protected void ddlTrendGraphics_SelectedIndexChanged(object sender, EventArgs e) {
		pivotGrid.Fields["fieldTrend"].KPIGraphic = (PivotKPIGraphic)Enum.Parse(typeof(PivotKPIGraphic), ddlTrendGraphics.SelectedItem.Text);
	}
}
