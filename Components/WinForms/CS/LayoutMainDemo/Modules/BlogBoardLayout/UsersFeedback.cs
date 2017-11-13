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
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraLayout.Demos.Modules;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;

namespace DevExpress.XtraLayout.Demos {
  
    public class RibbonItems{
       public LayoutControlItem mapItem;
       public LayoutControlItem commentItem;
       public LayoutControlItem rafItem;
       public LayoutControlItem dateItem;
       public LayoutControlItem mainItem;
       public LayoutControlItem labelItem;
       public SimpleButton expandСollapse;
       public List<LayoutControlItem> commentList;
       public bool expanded = false;
       public RibbonItems(){
           mapItem = new LayoutControlItem();
           commentItem = new LayoutControlItem();
           rafItem = new LayoutControlItem();
           dateItem = new LayoutControlItem();
           mainItem = new LayoutControlItem();
           labelItem = new LayoutControlItem();
           expandСollapse = new SimpleButton();
           commentList = new List<LayoutControlItem>();
           expandСollapse.Click += expandСollapse_Click;

       }

       void expandСollapse_Click(object sender, EventArgs e) {
           if(!expanded) {
               mainItem.Visibility = LayoutVisibility.Never;
               commentItem.Visibility = LayoutVisibility.Never;
               rafItem.Visibility = LayoutVisibility.Never;
               mapItem.Visibility = LayoutVisibility.Never;
               foreach(LayoutControlItem comment in commentList) {
                   comment.Visibility = LayoutVisibility.Never;
               }
               expanded = true;
           } else {
               mainItem.Visibility = LayoutVisibility.Always;
               commentItem.Visibility = LayoutVisibility.Always;
               rafItem.Visibility = LayoutVisibility.Always;
               mapItem.Visibility = LayoutVisibility.Always;
               foreach(LayoutControlItem comment in commentList) {
                   comment.Visibility = LayoutVisibility.Always;
               }
               expanded = false;
           }
       }
        public void addConversation(Blog blog){
            foreach(ConversationBlog blogConversation in blog.Conversation) {
                UserComment userComment = new UserComment();
                userComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               // userComment.Name = count.ToString();
                userComment.pictureEdit.Image = blogConversation.Sender.Image;
                userComment.labelTime.Text = blogConversation.SendTime.ToShortTimeString();
                userComment.labelFullName.Text = blogConversation.Sender.FirstName + " " + blogConversation.Sender.LastName;
                userComment.labelNickName.Text = blogConversation.Sender.NickName;
                userComment.memoEdit.Text = blogConversation.MessageBody;
                LayoutControlItem lci = new LayoutControlItem();
               
                lci.Control = userComment;
                commentList.Add(lci);
            }
        }

    }
    public partial class UsersFeedback : DevExpress.XtraLayout.Demos.TutorialControl {
        private LayoutControl ribbon;

      
        RibbonItems items;
       // bool expanded = false;
        // private PartRibbon part;
        public UsersFeedback() {
            ribbon = new LayoutControl();
            
            //  items = new List<RibbonItems>();
            ribbon.MinimumSize = new System.Drawing.Size(630, 600);
            ribbon.Margin = new System.Windows.Forms.Padding(0);
            ribbon.Padding = new System.Windows.Forms.Padding(0);
            ribbon.Parent = this;
            LoadData();
        }
        int count = 1;

