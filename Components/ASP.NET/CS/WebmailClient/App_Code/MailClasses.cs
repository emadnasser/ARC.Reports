using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using DevExpress.Data.Filtering;

public static class QueryableExtensions {
    public static IQueryable<Message> ConvertToMessages(this IQueryable<DBMessage> source) {
        return source.Select(x => new Message {
            Date = x.Date,
            Folder = x.Folder,
            From = x.From,
            HasAttachment = x.HasAttachment,
            ID = x.ID,
            IsReply = x.IsReply,
            Subject = x.Subject,
            Text = x.Text,
            To = x.To,
            Unread = x.Unread
        });
    }
    public static IQueryable<Contact> ConvertToContacts(this IQueryable<DBContact> source) {
        return source.Select(x => new Contact {
            Address = x.Address,
            City = x.City,
            Collected = x.Collected,
            Country = x.Country,
            Email = x.Email,
            ID = x.ID,
            Name = x.Name,
            Phone = x.Phone,
            PhotoUrl = x.PhotoUrl
        });
    }
}

public class GetAddressFunction : ICustomFunctionOperator {
    static readonly GetAddressFunction instance = new GetAddressFunction();
    public static void Register() {
        CriteriaOperator.RegisterCustomFunction(instance);
    }
    public static bool Unregister() {
        return CriteriaOperator.UnregisterCustomFunction(instance);
    }
    Type ICustomFunctionOperator.ResultType(params Type[] operands) { return typeof(string); }
    object ICustomFunctionOperator.Evaluate(params object[] operands) {
        return string.Join(", ", operands.Where(x => !string.IsNullOrEmpty(x as string)));
    }
    string ICustomFunctionOperator.Name { get { return "GetAddress"; } }
}

public class Message {
    DateTime _date;
    string _to;

    public int ID { get; set; }
    public string Subject { get; set; }
    public DateTime Date { get { return _date; } set { _date = value; } }
    public string From { get; set; }
    public string To { get { return _to; } set { _to = value; } }
    public string Text { get; set; }
    public string Folder { get; set; }
    public bool HasAttachment { get; set; }
    public bool IsReply { get; set; }
    public bool Unread { get; set; }
}

public class Contact {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string PhotoUrl { get; set; }
    public bool Collected { get; set; }
}

public static class DemoModel {
    static DataProviderBase currentDataProvider;
    public static DataProviderBase DataProvider {
        get {
            if(currentDataProvider == null)
                currentDataProvider = CreateDataProvider();
            return currentDataProvider;
        }
    }
    static DataProviderBase CreateDataProvider() {
        if(Utils.IsSiteMode)
            return new SiteModeDataProvider();
        return new DBDataProvider();
    }
}

public abstract class DataProviderBase {
    public static string NoUpdateContactPhoto = "NoUpdateContactPhoto";
    public abstract IEnumerable<Message> Messages { get; }
    public abstract IEnumerable<Message> UnreadMessages { get; }
    public abstract IEnumerable<Contact> Contacts { get; }

    public abstract void AddMessage(string subject, string to, string text, string folder);
    public abstract void UpdateMessage(int id, string subject, string to, string text, string folder);
    public abstract void MarkMessagesAs(bool read, IEnumerable<int> ids);
    public abstract void DeleteMessages(IEnumerable<int> ids);

    public abstract void AddContact(string name, string email, string address, string country, string city, string phone, string photoUrl);
    public abstract void UpdateContact(int id, string name, string email, string address, string country, string city, string phone, string photoUrl);
    public abstract void DeleteContact(int id);
}

public class DBDataProvider : DataProviderBase {
    public override IEnumerable<Message> Messages { get { return GetDataContext().DBMessages.ConvertToMessages(); } }
    public override IEnumerable<Message> UnreadMessages { get { return Messages.Where(m => m.Unread); } }
    public override IEnumerable<Contact> Contacts { get { return GetDataContext().DBContacts.ConvertToContacts(); } }

    protected WebmailClientDataContext GetDataContext() {
        return new WebmailClientDataContextExt();
    }

