using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace TabbedBrowser {
    public partial class HistoryControl : XtraUserControl {
        Dictionary<string, DateTime> allHistory;
        List<HistoryItem> data;
        static readonly object itemClickCore = new object();
        public event EventHandler ItemClick {
            add { Events.AddHandler(itemClickCore, value); }
            remove { Events.RemoveHandler(itemClickCore, value); }
        }        
        public HistoryControl() {
            InitializeComponent();            
            this.allHistory = new Dictionary<string,DateTime>();
            data = new List<HistoryItem>();
        }
        void FillGridWithHistoryItems() {
            data.Clear();
            foreach(var item in allHistory) 
                data.Add(new HistoryItem() { Url = item.Key, LastDate = item.Value.ToString() });            
            gridControl1.DataSource = data;
        }
        void OpenNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {            
            EventHandler handler = (EventHandler)Events[itemClickCore];
            if(handler != null) handler(gridView1.GetFocusedRow(), e);
        }
        void ClearHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.allHistory.Clear();
            Update(this.allHistory);
        }
        public void Update(Dictionary<string, DateTime> allHistory) {
            this.allHistory = allHistory;
            FillGridWithHistoryItems();
            gridView1.RefreshData();
        }
        void gridView1_DoubleClick(object sender, EventArgs e) {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            if(DoRowDoubleClick(view, pt)) {
                EventHandler handler = (EventHandler)Events[itemClickCore];
                if(handler != null) handler(view.GetFocusedRow(), e);
            }
        }
        bool DoRowDoubleClick(GridView view, Point pt) {
            GridHitInfo info = view.CalcHitInfo(pt);
            if(info.InRow || info.InRowCell) return true;
            return false;
        }
    }
    class HistoryItem {
        string urlCore, dateCore;
        public string Url { 
            get{ return urlCore; }
            set { urlCore = value; }
        }
        public string LastDate {
            get { return dateCore; }
            set { dateCore = value; }
        }        
    }
}
