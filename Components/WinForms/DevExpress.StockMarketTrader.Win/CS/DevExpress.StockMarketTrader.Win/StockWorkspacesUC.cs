using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Sparkline;
using DevExpress.StockMarketTrader.Model.BusinessObjects;
using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpress.StockMarketTrader {
    public partial class StockWorkspacesUC : XtraUserControl {
        int selectedPiePointIndex = 0;
        string selectedCompanyName;
        Color red = Color.FromArgb(255, 255, 76, 118);
        Color green = Color.FromArgb(255, 103, 223, 43);

        public StockWorkspacesUC() {
            InitializeComponent();
        }
        void StockWorkspacesUC_Load(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null)
                return;
            StockMarketView.defaultViewModel.CurrentPriceIndexChanged += defaultViewModel_CurrentPriceIndexChanged;
            StockMarketView.defaultViewModel.PropertyChanged += defaultViewModel_PropertyChanged;
            //watchList
            watchListGridView.OptionsBehavior.AutoPopulateColumns = false;
            watchListGridView.OptionsBehavior.CacheValuesOnRowUpdating = CacheRowValuesMode.Disabled;
            watchListGrid.MainView.DataController.AllowIEnumerableDetails = false;
            watchListGridView.Appearance.FocusedRow.BackColor = Color.DimGray;
            watchListGridView.Appearance.FocusedRow.ForeColor = Color.White;
            watchListGridView.FocusRectStyle = XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            watchListGrid.DataSource = StockMarketView.defaultViewModel.WatchListBindingData;
            GridColumn col = watchListGridView.Columns.Add();
            col.FieldName = "CompanyName";
            col.Caption = "Symbol";
            //col.MaxWidth = 100;
            //col.MinWidth = 40;
            col.Visible = true;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Price";
            col.Caption = "Last Price";

            ArrowButtonRepositoryItem arrowRepositoryItem = new ArrowButtonRepositoryItem();
            arrowRepositoryItem.Buttons.Add(new XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Glyph, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.Up.png")), new SuperToolTip()));
            arrowRepositoryItem.Buttons.Add(new XtraEditors.Controls.EditorButton(XtraEditors.Controls.ButtonPredefines.Glyph, Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.Down.png")), new SuperToolTip()));
            arrowRepositoryItem.Buttons[0].IsLeft = true;
            arrowRepositoryItem.Buttons[1].IsLeft = true;
            col.ColumnEdit = arrowRepositoryItem;
            //col.MaxWidth = 100;
            //col.MinWidth = 60;
            col.Visible = true;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Volume";
            col.Visible = true;
            //col.MaxWidth = 100;
            //col.MinWidth = 60;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Volume Dynamics";
            RepositoryItemSparklineEdit rise = new RepositoryItemSparklineEdit();
            col.ColumnEdit = rise;
            //col.MaxWidth = 300;
            //col.MinWidth = 180;
            col.UnboundType = Data.UnboundColumnType.Object;
            AreaSparklineView view = new AreaSparklineView();
            view.HighlightMaxPoint = true;
            view.HighlightMinPoint = true;
            view.Color = Color.FromArgb(247, 138, 9);
            view.MinPointColor = Color.FromArgb(247, 138, 9);
            view.MaxPointColor = Color.White;
            rise.View = view;
            col.Visible = true;
            watchListGridView.BestFitColumns();
            watchListGridView.FocusedRowChanged += new XtraGrid.Views.Base.FocusedRowChangedEventHandler(watchListGridView_FocusedRowChanged);
            watchListGridView.CustomDrawCell += watchListGridView_CustomDrawCell;
            watchListGridView.Appearance.HideSelectionRow.ForeColor = Color.White;
            watchListGridView.CustomUnboundColumnData += watchListGridView_CustomUnboundColumnData;

            //chart
            stockChartUC.stockChart.Series["Price"].DataSource = StockMarketView.defaultViewModel.StockChartBindingData;
            stockChartUC.stockChart.Series["Price"].ArgumentDataMember = "Date";
            stockChartUC.stockChart.Series["Price"].ValueDataMembers.AddRange(new string[] { "Low", "High", "Open", "Close" });//TODO order

            stockChartUC.stockChart.Series["Volume"].DataSource = StockMarketView.defaultViewModel.StockChartBindingData;
            stockChartUC.stockChart.Series["Volume"].ArgumentDataMember = "Date";
            stockChartUC.stockChart.Series["Volume"].ValueDataMembers.AddRange(new string[] { "Volume" });
            //volumeChart
            volumeChart.Series[0].DataSource = StockMarketView.defaultViewModel.VolumeChartBindingData;
            volumeChart.Series[0].ArgumentDataMember = "CompanyName";
            volumeChart.Series[0].ToolTipPointPattern = "Argument: {A}&#x0a;Value: {V}";
            volumeChart.Series[0].ValueDataMembers.AddRange(new string[] { "Volume" });

            //transationsGrid
            transactionGridView.OptionsBehavior.AutoPopulateColumns = false;
            transactionGrid.DataSource = StockMarketView.defaultViewModel.TransactionGridBindingData;
            transactionGridView.CustomDrawCell += transactionGridView_CustomDrawCell;
            ConnectionStatusLabel.BringToFront();
            StockMarketView.defaultViewModel.WatchListChanged += defaultViewModel_WatchListChanged;
        }
        void defaultViewModel_WatchListChanged(object sender, EventArgs e) {
            watchListGridView.RefreshData();
        }
        void UpdateNetworkState() {
            ConnectionStatusLabel.Text = StockMarketView.defaultViewModel.NetworkState;
            UpdateConnectionLabelPosition();
        }
        void defaultViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if(e.PropertyName == "NetworkState" && FindForm() != null) {
                this.FindForm().BeginInvoke(new MethodInvoker(UpdateNetworkState), new object[] { });
            }
        }
        void OnVolumeChartBoundDataChanged(object sender, EventArgs e) {
            if(volumeChart.Series[0].Points.Count > 0 && selectedPiePointIndex != -1 && volumeChart.Series[0].Points.Count > selectedPiePointIndex) {
                DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
                for(int i = 0; i < volumeChart.Series[0].Points.Count; i++) {
                    if(selectedCompanyName == volumeChart.Series[0].Points[i].Argument.ToString()) {
                        ExplodePoint(volumeChart.Series[0].Points[i], view);
                        selectedPiePointIndex = i;
                        break;
                    }
                }
            }
        }
        void watchListGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            if(StockMarketView.defaultViewModel == null) return;
            GridCellInfo info = e.Cell as GridCellInfo;

            if(info == null) return;
            CompanyTradingDataViewModel rowData = watchListGridView.GetRow(e.RowHandle) as CompanyTradingDataViewModel;
            ArrowButtonRepositoryItem arrowb = info.Editor as ArrowButtonRepositoryItem;
            if(info.Column.FieldName == "Price" && arrowb != null) {
                switch(rowData.Rise) {
                    case 0:
                        arrowb.Buttons[0].Visible = true;
                        arrowb.Buttons[1].Visible = false;
                        //info.Appearance.ForeColor = green;
                        break;
                    case 180:
                        arrowb.Buttons[0].Visible = false;
                        arrowb.Buttons[1].Visible = true;
                        //info.Appearance.ForeColor = red;
                        break;
                }
                info.ViewInfo.DetailLevel = XtraEditors.Controls.DetailLevel.Full;
                info.ViewInfo.CalcViewInfo(e.Graphics);
            }
        }
        void defaultViewModel_CurrentPriceIndexChanged(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null) return;
            transactionGridView.FocusedRowHandle = StockMarketView.defaultViewModel.CurrentPriceIndex;
        }
        void watchListGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            StockMarketView.defaultViewModel.SelectedCompany = watchListGridView.GetFocusedRow() as CompanyTradingDataViewModel;
            selectedCompanyName = StockMarketView.defaultViewModel.SelectedCompany.CompanyName;
            SeriesPoint sPoint = FindSeriesPointByName(StockMarketView.defaultViewModel.SelectedCompany.CompanyName);
             DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
             if(sPoint != null && view != null)
                 ExplodePoint(sPoint, view);
             else
                 view.ExplodedPoints.Clear();
        }
        void transactionGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
            if (StockMarketView.defaultViewModel == null) return;
            double cellValue = -1;
            GridCellInfo info = e.Cell as GridCellInfo;
            if (info == null) return;
            double.TryParse(e.CellValue.ToString(), out cellValue);
            if (cellValue != -1) {
                if (cellValue == 0) {
                    info.Appearance.ForeColor = e.Appearance.BackColor;
                    return;
                }
                TransactionData rowData = transactionGridView.GetRow(e.RowHandle) as TransactionData;
                if (rowData.TransactionType == "Ask") info.Appearance.ForeColor = green;
                else info.Appearance.ForeColor = red;
            }
        }
        void volumeChart_MouseDown(object sender, MouseEventArgs e) {
            SeriesPoint seriesPoint = volumeChart.CalcHitInfo(e.Location).SeriesPoint;
            DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
            if(seriesPoint == null || view == null) return;
            ExplodePoint(seriesPoint, view);
            int rowH = GetRowHandleByCompanyName(selectedCompanyName);
            if(rowH >= 0) watchListGridView.FocusedRowHandle = rowH;
        }
        void ExplodePoint(SeriesPoint seriesPoint, DoughnutSeriesView view) {
            view.ExplodedPoints.Clear();
            view.ExplodedPoints.Add(seriesPoint);
            selectedCompanyName = seriesPoint.Argument.ToString();
        }
        void volumeChart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if (e.Object is DevExpress.XtraCharts.Series)
                return;
            e.Cancel = true;
        }
        void volumeChart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if (e.Object is DevExpress.XtraCharts.Series)
                return;
            e.Cancel = true;
        }
        void PanelsCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            BarCheckItem item = e.Item as BarCheckItem;
            if(item == null) return;
            SetDockPanelVisibility(item);
        }
        void SetDockPanelVisibility(BarCheckItem item) {
            switch(item.Caption) {
                case "WatchList":
                    if(!item.Checked)
                        watchListDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        watchListDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
                case "Transaction":
                    if(!item.Checked)
                        transactionGridDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        transactionGridDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
                case "Top Volumes":
                    if(!item.Checked)
                        topVolumesDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        topVolumesDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
            }
        }
        void UpdateConnectionLabelPosition() {
            ConnectionStatusLabel.Location = new Point(Right - ConnectionStatusLabel.Width - 20, 0);
        }
        void watchListDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            watchListbarCheckItem.Checked = false;
        }
        void topVolumesDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            topVolumesbarCheckItem.Checked = false;
        }
        void transactionGridDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            transactionGridbarCheckItem.Checked = false;
        }
        void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) {
            AboutHelper.Show(ProductKind.DXperienceWin, new ProductStringInfoWin("Stock Market Trader Demo")); 
         }
        void panelContainerTopVolumesAndTransaction_ClosedPanel(object sender, DockPanelEventArgs e) {
            transactionGridbarCheckItem.Checked = false;
            topVolumesbarCheckItem.Checked = false;
        }
        void watchListGridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if (e.IsGetData) {
                CompanyTradingDataViewModel model = e.Row as CompanyTradingDataViewModel;
                if (model != null && model.VolumeDynamics != null) {
                    List<double> values = new List<double>();
                    foreach (TradingDataViewModel dynamicItem in model.VolumeDynamics)
                        values.Add(dynamicItem.Volume);
                    e.Value = values;
                }
            }
        }
        SeriesPoint FindSeriesPointByName(string name) {
            for (int i = 0; i < volumeChart.Series[0].Points.Count; i++) {
                if (name == volumeChart.Series[0].Points[i].Argument.ToString())
                    return volumeChart.Series[0].Points[i];
            }
            return null;
        }
        protected int GetRowHandleByCompanyName(string name) {
            for (int i = 0; i < watchListGridView.RowCount; i++) {
                if (watchListGridView.GetRow(i) != null && ((CompanyTradingDataViewModel)watchListGridView.GetRow(i)).CompanyName == name) return i;
            }
            return -1;
        }
        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            UpdateConnectionLabelPosition();
        }
    }
}
