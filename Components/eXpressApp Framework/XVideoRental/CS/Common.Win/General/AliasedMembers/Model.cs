using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Xpo.Metadata;

namespace Common.Win.General.AliasedMembers {
    public class NotVisibileCalculator : IModelIsVisible {
        public bool IsVisible(IModelNode node, string propertyName) {
            return false;
        }
    }

    public class RuntimeOnlyCalculator : IModelIsVisible {
        public bool IsVisible(IModelNode node, string propertyName) {
            return !DesignerOnlyCalculator.IsRunFromDesigner;
        }
    }

    public interface IModelRuntimeCalculatedMember : IModelMember {
        [Required]
        [CriteriaOptions("ModelClass.TypeInfo")]
        [Editor("DevExpress.ExpressApp.Win.Core.ModelEditor.CriteriaModelEditorControl, DevExpress.ExpressApp.Win" + XafApplication.CurrentVersion, typeof(UITypeEditor))]
        string AliasExpression { get; set; }

        [ModelReadOnly(typeof(AlwaysEditableCalculator))]
        [Required]
        [TypeConverter(typeof(StringToTypeConverterExtended))]
        [Category("Data")]
        new Type Type { get; set; }

        [Browsable(false)]
        object Tag { get; set; }

        [Category("Appearance")]
        [DataSourceProperty("PropertyEditorTypes")]
        [TypeConverter(typeof(StringToTypeConverterBase))]
        [ModelBrowsable(typeof(RuntimeOnlyCalculator))]
        new Type PropertyEditorType { get; set; }
    }

    [DomainLogic(typeof(IModelRuntimeCalculatedMember))]
    public class ModelRuntimeCalculatedMemberLogic {
        public static IMemberInfo Get_MemberInfo(IModelRuntimeCalculatedMember runtimeCalculatedMember) {
            if (InterfaceBuilder.RuntimeMode) {
                CreateMemberInfo(runtimeCalculatedMember);
                return runtimeCalculatedMember.ModelClass.TypeInfo.FindMember(runtimeCalculatedMember.Name);
            }
            return ModelMemberLogic.Get_MemberInfo(runtimeCalculatedMember);
        }

        static void CreateMemberInfo(IModelRuntimeCalculatedMember runtimeCalculatedMember) {
            XPClassInfo classInfo = FindXPClassInfo(runtimeCalculatedMember);
            var xpandCalcMemberInfo = (XpandCalcMemberInfo)classInfo.FindMember(runtimeCalculatedMember.Name);
            if (ValidState(runtimeCalculatedMember, xpandCalcMemberInfo)) {
                var xpClassInfo = FindXPClassInfo(runtimeCalculatedMember);
                var calcMemberInfo = (XpandCalcMemberInfo)xpClassInfo.FindMember(runtimeCalculatedMember.Name);
                if (calcMemberInfo == null) {
                    xpandCalcMemberInfo = CreateXpandCalcMemberInfo(runtimeCalculatedMember, xpClassInfo);
                }
            }
            UpdateAliasExpression(xpandCalcMemberInfo, runtimeCalculatedMember.AliasExpression);
        }

        static void UpdateAliasExpression(XpandCalcMemberInfo memberInfo, string aliasExpression) {
            if (memberInfo != null) {
                memberInfo.SetAliasExpression(aliasExpression);
            }
        }

        static XpandCalcMemberInfo CreateXpandCalcMemberInfo(IModelRuntimeCalculatedMember runtimeCalculatedMember, XPClassInfo xpClassInfo) {
            var xpandCalcMemberInfo = new XpandCalcMemberInfo(xpClassInfo, runtimeCalculatedMember.Name, runtimeCalculatedMember.Type, runtimeCalculatedMember.AliasExpression);
            var typesInfo = ((BaseInfo)runtimeCalculatedMember.ModelClass.TypeInfo).Store;
            typesInfo.RefreshInfo(xpClassInfo.ClassType);
            return xpandCalcMemberInfo;
        }

        static bool ValidState(IModelRuntimeCalculatedMember runtimeCalculatedMember, XpandCalcMemberInfo memberInfo) {
            if (CheckTag(runtimeCalculatedMember)) return false;
            if (memberInfo == null && !string.IsNullOrEmpty(runtimeCalculatedMember.Name)) {
                runtimeCalculatedMember.Tag = true;
                if (runtimeCalculatedMember.Type != null && !string.IsNullOrEmpty(runtimeCalculatedMember.AliasExpression)) {
                    runtimeCalculatedMember.Tag = null;
                    return true;
                }
            }
            return false;
        }

        static XPClassInfo FindXPClassInfo(IModelRuntimeCalculatedMember runtimeCalculatedMember) {
            var typeInfo = (TypeInfo)runtimeCalculatedMember.ModelClass.TypeInfo;
            return typeInfo.IsInterface ? FindDCXPClassInfo(typeInfo) : XpoTypesInfoHelper.GetXpoTypeInfoSource().XPDictionary.GetClassInfo(typeInfo.Type);
        }

        static XPClassInfo FindDCXPClassInfo(TypeInfo typeInfo) {
            var xpoTypeInfoSource = XpoTypesInfoHelper.GetXpoTypeInfoSource();
            Debug.Assert(xpoTypeInfoSource != null, "xpoTypeInfoSource != null");
            var generatedEntityType = xpoTypeInfoSource.GetGeneratedEntityType(typeInfo.Type);
            return generatedEntityType == null ? null : xpoTypeInfoSource.XPDictionary.GetClassInfo(generatedEntityType);
        }

        static bool CheckTag(IModelRuntimeCalculatedMember runtimeCalculatedMember) {
            if (Equals(true, runtimeCalculatedMember.Tag)) {
                runtimeCalculatedMember.Tag = null;
                return true;
            }
            return false;
        }
    }
    public class AlwaysEditableCalculator : IModelIsReadOnly {

        public bool IsReadOnly(IModelNode node, string propertyName) {
            return false;
        }

		public bool IsReadOnly(IModelNode node, IModelNode childNode) {
            return false;
        }
    }
}
