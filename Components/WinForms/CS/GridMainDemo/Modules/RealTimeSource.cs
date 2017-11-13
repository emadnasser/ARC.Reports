using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Diagnostics;
using DevExpress.Data;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.ComponentModel;
using DevExpress.Skins;

namespace DevExpress.XtraGrid.Demos {
    public partial class RealTimeSourceDemo : TutorialControl {
        ChangeThread chtr;
        Thread tr;
        //<gridControl1>
        RealTimeSource realTimeSource;
        //</gridControl1>

        Timer timerShow;
        Timer backgroundTimer;
        SynchronizationContext syncContext;
        readonly AutoResetEvent aEvent = new AutoResetEvent(true);
        readonly RepositoryItemProgressBar editorProgressBar;
        bool isHide = true;
        public RealTimeSourceDemo() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\RealTimeSource.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.RealTimeSource.xml";
            editorProgressBar = new RepositoryItemProgressBar { Minimum = 300, Maximum = 1000, ShowTitle = true, PercentView = false };
        }

        void RealTimeSourceDemo_Disposed(object sender, EventArgs e) {
            DoHide();
        }
        protected override void DoShow() {
            base.DoShow();
            isHide = false;
            syncContext = SynchronizationContext.Current;
            chtr = new ChangeThread(syncContext);
            trackBar1.Value = 10;
            PatchInterval();
            //<gridControl1>
            realTimeSource = CreateRealTimeSource();
            gridControl1.DataSource = realTimeSource;
            //</gridControl1>
            timerShow = new Timer(TimerShowCallback, null, 0, 500);
            backgroundTimer = new Timer(chtr.OnIdle, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
            this.Disposed += RealTimeSourceDemo_Disposed;
            chartControl1.Series["UPSDiagram"].Points.Clear();
            chartControl1.Series["UPSDiagram"].Label.TextPattern = "{V:n0}";
            tr = new Thread(chtr.Do);
            tr.IsBackground = true;
            tr.Start();
            //<gridControl1>
            realTimeSource.DataSource = chtr.List;
            //</gridControl1>
            gridView1.GridControl.RepositoryItems.AddRange(new RepositoryItem[] { editorProgressBar });
        }
        protected override void DoHide() {
            isHide = true;
            chtr.Stop();
            if(tr != null)
                tr.Join();
            backgroundTimer.Dispose();
            timerShow.Dispose();
            if(realTimeSource != null) {
                realTimeSource.DataSource = null;
                realTimeSource.Dispose();
            }
            base.DoHide();
        }

        static RealTimeSource CreateRealTimeSource() {
            RealTimeSource rts = new RealTimeSource();
            return rts;
        }

        private void TimerShowCallback(object state) {
            if(!aEvent.WaitOne(0) || isHide)
                return;
            double changes = chtr.ChangePerSecond;
            aEvent.Reset();
            syncContext.Post(x => {
                try {
                    double changePerSecond = (double)x;
                    if(chartControl1 != null && chartControl1.Series["UPSDiagram"] != null && chartControl1.Series["UPSDiagram"].Points != null) {
                        while(chartControl1.Series["UPSDiagram"].Points.Count >= 20) {
                            chartControl1.Series["UPSDiagram"].Points.RemoveAt(0);
                        }
                        chartControl1.Series["UPSDiagram"].Points.Add(new SeriesPoint(DateTime.Now.TimeOfDay.TotalSeconds, changePerSecond));
                    }
                } finally {
                    aEvent.Set();
                }
            }, changes);
        }

        private void UnplugRTS_Click(object sender, EventArgs e) {
            gridControl1.DataSource = null;
            if(!useRealtimeSource.Checked) {
                chtr.UseRealtimeSource = false;
                if(realTimeSource != null) {
                    realTimeSource.DataSource = null;
                    realTimeSource.Dispose();
                    realTimeSource = null;
                }
                gridControl1.DataSource = chtr.List;
            } else {
                realTimeSource = CreateRealTimeSource();
                realTimeSource.DataSource = chtr.List;
                gridControl1.DataSource = realTimeSource;
                chtr.UseRealtimeSource = true;
            }
            PatchInterval();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            PatchInterval();
        }
        void PatchInterval() {
            double pow = (this.trackBar1.Properties.Maximum - this.trackBar1.Value + 3) / 2.0;
            this.chtr.InterEventDelay = (int)Math.Pow(2.0, pow);
        }

        private void gridView1_DataSourceChanged(object sender, EventArgs e) {
            GridColumn column = gridView1.Columns["DayVal"];
            if(column == null || editorProgressBar == null)
                return;
            column.ColumnEdit = editorProgressBar;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e) {
            double val = Convert.ToDouble(gridView1.GetRowCellValue(e.RowHandle, "ChgPercent"));
            if(val < 0)
                e.Appearance.ForeColor = CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
        }
    }
    public class ChangeThread {
        readonly BindingList<MarketData> collection = new BindingList<MarketData>();
        public IList List { get { return this.collection; } }
        private int interEventDelay = 1024000;
        public int InterEventDelay {
            set { Interlocked.Exchange(ref interEventDelay, value); }
        }
        int needStop;
        readonly Stopwatch sw;
        readonly Stopwatch backgroundSw = new Stopwatch();
        private bool useRealtimeSource = true;
        readonly SynchronizationContext context;
        int changesFromPriopChangePerSecond = 0;
        int priorChanges;
        object lockObj = new object();
        public bool UseRealtimeSource {
            set { lock(lockObj) useRealtimeSource = value; }
        }
        public int ChangePerSecond {
            get {
                if(Interlocked.CompareExchange(ref changesFromPriopChangePerSecond, 0, 0) == 0) {
                    return priorChanges;
                } else {
                    int changes = Interlocked.Exchange(ref changesFromPriopChangePerSecond, 0);
                    TimeSpan changeReportInterval = sw.Elapsed;
                    priorChanges = Convert.ToInt32(changes / changeReportInterval.TotalSeconds);
                    sw.Reset();
                    sw.Start();
                    return priorChanges;
                }
            }
        }
        public ChangeThread(SynchronizationContext context) {
            string[] data = new string[] {"ANR", "FE", "GT", "PRGO", "APD", "PPL", "AES", "AVB", "IBM", "GAS", "EFX", "GPC", "ICE", "IVZ", "KO", "CCE", "SO", "STI", 
                "BWA", "HRL", "WFM", "LM", "TROW", "K", "EXPE", "PCAR", "TRIP", "WHR", "WMT", "NU", "HST", "CVH", "LMT", "MAR", "CVC", "RF", "VMC", "PHM", "MU", "IRM", 
                "AMT", "BXP", "STT", "PBCT", "FISV", "BLL", "MTB", "DIS", "LH", "AKAM", "CPB", "MYL", "LIFE", "LEG", "SCG", "CNX", "COL", "MCHP", "GR", "DUK", "BAC", 
                "NUE", "UNM", "DLTR", "ABC", "TEG", "RRD", "EQR", "EXC", "BA", "CME", "NTRS", "VTR", "FITB", "PG", "KR", "M", "SNI", "ETN", "CLF", "PH", "KEY", "SHW", 
                "HD", "AFL", "TSS", "CMI", "HBAN", "AEP", "BIG", "LTD", "ESRX", "GLW", "WPI", "MON", "AAPL", "DF", "T", "CMA", "THC", "LUV", "TXN", "TIE", "PX"};

            this.sw = new Stopwatch();
            this.context = context;
            sw.Start();
            foreach(string name in data)
                collection.Add(new MarketData(name));
        }
        public void Do() {
            Random rndRow = new Random();
            int postedOperation = 0;
            do {

                Stopwatch watch = Stopwatch.StartNew();
                int row = rndRow.Next(0, collection.Count);
                lock(lockObj) {
                    if(!useRealtimeSource) {
                        Interlocked.Increment(ref postedOperation);
                        context.Post((x) => {
                            collection[row].Update();
                            collection.ResetItem(row);
                            Interlocked.Decrement(ref postedOperation);
                        }, null);
                    } else {
                        collection[row].Update();
                        collection.ResetItem(row);
                    }
                }
                this.changesFromPriopChangePerSecond++;
                for(; ; ) {
                    var elapsed = watch.ElapsedTicks;
                    var left = interEventDelay - elapsed;
                    if(left <= 0) {
                        if(!useRealtimeSource) {
                            Thread.Sleep(0);
                            while(backgroundSw.ElapsedMilliseconds > 12) {
                                if(Interlocked.CompareExchange(ref needStop, 0, 0) != 0)
                                    break;
                                Thread.Sleep(1);
                            }
                            if(Interlocked.CompareExchange(ref postedOperation, 0, 0) > 100) {
                                while(Interlocked.CompareExchange(ref postedOperation, 0, 0) > 10) {
                                    if(Interlocked.CompareExchange(ref needStop, 0, 0) != 0)
                                        break;
                                    Thread.Sleep(0);
                                }
                            }
                        }
                        break;
                    }
                    if(left > 20000)
                        Thread.Sleep(1);
                }
                watch.Stop();
            } while(Interlocked.CompareExchange(ref needStop, 0, 0) == 0);
        }
        public void Stop() {
            Interlocked.Exchange(ref needStop, 1);
        }
        public void OnIdle(object state) {
            context.Post((x) => { backgroundSw.Reset(); backgroundSw.Start(); }, null);
        }
    }

