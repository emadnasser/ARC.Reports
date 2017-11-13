using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Linq;
using Common.Win.General.AliasedMembers;
using Common.Win.General.DashBoard.BusinessObjects;
using Common.Win.General.Security;
using Common.Win.General.Sequence;
using Common.Win.General.ViewCloner;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Validation;

namespace Common.Win {
    [ModelAbstractClass]
    public interface IModelStaticTextEx : IModelStaticText {
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        new string Text { get; set; }
    }
    public class CommonWindowsFormsModule : ModuleBase, IModelNodeUpdater<IModelRuntimeCalculatedMember> {
        public CommonWindowsFormsModule() {
            AdditionalExportedTypes.Add(typeof(Sequence));
        }
        protected override IEnumerable<Type> GetDeclaredExportedTypes() {
            var declaredExportedTypes = base.GetDeclaredExportedTypes();
            declaredExportedTypes = declaredExportedTypes.Union(new[] { typeof(DashboardDefinition) });
            return declaredExportedTypes;
        }

        public override void Setup(XafApplication application) {
            base.Setup(application);
            if (application != null) {
                SequenceGeneratorInitializer.Register(application);
                if (InterfaceBuilder.RuntimeMode)
                    ((TypesInfo) XafTypesInfo.Instance).AddEntityStore(new XpandXpoTypeInfoSource((TypesInfo) XafTypesInfo.Instance));

                application.SetupComplete += (sender, args) => RuntimeMemberBuilder.AddFields(application.Model);
                application.LoggedOn += (sender, args) => RuntimeMemberBuilder.AddFields(application.Model);
            }
        }


        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            if (Application != null) {
                var roleTypeProvider = Application.Security as IRoleTypeProvider;
                if (roleTypeProvider != null) {
                    foreach (var attribute in SecurityOperationsAttributes(typesInfo)) {
                        CreateMember(typesInfo, roleTypeProvider, attribute);
                    }
                }
            }
        }

        IEnumerable<SecurityOperationsAttribute> SecurityOperationsAttributes(ITypesInfo typesInfo) {
            var typeInfos = typesInfo.PersistentTypes.Where(info => info.FindAttribute<SecurityOperationsAttribute>() != null);
            return typeInfos.SelectMany(info => info.FindAttributes<SecurityOperationsAttribute>());
        }

        void CreateMember(ITypesInfo typesInfo, IRoleTypeProvider roleTypeProvider, SecurityOperationsAttribute attribute) {
            var roleTypeInfo = typesInfo.FindTypeInfo(roleTypeProvider.RoleType);
            if (roleTypeInfo.FindMember(attribute.OperationProviderProperty) == null) {
                var memberInfo = roleTypeInfo.CreateMember(attribute.OperationProviderProperty, typeof(SecurityOperationsEnum));
                memberInfo.AddAttribute(new RuleRequiredFieldAttribute());
            }
        }

        public override void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
            base.ExtendModelInterfaces(extenders);
            extenders.Add<IModelStaticText, IModelStaticTextEx>();
        }

        public override void Setup(ApplicationModulesManager moduleManager) {
            base.Setup(moduleManager);
            OverallCustomizationAllowedPermissionRequest.Register(Application);
        }

        public override void AddModelNodeUpdaters(IModelNodeUpdaterRegistrator updaterRegistrator){
            base.AddModelNodeUpdaters(updaterRegistrator);
            updaterRegistrator.AddUpdater(new ModelOptionsAdvBandedViewUpdater());
        }

        public override void AddGeneratorUpdaters(ModelNodesGeneratorUpdaters updaters) {
            base.AddGeneratorUpdaters(updaters);
            updaters.Add(new ModelViewClonerUpdater());
        }

        public void UpdateNode(IModelRuntimeCalculatedMember node, IModelApplication application) {
            node.IsCustom = false;
        }
    }
}
