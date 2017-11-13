using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace TabbedBrowser {
    public partial class BrowserControl : XtraUserControl {
        string thisUrl;
        internal string GetCaption { get { return webBrowser.Url.Host; } }
        static readonly object changeHistoryCore = new object();
        public event EventHandler ChangeHistory {
            add { Events.AddHandler(changeHistoryCore, value); }
            remove { Events.RemoveHandler(changeHistoryCore, value); }
        }
        public BrowserControl() {
            Initialize("");
        }
        public BrowserControl(string url) {
            Initialize(url);
        }
        void Initialize(string url) {
            InitializeComponent();
            CreateBrowser(url);
        }
        void CreateBrowser(string url) {
            layoutControl.BeginUpdate();
            Forward.Enabled = Back.Enabled = false;
            webBrowser.Navigate(url);
            webBrowser.CanGoBackChanged += new EventHandler(CanGoBackChanged);
            webBrowser.CanGoForwardChanged += new EventHandler(CanGoForwardChanged);
            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(Navigated);
            layoutControl.EndUpdate();
        }
        void ActivePanelChanged(object sender, ActivePanelChangedEventArgs e) {
            if(e.OldPanel != null) e.OldPanel.Hide();
        }
        void Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            Text = thisUrl = AddressBar.Text = webBrowser.Url.ToString();
            EventHandler handler = (EventHandler)Events[changeHistoryCore];
            if(handler != null) handler(webBrowser.Url.ToString(), e);
        }
        void CanGoForwardChanged(object sender, EventArgs e) {
            Forward.Enabled = webBrowser.CanGoForward;
        }
        void CanGoBackChanged(object sender, EventArgs e) {
            Back.Enabled = webBrowser.CanGoBack;
        }
        void NavigateCore(string url) {
            webBrowser.Navigate(new Uri(url));
        }
        public void Navigate(string url) {
            try {
                NavigateCore(url);
            }
            catch {
                try {
                    NavigateCore("http://" + url);
                }
                catch { }
            }
        }
        void AddressBarKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) Navigate(AddressBar.EditValue.ToString());
        }
        void buttonsPanel_ButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(e.Item == Back) webBrowser.GoBack();
            if(e.Item == Forward) webBrowser.GoForward();
            if(thisUrl != null && e.Item == Refresh_button) NavigateCore(thisUrl);
        }
    }
}
