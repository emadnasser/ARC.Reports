using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    public class OutlookData {
        public static Random rnd = new Random();
        internal static string[] users = new string[] {"Peter Dolan", "Ryan Fischer", "Richard Fisher",
												 "Tom Hamlett", "Mark Hamilton", "Steve Lee", "Jimmy Lewis", "Jeffrey W McClain",
												 "Andrew Miller", "Dave Murrel", "Bert Parkins", "Mike Roller", "Ray Shipman",
												 "Paul Bailey", "Brad Barnes", "Carl Lucas", "Jerry Campbell"};
        static string[] subject = new string[] { "Integrating DevExpress MasterView control into an Accounting System.",
                                                "Web Edition: Data Entry Page. There is an issue with date validation.",
                                                "Payables Due Calculator is ready for testing.",
                                                "Web Edition: Search Page is ready for testing.",
                                                "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.",
                                                "Receivables Calculator. Where can I find the complete specs?",
                                                "Ledger: Inconsistency. Please fix it.",
                                                "Receivables Printing module is ready for testing.",
                                                "Screen Redraw. Somebody has to look at it.",
                                                "Email System. What library are we going to use?",
                                                "Cannot add new vendor. This module doesn't work!",
                                                "History. Will we track sales history in our system?",
                                                "Main Menu: Add a File menu. File menu item is missing.",
                                                "Currency Mask. The current currency mask in completely unusable.",
                                                "Drag & Drop operations are not available in the scheduler module.",
                                                "Data Import. What database types will we support?",
                                                "Reports. The list of incomplete reports.",
                                                "Data Archiving. We still don't have this features in our application.",
                                                "Email Attachments. Is it possible to add multiple attachments? I haven't found a way to do this.",
                                                "Check Register. We are using different paths for different modules.",
                                                "Data Export. Our customers asked us for export to Microsoft Excel"};

        static int GetImportance(int num) {
            int ret = rnd.Next(num);
            if(ret > 2) ret = 1;
            return ret;
        }

        static int GetIcon() {
            int ret = rnd.Next(10);
            ret = ret > 2 ? 1 : 0;
            return ret;
        }

        static int GetAttach() {
            int ret = rnd.Next(10);
            ret = ret > 5 ? 1 : 0;
            return ret;
        }

        static DateTime GetSent() {
            DateTime ret = DateTime.Now;
            int r = rnd.Next(12);
            if(r > 1) ret = ret.AddDays(-rnd.Next(50));
            ret = ret.AddMinutes(-rnd.Next(ret.Minute + ret.Hour * 60 + 360));
            return ret;
        }

        static DateTime GetReceived(DateTime sent) {
            DateTime dt = sent.AddMinutes(10 + rnd.Next(120));
            if(dt > DateTime.Now) dt = DateTime.Now.AddMinutes(-1);
            return dt;
        }

        static string GetSubject() {
            return subject[rnd.Next(subject.Length - 1)];
        }

        public static string GetFrom() {
            return users[rnd.Next(users.Length - 2)];
        }

        static string GetTo() {
            return users[users.Length - 1];
        }

        static DateTime GetSentDate() {
            DateTime ret = DateTime.Today;
            int r = rnd.Next(12);
            if(r > 1) ret = ret.AddDays(-rnd.Next(50));
            return ret;
        }

        public static DateTime GetDueDate() {
            DateTime ret = DateTime.Today;
            ret = ret.AddDays(60 + rnd.Next(50));
            return ret;
        }

        static int GetSize(bool largeData) {
            return 1000 + (largeData ? 20 * rnd.Next(10000) : 30 * rnd.Next(100));
        }
        static bool GetHasAttachment() {
            return rnd.Next(10) > 5;
        }

        public static DataTable CreateDataTable() {
            return CreateDataTable(7);
        }
        public static object[] CreateMailRow(int num, bool realTime) {
            DateTime sent = GetSent();
            return new object[] { GetImportance(num), GetAttach(), realTime ? 0 : GetIcon(), GetIcon(), GetSubject(), GetFrom(), GetTo(), sent, realTime ? DateTime.Now : GetReceived(sent) };
        }
        public static DataTable CreateDataTable(int num) {
            DataTable tbl = new DataTable("Outlook");
            tbl.Columns.Add("Priority", typeof(int));
            tbl.Columns.Add("Attachment", typeof(int));
            tbl.Columns.Add("Read", typeof(int));
            tbl.Columns.Add("Flag", typeof(int));
            tbl.Columns.Add("Subject", typeof(string));
            tbl.Columns.Add("From", typeof(string));
            tbl.Columns.Add("To", typeof(string));
            tbl.Columns.Add("Sent", typeof(DateTime));
            tbl.Columns.Add("Received", typeof(DateTime));
            for(int i = 0; i < 80; i++) {
                tbl.Rows.Add(CreateMailRow(num, false));
            }
            return tbl;
        }
        public static DataTable CreateIssueList() {
            DataTable tbl = new DataTable();
            tbl = new DataTable("IssueList");
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Subject", typeof(string));
            tbl.Columns.Add("Implemented", typeof(int));
            tbl.Columns.Add("Suspended", typeof(bool));
            for(int i = 1; i <= subject.Length; i++) {
                tbl.Rows.Add(new object[] { i, subject.GetValue(i - 1), rnd.Next(100), rnd.Next(10) > 8 });
            }
            return tbl;
        }
    }
}
