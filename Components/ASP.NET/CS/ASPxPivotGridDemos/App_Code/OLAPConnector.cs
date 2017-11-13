using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.Web;
using DevExpress.XtraPivotGrid.Data;

public class OLAPConnector {
    const string ProviderDownloadUrl = "http://www.microsoft.com/downloads/details.aspx?FamilyID=50b97994-8453-4998-8226-fa42ec403d17#ASOLEDB",
        NoProviderErrorString = "To connect to olap cubes, you should have Microsoft SQL Server 2005<br />" +
                                "Analysis Services 9.0 (or newer) OLE DB Provider installed on your system. You can get<br />" +
                                "the latest version of this provider here:<br />" +
                                "<a href=\"" + ProviderDownloadUrl + "\" target=\"_blank\">" + ProviderDownloadUrl + "</a>.",
        ExceptionErrorString = "Unfortunately, an unexpected exception was raised when trying to connect to the OLAP datasource:";

    public static string TryConnect(ASPxPivotGrid pivot) {
        if(!OLAPMetaGetter.IsProviderAvailable) {
            pivot.OLAPConnectionString = null;
            return NoProviderErrorString;
        }
        try {
            pivot.DataBind();
        } catch(OLAPConnectionException exception) {
            pivot.OLAPConnectionString = null;
            return ExceptionErrorString + "<br />" + exception.Message;
        }
        return null;
    }

    public static Control CreateErrorPanel(string error) {
        ASPxRoundPanel panel = new ASPxRoundPanel();
        panel.ShowHeader = false;
        panel.Style["margin-bottom"] = "10px";
        Table table = new Table();
        table.Rows.Add(new TableRow());
        table.Rows[0].Cells.Add(new TableCell());
        table.Rows[0].Cells.Add(new TableCell());
        panel.Controls.Add(table);
        Image errorIcon = new Image();
        errorIcon.ImageUrl = "~/Content/Demo/Error.gif";
        errorIcon.AlternateText = "Error";
        table.Rows[0].Cells[0].Controls.Add(errorIcon);
        table.Rows[0].Cells[1].Text = error;
        return panel;
    }
}
