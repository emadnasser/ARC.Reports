using System;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class PopupControl_ContentUrldata2 : Page {
    const string SuccessText = "Your message has been successfully sent.";

    protected void ButtonSend_Click(object sender, EventArgs e) {
        HtmlForm form = Page.FindControl("MailForm") as HtmlForm;
        if(form != null) {
            form.Controls.Clear();
            WebControl textControl = CreateCentredText();
            textControl.ForeColor = Color.FromArgb(0, 51, 51);
            if(textControl != null)
                form.Controls.Add(textControl);
        }
    }

    protected virtual WebControl CreateCentredText() {
        Table table = new Table();
        TableRow row = new TableRow();
        TableCell cell = new TableCell();

        table.Rows.Add(row);
        row.Cells.Add(cell);
        cell.Controls.Add(new LiteralControl(string.Format("<div id=\"SuccessText\">{0}</div>", SuccessText)));

        cell.Controls.Add(new LiteralControl("&nbsp;"));

        ASPxButton buttonSendNewMsg = new ASPxButton();
        buttonSendNewMsg.ID = "ButtonSendNewMsg";
        buttonSendNewMsg.RenderMode = ButtonRenderMode.Link;
        buttonSendNewMsg.Text = "Send message";

        cell.Controls.Add(buttonSendNewMsg);

        table.Height = Unit.Percentage(100);
        table.Width = Unit.Percentage(100);
        table.BorderWidth = Unit.Pixel(0);

        cell.VerticalAlign = VerticalAlign.Middle;
        cell.HorizontalAlign = HorizontalAlign.Center;

        return table;
    }
}
