Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraPivotGrid

Partial Public Class OLAP_KPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim [error] As String = OLAPConnector.TryConnect(pivotGrid)
		If (Not String.IsNullOrEmpty([error])) Then
			Dim errorPanel As Control = OLAPConnector.CreateErrorPanel([error])
			pivotGrid.Parent.Controls.AddAt(0, errorPanel)
			panelOptions.Visible = False
		End If

		If IsPostBack Then
			Return
		End If

		ddlStatusGraphics.Items.Clear()
		ddlStatusGraphics.Items.Add("None", PivotKPIGraphic.None)
		ddlStatusGraphics.Items.Add("ServerDefined", PivotKPIGraphic.ServerDefined)
		ddlStatusGraphics.Items.Add("Cylinder", PivotKPIGraphic.Cylinder)
		ddlStatusGraphics.Items.Add("Faces", PivotKPIGraphic.Faces)
		ddlStatusGraphics.Items.Add("Gauge", PivotKPIGraphic.Gauge)
		ddlStatusGraphics.Items.Add("RoadSigns", PivotKPIGraphic.RoadSigns)
		ddlStatusGraphics.Items.Add("Shapes", PivotKPIGraphic.Shapes)
		ddlStatusGraphics.Items.Add("Thermometer", PivotKPIGraphic.Thermometer)
		ddlStatusGraphics.Items.Add("TrafficLights", PivotKPIGraphic.TrafficLights)
		ddlStatusGraphics.Items.Add("VarianceArrow", PivotKPIGraphic.VarianceArrow)
		ddlStatusGraphics.Items.Add("ReversedCylinder", PivotKPIGraphic.ReversedCylinder)
		ddlStatusGraphics.Items.Add("ReversedGauge", PivotKPIGraphic.ReversedGauge)
		ddlStatusGraphics.Items.Add("ReversedThermometer", PivotKPIGraphic.ReversedThermometer)
		ddlStatusGraphics.SelectedIndex = 1

		ddlTrendGraphics.Items.Clear()
		ddlTrendGraphics.Items.Add("None", PivotKPIGraphic.None)
		ddlTrendGraphics.Items.Add("ServerDefined", PivotKPIGraphic.ServerDefined)
		ddlTrendGraphics.Items.Add("StandardArrow", PivotKPIGraphic.StandardArrow)
		ddlTrendGraphics.Items.Add("StatusArrow", PivotKPIGraphic.StatusArrow)
		ddlTrendGraphics.Items.Add("ReversedStatusArrow", PivotKPIGraphic.ReversedStatusArrow)
		ddlTrendGraphics.Items.Add("Faces", PivotKPIGraphic.Faces)
		ddlTrendGraphics.SelectedIndex = 1
	End Sub
	Protected Sub ddlStatusGraphics_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.Fields("fieldStatus").KPIGraphic = CType(System.Enum.Parse(GetType(PivotKPIGraphic), ddlStatusGraphics.SelectedItem.Text), PivotKPIGraphic)
	End Sub
	Protected Sub ddlTrendGraphics_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		pivotGrid.Fields("fieldTrend").KPIGraphic = CType(System.Enum.Parse(GetType(PivotKPIGraphic), ddlTrendGraphics.SelectedItem.Text), PivotKPIGraphic)
	End Sub
End Class
