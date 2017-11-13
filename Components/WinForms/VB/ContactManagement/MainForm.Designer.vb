Imports Microsoft.VisualBasic
Imports System
Namespace ContactManagement
	Public Partial Class MainForm
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridContacts = New System.Windows.Forms.DataGrid()
			Me.contacts = New DevExpress.Xpo.XPCollection()
			Me.session = New DevExpress.Xpo.Session()
			Me.dataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
			Me.dataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
			Me.dataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
			Me.dataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.dataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
			Me.mainMenu = New System.Windows.Forms.MainMenu(Me.components)
			Me.mnuFile = New System.Windows.Forms.MenuItem()
			Me.mnuAddContact = New System.Windows.Forms.MenuItem()
			Me.mnuDeleteContact = New System.Windows.Forms.MenuItem()
			Me.mnuProperties = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.mnuCompanies = New System.Windows.Forms.MenuItem()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.mnuExit = New System.Windows.Forms.MenuItem()
			Me.mnuTools = New System.Windows.Forms.MenuItem()
			Me.mnuCompact = New System.Windows.Forms.MenuItem()
			Me.mnuHelp = New System.Windows.Forms.MenuItem()
			Me.mnuAbout = New System.Windows.Forms.MenuItem()
			CType(Me.gridContacts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.contacts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridContacts
			' 
			Me.gridContacts.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gridContacts.DataMember = ""
			Me.gridContacts.DataSource = Me.contacts
			Me.gridContacts.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridContacts.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.gridContacts.Location = New System.Drawing.Point(0, 0)
			Me.gridContacts.Name = "gridContacts"
			Me.gridContacts.ReadOnly = True
			Me.gridContacts.Size = New System.Drawing.Size(738, 422)
			Me.gridContacts.TabIndex = 0
			Me.gridContacts.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() { Me.dataGridTableStyle1, Me.dataGridTableStyle2, Me.dataGridTableStyle3})
