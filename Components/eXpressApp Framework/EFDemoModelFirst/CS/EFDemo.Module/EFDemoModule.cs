using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.ViewVariantsModule;
using EFDemo.Module.Data;
using EFDemo.Module.Reports;

namespace EFDemo.Module {
	public sealed partial class EFDemoModule : ModuleBase {
		public static String Metadata = "res://*/Data.EFDemoModel.csdl|res://*/Data.EFDemoModel.ssdl|res://*/Data.EFDemoModel.msl";
		public static String Provider = "System.Data.SqlClient";

		private String GetContextId() {
			return Application.GetType().Name.Contains("WinApplication") ? "Win" : "Web";
		}
		private void Application_CreateCustomModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e) {
			e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), true, GetContextId());
			e.Handled = true;
		}
		private void Application_CreateCustomUserModelDifferenceStore(Object sender, CreateCustomModelDifferenceStoreEventArgs e) {
			e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), false, GetContextId());
			e.Handled = true;
		}

		protected override IEnumerable<Type> GetDeclaredExportedTypes() {
			return base.GetDeclaredExportedTypes();
		}
		static EFDemoModule() {
			Person.FullNameFormat = "{LastName} {FirstName} {MiddleName}";
			DevExpress.Data.Linq.CriteriaToEFExpressionConverter.SqlFunctionsType = typeof(SqlFunctions);
		}
		public EFDemoModule() {
			InitializeComponent();
		}
		public override void Setup(XafApplication application) {
			base.Setup(application);
			application.CreateCustomModelDifferenceStore += Application_CreateCustomModelDifferenceStore;
			application.CreateCustomUserModelDifferenceStore += Application_CreateCustomUserModelDifferenceStore;
		}
		public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            PredefinedReportsUpdater predefinedReportsUpdater = new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);
            predefinedReportsUpdater.AddPredefinedReport<ContactsReport>("Contacts Report", typeof(Contact), true);
            return new ModuleUpdater[] { updater, predefinedReportsUpdater };
		}
        public override void Setup(ApplicationModulesManager moduleManager) {
            base.Setup(moduleManager);
            ReportsModuleV2 reportModule = moduleManager.Modules.FindModule<ReportsModuleV2>();
            reportModule.ReportDataType = typeof(ReportDataV2);
        }
	}
}
