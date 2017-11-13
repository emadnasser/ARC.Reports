using System;
using Common.Win;
using Common.Win.AdvBandedView;
using Common.Win.ColumnView.Model;
using Common.Win.Common;
using Common.Win.General;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;

[assembly: OnlineRepoLocation("http://goo.gl/ZVOkk")]

namespace Common.Win.GridView.Model {
    public interface IModelOptionsGridView : IModelOptionsColumnView {
    }
    public interface IModelOptionsColumnGridView : IModelColumnViewColumnOptions {
    }

    [ModelAbstractClass]
    public interface IModelColumnOptionsGridView : IModelColumnOptionsColumnView {
        [ModelBrowsable(typeof(GridListEditorVisibilityCalculator))]
        IModelOptionsColumnGridView OptionsColumnGridView { get; }
    }

    [ModelAbstractClass]
    public interface IModelListViewOptionsGridView : IModelListViewOptionsColumnView {
        [ModelBrowsable(typeof(GridListEditorVisibilityCalculator))]
        IModelOptionsGridView OptionsGridView { get; }

    }
    public class GridListEditorVisibilityCalculator : EditorTypeVisibilityCalculator {
        #region Overrides of EditorTypeVisibilityCalculator
        public override bool IsVisible(IModelNode node, string propertyName){
            return typeof(GridListEditor).IsAssignableFrom(EditorType(node)) &&
                   !node.GetParent<IModelListView>().BandsLayout.Enable;
        }

        #endregion
    }
}
