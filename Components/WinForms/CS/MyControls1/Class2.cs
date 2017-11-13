using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
 
namespace DevExpress.CustomEditors {
	[UserRepositoryItem("RegisterMyFontEdit")]
	public class RepositoryItemMyFontEdit : RepositoryItemImageComboBox {
		static RepositoryItemMyFontEdit() { RegisterMyFontEdit(); }
		public RepositoryItemMyFontEdit() {
			InitFontItems();
		}
		public static void RegisterMyFontEdit() {
			Image img = (Bitmap)Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyFontEdit.bmp"));
			EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyFontEdit", typeof(MyFontEdit), typeof(RepositoryItemMyFontEdit), typeof(DevExpress.XtraEditors.ViewInfo.ImageComboBoxEditViewInfo), new DevExpress.XtraEditors.Drawing.ImageComboBoxEditPainter(), true, img, typeof(DevExpress.Accessibility.PopupEditAccessible)));
		}
		public override string EditorTypeName { get { return "MyFontEdit"; } }	
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override ImageComboBoxItemCollection Items { get { return base.Items; } }

		private void AddDefaultButton(EditorButton btn, Keys keys) {
			btn.IsLeft = true;
			btn.Shortcut = new DevExpress.Utils.KeyShortcut(keys);
			btn.IsDefaultButton = true;
			Buttons.Add(btn);
		}
		public override void CreateDefaultButton() {
			base.CreateDefaultButton();
			AddDefaultButton(new EditorButton(ButtonPredefines.SpinRight), Keys.Add);
			AddDefaultButton(new EditorButton(ButtonPredefines.SpinLeft), Keys.Subtract);
		}
		
		protected void InitFontItems() {
			int width = 20;
			int height = 16;
			int offset = 1;
						
			ImageList il = new ImageList();
			il.ImageSize = new Size(width, height);

			Rectangle r = new Rectangle(offset, offset, width - offset * 2, height - offset * 2);

			BeginUpdate();
			try {
				Items.Clear();
				SmallImages = il;
						
				int j = 0;
				for (int i = 0; i < FontFamily.Families.Length; i++)  {
				
					try {
						Font f = new Font(FontFamily.Families[i].Name, 8);
						string s = FontFamily.Families[i].Name + ", " + f.Size.ToString(); 
						Bitmap im = new Bitmap(width, height);
						Graphics g = Graphics.FromImage(im);
						g.FillRectangle(Brushes.White, r);
						g.DrawString("abc", f, Brushes.Black, offset, offset);
						g.DrawRectangle(Pens.Black, r);
						il.Images.Add(im);
                        g.Dispose();			
						Items.Add(new ImageComboBoxItem(s, f, j++));
					} catch {}
				}
			} finally { CancelUpdate(); }
		}
	}
	[ToolboxBitmap(typeof(MyFontEdit), "MyFontEdit.bmp")]
	public class MyFontEdit : DevExpress.XtraEditors.ImageComboBoxEdit {
		static MyFontEdit() {
			RepositoryItemMyFontEdit.RegisterMyFontEdit();
		}
		public MyFontEdit() {
			ctrl = null;
		}
		public override string EditorTypeName { get { return "MyFontEdit"; } }	
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMyFontEdit Properties { 
			get { return base.Properties as RepositoryItemMyFontEdit; } 
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Font MyFont {
			get { 
				if(EditValue is Font) return (Font)EditValue; 
				return null;
			}
			set {
				if(value != null) {
					foreach(ImageComboBoxItem item in Properties.Items) 
						if(((Font)item.Value).Name == value.Name) 
							SetItem(item, value);
				}
				EditValue = value;
			}
		}
		private void SetItem(ImageComboBoxItem item, Font fnt) {
			Properties.BeginUpdate();
			item.Value = fnt;
			item.Description = fnt.Name + ", " + fnt.Size.ToString();
			Properties.EndUpdate();
			if(InplaceType != InplaceType.Standalone) {
				RepositoryItemMyFontEdit fe = Tag as RepositoryItemMyFontEdit;
				if(fe == null) return;
				fe.BeginUpdate();
				try {
					fe.Items.Assign(Properties.Items);
				}
				finally {
					fe.CancelUpdate();
				}
			}
		}
		private Control ctrl;
		[DefaultValue(null)]
		public Control Control {
			get { return ctrl; }
			set { ctrl = value; 
				if(ctrl != null) {
					ctrl.FontChanged += new EventHandler(OnCtrlFontChanged);
					MyFont = ctrl.Font;
				}
			}
		}
		void OnCtrlFontChanged(object sender, EventArgs e) {
			if(ctrl != null) MyFont = ctrl.Font;
		}
		protected override void OnEditValueChanged() {
			base.OnEditValueChanged();
			if(ctrl != null) {
                try { 
                    ctrl.Font = MyFont; 
                } catch {}
            }
		}

		protected override void OnClickButton(EditorButtonObjectInfoArgs buttonInfo) {
			base.OnClickButton(buttonInfo);
			if(SelectedIndex == -1) return;
			ImageComboBoxItem myItem = Properties.Items[SelectedIndex];
			Font fnt = myItem.Value as Font;
			Font newFont = null;
			if(buttonInfo.Button.Kind == ButtonPredefines.SpinLeft && fnt.Size > 5) 
				newFont = new Font(fnt.FontFamily, fnt.Size - 1);
			
			if(buttonInfo.Button.Kind == ButtonPredefines.SpinRight && fnt.Size < 50) 
				newFont = new Font(fnt.FontFamily, fnt.Size + 1);
			
			if(newFont != null) {
				SetItem(myItem, newFont);	
				EditValue = newFont;		
				OnEditValueChanged();
			}
		}
	}
}
