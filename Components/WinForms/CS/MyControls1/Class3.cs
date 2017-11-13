using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Registrator;

namespace DevExpress.CustomEditors {
	[UserRepositoryItem("RegisterMyRadioGroup")]
	public class RepositoryItemMyRadioGroup : RepositoryItemRadioGroup {
		static RepositoryItemMyRadioGroup() { RegisterMyRadioGroup(); }
		public RepositoryItemMyRadioGroup() {}
		public static void RegisterMyRadioGroup() {
			Image img = (Bitmap)Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyRadioGroup.bmp"));
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyRadioGroup", typeof(MyRadioGroup), typeof(RepositoryItemMyRadioGroup), typeof(DevExpress.XtraEditors.ViewInfo.RadioGroupViewInfo), new DevExpress.XtraEditors.Drawing.RadioGroupPainter(), true, img, typeof(DevExpress.Accessibility.PopupEditAccessible)));
		}
		public override string EditorTypeName { get { return "MyRadioGroup"; } }
		//-------------------------
		protected override RadioGroupItemCollection CreateItemCollection() {
			return new MyRadioGroupItemCollection();
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new MyRadioGroupItemCollection Items { get { return base.Items as MyRadioGroupItemCollection; } }
		//-------------------------
	}
	[ToolboxBitmap(typeof(MyRadioGroup), "MyRadioGroup.bmp")]
	public class MyRadioGroup : DevExpress.XtraEditors.RadioGroup {
		static MyRadioGroup() {
			RepositoryItemMyRadioGroup.RegisterMyRadioGroup();
		}
		public MyRadioGroup() {}
		public override string EditorTypeName { get { return "MyRadioGroup"; } }	
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMyRadioGroup Properties { 
			get { return base.Properties as RepositoryItemMyRadioGroup; } 
		}
	}

	[TypeConverter(typeof(DevExpress.Utils.Design.UniversalTypeConverter))]
	public class MyRadioGroupItem : RadioGroupItem { 
		bool myBoolProperty;
		public MyRadioGroupItem(object value, string description, bool myBoolProperty) : base(value, description) {
			this.myBoolProperty = myBoolProperty;
		}
		public MyRadioGroupItem() {
			myBoolProperty = true;
		}
		[DefaultValue(true)]
		public bool MyBoolProperty {
			get { return myBoolProperty; }
			set { 
				myBoolProperty = value; 
				ItemChanged();
			}
		}
		public override object Clone() { 
			return new MyRadioGroupItem(Value, Description, MyBoolProperty); 
		}
	}
	public class MyRadioGroupItemCollection : DevExpress.XtraEditors.Controls.RadioGroupItemCollection {
		public new MyRadioGroupItem this[int index] {
			get { return base[index] as MyRadioGroupItem; }
			set { base[index] = value; }
		}
	}
}
