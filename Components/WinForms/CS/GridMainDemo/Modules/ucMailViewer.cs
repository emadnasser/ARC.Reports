using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.Utils.Menu;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid.Demos;
using DevExpress.Utils.Design;

namespace DevExpress.XtraGrid.Demos {
    public partial class ucMailViewer : XtraUserControl {
        public ucMailViewer() {
            InitializeComponent();
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
        }
        public void SetMenuManager(IDXMenuManager manager) {
            recMessage.MenuManager = manager;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode)
                LookAndFeelStyleChanged();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && !DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
            base.Dispose(disposing);
        }
        void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e) {
            LookAndFeelStyleChanged();
        }
        void LookAndFeelStyleChanged() {
            Color windowColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window");
            Color windowTextColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
            lcTitle.Appearance.BackColor = windowColor;
            lcTitle.Appearance.ForeColor = windowTextColor;
        }
        void ShowMessageAdditions(bool visible) {
            layoutControlItem4.Visibility =
                layoutControlItem5.Visibility = visible ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        internal void ShowMessage(DevExpress.XtraGrid.Demos.Message message) {
            if(message == null) return;
            ShowMessageAdditions(true);
            lcTitle.Text = string.Format("<size=+3><b>{0}<br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br>", message.Subject, message.From, message.Date, GetFromString(message.MailType), Date);
            recMessage.HtmlText = message.Text;
        }
        private string GetFromString(MailType mailType) {
            return DevExpress.XtraGrid.Demos.Properties.Resources.FromString;
        }
        internal void ShowMessagesInfo(List<DevExpress.XtraGrid.Demos.Message> messages) {
            ShowMessageAdditions(false);
            lcTitle.Text = string.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, MessageFromCount);
            string text =  MessageTile;
            foreach(DevExpress.XtraGrid.Demos.Message message in messages) {
                text += string.Format(MessageTileEx, message.From, message.Date, message.Subject);
            }
            text += MessageTileEnd;
            recMessage.HtmlText = text;
        }
        internal void ClearInfo() {
            lcTitle.Text = string.Empty;
            recMessage.Text = string.Empty;
            layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }
        public float ZoomFactor {
            get { return recMessage.Views.SimpleView.ZoomFactor; }
            set { recMessage.Views.SimpleView.ZoomFactor = value; }
        }
        public RichEditControl RichEdit { get { return recMessage; } }

        private void bbiReply_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }
        private void bbiReplyAll_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }
        private void bbiForward_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
        }
        const string MessageTile = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\"><html><body><style type=\"text/css\">.style1{font-size: x-small;font-family: \"Segoe UI\";}.style2{font-family: \"Segoe UI\";color: #666666;}.style3{font-family: \"Segoe UI\";}</style>";
        const string MessageTileEx = "<span class=\"style3\">{0} (</span><span class=\"style1\">{1}</span><span class=\"style3\">)</span><span class=\"style2\"><br />{2}<br /><br /></span>";
        const string MessageTileEnd = "</body></html>";
        const string MessageFromCount = "Message(s)";
        const string Date = "Date";
    }
}
