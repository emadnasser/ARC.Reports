using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Common.Win;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;

[assembly: OnlineRepoLocation("http://goo.gl/FoZUJ")]

namespace Common.Win.ModelAdapter {
    public abstract class ModelSynchronizer<TComponent, TModelNode> : DevExpress.ExpressApp.Model.ModelSynchronizer<TComponent, TModelNode> where TModelNode : IModelNode {
        static readonly HashSet<string> _excludedNodeMembers =
            new HashSet<string>(new[] { "Id", "Index", "Removed", "IsNewNode", "IsRemovedNode" });
        protected ModelSynchronizer(TComponent component, TModelNode modelNode)
            : base(component, modelNode) {
        }

        protected void SynchronizeValues(ModelNode modelNode, object component, PropertyDescriptorCollection properties) {

            foreach (var valueInfo in GetModelValueInfos(modelNode)) {
                var propertyDescriptor = properties.Find(valueInfo.Name, false);
                if (propertyDescriptor != null) {
                    var propertyValue = GetPropertyValue(component, propertyDescriptor, valueInfo, modelNode);
                    var modelValue = GetSynchronizeValuesNodeValue(modelNode, valueInfo, propertyDescriptor, valueInfo.PropertyType.IsNullableType(), component);
                    if (modelValue != null && !modelValue.Equals(propertyValue)) {
                        modelNode.SetValue(valueInfo.Name, propertyValue);
                    }
                }
            }
        }

        protected virtual object GetSynchronizeValuesNodeValue(ModelNode modelNode, ModelValueInfo valueInfo, PropertyDescriptor propertyDescriptor, bool isNullableType, object component) {
            return !isNullableType ? GetNodeValueCore(modelNode, valueInfo) : null;
        }

        protected virtual object GetPropertyValue(object component, PropertyDescriptor propertyDescriptor, ModelValueInfo valueInfo, ModelNode modelNode) {
            return propertyDescriptor.GetValue(component);
        }

        protected virtual bool IsDefaultValue(object value, PropertyDescriptor propertyDescriptor) {
            var defaultValueAttribute = propertyDescriptor.Attributes.OfType<DefaultValueAttribute>().SingleOrDefault();
            return defaultValueAttribute != null && defaultValueAttribute.Value.Equals(value);
        }

        protected void ApplyModel(IModelNode node, object component, Action<ModelNode, object, PropertyDescriptorCollection> action) {
            if (component is IModelNode)
                throw new ArgumentOutOfRangeException("component");
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(component);
            var mNode = (ModelNode)node;
            action.Invoke(mNode, component, properties);
            for (int i = 0; i < node.NodeCount; i++) {
                var modelNode = mNode[i];
                var propertyDescriptor = properties.Find(modelNode.Id, false);
                if (propertyDescriptor != null) {
                    ApplyModel(modelNode, propertyDescriptor.GetValue(component), action);
                }
            }
        }

        protected void ApplyValues(ModelNode node, object component, PropertyDescriptorCollection properties) {
            foreach (var valueInfo in GetModelValueInfos(node)) {
                var propertyDescriptor = properties.Find(valueInfo.Name, false);
                if (propertyDescriptor != null) {
                    var nodeValue = GetApplyModelNodeValue(node, valueInfo);
                    if (nodeValue != null) {
                        var propertyType = propertyDescriptor.PropertyType;
                        var propertyValue = propertyDescriptor.GetValue(component);
                        if ((!IsDefaultCoreValue(nodeValue, propertyType) || (!nodeValue.Equals(propertyValue))) && propertyType.IsValidEnum(nodeValue)) {
                            if (!nodeValue.Equals(propertyValue))
                                propertyDescriptor.SetValue(component, nodeValue);
                        }
                    }
                }
            }
        }

        protected virtual object GetApplyModelNodeValue(ModelNode node, ModelValueInfo valueInfo) {
            return GetNodeValueCore(node, valueInfo);
        }

