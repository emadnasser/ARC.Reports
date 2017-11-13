using System;
using System.Collections.Generic;
using System.Linq;
using Common.Win;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.NodeGenerators;

[assembly: OnlineRepoLocation("http://goo.gl/mTF7l")]

namespace Common.Win.General.ViewCloner {
    public class ModelViewClonerUpdater : ModelNodesGeneratorUpdater<ModelViewsNodesGenerator> {
        public override void UpdateNode(ModelNode node) {
            foreach (var modelClass in ModelClasses(node)) {
                foreach (var cloneViewAttribute in CloneViewAttributes(modelClass)) {
                    IModelView modelView = GetModelView(modelClass, cloneViewAttribute);
                    ModelNode cloneNodeFrom = ((ModelNode)modelView).Clone(cloneViewAttribute.ViewId);
                    AssignDetailView(node, cloneNodeFrom, modelView, cloneViewAttribute);
                }
            }
        }

        IEnumerable<CloneViewAttribute> CloneViewAttributes(IModelClass modelClass) {
            return modelClass.TypeInfo.FindAttributes<CloneViewAttribute>().OrderBy(viewAttribute => viewAttribute.ViewType);
        }

        IEnumerable<IModelClass> ModelClasses(ModelNode node) {
            return node.Application.BOModel.Where(modelClass => modelClass.TypeInfo.FindAttribute<CloneViewAttribute>() != null);
        }

        void AssignDetailView(ModelNode node, ModelNode cloneNodeFrom, IModelView modelView, CloneViewAttribute cloneViewAttribute) {
            if (modelView is IModelListView && !(string.IsNullOrEmpty(cloneViewAttribute.DetailView))) {
                CloneViewAttribute attribute = cloneViewAttribute;
                var modelDetailView =
                    node.Application.Views.OfType<IModelDetailView>().FirstOrDefault(view => view.Id == attribute.DetailView);
                if (modelDetailView == null)
                    throw new NullReferenceException(attribute.DetailView);
                ((IModelListView)cloneNodeFrom).DetailView = modelDetailView;
            }
        }

        IModelView GetModelView(IModelClass modelClass, CloneViewAttribute cloneViewAttribute) {
            if (cloneViewAttribute.ViewType == CloneViewType.LookupListView)
                return modelClass.DefaultLookupListView;
            if (cloneViewAttribute.ViewType == CloneViewType.DetailView)
                return modelClass.DefaultDetailView;
            return modelClass.DefaultListView;
        }
    }
}
