using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevExpress.XtraLayout.Demos {
    public partial class TechnoLayout : TutorialControl {
        public TechnoLayout() {
            InitializeComponent();
            ((ILayoutControl)facesUserControl1.layoutControl1).EnableCustomizationMode = true;
            facesUserControl1.layoutControl1.ItemSelectionChanged += layoutControl1_ItemSelectionChanged;
            facesUserControl1.layoutControlItem1.Selected = true;
            if(Skins.DpiProvider.Default.DpiScaleFactor > 1.4)
                this.navigationPage1.ImageUri.Uri = "Properties;Size32x32;Office2013";
        }
       
        object Selected { get; set; }

        private void layoutControl1_ItemSelectionChanged(object sender, EventArgs e) {
            propertyGrid.Rows.Clear();
            if(sender is LayoutControlGroup)
                propertyGrid.SelectedObject = new LayoutGroupCustomWrapper(sender as LayoutControlGroup);
            if(sender is LayoutControlItem)
                propertyGrid.SelectedObject = new LayoutItemCustomWrapper(sender as LayoutControlItem);
            Selected = sender;
        }

        public class LayoutItemCustomWrapper : BasePropertyGridObjectWrapper {
            public LayoutItemCustomWrapper(LayoutControlItem item) {
                SetWrappedObject(item);
            }
            [Category("Name"), DefaultValue(true)]
            public virtual string Name { get { return Item.Name; } }
            [Category("Text"), DefaultValue(true)]
            public virtual bool TextVisible { get { return Item.TextVisible; } set { Item.TextVisible = value; } }
            [Category("Text"), DefaultValue("")]
            public virtual string Text { get { return Item.Text; } set { Item.Text = value; } }
            [Category("Text"), DefaultValue(Locations.Default)]
            public virtual Locations TextLocation { get { return Item.TextLocation; } set { Item.TextLocation = value; } }


            [Category("OptionsFlowLayoutItem"), DefaultValue(false)]
            public virtual bool StartNewLine { get { return Item.StartNewLine; } set { Item.StartNewLine = value; } }

            public virtual Size Size { get { return Item.Size; } set { Item.Size = value; } }
            public virtual Size MaxSize { get { return Item.MaxSize; } set { Item.MaxSize = value; } }
            public virtual Size MinSize { get { return Item.MinSize; } set { Item.MinSize = value; } }
            public virtual DevExpress.XtraLayout.Utils.Padding Spacing { get { return Item.Spacing; } set { Item.Spacing = value; } }

            protected LayoutControlItem Item {
                get { return WrappedObject as LayoutControlItem; }
            }
            public override BasePropertyGridObjectWrapper Clone() {
                return new LayoutItemCustomWrapper(Item);
            }
        }
        public class LayoutGroupCustomWrapper : BasePropertyGridObjectWrapper {
            public LayoutGroupCustomWrapper(LayoutControlGroup group) {
                SetWrappedObject(group);
            }
            [DefaultValue(LayoutMode.Regular), Category("Group")]
            public virtual LayoutMode LayoutMode { get { return Group.LayoutMode; } set { Group.LayoutMode = value; } }
            [Category("OptionsFlowLayoutGroup")]
            public virtual FlowDirection FlowDirection { get { return Group.FlowDirection; } set { Group.FlowDirection = value; } }
            protected LayoutControlGroup Group {
                get { return WrappedObject as LayoutControlGroup; }
            }
            public override BasePropertyGridObjectWrapper Clone() {
                return new LayoutGroupCustomWrapper(Group);
            }
        }

        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            facesUserControl1.layoutControl1.BeginUpdate();
            try {
                foreach(LayoutControlItem item in facesUserControl1.lcgFaces.Items)
                    item.Size = new Size((int)Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor), (int)Math.Round(ztbcSize.Value * Skins.DpiProvider.Default.DpiScaleFactor));
            } 
            finally {
                facesUserControl1.layoutControl1.EndUpdate();
            }
            layoutControl1_ItemSelectionChanged(Selected, null);
        }

        private void zoomTrackBarControl2_EditValueChanged(object sender, EventArgs e) {
            facesUserControl1.layoutControl1.BeginUpdate();
            try {
                foreach(LayoutControlItem item in facesUserControl1.lcgFaces.Items)
                    item.Spacing = new Utils.Padding((int)Math.Round(ztbcSpacing.Value * Skins.DpiProvider.Default.DpiScaleFactor));
            } finally {
                facesUserControl1.layoutControl1.EndUpdate();
            }
            layoutControl1_ItemSelectionChanged(Selected, null);
        }

        private void cheCustomizationMode_CheckedChanged(object sender, EventArgs e) {
            ((ILayoutControl)facesUserControl1.layoutControl1).EnableCustomizationMode = cheCustomizationMode.Checked;
            layoutControlItem5.Visibility = (cheCustomizationMode.Checked) ? LayoutVisibility.Always : LayoutVisibility.Never;
            
        }
    }
}
