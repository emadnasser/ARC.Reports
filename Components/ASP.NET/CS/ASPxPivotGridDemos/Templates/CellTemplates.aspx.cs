using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxPivotGrid;
using System.Drawing;
using DevExpress.XtraPivotGrid;

public partial class Appearance_CellTemplate : Page {
    protected void Page_Load(object sender, EventArgs e) {
        pivotGrid.CellTemplate = new CellTemplate();
    }
    class CellTemplate : ITemplate {

        void ITemplate.InstantiateIn(Control container) {
            PivotGridCellTemplateContainer templateContainer = (PivotGridCellTemplateContainer)container;
            DevExpress.Web.ASPxPivotGrid.PivotGridField field = templateContainer.DataField;

            if(field != null && field.Caption == "Percents") {
                int value = Convert.ToInt32(Convert.ToDecimal(templateContainer.Value) * 350);

                Table table = new Table();
                table.Width = Unit.Pixel(400);
                templateContainer.Controls.Add(table);

                TableRow row = new TableRow();
                table.Controls.Add(row);

                TableCell cell = new TableCell();
                cell.Style.Add(HtmlTextWriterStyle.Padding, "0px");
                cell.Width = Unit.Pixel(value);
                cell.Height = Unit.Pixel(20);
                if(templateContainer.Item.RowValueType == PivotGridValueType.Total)
                    cell.BackColor = Color.FromArgb(148, 184, 243);
                else
                    cell.BackColor = Color.FromArgb(243, 148, 164);
                if(templateContainer.Item.RowValueType == PivotGridValueType.GrandTotal)
                    cell.BackColor = Color.FromArgb(134, 206, 128);
                row.Controls.Add(cell);

                cell = new TableCell();
                cell.Text = templateContainer.Item.Text;
                cell.Wrap = false;
                row.Controls.Add(cell);
            } else {
                templateContainer.Controls.Add(new LiteralControl(templateContainer.Text));
            }
        }
    }
}
