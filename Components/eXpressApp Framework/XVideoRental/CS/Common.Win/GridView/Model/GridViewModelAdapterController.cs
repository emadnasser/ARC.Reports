using Common.Win;
using Common.Win.ColumnView.Model;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Columns;

[assembly: OnlineRepoLocation("http://goo.gl/VTo5B")]

namespace Common.Win.GridView.Model {
    public class GridViewModelAdapterController : GridViewModelAdapterControllerBase {
        GridListEditor _gridListEditor;

        protected override void OnDeactivated() {
            base.OnDeactivated();
            if(_gridListEditor != null) {
                _gridListEditor.ModelApplied -= _gridListEditor_ModelApplied;
                _gridListEditor.ModelSaved -= _gridListEditor_ModelSaved;
            }
        }
        protected override void OnActivated() {
            base.OnActivated();
            var listView = View as ListView;
            if (listView != null && listView.Editor != null && listView.Editor.GetType() == typeof(GridListEditor)) {
                _gridListEditor = (GridListEditor)listView.Editor;
                _gridListEditor.ModelApplied += _gridListEditor_ModelApplied;
                _gridListEditor.ModelSaved += _gridListEditor_ModelSaved;
            }
        }
        private void _gridListEditor_ModelSaved(object sender, System.EventArgs e) {
            new GridLstEditorDynamicModelSynchronizer(_gridListEditor).SynchronizeModel();
        }
        private void _gridListEditor_ModelApplied(object sender, System.EventArgs e) {
            new GridLstEditorDynamicModelSynchronizer(_gridListEditor).ApplyModel();
        }
        protected override void ExtendInterfaces(ModelInterfaceExtenders extenders) {
            extenders.Add<IModelListView, IModelListViewOptionsGridView>();
            extenders.Add<IModelColumn, IModelColumnOptionsGridView>();

            var builder = new InterfaceBuilder(extenders);
            var assembly = BuildAssembly(builder, typeof(XafGridView), typeof(GridColumn));


            builder.ExtendInteface<IModelOptionsGridView, XafGridView>(assembly);
            builder.ExtendInteface<IModelOptionsColumnGridView, GridColumn>(assembly);
        }

    }

}
