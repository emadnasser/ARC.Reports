using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.ActiveDemos;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace DevExpress.XtraGrid.Demos {
    public partial class Grid100000Records : TutorialControl {
        public Grid100000Records() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            CreateData();
        }
        int startTickCount, endTickCount;
        public override bool HasActiveDemo { get { return true; } }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl1);
        }
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            object oldDataSource = this.gridControl1.DataSource;
            this.gridControl1.DataSource = null;
            this.gridView1.SortInfo.Clear();
            this.startTickCount = System.Environment.TickCount;
            this.gridControl1.DataSource = oldDataSource;
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_DataReloading, OperationSeconds));

            if(activeDemo.Actions.Canceled) return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.ClickGridColumn(this.colclnCurrency);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_CurrencySorting, OperationSeconds));
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);

            if(activeDemo.Actions.Canceled) return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.GroupByColumn(this.colclnText);
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_TextGrouping, OperationSeconds));

            if(activeDemo.Actions.Canceled) return;
            this.gridView1.StartSorting += new EventHandler(StartGroupingSorting);
            activeDemo.GroupByColumn(this.colclnDate);
            this.gridView1.StartSorting -= new EventHandler(StartGroupingSorting);
            this.endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_DateGrouping, OperationSeconds));

            activeDemo.ExpandCollapseRow(this.gridView1, 3);
            if(activeDemo.Actions.Canceled) return;
            ActiveActions.Delay(1000);
            activeDemo.ExpandCollapseRow(this.gridView1, 2);
            if(activeDemo.Actions.Canceled) return;
            ActiveActions.Delay(1000);

            if(activeDemo.Actions.Canceled) return;
            startTickCount = System.Environment.TickCount;
            this.gridView1.SortInfo.Clear();
            endTickCount = System.Environment.TickCount;
            ActiveDemoResults.Add(string.Format(Properties.Resources.ActiveGrid_100kRecords_ClearGrouping, OperationSeconds));
        }
        double OperationSeconds {
            get {
                return (double)(endTickCount - startTickCount) / 1000;
            }
        }
        void StartGroupingSorting(object sender, EventArgs e) {
            this.startTickCount = System.Environment.TickCount;
        }
        public class Record {
            public int Id { get; set; }
            public string Text { get; set; }
            public bool? Bool { get; set; }
            public DateTime? Date { get; set; }
            public decimal? Currency { get; set; }
        }
        const int RowCount = 100000;
        void CreateData() {
            SetWaitDialogCaption(Properties.Resources.CreatingData);
            DateTime dateTime = DateTime.Now;
            string textBase = Properties.Resources.Text;
            Random random = new Random();
            this.bindingSource1.DataSource = Enumerable.Range(0, RowCount).Select(i => new Record() {
                Id = i + 1,
                Text = textBase + " " + (i % 100 + 1).ToString(),
                Bool = random.Next(1000) % 2 == 1,
                Date = dateTime.AddDays(random.Next(100)),
                Currency = random.Next(1000000) / 100m,
            }).ToList();
        }
        private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e) {
            Record row = (Record)gridView1.GetRow(e.RowHandle);
            if(row.Currency > 5000)
                e.PreviewText = string.Format(Properties.Resources.RecordDescription, row.Id);
        }
    }
}

