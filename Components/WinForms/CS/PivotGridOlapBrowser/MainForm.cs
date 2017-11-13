using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using PivotGridOlapBrowser.Commands.UI;
using System;
using System.Collections.Generic;

namespace PivotGridOlapBrowser {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            InitializeToolBar();
            InitializeControls();
        }
        void InitializeControls() {
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("PivotGridOlapBrowser.AppIcon.ico", typeof(MainForm).Assembly);
            this.pivotGridBrowser1.CommandsUpdate += pivotGridBrowser1_CommandsUpdate;
            this.pivotGridBrowser1.CommandFailed += pivotGridBrowser1_CommandFailed;
        }
        void InitializeToolBar() {
            ConnectToItem biConnectTo = new ConnectToItem(this.barManager1, this.pivotGridBrowser1);
            CreateReportItem biReport = new CreateReportItem(this.barManager1, this.pivotGridBrowser1);
            ShowChartFromPivotItem biShowChartFromPivot = new ShowChartFromPivotItem(this.barManager1, this.pivotGridBrowser1);
            ShowTotalsItem biShowTotals = new ShowTotalsItem(this.barManager1, this.pivotGridBrowser1);
            ShowSelectionItem biShowSelection = new ShowSelectionItem(this.barManager1, this.pivotGridBrowser1);
            ChartViewSetSubItem biChartViewSet = new ChartViewSetSubItem(this.barManager1, this.pivotGridBrowser1);
            this.barToolbar.LinksPersistInfo.AddRange(new LinkPersistInfo[] {
                new LinkPersistInfo(biConnectTo), 
                new LinkPersistInfo(biReport),
                new LinkPersistInfo(biShowChartFromPivot, true),
                new LinkPersistInfo(biShowTotals, true),
                new LinkPersistInfo(biShowSelection),
                new LinkPersistInfo(biChartViewSet, true),
            });
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (!pivotGridBrowser1.LoadSampleConfiguration()) {
                bsiStatus.Caption = "Failed to connect to the datasource.";
                panelError.Visible = true;
                barManager1.Items.Clear();
            }
            else {
                bsiStatus.Caption = "Ready. Sample cube has been loaded.";
                panelError.Visible = false;
            }
        }
        void pivotGridBrowser1_CommandFailed(object sender, CommandFailedEventArgs e) {
            bsiStatus.Caption = e.Message;
        }
        void pivotGridBrowser1_CommandsUpdate(object sender, CommandsUpdateEventArgs e) {
            foreach(BarItem item in this.barManager1.Items) {
                IPivotGridBrowserBarItem browserBarItem = item as IPivotGridBrowserBarItem;
                if(browserBarItem != null) browserBarItem.Update();
            }
        }        
        void pivotGridBrowser1_IsBusyChanged(object sender, EventArgs e) {
            SetIsBusy(pivotGridBrowser1.IsBusy);
        }
        void SetIsBusy(bool isBusy) {
            bsiStatus.Caption = isBusy ? "Working..." : "Ready.";
            bsiStatus.Refresh();
        }
    }
}