    public class MarketData {
        readonly static Random rnd = new Random();
        const double MAX = 950;
        const double MIN = 350;
        public string Ticker { get; private set; }
        double last;
        public double Last {
            get { return last; }
            private set { last = Math.Round(value, 1); }
        }
        double chgPercent;
        public double ChgPercent {
            get { return chgPercent; }
            private set { chgPercent = Math.Round(value * 100, 2); }
        }
        double open;
        public double Open {
            get { return open; }
            private set { open = Math.Round(value, 1); }
        }
        double high;
        public double High {
            get { return high; }
            private set { high = Math.Round(value, 1); }
        }
        double low;
        public double Low {
            get { return low; }
            private set { low = Math.Round(value, 1); }
        }
        //public DateTime Date;
        string time;
        public string Time {
            get { return time; }
        }
        double dayVal;
        public double DayVal {
            get { return Math.Round(dayVal, 1); }
            private set { dayVal = value; }
        }

        public MarketData(string name) {
            Ticker = name;
            Open = (NextRnd() * (MAX - MIN)) + MIN;
            DayVal = open;
            UpdateInternal(Open);
        }
        public void Update() {
            double value = DayVal - (MAX - MIN) * 0.05 + NextRnd() * (MAX - MIN) * 0.1;
            if(value <= MIN)
                value = MIN;
            if(value >= MAX)
                value = MAX;
            UpdateInternal(value);
        }
        void UpdateInternal(double dayVal) {
            Last = DayVal;
            DayVal = dayVal;
            ChgPercent = (DayVal - Last) / DayVal;
            High = Math.Max(Open, Math.Max(DayVal, Last));
            Low = Math.Min(Open, Math.Min(DayVal, Last));
            this.time = DateTime.Now.ToLongTimeString();
        }
        double NextRnd() {
            double value = 0;
            for(int i = 0; i < 5; i++)
                value += rnd.NextDouble();
            return value / 5;
        }
    }

}
