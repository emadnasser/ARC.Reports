using System;
using DevExpress.ExpressApp.Model;

namespace Common.Win.Common {
    [OnlineRepoLocation("http://goo.gl/qVPM9")]
    public abstract class EditorTypeVisibilityCalculator : IModelIsVisible {

        #region Implementation of IModelIsVisible

        protected Type EditorType(IModelNode node) {
            var modelListView = node as IModelListView;
            if (modelListView != null)
                return modelListView.EditorType;
            var modelColumn = node as IModelColumn;
            if (modelColumn != null)
                return ((IModelListView)modelColumn.ParentView).EditorType;
            throw new NotImplementedException(node.GetType().ToString());
        }
        #endregion
        #region Implementation of IModelIsVisible
        public abstract bool IsVisible(IModelNode node, string propertyName);
        #endregion
    }
}
