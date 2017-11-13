Namespace DevExpress.XtraGrid.Demos
	Partial Public Class AlphaBlending
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(AlphaBlending))
			Me.btnEditAlphaBlending = New DevExpress.XtraEditors.SimpleButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.chAlphaBlending = New DevExpress.XtraEditors.CheckEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colEmployeeID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHireDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.colBirthDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colRegion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colExtension = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.xtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.cbeStyles = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cbeImages = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.chAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.cbeStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnEditAlphaBlending
			' 
			Me.btnEditAlphaBlending.ImageIndex = 3
			Me.btnEditAlphaBlending.ImageList = Me.imageList1
			Me.btnEditAlphaBlending.Location = New System.Drawing.Point(14, 37)
			Me.btnEditAlphaBlending.Name = "btnEditAlphaBlending"
			Me.btnEditAlphaBlending.Size = New System.Drawing.Size(116, 24)
			Me.btnEditAlphaBlending.TabIndex = 18
			Me.btnEditAlphaBlending.Text = "A&djust..."
'			Me.btnEditAlphaBlending.Click += New System.EventHandler(Me.btnEditAlphaBlending_Click)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			' 
			' chAlphaBlending
			' 
			Me.chAlphaBlending.EditValue = True
			Me.chAlphaBlending.Location = New System.Drawing.Point(12, 12)
			Me.chAlphaBlending.Name = "chAlphaBlending"
			Me.chAlphaBlending.Properties.Caption = "Alpha &Blending"
			Me.chAlphaBlending.Size = New System.Drawing.Size(116, 19)
			Me.chAlphaBlending.TabIndex = 15
'			Me.chAlphaBlending.CheckedChanged += New System.EventHandler(Me.chAlphaBlending_CheckedChanged)
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 78)
			Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoExEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemImageComboBox1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(832, 387)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand3, Me.gridBand2, Me.gridBand1})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colAddress, Me.colBirthDate, Me.colCity, Me.colCountry, Me.colEmployeeID, Me.colExtension, Me.colFirstName, Me.colHireDate, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colPostalCode, Me.colRegion, Me.colTitle, Me.colTitleOfCourtesy})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.GroupCount = 1
			Me.advBandedGridView1.Images = Me.imageList1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.PaintStyleName = "MixedXP"
			Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCountry, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.advBandedGridView1.EndGrouping += New System.EventHandler(Me.advBandedGridView1_EndGrouping)
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Photo"
			Me.gridBand3.Columns.Add(Me.colPhoto)
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 75
			' 
			' colPhoto
			' 
			Me.colPhoto.Caption = "Photo"
			Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.ImageIndex = 2
			Me.colPhoto.Name = "colPhoto"
			Me.colPhoto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colPhoto.OptionsFilter.AllowFilter = False
			Me.colPhoto.RowCount = 3
			Me.colPhoto.Visible = True
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Employee"
			Me.gridBand2.Columns.Add(Me.colEmployeeID)
			Me.gridBand2.Columns.Add(Me.colFirstName)
			Me.gridBand2.Columns.Add(Me.colLastName)
			Me.gridBand2.Columns.Add(Me.colHireDate)
			Me.gridBand2.Columns.Add(Me.colTitleOfCourtesy)
			Me.gridBand2.Columns.Add(Me.colNotes)
			Me.gridBand2.Columns.Add(Me.colBirthDate)
			Me.gridBand2.Columns.Add(Me.colTitle)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 267
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.Caption = "EmployeeID"
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Width = 20
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "First Name"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.Width = 70
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "Last Name"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.Width = 71
			' 
			' colHireDate
			' 
			Me.colHireDate.Caption = "Hire Date"
			Me.colHireDate.FieldName = "HireDate"
			Me.colHireDate.Name = "colHireDate"
			Me.colHireDate.Width = 24
			' 
			' colTitleOfCourtesy
			' 
			Me.colTitleOfCourtesy.Caption = "Title Of Courtesy"
			Me.colTitleOfCourtesy.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
			Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
			Me.colTitleOfCourtesy.Visible = True
			Me.colTitleOfCourtesy.Width = 126
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dr.", "Dr.", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Miss", "Miss", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mr.", "Mr.", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mrs.", "Mrs.", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ms.", "Ms.", 4)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			' 
			' colNotes
			' 
			Me.colNotes.Caption = "Notes"
			Me.colNotes.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.ImageIndex = 1
			Me.colNotes.Name = "colNotes"
			Me.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colNotes.OptionsFilter.AllowFilter = False
			Me.colNotes.RowIndex = 1
			Me.colNotes.Visible = True
			Me.colNotes.Width = 141
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(300, 150)
			' 
			' colBirthDate
			' 
			Me.colBirthDate.Caption = "Birth Date"
			Me.colBirthDate.FieldName = "BirthDate"
			Me.colBirthDate.Name = "colBirthDate"
			Me.colBirthDate.RowIndex = 1
			Me.colBirthDate.Visible = True
			Me.colBirthDate.Width = 126
			' 
			' colTitle
			' 
			Me.colTitle.Caption = "Title"
			Me.colTitle.FieldName = "Title"
			Me.colTitle.Name = "colTitle"
			Me.colTitle.RowIndex = 2
			Me.colTitle.Visible = True
			Me.colTitle.Width = 267
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Address"
			Me.gridBand1.Columns.Add(Me.colRegion)
			Me.gridBand1.Columns.Add(Me.colCountry)
			Me.gridBand1.Columns.Add(Me.colCity)
			Me.gridBand1.Columns.Add(Me.colExtension)
			Me.gridBand1.Columns.Add(Me.colHomePhone)
			Me.gridBand1.Columns.Add(Me.colPostalCode)
			Me.gridBand1.Columns.Add(Me.colAddress)
			Me.gridBand1.ImageIndex = 0
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 304
			' 
			' colRegion
			' 
			Me.colRegion.Caption = "Region"
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.Width = 80
			' 
			' colCountry
			' 
			Me.colCountry.Caption = "Country"
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.Width = 88
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.Width = 136
			' 
			' colExtension
			' 
			Me.colExtension.Caption = "Extension"
			Me.colExtension.FieldName = "Extension"
			Me.colExtension.Name = "colExtension"
			Me.colExtension.RowIndex = 1
			Me.colExtension.Visible = True
			Me.colExtension.Width = 80
			' 
			' colHomePhone
			' 
			Me.colHomePhone.Caption = "Home Phone"
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.Name = "colHomePhone"
			Me.colHomePhone.RowIndex = 1
			Me.colHomePhone.Visible = True
			Me.colHomePhone.Width = 224
			' 
			' colPostalCode
			' 
			Me.colPostalCode.Caption = "Postal Code"
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.RowIndex = 2
			Me.colPostalCode.Visible = True
			Me.colPostalCode.Width = 80
			' 
			' colAddress
			' 
			Me.colAddress.Caption = "Address"
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.RowIndex = 2
			Me.colAddress.Visible = True
			Me.colAddress.Width = 224
			' 
			' xtraGridBlending1
			' 
			Me.xtraGridBlending1.GridControl = Me.gridControl1
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.cbeStyles)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Controls.Add(Me.cbeImages)
			Me.panelControl1.Controls.Add(Me.btnEditAlphaBlending)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.chAlphaBlending)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(832, 70)
			Me.panelControl1.TabIndex = 4
			' 
			' cbeStyles
			' 
			Me.cbeStyles.EditValue = ""
			Me.cbeStyles.Location = New System.Drawing.Point(404, 34)
			Me.cbeStyles.Name = "cbeStyles"
			Me.cbeStyles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeStyles.Properties.DropDownRows = 20
			Me.cbeStyles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeStyles.Size = New System.Drawing.Size(196, 20)
			Me.cbeStyles.TabIndex = 21
