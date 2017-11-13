using Common.Win;
using Common.Win.ColumnView.Design;
using Common.Win.ColumnView.Model;
using Common.Win.ColumnView.RepositoryItems;
using Common.Win.GridView.MasterDetail;
using Common.Win.GridView.Model;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Core;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.ExpressApp.Win.Editors.Grid;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[assembly: OnlineRepoLocation("http://goo.gl/HKstg")]

namespace Common.Win.GridView
{
    [ListEditor(typeof(object), false)]
    public class XpandGridListEditor : GridListEditor, IColumnViewEditor {
        public XpandGridListEditor(IModelListView model)
            : base(model) {
        }
        public event EventHandler<CustomGridViewCreateEventArgs> CustomGridViewCreate;

        bool IColumnViewEditor.OverrideViewDesignMode { get; set; }

        public new IModelListViewOptionsGridView Model {
            get { return (IModelListViewOptionsGridView)base.Model; }
        }
        protected override List<IModelSynchronizable> CreateModelSynchronizers() {
            List<IModelSynchronizable> result = base.CreateModelSynchronizers();
            result.Add(new ListEditorModelSynchronizer(this, result));
            result.Add(new FilterModelSynchronizer(this, Model));
            result.Add(new GridViewViewOptionsSynchronizer(this));
            result.Add(new GridViewColumnOptionsSynchroniser(this));
            result.Add(new RepositoryItemColumnViewSynchronizer(GridView, Model));
            return result;
        }
        #region modelDetailViews
        private void OnCustomGetSelectedObjects(CustomGetSelectedObjectsArgs e) {
            EventHandler<CustomGetSelectedObjectsArgs> customGetSelectedObjectsHandler = CustomGetSelectedObjects;
            if (customGetSelectedObjectsHandler != null) customGetSelectedObjectsHandler(this, e);
        }

        public event EventHandler<CustomGridCreateEventArgs> CustomGridCreate;

        protected virtual void OnCustomGridViewCreate(CustomGridViewCreateEventArgs e) {
            EventHandler<CustomGridViewCreateEventArgs> handler = CustomGridViewCreate;
            if (handler != null) handler(this, e);
        }

        //TODO Crimp
        public override object FocusedObject {
            get {
                object result = null;
                if (GridView != null) {
                    var focusedGridView = GetFocusedGridView(GridView);
                    result = GetFocusedRowObject(focusedGridView);
                    var masterDetailXafGridView = (IMasterDetailColumnView)GridView;
                    Window window = masterDetailXafGridView.Window;
                    if (window != null)
                        result = masterDetailXafGridView.Window.View.ObjectSpace.GetObject(result);
                }
                return result;
            }
            set {
                if (value != null && value != DBNull.Value && GridView != null && DataSource != null) {
                    XtraGridUtils.SelectRowByHandle(GridView, GridView.GetRowHandle(List.IndexOf(value)));
                    if (XtraGridUtils.HasValidRowHandle(GridView)) {
                        GridView.SetRowExpanded(GridView.FocusedRowHandle, true, true);
                    }
                }
            }
        }

        object GetFocusedRowObject(DevExpress.XtraGrid.Views.Base.ColumnView view) {
            if (((IMasterDetailColumnView)view).Window == null) //TODO Crimp
                return XtraGridUtils.GetFocusedRowObject(CollectionSource, view);
            int rowHandle = view.FocusedRowHandle;
            if (!((!view.IsDataRow(rowHandle) && !view.IsNewItemRow(rowHandle))))
                return XtraGridUtils.GetFocusedRowObject(view);
            return XtraGridUtils.GetFocusedRowObject(CollectionSource, view);
        }

        DevExpress.XtraGrid.Views.Base.ColumnView GetFocusedGridView(DevExpress.XtraGrid.Views.Base.ColumnView columnView) {
            Frame masterFrame = null;
            var detailColumnView = columnView as IMasterDetailColumnView;
            if (detailColumnView != null) {
                masterFrame = detailColumnView.MasterFrame;
            }
            return masterFrame != null && masterFrame.View != null ? GetFocusedGridView(masterFrame) : columnView;
        }

        DevExpress.XtraGrid.Views.Base.ColumnView GetFocusedGridView(Frame masterFrame) {
            return (DevExpress.XtraGrid.Views.Base.ColumnView)((WinColumnsListEditor)((ListView)masterFrame.View).Editor).Grid.FocusedView;
        }

