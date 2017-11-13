Namespace DevExpress.XtraEditors.Demos
	Partial Public Class InplaceEditors
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(InplaceEditors))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridEditorName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridEditorValue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.repositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemTimeEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
			Me.repositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemImageComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imcSmall = New DevExpress.Utils.ImageCollection(Me.components)
			Me.repositoryItemMRUEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit()
			Me.repositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemPictureEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.repositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.repositoryItemRadioGroup = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
			Me.repositoryItemHyperLinkEdit = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.repositoryItemPopupContainerEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
			Me.popupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
			Me.gridPopup = New DevExpress.XtraGrid.GridControl()
			Me.dataTableLookUp = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.gridView1Popup = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colclnName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colclnDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageEdit = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.repositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.repositoryItemProgressBar = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.repositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.repositoryItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.repositoryItemColorEdit = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
			Me.repositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
			Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
			Me.repositoryItemRangeTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar()
			Me.repositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
			Me.dataSet1 = New System.Data.DataSet()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.gcProperties = New DevExpress.XtraEditors.GroupControl()
			Me.xtraPropertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMRUEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRadioGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl.SuspendLayout()
			CType(Me.gridPopup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTableLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1Popup, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRangeTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gcProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gcProperties.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(5, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit, Me.repositoryItemButtonEdit, Me.repositoryItemSpinEdit, Me.repositoryItemTimeEdit, Me.repositoryItemComboBox, Me.repositoryItemImageComboBox, Me.repositoryItemMRUEdit, Me.repositoryItemCheckEdit, Me.repositoryItemPictureEdit, Me.repositoryItemMemoEdit, Me.repositoryItemRadioGroup, Me.repositoryItemHyperLinkEdit, Me.repositoryItemPopupContainerEdit, Me.repositoryItemImageEdit, Me.repositoryItemMemoExEdit, Me.repositoryItemProgressBar, Me.repositoryItemDateEdit, Me.repositoryItemCalcEdit, Me.repositoryItemColorEdit, Me.repositoryItemLookUpEdit, Me.repositoryItemTrackBar1, Me.repositoryItemFontEdit1, Me.repositoryItemRangeTrackBar1, Me.repositoryItemCheckedComboBoxEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(588, 423)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridEditorName, Me.gridEditorValue})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsPrint.AutoWidth = False
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.OptionsView.RowAutoHeight = True
			Me.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			Me.gridView1.OptionsView.ShowGroupPanel = False
'			Me.gridView1.CustomRowCellEdit += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridView1_CustomRowCellEdit)
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged)
			' 
			' gridEditorName
			' 
			Me.gridEditorName.Caption = "Editor Name"
			Me.gridEditorName.FieldName = "Name"
			Me.gridEditorName.Name = "gridEditorName"
			Me.gridEditorName.OptionsColumn.AllowEdit = False
			Me.gridEditorName.OptionsColumn.AllowFocus = False
			Me.gridEditorName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridEditorName.OptionsColumn.ReadOnly = True
			Me.gridEditorName.OptionsFilter.AllowAutoFilter = False
			Me.gridEditorName.OptionsFilter.AllowFilter = False
			Me.gridEditorName.Visible = True
			Me.gridEditorName.VisibleIndex = 0
			Me.gridEditorName.Width = 221
			' 
			' gridEditorValue
			' 
			Me.gridEditorValue.Caption = "Value"
			Me.gridEditorValue.FieldName = "Value"
			Me.gridEditorValue.Name = "gridEditorValue"
			Me.gridEditorValue.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridEditorValue.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridEditorValue.OptionsFilter.AllowAutoFilter = False
			Me.gridEditorValue.OptionsFilter.AllowFilter = False
			Me.gridEditorValue.Visible = True
			Me.gridEditorValue.VisibleIndex = 1
			Me.gridEditorValue.Width = 289
			' 
			' repositoryItemTextEdit
			' 
			Me.repositoryItemTextEdit.AutoHeight = False
			Me.repositoryItemTextEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemTextEdit.Name = "repositoryItemTextEdit"
			' 
			' repositoryItemButtonEdit
			' 
			Me.repositoryItemButtonEdit.AutoHeight = False
			Me.repositoryItemButtonEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit"
