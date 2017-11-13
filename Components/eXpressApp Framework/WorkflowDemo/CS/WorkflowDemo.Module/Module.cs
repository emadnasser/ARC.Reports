using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using WorkflowDemo.Module.Objects;

namespace WorkflowDemo.Module {
	public sealed partial class WorkflowDemoModule : ModuleBase {
        public const string WorkflowServerAddress = "http://localhost:46232/";
        //public const string WorkflowServerAddress = "net.pipe://localhost/WFDemo";
        public static Binding WorkflowBinding = new BasicHttpBinding();
        //public static Binding WorkflowBinding = new NetNamedPipeBinding();

        public WorkflowDemoModule() {
			InitializeComponent();
            this.AdditionalExportedTypes.Add(typeof(Issue));
            this.AdditionalExportedTypes.Add(typeof(Task));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Workflow.WorkflowModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule));
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
}
