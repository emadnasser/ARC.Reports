using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Common.Win;
using Common.Win.ChartControl.Model;
using Common.Win.Common;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Filtering;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.PivotGrid.Win;
using DevExpress.XtraGrid;

[assembly: OnlineRepoLocation("http://goo.gl/SShTb")]

namespace Common.Win.General.DashBoard {

    public class DashboardInteractionController : ViewController<DashboardView>, IModelExtender {
        readonly Dictionary<IModelListView, MasterDetailMode> _masterDetailModes = new Dictionary<IModelListView, MasterDetailMode>();

        protected override void OnActivated() {
            base.OnActivated();
            ((ISupportAppearanceCustomization)View.LayoutManager).CustomizeAppearance += LayoutManagerOnCustomizeAppearance;
            foreach (var item in View.GetItems<DashboardViewItem>()) {
                var modelDashboardViewItem = (item.GetModel(View));
                if (!(modelDashboardViewItem is IModelDashboardReportViewItem))
                    AssignMasterDetailModes((IModelDashboardViewItemEx)modelDashboardViewItem);
            }
        }

        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            foreach (var result in View.Items.OfType<DashboardViewItem>()) {
                var frame1 = result.Frame;
                if (frame1 != null && frame1.View is ListView) {
                    var listView = ((ListView)frame1.View);
                    DashboardViewItem result1 = result;
                    listView.SelectionChanged += (sender, args) => OnSelectionChanged(new SelectionChangedArgs(listView, result1));
                }
            }
            ResetMasterDetailModes();
        }

        void AssignMasterDetailModes(IModelDashboardViewItemEx modelDashboardViewItem) {
            if (modelDashboardViewItem.MasterDetailMode.HasValue) {
                var modelListView = modelDashboardViewItem.View as IModelListView;
                if (modelListView != null) {
                    _masterDetailModes.Add(modelListView, modelListView.MasterDetailMode);
                    modelListView.MasterDetailMode = modelDashboardViewItem.MasterDetailMode.Value;
                }
            }
        }

        void ResetMasterDetailModes() {
            foreach (var masterDetailMode in _masterDetailModes) {
                masterDetailMode.Key.MasterDetailMode = masterDetailMode.Value;
            }
            _masterDetailModes.Clear();
        }

        void OnSelectionChanged(SelectionChangedArgs selectionChangedArgs) {
            var dataSourceListView = DataSourceListView((IModelListView)selectionChangedArgs.DashboardViewItemModel.View);
            if (dataSourceListView != null) {
                var dashboardViewItems = View.Items.OfType<DashboardViewItem>();
                foreach (var dashboardViewItem in dashboardViewItems) {
                    var modelDashboardViewItemEx = (IModelDashboardViewItemEx)dashboardViewItem.GetModel(View);
                    if (modelDashboardViewItemEx.Filter.DataSourceView == dataSourceListView.Model){
                        var dashboardReportViewItem = dashboardViewItem as DashboardReportViewItem;
                        
                        if (dashboardReportViewItem != null) {
                            var objectTypeInfo = Application.TypesInfo.FindTypeInfo(dashboardReportViewItem.ReportData.DataType);
                            var reportDataTypeMember = GetReportDataTypeMember(modelDashboardViewItemEx, objectTypeInfo);
                            var criteria = new InOperator(reportDataTypeMember, Getkeys(dataSourceListView));
                            var report = dashboardReportViewItem.Report;
                            report.FilterString = new LocalizedCriteriaWrapper(objectTypeInfo.Type, criteria).CriteriaOperator.ToString();
                            report.CreateDocument(false);
                        } else {
                            var filterListView = FilteredListView(dataSourceListView, dashboardViewItem, modelDashboardViewItemEx);
                            CreateSummaryDataSource(filterListView);
                        }
                    }
                }
            }
            NotifyControllers(selectionChangedArgs.ListView);
        }

        private string GetReportDataTypeMember(IModelDashboardViewItemEx modelDashboardViewItemEx,
            ITypeInfo objectTypeInfo){
            var reportDataTypeMember = modelDashboardViewItemEx.Filter.ReportDataTypeMember;
            if (string.IsNullOrEmpty(reportDataTypeMember)){
                reportDataTypeMember = objectTypeInfo.KeyMember.Name;
            }
            else{
                var memberTypeInfo = objectTypeInfo.FindMember(reportDataTypeMember).MemberTypeInfo;
                if (memberTypeInfo.IsPersistent)
                    return reportDataTypeMember + "." + memberTypeInfo.KeyMember.Name;
            }
            return reportDataTypeMember;
        }

        void NotifyControllers(ListView listView) {
            if (View != null) {
                var selectionChangeds = View.Items.OfType<DashboardViewItem>().SelectMany(Controllers);
                foreach (var selectionChanged in selectionChangeds) {
                    selectionChanged.SelectedObjects = listView.SelectedObjects;
                }
            }
        }

