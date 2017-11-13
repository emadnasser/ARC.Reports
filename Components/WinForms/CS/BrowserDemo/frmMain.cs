using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace DevExpress.XtraBars.Demos.BrowserDemo {
    public partial class frmMain : TabForm {
        public frmMain() : this(true){ }
        public frmMain(bool hasPage) {
            InitializeComponent();
            Initialize(hasPage);
        }
        protected void Initialize(bool shouldCreateWebBrowser) {
            this.shouldInitHomePage = shouldCreateWebBrowser;
            if(shouldCreateWebBrowser) {
                CreatePageWebBrowser(TabFormControl.SelectedPage);
                SubscribeOnPageEvents();
            }
            else {
                TabFormControl.Pages.Clear();
                TabFormControl.SelectedPage = null;
            }
            TabFormControl.SelectedPageChanged += OnSelectedPageChanged;
            TabFormControl.SelectedPageChanging += OnSelectedPageChanging;
            TabFormControl.PageCreated += OnPageCreated;
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("BrowserDemo.AppIcon.ico", typeof(frmMain).Assembly);
            barManager1.ForceLinkCreate();
            barManager1.GetController().Changed += new EventHandler(ChangedController);
            InitSkins();
            this.Focus();
        }

        void OnPageCreated(object sender, PageCreatedEventArgs e) {
            CreatePageWebBrowser(e.Page);
        }
        static bool BrowserVersionChecked = false;
        void CreatePageWebBrowser(TabFormPage page) {
            TabFormWebBrowser browser = new TabFormWebBrowser(page);
            UpdateWebBrowserVersion(browser);
            page.ContentContainer.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.ScriptErrorsSuppressed = true;
            page.ContentContainer.Controls.Add(new BrowserNavigationControl());
        }

        void UpdateWebBrowserVersion(WebBrowser browser) {
            if(BrowserVersionChecked) return;
            BrowserVersionChecked = true;
            RegistryKey regkey = GetBrowserEmulationRegKey();
            if(regkey == null) return;
            int optimalVersion = GetOptimalBrowserVersion(browser);
            string processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            try {
                object curVal = regkey.GetValue(processName);
                if(!(curVal is int) || (int)curVal != optimalVersion)
                    regkey.SetValue(processName, unchecked(optimalVersion), RegistryValueKind.DWord);
            }
            catch { }
            finally { regkey.Close(); }

        }
        protected int GetOptimalBrowserVersion(WebBrowser browser) {
            int majorVersion = browser.Version.Major;
            if(majorVersion >= 11) return 11001;
            if(majorVersion == 10) return 10001;
            if(majorVersion == 9) return 9999;
            if(majorVersion == 8) return 8888;
            return 7000;
        }

        protected RegistryKey GetBrowserEmulationRegKey() {
            try {
                RegistryKey key = null;
                string keyPath = "SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION";
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyPath, true);
                if(key != null) return key;
                return Microsoft.Win32.Registry.CurrentUser.CreateSubKey(keyPath);
            }
            catch { }
            return null;
        }

        void OnSelectedPageChanging(object sender, TabFormSelectedPageChangingEventArgs e) {
            UnsubscribeOnPageEvents();
        }
        void OnSelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e) {
            SubscribeOnPageEvents();
            if(NavigationPanel == null) return;
            if(WebBrowser == null || WebBrowser.Url == null)
                NavigationPanel.SearchItem.EditValue = string.Empty;
            else NavigationPanel.SearchItem.EditValue = WebBrowser.Url.AbsoluteUri;
			CheckButtons();
        }
        void CheckButtons() {
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward;
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack;
        }
        void SubscribeOnPageEvents() {
            if(WebBrowser != null) {
                WebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
                WebBrowser.CanGoBackChanged += new EventHandler(OnWebBrowserCanGoBackChanged);
                WebBrowser.CanGoForwardChanged += new EventHandler(OnWebBrowserCanGoForwardChanged);
                NavigationPanel.SearchPanel.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repositoryItemComboBox1_CloseUp);
                NavigationPanel.SearchPanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repositoryItemComboBox1_KeyDown);
                NavigationPanel.SearchPanel.Validating += new System.ComponentModel.CancelEventHandler(this.repositoryItemComboBox1_Validating);
                NavigationPanel.BackButton.ItemClick += OnBackButtonItemClick;
                NavigationPanel.ForwardButton.ItemClick += OnForwardButtonItemClick;
                NavigationPanel.RefreshButton.ItemClick += OnRefreshButtonItemClick;
            }
        }
        void UnsubscribeOnPageEvents() {
            if(WebBrowser != null) {
                WebBrowser.Navigated -= new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
                WebBrowser.CanGoBackChanged -= new EventHandler(OnWebBrowserCanGoBackChanged);
                WebBrowser.CanGoForwardChanged -= new EventHandler(OnWebBrowserCanGoForwardChanged);
                NavigationPanel.SearchPanel.CloseUp -= new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.repositoryItemComboBox1_CloseUp);
                NavigationPanel.SearchPanel.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.repositoryItemComboBox1_KeyDown);
                NavigationPanel.SearchPanel.Validating -= new System.ComponentModel.CancelEventHandler(this.repositoryItemComboBox1_Validating);
                NavigationPanel.BackButton.ItemClick -= OnBackButtonItemClick;
                NavigationPanel.ForwardButton.ItemClick -= OnForwardButtonItemClick;
                NavigationPanel.RefreshButton.ItemClick -= OnRefreshButtonItemClick;
            }
        }

        public WebBrowser WebBrowser {
            get {
                if(TabFormControl.SelectedPage == null)
                    return null;
                foreach(Control ctrl in TabFormControl.SelectedPage.ContentContainer.Controls) {
                    if(ctrl is WebBrowser) return ctrl as WebBrowser;
                }
                return null;
            }
        }
        public BrowserNavigationControl NavigationPanel {
            get {
                if(TabFormControl.SelectedPage == null)
                    return null;
                foreach(Control ctrl in TabFormControl.SelectedPage.ContentContainer.Controls) {
                    if(ctrl is BrowserNavigationControl) return ctrl as BrowserNavigationControl;
                }
                return null;
            }
        }


        private bool skinProcessing = false;
        string currentAddress = "";

        #region Skins

        void InitSkins() {
            barManager1.ForceInitialize();
        }

        private void ChangedController(object sender, EventArgs e) {
            if(skinProcessing) return;
            string paintStyleName = barManager1.GetController().PaintStyleName;
            if("DefaultSkin".IndexOf(paintStyleName) >= 0)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            else DevExpress.Skins.SkinManager.DisableFormSkins();
            skinProcessing = true;
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            skinProcessing = false;
        }
        #endregion

        private void AddNewItem(string s) {
            if(NavigationPanel == null) return;
            if(s != "") {
                bool isAdded = false;
                for(int i = 0; i < NavigationPanel.SearchPanel.Items.Count; i++)
                    if(NavigationPanel.SearchPanel.Items[i].ToString() == s) {
                        isAdded = true;
                        break;
                    }
                if(!isAdded)
                    NavigationPanel.SearchPanel.Items.Add(s);
            }
        }

        private void GoToItem(string address) {
            if(address == null) return;
            if(currentAddress != address) {
                NavigationPanel.SearchItem.EditValue = address;
                try {
                    if(WebBrowser != null && !WebBrowser.IsBusy) WebBrowser.Navigate(address);
                }
                catch { }
            }
        }

        string Address {
            get {
                if(barManager1.ActiveEditor != null && barManager1.ActiveEditor.EditValue != null)
                    return barManager1.ActiveEditor.EditValue.ToString();
                return null;
            }
        }

        private void repositoryItemComboBox1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e) {
            GoToItem(Address);
        }

        private void repositoryItemComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            DevExpress.XtraEditors.ComboBoxEdit edit = sender as DevExpress.XtraEditors.ComboBoxEdit;
            if(e.KeyData == Keys.Escape) {
                e.Handled = true;
                edit.SelectAll();
            }
            if(e.KeyData == Keys.Enter && !edit.IsPopupOpen) {
                NavigationPanel.Manager.ActiveEditItemLink.PostEditor();
                edit.SelectAll();
                e.Handled = true;
                GoToItem(NavigationPanel.SearchItem.EditValue.ToString());
            }
        }
        private void repositoryItemComboBox1_Validating(object sender, CancelEventArgs e) {
            GoToItem(Address);
        }

        string blankString = "about:blank";
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            if(!object.Equals(sender, WebBrowser)) return;
            string documentUri = WebBrowser.Url.AbsoluteUri;
            string eventUri = e.Url.AbsoluteUri;
            if(eventUri == blankString) return;
            if(documentUri != eventUri) return;
            if(barManager1.ActiveEditor != null)
                barManager1.ActiveEditItemLink.CloseEditor();
            if(CorrectAddress(eventUri)) {
                NavigationPanel.SearchItem.EditValue = eventUri;
                currentAddress = eventUri;
                AddNewItem(eventUri);
            }
        }
        private void OnWebBrowserCanGoForwardChanged(object sender, EventArgs e) {
            NavigationPanel.ForwardButton.Enabled = WebBrowser.CanGoForward;
        }
        private void OnWebBrowserCanGoBackChanged(object sender, EventArgs e) {
            NavigationPanel.BackButton.Enabled = WebBrowser.CanGoBack;
        }

        bool CorrectAddress(string name) {
            string[] names = new string[] { "javascript:" };
            foreach(string s in names)
                if(name.IndexOf(s) == 0) return false;
            return true;
        }

        private void OnRefreshButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(WebBrowser == null || WebBrowser.Url == null) return;
            WebBrowser.Navigate(WebBrowser.Url.AbsoluteUri);
        }

        private void OnBackButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                if(WebBrowser != null) WebBrowser.GoBack();
            }
            catch { }
        }

        private void OnForwardButtonItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                if(WebBrowser != null) WebBrowser.GoForward();
            }
            catch { }
        }

        bool shouldInitHomePage = true;
        void InitHomePage() {
            GoToItem("www.devexpress.com/Subscriptions/Universal.xml");
        }

        private void frmMain_Load(object sender, System.EventArgs e) {
            if(this.shouldInitHomePage)
                BeginInvoke(new MethodInvoker(InitHomePage));
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e) {
            e.Form = new frmMain(false);
            OpenFormCount++;
        }
        static int OpenFormCount = 1;
    }
}
