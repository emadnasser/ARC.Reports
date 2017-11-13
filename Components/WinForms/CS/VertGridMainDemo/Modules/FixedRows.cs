using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Design;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.Utils.Menu;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraVerticalGrid.Demos {
    public partial class FixedRows : TutorialControl {
        public FixedRows() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\VertGridMainDemo\\Modules\\FixedRows.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraVerticalGrid.Demos.CodeInfo.FixedRows.xml";
            this.propertyGridControl1.SelectedObject = this.pictureEdit1;
            this.numFixedLineWidth1.Value = this.propertyGridControl1.OptionsView.FixedLineWidth;

            RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
            pictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

            //<propertyGridControl1>
            this.propertyGridControl1.BeginUpdate();
            MoveRow("Image", FixedStyle.Top);
            MoveRow("Properties.PictureAlignment", FixedStyle.Top);
            MoveRow("Properties.SizeMode", FixedStyle.Top);
            this.propertyGridControl1.RepositoryItems.Add(pictureEdit);
            this.propertyGridControl1.GetRowByFieldName("Image").Properties.RowEdit = pictureEdit;
            this.propertyGridControl1.EndUpdate();
            //</propertyGridControl1>
        }

        bool AllowFixingNestedRows { get { return cheAllowFixingNestedRows.Checked; } }

        //<propertyGridControl1>
        void MoveRow(string fieldName, FixedStyle fixedStyle) {
            this.propertyGridControl1.BeginUpdate();
            BaseRow row = this.propertyGridControl1.GetRowByFieldName(fieldName);
            row.ParentRow.ChildRows.Remove(row);
            propertyGridControl1.Rows.Add(row);
            row.Fixed = fixedStyle;
            this.propertyGridControl1.EndUpdate();
        }
        //</propertyGridControl1>

        public override VGridControlBase ExportControl { get { return this.propertyGridControl1; } }

        //<numFixedLineWidth1>
        void numFixedLineWidth1_EditValueChanged(object sender, EventArgs e) {
            this.propertyGridControl1.OptionsView.FixedLineWidth = Convert.ToInt32(this.numFixedLineWidth1.Value);
        }
        //</numFixedLineWidth1>

        void FixedRows_Load(object sender, EventArgs e) {
            this.propertyGridControl1.RowsCustomization();
        }
        bool EnableFixedStyleMenuItem(BaseRow row, FixedStyle fixedStyle) {
            if(AllowFixingNestedRows) {
                return true;
            } else {
                return row.ParentRow == null || row.Fixed == fixedStyle;
            }
        }
        //<propertyGridControl1>
        void propertyGridControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            e.Menu.Items.Add(AddEnabled(new DXMenuItem("Show Row Customization", Click_ShowRowCustomization, this.menuItemImageList.Images[0]), 
                this.propertyGridControl1.CustomizationForm == null));
            if(e.Row == null)
                return;
            e.Menu.Items.Add(AddTag(AddEnabled(new DXMenuCheckItem("Not Fixed", e.Row.Fixed == FixedStyle.None, this.menuItemImageList.Images[1], Click_NotFixed), 
                EnableFixedStyleMenuItem(e.Row, FixedStyle.None)), e.Row));
            e.Menu.Items.Add(AddTag(AddEnabled(new DXMenuCheckItem("Fixed Top", e.Row.Fixed == FixedStyle.Top, this.menuItemImageList.Images[2], Click_FixedTop), 
                EnableFixedStyleMenuItem(e.Row, FixedStyle.Top)), e.Row));
            e.Menu.Items.Add(AddTag(AddEnabled(new DXMenuCheckItem("Fixed Bottom", e.Row.Fixed == FixedStyle.Bottom, this.menuItemImageList.Images[3], Click_FixedBottom), 
                EnableFixedStyleMenuItem(e.Row, FixedStyle.Bottom)), e.Row));
        }
        DXMenuItem AddTag(DXMenuItem item, object tag) {
            item.Tag = tag;
            return item;
        }
        DXMenuItem AddEnabled(DXMenuItem item, bool enabled) {
            item.Enabled = enabled;
            return item;
        }
        DXMenuItem AddSeparator(DXMenuItem item) {
            item.BeginGroup = true;
            return item;
        }
        void Click_ShowRowCustomization(object sender, EventArgs e) {
            this.propertyGridControl1.RowsCustomization();
        }
        void Click_NotFixed(object sender, EventArgs e) {
            ChangeFixedStyle(GetRow(sender), FixedStyle.None);
        }
        void ChangeFixedStyle(BaseRow row, FixedStyle fixedStyle) {
            if(row.Fixed == fixedStyle)
                return;
            row.Fixed = fixedStyle;
            if(AllowFixingNestedRows) {
                propertyGridControl1.BeginUpdate();
                BaseRow parentRow = row.Tag as BaseRow;
                if(parentRow != null && parentRow.Fixed == fixedStyle) {
                    row.Tag = null;
                    RemoveParent(row);
                    parentRow.ChildRows.Add(row);
                } else {
                    if(row.ParentRow != null) {
                        row.Tag = row.ParentRow;
                    }
                    RemoveParent(row);
                    propertyGridControl1.Rows.Add(row);
                }
                propertyGridControl1.EndUpdate();
            }
        }
        void RemoveParent(BaseRow row) {
            propertyGridControl1.BeginUpdate();
            if(row.ParentRow != null) {
                row.ParentRow.ChildRows.Remove(row);
            } else {
                propertyGridControl1.Rows.Remove(row);
            }
            propertyGridControl1.EndUpdate();
        }
        //BaseRow GetRowByFixedStyle(FixedStyle fixedStyle, int index) {
        //    switch(fixedStyle){
        //        case FixedStyle.Top:
        //            return propertyGridControl1.FixedTopRows[index];
        //        case FixedStyle.Bottom:
        //            return propertyGridControl1.FixedBottomRows[index];
        //        case FixedStyle.None:
        //            return propertyGridControl1.NotFixedRows[index];
        //        default:
        //            return null;
        //    }
        //}
        void Click_FixedTop(object sender, EventArgs e) {
            ChangeFixedStyle(GetRow(sender), FixedStyle.Top);
        }
        void Click_FixedBottom(object sender, EventArgs e) {
            ChangeFixedStyle(GetRow(sender), FixedStyle.Bottom);
        }
        BaseRow GetRow(object dxMenuItem) {
            return ((BaseRow)((DXMenuItem)dxMenuItem).Tag);
        }
        //</propertyGridControl1>
    }
}
