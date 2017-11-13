namespace DevExpress.XtraTreeList.Demos {
    partial class MultiDragAndDrop {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiDragAndDrop));
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.ceAcceptOuterNodes = new DevExpress.XtraEditors.CheckEdit();
            this.ceMultipleNodesDragAndDrop = new DevExpress.XtraEditors.CheckEdit();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tl1ClassView = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.tl2ClassView = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAcceptOuterNodes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultipleNodesDragAndDrop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl1ClassView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl2ClassView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ceAcceptOuterNodes);
            this.panel.Controls.Add(this.ceMultipleNodesDragAndDrop);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(8);
            this.panel.Size = new System.Drawing.Size(784, 48);
            this.panel.TabIndex = 1;
            // 
            // ceAcceptOuterNodes
            // 
            this.ceAcceptOuterNodes.EditValue = true;
            this.ceAcceptOuterNodes.Location = new System.Drawing.Point(202, 13);
            this.ceAcceptOuterNodes.Name = "ceAcceptOuterNodes";
            this.ceAcceptOuterNodes.Properties.AutoWidth = true;
            this.ceAcceptOuterNodes.Properties.Caption = "Drag and drop between treelist controls";
            this.ceAcceptOuterNodes.Size = new System.Drawing.Size(213, 19);
            this.ceAcceptOuterNodes.TabIndex = 21;
            this.ceAcceptOuterNodes.CheckedChanged += new System.EventHandler(this.ceAcceptOuterNodesChanged);
            // 
            // ceMultipleNodesDragAndDrop
            // 
            this.ceMultipleNodesDragAndDrop.EditValue = true;
            this.ceMultipleNodesDragAndDrop.Location = new System.Drawing.Point(23, 13);
            this.ceMultipleNodesDragAndDrop.Name = "ceMultipleNodesDragAndDrop";
            this.ceMultipleNodesDragAndDrop.Properties.AutoWidth = true;
            this.ceMultipleNodesDragAndDrop.Properties.Caption = "Multiple nodes drag and drop";
            this.ceMultipleNodesDragAndDrop.Size = new System.Drawing.Size(161, 19);
            this.ceMultipleNodesDragAndDrop.TabIndex = 20;
            this.ceMultipleNodesDragAndDrop.CheckedChanged += new System.EventHandler(this.ceMultipleNodesDragAndDropChanged);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "CSharp_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "csharp_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "namespace.png");
            this.imageCollection.Images.SetKeyName(3, "class.png");
            this.imageCollection.Images.SetKeyName(4, "interface.png");
            this.imageCollection.Images.SetKeyName(5, "enum.png");
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(8);
            this.panelControl1.Size = new System.Drawing.Size(784, 13);
            this.panelControl1.TabIndex = 22;
            // 
            // tl1ClassView
            // 
            this.tl1ClassView.AllowDrop = true;
            this.tl1ClassView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tl1ClassView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tl1ClassView.Location = new System.Drawing.Point(0, 61);
            this.tl1ClassView.Name = "tl1ClassView";
            this.tl1ClassView.OptionsBehavior.AutoChangeParent = false;
            this.tl1ClassView.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.tl1ClassView.OptionsBehavior.Editable = false;
            this.tl1ClassView.OptionsBehavior.ResizeNodes = false;
            this.tl1ClassView.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.tl1ClassView.OptionsBehavior.SmartMouseHover = false;
            this.tl1ClassView.OptionsDragAndDrop.AcceptOuterNodes = true;
            this.tl1ClassView.OptionsDragAndDrop.CanCloneNodesOnDrop = true;
            this.tl1ClassView.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Multiple;
            this.tl1ClassView.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced;
            this.tl1ClassView.OptionsSelection.MultiSelect = true;
            this.tl1ClassView.OptionsView.EnableAppearanceEvenRow = true;
            this.tl1ClassView.OptionsView.ShowColumns = false;
            this.tl1ClassView.OptionsView.ShowHorzLines = false;
            this.tl1ClassView.OptionsView.ShowIndicator = false;
            this.tl1ClassView.OptionsView.ShowVertLines = false;
            this.tl1ClassView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryImageComboBox1,
            this.repositoryItemDateEdit2});
            this.tl1ClassView.SelectImageList = this.imageCollection;
            this.tl1ClassView.Size = new System.Drawing.Size(415, 371);
            this.tl1ClassView.TabIndex = 24;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 49;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 397;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowFocused = false;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryImageComboBox1
            // 
            this.repositoryImageComboBox1.AllowFocused = false;
            this.repositoryImageComboBox1.AutoHeight = false;
            this.repositoryImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 1, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 2, 1)});
            this.repositoryImageComboBox1.Name = "repositoryImageComboBox1";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(415, 61);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 371);
            this.splitterControl1.TabIndex = 25;
            this.splitterControl1.TabStop = false;
            // 
            // tl2ClassView
            // 
            this.tl2ClassView.AllowDrop = true;
            this.tl2ClassView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.tl2ClassView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl2ClassView.Location = new System.Drawing.Point(420, 61);
            this.tl2ClassView.Name = "tl2ClassView";
            this.tl2ClassView.OptionsBehavior.AutoChangeParent = false;
            this.tl2ClassView.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.tl2ClassView.OptionsBehavior.Editable = false;
            this.tl2ClassView.OptionsBehavior.ResizeNodes = false;
            this.tl2ClassView.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.tl2ClassView.OptionsBehavior.SmartMouseHover = false;
            this.tl2ClassView.OptionsDragAndDrop.AcceptOuterNodes = true;
            this.tl2ClassView.OptionsDragAndDrop.CanCloneNodesOnDrop = true;
            this.tl2ClassView.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Multiple;
            this.tl2ClassView.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced;
            this.tl2ClassView.OptionsSelection.MultiSelect = true;
            this.tl2ClassView.OptionsView.EnableAppearanceEvenRow = true;
            this.tl2ClassView.OptionsView.ShowColumns = false;
            this.tl2ClassView.OptionsView.ShowHorzLines = false;
            this.tl2ClassView.OptionsView.ShowIndicator = false;
            this.tl2ClassView.OptionsView.ShowVertLines = false;
            this.tl2ClassView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit3,
            this.repositoryItemImageComboBox1,
            this.repositoryItemDateEdit4});
            this.tl2ClassView.SelectImageList = this.imageCollection;
            this.tl2ClassView.Size = new System.Drawing.Size(364, 371);
            this.tl2ClassView.TabIndex = 26;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Name";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.MinWidth = 33;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AllowFocused = false;
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AllowFocused = false;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 1, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 2, 1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // MultiDragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tl2ClassView);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.tl1ClassView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel);
            this.Name = "MultiDragAndDrop";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAcceptOuterNodes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultipleNodesDragAndDrop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl1ClassView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl2ClassView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panel;
        private XtraEditors.CheckEdit ceAcceptOuterNodes;
        private XtraEditors.CheckEdit ceMultipleNodesDragAndDrop;
        private Utils.ImageCollection imageCollection;
        private XtraEditors.PanelControl panelControl1;
        private TreeList tl1ClassView;
        private Columns.TreeListColumn treeListColumn1;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboBox1;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private XtraEditors.SplitterControl splitterControl1;
        private TreeList tl2ClassView;
        private Columns.TreeListColumn treeListColumn2;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
    }
}
