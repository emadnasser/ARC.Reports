using System;
using System.IO;
using System.Reflection;
using DevExpress.DashboardCommon;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.DashboardWin;
using DevExpress.DashboardCommon.Native;
using DevExpress.DataAccess;

namespace DashboardMainDemo.Modules {
    public partial class DashboardTutorialControl : TutorialControlBase {
        static Dashboard CreateCopy(Dashboard dashboard) {
            using(Stream stream = new MemoryStream()) {
                dashboard.SaveToXml(stream);
                stream.Seek(0L, SeekOrigin.Begin);
                Dashboard copy = new Dashboard();
                copy.LoadFromXml(stream);
                for(int i = 0; i < dashboard.DataSources.Count; i++) {
                    IDashboardDataSource dataSource = dashboard.DataSources[i];
                    if(dataSource is DashboardObjectDataSource)
                        copy.DataSources[i].Data = dataSource.Data;
                    DashboardExtractDataSource extractDataSource = dataSource as DashboardExtractDataSource;
                    if (extractDataSource is DashboardExtractDataSource)
                        ((DashboardExtractDataSource)copy.DataSources[i]).FileName = extractDataSource.FileName;
                }
                return copy;
            }
        }

        bool dashboardModified = false;
        Dashboard dashboard;
        
        protected Dashboard Dashboard { 
            get { return dashboard; } 
            set {
                if(value != dashboard) {
                    DisposeDashboard();
                    dashboard = value;
                    OnDashboardChanged();                    
                }
            } 
        }
        protected virtual bool ShowFooterPanel { get { return false; } }
        protected virtual bool CalculateHiddenTotals { get { return false; } }
        protected DashboardViewer DashboardViewer { get { return dashboardViewer; } }
        protected bool DashboardModified { get { return dashboardModified; } }

        public DashboardTutorialControl() {
            InitializeComponent();
            Initialize();
        }
        protected virtual void EditDashboard() {
            using(Dashboard dashboard = CreateCopy(Dashboard)) {
                using(DashboardDesignerForm designerForm = new DashboardDesignerForm(dashboard)) {
                    designerForm.AllowFormGlass = DevExpress.Skins.SkinManager.AllowFormSkins ? DefaultBoolean.False : DefaultBoolean.True;
                    designerForm.ShowDialog();
                    if(designerForm.SaveDashboard) {
                        Dashboard = CreateCopy(designerForm.Dashboard);
                        dashboardModified = true;
                    }
                }
            }
        }
        protected virtual void SubscribeDashboardEvents() { }
        void OnDashboardChanged() {
            dashboardViewer.Dashboard = dashboard;
        }
        void Initialize() {
            panelFooter.Visible = ShowFooterPanel;
            dashboardViewer.CalculateHiddenTotals = CalculateHiddenTotals;
            dashboardViewer.DataSourceOptions.ObjectDataSourceLoadingBehavior = DocumentLoadingBehavior.LoadAsIs;
            SubscribeDashboardEvents();
            LoadDashboard();
        }
        void LoadDashboard() {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type dashboardType = asm.GetType(string.Format("DashboardMainDemo.Dashboards.{0}", GetType().Name));
            if(dashboardType != null)
                Dashboard = (Dashboard)Activator.CreateInstance(dashboardType);
            else
                Dashboard = null;
        }
        void DisposeDashboard() {
            if(dashboard != null)
                dashboard.Dispose();
        }
        void btnEditDashboard_Click(object sender, EventArgs e) {
            EditDashboard();
        }
    }
}
