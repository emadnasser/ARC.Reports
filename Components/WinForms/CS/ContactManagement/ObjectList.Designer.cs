using DevExpress.Xpo;
namespace ContactManagement {
    partial class ObjectList {
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
            this.gridObjects = new System.Windows.Forms.DataGrid();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuAdd = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // gridObjects
            // 
            this.gridObjects.DataMember = "";
            this.gridObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridObjects.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridObjects.Location = new System.Drawing.Point(0, 0);
            this.gridObjects.Name = "gridObjects";
            this.gridObjects.ReadOnly = true;
            this.gridObjects.Size = new System.Drawing.Size(507, 259);
            this.gridObjects.TabIndex = 0;
            this.gridObjects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridObjects_KeyDown);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuDelete});
            // 
            // mnuAdd
            // 
            this.mnuAdd.Index = 0;
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 2;
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // ObjectList
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(507, 259);
            this.Controls.Add(this.gridObjects);
            this.Menu = this.mainMenu;
            this.Name = "ObjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Objects";
            ((System.ComponentModel.ISupportInitialize)(this.gridObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid gridObjects;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuAdd;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuDelete;
        public XPCollection objects = null;
        private System.ComponentModel.IContainer components;

    }
}