'			Me.repositoryItemButtonEdit.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.repositoryItemButtonEdit_ButtonClick)
			' 
			' repositoryItemSpinEdit
			' 
			Me.repositoryItemSpinEdit.AutoHeight = False
			Me.repositoryItemSpinEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit"
			' 
			' repositoryItemTimeEdit
			' 
			Me.repositoryItemTimeEdit.AutoHeight = False
			Me.repositoryItemTimeEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemTimeEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemTimeEdit.Name = "repositoryItemTimeEdit"
			' 
			' repositoryItemComboBox
			' 
			Me.repositoryItemComboBox.AutoHeight = False
			Me.repositoryItemComboBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox.DropDownRows = 15
			Me.repositoryItemComboBox.Items.AddRange(New Object() { "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Bouvet Island", "Brazil", "British Indian Ocean Territories", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China, People''s Republic of", "Christmas Island", "Cocos Islands", "Columbia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Cote D''ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Faroe Islands", "Fiji", "Finland", "France", "France, Metropolitan", "French Guiana", "French Polynesia", "French Southern Territories", "FYROM", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Heard Island And Mcdonald Islands", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Democratic Peoples Republic of", "Korea, Republic of", "Kuwait", "Kyrgyzstan", "Lao Peoples Democratic Republic", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Norfolk Island", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Pierre and Miquelon", "Saint Vincent and The Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Georgia and Sandwich Islands", "Spain", "Sri Lanka", "Sudan", "Suriname", "Svalbard and JanMayen", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City State", "Venezuela", "Vietnam", "Virgin Islands (British)", "Virgin Islands (U.S.)", "Wallis And Futuna Islands", "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe", "Guernsey", "Malaga", "Denmark", "Jersey"})
			Me.repositoryItemComboBox.Name = "repositoryItemComboBox"
			' 
			' repositoryItemImageComboBox
			' 
			Me.repositoryItemImageComboBox.AutoHeight = False
			Me.repositoryItemImageComboBox.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox.DropDownRows = 12
			Me.repositoryItemImageComboBox.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Time", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Design", 1, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mail", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pie", 3, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Home", 4, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Tag", 5, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Contact", 6, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Database", 7, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", 8, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Video", 9, 9)})
			Me.repositoryItemImageComboBox.Name = "repositoryItemImageComboBox"
			Me.repositoryItemImageComboBox.SmallImages = Me.imcSmall
			' 
			' imcSmall
			' 
			Me.imcSmall.ImageStream = (CType(resources.GetObject("imcSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imcSmall.InsertGalleryImage("time_16x16.png", "images/scheduling/time_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/time_16x16.png"), 0)
			Me.imcSmall.Images.SetKeyName(0, "time_16x16.png")
			Me.imcSmall.InsertGalleryImage("design_16x16.png", "images/miscellaneous/design_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/design_16x16.png"), 1)
			Me.imcSmall.Images.SetKeyName(1, "design_16x16.png")
			Me.imcSmall.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_16x16.png"), 2)
			Me.imcSmall.Images.SetKeyName(2, "mail_16x16.png")
			Me.imcSmall.InsertGalleryImage("pie_16x16.png", "images/chart/pie_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/chart/pie_16x16.png"), 3)
			Me.imcSmall.Images.SetKeyName(3, "pie_16x16.png")
			Me.imcSmall.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 4)
			Me.imcSmall.Images.SetKeyName(4, "home_16x16.png")
			Me.imcSmall.InsertGalleryImage("tag_16x16.png", "images/programming/tag_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/tag_16x16.png"), 5)
			Me.imcSmall.Images.SetKeyName(5, "tag_16x16.png")
			Me.imcSmall.InsertGalleryImage("contact_16x16.png", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 6)
			Me.imcSmall.Images.SetKeyName(6, "contact_16x16.png")
			Me.imcSmall.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 7)
			Me.imcSmall.Images.SetKeyName(7, "database_16x16.png")
			Me.imcSmall.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_16x16.png"), 8)
			Me.imcSmall.Images.SetKeyName(8, "task_16x16.png")
			Me.imcSmall.InsertGalleryImage("video_16x16.png", "images/miscellaneous/video_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/video_16x16.png"), 9)
			Me.imcSmall.Images.SetKeyName(9, "video_16x16.png")
			' 
			' repositoryItemMRUEdit
			' 
			Me.repositoryItemMRUEdit.AutoHeight = False
			Me.repositoryItemMRUEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemMRUEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemMRUEdit.Items.AddRange(New Object() { "White", "Black", "Blue", "Green"})
			Me.repositoryItemMRUEdit.Name = "repositoryItemMRUEdit"
