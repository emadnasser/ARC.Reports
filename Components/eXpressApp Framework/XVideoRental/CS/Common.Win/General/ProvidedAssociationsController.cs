using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace Common.Win.General {

    [AttributeUsage(AttributeTargets.Property)]
    public class ProvidedAssociationAttribute : Attribute {
        readonly string _attributesFactoryProperty;
        readonly string _providedPropertyName;
        readonly string _associationName;
        readonly RelationType _relationType;


        public ProvidedAssociationAttribute(string associationName)
            : this(associationName, null) {
        }

        public ProvidedAssociationAttribute(string associationName, string providedPropertyName)
            : this(associationName, providedPropertyName, RelationType.Undefined, null) {
        }

        public ProvidedAssociationAttribute(string associationName, RelationType relationType)
            : this(associationName, null, relationType, null) {
        }


        public ProvidedAssociationAttribute(string associationName, string providedPropertyName, RelationType relationType,
                                            string attributesFactory) {
            _associationName = associationName;
            _relationType = relationType;
            _attributesFactoryProperty = attributesFactory;
            _providedPropertyName = providedPropertyName;
        }

        public string AssociationName {
            get { return _associationName; }
        }

        public string AttributesFactoryProperty {
            get { return _attributesFactoryProperty; }
        }

        public string ProvidedPropertyName {
            get { return _providedPropertyName; }
        }


        public RelationType RelationType {
            get { return _relationType; }
        }
    }

    public enum RelationType {
        Undefined,
        ManyToMany,
        OneToMany
    }

    public class ProvidedAssociationsController : Controller {

        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            foreach (var memberInfo in GetDecoratedMembers(typesInfo)) {
                var providedAssociationAttribute = (ProvidedAssociationAttribute)memberInfo.FindAttributeInfo(typeof(ProvidedAssociationAttribute));
                var associationAttribute = GetAssociationAttribute(memberInfo, providedAssociationAttribute);
                var customMemberInfo = CreateMemberInfo(typesInfo, memberInfo, providedAssociationAttribute, associationAttribute);
                AddExtraAttributes(memberInfo, providedAssociationAttribute, customMemberInfo);
            }
        }

        void AddExtraAttributes(XPMemberInfo memberInfo, ProvidedAssociationAttribute providedAssociationAttribute, XPMemberInfo customMemberInfo) {
            if (!(string.IsNullOrEmpty(providedAssociationAttribute.AttributesFactoryProperty)))
                foreach (var attribute in GetAttributes(providedAssociationAttribute.AttributesFactoryProperty, memberInfo.Owner)) {
                    customMemberInfo.AddAttribute(attribute);
                }
        }

        IEnumerable<XPMemberInfo> GetDecoratedMembers(ITypesInfo typesInfo) {
            var memberInfos =
                typesInfo.PersistentTypes.Where(info => (info.IsInterface && !info.IsDomainComponent) || !info.IsInterface).SelectMany(typeInfo => {
                    XPClassInfo xpClassInfo = XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary.QueryClassInfo(typeInfo.Type);
                    return xpClassInfo != null ? xpClassInfo.OwnMembers : new List<XPMemberInfo>();
                });
            return memberInfos.Where(memberInfo => memberInfo.HasAttribute(typeof(ProvidedAssociationAttribute)));
        }

        AssociationAttribute GetAssociationAttribute(XPMemberInfo memberInfo, ProvidedAssociationAttribute providedAssociationAttribute) {
            var associationAttribute = memberInfo.FindAttributeInfo(typeof(AssociationAttribute)) as AssociationAttribute;
            if (associationAttribute == null && !string.IsNullOrEmpty(providedAssociationAttribute.AssociationName))
                associationAttribute = new AssociationAttribute(providedAssociationAttribute.AssociationName);
            else if (associationAttribute == null)
                throw new NullReferenceException(memberInfo + " has no association attribute");
            return associationAttribute;
        }

        IEnumerable<Attribute> GetAttributes(string attributesFactoryProperty, XPClassInfo owner) {
            PropertyInfo memberInfo = owner.ClassType.GetProperty(attributesFactoryProperty);
            return memberInfo != null ? (IEnumerable<Attribute>)memberInfo.GetValue(null, null) : new List<Attribute>();
        }

        private XPMemberInfo CreateMemberInfo(ITypesInfo typesInfo, XPMemberInfo memberInfo, ProvidedAssociationAttribute providedAssociationAttribute, AssociationAttribute associationAttribute) {
            var typeToCreateOn = GetTypeToCreateOn(memberInfo, associationAttribute);
            if (typeToCreateOn == null)
                throw new NotImplementedException();
            XPMemberInfo xpCustomMemberInfo;
            if (!(memberInfo.IsCollection) || (memberInfo.IsCollection && providedAssociationAttribute.RelationType == RelationType.ManyToMany)) {
                xpCustomMemberInfo = typesInfo.CreateCollection(
                    typeToCreateOn,
                    memberInfo.Owner.ClassType,
                    associationAttribute.Name,
                    XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary,
                    providedAssociationAttribute.ProvidedPropertyName ?? memberInfo.Owner.ClassType.Name + "s", false);
            } else {
                xpCustomMemberInfo = typesInfo.CreateMember(
                    typeToCreateOn,
                    memberInfo.Owner.ClassType,
                    associationAttribute.Name,
                    XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary,
                    providedAssociationAttribute.ProvidedPropertyName ?? memberInfo.Owner.ClassType.Name, false);
            }

            if (!string.IsNullOrEmpty(providedAssociationAttribute.AssociationName) && !memberInfo.HasAttribute(typeof(AssociationAttribute)))
                memberInfo.AddAttribute(new AssociationAttribute(providedAssociationAttribute.AssociationName));

            typesInfo.RefreshInfo(typeToCreateOn);

            return xpCustomMemberInfo;
        }

        private Type GetTypeToCreateOn(XPMemberInfo memberInfo, AssociationAttribute associationAttribute) {
            return !memberInfo.MemberType.IsGenericType
                       ? (string.IsNullOrEmpty(associationAttribute.ElementTypeName)
                              ? memberInfo.MemberType
                              : Type.GetType(associationAttribute.ElementTypeName))
                       : memberInfo.MemberType.GetGenericArguments()[0];
        }
    }
}
