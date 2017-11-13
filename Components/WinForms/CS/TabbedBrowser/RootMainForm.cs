using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace TabbedBrowser {
    public partial class RootMainForm : XtraForm, DevExpress.XtraBars.Docking2010.IDocumentsHostWindow {
        BrowserMenu popupMenu;
        Dictionary<string, DateTime> allHistory;
        bool IsHistory, CloseForm, CanCreateAddTab;
        protected bool IsInitialized = true;
        string homeUrl = "http://devexpress.com/";
        public RootMainForm() {
            Initialize(new Dictionary<string, DateTime>(), FormWindowState.Maximized);
        }
        public RootMainForm(Dictionary<string, DateTime> allHistory, FormWindowState state) {
            Initialize(allHistory, state);
        }
        void Initialize(Dictionary<string, DateTime> allHistory, FormWindowState state) {
            InitializeComponent();
            tabbedView1.CustomDocumentsHostWindow += new CustomDocumentsHostWindowEventHandler(CustomDocumentsHostWindow);
            tabbedView1.FloatingDocumentContainer = FloatingDocumentContainer.DocumentsHost;
            tabbedView1.QueryControl += new QueryControlEventHandler(QueryControl);
            tabbedView1.Documents.CollectionChanged += new CollectionChangedHandler<BaseDocument>(DocumentsCollectionChanged);
            tabbedView1.TabMouseActivating += new DocumentCancelEventHandler(TabMouseActivating);
            tabbedView1.ControlReleasing += new ControlReleasingEventHandler(ControlReleasing);     
            CreateAddTab(null);
            tabbedView1.DocumentGroups.CollectionChanged += new CollectionChangedHandler<DocumentGroup>(DocumentGroupsCollectionChanged);
            tabbedView1.PopupMenuShowing += new PopupMenuShowingEventHandler(PopupMenuShowing);
            this.allHistory = allHistory;           
            CanCreateAddTab = true;
            WindowState = state;
        }
        void CreateMenu() {
            popupMenu = new BrowserMenu(barManager1);
        }
        void CreateAddTab(DocumentGroup group) {
            Document newDocument = CreateTab("+", group);
            newDocument.Properties.ShowInDocumentSelector = newDocument.Properties.AllowFloat = newDocument.Properties.AllowPin = newDocument.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
        }
        Document CreateTab(string caption, DocumentGroup group) {
            Document document = (Document)tabbedView1.AddDocument(caption, caption);
            if(group != null)
                tabbedView1.Controller.Dock(document, group);
            return document;
        }
        public void CreateNewTab() {
            ActivateTab(GetAddTab(GetActiveDocument().Parent));
        }
        public void CreateNewWindow(Control control) {
            tabbedView1.AddFloatingDocumentsHost(control);
            var manager = ((IDocumentsHostWindow)control.FindForm()).DocumentManager;
            Document doc = ((Document)manager.GetDocument(control));
            doc.ParentChanged += new DocumentEventHandler(DocumentParentChanged);
        }
        public void Navigate(string url) {
            Navigate(GetActiveDocument().Control, url);
        }
        void SetSelectedPrevTab(DocumentGroup group) {
            int index = group.SelectedItemIndex;
            if(index > 0) group.SetSelected(group.Items[index - 1]);
        }
        void ActivateTab(Document document) {
            if(IsAddTab(document))
                CanCreateAddTab = true;
            tabbedView1.Controller.Activate(document);
        }
        void RestoreAddTabButtonPosition(DocumentGroup group, Document document) {
            Document addTab = GetAddTab(group);
            using(BatchUpdate.Enter(group)) {
                if(CanRestoreAddTabButtonPosition(group.Items, addTab)) {
                    group.Items.Move(group.Items.Count, addTab);
                    if(document != null) group.SetSelected(document);
                }
            }
        }
        void RestoreAddTabButtonPositions() {
            DocumentGroup[] groups = tabbedView1.DocumentGroups.ToArray();
            foreach(DocumentGroup group in groups)
                RestoreAddTabButtonPosition(group, null);
        }
        bool CloseChildWindow(DocumentGroup group) {
            if(group.Items.Count <= 2) {
                Document document = GetAddTab(group);
                if(document != null) document.Dispose();
                if(tabbedView1.DocumentGroups.Count <= 1)
                    return true;
            }
            ActivateTab(group.SelectedDocument);
            return false;
        }
        Document GetAddTab(DocumentGroup group) {
            return group.Items.FindFirst(x => x.Caption == "+");
        }
        Document GetActiveDocument() {
            return (Document)tabbedView1.ActiveDocument;
        }
        void SetTabCaption(string Caption) {
            if(Caption != "")
                GetActiveDocument().Caption = Caption;
            else
                GetActiveDocument().Caption = "New Tab";
        }
        void AddHistory(string url) {
            if(url != null && !allHistory.ContainsKey(url))
                allHistory.Add(url, DateTime.Now);
        }
        bool QueryControlAddTab(QueryControlEventArgs e) {
            e.Control = !IsInitialized ? new BrowserControl() : new BrowserControl(homeUrl);
            e.Control.TextChanged += new EventHandler(TabTextChanged);
            ((BrowserControl)e.Control).ChangeHistory += new EventHandler(ChangeHistory);
            Document thisDoc = (Document)e.Document;
            return IsAddTab(thisDoc);
        }
        bool QueryControlHistory(QueryControlEventArgs e) {
            e.Control = new HistoryControl();
            ((HistoryControl)e.Control).ItemClick += new EventHandler(History_ItemClick);
            Document thisDoc = (Document)e.Document;
            return IsAddTab(thisDoc);
        }
        bool IsAddTab(Document document) {
            if(document.Caption == "+")
                return true;
            return false;
        }
        bool CanRestoreAddTabButtonPosition(DocumentCollection collection, Document addTab) {
            return collection.IndexOf(addTab) != collection.Count - 1;
        }
        void SetPropertyNewTab(Document document, string caption) {
            document.Properties.ShowInDocumentSelector = document.Properties.AllowFloat = document.Properties.AllowPin = document.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            document.Caption = caption;
        }
        void Navigate(Control browser, string url) {
            BrowserControl control = browser as BrowserControl;
            if(control != null)
                control.Navigate(url);
        }
        void BeginFloating(object sender, DocumentCancelEventArgs e) {
            BeginFloatingEventArgs ea = e as BeginFloatingEventArgs;
            Document document = (Document)e.Document;
            if(ea.FloatingReason != FloatingReason.DoubleClick) {
                SetSelectedPrevTab(document.Parent);
                CloseChildWindow(document.Parent);
            }
            else e.Cancel = document.Parent.Items.Count == 2;
        }
        void EndDocking(object sender, DocumentEventArgs e) {
            RestoreAddTabButtonPosition(((Document)e.Document).Parent, (Document)e.Document);
        }
        void CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e) {
            if(e.Document != null) {
                ActivateTab(e.Document);
                if(e.Button.Index == 0)
                    Navigate(e.Document.Control, homeUrl);
                if(e.Button.Index == 1) {
                    IsHistory = true;
                    ActivateTab(GetAddTab(e.Document.Parent));
                }
                if(e.Button.Index == 2) {
                    if(popupMenu == null)
                        CreateMenu();
                    popupMenu.ShowPopup(barManager1, documentManager1.ClientToScreen(
                        new Point(e.Document.Control.Parent.Right - 133, e.Document.Control.Parent.Top - 1)));
                }
            }
        }
        void History_ItemClick(object sender, EventArgs e) {
            string tag;
            DevExpress.XtraBars.ItemClickEventArgs itemArgs = e as DevExpress.XtraBars.ItemClickEventArgs;
            tag = itemArgs != null ? itemArgs.Item.Tag.ToString() : "DoubleClick";
            if(tag == "DoubleClick" || tag == "Open in new Tab") {
                Document document = GetAddTab(GetActiveDocument().Parent);
                ActivateTab(document);
                ((BrowserControl)document.Control).Navigate(((HistoryItem)sender).Url);
            }
            if(tag == "Open in new Window") {
                CreateNewWindow(new BrowserControl(((HistoryItem)sender).Url));
            }
        }
        void TabTextChanged(object sender, EventArgs e) {
            BrowserControl browserControl = ((BrowserControl)sender);
            if(tabbedView1.ActiveDocument == null)
                ActivateTab((Document)tabbedView1.Documents[0]);
            SetTabCaption(browserControl.GetCaption);
        }
        void ChangeHistory(object sender, EventArgs e) {
            string url = sender.ToString() == "" ? "New Tab" : sender.ToString();
            AddHistory(url);
        }
        void ClearHistory(object sender, EventArgs e) {
            allHistory.Clear();
        }
        void CustomDocumentsHostWindow(object sender, DevExpress.XtraBars.Docking2010.CustomDocumentsHostWindowEventArgs e) {
            e.Constructor = delegate() { return new HostWindow(allHistory, this); };
        }
        void DocumentGroupsCollectionChanged(DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs<DocumentGroup> ea) {
            if(ea.ChangedType == DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded) {
                CreateAddTab(ea.Element);
            }
        }
        void QueryControl(object sender, QueryControlEventArgs e) {
            if(IsHistory ? QueryControlHistory(e) : QueryControlAddTab(e)) {
                if(!CanCreateAddTab) {
                    BeginInvoke(new Action(() => tabbedView1.ReleaseDeferredLoadControl(e.Document)));
                    SetSelectedPrevTab(((Document)e.Document).Parent);
                    ActivateTab(((Document)e.Document).Parent.SelectedDocument);
                }
                else {
                    SetPropertyNewTab((Document)e.Document, IsHistory ? "History" : "New Tab");
                    ((Document)e.Document).ParentChanged += new DocumentEventHandler(DocumentParentChanged);
                    BeginInvoke(new Action(() => CreateAddTab(((Document)e.Document).Parent)));
                }
                IsHistory = false;
            }
            IsInitialized = false;
            CanCreateAddTab = false;
        }
        void ControlReleasing(object sender, ControlReleasingEventArgs e) {                   
            if(IsAddTab((Document)e.Document)) {
                e.Cancel = false;
                e.DisposeControl = true;
            }
        }
        void TabMouseActivating(object sender, DocumentCancelEventArgs e) {
            if(((Document)e.Document).Caption == "+")
                CanCreateAddTab = true;
        }
        void PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            Document document = e.GetDocument() as Document;
            if(document != null && document.Parent.Items.Count == 2) {
                e.Menu.Remove(BaseViewControllerCommand.Float);
                e.Menu.Remove(TabbedViewControllerCommand.NewVerticalDocumentGroup);
                e.Menu.Remove(TabbedViewControllerCommand.NewHorizontalDocumentGroup);
                e.Menu.Remove(TabbedViewControllerCommand.MoveToPrevDocumentGroup);
                e.Menu.Remove(TabbedViewControllerCommand.MoveToNextDocumentGroup);
            }
        }
        void DocumentParentChanged(object sender, DocumentEventArgs e) {
            Document document = (Document)sender;
            if(document.Parent != null)
                RestoreAddTabButtonPosition(document.Parent, document);  
        }
        void DocumentsCollectionChanged(DevExpress.XtraBars.Docking2010.Base.CollectionChangedEventArgs<BaseDocument> ea) {
            XtraUserControl control = ea.Element.Control as XtraUserControl;
            if(control != null) {
                if(ea.ChangedType == DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementAdded) {
                    if(control is BrowserControl) control.TextChanged += new EventHandler(TabTextChanged);
                    if(control is HistoryControl) ((HistoryControl)control).ItemClick += new EventHandler(History_ItemClick);
                }
                if(ea.ChangedType == DevExpress.XtraBars.Docking2010.Base.CollectionChangedType.ElementRemoved) {
                    if(control is BrowserControl) control.TextChanged -= new EventHandler(TabTextChanged);
                    if(control is HistoryControl) ((HistoryControl)control).ItemClick -= new EventHandler(History_ItemClick);
                }
            }
        }
        void DocumentActivated(object sender, DocumentEventArgs e) {
            if(e.Document.Caption == "History") {
                ((HistoryControl)e.Document.Control).Update(allHistory);
            }
        }
        void BeginDocumentsHostDocking(object sender, DocumentCancelEventArgs e) {
            TabbedView view = e.Document.Manager.View as TabbedView;
            if(view != null)
                foreach(DocumentGroup group in view.DocumentGroups) {
                    BaseDocument document = GetAddTab(group);
                    if(document != null) document.Dispose();
                }
        }
        void DocumentClosing(object sender, DocumentCancelEventArgs e) {
            DocumentGroup group = ((Document)e.Document).Parent;
            if(group != null) {
                SetSelectedPrevTab(group);  
                CloseForm = CloseChildWindow(group);
            }
        }
        void DocumentClosed(object sender, DocumentEventArgs e) {            
            if(CloseForm)
                BeginInvoke(new Action(this.Close));
        }
        #region IDocumentHostWindow Members
        bool IDocumentsHostWindow.DestroyOnRemovingChildren {
            get { return true; }
        }
        DocumentManager IDocumentsHostWindow.DocumentManager {
            get { return documentManager1; }
        }
        void IDocumentsHostWindow.Show() {
            RestoreAddTabButtonPositions();
            this.Shown -= TabbedBrowserApplicationContext.rootForm_Shown;
            this.Disposed -= TabbedBrowserApplicationContext.rootForm_Disposed;
            this.Shown += TabbedBrowserApplicationContext.rootForm_Shown;
            this.Disposed += TabbedBrowserApplicationContext.rootForm_Disposed;
            base.Show();
        }        
        #endregion
    }

    class BrowserMenu : PopupMenu {
        public BrowserMenu(BarManager barManeger)
            : base(barManeger) {
            this.Add("New Tab");
            this.Add("New Window");
            this.AddGallerySkin("Skin");
            this.Add("Help");
            this.Add("Support");
            this.Add("About");
            Manager = barManeger;
        }
        public BarItemLink Add(string menuCaption) {
            return this.AddItem(AddToCollection(menuCaption));
        }
        BarButtonItem AddToCollection(string menuCaption) {
            BarButtonItem newMenu = new BarButtonItem(Manager, menuCaption);
            newMenu.Tag = menuCaption;
            newMenu.ItemClick += new ItemClickEventHandler(browserMenu_Click);
            return newMenu;
        }
        void AddRange(BarItemLinkCollection subMenu, List<string> menuCaption) {
            if(menuCaption != null) {
                foreach(string caption in menuCaption)
                    subMenu.Add(AddToCollection(caption));
            }
        }
        public BarSubItem Add(string subMenuCaption, List<string> menuCaption) {
            BarSubItem newSubMenu = new BarSubItem(Manager, subMenuCaption);
            newSubMenu.Tag = subMenuCaption;
            AddRange(newSubMenu.ItemLinks, menuCaption);
            this.AddItem(newSubMenu);
            return newSubMenu;
        }
        public BarButtonItem AddGallerySkin(string caption) {
            PopupMenu gallery = new PopupMenu();
            gallery.Manager = Manager;
            SkinHelper.InitSkinPopupMenu(gallery);
            BarButtonItem galleryMenu = new BarButtonItem(Manager, caption);
            galleryMenu.ButtonStyle = BarButtonStyle.DropDown;
            galleryMenu.DropDownControl = gallery;
            galleryMenu.ActAsDropDown = true;
            this.AddItem(galleryMenu);
            return galleryMenu;
        }

        void browserMenu_Click(object sender, ItemClickEventArgs e) {
            RootMainForm mainForm = ((RootMainForm)this.Manager.Form);
            switch(e.Item.Tag.ToString()) {
                case "New Tab":
                    mainForm.CreateNewTab(); break;
                case "New Window":
                    mainForm.CreateNewWindow(new BrowserControl()); break;
                case "Help":
                    mainForm.Navigate("http://www.devexpress.com/Products/NET/Controls/WinForms/Bars"); break;
                case "Support":
                    mainForm.Navigate("http://www.devexpress.com/Support"); break;
                case "About":
                BarManager.About();
                    break;
            }
        }
    }
}
