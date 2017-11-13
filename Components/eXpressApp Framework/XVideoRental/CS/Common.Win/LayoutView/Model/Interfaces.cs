using System.ComponentModel;
using System.Drawing.Design;
using Common.Win;
using Common.Win.ColumnView.Model;
using Common.Win.Common;
using Common.Win.LayoutView.Design;
using DevExpress.ExpressApp.Model;

[assembly: OnlineRepoLocation("http://goo.gl/XjnBX")]

namespace Common.Win.LayoutView.Model {
    public interface IModelOptionsLayoutView : IModelOptionsColumnView {
        IModelDesignLayoutView DesignLayoutView { get; }
    }

    public interface IModelDesignLayoutView : IModelLayoutDesignStore {
        [Editor(typeof(LayoutViewPropertyEditor), typeof(UITypeEditor))]
        [DefaultValue("Use the property editor to invoke the designer")]
        string Layout { get; set; }
    }

    public interface IModelOptionsColumnLayoutView : IModelColumnViewColumnOptions {
    }

    [ModelAbstractClass]
    public interface IModelColumnOptionsLayoutView : IModelColumnOptionsColumnView {
        [ModelBrowsable(typeof(LayoutEditorVisibilityCalculator))]
        IModelOptionsColumnLayoutView OptionsColumnLayoutView { get; }
    }
    [ModelAbstractClass]
    public interface IModelListViewOptionsLayoutView : IModelListViewOptionsColumnView {
        [ModelBrowsable(typeof(LayoutEditorVisibilityCalculator))]
        IModelOptionsLayoutView OptionsLayoutView { get; }
    }
    public class LayoutEditorVisibilityCalculator : EditorTypeVisibilityCalculator {
        #region Overrides of EditorTypeVisibilityCalculator
        public override bool IsVisible(IModelNode node, string propertyName) {
            return typeof(LayoutViewListEditor).IsAssignableFrom(EditorType(node));
        }
        #endregion
    }

}
