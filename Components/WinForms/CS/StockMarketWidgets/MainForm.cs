using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using StockMarketWidgets.StockDataServiceReference;

namespace StockMarketWidgets {
    public partial class MainForm : XtraForm {
        RealTimeDataModel modelCore;
        Dictionary<string, Queue<Delegate>> defferedUpdate = new Dictionary<string, Queue<Delegate>>();
        public List<string> Companies { get; private set; }
        public MainForm() {
            InitializeComponent();
            Companies = new List<string>();
            CreateModel();
            UpdateCompanies();
        }
        protected void CreateModel() {
            modelCore = new RealTimeDataModel();
            modelCore.GetDataCompleted += model_GetDataCompleted;
        }
        void UpdateCompanies() {
            Action<string[]> action = new Action<string[]>(SetCompanies);
            AddDefferedDelegate("GetCompanies", action);
            modelCore.BeginGetCompanies();
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            modelCore.GetDataCompleted += model_GetDataCompleted;
        }
        void model_GetDataCompleted(object sender, RealTimeDataEventArgs e) {
            Delegate d = GetDefferedDelegate(e.Key);
            this.BeginInvoke(d, new object[] { e.Data });
        }
        Delegate GetDefferedDelegate(string key) {
            if(defferedUpdate.ContainsKey(key) && defferedUpdate[key].Count != 0)
                return defferedUpdate[key].Dequeue();
            return null;
        }
        void SetCompanies(string[] companies) {
            Companies = new List<string>(companies);
            OnDatesLoadComplete();
        }
        void OnDatesLoadComplete() {
            for(int i = 0; i < 8; i++) {
                Action<CompanyData[]> action = new Action<CompanyData[]>(GetStockData);
                AddDefferedDelegate("GetCompanyMultipleDataFromPeriod", action);
                modelCore.BeginGetCompanyMultipleDataFromPeriod(1, 5, 1, Companies[i]);
            }
        }
        int stackGroupIndex = 0;
        void GetStockData(CompanyData[] data) {
            List<CompanyData> newStockData = new List<CompanyData>();
            try {
                newStockData = new List<CompanyData>(data);
                Document document = widgetView1.AddDocument(new WidgetControl() { Text = Companies[newStockData[0].Data.CompanyID], Data = newStockData, CompanyNameText = Companies[newStockData[0].Data.CompanyID] }) as Document;
                widgetView1.Controller.Dock(document, widgetView1.StackGroups[stackGroupIndex]);
                if(widgetView1.StackGroups[stackGroupIndex].Items.Count > 1)
                    stackGroupIndex++;
                Action<CompanyData[]> action = new Action<CompanyData[]>(UpdateStockData);
                AddDefferedDelegate("GetCompanyMultipleDataFromPeriod", action);
                modelCore.BeginGetCompanyMultipleDataFromPeriod(1, 250, 1, Companies[newStockData[0].Data.CompanyID]);
            }
            catch { }
        }
        void UpdateStockData(CompanyData[] data) {
            string companyName = Companies[data[0].Data.CompanyID];
            Document d = widgetView1.Documents.FindFirst((c) => (c.Caption == companyName)) as Document;
            if(d != null) {
                (d.Control as WidgetControl).Data = new List<CompanyData>(data);
            }
        }
        protected void AddDefferedDelegate(string key, Delegate method) {
            if(!defferedUpdate.ContainsKey(key))
                defferedUpdate.Add(key, new Queue<Delegate>());
            defferedUpdate[key].Enqueue(method);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }
    }
}
