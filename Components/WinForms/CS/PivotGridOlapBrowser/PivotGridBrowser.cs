using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using PivotGridOlapBrowser.Commands;
using PivotGridOlapBrowser.Commands.Services;
using PivotGridOlapBrowser.Dialogs;
using PivotGridOlapBrowser.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PivotGridOlapBrowser {
    public class CommandsUpdateEventArgs : EventArgs {
    }
    public class CommandFailedEventArgs : EventArgs {
        readonly string message;
        readonly BrowserCommandId commandId;

        public CommandFailedEventArgs(BrowserCommandId commandId, string message) {
            this.commandId = commandId;
            this.message = message;
        }
        public BrowserCommandId CommandId { get { return commandId; } }
        public string Message { get { return message; } }
    }
    public delegate void CommandsUpdateEventHandler(object sender, CommandsUpdateEventArgs e);
    public delegate void CommandFailedEventHandler(object sender, CommandFailedEventArgs e);
    public partial class PivotGridBrowser : UserControl {
        static readonly object evtIsBusyChanged = new object();
        static readonly object evtCommandsUpdate = new object();
        static readonly object evtCommandFailed = new object();

        static string GetDrillDownTabText(PivotCellEventArgs e) {
            StringBuilder stb = new StringBuilder();
            stb.Append("DrillDown: ");
            if(e.ColumnField != null)
                stb.Append(e.GetFieldValue(e.ColumnField)).Append(", ");
            if(e.RowField != null)
                stb.Append(e.GetFieldValue(e.RowField)).Append(", ");
            stb.Append(e.DataField);
            return stb.ToString();
        }
        static string GetPivotTabText(string connectionString) {
            OLAPConnectionStringBuilder builder = new OLAPConnectionStringBuilder(connectionString);
            StringBuilder stb = new StringBuilder();
            stb.Append("Pivot Grid: '");
            stb.Append(builder.CubeName).Append("'");
            return stb.ToString();
        }
        static string GetChartTabText(DataTable dataTable) {
            if(dataTable.Rows.Count == 0) return "Chart";
            StringBuilder stb = new StringBuilder();
            stb.Append("Chart: '");
            stb.Append(dataTable.Rows[0][1].ToString()).Append(" - ");
            stb.Append(dataTable.Rows[dataTable.Rows.Count - 1][1].ToString()).Append("'");
            return stb.ToString();
        }
        static string GetReportTabText() {
            StringBuilder stb = new StringBuilder();
            stb.Append("Report designer");
            return stb.ToString();
        }

        int busyCounter;
        readonly ConnectionDesigner connectionDesigner;
        readonly PivotGridBrowserServiceManager serviceManager;
        
        public PivotGridBrowser() {
            InitializeComponent();
            this.serviceManager = new PivotGridBrowserServiceManager();
            AddServices();
            this.connectionDesigner = new ConnectionDesigner();
        }
        public bool? GetIsCommandActual(BrowserCommandId commandId) {
            if(this.browserTabs.SelectedTabPage == null) return null;
            return this.browserTabs.SelectedTabPage.GetIsCommandActual(commandId);
        }

        BrowserPivot ActiveBrowser { get { return browserTabs.ActiveBrowser; } }
        BrowserChart ActiveChart { get { return browserTabs.ActiveChart; } }

        protected virtual XtraReport CreateReport(BrowserTabControl tabControl) {
            XtraReport report = new XtraReport();
            return report;
        }
        protected virtual BrowserPivot CreateBrowserPivot() {
            BrowserPivot browser = new PivotGridOlapBrowser.BrowserPivot();
            browser.IsBusyChanged += OnBrowserBusyChanged;
            browser.CellDoubleClick += OnBrowserCellDoubleClick;
            return browser;
        }
        protected virtual BrowserChart CreateChart(DataTable dataTable, bool? showSelection, DataState state) {
            BrowserChart chart = new BrowserChart(ViewType.Line, false, showSelection, state);
            chart.DataSource = dataTable;
            return chart;
        }
        protected virtual BrowserGrid CreateGrid(BrowserPivot browser, object dataTable) {
            BrowserGrid grid = new BrowserGrid(browser);
            grid.DataSource = dataTable;
            return grid;
        }
        public virtual BrowserCommand CreateCommand(BrowserCommandId commandId) {
            if(serviceManager != null)
                return serviceManager.CreateCommand(commandId);
            else
                return null;
        }
        protected void AddServices() {
            AddService(typeof(IBrowserCommandFactoryService), new BrowserCommandFactoryService(this));
        }
        protected void AddService(Type serviceType, object serviceInstance) {
            if(serviceManager != null)
                serviceManager.AddService(serviceType, serviceInstance);
        }       

        public event EventHandler IsBusyChanged {
            add { Events.AddHandler(evtIsBusyChanged, value); }
            remove { Events.RemoveHandler(evtIsBusyChanged, value); }
        }
        public event CommandFailedEventHandler CommandFailed {
            add { Events.AddHandler(evtCommandFailed, value); }
            remove { Events.RemoveHandler(evtCommandFailed, value); }
        }
        public event CommandsUpdateEventHandler CommandsUpdate {
            add { Events.AddHandler(evtCommandsUpdate, value); }
            remove { Events.RemoveHandler(evtCommandsUpdate, value); }
        }
        public bool IsBusy {
            get { return busyCounter > 0; }
        }        
        protected void SetBusy(bool busy) {
            bool oldBusy = IsBusy;
            busyCounter += busy ? 1 : -1;
            if(IsBusy != oldBusy)
                OnIsBusyChanged();
        }
        protected internal virtual void OnCommandFailed(BrowserCommandId commandId, string message) {
            CommandFailedEventHandler handler = (CommandFailedEventHandler)Events[evtCommandFailed];
            if(handler != null)
                handler(this, new CommandFailedEventArgs(commandId, message));
        }
        protected virtual void OnCommandsUpdate() {
            CommandsUpdateEventHandler handler = (CommandsUpdateEventHandler)Events[evtCommandsUpdate];
            if(handler != null)
                handler(this, new CommandsUpdateEventArgs());
        }
        protected virtual void OnIsBusyChanged() {
            EventHandler handler = (EventHandler)Events[evtIsBusyChanged];
            if(handler != null)
                handler(this, EventArgs.Empty);
        }        
        void OnBrowserBusyChanged(object sender, EventArgs e) {
            BrowserPivot browser = sender as BrowserPivot;
            if(browser == null) return;
            SetBusy(browser.IsBusy);
        }

        void OnBrowserCellDoubleClick(object sender, PivotCellEventArgs e) {
            try {
                PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
                if(ds == null || ds.RowCount == 0) {
                    XtraMessageBox.Show("DrillDown operation returned no rows", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.browserTabs.AddTabPage(new GridTabPage(CreateGrid(ActiveBrowser, ds), GetDrillDownTabText(e)), true);
            } catch(OLAPException exception) {
                if(exception.InnerException != null)
                    XtraMessageBox.Show(String.Format("{0}: {1}", exception.Message, exception.InnerException.Message), null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(exception.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ShowReport() {
            XtraReport report = PivotReportGenerator.GenerateReport(this.browserTabs.ReportControls);
            report.ShowDesignerDialog();
            return true;
        }
        public bool ShowChartFromPivot() {
            BrowserPivot browser = ActiveBrowser;
            if(browser == null) return false;
            DataTable dataTable = browser.Data;
            bool? showSelection = true;
            if(dataTable.Columns[PivotDataExtractor.ColumnNameIsSelected] == null)
                showSelection = null;
            this.browserTabs.AddTabPage(new ChartTabPage(CreateChart(dataTable, showSelection, browser.State), GetChartTabText(dataTable)), true);
            return true;
        }
        public bool? ShowConnectionDialog() {
            if(connectionDesigner.ShowDialog() == DialogResult.OK) {
                return AddConnectedBrowserPage(connectionDesigner.ConnectionString) != null;
            }
            return null;
        }
        protected virtual internal bool? ShowSelection {
            get {
                if(ActiveChart == null) return null;
                return ActiveChart.ShowSelection;
            }
            set {
                if(ActiveChart == null) return;
                ActiveChart.ShowSelection = value;
            }
        }
        protected virtual internal bool ShowTotals {
            get {
                if(ActiveChart == null) return false;
                return ActiveChart.ShowTotals;
            }
            set {
                if(ActiveChart == null || value == ActiveChart.ShowTotals) return;
                ActiveChart.ShowTotals = value;
            }
        }
        protected virtual internal ViewType ChartViewType {
            get {
                if(ActiveChart == null) return ViewType.Line;
                return ActiveChart.ViewType;
            }
            set {
                if(ActiveChart == null || object.Equals(value, ActiveChart.ViewType)) return;
                ActiveChart.ViewType = value;
            }
        }
        
        public bool LoadSampleConfiguration() {
            BrowserPivot browser = AddConnectedBrowserPage(ConnectionDesigner.SampleConnectionString);
            if(browser == null)
                return false;
            PivotGridField fieldQuantity = browser.Fields["[Measures].[Quantity]"],
                fieldCategories = browser.Fields["[Categories].[Category Name].[Category Name]"],
                fieldProducts = browser.Fields["[Products].[Products].[Products]"];
            if(fieldQuantity != null) {
                fieldQuantity.Visible = true;
                fieldQuantity.Area = PivotArea.DataArea;
            }
            if(fieldCategories != null) {
                fieldCategories.Visible = true;
                fieldCategories.Area = PivotArea.RowArea;
            }
            if(fieldProducts != null) {
                fieldProducts.Visible = true;
                fieldProducts.Area = PivotArea.RowArea;
            }
            return true;
        }
        BrowserPivot AddConnectedBrowserPage(string connectionString) {
            BrowserPivot browser = CreateBrowserPivot();
            if(Connect(browser, connectionString)) {
                this.browserTabs.AddTabPage(new PivotTabPage(browser, GetPivotTabText(connectionString)), true);
                return browser;
            }
            return null;
        }
        bool Connect(BrowserPivot browser, string connectionString) {
            if(browser == null) return false;
            try {
                SetBusy(true);
                browser.ConnectionString = connectionString;
                return true;
            } catch(OLAPConnectionException) {
                //XtraMessageBox.Show("Failed to connect to the datasource.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnCommandsUpdate();
                return false;
            } finally {
                SetBusy(false);
            }
        }
        void browserTabs_SelectedPageChanged(object sender, TabPageChangedEventArgs e) {
            OnCommandsUpdate();
        }
    }

    class PivotGridBrowserServiceManager : DevExpress.Services.Internal.ServiceManager {
        internal PivotGridBrowserServiceManager() {
        }
        public virtual BrowserCommand CreateCommand(BrowserCommandId commandId) {
            IBrowserCommandFactoryService service = GetService(typeof(IBrowserCommandFactoryService)) as IBrowserCommandFactoryService;
            if(service == null)
                return null;
            return service.CreateCommand(commandId);
        }
    }
}