        protected object PropertyDefaultValue(object value, ModelNode node, PropertyDescriptor propertyDescriptor, ModelValueInfo valueInfo, object component) {
            var defaultValueAttribute = propertyDescriptor.Attributes.OfType<DefaultValueAttribute>().FirstOrDefault();
            if (defaultValueAttribute == null) {
                if (propertyDescriptor.PropertyType.IsStruct())
                    return Activator.CreateInstance(propertyDescriptor.PropertyType);
            } else if (defaultValueAttribute.Value.Equals(propertyDescriptor.GetValue(component))) {
                return null;
            }
            return NodeRealValueCore(valueInfo, node);
        }

        object NodeRealValueCore(ModelValueInfo valueInfo, ModelNode node) {
            var nodeValue = GetNodeValueCore(node, valueInfo);
            if (nodeValue == null && !valueInfo.IsReadOnly && valueInfo.PropertyType != typeof(string)) {
                if (valueInfo.PropertyType.IsStruct())
                    return Activator.CreateInstance(valueInfo.PropertyType);
                if (valueInfo.PropertyType.IsNullableType())
                    return Activator.CreateInstance(valueInfo.PropertyType.GetGenericArguments()[0]);
                throw new NotImplementedException(valueInfo.PropertyType.ToString());
            }
            return nodeValue;
        }

        protected virtual object GetNodeValueCore(ModelNode node, ModelValueInfo valueInfo) {
            if (valueInfo.IsReadOnly)
                return null;
            var nodeValue = node.GetValue(valueInfo.Name);
            return valueInfo.PropertyType.IsStruct() && nodeValue.Equals(Activator.CreateInstance(valueInfo.PropertyType))
                       ? null
                       : nodeValue;
        }


        protected virtual IEnumerable<ModelValueInfo> GetModelValueInfos(IModelNode modelNode) {
            return IsDisabled(modelNode) ? Enumerable.Empty<ModelValueInfo>() : ((ModelNode)modelNode).NodeInfo.ValuesInfo.Where(IsNotExcluded);
        }

        static bool IsDisabled(IModelNode modelNode) {
            return modelNode is IModelNodeEnabled && !((IModelNodeEnabled)modelNode).NodeEnabled;
        }

        static bool IsNotExcluded(ModelValueInfo info) {
            return !_excludedNodeMembers.Contains(info.Name);
        }

        protected virtual bool IsDefaultCoreValue(object value, Type propertyType) {
            if (value == null)
                return true;
            if (value is string)
                return ReferenceEquals(value, "");
            return propertyType.IsValueType && Activator.CreateInstance(propertyType).Equals(value);
        }
    }
    public abstract class ModelListSynchronizer : ModelSynchronizer {
        private List<IModelSynchronizable> _modelSynchronizerList;

        protected ModelListSynchronizer(object control, IModelNode model)
            : base(control, model) {
                _modelSynchronizerList = new List<IModelSynchronizable>();

        }

        protected override void ApplyModelCore() {
            foreach(IModelSynchronizable synchronizer in _modelSynchronizerList) {
                synchronizer.ApplyModel();
            }
        }
        public override void SynchronizeModel() {
            foreach(IModelSynchronizable synchronizer in _modelSynchronizerList) {
                synchronizer.SynchronizeModel();
            }
        }

        public List<IModelSynchronizable> ModelSynchronizerList {
            get { return _modelSynchronizerList; }
        }

        public override void Dispose() {
            base.Dispose();
            if(_modelSynchronizerList != null) {
                for(int i = 0 ; i < _modelSynchronizerList.Count; i++) {
                    if(_modelSynchronizerList[i] is IDisposable) {
                        ((IDisposable)_modelSynchronizerList[i]).Dispose();
                    }
                }
                _modelSynchronizerList.Clear();
                _modelSynchronizerList = null;
            }
        }
    }
}
