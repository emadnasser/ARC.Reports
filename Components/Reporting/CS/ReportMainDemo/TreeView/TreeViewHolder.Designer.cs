namespace XtraReportsDemos.TreeView {
    partial class TreeViewHolder {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ImageList imageList1;        

        public DevExpress.XtraTreeList.TreeList TreeView { 
            get {return this.treeView1;}
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new DevExpress.XtraTreeList.TreeList();                                  
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // treeView1
            // 
            this.treeView1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            new DevExpress.XtraTreeList.Columns.TreeListColumn()});
            this.treeView1.Columns[0].Visible = true;
            this.treeView1.Columns[0].VisibleIndex = 0;
            this.treeView1.Columns[0].OptionsColumn.AllowFocus = true;
            this.treeView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeView1.Appearance.Row.Options.UseFont = true;
            this.treeView1.AppearancePrint.Row.BackColor = System.Drawing.Color.Transparent;
            this.treeView1.AppearancePrint.Row.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.treeView1.AppearancePrint.Row.Options.UseFont = true;
            this.treeView1.CausesValidation = false;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.OptionsBehavior.Editable = false;
            this.treeView1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.None;
            this.treeView1.OptionsPrint.PrintAllNodes = true;
            this.treeView1.OptionsPrint.PrintPageHeader = false;
            this.treeView1.OptionsPrint.PrintTreeButtons = false;
            this.treeView1.OptionsPrint.PrintHorzLines = false;
            this.treeView1.OptionsPrint.PrintVertLines = false;
            this.treeView1.OptionsPrint.PrintImages = true;
            this.treeView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeView1.OptionsSelection.MultiSelect = false;
            this.treeView1.OptionsView.AutoWidth = true;
            this.treeView1.OptionsView.ShowColumns = false;
            this.treeView1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeView1.OptionsView.ShowHorzLines = false;
            this.treeView1.OptionsView.ShowIndicator = false;
            this.treeView1.OptionsView.ShowVertLines = false;
            this.treeView1.OptionsView.ShowButtons = true;
            this.treeView1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
            this.treeView1.Size = new System.Drawing.Size(440, 121);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 0;
            // 
            // hierarchyTableAdapter1
            // 
            // 
            // TreeViewHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "TreeViewHolder";
            this.Size = new System.Drawing.Size(440, 121);

            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeView1;

    }
}
