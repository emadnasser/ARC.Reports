#if DEBUG_1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Controls;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraEditors;
using System.Reflection;

namespace DevExpress.XtraLayout.Demos.Modules {
    public partial class UserFeedbackControl : XtraUserControl, IXtraResizableControl {
        public UserFeedbackControl() {
            InitializeComponent();
        }
        bool expand = true;
        protected IXtraResizableControl GetIXtraResizable() {
            return Controls[0] as IXtraResizableControl;
        }
        public event EventHandler Changed {
            add { GetIXtraResizable().Changed += value; }
            remove {
                GetIXtraResizable().Changed -= value;
            }
        }

        public bool IsCaptionVisible {
            get { return GetIXtraResizable() != null ? GetIXtraResizable().IsCaptionVisible : false; }
        }

        public Size MaxSize {
            get { return GetIXtraResizable().MaxSize; }
        }

        public Size MinSize {
            get { return GetIXtraResizable().MinSize; }
        }

        private void SetReBlogItemsVisibility() {
            if(layoutControlGroup3.Visibility == LayoutVisibility.Always) layoutControlGroup3.Visibility = LayoutVisibility.Never;
            else layoutControlGroup3.Visibility = LayoutVisibility.Always;
        }
        private void SetMapVisibilityAndHeight() {
            if(mapControlItem.Visibility == LayoutVisibility.Always) mapControlItem.Visibility = LayoutVisibility.Never;
            else mapControlItem.Visibility = LayoutVisibility.Always;
        }
        private void SetConversationVisibility() {
            foreach(BaseLayoutItem bli in layoutControl1.Items) {
                LayoutControlItem lci = bli as LayoutControlItem;
                if(lci == null || lci.Control == null) continue;
                UserComment BlogConversationControl = lci.Control as UserComment;
                if(BlogConversationControl == null) continue;
                if(lci.Visibility == LayoutVisibility.Always) lci.Visibility = LayoutVisibility.Never;
                else lci.Visibility = LayoutVisibility.Always;
            }
        }

        private void layoutControlGroup1_MouseDown(object sender, MouseEventArgs e) {
            if(expand) SetItemsVisibility(true);
            else SetItemsVisibility(false);

        }

        private void SetItemsVisibility(bool p) {
            SetConversationVisibility();
            SetReBlogItemsVisibility();
            SetMapVisibilityAndHeight();
            expand = !p;
        }

       