        private void LoadData() {
            foreach(Blog blog in SampleData.Data) {
           
                items = new RibbonItems();
                CreateLabel(blog);
                CreateMain(blog);
                CrateDate(blog);
                CreateRetweetsAndFavorites(blog);
                CreateMap(blog);
                CreateComment(blog);
                count++;
                //expandСollapse.Click += expandСollapse_Click;
                ribbon.AddItem(new EmptySpaceItem());
            }
        }

       
        void CreateMap(Blog blog) {
            if(blog.Location != null) {
               // LayoutControlItem item = new LayoutControlItem();
                items.mapItem.TextVisible = false;
                items.mapItem.Padding = new Utils.Padding(0);

                MapControl map = new DevExpress.XtraMap.MapControl();

                DevExpress.XtraMap.ImageLayer imageLayer1 = new DevExpress.XtraMap.ImageLayer();
                DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
                map.BeginInit();
                map.MinimumSize = map.MaximumSize = new Size(600, 600);
                map.Location = new Point(0, 0);
                map.Padding = new System.Windows.Forms.Padding(0);
                map.Margin = new System.Windows.Forms.Padding(0);

                map.SetCenterPoint(new DevExpress.XtraMap.GeoPoint(blog.Location.Lat, blog.Location.Lng), true);
                map.ZoomLevel = 16.0;

                imageLayer1.DataProvider = bingMapDataProvider1;
                map.Layers.Add(imageLayer1);

                map.EndInit();

                items.mapItem.Control = map;
                ribbon.Root.Add(items.mapItem);

                //   part.items.Add(new RibbonItems(item,true));
            }
        }
        void CreateComment(Blog blog) {
            if(blog.Conversation != null) {
                items.addConversation(blog);
                foreach(LayoutControlItem item in items.commentList) {
                    count++;
                    item.Name = count.ToString();
                    item.SizeConstraintsType = SizeConstraintsType.Custom;
                    item.MinSize = item.MaxSize = new System.Drawing.Size(600, 100);
                    item.Padding = new Utils.Padding(0, 0, 0, 0);

                    item.TextVisible = false;
                    ribbon.Root.AddItem(item);
                }
               
            }
        }
        void CreateRetweetsAndFavorites(Blog blog) {
          //  LayoutControlItem item = new LayoutControlItem();
            items.rafItem.TextVisible = false;
            items.rafItem.Padding = new Utils.Padding(0);

            PanelControl raf = new PanelControl();
            items.rafItem.Control = raf;
            ribbon.Root.AddItem(items.rafItem);
            //    part.items.Add(new RibbonItems(item, true));
            raf.BorderStyle = XtraEditors.Controls.BorderStyles.Simple;
            raf.MinimumSize = new System.Drawing.Size(600, 40);
            raf.MaximumSize = new System.Drawing.Size(600, 0);
            LabelControl retweets = new LabelControl();
            //retweets.Text = "Retweets: " + blog.ReBlogPeople.Count.ToString();
            retweets.Parent = raf;
            retweets.Location = new Point(5, 5);
            retweets.MaximumSize = new System.Drawing.Size(100, 15);

            LabelControl favorites = new LabelControl();
            //favorites.Text = "Favorites: " + blog.ReBlogPeople.Count.ToString();
            favorites.Parent = raf;
            favorites.Location = new Point(100, 5);
            favorites.MaximumSize = new System.Drawing.Size(100, 15);
            int reBlogPeopleCount = 0;
            if(blog.Favorites != null) {
                for(int i = 0; i < blog.Favorites.Count; i++) {
                    if(i > 3) break;
                    PictureEdit pe = new PictureEdit();
                    pe.Parent = raf;
                    pe.Location = new Point(200 + i * 50, 5);
                    pe.Size = new Size(32, 32);
                    pe.Image = blog.Favorites[i];
                    pe.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
                    reBlogPeopleCount++;
                }
            }
            retweets.Text = reBlogPeopleCount.ToString() + " Retweets";
            favorites.Text = reBlogPeopleCount.ToString() + " Favorites";
            //PictureEdit avatar1 = new PictureEdit();
            //PictureEdit avatar2 = new PictureEdit();
            //PictureEdit avatar3 = new PictureEdit();
            //PictureEdit avatar4 = new PictureEdit();
            //avatar1.Parent = raf;
            //avatar1.Location = new Point(200, 5);
            //avatar1.Size = new System.Drawing.Size(32,32);
            //avatar1.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            //avatar2.Parent = raf;
            //avatar2.Location = new Point(250, 5);
            //avatar2.Size = new System.Drawing.Size(32, 32);
            //avatar2.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            //avatar3.Parent = raf;
            //avatar3.Location = new Point(300, 5);
            //avatar3.Size = new System.Drawing.Size(32, 32);
            //avatar3.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            //avatar4.Parent = raf;
            //avatar4.Location = new Point(350, 5);
            //avatar4.Size = new System.Drawing.Size(32, 32);
            //avatar4.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;

            //avatar1.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-3.jpg", typeof(frmMain).Assembly);
            //avatar2.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-5.jpg", typeof(frmMain).Assembly);
            //avatar3.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-6.jpg", typeof(frmMain).Assembly);
            //avatar4.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-1.jpg", typeof(frmMain).Assembly);
        }
        void CrateDate(Blog blog) {
            //LayoutControlItem item = new LayoutControlItem();
            items.dateItem.TextVisible = false;
            items.dateItem.Padding = new Utils.Padding(0);
            LabelControl date = new LabelControl();
            //date.Padding = new System.Windows.Forms.Padding(0);
            //date.Margin = new System.Windows.Forms.Padding(0);
            items.dateItem.Control = date;
            ribbon.Root.AddItem(items.dateItem);
            //    part.items.Add(new RibbonItems(item, true));
            date.Text = blog.SendTime.ToString();


            date.Appearance.Font = new Font("Tahoma", 10F);
            date.MinimumSize = new System.Drawing.Size(600, 20);
            date.Location = new Point(5, 550);
            date.BorderStyle = XtraEditors.Controls.BorderStyles.Simple;

        }
        void CreateMain(Blog blog) {
            //LayoutControlItem item = new LayoutControlItem();
            items.mainItem.TextVisible = false;
            items.mainItem.Padding = new Utils.Padding(0);
            PanelControl lc = new PanelControl();
            items.mainItem.Control = lc;

            ribbon.Root.AddItem(items.mainItem);
            //   part.items.Add(new RibbonItems(item, false));
            lc.BorderStyle = XtraEditors.Controls.BorderStyles.Simple;


            lc.MinimumSize = new System.Drawing.Size(600, 50);
            lc.MaximumSize = new System.Drawing.Size(600, 0);
            lc.Padding = new System.Windows.Forms.Padding(0);
            lc.Margin = new System.Windows.Forms.Padding(0);

            RichTextEdit label = new RichTextEdit();
            label.Text = blog.MessageBody;
            label.Location = new Point(5, 5);
            label.MinimumSize = new System.Drawing.Size(590, 40);
            label.Parent = lc;
            PictureEdit picture = new PictureEdit();
            if(blog.ImageContent != null) {
                lc.MinimumSize = new System.Drawing.Size(600, 345);

                picture.Image = blog.ImageContent;
                picture.Location = new Point(5, 45);
                picture.MinimumSize = new System.Drawing.Size(590, 300);
                picture.Properties.SizeMode = XtraEditors.Controls.PictureSizeMode.Zoom;
                picture.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
                picture.Parent = lc;

            }
        }
        void CreateLabel(Blog blog) {
            // LayoutControlItem item = new LayoutControlItem();
            items.labelItem.Padding = new Utils.Padding(0);
            items.labelItem.TextVisible = false;
            PanelControl lb = new PanelControl();
            items.labelItem.Control = lb;
            ribbon.Root.AddItem(items.labelItem);
            //   part.items.Add(new RibbonItems(item, false));
            lb.BorderStyle = XtraEditors.Controls.BorderStyles.Simple;


            lb.Padding = new System.Windows.Forms.Padding(10);
            lb.MinimumSize = new System.Drawing.Size(600, 58);
            lb.MaximumSize = new System.Drawing.Size(600, 0);


            PictureEdit pb = new PictureEdit();
            pb.Image = blog.Sender.Image;
            pb.MinimumSize = pb.MaximumSize = new System.Drawing.Size(48, 48);
            pb.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            pb.Location = new Point(5, 5);
            lb.Controls.Add(pb);

            LabelControl labelFullName = new LabelControl();
            labelFullName.Text = "DevExpress";
            labelFullName.Parent = lb;
            labelFullName.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            labelFullName.Location = new Point(65, 20);

            LabelControl labelNickName = new LabelControl();
            labelNickName.Text = "@DevExpress";
            labelNickName.Parent = lb;
            labelNickName.Appearance.Font = new Font("Tahoma", 10F);
            labelNickName.Appearance.ForeColor = Color.Orange;
            labelNickName.Location = new Point(300, 20);

            LabelControl timeAgo = new LabelControl();
            timeAgo.Text = Math.Round((DateTime.Now - blog.SendTime).TotalHours, 1).ToString() + " hours ago";
            timeAgo.Parent = lb;
            timeAgo.Appearance.Font = new Font("Tahoma", 10F);
            timeAgo.Location = new Point(420, 20);
            // lb.Image = blog.Sender.Image;

           // SimpleButton expandСollapse = new SimpleButton();
            items.expandСollapse.Parent = lb;
            items.expandСollapse.Location = new Point(542, 0);
            items.expandСollapse.MinimumSize = items.expandСollapse.MaximumSize = new Size(58, 58);
            //    expandСollapse.Click += expandСollapse_Click;

        }

       

    }
    public partial class _UsersFeedback : DevExpress.XtraLayout.Demos.TutorialControl {
        public _UsersFeedback() {
            //  InitializeComponent();
            this.MouseWheel += BlogForm_MouseWheel;
            LoadData();
        }
        int count = 1;
        private void LoadData() {
            foreach(Blog Blog in SampleData.Data) {
                CreateMainBlog(Blog, count);
                count++;
            }
        }
        void BlogForm_MouseWheel(object sender, MouseEventArgs e) {
            DXMouseEventArgs ee = e as DXMouseEventArgs;
            if(ee != null) {
                //  ((ILayoutControl)layoutControl).ActiveHandler.OnMouseWheel(ee);
                ee.Handled = true;
            }
        }
        private static UserFeedbackControl CreateRowCore(Blog Blog, int countName) {
            UserFeedbackControl UserFeedbackControl = new UserFeedbackControl();
            UserFeedbackControl.pictureEdit1.Image = Blog.Sender.Image;
            UserFeedbackControl.labelFullName.Text = Blog.Sender.FirstName + " " + Blog.Sender.LastName;
            UserFeedbackControl.labelNickName.Text = Blog.Sender.NickName;
            UserFeedbackControl.labelTimeAgo.Text = Math.Round((DateTime.Now - Blog.SendTime).TotalHours, 1).ToString() + " hours ago";
            UserFeedbackControl.Name = UserFeedbackControl.Name + countName.ToString();
            UserFeedbackControl.richEditControl.Document.Delete(UserFeedbackControl.richEditControl.Document.Range);
            UserFeedbackControl.richEditControl.Document.InsertText(UserFeedbackControl.richEditControl.Document.CaretPosition, Blog.MessageBody + "\n");

            return UserFeedbackControl;
        }
        private void CreateMainBlog(Blog Blog, int countName) {
            UserFeedbackControl UserFeedbackControl = CreateRowCore(Blog, countName);
            if(Blog.Location != null) {
                UserFeedbackControl.mapControlItem.Visibility = LayoutVisibility.Always;
                UserFeedbackControl.mapControl.SetCenterPoint(new DevExpress.XtraMap.GeoPoint(Blog.Location.Lat, Blog.Location.Lng), true);
                UserFeedbackControl.mapControl.ZoomLevel = 16.0;
            } UserFeedbackControl.mapControlItem.Visibility = LayoutVisibility.Never;
            UserFeedbackControl.labelControl4.Text = Blog.ReBlogPeople.Count.ToString();
            UserFeedbackControl.labelControl5.Text = Blog.ReBlogPeople.Count.ToString();
            UserFeedbackControl.labelTimeAdd.Text = Blog.SendTime.ToLongDateString();
            //  UserFeedbackControl.simpleButton1.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.icon-map.png", typeof(frmMain).Assembly);
            //UserFeedbackControl.pictureEdit6.Image = Blog.ImageContent;
            //UserFeedbackControl.pictureEdit2.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-3.jpg", typeof(frmMain).Assembly);
            //UserFeedbackControl.pictureEdit3.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-5.jpg", typeof(frmMain).Assembly);
            //UserFeedbackControl.pictureEdit4.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-6.jpg", typeof(frmMain).Assembly);
            //UserFeedbackControl.pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.avatar-1.jpg", typeof(frmMain).Assembly);
            if(Blog.Conversation != null) {
                foreach(ConversationBlog BlogConversation in Blog.Conversation) {
                    countName++;
                    //CreateConversation(UserFeedbackControl, BlogConversation, countName);

                }
            }

            //   LayoutControlItem lci = layoutControl.AddItem("", UserFeedbackControl);
            // lci.TextVisible = false;
        }
        private void CreateConversation(UserFeedbackControl parentBlog, ConversationBlog blogConverstion, int countName) {
            //    UserComment userComment = new UserComment();
            //    userComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //    userComment.Name = countName.ToString();
            //    userComment.pictureEdit.Image = blogConverstion.Sender.Image;
            //    userComment.labelTime.Text = blogConverstion.SendTime.ToShortTimeString();
            //    userComment.labelFullName.Text = blogConverstion.Sender.FirstName + " " + blogConverstion.Sender.LastName;
            //    userComment.labelNickName.Text = blogConverstion.Sender.NickName;
            //    userComment.memoEdit.Text = blogConverstion.MessageBody;
            //    LayoutControlItem lci = new LayoutControlItem();
            //    lci.Name = countName.ToString();
            //    lci.Control = userComment;
            //    lci.SizeConstraintsType = SizeConstraintsType.Custom;
            //    lci.MinSize = lci.MaxSize = new System.Drawing.Size(600, 100);
            //    lci.Padding = new Utils.Padding(0, 0, 0, 0);

            //    lci.TextVisible = false;
            //    parentBlog.layoutControlGroup3.AddItem(lci);
            //parentBlog.layoutControl1.AddItem(lci, parentBlog.layoutControlGroup3, InsertType.Bottom);
        }
    }
}
#endif
