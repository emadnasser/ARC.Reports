using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;

namespace Common.Win.General{
    public static class ModelNodeExtenions{
        public static string Id(this IModelNode modelNode) {
            return ((ModelNode)modelNode).Id;
        }
        public static TNode GetParent<TNode>(this IModelNode modelNode) where TNode : class, IModelNode {
            if (modelNode is TNode)
                return (TNode)modelNode;
            var parent = modelNode.Parent;
            while (!(parent is TNode)) {
                parent = parent.Parent;
                if (parent == null)
                    break;
            }
            return parent != null ? (TNode)parent : default(TNode);
        }
    }
}