'			Me.repositoryItemMRUEdit.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.repositoryItemMRUEdit_ButtonClick)
			' 
			' repositoryItemCheckEdit
			' 
			Me.repositoryItemCheckEdit.AutoHeight = False
			Me.repositoryItemCheckEdit.Caption = "Check"
			Me.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit"
			' 
			' repositoryItemPictureEdit
			' 
			Me.repositoryItemPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit"
			' 
			' repositoryItemMemoEdit
			' 
			Me.repositoryItemMemoEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit"
			' 
			' repositoryItemRadioGroup
			' 
			Me.repositoryItemRadioGroup.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemRadioGroup.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Male"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Female")})
			Me.repositoryItemRadioGroup.Name = "repositoryItemRadioGroup"
			' 
			' repositoryItemHyperLinkEdit
			' 
			Me.repositoryItemHyperLinkEdit.AutoHeight = False
			Me.repositoryItemHyperLinkEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemHyperLinkEdit.Name = "repositoryItemHyperLinkEdit"
			' 
			' repositoryItemPopupContainerEdit
			' 
			Me.repositoryItemPopupContainerEdit.AutoHeight = False
			Me.repositoryItemPopupContainerEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemPopupContainerEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemPopupContainerEdit.CloseOnOuterMouseClick = False
			Me.repositoryItemPopupContainerEdit.Name = "repositoryItemPopupContainerEdit"
			Me.repositoryItemPopupContainerEdit.PopupControl = Me.popupContainerControl
'			Me.repositoryItemPopupContainerEdit.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.repositoryItemPopupContainerEdit_QueryResultValue)
'			Me.repositoryItemPopupContainerEdit.QueryDisplayText += New DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(Me.repositoryItemPopupContainerEdit_QueryDisplayText)
'			Me.repositoryItemPopupContainerEdit.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.repositoryItemPopupContainerEdit_QueryPopUp)
			' 
			' popupContainerControl
			' 
			Me.popupContainerControl.Controls.Add(Me.gridPopup)
			Me.popupContainerControl.Location = New System.Drawing.Point(48, 24)
			Me.popupContainerControl.Name = "popupContainerControl"
			Me.popupContainerControl.Size = New System.Drawing.Size(344, 256)
			Me.popupContainerControl.TabIndex = 4
			' 
			' gridPopup
			' 
			Me.gridPopup.DataSource = Me.dataTableLookUp
			Me.gridPopup.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridPopup.Location = New System.Drawing.Point(0, 0)
			Me.gridPopup.MainView = Me.gridView1Popup
			Me.gridPopup.Name = "gridPopup"
			Me.gridPopup.Size = New System.Drawing.Size(344, 256)
			Me.gridPopup.TabIndex = 1
			Me.gridPopup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1Popup})
'			Me.gridPopup.BindingContextChanged += New System.EventHandler(Me.gridPopup_BindingContextChanged)
			' 
			' dataTableLookUp
			' 
			Me.dataTableLookUp.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTableLookUp.TableName = "TableLookUp"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.Caption = "Id"
			Me.dataColumn1.ColumnName = "clnId"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.Caption = "Name"
			Me.dataColumn2.ColumnName = "clnName"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.Caption = "Department"
			Me.dataColumn3.ColumnName = "clnDepartment"
			' 
			' gridView1Popup
			' 
			Me.gridView1Popup.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colclnName, Me.colclnDepartment})
			Me.gridView1Popup.GridControl = Me.gridPopup
			Me.gridView1Popup.GroupCount = 1
			Me.gridView1Popup.Name = "gridView1Popup"
			Me.gridView1Popup.OptionsBehavior.AllowIncrementalSearch = True
			Me.gridView1Popup.OptionsBehavior.Editable = False
			Me.gridView1Popup.OptionsSelection.InvertSelection = True
			Me.gridView1Popup.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colclnDepartment, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1Popup.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridView1Popup_KeyDown)
