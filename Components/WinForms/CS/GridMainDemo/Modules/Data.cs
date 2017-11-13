using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Text;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;

namespace DevExpress.XtraGrid.Demos {
    [Flags]
    public enum MailFolder { All = 0, Announcements = 1, ASP = 2, WinForms = 4, IDETools = 8, Frameworks = 16 };
    public enum MailType { Inbox, Deleted, Sent, Draft };
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

        static DateTime GetSentDateWithTime() {
            DateTime ret = DateTime.Now.AddMinutes(-rnd.Next(60, 250000));
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

        public static ServerSideGridTest CreateNewObject(UnitOfWork uow) {
            ServerSideGridTest obj = new ServerSideGridTest(uow);
            obj.Subject = GetSubject();
            obj.From = GetFrom();
            obj.Sent = GetSentDateWithTime();
            obj.HasAttachment = GetHasAttachment();
            obj.Size = GetSize(obj.HasAttachment);
            obj.Priority = GetImportance(4);
            return obj;
        }
    }
    public class GroupIntervalData {
        public static Random rnd = new Random();
        static decimal GetCount() {
            return rnd.Next(50) + 10;
        }
        static DateTime GetDate(bool range) {
            DateTime ret = DateTime.Now;
            int r = rnd.Next(20);
            if(range) {
                if(r > 1) ret = ret.AddDays(rnd.Next(80) - 40);
                if(r > 18) ret = ret.AddMonths(rnd.Next(18));
            }
            else ret = ret.AddDays(rnd.Next(r * 30) - r * 15);
            return ret;
        }
        public static DataTable CreateDataTable(int maxRows) {
            return CreateDataTable(maxRows, true);
        }
        public static DataTable CreateDataTable(int maxRows, bool range) {
            DataTable tbl = null;
            string DBFileName = string.Empty;
            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.mdb");
            if(DBFileName != string.Empty) {
                DataSet ds = new DataSet();
                string tblName = "Products";

                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " + tblName, con);
                oleDbDataAdapter.Fill(ds, tblName);

                DataTable product = ds.Tables[tblName];
                tbl = new DataTable("GroupInterval");
                tbl.Columns.Add("Product Name", typeof(string));
                tbl.Columns.Add("Category", typeof(int));
                tbl.Columns.Add("Unit Price", typeof(decimal));
                tbl.Columns.Add("Count", typeof(int));
                tbl.Columns.Add("Order Date", typeof(DateTime));
                tbl.Columns.Add("Order Sum", typeof(decimal), "[Unit Price] * [Count]");
                for(int i = 0; i < maxRows; i++) {
                    DataRow row = product.Rows[rnd.Next(product.Rows.Count - 1)];
                    tbl.Rows.Add(new object[] { row["ProductName"], row["CategoryID"], row["UnitPrice"], GetCount(), GetDate(range) });
                }
            }
            return tbl;
        }
    }
    public class MailData {
        DataRow row;
        public MailData(DataRow row) {
            this.row = row;
        }
        public DataRow Row { get { return row; } }
        public int Priority {
            get { return (int)row["Priority"]; }
            set { row["Priority"] = value; }
        }
        public int Attachment { get { return (int)row["Attachment"]; } }
        public int Read {
            get { return (int)row["Read"]; }
            set { row["Read"] = value; }
        }
        public int Flag {
            get { return (int)row["Flag"]; }
            set { row["Flag"] = value; }
        }
        public string Subject { get { return string.Format("{0}", row["Subject"]); } }
        public string From { get { return string.Format("{0}", row["From"]); } }
    }
    public class ColorsObject {
        Color fforeColor, fbackColor;
        public ColorsObject(Color fforeColor, Color fbackColor) {
            this.fforeColor = fforeColor;
            this.fbackColor = fbackColor;
        }
        public Color ForeColor { get { return fforeColor; } set { fforeColor = value; } }
        public Color BackColor { get { return fbackColor; } set { fbackColor = value; } }
    }
    public class ColorHelper {
        public static void UpdateColor(ImageList list, UserLookAndFeel lf) {
            for(int i = 0; i < list.Images.Count; i++)
                list.Images[i] = SetColor(list.Images[i] as Bitmap, GetHeaderForeColor(lf));
        }
        public static Color GetHeaderForeColor(UserLookAndFeel lf) {
            Color ret = SystemColors.ControlText;
            if(lf.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
        }
        static Bitmap SetColor(Bitmap bmp, Color color) {
            for(int i = 0; i < bmp.Width; i++)
                for(int j = 0; j < bmp.Height; j++)
                    if(bmp.GetPixel(i, j).Name != "0")
                        bmp.SetPixel(i, j, color);
            return bmp;
        }
    }
    public class LoanPayment {
        int monthNumber;
        double balance, interest, principal;
        DateTime month;
        public LoanPayment(double balance, double monthlyPayment, int month, double interestRate, DateTime startMonth) {
            this.monthNumber = month;
            this.month = startMonth.AddMonths(month - 1);
            this.interest = Trunc2(balance * interestRate);
            this.principal = Trunc2(monthlyPayment - this.interest);
            this.balance = Trunc2(balance - this.principal);
        }
        public void UpdateBalance() {
            if(this.balance < 0) this.principal += this.balance;
            this.balance = 0;
        }

