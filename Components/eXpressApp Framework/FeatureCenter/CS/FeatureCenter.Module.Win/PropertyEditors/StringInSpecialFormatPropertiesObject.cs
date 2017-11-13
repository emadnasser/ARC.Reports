using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Helpers;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Demos;
using FeatureCenter.Module.PropertyEditors;
using DevExpress.ExpressApp.Editors;

namespace FeatureCenter.Module.Win.PropertyEditors {
	[NavigationItem(Captions.PropertyEditorsGroup), DefaultListViewOptions(true, NewItemRowPosition.Top)]
	[ImageName("PropertyEditors.Demo_String_InSpecialFormat_Properties")]
	[Hint(Hints.WinStringInSpecialFormatPropertiesHint)]
	[System.ComponentModel.DisplayName("String In Special Format Properties")]
	public class WinStringInSpecialFormatProperties : StringInSpecialFormatProperties {
		private XPDelayedProperty rtfStringProperty = new XPDelayedProperty();

		public WinStringInSpecialFormatProperties(Session session) : base(session) { }

		[VisibleInListView(true)]
		[Delayed("rtfStringProperty"), ValueConverter(typeof(StringCompressionConverter)), EditorAlias(EditorAliases.RichTextPropertyEditor)]
		public string RtfStringProperty {
			get { return (string)rtfStringProperty.Value; }
			set { 
				rtfStringProperty.Value = value;
				OnChanged("RtfStringProperty");
			}
		}
	}
}
