using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxPivotGrid;

public partial class UserControls_ProductsPivotGrid : ViewUserControl {
    protected void Page_Load(object sender, EventArgs e) {
        PivotGrid.CellTemplate = new CellTemplate();
        PivotGrid.Fields["State"].ValueTemplate = new StateFieldValueTemplate();

        ApplyFilter();
        if(!IsPostBack)
            PivotGrid.CollapseAll();
    }
    protected void ApplyFilter() {
        if(OwnerPage != null)
            PivotGrid.Prefilter.CriteriaString = Filter.GetExpression(false);
    }

    public override long SelectedItemID { get { return DataProvider.emptyEntryID; } set { } }
    public override void Update() {
        ApplyFilter();
    }

    protected void SalesDataSource_Selecting(object sender, DevExpress.Data.Linq.LinqServerModeDataSourceSelectEventArgs e) {
        e.KeyExpression = "Id";
        e.QueryableSource = DataProvider.OrderItems;
    }

    class StateFieldValueTemplate : ITemplate {
        void ITemplate.InstantiateIn(Control container) {
            var templateContainer = (PivotGridFieldValueTemplateContainer)container;
            var cell = templateContainer.CreateFieldValue();
            templateContainer.Controls.Add(cell);

            var stateDisplayName = DemoUtils.GetStateDisplayName(templateContainer.Text);
            if(!string.IsNullOrEmpty(stateDisplayName))
                cell.TextControl.Text = stateDisplayName;
        }
    }
    class CellTemplate : ITemplate {
        void ITemplate.InstantiateIn(Control container) {
            var cellContainer = (PivotGridCellTemplateContainer)container;
            var field = cellContainer.DataField;
            if(field == null || field.Caption != "Percentage") {
                cellContainer.Controls.Add(new LiteralControl(cellContainer.Text));
                return;
            }
            var table = new Table() { CssClass = "progressBarTable" };
            cellContainer.Controls.Add(table);
            var row = new TableRow();
            table.Rows.Add(row);

            var cell = new TableCell() { CssClass = "progressBarCell" };
            row.Cells.Add(cell);

            var val = Convert.ToDecimal(cellContainer.Value) * 100;
            cell.Controls.Add(new ASPxProgressBar() {
                Width = Unit.Percentage(100),
                Height = 10,
                Value = val,
                ShowPosition = false
            });

            cell = new TableCell() { CssClass = "progressValueCell", Text = string.Format("{0:N}%", val) };
            row.Cells.Add(cell);
        }
    }
}
