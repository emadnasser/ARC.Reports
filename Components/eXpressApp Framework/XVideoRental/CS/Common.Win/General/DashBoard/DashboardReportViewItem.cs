using System;
using System.Windows.Forms;
using Common.Win;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Xpo;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

[assembly: OnlineRepoLocation("http://goo.gl/d5Qjw")]

namespace Common.Win.General.DashBoard {
    [ViewItem(typeof(IModelDashboardReportViewItem))]
    public class DashboardReportViewItem : DashboardViewItem, IComplexViewItem {
        readonly IModelDashboardReportViewItem _model;
        private XtraReport _report;
        PrintControl _printControl;
        XafApplication _application;
        private IReportDataV2 _reportData;
        private ReportsModuleV2 _reportsModuleV2;

        public DashboardReportViewItem(IModelDashboardReportViewItem model, Type objectType)
            : base(model, objectType) {
            _model = model;
        }

        public new IModelDashboardReportViewItem Model {
            get { return _model; }
        }

        public IReportDataV2 ReportData{
            get { return _reportData; }
        }

        public XtraReport Report {
            get { return _report; }
        }

        protected override object CreateControlCore() {
            _printControl = new PrintControl { Dock = DockStyle.Fill };
            _printControl.ParentChanged += OnControlParentChanged;
            _reportsModuleV2 = ReportsModuleV2.FindReportsModule(_application.Modules);
            var reportDataType = _reportsModuleV2.ReportDataType;
            _reportData = (IReportDataV2)View.ObjectSpace.FindObject(reportDataType, CriteriaOperator.Parse("DisplayName=?", Model.ReportName));
            
            if (_reportData == null)
                throw new NullReferenceException(string.Format("Report {0} not found", Model.ReportName));
            _report = ReportDataProvider.ReportsStorage.LoadReport(_reportData);
            SetupBeforePrint();
            View.ControlsCreated += ViewOnControlsCreated;
            _printControl.PrintingSystem = Report.PrintingSystem;
            
            return _printControl;
        }

        void ViewOnControlsCreated(object sender, EventArgs eventArgs) {
            if (Model.CreateDocumentOnLoad)
                _report.CreateDocument(true);
        }

        void OnControlParentChanged(object sender, EventArgs e) {
            var control = (Control)sender;
            control.ParentChanged -= OnControlParentChanged;
            Form form = control.FindForm();
            if (form == null) {
                control.Parent.ParentChanged += OnControlParentChanged;
            }
            else {
                CreatePrintRibbonController(form as RibbonForm);
            }
        }

        void CreatePrintRibbonController(RibbonForm ribbonForm) {
            if (ribbonForm != null) {
                RibbonControl ribbon = ribbonForm.Ribbon;
                new PrintRibbonController { PrintControl = _printControl }.Initialize(ribbon, ribbon.StatusBar);
            }
        }
        #region Implementation of IComplexViewItem
        void IComplexViewItem.Setup(IObjectSpace objectSpace, XafApplication application) {
            _application = application;
        }
        #endregion

        public void SetupBeforePrint(){
            _reportsModuleV2.ReportsDataSourceHelper.SetupBeforePrint(_report, null, CriteriaOperator.Parse(_report.FilterString), true, new SortProperty[0], true);
        }
    }

}
