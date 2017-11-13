using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using FeatureCenter.Module.Navigation;
using DevExpress.ExpressApp;
using System.Web.UI.WebControls;
using DevExpress.ExpressApp.Web.TestScripts;
using DevExpress.ExpressApp.Web.Editors;
using FeatureCenter.Module.PropertyEditors;
using DevExpress.ExpressApp.Model;
using System.Web.UI;

namespace FeatureCenter.Module.Web.Navigation {
	[PropertyEditor(typeof(SingleChoiceAction), FeatureCenterEditorAliases.NavigationContainerEditor)]
    public class NavigationActionContainerPropertyEditor : PropertyEditor, ITestableEx, ISupportAdditionalParametersTestControl {
		private NavigationActionContainer NavigationActionContainer {
			get { return (NavigationActionContainer)Control; }
		}
		private NavigationObject NavigationObject {
			get {
				return (NavigationObject)CurrentObject;
			}
		}
		protected override object GetControlValueCore() {
			return null;
		}
        public NavigationActionContainerPropertyEditor(Type objectType, IModelMemberViewItem info) : base(objectType, info) { }
		protected override object CreateControlCore() {
			NavigationActionContainer navigationActionContainer = new NavigationActionContainer();
            navigationActionContainer.DisableDelayedCreation();
            navigationActionContainer.RecoverViewStateOnNavigationCallback = true;
			navigationActionContainer.ContainerId = "TestNavigation";
            navigationActionContainer.Unload += new EventHandler(navigationActionContainer_Unload);
            navigationActionContainer.Load += new EventHandler(navigationActionContainer_Load);
			return navigationActionContainer;
		}

        void navigationActionContainer_Load(object sender, EventArgs e) {
            NavigationActionContainer nc = (NavigationActionContainer)sender;
            if(nc.NavigationControl != null) {
                nc.NavigationControl.FindControl(""); //Force initialize templated items (TreeView in NavBar)
            }
        }

        private void navigationActionContainer_Unload(object sender, EventArgs e) {
            ((NavigationActionContainer)sender).Load -= new EventHandler(navigationActionContainer_Load);
            OnControlInitialized(sender as Control);
        }
        protected void OnControlInitialized(Control control) {
            if(ControlInitialized != null) {
                ControlInitialized(this, new ControlInitializedEventArgs(control));
            }
        }
		protected override void ReadValueCore() {
			NavigationActionContainer.Register((SingleChoiceAction)PropertyValue, NavigationObject.NavigationStyle);
		}
        protected override void Dispose(bool disposing) {
            Control control = Control as Control;
            if(control != null) {
                control.Unload -= navigationActionContainer_Unload;
            }
            base.Dispose(disposing);
        }

		#region ITestable Members
		string ITestable.ClientId { get { return ((ITestable)NavigationActionContainer).ClientId; } }
		string ITestable.TestCaption { get { return this.Caption; } }
		IJScriptTestControl ITestable.TestControl { get { return ((ITestable)NavigationActionContainer).TestControl; } }
        public event EventHandler<ControlInitializedEventArgs> ControlInitialized;
        TestControlType ITestable.TestControlType { get { return TestControlType.Field; } }
        #endregion

        #region ITestableEx Members
        public Type RegisterControlType {
            get { return NavigationActionContainer.GetType(); }
        }
        #endregion
        #region ISupportAdditionalParametersTestControl Members
        public ICollection<string> GetAdditionalParameters(object control) {
            ISupportAdditionalParametersTestControl testControl = this.NavigationActionContainer as ISupportAdditionalParametersTestControl;
            if (testControl != null) {
                return testControl.GetAdditionalParameters(testControl);
            }
            return new string[0];
        }
        #endregion
    }
}