        IEnumerable<IDataSourceSelectionChanged> Controllers(IFrameContainer item) {
            return item.Frame == null ? Enumerable.Empty<IDataSourceSelectionChanged>()
                       : item.Frame.Controllers.Cast<Controller>().Where(controller => controller.Active).OfType<IDataSourceSelectionChanged>();
        }

        ListView DataSourceListView(IModelListView dataSourceView) {
            return View != null ? (dataSourceView != null ?
                       View.Items.OfType<DashboardViewItem>().Where(item => ViewMatch(item, dataSourceView)).Select(item => item.Frame.View).Cast<ListView>().Single() : null)
                       : null;
        }

        bool ViewMatch(DashboardViewItem item, IModelListView dataSourceView) {
            return item.Frame != null && item.Frame.View != null && item.Frame.View.Model == dataSourceView;
        }

        void LayoutManagerOnCustomizeAppearance(object sender, CustomizeAppearanceEventArgs customizeAppearanceEventArgs) {
            var modelDashboardViewItem = View.Model.Items.OfType<IModelDashboardViewItemEx>().FirstOrDefault(item => item.Id == customizeAppearanceEventArgs.Name);
            if (modelDashboardViewItem != null)
                ((IAppearanceVisibility)customizeAppearanceEventArgs.Item).Visibility = modelDashboardViewItem.Visibility;
        }

        void CreateSummaryDataSource(ListView filterListView) {
            var pivotGridListEditor = filterListView.Editor as PivotGridListEditor;
            if (pivotGridListEditor != null) {
                if (!filterListView.IsControlCreated) {
                    filterListView.CreateControls();
                }
                var pivotSummaryDataSource = pivotGridListEditor.PivotGridControl.CreateSummaryDataSource();
                foreach (ListView summaryDataSourceView in GetSummaryDataSourceViews(filterListView)) {
                    ((GridControl)summaryDataSourceView.Control).DataSource = pivotSummaryDataSource;
                }
            }
        }

        IEnumerable<ListView> GetSummaryDataSourceViews(ListView filterListView) {
            var dashboardViewItems = View.Items.OfType<DashboardViewItem>();
            var viewItems = dashboardViewItems.Where(item => ((IModelDashboardViewItemEx)item.GetModel(View)).Filter.SummaryDataSourceView == filterListView.Model);
            return viewItems.Select(item => item.Frame.View).OfType<ListView>();
        }

        ListView FilteredListView(ListView listView, DashboardViewItem dashboardViewItem, IModelDashboardViewItemEx modelDashboardViewItemFiltered) {
            var filteredColumn = modelDashboardViewItemFiltered.Filter.FilteredColumn;
            var filteredListView = ((ListView)dashboardViewItem.Frame.View);
            var collectionSourceBase = filteredListView.CollectionSource;
            collectionSourceBase.Criteria[modelDashboardViewItemFiltered.Filter.DataSourceView.Id] = CriteriaSelectionOperator(listView, filteredColumn);
            return filteredListView;
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            ((ISupportAppearanceCustomization)View.LayoutManager).CustomizeAppearance -= LayoutManagerOnCustomizeAppearance;
        }

        CriteriaOperator CriteriaSelectionOperator(ListView listView, IModelColumn filteredColumn) {
            var keyName = filteredColumn.ModelMember.MemberInfo.MemberTypeInfo.KeyMember.Name;
            var selectionCriteria = listView.Editor as ISelectionCriteria;
            return selectionCriteria != null ? CriteriaOperator.Parse(filteredColumn.PropertyName + "." + (selectionCriteria).SelectionCriteria.ToString())
                       : new InOperator(filteredColumn.PropertyName + "." + keyName, Getkeys(listView));
        }

        IEnumerable Getkeys(ListView listView) {
            return listView.SelectedObjects.OfType<object>().Select(o => ObjectSpace.GetKeyValue(o));
        }
        #region Implementation of IModelExtender
        public void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
            extenders.Add<IModelDashboardViewItem, IModelDashboardViewItemEx>();
        }
        #endregion
    }

    public class SelectionChangedArgs : EventArgs {
        readonly ListView _listView;
        readonly DashboardViewItem _dashboardViewItem;

        public SelectionChangedArgs(ListView listView, DashboardViewItem dashboardViewItem) {
            _listView = listView;
            _dashboardViewItem = dashboardViewItem;
        }

        public ListView ListView {
            get { return _listView; }
        }

        public DashboardViewItem DashboardViewItem {
            get {
                return _dashboardViewItem;
            }
        }

        public IModelDashboardViewItemEx DashboardViewItemModel {
            get {
                return (IModelDashboardViewItemEx)_dashboardViewItem.GetModel((DashboardView)_dashboardViewItem.View);
            }
        }
    }
}

