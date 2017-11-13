using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;

namespace DevExpress.XtraLayout.Demos {
    public partial class ImageLayout : TutorialControl {
        public ImageLayout() {
            InitializeComponent();
        }
        Image sImage = null;
        Color skinColor;
        SkinPaddingEdges sMargings;
        protected void ModifyActualSkin(bool visible) {
            SkinElement groupElement = DevExpress.Skins.CommonSkins.GetSkin(layoutControl1.LookAndFeel)[DevExpress.Skins.CommonSkins.SkinGroupPanel];
            SkinElement itemElement = DevExpress.Skins.CommonSkins.GetSkin(layoutControl1.LookAndFeel)[DevExpress.Skins.CommonSkins.SkinLayoutItemBackground];
            if(visible) {
                sImage = groupElement.Image.Image;
                groupElement.Image.Image = null;
                skinColor = groupElement.Color.BackColor;
                groupElement.Color.BackColor = Color.FromArgb(222, 227, 232);
                sMargings = itemElement.ContentMargins;
                itemElement.ContentMargins.All = 0;
                layoutControl1.Refresh();
            }
            else {
                groupElement.Image.Image = sImage;
                groupElement.Color.BackColor = skinColor;
                itemElement.ContentMargins.Bottom = sMargings.Bottom;
                itemElement.ContentMargins.Left = sMargings.Left;
                itemElement.ContentMargins.Right = sMargings.Right;
                itemElement.ContentMargins.Top = sMargings.Top;
            }
            Form form = this.FindForm();
            form.Invalidate(true);
            form.Update();
        }
        private void pictureEdit2_MouseUp(object sender, MouseEventArgs e) {
            labelControl2.Text = "The design of a Porsche always speaks in a universal language: People everywhere love to drive. But something about a Boxster speaks with a voice like that of a Siren. It calls to you, and resistance seems futile. What its aerodynamically chiseled exterior promises is too enticing. What its aesthetically intelligent interior conveys is too compelling. If driving is your passion, there is no substitute for the sheer inspiration of the Boxster.";
            labelControl1.Text = "Boxster";
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.Boxster.jpg", typeof(frmMain).Assembly);

        }

        private void pictureEdit4_MouseUp(object sender, MouseEventArgs e) {
            labelControl2.Text = "Tour the Cayman's front, side and rear surfaces with your eyes, and you immediately sense Porsche's love of curves. The body's muscular, sculpted features are thought by some to be an adaptation of the twists and turns found along our favorite roads. Each meeting of convex and concave surfaces is designed to move the air and the drivers soul with equal ease.";
            labelControl1.Text = "Cayman";
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.cayman.jpg", typeof(frmMain).Assembly);
        }

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e) {
            labelControl2.Text = "In terms of engineering, the 911 offers a simple definition of precision: Improve that which is essential. Remove that which is not. Focus on that which matters most: the driver. This same set of principles is also expressed in the all-new passenger compartment.";
            labelControl1.Text = "911";
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.911.jpg", typeof(frmMain).Assembly);

        }

        private void pictureEdit3_MouseUp(object sender, MouseEventArgs e) {
            labelControl2.Text = "The Porsche Cayenne is a mid-size luxury SUV produced by the German automaker Porsche since 2002. It is the first V8 engined vehicle built by Porsche since 1995, when the Porsche 928 was discontinued. Sales of the Cayenne have been strong, with 100,000 sold as of June 2005, becoming Porsche's best-selling vehicle in North America. 40% of Cayenne sales are in North America. Sales slowed by 2006. The Cayenne was skipped for the 2007 model year, but has been redesigned for 2008.";
            labelControl1.Text = "Cayenne";
            pictureEdit5.Image = DevExpress.Utils.ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.Cayenne.jpg", typeof(frmMain).Assembly);

        }
        public override DevExpress.DXperience.Demos.RibbonMenuManager RibbonMenuManager {
            get {
                return base.RibbonMenuManager;
            }
            set {
                base.RibbonMenuManager = value;
                ModifyActualSkin(value != null);
            }
        }
        private void ImageLayout_Load(object sender, EventArgs e) {
            pictureEdit2.Focus();
            pictureEdit2_MouseUp(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }
    }
}