'			Me.gridView1Popup.DoubleClick += New System.EventHandler(Me.gridView1Popup_DoubleClick)
			' 
			' colclnName
			' 
			Me.colclnName.Caption = "Name"
			Me.colclnName.FieldName = "clnName"
			Me.colclnName.Name = "colclnName"
			Me.colclnName.Visible = True
			Me.colclnName.VisibleIndex = 0
			' 
			' colclnDepartment
			' 
			Me.colclnDepartment.Caption = "Department"
			Me.colclnDepartment.FieldName = "clnDepartment"
			Me.colclnDepartment.Name = "colclnDepartment"
			' 
			' repositoryItemImageEdit
			' 
			Me.repositoryItemImageEdit.AutoHeight = False
			Me.repositoryItemImageEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit.Name = "repositoryItemImageEdit"
			Me.repositoryItemImageEdit.PopupFormSize = New System.Drawing.Size(250, 150)
			' 
			' repositoryItemMemoExEdit
			' 
			Me.repositoryItemMemoExEdit.AutoHeight = False
			Me.repositoryItemMemoExEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit.Name = "repositoryItemMemoExEdit"
			Me.repositoryItemMemoExEdit.PopupFormSize = New System.Drawing.Size(250, 150)
			' 
			' repositoryItemProgressBar
			' 
			Me.repositoryItemProgressBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemProgressBar.Name = "repositoryItemProgressBar"
			' 
			' repositoryItemDateEdit
			' 
			Me.repositoryItemDateEdit.AutoHeight = False
			Me.repositoryItemDateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemDateEdit.Name = "repositoryItemDateEdit"
			' 
			' repositoryItemCalcEdit
			' 
			Me.repositoryItemCalcEdit.AutoHeight = False
			Me.repositoryItemCalcEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit.Name = "repositoryItemCalcEdit"
			' 
			' repositoryItemColorEdit
			' 
			Me.repositoryItemColorEdit.AutoHeight = False
			Me.repositoryItemColorEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemColorEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemColorEdit.Name = "repositoryItemColorEdit"
			' 
			' repositoryItemLookUpEdit
			' 
			Me.repositoryItemLookUpEdit.AutoHeight = False
			Me.repositoryItemLookUpEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnName", "Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("clnDepartment", "Department", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit.DataSource = Me.dataTableLookUp
			Me.repositoryItemLookUpEdit.DisplayMember = "clnName"
			Me.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit"
			Me.repositoryItemLookUpEdit.PopupWidth = 290
			Me.repositoryItemLookUpEdit.ValueMember = "clnId"
			' 
			' repositoryItemTrackBar1
			' 
			Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
			Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
			' 
			' repositoryItemFontEdit1
			' 
			Me.repositoryItemFontEdit1.AutoHeight = False
			Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
			' 
			' repositoryItemRangeTrackBar1
			' 
			Me.repositoryItemRangeTrackBar1.LabelAppearance.Options.UseTextOptions = True
			Me.repositoryItemRangeTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemRangeTrackBar1.Name = "repositoryItemRangeTrackBar1"
			' 
			' repositoryItemCheckedComboBoxEdit1
			' 
			Me.repositoryItemCheckedComboBoxEdit1.AutoHeight = False
			Me.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1"
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTableLookUp})
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(304, 88)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(176, 224)
			Me.pictureBox1.TabIndex = 3
			Me.pictureBox1.TabStop = False
			Me.pictureBox1.Visible = False
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(593, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(5, 423)
			Me.splitter1.TabIndex = 6
			Me.splitter1.TabStop = False
			' 
			' gcProperties
			' 
			Me.gcProperties.Appearance.BackColor = System.Drawing.SystemColors.Control
			Me.gcProperties.Appearance.Options.UseBackColor = True
			Me.gcProperties.Controls.Add(Me.xtraPropertyGrid1)
			Me.gcProperties.Dock = System.Windows.Forms.DockStyle.Right
			Me.gcProperties.Location = New System.Drawing.Point(598, 0)
			Me.gcProperties.Name = "gcProperties"
			Me.gcProperties.Padding = New System.Windows.Forms.Padding(1)
			Me.gcProperties.Size = New System.Drawing.Size(405, 423)
			Me.gcProperties.TabIndex = 7
			Me.gcProperties.Text = "Properties:"
			' 
			' xtraPropertyGrid1
			' 
			Me.xtraPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraPropertyGrid1.Location = New System.Drawing.Point(3, 22)
			Me.xtraPropertyGrid1.Name = "xtraPropertyGrid1"
			Me.xtraPropertyGrid1.Size = New System.Drawing.Size(399, 398)
			Me.xtraPropertyGrid1.TabIndex = 0
			' 
			' InplaceEditors
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.popupContainerControl)
			Me.Controls.Add(Me.pictureBox1)
			Me.Controls.Add(Me.gcProperties)
			Me.Name = "InplaceEditors"
			Me.Size = New System.Drawing.Size(1003, 428)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imcSmall, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMRUEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRadioGroup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl.ResumeLayout(False)
			CType(Me.gridPopup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTableLookUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1Popup, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRangeTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gcProperties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gcProperties.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridEditorName As DevExpress.XtraGrid.Columns.GridColumn
		Private gridEditorValue As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private WithEvents repositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private repositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemTimeEdit As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
		Private repositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemImageComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents repositoryItemMRUEdit As DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit
		Private repositoryItemCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemPictureEdit As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemRadioGroup As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
		Private repositoryItemHyperLinkEdit As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private WithEvents repositoryItemPopupContainerEdit As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
		Private repositoryItemImageEdit As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemProgressBar As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private repositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemColorEdit As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private repositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private dataSet1 As System.Data.DataSet
		Private dataTableLookUp As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private colclnName As DevExpress.XtraGrid.Columns.GridColumn
		Private colclnDepartment As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents gridPopup As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1Popup As DevExpress.XtraGrid.Views.Grid.GridView
		Private popupContainerControl As DevExpress.XtraEditors.PopupContainerControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gcProperties As DevExpress.XtraEditors.GroupControl
		Private repositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
		Private xtraPropertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid
		Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
		Private repositoryItemRangeTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar
		Private repositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
		Private imcSmall As Utils.ImageCollection
	End Class
End Namespace
