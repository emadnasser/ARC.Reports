using System;
using System.Configuration;
using System.Collections.Generic;

using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Kpi;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Validation;
using DevExpress.Persistent.AuditTrail;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.ReportsV2;
using FeatureCenter.Module.Reports;
using FeatureCenter.Module.Actions;
using DevExpress.Internal;
using FeatureCenter.Module.ListEditors;
using System.Data.Entity;

namespace FeatureCenter.Module {
    public sealed partial class FeatureCenterModule : ModuleBase {
        static FeatureCenterModule() {
            DevExpress.ExpressApp.SystemModule.ObjectMethodActionsViewController.Enabled = false;
            ModelNodesGeneratorSettings.SetIdPrefix(typeof(FeatureCenter.Module.ConcurrentModifications.Person), "ConcurrentModifications.Person");
            DevExpress.Data.Linq.CriteriaToEFExpressionConverter.EntityFunctionsType = typeof(System.Data.Entity.DbFunctions);
            DevExpress.Data.Linq.CriteriaToEFExpressionConverter.SqlFunctionsType = typeof(System.Data.Entity.SqlServer.SqlFunctions);
            Database.SetInitializer<TestDbContext>(new DropCreateDatabaseIfModelChanges<TestDbContext>());
        }
        public FeatureCenterModule() {
            InitializeComponent();
            DateRangeRepository.RegisterRange(new DateRange("Rolling 1994", new RangePoint(new DateTime(1994, 1, 1), 0, TimeIntervalType.Day), new RangePoint(new DateTime(1994, 1, 1), DateTime.Today.DayOfYear, TimeIntervalType.Day)));
            DateRangeRepository.RegisterRange(new DateRange("Rolling 1995", new RangePoint(new DateTime(1995, 1, 1), 0, TimeIntervalType.Day), new RangePoint(new DateTime(1995, 1, 1), DateTime.Today.DayOfYear, TimeIntervalType.Day)));
            DateRangeRepository.RegisterRange(new DateRange("Rolling 1996", new RangePoint(new DateTime(1996, 1, 1), 0, TimeIntervalType.Day), new RangePoint(new DateTime(1996, 1, 1), DateTime.Today.DayOfYear, TimeIntervalType.Day)));
            ModelMemberReadOnlyCalculator.AllowPersistentCustomProperties = true;
            Hints.RegisterViewSpecificHints();
        }

