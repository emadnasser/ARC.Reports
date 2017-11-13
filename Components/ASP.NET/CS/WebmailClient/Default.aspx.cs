using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Data.Filtering;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    const string
        PreviewMessageFormat = 
            "<div class='MailPreview'>" +
                "<div class='Subject'>{0}</div>" +
                "<div class='Info'>" +
                    "<div>From: {1}</div>" +
                    "<div>To: {2}</div>" +
                    "<div>Date: {3:g}</div>" +
                "</div>" +
                "<div class='Separator'></div>" +
                "<div class='Body'>{4}</div>" +
            "</div>",
        ReplyMessageFormat = "Hi,<br/><br/><br/><br/>Thanks,<br/>Thomas Hardy<br/><br/><br/>----- Original Message -----<br/>Subject: {0}<br/>From: {1}<br/>To: {2}<br/>Date: {3:g}<br/>{4}",
        NotFoundMessageFormat = "<h1>Can't find message with the key={0}</h1>";

    protected string SearchText { get { return Utils.GetSearchText(this); } }

    protected void Page_PreInit(object sender, EventArgs e) {
        Utils.ApplyTheme(this);
    }

    protected void Page_Init(object sender, EventArgs e) {
        if(!IsPostBack)
            CheckMailTreeSelectedNode();
    }

    protected void Page_Load(object s, EventArgs e) {
        CheckMailTreeSelectedNode();
        if(ShouldBindGrid())
            BindGrid();
        if(MailFormPanel.IsCallback || IsPostBack && !IsCallback) {
            AddressesList.DataSource = DemoModel.DataProvider.Contacts.Select(c => new {
                Text = c.Name,
                Value = c.Email,
                ImageUrl = Utils.GetContactPhotoUrl(c.PhotoUrl)
            });
            AddressesList.DataBind();
        }

        MailGrid.DataColumns["To"].Visible = ShowToColumn();
        MailGrid.DataColumns["From"].Visible = !ShowToColumn();
        if(Utils.CurrentTheme == "iOS")
            MailGrid.Columns[0].Width = Unit.Pixel(77);
        if(Utils.CurrentTheme == "Material")
            MailGrid.Columns[0].Width = Unit.Pixel(65);
    }

    void BindGrid() {
        MailGrid.DataSource = SelectMessages();
        MailGrid.DataBind();
    }

    bool ShouldBindGrid() {
        return !IsCallback || MailGrid.IsCallback;
    }

    protected bool ShowToColumn() {
        return MailTree.SelectedNode.Name == "Sent Items" || MailTree.SelectedNode.Name == "Drafts";
    }

    protected void MailPreviewPanel_Callback(object sender, CallbackEventArgsBase e) {
        int id;
        var text = string.Format(NotFoundMessageFormat, e.Parameter);
        if(int.TryParse(e.Parameter, out id)) {
            var message = DemoModel.DataProvider.Messages.FirstOrDefault(m => m.ID == id);
            if(message != null) {
                DemoModel.DataProvider.MarkMessagesAs(true, new int[] { id });
                var subject = message.Subject;
                if(message.IsReply)
                    subject = "Re: " + subject;
                text = string.Format(PreviewMessageFormat, subject, message.From, message.To, message.Date, message.Text);
            }
        }
        MailPreviewPanel.Controls.Add(new LiteralControl(text));
    }

    protected void MailGrid_CustomDataCallback(object sender, ASPxGridViewCustomDataCallbackEventArgs e) {
        var args = e.Parameters.Split('|');
        if(args[0] == "MailForm" && args[1] == "Reply" && args.Length == 3) {
            int id;
            if(!int.TryParse(args[2], out id))
                return;
            var message = DemoModel.DataProvider.Messages.FirstOrDefault(m => m.ID == id);
            if(message == null)
                return;
            var result = new Dictionary<string, string>();
            result["To"] = message.To;

            var subject = message.Subject;
            if(!subject.StartsWith("Re: "))
                subject = "Re: " + subject;
            result["Subject"] = subject;

            result["Text"] = FormatMessageCore(message, ReplyMessageFormat);
            e.Result = result;
        }
        if(args[0] == "MailForm" && args.Length == 3 && args[1] == "EditDraft") {
            int id;
            if(!int.TryParse(args[2], out id))
                return;
            var message = DemoModel.DataProvider.Messages.FirstOrDefault(m => m.ID == id);
            if(message == null)
                return;
            var result = new Dictionary<string, string>();
            result["To"] = message.To;
            result["Subject"] = message.Subject;
            result["Text"] = message.Text;
            e.Result = result;
        }
        if(args[0] == "MarkAs" && args.Length > 2) {
            var read = args[1] == "Read";
            int[] keys = null;
            if(!TryParseKeyValues(args.Skip(2), out keys))
                return;
            DemoModel.DataProvider.MarkMessagesAs(read, keys);
        }
    }

    protected void MailGrid_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        if(string.IsNullOrEmpty(e.Parameters))
            return;
        var args = e.Parameters.Split('|');
        if(args[0] == "FolderChanged" || args[0] == "Search") {
            string filter = args[0] == "Search" ? SearchText : string.Empty;
            MailGrid.SearchPanelFilter = filter;
            BindGrid();
            MailGrid.ExpandAll();
        }
        if(args[0] == "SendMail" || args[0] == "SaveMail") {
            var subject = SubjectEditor.Text;
            var to = ToEditor.Text;
            string messageText = MailEditor.Html.Length <= 10000 ? MailEditor.Html : MailEditor.Html.Substring(0, 10000);
            string folder = args[0] == "SendMail" ? "Sent Items" : "Drafts";
            int id;
            if(args.Length == 2 && int.TryParse(args[1], out id))
                DemoModel.DataProvider.UpdateMessage(id, subject, to, messageText, folder);
            else
                DemoModel.DataProvider.AddMessage(subject, to, messageText, folder);
            BindGrid();
        }
        if(args[0] == "Delete" && args.Length > 1) {
            int[] keys = null;
            if(!TryParseKeyValues(args.Skip(1), out keys))
                return;
            DemoModel.DataProvider.DeleteMessages(keys);
            BindGrid();
        }
    }

    protected void MailGrid_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        if(MailTree.SelectedNode.Name == "Inbox") {
            var list = new List<Message>();
            for(var i = 0; i < MailGrid.VisibleRowCount; i++) { 
                if(MailGrid.IsGroupRow(i)) continue;
                var message = MailGrid.GetRow(i) as Message;
                if(message != null)
                    list.Add(message);
            }
            e.Properties["cpVisibleMailKeysHash"] = GetMessagesKeyMap(list);
        }
    }

    protected void MailTree_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        e.Properties["cpUnreadMessagesHash"] = GetMessagesKeyMap(DemoModel.DataProvider.UnreadMessages);
    }

    protected void MailGrid_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if(e.Column.FieldName == "Subject" && (bool)e.GetFieldValue("IsReply"))
            e.DisplayText = string.Format("Re: {0}", e.Value);
        if(e.Column.FieldName == "To") {
            var list = new List<string>();
            foreach(var item in e.Value.ToString().Split(',')) {
                var email = item.Trim();
                var contact = DemoModel.DataProvider.Contacts.FirstOrDefault(c => c.Email == email);
                list.Add(contact != null ? contact.Name : email);
            }
            e.DisplayText = string.Join(", ", list);
        }
        if(e.Column.FieldName == "From") {
            var from = e.Value.ToString();
            var contact = DemoModel.DataProvider.Contacts.FirstOrDefault(c => c.Email == from);
            e.DisplayText = contact != null ? contact.Name : from;
        }
    }

    protected void MailGrid_CustomGroupDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if(e.Column.FieldName == "Subject")
            e.DisplayText = HttpUtility.HtmlEncode(e.Value);
    }

    List<Message> SelectMessages() {
        var result = DemoModel.DataProvider.Messages.AsQueryable();
        if(MailTree.SelectedNode.Text == "Inbox")
            result = result.Where(m => m.Folder != "Sent Items" && m.Folder != "Drafts");
        else
            result = result.Where(m => m.Folder == MailTree.SelectedNode.Text);
        return result.ToList();
    }

    string FormatMessageCore(Message message, string format) {
        var subject = message.Subject;
        if(message.IsReply)
            subject = "Re: " + subject;
        return string.Format(format, subject, message.From, message.To, message.Date, message.Text);
    }

    void CheckMailTreeSelectedNode() {
        if(MailTree.SelectedNode == null)
            MailTree.SelectedNode = MailTree.Nodes.FindByText("Inbox");
    }

    protected bool TryParseKeyValues(IEnumerable<string> stringKeys, out int[] resultKeys) {
        resultKeys = null;
        var list = new List<int>();
        foreach(var sKey in stringKeys) {
            int key;
            if(!int.TryParse(sKey, out key))
                return false;
            list.Add(key);
        }
        resultKeys = list.ToArray();
        return true;
    }

    Dictionary<string, List<string>> GetMessagesKeyMap(IEnumerable<Message> messages) {
        var dict = new Dictionary<string, List<string>>();
        var query = messages.GroupBy(m => m.Folder).Where(g => g.Count() > 0);
        foreach(var item in messages.GroupBy(m => m.Folder).Where(g => g.Count() > 0))
            dict.Add(item.Key, item.Select(m => m.ID.ToString()).ToList());
        return dict;
    }
}
