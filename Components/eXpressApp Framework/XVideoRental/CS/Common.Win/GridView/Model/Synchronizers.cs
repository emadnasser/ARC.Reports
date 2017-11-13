using Common.Win;
using Common.Win.AdvBandedView.Model;
using Common.Win.ColumnView.Design;
using Common.Win.ColumnView.Model;
using Common.Win.ColumnView.RepositoryItems;
using Common.Win.Common;
using Common.Win.General;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;

[assembly: OnlineRepoLocation("http://goo.gl/SPtMN")]

namespace Common.Win.GridView.Model {

    public class GridViewViewOptionsSynchronizer : ComponentSynchronizer<DevExpress.XtraGrid.Views.Grid.GridView, IModelOptionsColumnView> {
        public GridViewViewOptionsSynchronizer(XpandGridListEditor control)
            : base(control.GridView,control.Model.BandsLayout.Enable? (IModelOptionsColumnView) ((IModelListViewOptionsAdvBandedView) control.Model).OptionsAdvBandedView:
        control.Model.OptionsGridView, ((IColumnViewEditor)control).OverrideViewDesignMode) {
        }
    }

    public class GridViewColumnOptionsSynchroniser : ColumnViewEditorColumnOptionsSynchronizer<XpandGridListEditor, IModelListViewOptionsGridView, IModelColumnOptionsColumnView> {
        public GridViewColumnOptionsSynchroniser(XpandGridListEditor control)
            : base(control, control.Model) {
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnView GetColumnView() {
            return Control.GridView;
        }

        protected override IModelColumnViewColumnOptions GetColumnOptions(IModelColumnOptionsColumnView modelColumnOptionsView) {
            return modelColumnOptionsView.GetParent<IModelListView>().BandsLayout.Enable
                ? (IModelColumnViewColumnOptions)((IModelColumnOptionsAdvBandedView) modelColumnOptionsView).OptionsColumnAdvBandedView
                : ((IModelColumnOptionsGridView) modelColumnOptionsView).OptionsColumnGridView;
        }
    }
    #region XAF GridLstEditor stuff
    public class GridLstEditorDynamicModelSynchronizer : ModelListSynchronizer {
        internal GridLstEditorDynamicModelSynchronizer(GridListEditor columnViewEditor, IModelListView viewDesignMode,
                                                       bool overrideViewDesignMode)
            : base(columnViewEditor, viewDesignMode) {
            ModelSynchronizerList.Add(new GridListEditorViewOptionsSynchronizer(columnViewEditor, overrideViewDesignMode));
            ModelSynchronizerList.Add(new GridListEditorColumnOptionsSynchroniser(columnViewEditor));
            ModelSynchronizerList.Add(new RepositoryItemColumnViewSynchronizer(columnViewEditor.GridView, columnViewEditor.Model));
        }

        public GridLstEditorDynamicModelSynchronizer(GridListEditor columnViewEditor)
            : this(columnViewEditor, columnViewEditor.Model, false) {
        }
    }

    public class GridListEditorViewOptionsSynchronizer :
        ComponentSynchronizer<DevExpress.XtraGrid.Views.Grid.GridView, IModelOptionsColumnView> {
        public GridListEditorViewOptionsSynchronizer(GridListEditor control, bool overrideViewDesignMode)
            : base(control.GridView, control.Model.BandsLayout.Enable?
                (IModelOptionsColumnView) ((IModelListViewOptionsAdvBandedView) control.Model).OptionsAdvBandedView:((IModelListViewOptionsGridView)control.Model).OptionsGridView, overrideViewDesignMode) {
        }
    }
    public class GridListEditorColumnOptionsSynchroniser : ColumnViewEditorColumnOptionsSynchronizer<GridListEditor, IModelListViewOptionsGridView, IModelColumnOptionsGridView> {
        public GridListEditorColumnOptionsSynchroniser(GridListEditor control)
            : base(control, (IModelListViewOptionsGridView)control.Model) {
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnView GetColumnView() {
            return Control.GridView;
        }

        protected override IModelColumnViewColumnOptions GetColumnOptions(IModelColumnOptionsGridView modelColumnOptionsView) {
            return modelColumnOptionsView.GetParent<IModelListView>().BandsLayout.Enable
                ? (IModelColumnViewColumnOptions)((IModelColumnOptionsAdvBandedView)modelColumnOptionsView).OptionsColumnAdvBandedView
                : modelColumnOptionsView.OptionsColumnGridView;
        }

    }

    #endregion

}
