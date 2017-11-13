using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.BrowserDemo {
    public class TabFormWebBrowser : WebBrowser {
        TabFormPage page;

        public TabFormWebBrowser(TabFormPage page) : base() {
            this.page = page;
        }
        public TabFormPage Page { get { return page; } }

        protected override void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e) {
            base.OnDocumentCompleted(e);
            OnDocumentCompletedCore(e);
        }

        protected void OnDocumentCompletedCore(WebBrowserDocumentCompletedEventArgs e) {
            if(Page == null || e.Url == null || string.IsNullOrEmpty(e.Url.Host) || Url == null || !object.Equals(Url.Host, e.Url.Host))
                return;
            try {
                string iconURL = "http://" + e.Url.Host + "/favicon.ico";
                System.Net.WebRequest request = System.Net.HttpWebRequest.Create(iconURL);
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream stream = response.GetResponseStream();
                Page.Image = Image.FromStream(stream);
            }
            catch { }
        }

        protected override void OnDocumentTitleChanged(System.EventArgs e) {
            base.OnDocumentTitleChanged(e);
            OnDocumentTitleChangedCore();
        }

        protected void OnDocumentTitleChangedCore() {
            if(Page == null) return;
            Page.Text = DocumentTitle;
        }
    }
}