'			Me.gridContacts.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridContacts_KeyDown);
'			Me.gridContacts.Navigate += New System.Windows.Forms.NavigateEventHandler(Me.gridContacts_Navigate);
			' 
			' contacts
			' 
			Me.contacts.CaseSensitive = True
			Me.contacts.ObjectType = GetType(ContactManagement.Contact)
			Me.contacts.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("LastName", DevExpress.Xpo.DB.SortingDirection.Ascending)})
			Me.contacts.Session = Me.session
			Me.contacts.DisplayableProperties = "Oid;FirstName;LastName;PhoneNumber;Email;Employer.Name;DefaultAddress.City;Employ" & "er;DefaultAddress"
			' 
			' dataGridTableStyle1
			' 
			Me.dataGridTableStyle1.DataGrid = Me.gridContacts
			Me.dataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() { Me.dataGridTextBoxColumn1, Me.dataGridTextBoxColumn2, Me.dataGridTextBoxColumn3, Me.dataGridTextBoxColumn4, Me.dataGridTextBoxColumn5, Me.dataGridTextBoxColumn6})
			Me.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.dataGridTableStyle1.ReadOnly = True
			' 
			' dataGridTextBoxColumn1
			' 
			Me.dataGridTextBoxColumn1.Format = ""
			Me.dataGridTextBoxColumn1.FormatInfo = Nothing
			Me.dataGridTextBoxColumn1.HeaderText = "First Name"
			Me.dataGridTextBoxColumn1.MappingName = "FirstName"
			Me.dataGridTextBoxColumn1.Width = 75
			' 
			' dataGridTextBoxColumn2
			' 
			Me.dataGridTextBoxColumn2.Format = ""
			Me.dataGridTextBoxColumn2.FormatInfo = Nothing
			Me.dataGridTextBoxColumn2.HeaderText = "Last Name"
			Me.dataGridTextBoxColumn2.MappingName = "LastName"
			Me.dataGridTextBoxColumn2.Width = 75
			' 
			' dataGridTextBoxColumn3
			' 
			Me.dataGridTextBoxColumn3.Format = ""
			Me.dataGridTextBoxColumn3.FormatInfo = Nothing
			Me.dataGridTextBoxColumn3.HeaderText = "Phone Number"
			Me.dataGridTextBoxColumn3.MappingName = "PhoneNumber"
			Me.dataGridTextBoxColumn3.Width = 75
			' 
			' dataGridTextBoxColumn4
			' 
			Me.dataGridTextBoxColumn4.Format = ""
			Me.dataGridTextBoxColumn4.FormatInfo = Nothing
			Me.dataGridTextBoxColumn4.HeaderText = "Email"
			Me.dataGridTextBoxColumn4.MappingName = "Email"
			Me.dataGridTextBoxColumn4.Width = 75
			' 
			' dataGridTextBoxColumn5
			' 
			Me.dataGridTextBoxColumn5.Format = ""
			Me.dataGridTextBoxColumn5.FormatInfo = Nothing
			Me.dataGridTextBoxColumn5.HeaderText = "Employer.Name"
			Me.dataGridTextBoxColumn5.MappingName = "Employer.Name"
			Me.dataGridTextBoxColumn5.Width = 75
			' 
			' dataGridTextBoxColumn6
			' 
			Me.dataGridTextBoxColumn6.Format = ""
			Me.dataGridTextBoxColumn6.FormatInfo = Nothing
			Me.dataGridTextBoxColumn6.HeaderText = "DefaultAddress.City"
			Me.dataGridTextBoxColumn6.MappingName = "DefaultAddress.City"
			Me.dataGridTextBoxColumn6.Width = 75
			' 
			' dataGridTableStyle2
			' 
			Me.dataGridTableStyle2.DataGrid = Me.gridContacts
			Me.dataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() { Me.dataGridTextBoxColumn7, Me.dataGridTextBoxColumn8, Me.dataGridTextBoxColumn9})
			Me.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.dataGridTableStyle2.MappingName = "Employer"
			Me.dataGridTableStyle2.ReadOnly = True
			Me.dataGridTableStyle2.RowHeadersVisible = False
			' 
			' dataGridTextBoxColumn7
			' 
			Me.dataGridTextBoxColumn7.Format = ""
			Me.dataGridTextBoxColumn7.FormatInfo = Nothing
			Me.dataGridTextBoxColumn7.HeaderText = "Employer Name"
			Me.dataGridTextBoxColumn7.MappingName = "Name"
			Me.dataGridTextBoxColumn7.Width = 75
			' 
			' dataGridTextBoxColumn8
			' 
			Me.dataGridTextBoxColumn8.Format = ""
			Me.dataGridTextBoxColumn8.FormatInfo = Nothing
			Me.dataGridTextBoxColumn8.HeaderText = "Web"
			Me.dataGridTextBoxColumn8.MappingName = "WebSite"
			Me.dataGridTextBoxColumn8.Width = 75
			' 
			' dataGridTextBoxColumn9
			' 
			Me.dataGridTextBoxColumn9.Format = ""
			Me.dataGridTextBoxColumn9.FormatInfo = Nothing
			Me.dataGridTextBoxColumn9.HeaderText = "Phone Number"
			Me.dataGridTextBoxColumn9.MappingName = "PhoneNumber"
			Me.dataGridTextBoxColumn9.Width = 75
			' 
			' dataGridTableStyle3
			' 
			Me.dataGridTableStyle3.DataGrid = Me.gridContacts
			Me.dataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() { Me.dataGridTextBoxColumn10, Me.dataGridTextBoxColumn11})
			Me.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.dataGridTableStyle3.MappingName = "DefaultAddress"
			' 
			' dataGridTextBoxColumn10
			' 
			Me.dataGridTextBoxColumn10.Format = ""
			Me.dataGridTextBoxColumn10.FormatInfo = Nothing
			Me.dataGridTextBoxColumn10.HeaderText = "City"
			Me.dataGridTextBoxColumn10.MappingName = "City"
			Me.dataGridTextBoxColumn10.Width = 75
			' 
			' dataGridTextBoxColumn11
			' 
			Me.dataGridTextBoxColumn11.Format = ""
			Me.dataGridTextBoxColumn11.FormatInfo = Nothing
			Me.dataGridTextBoxColumn11.HeaderText = "Street"
			Me.dataGridTextBoxColumn11.MappingName = "Street"
			Me.dataGridTextBoxColumn11.Width = 75
			' 
			' mainMenu
			' 
			Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.mnuFile, Me.mnuTools, Me.mnuHelp})
			' 
			' mnuFile
			' 
			Me.mnuFile.Index = 0
			Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.mnuAddContact, Me.mnuDeleteContact, Me.mnuProperties, Me.menuItem3, Me.mnuCompanies, Me.menuItem1, Me.mnuExit})
			Me.mnuFile.Text = "&File"
			' 
			' mnuAddContact
			' 
			Me.mnuAddContact.Index = 0
			Me.mnuAddContact.Shortcut = System.Windows.Forms.Shortcut.Ins
			Me.mnuAddContact.Text = "&Add Contact..."