        private void button1_Click(object sender, EventArgs e) {
            if(layoutControlGroup3.Visible) { layoutControlGroup3.Visibility = LayoutVisibility.Never; mapControl.Visible = false; } 
            else { layoutControlGroup3.Visibility = LayoutVisibility.Always; mapControl.Visible = true; }
        }

       
      

      
    }
    public class Blog {
        public Contact Sender { get; set; }
        public string MessageBody { get; set; }
        public Image ImageContent { get; set; }
        public MapLocation Location { get; set; }
        public List<Contact> ReBlogPeople { get; set; }
        public DateTime SendTime { get; set; }
        public List<Blog> Conversation { get; set; }
    }
    public class MapLocation {
        public double Lat { get; set; }//широта
        public double Lng { get; set; }//долгота
        public MapLocation(double lat, double lng) {
            Lat = lat;
            Lng = lng;
        }
    }
    public class Contact {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image Image { get; set; }
        public string NickName { get; set; }
    }
    public class SampleData {
        static List<Blog> data;
        public static List<Blog> Data {
            get {
                if(data == null) {
                    CreateData();
                }
                return data;

            }
        }
        protected static void CreateData() {
            data = new List<Blog>();
            List<Contact> listContact = CreateContact();
            List<string> listMessage = CreateMessage();
            List<string> listComments = CreateComments();
            List<MapLocation> listLocation = CreateLocation();
            Blog mainBlog;
            List<Blog> conversationBlog;
            conversationBlog = new List<Blog>();
            conversationBlog.Add(new Blog() { MessageBody = listComments[2], Sender = listContact[1], SendTime = new DateTime(2014, 2, 6, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[4], Sender = listContact[4], SendTime = new DateTime(2014, 2, 6, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[3], Sender = listContact[5], SendTime = new DateTime(2014, 2, 6, 8, 4, 00) });
            mainBlog = new Blog() { MessageBody = listMessage[0], Sender = listContact[0], SendTime = new DateTime(2014, 2, 4, 10, 54, 00), Location = listLocation[1], Conversation = conversationBlog, ReBlogPeople = new List<Contact>() { listContact[1], listContact[2], listContact[3], listContact[4], listContact[5] }/*, ImageContent = "long_cat1.gif"*/ };
            data.Add(mainBlog);
            conversationBlog = new List<Blog>();
            conversationBlog.Add(new Blog() { MessageBody = listComments[2], Sender = listContact[3], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[3], Sender = listContact[1], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[1], Sender = listContact[2], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            mainBlog = new Blog() { MessageBody = listMessage[2], Sender = listContact[0], SendTime = new DateTime(2014, 1, 3, 10, 54, 00), Location = listLocation[0], Conversation = conversationBlog, ReBlogPeople = new List<Contact>() { listContact[1], listContact[2], listContact[3] }, ImageContent  = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-1.jpg", Assembly.GetExecutingAssembly())};
            data.Add(mainBlog);
            conversationBlog = new List<Blog>();
            conversationBlog.Add(new Blog() { MessageBody = listComments[0], Sender = listContact[1], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[2], Sender = listContact[5], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[4], Sender = listContact[4], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            mainBlog = new Blog() { MessageBody = listMessage[3], Sender = listContact[0], SendTime = new DateTime(2014, 1, 3, 10, 54, 00), Location = listLocation[0], Conversation = conversationBlog, ReBlogPeople = new List<Contact>() { listContact[1], listContact[2], listContact[3] }/*, ImageContent = "long.jpg"*/ };
            data.Add(mainBlog);
            conversationBlog = new List<Blog>();
            conversationBlog.Add(new Blog() { MessageBody = listComments[1], Sender = listContact[4], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[3], Sender = listContact[2], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            conversationBlog.Add(new Blog() { MessageBody = listComments[2], Sender = listContact[3], SendTime = new DateTime(2014, 2, 5, 8, 4, 00) });
            mainBlog = new Blog() { MessageBody = listMessage[3], Sender = listContact[0], SendTime = new DateTime(2014, 1, 3, 10, 54, 00), Location = listLocation[0], Conversation = conversationBlog, ReBlogPeople = new List<Contact>() { listContact[1], listContact[2], listContact[3] }/*, ImageContent = "long2.png"*/ };
            data.Add(mainBlog);
        }

        protected static List<MapLocation> CreateLocation() {
            List<MapLocation> listLocation = new List<MapLocation>();
            listLocation.Add(new MapLocation(34.161210, -118.300946));
            listLocation.Add(new MapLocation(34.389913, -118.545914));
            listLocation.Add(new MapLocation(34.279191, -118.879218));
            return listLocation;
        }

        protected static List<string> CreateComments() {
            List<string> listMessage = new List<string>();
            listMessage.Add("It's great.");
            listMessage.Add("Wonderful idea.");
            listMessage.Add("Thank you. It's help me");
            listMessage.Add("Thank you for such brilliant products and keep up the good work.");
            listMessage.Add("I have had the pleasure to work with WPF, WinForms, and ASP.NET and no one offers a more powerful, comprehensive, and just plain awesome set of tools as DevExpress.");
            listMessage.Add("You are the best!. I tried ASP NET controls from some of your competitors, But you are incredible. We will buy very soon learning's videos for ASP solutions!");
            return listMessage;
        }

        protected static List<string> CreateMessage() {
            List<string> listMessage = new List<string>();
            listMessage.Add("Blog: DevExpress http://ASP.NET  - Recent rendering change in v13.2: DevExpress http://ASP.NET  - ... http://dxpr.es/1kN8GTN");
            listMessage.Add("Blog: http://ASP.NET  Security RigmaROLE: It's one thing to be able to make a stunning looking website (... http://dxpr.es/1alC2aR ");
            listMessage.Add("WinForms TreeListControl  A feature-complete, multi-purpose, and data-aware TreeView-Grid control that has the... http://fb.me/2FxoaBXWp ");
            listMessage.Add("Blog: TemplateExpand with CollapsedRegions – How does it work?: Disclaimer (Yes again)  Yup, some people still... http://dxpr.es/LPY4qS ");
            return listMessage;
        }

        protected static List<Contact> CreateContact() {
            List<Contact> listContact = new List<Contact>();
            listContact.Add(new Contact() { FirstName = "DevExpress", NickName = "@DevExpress", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-6.jpg", typeof(frmMain).Assembly)});
            listContact.Add(new Contact() { FirstName = "Monica", LastName = "Black", NickName = "@developer1", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-1.jpg", typeof(frmMain).Assembly) });
            listContact.Add(new Contact() { FirstName = "Anna", LastName = "White", NickName = "@developer2", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-2.jpg", typeof(frmMain).Assembly) });
            listContact.Add(new Contact() { FirstName = "Jessica", LastName = "Green", NickName = "@developer3", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-3.jpg", typeof(frmMain).Assembly) });
            listContact.Add(new Contact() { FirstName = "Angelina", LastName = "Brown", NickName = "@developer4", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-4.jpg", typeof(frmMain).Assembly) });
            listContact.Add(new Contact() { FirstName = "Erica", LastName = "Pink", NickName = "@developer5", Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-5.jpg", typeof(frmMain).Assembly) });
            return listContact;
        }
    }
}
#endif