        public void OnCustomGridCreate(CustomGridCreateEventArgs e) {
            EventHandler<CustomGridCreateEventArgs> handler = CustomGridCreate;
            if (handler != null) handler(this, e);
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnView CreateGridViewCore() {
            var gridViewCreatingEventArgs = new CustomGridViewCreateEventArgs(Grid);
            OnCustomGridViewCreate(gridViewCreatingEventArgs);
            return (DevExpress.XtraGrid.Views.Grid.GridView)(gridViewCreatingEventArgs.Handled ? gridViewCreatingEventArgs.GridView : CreateXpandGridView());
        }

        private DevExpress.XtraGrid.Views.Grid.GridView CreateXpandGridView() {
            if (CanShowBands) {
                var gridView = new XpandBandedGridView();
                gridView.OptionsView.ColumnAutoWidth = true;
                gridView.OptionsView.ColumnHeaderAutoHeight = DefaultBoolean.True;
                return gridView;
            }
            return new XpandXafGridView();
        }

        public event EventHandler<CustomGetSelectedObjectsArgs> CustomGetSelectedObjects;
        public override IList GetSelectedObjects() {
            if (Grid != null && GridView != null) {
                var focusedGridView = GetFocusedGridView(GridView);
                var selectedObjects = GetSelectedObjects(focusedGridView);
                var e = new CustomGetSelectedObjectsArgs(selectedObjects);
                OnCustomGetSelectedObjects(e);
                if (e.Handled)
                    return e.List;
                return selectedObjects;
            }
            return base.GetSelectedObjects();
        }
        //TODO Crimp
        IList GetSelectedObjects(DevExpress.XtraGrid.Views.Base.ColumnView focusedView) {
            int[] selectedRows = focusedView.GetSelectedRows();
            if ((selectedRows != null) && (selectedRows.Length > 0)) {
                IEnumerable<object> objects = selectedRows.Where(rowHandle => rowHandle > -1).Select(focusedView.GetRow).Where(obj => obj != null);
                return objects.ToList();
            }
            return new List<object>();
        }

        #endregion

        private void Manager_QueryShowPopupMenu(object sender, QueryShowPopupMenuEventArgs e) {
            if (e.Control != Grid) {
                e.Cancel = true;
                e.BreakShowPopupMenu = false;
            }
            else {
                GridHitTest hitTest = GridView.CalcHitInfo(Grid.PointToClient(e.Position)).HitTest;
                e.Cancel = !(hitTest == GridHitTest.RowDetail || CanShowPopupMenu(e.Position));
            }
        }
        protected override GridViewPopupMenuManager CreateGridViewPopupMenuManager(BarManager barManager) {
            GridViewPopupMenuManager manager = new GridViewPopupMenuManager(barManager, Grid, GridView);
            manager.QueryShowPopupMenu += Manager_QueryShowPopupMenu;
            return manager;
        }
    }

    public class XpandBandedGridView : XafBandedGridView, IMasterDetailColumnView {
        protected override XafBandedGridView CreateInstanceCore() {
            return new XpandBandedGridView();
        }

        #region modelDetailViews
        Window IMasterDetailColumnView.Window { get; set; }
        Frame IMasterDetailColumnView.MasterFrame { get; set; }

        public override void Assign(BaseView baseView, bool copyEvents) {
            var xafGridView = ((IMasterDetailColumnView)baseView);
            ((IMasterDetailColumnView)this).Window = xafGridView.Window;
            ((IMasterDetailColumnView)this).MasterFrame = xafGridView.MasterFrame;
            base.Assign(baseView, copyEvents);
        }
        #endregion
    }
    public class XpandXafGridView : XafGridView, IMasterDetailColumnView {
        protected override XafGridView CreateInstanceCore() {
            return new XpandXafGridView();
        }
        #region modelDetailViews
        Window IMasterDetailColumnView.Window { get; set; }
        Frame IMasterDetailColumnView.MasterFrame { get; set; }

        public override void Assign(BaseView baseView, bool copyEvents) {
            var xafGridView = ((IMasterDetailColumnView)baseView);
            ((IMasterDetailColumnView)this).Window = xafGridView.Window;
            ((IMasterDetailColumnView)this).MasterFrame = xafGridView.MasterFrame;
            base.Assign(baseView, copyEvents);
        }
        #endregion
    }
}
