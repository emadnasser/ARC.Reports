namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
    partial class DragDrop {
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
            this.splitter1 = new DevExpress.XtraEditors.SplitterControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new DevExpress.XtraEditors.ListBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new DevExpress.XtraEditors.CheckEdit();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(289, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 474);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(297, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 474);
            this.panel2.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 432);
            this.listBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drag && Drop here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Properties.Caption = "DragRowHeaders";
            this.checkBox1.Size = new System.Drawing.Size(184, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl1.Location = new System.Drawing.Point(4, 4);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsBehavior.DragRowHeaders = true;
            this.vGridControl1.OptionsBehavior.UseTabKey = false;
            this.vGridControl1.Size = new System.Drawing.Size(285, 474);
            this.vGridControl1.TabIndex = 12;
            this.vGridControl1.EndDragRow += new DevExpress.XtraVerticalGrid.Events.EndDragRowEventHandler(this.vGridControl1_EndDragRow);
            this.vGridControl1.ProcessDragRow += new DevExpress.XtraVerticalGrid.Events.ProcessDragRowEventHandler(this.vGridControl1_ProcessDragRow);
            // 
            // DragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Name = "DragDrop";
            this.Size = new System.Drawing.Size(485, 482);
            this.TutorialInfo.AboutFile = null;
            this.TutorialInfo.Description = null;
            this.TutorialInfo.TutorialName = null;
            this.TutorialInfo.WhatsThisCodeFile = null;
            this.TutorialInfo.WhatsThisXMLFile = null;
            this.Load += new System.EventHandler(this.DragDrop_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitterControl splitter1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ListBoxControl listBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit checkBox1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.ComponentModel.IContainer components = null;

    }
}
