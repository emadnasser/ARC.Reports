using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PrintMails : System.Web.UI.Page {
    protected void Page_PreInit(object sender, EventArgs e) {
        Utils.ApplyTheme(this);
    }

    protected void Page_Load(object sender, EventArgs e) {
        var messages = DemoModel.DataProvider.Messages.Where(m => m.Folder != "Sent Items" && m.Folder != "Drafts").Select(m => new {
            From = m.From,
            Subject = m.Subject,
            Date = m.Date.ToShortDateString()
        });

        MailReportViewer.Report = new MailReport(messages);
    }
}
