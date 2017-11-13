﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Common.Win;
using Common.Win.ColumnView.Design;
using Common.Win.ColumnView.RepositoryItems;
using Common.Win.GridView.MasterDetail;
using Common.Win.LayoutView.Model;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

[assembly: OnlineRepoLocation("http://goo.gl/V3yDN")]

namespace Common.Win.LayoutView {
    [ListEditor(typeof(object), false)]
    public class LayoutViewListEditor : LayoutViewListEditorBase, IColumnViewEditor, ISupportFilter {
        public LayoutViewListEditor(IModelListView model)
            : base(model) {
        }
        public new IModelListViewOptionsLayoutView Model {
            get { return (IModelListViewOptionsLayoutView)base.Model; }
        }

        protected virtual void OnCustomGridViewCreate(CustomGridViewCreateEventArgs e) {
            EventHandler<CustomGridViewCreateEventArgs> handler = CustomGridViewCreate;
            if(handler != null) handler(this, e);
        }

        public event EventHandler<CustomGridViewCreateEventArgs> CustomGridViewCreate;
        protected override List<IModelSynchronizable> CreateModelSynchronizers() {
            List<IModelSynchronizable> result = base.CreateModelSynchronizers();
            result.Add(new FilterModelSynchronizer(this, Model));
            result.Add(new LayoutViewListEditorSynchronizer(this));
            result.Add(new LayoutViewOptionsSynchronizer(this));
            result.Add(new LayoutColumnOptionsSynchroniser(this));
            result.Add(new RepositoryItemColumnViewSynchronizer(ColumnView, Model));
            result.Add(new LayoutViewLayoutStoreSynchronizer(this));
            return result;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool IColumnViewEditor.OverrideViewDesignMode { get; set; }

        protected override void OnColumnCreated(GridColumn column, IModelColumn columnInfo) {
            base.OnColumnCreated(column, columnInfo);
            if(column.ColumnEdit is RepositoryItemMemoExEdit)
                column.ColumnEdit = new RepositoryItemMemoEdit { Name = columnInfo.PropertyName };
        }
        protected override DevExpress.XtraGrid.Views.Base.ColumnView CreateGridViewCore() {
            var gridViewCreatingEventArgs = new CustomGridViewCreateEventArgs(Grid);
            OnCustomGridViewCreate(gridViewCreatingEventArgs);
            return (XafLayoutView)(gridViewCreatingEventArgs.Handled
                     ? gridViewCreatingEventArgs.GridView
                     : new XpandXafLayoutView(this) { OverrideViewDesignMode = ((IColumnViewEditor)this).OverrideViewDesignMode });
        }

        bool ISupportFooter.IsFooterVisible {
            get { return false; }
            set { }
        }
        bool ISupportFilter.FilterEnabled {
            get {
                return ColumnView.ActiveFilterEnabled;
            }
            set {
                ColumnView.ActiveFilterEnabled = value;
            }
        }

        private CriteriaOperator ConvertStringToCriteriaOperator(string criteriaString) {
            CriteriaOperator criteriaOperator = CollectionSource.ObjectSpace.ParseCriteria(criteriaString);
            DevExpress.ExpressApp.Filtering.FilterWithObjectsProcessor criteriaProcessor = new DevExpress.ExpressApp.Filtering.FilterWithObjectsProcessor(CollectionSource.ObjectSpace, CollectionSource.ObjectTypeInfo, IsInstantFeedbackMode);
            criteriaProcessor.Process(criteriaOperator, DevExpress.ExpressApp.Filtering.FilterWithObjectsProcessorMode.StringToObject);
            DevExpress.Persistent.Base.EnumPropertyValueCriteriaProcessor enumParametersProcessor = new DevExpress.Persistent.Base.EnumPropertyValueCriteriaProcessor(CollectionSource.ObjectTypeInfo);
            enumParametersProcessor.Process(criteriaOperator);
            return criteriaOperator;
        }
        string ISupportFilter.Filter {
            get {
                string result = string.Empty;
                if(!ReferenceEquals(ColumnView.ActiveFilterCriteria, null) && CollectionSource != null) {
                    result = CriteriaOperator.ToString(ColumnView.ActiveFilterCriteria);
                }
                return result;
            }
            set {
                if(CollectionSource != null) {
                    ColumnView.ActiveFilterCriteria = ConvertStringToCriteriaOperator(Model.Filter);
                }
                else {
                    ColumnView.ActiveFilterString = value;
                }
            }
        }
        protected override void OnControlsCreated() {
            base.OnControlsCreated();
            if(CollectionSource != null) {
                ColumnView.ActiveFilterCriteria = ConvertStringToCriteriaOperator(Model.Filter);
            }
            if(Model != null) {
                ((ISupportFilter)this).FilterEnabled = Model.FilterEnabled;
            }
        }
    }

    public class XpandXafLayoutView : XafLayoutView, IMasterDetailColumnView {
        public XpandXafLayoutView(GridControl gridControl)
            : base(gridControl) {
        }
        public override void Assign(BaseView v, bool copyEvents) {
            var xafGridView = (IMasterDetailColumnView)v;
            ((IMasterDetailColumnView)this).Window = xafGridView.Window;
            ((IMasterDetailColumnView)this).MasterFrame = xafGridView.MasterFrame;
            base.Assign(v, copyEvents);
        }
        #region Implementation of IMasterDetailColumnView
        public Window Window { get; set; }
        public Frame MasterFrame { get; set; }
        public bool CanFilterGroupSummaryColumns { get; set; }
        #endregion
        public XpandXafLayoutView(LayoutViewListEditor layoutViewListEditor)
            : base(layoutViewListEditor.Grid) {
        }

        protected override bool IsDesignMode {
            get {
                return OverrideViewDesignMode || base.IsDesignMode;
            }
        }
        protected override BaseView CreateInstance() {
            return new XpandXafLayoutView(GridControl);
        }
        public bool OverrideViewDesignMode { get; set; }
    }

}