    public override void AddMessage(string subject, string to, string text, string folder) {
        var context = GetDataContext();
        context.DBMessages.InsertOnSubmit(new DBMessage() {
            Date = DateTime.Now,
            Subject = subject,
            From = Utils.ThomasEmail,
            To = to,
            Text = text,
            Folder = folder
        });
        context.SubmitChanges();
    }

    
    public override void UpdateMessage(int id, string subject, string to, string text, string folder) {
        var context = GetDataContext();
        var m = context.DBMessages.FirstOrDefault(i => i.ID == id);
        if(m == null)
            return;
        m.Date = DateTime.Now;
        m.Subject = subject;
        m.From = Utils.ThomasEmail;
        m.To = to;
        m.Text = text;
        m.Folder = folder;
        context.SubmitChanges();
    }
    public override void MarkMessagesAs(bool read, IEnumerable<int> ids) {
        var context = GetDataContext();
        foreach(var m in context.DBMessages.Where(i => ids.Contains(i.ID)))
            m.Unread = !read;
#pragma warning disable 168
        try {
            context.SubmitChanges();
        } catch(ChangeConflictException e) { }
#pragma warning restore 168
    }
    public override void DeleteMessages(IEnumerable<int> ids) {
        var context = GetDataContext();
        context.DBMessages.DeleteAllOnSubmit(context.DBMessages.Where(i => ids.Contains(i.ID)));
        context.SubmitChanges();
    }
    public override void AddContact(string name, string email, string address, string country, string city, string phone, string photoUrl) {
        var context = GetDataContext();
        context.DBContacts.InsertOnSubmit(new DBContact() {
            Name = name,
            Email = email,
            Address = address,
            Country = country,
            City = city,
            Phone = phone,
            PhotoUrl = photoUrl
        });
        context.SubmitChanges();
    }
    public override void UpdateContact(int id, string name, string email, string address, string country, string city, string phone, string photoUrl) {
        var context = GetDataContext();
        var c = context.DBContacts.FirstOrDefault(i => i.ID == id);
        if(c == null)
            return;
        c.Name = name;
        c.Email = email;
        c.Address = address;
        c.Country = country;
        c.City = city;
        c.Phone = phone;
        if(photoUrl != DataProviderBase.NoUpdateContactPhoto)
            c.PhotoUrl = photoUrl;
        context.SubmitChanges();
    }
    public override void DeleteContact(int id) {
        var context = GetDataContext();
        var c = context.DBContacts.FirstOrDefault(i => i.ID == id);
        if(c == null)
            return;
        context.DBContacts.DeleteOnSubmit(c);
        context.SubmitChanges();
    }
}

public class SiteModeDataProvider : DataProviderBase {
    const string MessagesContextKey = "65F741CC-9222-4DA5-AD98-1BD9124E54AF";
    const string ContactsContextKey = "1ADB0A67-3343-4D6D-90A3-780448DC747E";

    protected static List<Message> DBMessages = CreateDBMessageList();
    protected static List<Contact> DBContacts = CreateDBContactList();

    public SiteModeDataProvider() {
        Utils.StartClearExpiredFilesBackgroundThread();
    }

    HttpContext Context { get { return HttpContext.Current; } }
    HttpSessionState Session { get { return Context.Session; } }

    protected List<Message> SessionMessages {
        get {
            var key = "07A5E5BF-4C38-4C6C-A324-B81D24730AAD";
            if(Session[key] == null)
                Session[key] = new List<Message>();
            return (List<Message>)Session[key];
        }
    }
    protected List<int> DeletedDBMessagesKeys {
        get {
            var key = "4200605D-F2A3-4192-90CC-F11E739654FC";
            if(Session[key] == null)
                Session[key] = new List<int>();
            return (List<int>)Session[key];
        }
    }
    protected List<int> UnreadMessagesKeys {
        get {
            var key = "7B2D4B7E-5A7B-457B-B9D5-6821F55DE59E";
            if(Session[key] == null)
                Session[key] = DBMessages.Where(m => m.Unread).Select(i => i.ID).ToList();
            return (List<int>)Session[key];
        }
    }
    protected List<Contact> SessionContacts {
        get {
            var key = "068191AC-A820-483E-B450-8AD9DD1A51A7";
            if(Session[key] == null)
                Session[key] = new List<Contact>();
            return (List<Contact>)Session[key];
        }
    }
    protected List<int> DeletedDBContactsKeys {
        get {
            var key = "07B7041A-9416-4267-B9DB-BF53FAB64D3C";
            if(Session[key] == null)
                Session[key] = new List<int>();
            return (List<int>)Session[key];
        }
    }

    public override IEnumerable<Message> Messages {
        get {
            if(Context.Items[MessagesContextKey] == null)
                Context.Items[MessagesContextKey] = LoadMessages();
            return (IEnumerable<Message>)Context.Items[MessagesContextKey];
        }
    }
    public override IEnumerable<Message> UnreadMessages {
        get { return Messages.Where(m => UnreadMessagesKeys.Contains(m.ID)); }
    }
    public override IEnumerable<Contact> Contacts { 
        get {
            if(Context.Items[ContactsContextKey] == null)
                Context.Items[ContactsContextKey] = LoadContacts();
            return (IEnumerable<Contact>)Context.Items[ContactsContextKey];
        } 
    }

    protected void ForceReloadMessages() {
        Context.Items[MessagesContextKey] = null;
    }

    protected void ForceReloadContacts() {
        Context.Items[ContactsContextKey] = null;
    }

