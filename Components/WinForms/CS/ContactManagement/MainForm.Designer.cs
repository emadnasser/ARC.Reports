namespace ContactManagement {
    partial class MainForm {
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
            this.gridContacts = new System.Windows.Forms.DataGrid();
            this.contacts = new DevExpress.Xpo.XPCollection();
            this.session = new DevExpress.Xpo.Session();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuAddContact = new System.Windows.Forms.MenuItem();
            this.mnuDeleteContact = new System.Windows.Forms.MenuItem();
            this.mnuProperties = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuCompanies = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuTools = new System.Windows.Forms.MenuItem();
            this.mnuCompact = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContacts
            // 
            this.gridContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridContacts.DataMember = "";
            this.gridContacts.DataSource = this.contacts;
            this.gridContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContacts.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.gridContacts.Location = new System.Drawing.Point(0, 0);
            this.gridContacts.Name = "gridContacts";
            this.gridContacts.ReadOnly = true;
            this.gridContacts.Size = new System.Drawing.Size(738, 422);
            this.gridContacts.TabIndex = 0;
            this.gridContacts.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1,
            this.dataGridTableStyle2,
            this.dataGridTableStyle3});
            this.gridContacts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridContacts_KeyDown);
            this.gridContacts.Navigate += new System.Windows.Forms.NavigateEventHandler(this.gridContacts_Navigate);
            // 
            // contacts
            // 
            this.contacts.CaseSensitive = true;
            this.contacts.ObjectType = typeof(ContactManagement.Contact);
            this.contacts.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("LastName", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            this.contacts.Session = this.session;
            this.contacts.DisplayableProperties = "Oid;FirstName;LastName;PhoneNumber;Email;Employer.Name;DefaultAddress.City;Employ" +
                "er;DefaultAddress";
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.gridContacts;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn3,
            this.dataGridTextBoxColumn4,
            this.dataGridTextBoxColumn5,
            this.dataGridTextBoxColumn6});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.ReadOnly = true;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "First Name";
            this.dataGridTextBoxColumn1.MappingName = "FirstName";
            this.dataGridTextBoxColumn1.Width = 75;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridTextBoxColumn2.MappingName = "LastName";
            this.dataGridTextBoxColumn2.Width = 75;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridTextBoxColumn3.MappingName = "PhoneNumber";
            this.dataGridTextBoxColumn3.Width = 75;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Email";
            this.dataGridTextBoxColumn4.MappingName = "Email";
            this.dataGridTextBoxColumn4.Width = 75;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Employer.Name";
            this.dataGridTextBoxColumn5.MappingName = "Employer.Name";
            this.dataGridTextBoxColumn5.Width = 75;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "DefaultAddress.City";
            this.dataGridTextBoxColumn6.MappingName = "DefaultAddress.City";
            this.dataGridTextBoxColumn6.Width = 75;
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.DataGrid = this.gridContacts;
            this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn7,
            this.dataGridTextBoxColumn8,
            this.dataGridTextBoxColumn9});
            this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle2.MappingName = "Employer";
            this.dataGridTableStyle2.ReadOnly = true;
            this.dataGridTableStyle2.RowHeadersVisible = false;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Employer Name";
            this.dataGridTextBoxColumn7.MappingName = "Name";
            this.dataGridTextBoxColumn7.Width = 75;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "Web";
            this.dataGridTextBoxColumn8.MappingName = "WebSite";
            this.dataGridTextBoxColumn8.Width = 75;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "Phone Number";
            this.dataGridTextBoxColumn9.MappingName = "PhoneNumber";
            this.dataGridTextBoxColumn9.Width = 75;
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.DataGrid = this.gridContacts;
            this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn10,
            this.dataGridTextBoxColumn11});
            this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle3.MappingName = "DefaultAddress";
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "City";
            this.dataGridTextBoxColumn10.MappingName = "City";
            this.dataGridTextBoxColumn10.Width = 75;
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.HeaderText = "Street";
            this.dataGridTextBoxColumn11.MappingName = "Street";
            this.dataGridTextBoxColumn11.Width = 75;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAddContact,
            this.mnuDeleteContact,
            this.mnuProperties,
            this.menuItem3,
            this.mnuCompanies,
            this.menuItem1,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuAddContact
            // 
            this.mnuAddContact.Index = 0;
            this.mnuAddContact.Shortcut = System.Windows.Forms.Shortcut.Ins;
            this.mnuAddContact.Text = "&Add Contact...";
            this.mnuAddContact.Click += new System.EventHandler(this.mnuAddContact_Click);
            // 
            // mnuDeleteContact
            // 
            this.mnuDeleteContact.Index = 1;
            this.mnuDeleteContact.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.mnuDeleteContact.Text = "&Delete Contact";
            this.mnuDeleteContact.Click += new System.EventHandler(this.mnuDeleteContact_Click);
            // 
            // mnuProperties
            // 
            this.mnuProperties.Index = 2;
            this.mnuProperties.Text = "&Edit Contact...";
            this.mnuProperties.Click += new System.EventHandler(this.mnuProperties_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "-";
            // 
            // mnuCompanies
            // 
            this.mnuCompanies.Index = 4;
            this.mnuCompanies.Text = "C&ompanies...";
            this.mnuCompanies.Click += new System.EventHandler(this.mnuCompanies_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.Index = 1;
            this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCompact});
            this.mnuTools.Text = "Tools";
            // 
            // mnuCompact
            // 
            this.mnuCompact.Index = 0;
            this.mnuCompact.Text = "Compact Database...";
            this.mnuCompact.Click += new System.EventHandler(this.mnuCompact_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(738, 422);
            this.Controls.Add(this.gridContacts);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGrid gridContacts;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuAddContact;
        private System.Windows.Forms.MenuItem mnuDeleteContact;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuProperties;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuCompanies;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuTools;
        private System.Windows.Forms.MenuItem mnuCompact;
        private DevExpress.Xpo.Session session;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        internal DevExpress.Xpo.XPCollection contacts;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.ComponentModel.IContainer components;

    }
}