'			Me.cbeStyles.SelectedIndexChanged += New System.EventHandler(Me.cbeStyles_SelectedIndexChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(401, 14)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(75, 13)
			Me.label2.TabIndex = 20
			Me.label2.Text = "Style Scheme:"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' cbeImages
			' 
			Me.cbeImages.EditValue = ""
			Me.cbeImages.Location = New System.Drawing.Point(172, 34)
			Me.cbeImages.Name = "cbeImages"
			Me.cbeImages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeImages.Properties.Items.AddRange(New Object() { "(None)", "Blue", "Green", "Pink", "Yellow", "World"})
			Me.cbeImages.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeImages.Size = New System.Drawing.Size(196, 20)
			Me.cbeImages.TabIndex = 19
'			Me.cbeImages.SelectedIndexChanged += New System.EventHandler(Me.cbeImages_SelectedIndexChanged)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(169, 14)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Background Image:"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 70)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(832, 8)
			Me.panelControl2.TabIndex = 5
			' 
			' AlphaBlending
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "AlphaBlending"
			Me.Size = New System.Drawing.Size(832, 465)
'			Me.Load += New System.EventHandler(Me.AlphaBlending_Load)
			CType(Me.chAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.cbeStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private imageList1 As System.Windows.Forms.ImageList
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private xtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
		Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colBirthDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCountry As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colExtension As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHireDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHomePhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPostalCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colRegion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTitleOfCourtesy As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private components As System.ComponentModel.IContainer
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents chAlphaBlending As DevExpress.XtraEditors.CheckEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private label1 As System.Windows.Forms.Label
		Private WithEvents cbeImages As DevExpress.XtraEditors.ComboBoxEdit
		Private label2 As System.Windows.Forms.Label
		Private WithEvents cbeStyles As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents btnEditAlphaBlending As DevExpress.XtraEditors.SimpleButton
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