        private void Application_CustomizeFormattingCulture(object sender, CustomizeFormattingCultureEventArgs e) {
            e.FormattingCulture.NumberFormat.CurrencySymbol = System.Globalization.CultureInfo.GetCultureInfo("en-US").NumberFormat.CurrencySymbol;
        }
        private void application_CustomProcessShortcut(object sender, CustomProcessShortcutEventArgs e) {
            if (e.Shortcut != null && !string.IsNullOrEmpty(e.Shortcut.ViewId)) {
                IModelView modelView = Application.FindModelView(e.Shortcut.ViewId);
                if (modelView is IModelObjectView) {
                    ITypeInfo typeInfo = ((IModelObjectView)modelView).ModelClass.TypeInfo;
                    AutoCreatableObjectAttribute attribute = typeInfo.FindAttribute<AutoCreatableObjectAttribute>(true);
                    if (attribute != null && attribute.AutoCreatable) {
						IObjectSpace objSpace = Application.CreateObjectSpace(typeInfo.Type);
                        object obj;
                        if (typeof(XPBaseObject).IsAssignableFrom(typeInfo.Type) ||
                            (typeInfo.IsInterface && typeInfo.IsDomainComponent)) {
                            obj = objSpace.FindObject(typeInfo.Type, null);
                            if (obj == null) {
                                obj = objSpace.CreateObject(typeInfo.Type);
                            }
                        }
                        else {
                            if (typeInfo.Type == typeof(WelcomeObject)) {
                                obj = WelcomeObject.Instance;
                            }
                            else {
                                obj = Activator.CreateInstance(typeInfo.Type);
                            }
                        }
                        //obj = typeof(BaseObject).IsAssignableFrom(typeInfo.Type) ? objSpace.CreateObject(typeInfo.Type) : Activator.CreateInstance(typeInfo.Type);
                        DetailView detailView = Application.CreateDetailView(objSpace, obj, true);
                        if (attribute.ViewEditMode == ViewEditMode.Edit) {
                            detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
                        }
                        e.View = detailView;
                        e.Handled = true;
                    }
                }
            }
        }
        private void AuditTrailServiceInstance_QueryCurrentUserName(object sender, QueryCurrentUserNameEventArgs e) {
            //Do not remove this line. Usually, the current user name is supplied by an XAF application's Security System. 
            //However, the FeatureCenter demo doesn't use the Security System module. 
            //That's why we have to use the WindowsIdentity, to get the current user name.

            e.CurrentUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
        private void AuditTrailServiceInstance_CustomizeAuditTrailSettings(object sender, CustomizeAuditTrailSettingsEventArgs e) {
            e.AuditTrailSettings.Clear();
            e.AuditTrailSettings.AddType(typeof(FeatureCenter.Module.Audit.SimplePropertiesAuditedObject), true);
            e.AuditTrailSettings.AddType(typeof(FeatureCenter.Module.Audit.CollectionPropertiesAuditedObject), true);
            e.AuditTrailSettings.AddType(typeof(FeatureCenter.Module.Audit.AuditSettingsObject), new string[] { "Name", "AuditedProperty" });
            e.AuditTrailSettings.AddType(typeof(FeatureCenter.Module.Audit.ObjectAuditingModesObject), true);
        }
        private void CustomizeAppearanceDemoObject(ITypeInfo ti) {
            if (ti != null) {
                IMemberInfo mi1 = ti.FindMember("HideSimpleLayoutItem");
                if (mi1 == null) {
                    mi1 = ti.CreateMember("HideSimpleLayoutItem", typeof(bool));
                    mi1.AddAttribute(new ImmediatePostDataAttribute());
                    mi1.AddAttribute(new VisibleInListViewAttribute(false));
                    mi1.AddAttribute(new VisibleInLookupListViewAttribute(false));
                }
                IMemberInfo mi2 = ti.FindMember("HideSimpleLayoutGroup");
                if (mi2 == null) {
                    mi2 = ti.CreateMember("HideSimpleLayoutGroup", typeof(bool));
                    mi2.AddAttribute(new ImmediatePostDataAttribute());
                    mi2.AddAttribute(new VisibleInListViewAttribute(false));
                    mi2.AddAttribute(new VisibleInLookupListViewAttribute(false));
                }
                IMemberInfo mi3 = ti.FindMember("HideTabPageGroup");
                if (mi3 == null) {
                    mi3 = ti.CreateMember("HideTabPageGroup", typeof(bool));
                    mi3.AddAttribute(new ImmediatePostDataAttribute());
                    mi3.AddAttribute(new VisibleInListViewAttribute(false));
                    mi3.AddAttribute(new VisibleInLookupListViewAttribute(false));
                }
            }
        }
        protected override IEnumerable<Type> GetDeclaredExportedTypes() {
            List<Type> declaredExportedTypes = new List<Type>(base.GetDeclaredExportedTypes());
            declaredExportedTypes.Add(typeof(OidGenerator));
            return declaredExportedTypes;
        }
        public override void Setup(ApplicationModulesManager moduleManager) {
            base.Setup(moduleManager);
            ValidationRulesRegistrator.RegisterRule(moduleManager, typeof(FeatureCenter.Module.Validation.RuleStringLengthComparison), typeof(FeatureCenter.Module.Validation.IRuleStringLengthComparisonProperties));
            ValidationRulesRegistrator.RegisterRule(moduleManager, typeof(FeatureCenter.Module.Validation.CodeRuleObjectIsValidRule), typeof(DevExpress.Persistent.Validation.IRuleBaseProperties));
        }
        //protected override void CustomizeModelApplicationCreatorProperties(ModelApplicationCreatorProperties creatorProperties) {
        //    base.CustomizeModelApplicationCreatorProperties(creatorProperties);
        //    creatorProperties.RegisterObject(
        //        typeof(DevExpress.ExpressApp.Validation.IModelRuleBase),
        //        typeof(FeatureCenter.Module.Validation.RuleStringLengthComparison),
        //        typeof(FeatureCenter.Module.Validation.IRuleStringLengthComparisonProperties));
        //    creatorProperties.RegisterObject(
        //        typeof(DevExpress.ExpressApp.Validation.IModelRuleBase),
        //        typeof(FeatureCenter.Module.Validation.CodeRuleObjectIsValidRule),
        //        typeof(DevExpress.Persistent.Validation.IRuleBaseProperties));
        //}
        protected override ModuleTypeList GetRequiredModuleTypesCore() {
            ModuleTypeList moduleTypeList = base.GetRequiredModuleTypesCore();
            moduleTypeList.Add(typeof(DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule));
            moduleTypeList.Add(typeof(DevExpress.ExpressApp.SystemModule.SystemModule));
            return moduleTypeList;
        }
        public override void AddGeneratorUpdaters(ModelNodesGeneratorUpdaters updaters) {
            base.AddGeneratorUpdaters(updaters);
            updaters.Add(new ModelImageSourcesUpdater());
            updaters.Add(new CustomDetailViewItemsGenarator());
            updaters.Add(new CustomModelViewsUpdater());
            updaters.Add(new CustomBOModelUpdater());
            updaters.Add(new CustomBOModelMemberUpdater());
            updaters.Add(new CustomDetailViewLayoutGenarator());
        }
        public override void Setup(XafApplication application) {
            base.Setup(application);
            XafTypesInfo.Instance.RegisterEntity("PersistentProperties", typeof(FeatureCenter.Module.DC.IPersistentPropertiesPresenter));
            XafTypesInfo.Instance.RegisterEntity("Contact", typeof(FeatureCenter.Module.DC.IContact));
            XafTypesInfo.Instance.RegisterEntity("Phone", typeof(FeatureCenter.Module.DC.IPhone));

            XafTypesInfo.Instance.RegisterEntity("Associations", typeof(FeatureCenter.Module.DC.IAssociationsPresenter));
            XafTypesInfo.Instance.RegisterEntity("Company", typeof(FeatureCenter.Module.DC.ICompany));
            XafTypesInfo.Instance.RegisterEntity("Owner", typeof(FeatureCenter.Module.DC.IOwner));
            XafTypesInfo.Instance.RegisterEntity("Department", typeof(FeatureCenter.Module.DC.IDepartment));
            XafTypesInfo.Instance.RegisterEntity("Address", typeof(FeatureCenter.Module.DC.IAddress));

            XafTypesInfo.Instance.RegisterEntity("MultipleInheritance", typeof(FeatureCenter.Module.DC.IMultipleInheritancePresenter));
            XafTypesInfo.Instance.RegisterEntity("OfficeManager", typeof(FeatureCenter.Module.DC.IOfficeManager));
            XafTypesInfo.Instance.RegisterEntity("ProductManager", typeof(FeatureCenter.Module.DC.IProductManager));
            XafTypesInfo.Instance.RegisterSharedPart(typeof(FeatureCenter.Module.DC.IManager));
            XafTypesInfo.Instance.RegisterSharedPart(typeof(FeatureCenter.Module.DC.IWorker));

            XafTypesInfo.Instance.RegisterEntity("DomainLogicForProperties", typeof(FeatureCenter.Module.DC.IDomainLogicForPropertiesPresenter));
            XafTypesInfo.Instance.RegisterEntity("Product", typeof(FeatureCenter.Module.DC.IProduct));
            XafTypesInfo.Instance.RegisterEntity("Review", typeof(FeatureCenter.Module.DC.IReview));

            XafTypesInfo.Instance.RegisterEntity("DomainLogicForMethods", typeof(FeatureCenter.Module.DC.IDomainLogicForMethodsPresenter));
            XafTypesInfo.Instance.RegisterEntity("Task", typeof(FeatureCenter.Module.DC.ITask));
            XafTypesInfo.Instance.RegisterEntity("TaskReport", typeof(FeatureCenter.Module.DC.ITaskReport));

            XafTypesInfo.Instance.RegisterEntity("DomainLogicInheritance", typeof(FeatureCenter.Module.DC.IDomainLogicInheritancePresenter));
            XafTypesInfo.Instance.RegisterEntity("Person", typeof(FeatureCenter.Module.DC.IPerson));
            XafTypesInfo.Instance.RegisterEntity("Client", typeof(FeatureCenter.Module.DC.IClient));
            Application.CustomizeFormattingCulture += new EventHandler<CustomizeFormattingCultureEventArgs>(Application_CustomizeFormattingCulture);
            application.CustomProcessShortcut += new EventHandler<CustomProcessShortcutEventArgs>(application_CustomProcessShortcut);
            AuditTrailService.Instance.TimestampStrategy = new LocalAuditTimestampStrategy();
            AuditTrailService.Instance.QueryCurrentUserName += new QueryCurrentUserNameEventHandler(AuditTrailServiceInstance_QueryCurrentUserName);
            AuditTrailService.Instance.CustomizeAuditTrailSettings += new CustomizeAuditSettingsEventHandler(AuditTrailServiceInstance_CustomizeAuditTrailSettings);
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            CustomizeAppearanceDemoObject(typesInfo.FindTypeInfo(typeof(FeatureCenter.Module.ConditionalAppearance.ConditionalAppearanceHideShowEditorsObject)));
        }
        public override void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
            base.ExtendModelInterfaces(extenders);
            extenders.Add<IModelMember, IModelMemberExtender>();
            extenders.Add<IModelPropertyEditor, IModelPropertyEditorClassMemberExtender>();
            extenders.Add<IModelLayoutGroup, IModelLayoutGroupExtender>();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new Updater(objectSpace, versionFromDB);
            PredefinedReportsUpdater predefinedReportsUpdater =
                new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);
            predefinedReportsUpdater.AddPredefinedReport<ContactReport>(
            "Contacts Report", typeof(ContactForReport), true);
            return new ModuleUpdater[] { updater, predefinedReportsUpdater };
        }
		public static String GetEFConnectionString() {
			String result = null;
			ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EFConnectionString"];
			if(connectionStringSettings != null) {
				result = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
			}
			return result;
		}
	}

    public class ModelImageSourcesUpdater : ModelNodesGeneratorUpdater<ImageSourceNodesGenerator> {
        public override void UpdateNode(ModelNode node) {
            IModelAssemblyResourceImageSource customImages = (IModelAssemblyResourceImageSource)node[CustomImages.CustomImagesAssemblyInfo.AssemblyName];
            if (customImages == null) {
                customImages = node.AddNode<IModelAssemblyResourceImageSource>(CustomImages.CustomImagesAssemblyInfo.AssemblyName);
                customImages.Index = node.NodeCount - 1;
            }
            customImages.Folder = "Images";
        }
    }


}