        public DateTime Month { get { return month; } }
        public int MonthNumber { get { return monthNumber; } }
        public double MonthlyPayment { get { return Interest + Principal; } }
        public double Balance { get { return balance; } }
        public double Interest { get { return interest; } }
        public double Principal { get { return principal; } }
        public string MonthString { get { return string.Format("{0}<size=-2> ({1:MMMM, yyyy})", MonthNumber, Month); } }
        public static double Trunc2(double val) {
            return Convert.ToDouble(Convert.ToInt64(val * 100)) / 100;
        }
        public static List<LoanPayment> Calculate(double loanAmount, double interestRate, double months, DateTime startMonth, out double payment) {
            payment = (loanAmount * interestRate) / (1 - Math.Exp((-months) * Math.Log(1 + interestRate)));
            payment = LoanPayment.Trunc2(payment);
            List<LoanPayment> payments = new List<LoanPayment>();
            double balance = loanAmount;
            for(int i = 1; i <= months; i++) {
                LoanPayment lp = new LoanPayment(balance, payment, i, interestRate, startMonth);
                balance = lp.Balance;
                payments.Add(lp);
                if(lp.Balance <= 0) break;
            }
            payments[payments.Count - 1].UpdateBalance();
            return payments;
        }
        public static void InitStartMonth(ImageComboBoxEdit edit) {
            DateTime start = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            for(int i = 1; i < 7; i++)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0:MMMM, yyyy}", start.AddMonths(i)), start.AddMonths(i), -1));
            edit.SelectedIndex = 0;
        }
        public static void InitTermOfLoan(ImageComboBoxEdit edit) {
            int[] terms = new int[] { 5, 10, 15, 20, 25, 30 };
            foreach(int term in terms)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0} {1}", term, Properties.Resources.Years), term, -1));
            edit.SelectedIndex = 5;
        }
        public static void InitInterestRateData(ImageComboBoxEdit edit) {
            for(double i = 2.5; i < 15; i += 0.125)
                edit.Properties.Items.Add(new ImageComboBoxItem(string.Format("{0:n3} %", i), i, -1));
            edit.SelectedIndex = 25;
        }
        public static string GetMonthString(int month, List<LoanPayment> data) {
            foreach(LoanPayment payment in data)
                if(payment.MonthNumber.Equals(month)) return StringPainter.Default.RemoveFormat(payment.MonthString);
            return string.Empty;
        }
    }
    public class PaymentTypeSum {
        double interestSum = 0;
        double principalSum = 0;
        public PaymentTypeSum() {
            interestSum = 0;
            principalSum = 0;
        }
        public double InterestSum { get { return interestSum; } }
        public double PrincipalSum { get { return principalSum; } }
        public void AddToSum(double value1, double value2) {
            interestSum += value1;
            principalSum += value2;
        }
    }
    public enum PropertyType {
        [Description("Single Family Home")]
        SingleFamilyHome,
        [Description("Condo/Townhouse")]
        Townhome,
        [Description("Multi-Family Home")]
        MultiFamilyHome
    };
    public enum PropertyStatus {
        [Description("New Construction")]
        NewConstruction,
        [Description("Foreclosures")]
        Foreclosures,
        [Description("Recently Sold")]
        RecentlySold
    };
    public class Home {
        static List<Home> homes;
        DataRow row;
        Image photo;
        public Home(DataRow row) {
            this.row = row;
            if(!(row["Photo"] is DBNull))
                photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]);
        }
        public int ID { get { return (int)row["ID"]; } }
        public string Address { get { return string.Format("{0}", row["Address"]); } }
        public short Baths { get { return (short)row["Baths"]; } }
        public short Beds { get { return (short)row["Beds"]; } }
        public double HouseSize { get { return (double)row["HouseSize"]; } }
        public double LotSize { get { return (double)row["LotSize"]; } }
        public decimal Price { get { return Convert.ToDecimal(row["Price"]); } }
        public string YearBuilt { get { return string.Format("{0}", row["YearBuilt"]); } }
        public Image Photo { get { return photo; } }
        public string Features { get { return string.Format("{0}", row["Features"]); } }
        public string Type { get { return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText((PropertyType)row["Type"]); } }
        public string Status { get { return DevExpress.Utils.EnumExtensions.GetEnumItemDisplayText((PropertyStatus)row["Status"]); } }
        static List<Home> GetHomes() {
            DataSet temp = new DataSet();
            string db = FilesHelper.FindingFileName(Application.StartupPath, "Data\\Homes.xml");
            if(string.IsNullOrEmpty(db)) return null;
            temp.ReadXml(db);
            List<Home> ret = new List<Home>();
            foreach(DataRow row in temp.Tables["Homes"].Rows)
                ret.Add(new Home(row));
            return ret;
        }
        public static List<Home> Homes {
            get {
                if(homes == null)
                    homes = GetHomes();
                return homes;
            }
        }
    }
    public class HomeBedRoomChartData {
        public string RoomName { get; set; }
        public double RoomSize { get; set; }
    }
    public class Message {
        DataRow row;
        DateTime date;
        bool read, deleted, isReply, hasAttachment;
        int priority = 1;
        MailType mailType;
        MailFolder mailFolder;
        string from = String.Empty, subject = String.Empty, text = String.Empty, plainText = string.Empty;

        public Message() {
            this.date = DateTime.Now;
        }
        public Message(DataRow row) {
            this.row = row;
            this.date = ((DateTime)row["Date"]).Add(DateTime.Now - DataHelper.LastMailDate);
            this.from = string.Format("{0}", row["From"]);
            this.subject = string.Format("{0}", row["Subject"]);
            this.isReply = (bool)row["IsReply"];
            this.hasAttachment = (bool)row["HasAttachment"];
            this.read = Delay > TimeSpan.FromHours(6);
            if(Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) read = false;
            this.text = string.Format("{0}", row["Text"]);
            this.deleted = false;
            if(!IsReply)
                priority = 2;
            else
                if(string.IsNullOrEmpty(Folder))
                    priority = 0;
            mailType = MailType.Inbox;
            mailFolder = GetFolder(row);
            DataTweaking();
        }

        public DateTime Date { get { return date; } set { date = value; } }
        public string From { get { return from; } set { from = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string SubjectDisplayText { get { return string.Format("{1}{0}", Subject, IsReply ? "RE: " : ""); } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return read ? 1 : 0; } }
        public int Priority { get { return priority; } set { priority = value; } }
        internal bool IsReply { get { return isReply; } set { isReply = value; } }
        public bool IsUnread { get { return !read; } }
        internal string Folder { get { return string.Format("{0}", mailFolder); } }
        public string Text { get { return text; } set { text = value; } }
        public string PlainText { get { return GetPlainText(); } }

        string GetPlainText() {
            if(string.IsNullOrEmpty(plainText))
                plainText = ObjectHelper.GetPlainText(text.Substring(0, Math.Min(100, text.Length)));
            return plainText;
        }
        public MailType MailType { get { return mailType; } set { mailType = value; } }
        public MailFolder MailFolder { get { return mailFolder; } set { mailFolder = value; } }
        public bool Deleted { get { return deleted; } set { deleted = value; } }
        internal TimeSpan Delay { get { return DateTime.Now - date; } }

        public void ToggleRead() {
            read = !read;
        }
        void DataTweaking() {
            if(this.IsReply) return;
            if(this.Subject.IndexOf("IDataStore") > 0) read = false;
        }
        MailFolder GetFolder(DataRow row) {
            string ret = string.Format("{0}", row["Folder"]);
            if(string.IsNullOrEmpty(ret)) return MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainText = text; }
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainText(string htmlText) {
            rich.HtmlText = htmlText;
            return rich.Text.TrimStart();
        }
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<Message> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as Message);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
    }
    public class DataHelper {
        static List<Message> messages = null;
        internal static DateTime LastMailDate = DateTime.Now;
        internal static DataTable MailTable {
            get {
                string table = "Messages";
                DataTable messages = CreateDataTable(table);
                if(messages != null && messages.Rows.Count > 0)
                    LastMailDate = (DateTime)messages.Rows[0]["Date"];
                return messages;
            }
        }
        public static List<Message> Messages {
            get {
                try {
                    if(messages == null) {
                        messages = new List<Message>();
                        DataTable tbl = MailTable;
                        if(tbl != null) {
                            foreach(DataRow row in tbl.Rows)
                                messages.Add(new Message(row));
                        }
                    }
                }
                catch(Exception e) {
                    XtraMessageBox.Show(e.Message, e.Source);
                    messages = new List<Message>();
                }
                return messages;
            }
        }
        private static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = FilesHelper.FindingFileName(Application.StartupPath, "Data\\Mail.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
        public static void LogoGridLookupGetImageByValue(object sender, ImageByValueEventArgs e) {
            RepositoryItemGridLookUpEditWithGlyph repository = sender as RepositoryItemGridLookUpEditWithGlyph;
            if(repository == null || repository.DataSource == null) return;
            DataTable dt = repository.DataSource as DataTable;
            DataRow row = null;
            try {
                row = dt.Rows[(int)e.Value - 1];
            }
            catch { }
            if(row != null) {
                e.Image = (byte[])row["Logo"];
            }
        }
    }
    public class PreviewGridView : GridView {
        protected override bool IsAllowPixelScrollingPreview {
            get {
                return true;
            }
        }
    }
    public class SaleOverviewData {
        public SaleOverviewData(string state, double sales, double salesVsTarget, double profit, double customersSatisfaction, double markerShare) {
            this.State = state;
            this.Sales = sales;
            this.Profit = profit;
            this.SalesVsTarget = salesVsTarget;
            this.CustomersSatisfaction = customersSatisfaction;
            this.MarketShare = markerShare;
        }
        public string State { get; set; }
        [DisplayFormat(DataFormatString = "#,##0,,M")]
        public double Sales { get; set; }
        [DisplayFormat(DataFormatString = "#,##0,,M")]
        public double Profit { get; set; }
        [DisplayFormat(DataFormatString = "p", ApplyFormatInEditMode = true), Display(Name = "Sales vs Target")]
        public double SalesVsTarget { get; set; }
        [DisplayFormat(DataFormatString = "p0", ApplyFormatInEditMode = true)]
        public double MarketShare { get; set; }
        [Display(Name = "Satisfaction")]
        public double CustomersSatisfaction { get; set; }
    }
    public static class SaleOverviewDataGenerator {
        public static SaleOverviewData[] GenerateSales() {
            return new SaleOverviewData[] {
                new SaleOverviewData("California", 467949484.42, 0.0276, 44000000, 4.6, .34),
                new SaleOverviewData("South Dakota", 458113868.36, 0.0482, 27000000, 4.8, .32),
                new SaleOverviewData("Ohio", 250772304.63, -0.0288, -15000000, 3.4, .29),
                new SaleOverviewData("Wisconsin", 182660621.53, 0.0598, 14000000, 4.1, .22),
                new SaleOverviewData("New Hampshire", 158710257.91, 0.0132, 10000000, 4.0, .19),
                new SaleOverviewData("Maine", 156032947.24, -0.0996, -9000000, 2.9, .14),
                new SaleOverviewData("Utah", 131496479.72, 0.0445, 18000000, 4.7, .27),
                new SaleOverviewData("Idaho", 119199535.50, 0.0065, 14000000, 3.9, .30),
                new SaleOverviewData("Illinois", 102480457.66, -0.0039, 9000000, 4.2, .17),
                new SaleOverviewData("Washington", 102301309.53, 0.0242, 18000000, 4.6, .26),
                new SaleOverviewData("Wyoming", 98012761.36, 0.0021, 4000000, 3.7, .31),
                new SaleOverviewData("Indiana", 95976655.67, 0.0249, -7000000, 2.5, .17),
                new SaleOverviewData("Nevada", 91535057.56, 0.0284, 23000000, 4.5, .22),
                new SaleOverviewData("Massachusetts", 90602516.28, 0.0139, 12000000, 4.0, .24),
                new SaleOverviewData("Rhode Island", 90548513.43, 0.0137, 21000000, 4.4, .29),
                new SaleOverviewData("Montana", 89977272.49, -0.0049, -5000000, 2.0, .13),
                new SaleOverviewData("Alabama", 88237187.77, -0.0059, 6000000, 4.6, .15),
                new SaleOverviewData("Georgia", 88175277.25, 0.0045, 11000000, 4.2, .24),
                new SaleOverviewData("New York", 87774749.80, 0.0114, 15000000, 3.9, .30),
                new SaleOverviewData("Texas", 84291394.13, -0.0093, -20000000, 2.9, .13),
                new SaleOverviewData("Virginia", 83582665.33, -0.0057, 8000000, 3.9, .10),
                new SaleOverviewData("South Carolina", 83391264.21, 0.0384, 6000000, 4.4, .28),
                new SaleOverviewData("Missouri", 82106438.59, -0.0144, 2000000, 3.2, .18),
                new SaleOverviewData("Florida", 81751131.33, 0.0115, 7000000, 4.1, .24),
                new SaleOverviewData("Mississippi", 81203810.96, 0.0332, 6000000, 4.4, .31),
                new SaleOverviewData("New Mexico", 80452595.66, 0.0122, 13000000, 4.9, .23),
                new SaleOverviewData("Kentucky", 79995544.60, 0.0403, 10000000, 4.6, .27),
                new SaleOverviewData("Connecticut", 73220631.05, 0.0337, 8000000, 2.9, .24),
                new SaleOverviewData("Arizona", 72989023.31, -0.0094, -4000000, 3.6, .11),
                new SaleOverviewData("Tennessee", 72877959.11, 0.02915, 14000000, 4.9, .25),
                new SaleOverviewData("Colorado", 71391979.17, 0.0036, 5000000, 4.1, .28),
                new SaleOverviewData("Oregon", 70908060.11, 0.0042, 6000000, 4.5, .23),
                new SaleOverviewData("North Carolina", 70896926.22, -0.0111, -17000000, 3.0, .12),
                new SaleOverviewData("Michigan", 69466608.80, -0.0083, 3000000, 4.0, .20),
                new SaleOverviewData("Minnesota", 66473670.35, 0.0099, 8000000, 4.2, .19),
            };
        }
    }
    public class DemoHelper {
        static string connectionString = string.Empty;
        static ImageCollection ic16 = null;
        static ImageCollection ic24 = null;
        public static ImageCollection CategorySmallImages {
            get {
                if(ic16 == null) {
                    ic16 = new ImageCollection();
                    ic16.ImageSize = new Size(17, 17);
                    LoadImages(ic16, "Icon_17");
                }
                return ic16;
            }
        }
        public static ImageCollection CategoryLargeImages {
            get {
                if(ic24 == null) {
                    ic24 = new ImageCollection();
                    ic24.ImageSize = new Size(24, 24);
                    LoadImages(ic24, "Icon_25");
                }
                return ic24;
            }
        }
        static void LoadImages(ImageCollection ic, string fieldName) {
            DataSet ds = new DataSet();
            OleDbDataAdapter oleDBAdapter = new OleDbDataAdapter("SELECT * FROM Categories", connectionString);
            oleDBAdapter.Fill(ds);
            foreach(DataRow row in ds.Tables[0].Rows) {
                ic.Images.Add(DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(row[fieldName] as byte[]));
            }
        }
        public static void AddCategoryImagesToEdit(string connectionString, RepositoryItemImageComboBox edit) {
            DemoHelper.connectionString = connectionString;
            if(edit != null) {
                edit.SmallImages = CategorySmallImages;
                edit.LargeImages = CategoryLargeImages;
                edit.DropDownRows = CategorySmallImages.Images.Count;
            }
        }
    }
    public class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public class Trademark {
            Bitmap captionLogo = null;
            public int ID { get; set; }
            public Image Logo { get; set; }
            public string Name { get; set; }
            public Bitmap CaptionLogo {
                get {
                    if(captionLogo == null)
                        captionLogo = ResizeImage(Logo, 24, 70);
                    return captionLogo;
                }
            }
        }
        public class OrderItem {
            internal Model Model;
            public OrderItem(Model model, int days, Random rnd, int id) {
                Model = model;
                ModelPrice = model.Price;
                Trademark = model.Trademark;
                Name = model.Name;
                Modification = model.Modification;
                Category = model.Category;
                MPGCity = model.MPGCity;
                MPGHighway = model.MPGHighway;
                Doors = model.Doors;
                BodyStyle = model.BodyStyle;
                Cylinders = model.Cylinders;
                Horsepower = model.Horsepower;
                Torque = model.Torque;
                TransmissionSpeeds = model.TransmissionSpeeds;
                TransmissionType = model.TransmissionType;

                SalesDate = DateTime.Now.AddDays(-rnd.Next(days));
                Discount = Math.Round(0.05 * rnd.Next(4), 2);
                OrderID = id;
            }
            public int OrderID { get; set; }
            public DateTime SalesDate { get; set; }
            public double Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public Image Photo { get { return Model.Photo; } }
        }
        public class Model {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public decimal Price { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public string Description { get; set; }
            public Image Image { get; set; }
            public Image Photo { get; set; }
            public DateTime DeliveryDate { get; set; }
            public bool InStock { get; set; }
            public Image TrademarkImage {
                get {
                    return Trademarks != null ? Trademarks[Trademark - 1].Logo : null;
                }
            }
            public string TrademarkName { get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; } }
            public Bitmap GetSmallTrademarkImage() {
                return Trademarks[Trademark - 1].CaptionLogo;
            }
            public List<VehiclesData.Trademark> Trademarks = null;
        }
        public static Bitmap ResizeImage(Image image, int height, int maxWidth) {
            int width = Math.Min(image.Width * height / image.Height, maxWidth);
            int heightImage = image.Height * width / image.Width;
            Rectangle destRect = new Rectangle(0, (height - heightImage) / 2, width, heightImage);
            Bitmap destImage = new Bitmap(width, height);

            using(Graphics graphics = Graphics.FromImage(destImage)) {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            }

            return destImage;
        }
        public static void LogoGridLookupGetImageByValue(object sender, ImageByValueEventArgs e) {
            RepositoryItemGridLookUpEditWithGlyph repository = sender as RepositoryItemGridLookUpEditWithGlyph;
            if(repository == null || repository.DataSource == null) return;
            List<Trademark> list = repository.DataSource as List<Trademark>;
            int val = (int)e.Value;
            if(val > 0)
                e.Image = list[(int)e.Value - 1].Logo;
        }
        public static void InitMDBDataAndCreateEditors(string connectionString, GridControl grid, out List<Model> models, out List<Trademark> trademarks) {
            DataSet ds;
            models = InitMDBDataCore(connectionString, out ds, out trademarks);
            CreateEditors(grid, ds, trademarks);
            InitColumnViewEditors(grid.MainView as ColumnView);
        }
        public static void InitOrdersData(string connectionString, GridControl grid, int itemCount, int dataInterval) {
            DataSet ds;
            Random rnd = new Random();
            List<Trademark> listTrademarks;
            List<Model> listModels = InitMDBDataCore(connectionString, out ds, out listTrademarks, 1);
            List<OrderItem> orders = new List<OrderItem>();
            for(int i = 0; i < itemCount; i++)
                orders.Add(new OrderItem(listModels[rnd.Next(0, listModels.Count - 1)], dataInterval, rnd, i + 1));
            grid.DataSource = orders;
            CreateEditors(grid, ds, listTrademarks);
        }
        public static void InitMDBData(string connectionString, GridControl grid) {
            InitMDBData(connectionString, grid, 30);
        }
        public static void InitMDBData(string connectionString, GridControl grid, int dataInterval) {
            DataSet ds;
            List<Trademark> listTrademarks;
            List<Model> listModels = InitMDBDataCore(connectionString, out ds, out listTrademarks, dataInterval);
            SetGridDataSource(listModels, grid);
            CreateEditors(grid, ds, listTrademarks);
        }
        static void CreateEditors(GridControl grid, DataSet ds, List<Trademark> listTrademarks) {
            CreateSimpleLookUpEdit(grid, ds.Tables["Category"], "/Category");
            CreateSimpleLookUpEdit(grid, ds.Tables["BodyStyle"], "/BodyStyle");
            CreateSimpleLookUpEdit(grid, ds.Tables["TransmissionType"], "/TransmissionType");
            CreateTrademarkLookUpEdit(grid, listTrademarks, "/Trademark");
            CreateSpinEdit(grid, "/MPGCity/MPGHighway", 100, 1);
            CreateSpinEdit(grid, "/Doors", 10, 1);
            CreateSpinEdit(grid, "/Cylinders", 20, 1);
            CreateSpinEdit(grid, "/TransmissionSpeeds", 20, -1);
            CreateCurrencyEdit(grid, "/Price/ModelPrice");
            CreatePictureEdit(grid, "/TrademarkImage/Photo/Image");
        }
        static List<Model> InitMDBDataCore(string connectionString, out DataSet ds, out List<Trademark> listTrademarks) {
            return InitMDBDataCore(connectionString, out ds, out listTrademarks, 30);
        }
        static List<Model> InitMDBDataCore(string connectionString, out DataSet ds, out List<Trademark> listTrademarks, int dataInterval) {
            string Model = "Model";
            string Trademark = "Trademark";
            string Category = "Category";
            string BodyStyle = "BodyStyle";
            string TransmissionType = "TransmissionType";
            ds = new DataSet();
            FillTable(Model, null, connectionString, ds);
            FillTable(Category, null, connectionString, ds);
            FillTable(Trademark, null, connectionString, ds);
            FillTable(BodyStyle, null, connectionString, ds);
            FillTable(TransmissionType, null, connectionString, ds);

            listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables[Trademark].Rows)
                listTrademarks.Add(new VehiclesData.Trademark()
                {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                    Logo = ByteImageConverter.FromByteArray((byte[])row["Logo"])
                });

            var listModels = new List<VehiclesData.Model>();
            Random rnd = new Random();
            foreach(DataRow row in ds.Tables[Model].Rows)
                listModels.Add(new VehiclesData.Model()
                {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                    Trademark = (int)row["TrademarkID"],
                    Modification = (string)row["Modification"],
                    Category = (int)row["CategoryID"],
                    Price = (decimal)row["Price"],
                    MPGCity = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG City"],
                    MPGHighway = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG Highway"],
                    Doors = (int)row["Doors"],
                    BodyStyle = (int)row["BodyStyleID"],
                    Cylinders = (int)row["Cylinders"],
                    Horsepower = (string)row["Horsepower"],
                    Torque = (string)row["Torque"],
                    TransmissionSpeeds = Convert.ToInt32(row["Transmission Speeds"]),
                    TransmissionType = (int)row["Transmission Type"],
                    Description = string.Format("{0}", row["Description"]),
                    Image = ByteImageConverter.FromByteArray((byte[])row["Image"]),
                    Photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]),
                    DeliveryDate = DateTime.Now.AddDays(rnd.Next(dataInterval)),
                    InStock = rnd.Next(100) < 95,
                    Trademarks = listTrademarks
                });
            return listModels;
        }
        public static void InitColumnViewEditors(ColumnView view) {
            if(view.Columns.Count == 0) return;
            foreach(GridColumn col in view.Columns) {
                RepositoryItem item = GetEditByFielsName(col.FieldName, view.GridControl.RepositoryItems);
                if(item != null && col.ColumnEdit == null) col.ColumnEdit = item;
            }
            GridView gView = view as GridView;
            if(gView != null) gView.GroupSummary.Add(SummaryItemType.Count, "ID");
            GridColumn colPrice = view.Columns["Price"];
            if(colPrice != null) {
                colPrice.DisplayFormat.FormatType = FormatType.Numeric;
                colPrice.DisplayFormat.FormatString = "c";
            }
            GridColumn colDeliveryDate = view.Columns["DeliveryDate"];
            if(colDeliveryDate != null)
                colDeliveryDate.GroupInterval = ColumnGroupInterval.DateRange;
        }
        static RepositoryItem GetEditByFielsName(string fieldName, RepositoryItemCollection repositoryItemCollection) {
            foreach(RepositoryItem item in repositoryItemCollection)
                if(item.Name.IndexOf("/" + fieldName) >= 0) return item;
            return null;
        }
        static RepositoryItemPictureEdit CreatePictureEdit(GridControl grid, string name) {
            RepositoryItemPictureEdit ret = new RepositoryItemPictureEdit();
            grid.RepositoryItems.Add(ret);
            ret.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            ret.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemTextEdit CreateCurrencyEdit(GridControl grid, string name) {
            RepositoryItemTextEdit ret = new RepositoryItemTextEdit();
            grid.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            ret.Mask.EditMask = "c";
            ret.Mask.UseMaskAsDisplayFormat = true;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemSpinEdit CreateSpinEdit(GridControl grid, string name, int maxValue, int minValue) {
            RepositoryItemSpinEdit ret = new RepositoryItemSpinEdit();
            grid.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.IsFloatValue = false;
            ret.Mask.EditMask = "N00";
            ret.MaxValue = maxValue;
            ret.MinValue = minValue;
            ret.Name = name;
            return ret;
        }
        static RepositoryItemLookUpEdit CreateSimpleLookUpEdit(GridControl grid, DataTable tbl, string name) {
            RepositoryItemLookUpEdit ret = new RepositoryItemLookUpEdit();
            grid.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name") });
            ret.PopupFormMinSize = new Size(100, 0);
            ret.DisplayMember = "Name";
            ret.Name = name;
            ret.ShowFooter = false;
            ret.ShowHeader = false;
            ret.ValueMember = "ID";
            ret.DataSource = tbl;
            ret.DropDownRows = tbl.Rows.Count;
            return ret;
        }
        static RepositoryItemGridLookUpEditWithGlyph CreateTrademarkLookUpEdit(GridControl grid, object ds, string name) {
            RepositoryItemGridLookUpEditWithGlyph ret = new RepositoryItemGridLookUpEditWithGlyph();
            RepositoryItemPictureEdit picture = new RepositoryItemPictureEdit();
            grid.RepositoryItems.Add(ret);
            ret.AutoHeight = false;
            ret.DisplayMember = "Name";
            ret.Name = name;
            picture.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            picture.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            ret.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { picture });
            ret.ValueMember = "ID";
            GridView view = new GridView();
            ret.View = view;
            GridColumn colLogo = new GridColumn();
            GridColumn colName = new GridColumn();
            view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colLogo, colName });
            view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            view.OptionsSelection.EnableAppearanceFocusedCell = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.ShowColumnHeaders = false;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ShowIndicator = false;
            colLogo.ColumnEdit = picture;
            colLogo.FieldName = "Logo";
            colLogo.Visible = true;
            colLogo.VisibleIndex = 0;
            colName.FieldName = "Name";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            ret.DataSource = ds;
            return ret;
        }
        static void FillTable(string table, string query, string connectionString, DataSet ds) {
            if(query == null) query = string.Format("SELECT * FROM {0}", table);
            System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, connectionString);
            //SetWaitDialogCaption(string.Format("Loading {0}...", table));
            oleDbDataAdapter.Fill(ds, table);
        }

        static void SetGridDataSource(object ds, GridControl grid) {
            grid.DataMember = null;
            grid.DataSource = ds;
        }

        static void repositoryItemGridLookUpEdit1_GetImageByValue(object sender, ImageByValueEventArgs e) {
            VehiclesData.LogoGridLookupGetImageByValue(sender, e);
        }
    }
}
