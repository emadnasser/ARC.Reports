using DevExpress.XtraEditors;
namespace DevExpress.XtraTreeList.Demos.Tutorials {
    partial class NodesNavigation {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodesNavigation));
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.button7 = new DevExpress.XtraEditors.SimpleButton();
            this.button6 = new DevExpress.XtraEditors.SimpleButton();
            this.button5 = new DevExpress.XtraEditors.SimpleButton();
            this.button4 = new DevExpress.XtraEditors.SimpleButton();
            this.button3 = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Mark";
            this.treeListColumn5.ColumnEdit = this.repositoryItemCheckEdit1;
            this.treeListColumn5.FieldName = "Mark";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            this.treeListColumn5.Width = 52;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowFocused = false;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AllowFocused = false;
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Category";
            this.treeListColumn2.FieldName = "Category";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 72;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Common Name";
            this.treeListColumn3.FieldName = "Common Name";
            this.treeListColumn3.MinWidth = 65;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            this.treeListColumn3.Width = 166;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Length(cm)";
            this.treeListColumn1.ColumnEdit = this.repositoryItemSpinEdit1;
            this.treeListColumn1.FieldName = "Length(cm)";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 3;
            this.treeListColumn1.Width = 71;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 46);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            15F,
            "Wrasse",
            "Bluehead Wrasse",
            "Thalassoma bifasciatum",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            25F,
            "Wrasse",
            "Senorita",
            "Oxyjulis californica",
            false}, 0, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            229F,
            "Wrasse",
            "Giant Maori Wrasse",
            "Cheilinus undulatus",
            false}, 0, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            19F,
            "Butterflyfish",
            "Ornate Butterflyfish",
            "Chaetodon Ornatissimus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            25F,
            "Smelt",
            "Surf Smelt",
            "Hypomesus pretiosus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            28F,
            "Parrotfish",
            "Redband Parrotfish",
            "Sparisoma Aurofrenatum",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            30F,
            "Angelfish",
            "Blue Angelfish",
            "Pomacanthus nauarchus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            30F,
            "Grunt",
            "French Grunt",
            "Haemulon flavolineatum",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            38F,
            "Scorpionfish",
            "Firefish",
            "Pterois volitans",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            40F,
            "Surfperch",
            "Redtail Surfperch",
            "Amphistichus rhodoterus",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            50F,
            "Triggerfish",
            "Clown Triggerfish",
            "Ballistoides conspicillum",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            55F,
            "Ray",
            "Bat Ray",
            "Myliobatis californica",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            200F,
            "Ray",
            "Spotted Eagle Ray",
            "Aetobatus narinari",
            true}, 11, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            60F,
            "Greenling",
            "Rock Greenling",
            "Hexagrammos lagocephalus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            80F,
            "Cod",
            "Lunartail Rockcod",
            "Variola louti",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            150F,
            "Cod",
            "Lingcod",
            "Ophiodon elongatus",
            true}, 14, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            90F,
            "Spadefish",
            "Atlantic Spadefish",
            "Chaetodiperus faber",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            90F,
            "Snapper",
            "Dog Snapper",
            "Lutjanus jocu",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            75F,
            "Snapper",
            "Yellowtail Snapper",
            "Ocyurus chrysurus",
            false}, 17, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            60F,
            "Snapper",
            "Red Emperor",
            "Lutjanus sebae",
            true}, 17, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            90F,
            "Jack",
            "Yellow Jack",
            "Gnathanodon speciousus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            91F,
            "Grouper",
            "Nassau Grouper",
            "Epinephelus striatus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            99F,
            "Sculpin",
            "Cabezon",
            "Scorpaenichthys marmoratus",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            150F,
            "Eel",
            "California Moray",
            "Gymnothorax mordax",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            150F,
            "Barracuda",
            "Great Barracuda",
            "Sphyraena barracuda",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            150F,
            "Croaker",
            "White Sea Bass",
            "Atractoscion nobilis",
            true}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            400F,
            "Shark",
            "Nurse Shark",
            "Ginglymostoma cirratum",
            false}, -1, 0, 1, -1);
            this.treeList1.AppendNode(new object[] {
            102F,
            "Shark",
            "Swell Shark",
            "Cephaloscyllium ventriosum",
            false}, 26, 0, 1, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemSpinEdit1});
            this.treeList1.SelectImageList = this.imageList1;
            this.treeList1.Size = new System.Drawing.Size(708, 254);
            this.treeList1.TabIndex = 8;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Species Name";
            this.treeListColumn4.FieldName = "Species Name";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            this.treeListColumn4.Width = 143;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 38);
            this.panel2.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(500, 8);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 22);
            this.button7.TabIndex = 6;
            this.button7.Text = "MoveLastVisible";
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(430, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 22);
            this.button6.TabIndex = 5;
            this.button6.Text = "MoveLast";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(324, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 22);
            this.button5.TabIndex = 4;
            this.button5.Text = "MoveNextVisible";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 22);
            this.button4.TabIndex = 3;
            this.button4.Text = "MoveNext";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 2;
            this.button3.Text = "MovePrevVisible";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "MovePrev";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "MoveFirst";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(708, 8);
            this.panelControl1.TabIndex = 10;
            // 
            // NodesNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel2);
            this.Name = "NodesNavigation";
            this.Size = new System.Drawing.Size(708, 300);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private PanelControl panel2;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton button2;
        private DevExpress.XtraEditors.SimpleButton button3;
        private DevExpress.XtraEditors.SimpleButton button4;
        private DevExpress.XtraEditors.SimpleButton button5;
        private DevExpress.XtraEditors.SimpleButton button6;
        private DevExpress.XtraEditors.SimpleButton button7;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}