    protected List<Message> LoadMessages() {
        var list = DBMessages.Where(dbM => 
            !SessionMessages.Any(m => m.ID == dbM.ID) && !DeletedDBMessagesKeys.Contains(dbM.ID)
        ).ToList();
        list.AddRange(SessionMessages);
        return list;
    }
    protected List<Contact> LoadContacts() {
        var list = DBContacts.Where(dbC =>
            !SessionContacts.Any(c => c.ID == dbC.ID) && !DeletedDBContactsKeys.Contains(dbC.ID)
        ).ToList();
        list.AddRange(SessionContacts);
        return list;
    }

    public override void AddMessage(string subject, string to, string text, string folder) {
        SessionMessages.Add(new Message() {
            ID = Math.Max(DBMessages.Max(m => m.ID), Messages.Max(m => m.ID)) + 1,
            Date = DateTime.Now,
            Subject = subject,
            From = Utils.ThomasEmail,
            To = to,
            Text = text,
            Folder = folder
        });
        ForceReloadMessages();
    }

    public override void UpdateMessage(int id, string subject, string to, string text, string folder) {
        var m = SessionMessages.FirstOrDefault(i => i.ID == id);
        var dbM = DBMessages.FirstOrDefault(i => i.ID == id);

        if(m == null && dbM != null) {
            m = CloneMessage(dbM);
            SessionMessages.Add(m);
        }
        if(m != null) {
            m.Date = DateTime.Now;
            m.Subject = subject;
            m.From = Utils.ThomasEmail;
            m.To = to;
            m.Text = text;
            m.Folder = folder;
            ForceReloadMessages();
        }
    }

    public override void MarkMessagesAs(bool read, IEnumerable<int> ids) {
        foreach(var id in ids) {
            var contains = UnreadMessagesKeys.Contains(id);
            if(read && contains)
                UnreadMessagesKeys.Remove(id);
            else if(!read && !contains)
                UnreadMessagesKeys.Add(id);
        }
    }

    public override void DeleteMessages(IEnumerable<int> ids) {
        foreach(var id in ids) {
            var sessionMessage = SessionMessages.FirstOrDefault(m => m.ID == id);
            if(sessionMessage != null)
                SessionMessages.Remove(sessionMessage);
            else
                DeletedDBMessagesKeys.Add(id);
        }
        MarkMessagesAs(true, ids);
        ForceReloadMessages();
    }

    public override void AddContact(string name, string email, string address, string country, string city, string phone, string photoUrl) {
        SessionContacts.Add(new Contact() {
            ID = Math.Max(DBContacts.Max(c => c.ID), Contacts.Max(c => c.ID)) + 1,
            Name = name,
            Email = email,
            Address = address,
            Country = country,
            City = city,
            Phone = phone,
            PhotoUrl = photoUrl
        });
        ForceReloadContacts();

    }

    public override void UpdateContact(int id, string name, string email, string address, string country, string city, string phone, string photoUrl) {
        var c = SessionContacts.FirstOrDefault(i => i.ID == id);
        var dbC = DBContacts.FirstOrDefault(i => i.ID == id);

        if(c == null && dbC != null) {
            c = CloneContact(dbC);
            SessionContacts.Add(c);
        }
        if(c != null) {
            c.Name = name;
            c.Email = email;
            c.Address = address;
            c.Country = country;
            c.City = city;
            c.Phone = phone;
            if(photoUrl != DataProviderBase.NoUpdateContactPhoto)
                c.PhotoUrl = photoUrl;
            ForceReloadContacts();
        }
    }

    public override void DeleteContact(int id) {
        var sessionContact = SessionContacts.FirstOrDefault(c => c.ID == id);
        if(sessionContact != null)
            SessionContacts.Remove(sessionContact);
        DeletedDBContactsKeys.Add(id);
        ForceReloadContacts();
    }

    static List<Message> CreateDBMessageList() {
        return new WebmailClientDataContextExt().DBMessages.ConvertToMessages().ToList();
    }
    static List<Contact> CreateDBContactList() {
        return new WebmailClientDataContextExt().DBContacts.ConvertToContacts().ToList();
    }

    static Message CloneMessage(Message source) {
        return new Message() {
            ID = source.ID,
            Subject = source.Subject,
            Date = source.Date,
            From = source.From,
            To = source.To,
            Text = source.Text,
            Folder = source.Folder,
            HasAttachment = source.HasAttachment,
            IsReply = source.IsReply,
            Unread = source.Unread
        };
    }
    static Contact CloneContact(Contact source) {
        return new Contact() {
            ID = source.ID,
            Name = source.Name,
            Email = source.Email,
            Address = source.Address,
            Country = source.Country,
            City = source.City,
            Phone = source.Phone,
            PhotoUrl = source.PhotoUrl,
            Collected = source.Collected
        };
    }
}

