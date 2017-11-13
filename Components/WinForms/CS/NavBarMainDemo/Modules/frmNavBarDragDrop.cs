using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraNavBar.Demos {
    public partial class frmNavBarDragDrop : TutorialControl {
        public frmNavBarDragDrop() {
            InitializeComponent();
            InitOptions();
        }

        Point mDown = new Point(-10000, -10000);
        private NavBarItemLink GetItemLink(IDataObject data) {
            NavBarItemLink ret = data.GetData(typeof(NavBarItemLink)) as NavBarItemLink;
            return ret;
        }

        private ListView.SelectedListViewItemCollection GetListViewItems(IDataObject data) {
            ListView.SelectedListViewItemCollection ret = data.GetData(typeof(ListView.SelectedListViewItemCollection)) as ListView.SelectedListViewItemCollection;
            return ret;
        }

        private void listView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null && link.Item.Enabled)
                listView1.Items.Add(link.Caption, link.Item.SmallImageIndex);
        }

        private void listView1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null && link.Item.Enabled)
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void lbRecycle_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null) {
                e.Effect = DragDropEffects.Move;
                lbRecycle.Appearance.ImageIndex = 1;
            }
        }

        private void lbRecycle_DragLeave(object sender, System.EventArgs e) {
            lbRecycle.Appearance.ImageIndex = 0;
        }

        private void lbRecycle_DragDrop(object sender, System.Windows.Forms.DragEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null) link.Dispose();
            lbRecycle.Appearance.ImageIndex = 0;
        }


        private void listView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            listView1.Focus();
            mDown = new Point(e.X, e.Y);
        }

        private void listView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            if((Math.Abs(e.X - mDown.X) > 5 || Math.Abs(e.Y - mDown.Y) > 5)) {
                int selectedItemsCount = listView1.SelectedItems.Count;
                if(selectedItemsCount < 0 || e.Button != MouseButtons.Left) return;
                listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Copy);
            }
        }

        private void navBarControl1_NavDragOver(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null) return;
            ListView.SelectedListViewItemCollection links = GetListViewItems(e.Data);
            if(links != null) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private NavBarItem GetNavBarItemByCaption(string s) {
            foreach(NavBarItem item in navBarControl1.Items)
                if(item.Caption == s) return item;
            return null;
        }

        private void navBarControl1_NavDragDrop(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventArgs e) {
            NavBarItemLink link = GetItemLink(e.Data);
            if(link != null) return;
            ListView.SelectedListViewItemCollection links = GetListViewItems(e.Data);
            if(links != null) {
                if(e.InsertPosition != -1) {
                    for(int i = links.Count - 1; i >= 0; i--)
                        e.Group.ItemLinks.Insert(e.InsertPosition, GetNavBarItemByCaption(links[i].Text));
                }
                else {
                    for(int i = 0; i < links.Count; i++)
                        e.Group.ItemLinks.Add(GetNavBarItemByCaption(links[i].Text));
                }
            }
        }

        private void SetDragDropFlags(NavBarDragDrop flag, bool IsChecked) {
            if(IsChecked) navBarControl1.DragDropFlags |= flag;
            else navBarControl1.DragDropFlags &= ~flag;
        }

        private void InitOptions() {
            ceAllowDrag.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowDrag) != 0;
            ceAllowDrop.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowDrop) != 0;
            ceAllowOuterDrop.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowOuterDrop) != 0;
        }

        private void ceAllowDrag_CheckedChanged(object sender, System.EventArgs e) {
            SetDragDropFlags(NavBarDragDrop.AllowDrag, ceAllowDrag.Checked);
        }

        private void ceAllowDrop_CheckedChanged(object sender, System.EventArgs e) {
            SetDragDropFlags(NavBarDragDrop.AllowDrop, ceAllowDrop.Checked);
        }

        private void ceAllowOuterDrop_CheckedChanged(object sender, System.EventArgs e) {
            SetDragDropFlags(NavBarDragDrop.AllowOuterDrop, ceAllowOuterDrop.Checked);
        }
    }
}
