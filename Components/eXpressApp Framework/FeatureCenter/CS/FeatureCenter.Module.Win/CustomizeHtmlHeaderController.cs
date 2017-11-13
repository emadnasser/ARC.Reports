using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.HtmlPropertyEditor.Win;

namespace FeatureCenter.Module.Win {
	public class CustomizeHtmlHeaderController : ViewController {
		public CustomizeHtmlHeaderController() {
			TargetViewType = ViewType.DetailView;
		}
		protected override void OnActivated() {
			base.OnActivated();
			DetailView detailView = (DetailView)View;
			foreach(HtmlPropertyEditor editor in detailView.GetItems<HtmlPropertyEditor>()) {
				editor.CustomizeHtmlHeader += new EventHandler<CustomizeHtmlHeaderEventArgs>(editor_CustomizeHtmlHeader);
			}
		}
		private void editor_CustomizeHtmlHeader(object sender, CustomizeHtmlHeaderEventArgs e) {
			e.HeaderInnerHtml = @"
				<style>
					h1 { color: #8080a0; font-weight: normal; padding: 0px; margin: 5px 0px; }
					p { padding: 0px; margin: 3px 0px; color: #808080; }
				</style>
			";
		}
		protected override void OnDeactivated() {
			DetailView detailView = (DetailView)View;
			foreach(HtmlPropertyEditor editor in detailView.GetItems<HtmlPropertyEditor>()) {
				editor.CustomizeHtmlHeader -= new EventHandler<CustomizeHtmlHeaderEventArgs>(editor_CustomizeHtmlHeader);
			}
			base.OnDeactivated();
		}
	}
}
