using DevExpress.DashboardCommon;
using System.Linq;
using DevExpress.DashboardWin;
using DevExpress.XtraCharts;

namespace DashboardMainDemo.Modules {
    public partial class EUTradeOverview : DashboardTutorialControl {
        public EUTradeOverview() {
            InitializeComponent();
        }

        protected override void SubscribeDashboardEvents() {
            DashboardViewer.DashboardItemControlUpdated += DashboardViewer_DashboardItemControlUpdated;
        }

        void DashboardViewer_DashboardItemControlUpdated(object sender, DevExpress.DashboardWin.DashboardItemControlEventArgs e) {
            if(e.DashboardItemName == "pieImportVsExport") {
                if(e.ChartControl.Series.Count > 0)
                    ((PieSeriesLabel)e.ChartControl.Series[0].Label).Position = PieSeriesLabelPosition.Inside;
            }
        }
    }
}
