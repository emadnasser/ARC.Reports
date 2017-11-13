using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Registrator;

namespace DevExpress.CustomEditors {
    [UserRepositoryItem("RegisterMyColorEdit")]
    public class RepositoryItemMyColorEdit : RepositoryItemImageComboBox {
        private bool _useSystemColors;
        static RepositoryItemMyColorEdit() { RegisterMyColorEdit(); }
        public RepositoryItemMyColorEdit() {
            this._useSystemColors = true;
            InitColorItems();
        }
        public static void RegisterMyColorEdit() {
            Image img = (Bitmap)Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.MyColorEdit.bmp"));
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("MyColorEdit", typeof(MyColorEdit), typeof(RepositoryItemMyColorEdit), typeof(DevExpress.XtraEditors.ViewInfo.ImageComboBoxEditViewInfo), new DevExpress.XtraEditors.Drawing.ImageComboBoxEditPainter(), true, img, typeof(DevExpress.Accessibility.PopupEditAccessible)));
        }
        public override string EditorTypeName { get { return "MyColorEdit"; } }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemMyColorEdit source = item as RepositoryItemMyColorEdit;
                if(source == null) return;
                this._useSystemColors = source.UseSystemColors;
            }
            finally {
                EndUpdate();
            }
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ImageComboBoxItemCollection Items { get { return base.Items; } }
        [DefaultValue(true)]
        public bool UseSystemColors {
            get { return _useSystemColors; }
            set {
                if(_useSystemColors != value) {
                    _useSystemColors = value;
                    InitColorItems();
                    OnPropertiesChanged();
                }
            }
        }
        private string SysColor = "System Color";
        protected void InitColorItems() {
            Array colors = Enum.GetValues(typeof(KnownColor));
            int imageCount = 0;

            int side = 16;
            int offset = 2;
            ImageList il = new ImageList();
            il.ImageSize = new Size(side, side);

            Rectangle r = new Rectangle(offset, offset, side - offset * 2, side - offset * 2);

            BeginUpdate();
            try {
                Items.Clear();
                SmallImages = il;

                for(int i = 0; i < colors.Length; i++) {

                    Color c = Color.FromKnownColor((KnownColor)colors.GetValue(i));
                    String s = colors.GetValue(i).ToString() + (c.IsSystemColor ? " (System)" : "");

                    if(!(c.IsSystemColor && !UseSystemColors)) {
                        Bitmap im = new Bitmap(side, side);
                        Graphics g = Graphics.FromImage(im);
                        g.FillRectangle(new SolidBrush(c), r);
                        g.DrawRectangle(Pens.Black, r);
                        il.Images.Add(im);
                        g.Dispose();
                        Items.Add(new ImageComboBoxItem(s, c, imageCount++));
                    }
                    else {
                        if(i == 0) {
                            Bitmap im = new Bitmap(side, side);
                            Graphics g = Graphics.FromImage(im);
                            g.FillRectangle(new SolidBrush(SystemColors.Control), r);
                            g.DrawString("S", new Font("Tahoma", 8, FontStyle.Bold), new SolidBrush(Color.Black), r);
                            g.DrawRectangle(Pens.Black, r);
                            il.Images.Add(im);
                            s = SysColor;
                            g.Dispose();
                            Items.Add(new ImageComboBoxItem(s, SystemColors.Control, imageCount++));
                        }
                    }
                }
            }
            finally {
                CancelUpdate();
            }
        }
    }
    [ToolboxBitmap(typeof(MyColorEdit), "MyColorEdit.bmp")]
    public class MyColorEdit : DevExpress.XtraEditors.ImageComboBoxEdit {
        static MyColorEdit() {
            RepositoryItemMyColorEdit.RegisterMyColorEdit();
        }
        public MyColorEdit() {
            ctrl = null;
        }
        public override string EditorTypeName { get { return "MyColorEdit"; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyColorEdit Properties {
            get { return base.Properties as RepositoryItemMyColorEdit; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color MyColor {
            get {
                if(EditValue is Color) return (Color)EditValue;
                return Color.Empty;
            }
            set {
                EditValue = value;
            }
        }
        private Control ctrl;
        [DefaultValue(null)]
        public Control Control {
            get { return ctrl; }
            set {
                ctrl = value;
                if(ctrl != null) {
                    ctrl.BackColorChanged += new EventHandler(OnCtrlColorChanged);
                    MyColor = ctrl.BackColor;
                }
            }
        }
        void OnCtrlColorChanged(object sender, EventArgs e) {
            if(ctrl != null) MyColor = ctrl.BackColor;
        }
        protected override void OnEditValueChanged() {
            base.OnEditValueChanged();
            if(ctrl != null) {
                try {
                    ctrl.BackColor = MyColor;
                }
                catch { };
            }
        }
    }
}
