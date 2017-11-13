using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Actions;
using FeatureCenter.Module.Navigation;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.ExpressApp;
using FeatureCenter.Module.PropertyEditors;
using DevExpress.ExpressApp.Model;

namespace FeatureCenter.Module.Win.Navigation {
	[PropertyEditor(typeof(SingleChoiceAction), FeatureCenterEditorAliases.NavigationContainerEditor)]
	public class NavigationActionContainerPropertyEditor : PropertyEditor {
		private NavigationActionContainer NavigationActionContainer {
			get { return (NavigationActionContainer)Control; }
		}
		private NavigationObject NavigationObject {
			get {
				return (NavigationObject)CurrentObject;
			}
		}
		protected override object CreateControlCore() {
			return new NavigationActionContainer();
		}
		protected override void ReadValueCore() {
			NavigationActionContainer.Register((SingleChoiceAction)PropertyValue, NavigationObject.NavigationStyle);
		}
		protected override object GetControlValueCore() {
			return null;
		}
        public NavigationActionContainerPropertyEditor(Type objectType, IModelMemberViewItem info) : base(objectType, info) { }
	}
}
