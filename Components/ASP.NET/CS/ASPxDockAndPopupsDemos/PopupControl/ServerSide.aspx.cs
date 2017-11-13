using System;
using System.Web.UI;
using DevExpress.Web;

public partial class PopupControl_ServerSide : Page {
    const string WindowText = "[Enter some text here and then press the Create Note button]";

    int StartLeft {
        set { ViewState["StartLeft"] = value; }
        get { return ViewState["StartLeft"] != null ? (int)ViewState["StartLeft"] : 650; }
    }
    int StartTop {
        set { ViewState["StartTop"] = value; }
        get { return ViewState["StartTop"] != null ? (int)ViewState["StartTop"] : 270; }
    }

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void Button1_Click(object sender, EventArgs e) {
        PopupWindow pcWindow = new PopupWindow(ASPxMemo1.Text);
        pcWindow.FooterText = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        pcWindow.ShowOnPageLoad = true;
        pcWindow.Left = StartLeft;
        pcWindow.Top = StartTop;
        StartLeft += 20;
        StartTop += 20;
        ASPxPopupControl1.Windows.Add(pcWindow);
        ASPxMemo1.Text = WindowText;
        ASPxMemo1.Style[HtmlTextWriterStyle.Color] = "gray";
    }

    protected void hlClearAllNotes_Click(object sender, EventArgs e) {
        ASPxPopupControl1.Windows.Clear();
        StartLeft = 650;
        StartTop = 270;
    }
}
