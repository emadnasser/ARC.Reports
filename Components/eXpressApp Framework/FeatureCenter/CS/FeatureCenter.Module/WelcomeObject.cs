using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using System.Drawing;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Editors;

namespace FeatureCenter.Module {
	[NonPersistent, System.ComponentModel.DisplayName(Captions.Welcome)]
	[AutoCreatableObject(ViewEditMode = ViewEditMode.View)]
	[ImageName("Demo_Welcome")]
	public class WelcomeObject {
        private static WelcomeObject instance;
        protected WelcomeObject() : base() {}
        public static WelcomeObject Instance {
            get
            {
                if(instance == null) {
                    instance = new WelcomeObject();
                }
                return instance;
            }
        }
	}

	public class WelcomeDisableObjectSpaceActionsController : ViewController<DetailView> {
        private const string InactiveForWelcomeObject = "Inactive for WelcomeObject";
		public WelcomeDisableObjectSpaceActionsController() { }
		protected override void OnActivated() {
			base.OnActivated();
			Frame.GetController<RefreshController>().Active[InactiveForWelcomeObject] = (View.ObjectTypeInfo.Type != typeof(WelcomeObject));
			Frame.GetController<RecordsNavigationController>().Active[InactiveForWelcomeObject] = (View.ObjectTypeInfo.Type != typeof(WelcomeObject));
			Frame.GetController<ModificationsController>().Active[InactiveForWelcomeObject] = (View.ObjectTypeInfo.Type != typeof(WelcomeObject));
		}
		protected override void OnDeactivated() {
            Frame.GetController<RefreshController>().Active.RemoveItem(InactiveForWelcomeObject);
            Frame.GetController<RecordsNavigationController>().Active.RemoveItem(InactiveForWelcomeObject);
			Frame.GetController<ModificationsController>().Active.RemoveItem(InactiveForWelcomeObject);
			base.OnDeactivated();
        }
	}

}
