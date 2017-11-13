using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;


public static class NewsGroupDataProvider  {
    static readonly string Key = "NewsGroupDataProvider";

	static HttpSessionState Session { get { return HttpContext.Current.Session; } }
    static List<Thread> Data {
		get {			
			if(Session[Key] == null)
				Restore();
            return (List<Thread>)Session[Key];
		}
	}	

	public static IEnumerable Select() {
		return Data;
	}

	public static void Insert(Thread item) {		
		Data.Add(item);
		item.ID = Data.Count;
	}

	public static void Update(Thread item) {
		Thread storedItem = FindItem(item.ID);
		Assign(item, storedItem);
	}

    private static void Assign(Thread source, Thread target) {
		target.ParentID = source.ParentID;
		target.From = source.From;
		target.Subject = source.Subject;
		target.Text = source.Text;
		target.DateCreated = source.DateCreated;
		target.HasAttachment = source.HasAttachment;
	}

	public static void Delete(Thread item) {
		Thread storedItem = FindItem(item.ID);
		Data.Remove(storedItem);
	}

	public static void Corrupt() {
		int count = 0;
		foreach(Thread item in Data) {
			int mod = count % 5;
			if(mod == 0)
				item.Subject = "";
			if(mod == 2)
				item.From = "";
			if(mod == 4)
				item.DateCreated = DateTime.Now.AddYears(-30 - count);
			count++;
		}
	}

	public static void Restore() {
		Session[Key] = CreateData();
	}

	static Thread FindItem(int id) {
        return Data.SingleOrDefault(t => t.ID == id);
	}

    static List<Thread> CreateData() {
        using(var context = new NewsGroupsContext())
            return context.Threads.ToList();
	}
}
