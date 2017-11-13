using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Localization;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace Common.Win.General.AliasedMembers {
    public class RuntimeMemberBuilder {
        static readonly XPDictionary _dictionary = XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary;

        public static void AddFields(IModelApplication model) {
            AddRuntimeMembers(model);
        }

        private static IEnumerable<IModelRuntimeCalculatedMember> GetCustomFields(IModelApplication model) {
            return model.BOModel.SelectMany(modelClass => modelClass.AllMembers).OfType<IModelRuntimeCalculatedMember>();
        }

        static void AddRuntimeMembers(IModelApplication model) {
            foreach (IModelRuntimeCalculatedMember modelRuntimeMember in GetCustomFields(model))
                try {
                    Type classType = modelRuntimeMember.ModelClass.TypeInfo.Type;
                    XPClassInfo typeInfo = _dictionary.GetClassInfo(classType);
                    lock (typeInfo) {
                        if (typeInfo.FindMember(modelRuntimeMember.Name) == null) {
                            new XpandCalcMemberInfo(typeInfo, modelRuntimeMember.Name, modelRuntimeMember.Type, modelRuntimeMember.AliasExpression);
                            XafTypesInfo.Instance.RefreshInfo(classType);
                        }
                    }
                } catch (Exception exception) {
                    throw new Exception(
                        ExceptionLocalizerTemplate<SystemExceptionResourceLocalizer, ExceptionId>.GetExceptionMessage(
                            ExceptionId.ErrorOccursWhileAddingTheCustomProperty,
                            modelRuntimeMember.MemberInfo.MemberType,
                            ((IModelClass)modelRuntimeMember.Parent).Name,
                            modelRuntimeMember.Name,
                            exception.Message));
                }
        }


    }
    public class XpandCalcMemberInfo : XPCustomMemberInfo {
        public XpandCalcMemberInfo(XPClassInfo owner, string propertyName, Type propertyType, string aliasExpression)
            : base(owner, propertyName, propertyType, null, true, false) {
            AddAttribute(new PersistentAliasAttribute(aliasExpression));
        }

        public override object GetValue(object theObject) {
            var xpBaseObject = ((XPBaseObject)theObject);
            return !xpBaseObject.Session.IsObjectsLoading && !xpBaseObject.Session.IsObjectsSaving
                       ? xpBaseObject.EvaluateAlias(Name)
                       : base.GetValue(theObject);
        }

        protected override bool CanPersist {
            get { return false; }
        }
        public void SetAliasExpression(string aliasExpression) {
            if (HasAttribute(typeof(PersistentAliasAttribute)))
                RemoveAttribute(typeof(PersistentAliasAttribute));

            AddAttribute(new PersistentAliasAttribute(aliasExpression));
        }

    }

}
