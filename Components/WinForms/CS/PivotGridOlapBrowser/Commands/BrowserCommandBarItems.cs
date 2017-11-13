using DevExpress.Utils.Commands;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Commands;
using DevExpress.XtraCharts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace PivotGridOlapBrowser.Commands.UI {
    #region IPivotGridBrowserBarItem interface
    public interface IPivotGridBrowserBarItem {
        PivotGridBrowser Browser { get; set; }
        BrowserCommandId CommandId { get; }
        void Update();
    }
    #endregion

    #region BrowserCommandBarButtonItem
    public abstract class BrowserCommandBarButtonItem : CommandBasedBarButtonItem, IPivotGridBrowserBarItem {
        BrowserCommandBarItemHelper browserHelper;

        public BrowserCommandBarButtonItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager) {
            browserHelper = new BrowserCommandBarItemHelper(pivotGridBrowser);
            UpdateItemCaption();
        }

        protected PivotGridBrowser InternalBrowser {
            get { return browserHelper.Browser; }
            set {
                if(browserHelper.ChangeBrowser(value))
                    OnBrowserChanged();
            }
        }
        protected abstract BrowserCommandId InternalCommandId { get; }
        protected void Update() {
            UpdateItemVisibility();
        }
		protected virtual void OnBrowserChanged() {
		}
        protected override Command CreateCommand() {
            if(browserHelper == null) return null;
            return browserHelper.CreateCommand(InternalCommandId);
        }
        protected override void OnClick(BarItemLink link) {
            base.OnClick(link);
            ((BrowserCommandBarButtonItem)link.Item).InvokeCommand();
        }
        #region IPivotGridBrowserBarItem Members
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        PivotGridBrowser IPivotGridBrowserBarItem.Browser { get { return this.InternalBrowser; } set { this.InternalBrowser = value; } }

        BrowserCommandId IPivotGridBrowserBarItem.CommandId { get { return this.InternalCommandId; } }

        void IPivotGridBrowserBarItem.Update() { this.Update(); }
        #endregion

        #region IDisposable implementation
        protected override void Dispose(bool disposing) {
            try {
                if(disposing) {
                    browserHelper.ChangeBrowser(null);
                }
            } finally {
                base.Dispose(disposing);
            }
        }
        #endregion
    }
    #endregion

    #region BrowserCommandBarCheckItem
    public abstract class BrowserCommandBarCheckItem : CommandBasedBarCheckItem, IPivotGridBrowserBarItem {
        BrowserCommandBarItemHelper browserHelper;

        public BrowserCommandBarCheckItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager) {
            browserHelper = new BrowserCommandBarItemHelper(pivotGridBrowser);
            UpdateItemCaption();
        }
                
        protected PivotGridBrowser InternalBrowser {
            get { return browserHelper.Browser; }
            set {
                if(browserHelper.ChangeBrowser(value))
                    OnBrowserChanged();
            }
        }
        protected abstract BrowserCommandId InternalCommandId { get; }
        protected abstract void ApplyChecking();

        protected void Update() {
            UpdateItemVisibility();
            UpdateItemChecked();
        }
        protected virtual void OnBrowserChanged() {
        }
        protected override void RaiseCheckedChanged() {
            base.RaiseCheckedChanged();
            ApplyChecking();
        }
        protected override Command CreateCommand() {
            if(browserHelper == null) return null;
            return browserHelper.CreateCommand(InternalCommandId);
        }

        #region IPivotGridBrowserBarItem Members
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        PivotGridBrowser IPivotGridBrowserBarItem.Browser { get { return this.InternalBrowser; } set { this.InternalBrowser = value; } }

        BrowserCommandId IPivotGridBrowserBarItem.CommandId { get { return this.InternalCommandId; } }

        void IPivotGridBrowserBarItem.Update() { this.Update(); }
        #endregion

        #region IDisposable implementation
        protected override void Dispose(bool disposing) {
            try {
                if(disposing) {
                    browserHelper.ChangeBrowser(null);
                }
            } finally {
                base.Dispose(disposing);
            }
        }
        #endregion
    }
    #endregion

    #region BrowserCommandBasedBarSubItem
    public abstract class BrowserCommandBasedBarSubItem : CommandBasedBarSubItem, IPivotGridBrowserBarItem {
        BrowserCommandBarItemHelper browserHelper;

        public BrowserCommandBasedBarSubItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager) {
            browserHelper = new BrowserCommandBarItemHelper(pivotGridBrowser);
            UpdateItemCaption();
        }
                
        protected PivotGridBrowser InternalBrowser {
            get { return browserHelper.Browser; }
            set {
                if(browserHelper.ChangeBrowser(value))
                    OnBrowserChanged();
            }
        }
        protected abstract BrowserCommandId InternalCommandId { get; }

        protected void Update() {
            UpdateItemVisibility();
            UpdateItemChecked();
        }
        protected virtual void OnBrowserChanged() {
        }
        protected override Command CreateCommand() {
            if(browserHelper == null) return null;
            return browserHelper.CreateCommand(InternalCommandId);
        }

        #region IPivotGridBrowserBarItem Members
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        PivotGridBrowser IPivotGridBrowserBarItem.Browser { get { return this.InternalBrowser; } set { this.InternalBrowser = value; } }

        BrowserCommandId IPivotGridBrowserBarItem.CommandId { get { return this.InternalCommandId; } }

        void IPivotGridBrowserBarItem.Update() { this.Update(); }
        #endregion

        #region IDisposable implementation
        protected override void Dispose(bool disposing) {
            try {
                if(disposing) {
                    browserHelper.ChangeBrowser(null);
                }
            } finally {
                base.Dispose(disposing);
            }
        }
        #endregion
    }
    #endregion

    #region BrowserCommandBarItemHelper
    class BrowserCommandBarItemHelper {
        PivotGridBrowser browser;

        public BrowserCommandBarItemHelper(PivotGridBrowser browser) {
            this.browser = browser;
        }
        public Command CreateCommand(BrowserCommandId commandId) {
            if(browser == null) return null;
            return browser.CreateCommand(commandId);
        }
        public bool ChangeBrowser(PivotGridBrowser newBrowser) {
            if(Object.ReferenceEquals(this.browser, newBrowser))
                return false;
            UnsubscribeControlEvents();
            this.browser = newBrowser;
            if(this.browser != null)
                SubscribeControlEvents();
            return true;
        }
        public PivotGridBrowser Browser { get { return this.browser; } }

        protected virtual void SubscribeControlEvents() {
            if(this.browser == null) return;
            //TODO: browser.BeforeDispose += new EventHandler(...);
        }
        protected virtual void UnsubscribeControlEvents() {
            if(this.browser == null) return;
            //TODO: browser.BeforeDispose -= new EventHandler(...);
        }
    }
    #endregion

    #region ConnectToItem
    public class ConnectToItem : BrowserCommandBarButtonItem {
        public ConnectToItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ConnectTo; } }
    }
    #endregion

    #region CreateReportItem
    public class CreateReportItem : BrowserCommandBarButtonItem {
        public CreateReportItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.CreateReport; } }
    }
    #endregion

    #region ShowChartFromPivotItem
    public class ShowChartFromPivotItem : BrowserCommandBarButtonItem {
        public ShowChartFromPivotItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ShowChartFromPivot; } }
    }
    #endregion
    
    #region ShowTotalsItem
    public class ShowTotalsItem : BrowserCommandBarCheckItem {
        public ShowTotalsItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ShowTotals; } }
        protected override void ApplyChecking() {
            InternalBrowser.ShowTotals = this.Checked;
        }
    }
    #endregion

    #region ShowSelectionItem
    public class ShowSelectionItem : BrowserCommandBarCheckItem {
        public ShowSelectionItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ShowSelection; } }
        protected override void ApplyChecking() {
            InternalBrowser.ShowSelection = this.Checked;
        }
    }
    #endregion

    #region ChartViewSetSubItem
    public class ChartViewSetSubItem : BrowserCommandBasedBarSubItem {
        public ChartViewSetSubItem(BarManager manager, PivotGridBrowser pivotGridBrowser)
            : base(manager, pivotGridBrowser) {
            InitSubItems(manager, pivotGridBrowser);
        }
        void InitSubItems(BarManager manager, PivotGridBrowser pivotGridBrowser) {
            Array viewTypes = Enum.GetValues(typeof(ViewType));
            foreach(object viewType1 in viewTypes) {
                ChartViewItem item = new ChartViewItem(manager, pivotGridBrowser, (ViewType)viewType1);
                AddItem(item);
                item.GroupIndex = 1;
                item.ItemClick += new ItemClickEventHandler(OnItemCheckedChanged);
                item.CheckedChanged += new ItemClickEventHandler(OnItemCheckedChanged);
                if(Comparer.Equals(item.ViewType, ViewType.Pie3D))
                    item.Checked = true;
            }
        }        
        protected void OnItemCheckedChanged(object sender, ItemClickEventArgs e) {
            ChartViewItem chartViewItem = (ChartViewItem)e.Item;
            Caption = GetDefaultCaption() + chartViewItem.ViewType.ToString();
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ChartViewSet; } }
    }
    #endregion
    #region ChartViewSubItemUIState
    public class ChartViewSubItemUIState : DevExpress.XtraBars.Commands.Internal.BarCheckItemUIState {//BarSubItemUIState
        public ChartViewSubItemUIState(ChartViewItem item)
            : base(item) {
        }
        public override object EditValue { 
            get {
                return Item.ViewType;
            } 
            set {
                Item.CheckViewType((ViewType)value);
            } 
        }
        protected new ChartViewItem Item { get { return (ChartViewItem)base.Item; } }
    }
    #endregion

    #region ChartViewItem
    public class ChartViewItem : BrowserCommandBarCheckItem {
        ViewType fViewType;

        public ChartViewItem(BarManager manager, PivotGridBrowser pivotGridBrowser, ViewType viewType)
            : base(manager, pivotGridBrowser) {
            this.fViewType = viewType;
            this.Caption = viewType.ToString();
        }
        public ViewType ViewType { get { return fViewType; } }
        public void CheckViewType(ViewType viewType) {
            if(Comparer.Equals(this.fViewType, viewType)) {
                this.Checked = true;
            }
        }
        protected override BrowserCommandId InternalCommandId { get { return BrowserCommandId.ChartView; } }
        protected override ICommandUIState CreateCommandUIState(Command command) {
            return new ChartViewSubItemUIState(this);
        }
        protected override void ApplyChecking() {
            InternalBrowser.ChartViewType = this.fViewType;
        }
    }
    #endregion
}
