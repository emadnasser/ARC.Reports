using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.Utils;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using PivotGridOlapBrowser.Commands;

namespace PivotGridOlapBrowser.Helpers {
    public class BrowserTabControl : XtraTabControl {
        bool allowCloseFirstPage;

        public BrowserTabControl() {
            this.allowCloseFirstPage = true;
            ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;            
            UpdateTabHeaders();
        }

        [DefaultValue(false)]
        public bool AllowCloseFirstPage {
            get { return allowCloseFirstPage; }
            set {
                if(allowCloseFirstPage == value) return;
                allowCloseFirstPage = value;
                UpdateCloseButtonsVisible();
            }
        }
        public BrowserPivot ActiveBrowser {
            get {
                PivotTabPage tabPage = this.SelectedTabPage as PivotTabPage;
                return tabPage != null ? tabPage.Browser : null;
            }
        }
        public BrowserChart ActiveChart {
            get {
                ChartTabPage tabPage = this.SelectedTabPage as ChartTabPage;
                return tabPage != null ? tabPage.Chart : null;
            }
        }
        public List<Control> ReportControls {
            get {
                List<Control> controls = new List<Control>(TabPages.Count);
                foreach(BrowserTabPage tabPage in TabPages) {
                    controls.Add(tabPage.Control);
                }
                return controls;
            }
        }
        protected override XtraTabPageCollection CreateTabCollection() {
            return new BrowserTabPageCollection(this);
        }
        public new BrowserTabPage SelectedTabPage {
            get { return (BrowserTabPage)base.SelectedTabPage; }
            set { base.SelectedTabPage = value; }
        }

        public void AddTabPage(BrowserTabPage page, bool addPadding) {
            page.Initialize();
            if(addPadding)
                page.Padding = new System.Windows.Forms.Padding(12);
            TabPages.Add(page);
            SelectedTabPage = page;
        }

        protected void UpdateCloseButtonsVisible() {
            for(int i = 0; i < TabPages.Count; i++) {
                TabPages[i].ShowCloseButton = (!AllowCloseFirstPage && i == 0) ? DefaultBoolean.False : DefaultBoolean.Default;                    
            }
        }

        protected void UpdateTabHeaders() {
            ShowTabHeader = AllowCloseFirstPage || TabPages.Count > 1 ? DefaultBoolean.True : DefaultBoolean.False;
        }

        protected override void OnTabPageAdded(XtraTabPage page) {
            base.OnTabPageAdded(page);
            UpdateTabHeaders();
            UpdateCloseButtonsVisible();            
        }

        protected override void OnTabPageRemoved(XtraTabPage page) {
            base.OnTabPageRemoved(page);
            UpdateTabHeaders();
        }

        protected override void OnCloseButtonClick(object sender, EventArgs e) {
            base.OnCloseButtonClick(sender, e);
            ClosePageButtonEventArgs args = (ClosePageButtonEventArgs)e;
            XtraTabPage page = (XtraTabPage)args.Page;
            page.Dispose();
            UpdateCloseButtonsVisible();
        }
    }

    public class BrowserTabPageCollection : XtraTabPageCollection {
        public BrowserTabPageCollection(XtraTabControl tabControl)
            : base(tabControl) {
        }
        protected override XtraTabPage CreatePage() {
            return base.CreatePage();
        }
    }

    public abstract class BrowserTabPage : XtraTabPage {
        public BrowserTabPage(string text)
            : base() {
            this.Text = text;
        }
        public void Initialize() {
            if(IsEmpty) {
                Control control = this.Control;
                control.Dock = DockStyle.Fill;
                this.Controls.Add(control);
            }
        }
        public bool IsEmpty { get { return this.Controls.Count == 0; } }        
        public bool? GetIsCommandActual(BrowserCommandId commandId) {
            return Array.Exists(this.Commands, item => item == commandId);
        }
        public Control Control {
            get {
                return GetControlCore();
            }
        }
        protected abstract BrowserCommandId[] Commands { get; }
        protected abstract Control GetControlCore();
    }
    public class PivotTabPage : BrowserTabPage {
        BrowserPivot browser;
        public PivotTabPage(BrowserPivot browser, string text)
            : base(text) {
            this.browser = browser;
        }
        public BrowserPivot Browser { get { return browser; } }
        protected override BrowserCommandId[] Commands { get { return new BrowserCommandId[] { BrowserCommandId.ConnectTo, 
            BrowserCommandId.CreateReport, BrowserCommandId.ShowChartFromPivot }; } }
        protected override Control GetControlCore() {
            return browser;
        }
    }
    public class ChartTabPage : BrowserTabPage {
        BrowserChart chart;

        public ChartTabPage(BrowserChart chart, string text)
            : base(text) {
            this.chart = chart;
        }
        public BrowserChart Chart { get { return chart; } }
        protected override BrowserCommandId[] Commands {
            get {
                return new BrowserCommandId[] { BrowserCommandId.ConnectTo, BrowserCommandId.CreateReport,
                    BrowserCommandId.ShowTotals, BrowserCommandId.ShowSelection, BrowserCommandId.ChartViewSet, 
                    BrowserCommandId.ChartView };
            }
        }
        protected override Control GetControlCore() {
            return chart;
        }
    }
    public class GridTabPage : BrowserTabPage {
        BrowserGrid grid;

        public GridTabPage(BrowserGrid grid, string text)
            : base(text) {
            this.grid = grid;
        }
        public BrowserGrid Grid { get { return grid; } }
        protected override BrowserCommandId[] Commands { get { return new BrowserCommandId[] { BrowserCommandId.ConnectTo, BrowserCommandId.CreateReport }; } }
        protected override Control GetControlCore() {
            return grid;
        }
    }
}
