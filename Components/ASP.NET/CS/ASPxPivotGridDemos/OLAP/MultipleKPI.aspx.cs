using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.XtraPivotGrid;

public partial class OLAP_MultipleKPI : Page {
	protected void Page_Load(object sender, EventArgs e) {
        string error = OLAPConnector.TryConnect(ASPxPivotGrid1);
        if(string.IsNullOrEmpty(error)) {
            Table kpiTable = new Table();
            kpiTable.Width = new Unit(520);
            List<string> kpis = ASPxPivotGrid1.GetOLAPKPIList();
            foreach(string kpi in kpis) {
                PivotOLAPKPIValue kpiValue = ASPxPivotGrid1.GetOLAPKPIValue(kpi);

                TableRow row = new TableRow();

                TableCell name = new TableCell();
                name.Text = kpi;
                name.Width = new Unit(200);
                row.Cells.Add(name);

                TableCell value = new TableCell();
                value.Text = string.Format("{0:c}", kpiValue.Value);
                value.Width = new Unit(110);
                value.HorizontalAlign = HorizontalAlign.Right;
                row.Cells.Add(value);

                TableCell goal = new TableCell();
                goal.Text = string.Format("{0:c}", kpiValue.Goal);
                goal.Width = new Unit(110);
                goal.HorizontalAlign = HorizontalAlign.Right;
                row.Cells.Add(goal);

                TableCell status = new TableCell();
                status.Controls.Add(GetKPIImage(kpi, PivotKPIType.Status, kpiValue.Status));
                status.Width = new Unit(50);
                status.HorizontalAlign = HorizontalAlign.Center;
                row.Cells.Add(status);

                TableCell trend = new TableCell();
                trend.Controls.Add(GetKPIImage(kpi, PivotKPIType.Trend, kpiValue.Trend));
                trend.Width = new Unit(50);
                trend.HorizontalAlign = HorizontalAlign.Center;
                row.Cells.Add(trend);

                kpiTable.Rows.Add(row);
            }
            ASPxRoundPanel1.Controls.Add(kpiTable);
            ASPxRoundPanel1.Visible = true;
        } else {
            Control errorPanel = OLAPConnector.CreateErrorPanel(error);
            ASPxPivotGrid1.Parent.Controls.AddAt(0, errorPanel);
        }
	}

	Image GetKPIImage(string kpi, PivotKPIType kpiType, int value) {
		Image image = new Image();
		PivotKPIGraphic graphic = ASPxPivotGrid1.GetOLAPKPIServerGraphic(kpi, kpiType);		
		ImageProperties imageProps = ASPxPivotGrid1.GetKPIImage(graphic, kpiType, value);
		imageProps.AssignToControl(image, false);
		return image;
	}
}
