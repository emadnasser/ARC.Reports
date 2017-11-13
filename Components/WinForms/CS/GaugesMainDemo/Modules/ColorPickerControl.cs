using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraTab;
using DevExpress.XtraEditors.ColorPick.Picker;

namespace DevExpress.XtraGauges.Demos {
    public partial class ColorPickerControl : XtraUserControl {
        RepositoryItemColorPickEdit item;
        public ColorPickerControl() {
            this.item = new RepositoryItemColorPickEdit();
            InitializeComponent();
            TabStop = false;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitColorPicker();
            IniWebList();
            IniSystemList();
        }
        void InitColorPicker() {
            colorPickControl.Selectable = false;
            colorPickControl.ThemeColors.AddColorRange(item.ThemeColors.ToList());
            colorPickControl.StandardColors.AddColorRange(item.StandardColors.ToList());
        }
        void IniSystemList() {
            systemColorListControl.Selectable = false;
            systemColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.SystemColors);
        }
        void IniWebList() {
            webColorListControl.Selectable = false;
            webColorListControl.Colors.AddColorRange(ColorListBoxViewInfo.WebColors);
        }
        
        void OnSelectedColorChanged(object sender, InnerColorPickControlSelectedColorChangedEventArgs e) {
            if(ResultColorChanged != null) ResultColorChanged(this, e);
        }
        Color color = Color.Empty;
        public void SetColor(Color color) {
            this.color = color;
        }
        void OnMoreColorClick(object sender, EventArgs e) {
            using(FrmColorPicker frm = new FrmColorPicker(item)) {
                frm.StartPosition = FormStartPosition.CenterScreen;
                if(this.color != Color.Empty) frm.SelectedColor = this.color;
                if(frm.ShowDialog(FindForm()) == DialogResult.OK) {
                    colorPickControl.SelectedColor = frm.SelectedColor;
                }
            }
        }
        public event EventHandler<InnerColorPickControlSelectedColorChangedEventArgs> ResultColorChanged;
    }

    [ToolboxItem(false)]
    public class NonFocusableTabControl : XtraTabControl {
        protected override bool AllowTabFocus { get { return false; } }
    }
}
