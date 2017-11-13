using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates.ActionContainers;
using DevExpress.ExpressApp.Templates;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Actions;
using FeatureCenter.Module.Actions;
using System.Collections;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model.Core;

namespace FeatureCenter.Module.Navigation {
	public class DisableControllersForNavigationObject : DisableControllersByConditionViewController {
        protected override string DisableReason { get { return "NavigationObject"; } }
        protected override bool GetIsDisabled() {
			return true;
		}
		public DisableControllersForNavigationObject() {
			TargetObjectType = typeof(NavigationObject);
		}
	}
	public class DisableControllersForNavigationItemObject : DisableControllersByConditionViewController {
		protected override bool GetIsDisabled() {
			return true;
		}
		public DisableControllersForNavigationItemObject() {
			TargetObjectType = typeof(NavigationItem);
		}
	}
	public class NavigationDemoWindowController : WindowController {
        private static ModelApplicationCreator modelCreatorInstance;
        private ShowNavigationItemController showNavigationItemController;
		private void SubscribeToEvents() {
			showNavigationItemController.CustomShowNavigationItem += new EventHandler<CustomShowNavigationItemEventArgs>(showNavigationItemController_CustomShowNavigationItem);
		}
		private void UnsubscribeFromEvents() {
			showNavigationItemController.CustomShowNavigationItem -= new EventHandler<CustomShowNavigationItemEventArgs>(showNavigationItemController_CustomShowNavigationItem);
		}
		private void showNavigationItemController_CustomShowNavigationItem(object sender, CustomShowNavigationItemEventArgs e) {
			ViewShortcut viewShortcut = e.ActionArguments.SelectedChoiceActionItem.Data as ViewShortcut;
			string listViewId = Application.FindListViewId(typeof(NavigationObject));
			if(viewShortcut != null) {
				if(viewShortcut.ViewId == listViewId) {
					IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(NavigationObject));
					DetailView detailView = Application.CreateDetailView(objectSpace, objectSpace.FindObject(typeof(NavigationObject), null));
					detailView.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
					e.ActionArguments.ShowViewParameters.CreatedView = detailView;
					e.ActionArguments.ShowViewParameters.TargetWindow = TargetWindow.Current;
					e.Handled = true;
				}
			}
		}
		protected override void OnFrameAssigned() {
			base.OnFrameAssigned();
            ModelCreatorInstance = ((ModelNode)Application.Model).CreatorInstance;
            showNavigationItemController = Frame.GetController<ShowNavigationItemController>();
			if(showNavigationItemController != null) {
				UnsubscribeFromEvents();
				SubscribeToEvents();
			}
		}
		protected override void Dispose(bool disposing) {
			if(showNavigationItemController != null) {
				UnsubscribeFromEvents();
				showNavigationItemController = null;
			}
			base.Dispose(disposing);
		}
		public NavigationDemoWindowController() {
			TargetWindowType = WindowType.Main;
		}
        internal static ModelApplicationCreator ModelCreatorInstance {
            get {
                return modelCreatorInstance;
            }
            set {
                modelCreatorInstance = value;
            }
        }
    }
	public class NavigationObjectDetailViewController : ViewController<DetailView> {
		private NavigationObject CurrentObject {
			get {
				return View.CurrentObject as NavigationObject;
			}
		}
		private void RefreshNavigationActionContainer() {
			PropertyEditor editor = (PropertyEditor)((DetailView)View).FindItem("Action");
            if(editor.Control != null) {
                editor.Refresh();
            } else {
                editor.ControlCreated -= new EventHandler<EventArgs>(editor_ControlCreated);
                editor.ControlCreated += new EventHandler<EventArgs>(editor_ControlCreated);
            }
		}
        private void editor_ControlCreated(object sender, EventArgs e) {
            ((PropertyEditor)sender).Refresh();
        }
		private void View_ControlsCreated(object sender, EventArgs e) {
			RefreshNavigationActionContainer();
		}
		private void SubscribeToEvents() {
			View.ObjectSpace.ObjectChanged += new EventHandler<ObjectChangedEventArgs>(ObjectSpace_ObjectChanged);
			View.ControlsCreated += new EventHandler(View_ControlsCreated);
		}
		private void UnsubscribeFromEvents() {
			View.ObjectSpace.ObjectChanged -= new EventHandler<ObjectChangedEventArgs>(ObjectSpace_ObjectChanged);
			View.ControlsCreated -= new EventHandler(View_ControlsCreated);
            PropertyEditor editor = (PropertyEditor)View.FindItem("Action");
            if(editor != null) {
                editor.ControlCreated -= new EventHandler<EventArgs>(editor_ControlCreated);
            }
		}
		private void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e) {
			if(!string.IsNullOrEmpty(e.PropertyName) && e.PropertyName != "Log") {
				CurrentObject.BuildAction();
				RefreshNavigationActionContainer();
			}
		}
		protected override void OnActivated() {
			base.OnActivated();
			SubscribeToEvents();
			RefreshNavigationActionContainer();
		}
		protected override void OnDeactivated() {
			ObjectSpace.CommitChanges();
			UnsubscribeFromEvents();
			base.OnDeactivated();
		}
		public NavigationObjectDetailViewController() {
			TargetObjectType = typeof(NavigationObject);
		}
    }
}
