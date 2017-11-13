using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraLayout.Dragging;
using DevExpress.Utils.Controls;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Demos.Modules;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos {
    /// <summary>
    /// Summary description for Employees.
    /// </summary>
    public partial class LayoutControlDragDrop : TutorialControl, IDragManager {
        private ImageList imageList3;
        private IContainer components;
        private ImageList imageList1;
        private ImageList imageList2;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl dragDropLayoutControl1;
        private LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl dragDropLayoutControl2;
        private LayoutControlItem layoutControlItem4;
        private Label label1;
        private LayoutControlItem layoutControlItem2;
        private ListView listView1;

        public LayoutControlDragDrop() {
            InitializeComponent();

        }
        //common
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutControlDragDrop));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Project"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Deliverable"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Task"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dragDropLayoutControl2 = new DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl();
            this.dragDropLayoutControl1 = new DevExpress.XtraLayout.Demos.Modules.DragDropLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem6.Checked = true;
            listViewItem6.StateImageIndex = 2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(280, 32);
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listView1_GiveFeedback);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dragDropLayoutControl2);
            this.layoutControl1.Controls.Add(this.dragDropLayoutControl1);
            this.layoutControl1.Controls.Add(this.listView1);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(582, 450);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dragDropLayoutControl2
            // 
            this.dragDropLayoutControl2.Location = new System.Drawing.Point(296, 48);
            this.dragDropLayoutControl2.Name = "dragDropLayoutControl2";
            this.dragDropLayoutControl2.Size = new System.Drawing.Size(280, 380);
            this.dragDropLayoutControl2.TabIndex = 5;
            // 
            // dragDropLayoutControl1
            // 
            this.dragDropLayoutControl1.Location = new System.Drawing.Point(6, 48);
            this.dragDropLayoutControl1.Name = "dragDropLayoutControl1";
            this.dragDropLayoutControl1.Size = new System.Drawing.Size(280, 380);
            this.dragDropLayoutControl1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(582, 450);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AllowHotTrack = false;
            this.layoutControlItem1.Control = this.listView1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(31, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(290, 42);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AllowHotTrack = false;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem3.Control = this.dragDropLayoutControl1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(290, 406);
            this.layoutControlItem3.Text = "LayoutControl 1";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AllowHotTrack = false;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem4.Control = this.dragDropLayoutControl2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(290, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(290, 406);
            this.layoutControlItem4.Text = "LayoutControl 2";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AllowHotTrack = false;
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(290, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(290, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.TrimClientAreaToControl = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList3;
            this.label1.Location = new System.Drawing.Point(296, 6);
            this.label1.MaximumSize = new System.Drawing.Size(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 3;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            this.label1.DragLeave += new System.EventHandler(this.label1_DragLeave);
            // 
            // LayoutControlDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "LayoutControlDragDrop";
            this.Size = new System.Drawing.Size(582, 450);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }
        BaseLayoutItem dragItem = null;
        BaseLayoutItem IDragManager.DragItem { get { return dragItem; } set { dragItem = value; } }
        void IDragManager.SetDragCursor(DragDropEffects e) { SetDragCursor(e); }
        private void SetDefaultCursor() {
            Cursor = Cursors.Default;
        }
        private void SetDragCursor(DragDropEffects e) {
            if(e == DragDropEffects.Move)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraLayout.Demos.Images.move.ico"));
            if(e == DragDropEffects.Copy)
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraLayout.Demos.Images.copy.ico"));
            if(e == DragDropEffects.None)
                Cursor = Cursors.No;
        }
        private LayoutControlItem GetDragNode(IDataObject data) {
            return data.GetData(typeof(LayoutControlItem)) as LayoutControlItem;
        }
        //ListView1
        private ListViewItem newItem = null;
        private void listView1_MouseDown(object sender, MouseEventArgs e) {
            newItem = listView1.GetItemAt(e.X, e.Y);
        }
        private void listView1_MouseMove(object sender, MouseEventArgs e) {
            if(newItem == null || e.Button != MouseButtons.Left) return;
            LayoutControlItem lci = new LayoutControlItem();
            lci.Name = Guid.NewGuid().ToString();
            lci.Control = new TextEdit();
            lci.Control.Name = Guid.NewGuid().ToString();
            lci.Text = newItem.Text;
            dragItem = lci;
            listView1.DoDragDrop(dragItem, DragDropEffects.Copy);
        }
        private void listView1_GiveFeedback(object sender, GiveFeedbackEventArgs e) {
            e.UseDefaultCursors = false;
        }
        protected override void OnBackColorChanged(EventArgs e) {
            base.OnBackColorChanged(e);
            if(listView1 == null) return;
            listView1.BackColor = BackColor;
            foreach(ListViewItem item in listView1.Items) {
                item.BackColor = BackColor;
                item.ForeColor = ForeColor;
            }
        }
        //Label1
        private void label1_DragDrop(object sender, DragEventArgs e) {
            if(CanRecycleDragItem()) {
                Control control = null;
                if(dragItem is LayoutControlItem) {
                    LayoutControlItem lci = dragItem as LayoutControlItem;
                    control = lci.Control;
                }
                dragItem.Parent.Remove(dragItem);
                if(control != null) {
                    control.Parent = null;
                    control.Dispose();
                }
                dragItem = null;
            }
            SetDefaultLabel();
        }
        private void label1_DragEnter(object sender, DragEventArgs e) {
            if(CanRecycleDragItem()) {
                label1.ImageIndex = 1;
                e.Effect = DragDropEffects.Copy;
                Cursor = new Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.XtraLayout.Demos.Images.delete.ico"));
            }
        }
        private void label1_DragLeave(object sender, EventArgs e) {
            SetDefaultLabel();
        }
        private void SetDefaultLabel() {
            label1.ImageIndex = 0;
            SetDefaultCursor();
        }
        protected bool CanRecycleDragItem() {
            if(dragItem == null && dragItem is LayoutControlItem) return false;
            if(dragItem.Owner == null) return false;
            return true;
        }
    }
}
