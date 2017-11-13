using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Xml.Serialization;
using DevExpress.Utils;
using DevExpress.Utils.Controls;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;

namespace SnapDemos.Modules {
    public class VideoList : XtraScrollableControl {
        const int PaddingBetweenItems = 5;
        const int VideoItemTextOffset = 8;

        int vScrollWidth;
        int hScrollHeight;
        Rectangle viewportBounds;

        public VideoList() {
            UserLookAndFeel.Default.StyleChanged += OnStyleChangedHandler;

            CreateLinks();
            UpdateLinksLayout();
        }

        protected Rectangle ViewportBounds { get { return viewportBounds; } }

        protected override VScrollBarViewInfoWithHandler CreateVScrollBar() {
            VScrollBarViewInfoWithHandler result = base.CreateVScrollBar();
            this.vScrollWidth = result.Width;
            return result;
        }
        protected override HScrollBarViewInfoWithHandler CreateHScrollBar() {
            HScrollBarViewInfoWithHandler result = base.CreateHScrollBar();
            this.hScrollHeight = result.Height;
            return result;
        }
        protected override void OnClientSizeChanged(EventArgs e) {
            base.OnClientSizeChanged(e);
            CalculateViewportBounds();
            UpdateLinksWidth();
        }
        protected override void OnPaddingChanged(EventArgs e) {
            base.OnPaddingChanged(e);
            CalculateViewportBounds();
            UpdateLinksLayout();
        }
        void OnStyleChangedHandler(object sender, EventArgs e) {
            UpdateLinksColor();
        }
        void CalculateViewportBounds() {
            this.viewportBounds.X = Padding.Left;
            this.viewportBounds.Y = Padding.Top;
            this.viewportBounds.Width = Math.Max(ClientRectangle.Width - this.vScrollWidth - Padding.Left - Padding.Right, 0);
            this.viewportBounds.Height = Math.Max(ClientRectangle.Height - this.hScrollHeight - Padding.Top - Padding.Bottom, 0);
        }
        void UpdateLinksColor() {
            Color linkColor = GetLinkColor(LookAndFeel);
            foreach (LinkLabel link in Controls) {
                link.LinkColor = linkColor;
                link.ActiveLinkColor = linkColor;
            }
        }
        void UpdateLinksWidth() {
            foreach (LinkLabel link in Controls)
                link.Width = ViewportBounds.Width;
        }
        void CreateLinks() {
            if (VideoSource.Data == null)
                return;

            foreach (VideoInfo video in VideoSource.Data) {
                LinkLabel link = CreateLinkLabel(video.GetImage(), video.Uri, video.Caption);
                Controls.Add(link);
            }
            UpdateLinksColor();
        }
        void UpdateLinksLayout() {
            int verticalPosition = ViewportBounds.Y;
            int horizontalPosition = ViewportBounds.X;
            foreach (LinkLabel link in Controls) {
                link.Location = new Point(horizontalPosition, verticalPosition);
                int height = Math.Max(link.Image.Height, link.Height);
                link.Height = height;
                verticalPosition += height + PaddingBetweenItems;
            }
            UpdateLinksWidth();
        }
        LinkLabel CreateLinkLabel(Image image, string uri, string text) {
            LinkLabel link = new LinkLabel();
            link.Image = image;
            link.Padding = new Padding(image.Width + VideoItemTextOffset, 0, 0, 0);
            link.TextAlign = ContentAlignment.MiddleLeft;
            link.LinkBehavior = LinkBehavior.HoverUnderline;
            link.ImageAlign = ContentAlignment.MiddleLeft;
            link.Text = text;
            link.AutoSize = false;
            link.Tag = uri;
            link.LinkClicked += OnLinkClicked;
            return link;
        }
        void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            LinkLabel link = sender as LinkLabel;
            if (link == null)
                return;

            try {
                System.Diagnostics.Process.Start((string)link.Tag);
            }
            catch {
            }
        }
        Color GetLinkColor(UserLookAndFeel lookAndFeel) {
            Color color = Color.Empty;
            if (lookAndFeel.ActiveStyle == DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin) {
                Skin skin = EditorsSkins.GetSkin(lookAndFeel);
                color = skin.Colors.GetColor(EditorsSkins.SkinHyperlinkTextColor);
            }
            return color.IsEmpty ? Color.Blue : color;
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                UserLookAndFeel.Default.StyleChanged -= OnStyleChangedHandler;
            }
            base.Dispose(disposing);
        }
    }

    public static class VideoSource {
        static List<VideoInfo> data;

        public static List<VideoInfo> Data {
            get {
                if (data == null)
                    data = GetDataSource();
                return data;
            }
        }

        static List<VideoInfo> GetDataSource() {
            string path = GetPathToResource("SnapDemos.Modules", "TrainingVideos.xml");
            using (Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(path)) {
                XmlSerializer s = new XmlSerializer(typeof(List<VideoInfo>), new XmlRootAttribute("Videos"));
                return (List<VideoInfo>)s.Deserialize(stream);
            }
        }
        static string GetPathToResource(string path, string name) {
            if (DevExpress.DXperience.Demos.DemoHelper.GetLanguageString(Assembly.GetCallingAssembly()) == "CS")
                return String.Format("{0}.{1}", path, name);
            else
                return name;
        }
    }
    [XmlType("Video")]
    public class VideoInfo {
        [XmlElement("Image")]
        public byte[] ImageData { get; set; }
        public string Uri { get; set; }
        public string Caption { get; set; }

        public Image GetImage() {
            if (ImageData == null)
                return null;
            try {
                using (MemoryStream stream = new MemoryStream(ImageData)) {
                    return Image.FromStream(stream);
                }
            }
            catch {
                return null;
            }
        }
    }
}