'			Me.mnuAddContact.Click += New System.EventHandler(Me.mnuAddContact_Click);
			' 
			' mnuDeleteContact
			' 
			Me.mnuDeleteContact.Index = 1
			Me.mnuDeleteContact.Shortcut = System.Windows.Forms.Shortcut.Del
			Me.mnuDeleteContact.Text = "&Delete Contact"
'			Me.mnuDeleteContact.Click += New System.EventHandler(Me.mnuDeleteContact_Click);
			' 
			' mnuProperties
			' 
			Me.mnuProperties.Index = 2
			Me.mnuProperties.Text = "&Edit Contact..."
'			Me.mnuProperties.Click += New System.EventHandler(Me.mnuProperties_Click);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 3
			Me.menuItem3.Text = "-"
			' 
			' mnuCompanies
			' 
			Me.mnuCompanies.Index = 4
			Me.mnuCompanies.Text = "C&ompanies..."
'			Me.mnuCompanies.Click += New System.EventHandler(Me.mnuCompanies_Click);
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 5
			Me.menuItem1.Text = "-"
			' 
			' mnuExit
			' 
			Me.mnuExit.Index = 6
			Me.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
			Me.mnuExit.Text = "&Exit"
'			Me.mnuExit.Click += New System.EventHandler(Me.mnuExit_Click);
			' 
			' mnuTools
			' 
			Me.mnuTools.Index = 1
			Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.mnuCompact})
			Me.mnuTools.Text = "Tools"
			' 
			' mnuCompact
			' 
			Me.mnuCompact.Index = 0
			Me.mnuCompact.Text = "Compact Database..."
'			Me.mnuCompact.Click += New System.EventHandler(Me.mnuCompact_Click);
			' 
			' mnuHelp
			' 
			Me.mnuHelp.Index = 2
			Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.mnuAbout})
			Me.mnuHelp.Text = "&Help"
			' 
			' mnuAbout
			' 
			Me.mnuAbout.Index = 0
			Me.mnuAbout.Text = "&About..."
'			Me.mnuAbout.Click += New System.EventHandler(Me.mnuAbout_Click);
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(738, 422)
			Me.Controls.Add(Me.gridContacts)
			Me.Menu = Me.mainMenu
			Me.Name = "MainForm"
			Me.Text = "Contact Manager"
			CType(Me.gridContacts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.contacts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents gridContacts As System.Windows.Forms.DataGrid
		Private mainMenu As System.Windows.Forms.MainMenu
		Private mnuFile As System.Windows.Forms.MenuItem
		Private WithEvents mnuAddContact As System.Windows.Forms.MenuItem
		Private WithEvents mnuDeleteContact As System.Windows.Forms.MenuItem
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents mnuExit As System.Windows.Forms.MenuItem
		Private WithEvents mnuProperties As System.Windows.Forms.MenuItem
		Private menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents mnuCompanies As System.Windows.Forms.MenuItem
		Private mnuHelp As System.Windows.Forms.MenuItem
		Private WithEvents mnuAbout As System.Windows.Forms.MenuItem
		Private mnuTools As System.Windows.Forms.MenuItem
		Private WithEvents mnuCompact As System.Windows.Forms.MenuItem
		Private session As DevExpress.Xpo.Session
		Private dataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
		Private dataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
		Friend contacts As DevExpress.Xpo.XPCollection
		Private dataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
		Private dataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
		Private dataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
		Private dataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
