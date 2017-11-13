using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
	[DefaultProperty("Caption")]
	[MetadataType(typeof(ResourceMetadata))]
	public partial class Resource : IResource, IXafEntityObject {
        [VisibleInListView(false), VisibleInDetailView(false), VisibleInLookupListView(false)]
		public Object Id {
			get { return Key; }
		}
		[VisibleInListView(false), VisibleInDetailView(false), VisibleInLookupListView(false)]
		public Int32 OleColor {
			get {
				return ColorTranslator.ToOle(Color.FromArgb(Color_Int));
			}
		}
		public Color Color {
			get { return Color.FromArgb(Color_Int); }
			set { Color_Int = value.ToArgb(); }
		}

		// IXafEntityObject
		void IXafEntityObject.OnCreated() {
		}
		void IXafEntityObject.OnSaving() {
		}
		void IXafEntityObject.OnLoaded() {
			Events.Load();
		}
	}

	public class ResourceMetadata {
		[Browsable(false)]
		public Int32 Key { get; set; }
	}
}
