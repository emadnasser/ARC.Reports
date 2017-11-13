using System;
using System.Data.Entity.Infrastructure;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.EF;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;

namespace FeatureCenter.Module.ListEditors {
	public class DataAccessModeDemoController : ViewController {
		private const string DatabaseSelectCountActionCaption = "Database select count";
		private SingleChoiceAction selectDataAccessModeAction;
		private SimpleAction infoAction;
		private Int32 selectCount;

		private void TestDbContext_DatabaseSelectExecuted(Object sender, EventArgs e) {
			if(((IObjectContextAdapter)sender).ObjectContext == ((EFObjectSpace)ObjectSpace).ObjectContext) {
				selectCount++;
				infoAction.Caption = DatabaseSelectCountActionCaption + ": " + selectCount.ToString();
			}
		}
		private void selectDataAccessModeAction_Execute(Object sender, SingleChoiceActionExecuteEventArgs e) {
			IModelListView listViewModel = (IModelListView)Application.FindModelView(Application.FindListViewId(TargetObjectType));
			listViewModel.DataAccessMode = (CollectionSourceDataAccessMode)e.SelectedChoiceActionItem.Data;
			IObjectSpace objectSpace = Application.CreateObjectSpace(TargetObjectType);
			e.ShowViewParameters.CreatedView = Application.CreateListView(objectSpace, TargetObjectType, true);
		}

		protected override void OnActivated() {
			base.OnActivated();
            foreach(ChoiceActionItem item in selectDataAccessModeAction.Items) {
                if(!((ListView)this.View).Editor.SupportsDataAccessMode((CollectionSourceDataAccessMode)item.Data)) {
                    item.Active["Not supported"] = false;
                }
            }
			foreach(ChoiceActionItem item in selectDataAccessModeAction.Items) {
				if((CollectionSourceDataAccessMode)item.Data == ((ListView)View).CollectionSource.DataAccessMode) {
					selectDataAccessModeAction.SelectedItem = item;
					break;
				}
			}
			selectCount = 0;
			TestDbContext.DatabaseSelectExecuted += TestDbContext_DatabaseSelectExecuted;
		}
		protected override void OnDeactivated() {
			base.OnDeactivated();
			TestDbContext.DatabaseSelectExecuted -= TestDbContext_DatabaseSelectExecuted;
		}

		public DataAccessModeDemoController()
			: base() {
			TypeOfView = typeof(ListView);
			TargetObjectType = typeof(DataAccessModeDemoObject);
			TargetViewNesting = Nesting.Root;

			selectDataAccessModeAction = new SingleChoiceAction(this, "SelectDataAccessMode", PredefinedCategory.View);
			selectDataAccessModeAction.Caption = "Select DataAccessMode";
			selectDataAccessModeAction.Items.Add(new ChoiceActionItem("Client", CollectionSourceDataAccessMode.Client));
			selectDataAccessModeAction.Items.Add(new ChoiceActionItem("Server", CollectionSourceDataAccessMode.Server));
			selectDataAccessModeAction.Items.Add(new ChoiceActionItem("DataView", CollectionSourceDataAccessMode.DataView));
            selectDataAccessModeAction.Items.Add(new ChoiceActionItem("Instant Feedback", CollectionSourceDataAccessMode.InstantFeedback));
            selectDataAccessModeAction.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Caption;
			selectDataAccessModeAction.ImageName = "ListEditors.Demo_ListEditors_Grid_LargeData";
			selectDataAccessModeAction.Execute += selectDataAccessModeAction_Execute;

			infoAction = new SimpleAction(this, "DatabaseSelectCount", PredefinedCategory.View);
			infoAction.Caption = DatabaseSelectCountActionCaption;
			infoAction.Enabled["A"] = false;
		}
	}
}
