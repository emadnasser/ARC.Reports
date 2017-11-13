using System.ComponentModel;
using Common.Win;
using Common.Win.ColumnView.Design;
using Common.Win.ColumnView.Model;
using Common.Win.ColumnView.RepositoryItems;
using Common.Win.Common;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.XtraGrid.Columns;
using DevExpress.ExpressApp.Editors;

[assembly: OnlineRepoLocation("http://goo.gl/ZmsWu")]

namespace Common.Win.LayoutView.Model {
    public class LayoutViewLayoutStoreSynchronizer : ColumnViewEditorLayoutStoreSynchronizer {
        public LayoutViewLayoutStoreSynchronizer(LayoutViewListEditor control)
            : base(control, control.Model.OptionsLayoutView.DesignLayoutView) {
        }
    }
    //TODO Crimp
    public class LayoutViewOptionsSynchronizer : ComponentSynchronizer<XafLayoutView, IModelOptionsLayoutView> {
        public LayoutViewOptionsSynchronizer(LayoutViewListEditor layoutViewListEditor)
            : base(layoutViewListEditor.XafLayoutView, layoutViewListEditor.Model.OptionsLayoutView, ((IColumnViewEditor)layoutViewListEditor).OverrideViewDesignMode) {
        }
        protected override object GetSynchronizeValuesNodeValue(ModelNode modelNode, ModelValueInfo valueInfo, PropertyDescriptor propertyDescriptor, bool isNullableType, object component) {
            var overrideViewDesignMode = OverrideViewDesignMode;
            var synchronizeValuesNodeValue = base.GetSynchronizeValuesNodeValue(modelNode, valueInfo, propertyDescriptor, !overrideViewDesignMode && isNullableType, component);
            if (overrideViewDesignMode)
                return PropertyDefaultValue(synchronizeValuesNodeValue, modelNode, propertyDescriptor, valueInfo, component);
            return synchronizeValuesNodeValue;
        }
    }

    public class LayoutColumnOptionsSynchroniser : ColumnViewEditorColumnOptionsSynchronizer<LayoutViewListEditor, IModelListViewOptionsLayoutView, IModelColumnOptionsLayoutView> {
        public LayoutColumnOptionsSynchroniser(LayoutViewListEditor control)
            : base(control, control.Model) {
        }

        protected override void ApplyModelCore() {
            base.ApplyModelCore();
            foreach(GridColumn column in Control.ColumnView.Columns) {
                column.OptionsColumn.AllowEdit = Control.Model.AllowEdit;
            }
        }
        protected override object GetSynchronizeValuesNodeValue(ModelNode modelNode, ModelValueInfo valueInfo, PropertyDescriptor propertyDescriptor, bool isNullableType, object component) {
            var overrideViewDesignMode = ((IColumnViewEditor)Control).OverrideViewDesignMode;
            var synchronizeValuesNodeValue = base.GetSynchronizeValuesNodeValue(modelNode, valueInfo, propertyDescriptor, !overrideViewDesignMode && isNullableType, component);
            if (overrideViewDesignMode)
                return PropertyDefaultValue(synchronizeValuesNodeValue, modelNode, propertyDescriptor, valueInfo, component);
            return synchronizeValuesNodeValue;
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnView GetColumnView() {
            return Control.ColumnView;
        }

        protected override IModelColumnViewColumnOptions GetColumnOptions(IModelColumnOptionsLayoutView modelColumnOptionsView) {
            return modelColumnOptionsView.OptionsColumnLayoutView;
        }
    }
}
