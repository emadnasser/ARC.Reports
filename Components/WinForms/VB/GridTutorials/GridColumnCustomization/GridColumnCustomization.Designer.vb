Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridColumnCustomization
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridColumnCustomization))
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCompany = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colState = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.colZipCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colTime = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
			Me.colCustomer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHomePhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFaxPhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPurchaseDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPaymentType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.colPaymentAmount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.colCopies = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.checkEdit3)
			Me.panel1.Controls.Add(Me.checkEdit2)
			Me.panel1.Controls.Add(Me.checkEdit1)
			Me.panel1.Controls.Add(Me.simpleButton1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(594, 78)
			Me.panel1.TabIndex = 3
			' 
			' checkEdit3
			' 
			Me.checkEdit3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit3.Location = New System.Drawing.Point(376, 51)
			Me.checkEdit3.Name = "checkEdit3"
			Me.checkEdit3.Properties.Caption = "Show Bands In Customization Form"
			Me.checkEdit3.Size = New System.Drawing.Size(208, 19)
			Me.checkEdit3.TabIndex = 3
'			Me.checkEdit3.CheckedChanged += New System.EventHandler(Me.checkEdit3_CheckedChanged);
			' 
			' checkEdit2
			' 
			Me.checkEdit2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit2.Location = New System.Drawing.Point(376, 31)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "Allow Change Band Parent"
			Me.checkEdit2.Size = New System.Drawing.Size(208, 19)
			Me.checkEdit2.TabIndex = 2
'			Me.checkEdit2.CheckedChanged += New System.EventHandler(Me.checkEdit2_CheckedChanged);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEdit1.Location = New System.Drawing.Point(376, 11)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Allow Change Column Parent"
			Me.checkEdit1.Size = New System.Drawing.Size(208, 19)
			Me.checkEdit1.TabIndex = 1
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(8, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(211, 24)
			Me.simpleButton1.TabIndex = 0
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 86)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit1, Me.repositoryItemTimeEdit1, Me.repositoryItemSpinEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(594, 330)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1})
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Appearance.RowSeparator.BackColor = System.Drawing.SystemColors.ControlDark
			Me.advBandedGridView1.Appearance.RowSeparator.Options.UseBackColor = True
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand6, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colID, Me.colFirstName, Me.colLastName, Me.colCompany, Me.colAddress, Me.colCity, Me.colState, Me.colZipCode, Me.colCustomer, Me.colPurchaseDate, Me.colHomePhone, Me.colFaxPhone, Me.colPaymentType, Me.colPaymentAmount, Me.colCopies, Me.colTime})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Images = Me.imageList1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsCustomization.AllowChangeColumnParent = True
			Me.advBandedGridView1.RowSeparatorHeight = 1
'			Me.advBandedGridView1.ShowCustomizationForm += New System.EventHandler(Me.advBandedGridView1_ShowCustomizationForm);
'			Me.advBandedGridView1.HideCustomizationForm += New System.EventHandler(Me.advBandedGridView1_HideCustomizationForm);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Customer"
			Me.gridBand1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand3, Me.gridBand4, Me.gridBand5})
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 430
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Name"
			Me.gridBand3.Columns.Add(Me.colID)
			Me.gridBand3.Columns.Add(Me.colFirstName)
			Me.gridBand3.Columns.Add(Me.colLastName)
			Me.gridBand3.ImageIndex = 2
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 178
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Width = 47
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "First Name"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.Width = 178
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "Last Name"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.RowIndex = 1
			Me.colLastName.Visible = True
			Me.colLastName.Width = 178
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "Company"
			Me.gridBand4.Columns.Add(Me.colCompany)
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Visible = False
			Me.gridBand4.Width = 108
			' 
			' colCompany
			' 
			Me.colCompany.AutoFillDown = True
			Me.colCompany.Caption = "Company"
			Me.colCompany.FieldName = "Company"
			Me.colCompany.Name = "colCompany"
			Me.colCompany.Visible = True
			Me.colCompany.Width = 108
			' 
			' gridBand5
			' 
			Me.gridBand5.Caption = "Address"
			Me.gridBand5.Columns.Add(Me.colAddress)
			Me.gridBand5.Columns.Add(Me.colCity)
			Me.gridBand5.Columns.Add(Me.colState)
			Me.gridBand5.Columns.Add(Me.colZipCode)
			Me.gridBand5.Name = "gridBand5"
			Me.gridBand5.Width = 252
			' 
			' colAddress
			' 
			Me.colAddress.Caption = "Address"
			Me.colAddress.FieldName = "Address"
			Me.colAddress.ImageIndex = 1
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.Width = 252
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.RowIndex = 1
			Me.colCity.Visible = True
			Me.colCity.Width = 109
			' 
			' colState
			' 
			Me.colState.Caption = "State"
			Me.colState.ColumnEdit = Me.repositoryItemComboBox1
			Me.colState.FieldName = "State"
			Me.colState.Name = "colState"
			Me.colState.RowIndex = 1
			Me.colState.Visible = True
			Me.colState.Width = 143
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "AK", "BC", "CA", "Co. Cork", "CT", "DF", "GA", "ID", "IL", "Isle of Wight", "Lara", "MI", "MT", "NJ", "NM", "Nueva Esparta", "NY", "OH", "OK", "OR", "Quebec", "RJ", "SP", "Tachira", "WA", "WY"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' colZipCode
			' 
			Me.colZipCode.Caption = "Zip Code"
			Me.colZipCode.FieldName = "ZipCode"
			Me.colZipCode.ImageIndex = 5
			Me.colZipCode.Name = "colZipCode"
			Me.colZipCode.RowIndex = 1
			Me.colZipCode.Width = 46
			' 
			' gridBand6
			' 
			Me.gridBand6.Caption = "Other"
			Me.gridBand6.Columns.Add(Me.colTime)
			Me.gridBand6.Columns.Add(Me.colCustomer)
			Me.gridBand6.Columns.Add(Me.colHomePhone)
			Me.gridBand6.Columns.Add(Me.colFaxPhone)
			Me.gridBand6.ImageIndex = 4
			Me.gridBand6.Name = "gridBand6"
			Me.gridBand6.Visible = False
			Me.gridBand6.Width = 187
			' 
			' colTime
			' 
			Me.colTime.Caption = "Time"
			Me.colTime.ColumnEdit = Me.repositoryItemTimeEdit1
			Me.colTime.FieldName = "Time"
			Me.colTime.ImageIndex = 6
			Me.colTime.Name = "colTime"
			Me.colTime.Width = 109
			' 
			' repositoryItemTimeEdit1
			' 
			Me.repositoryItemTimeEdit1.AutoHeight = False
			Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
			' 
			' colCustomer
			' 
			Me.colCustomer.Caption = "Customer"
			Me.colCustomer.FieldName = "Customer"
			Me.colCustomer.Name = "colCustomer"
			Me.colCustomer.Visible = True
			Me.colCustomer.Width = 78
			' 
			' colHomePhone
			' 
			Me.colHomePhone.Caption = "Home Phone"
			Me.colHomePhone.FieldName = "HomePhone"
			Me.colHomePhone.ImageIndex = 0
			Me.colHomePhone.Name = "colHomePhone"
			Me.colHomePhone.RowIndex = 1
			Me.colHomePhone.Visible = True
			Me.colHomePhone.Width = 187
			' 
			' colFaxPhone
			' 
			Me.colFaxPhone.Caption = "Fax Phone"
			Me.colFaxPhone.FieldName = "FaxPhone"
			Me.colFaxPhone.Name = "colFaxPhone"
			Me.colFaxPhone.RowIndex = 2
			Me.colFaxPhone.Width = 187
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Payment"
			Me.gridBand2.Columns.Add(Me.colPurchaseDate)
			Me.gridBand2.Columns.Add(Me.colPaymentType)
			Me.gridBand2.Columns.Add(Me.colPaymentAmount)
			Me.gridBand2.Columns.Add(Me.colCopies)
			Me.gridBand2.ImageIndex = 3
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 314
			' 
			' colPurchaseDate
			' 
			Me.colPurchaseDate.Caption = "Purchase Date"
			Me.colPurchaseDate.FieldName = "PurchaseDate"
			Me.colPurchaseDate.Name = "colPurchaseDate"
			Me.colPurchaseDate.Visible = True
			Me.colPurchaseDate.Width = 314
			' 
			' colPaymentType
			' 
			Me.colPaymentType.Caption = "Payment Type"
			Me.colPaymentType.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colPaymentType.FieldName = "PaymentType"
			Me.colPaymentType.Name = "colPaymentType"
			Me.colPaymentType.RowIndex = 1
			Me.colPaymentType.Visible = True
			Me.colPaymentType.Width = 163
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("American Express", "AMEX", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", "CASH", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Master", "MASTER", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", "VISA", 3)})
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
			' 
			' colPaymentAmount
			' 
			Me.colPaymentAmount.Caption = "Payment Amount"
			Me.colPaymentAmount.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colPaymentAmount.DisplayFormat.FormatString = "c"
			Me.colPaymentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPaymentAmount.FieldName = "PaymentAmount"
			Me.colPaymentAmount.Name = "colPaymentAmount"
			Me.colPaymentAmount.RowIndex = 1
			Me.colPaymentAmount.Visible = True
			Me.colPaymentAmount.Width = 151
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' colCopies
			' 
			Me.colCopies.Caption = "Copies"
			Me.colCopies.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.colCopies.FieldName = "Copies"
			Me.colCopies.Name = "colCopies"
			Me.colCopies.RowIndex = 2
			Me.colCopies.Width = 235
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 78)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(594, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' GridColumnCustomization
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "GridColumnCustomization"
			Me.Size = New System.Drawing.Size(594, 416)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridColumnCustomization_Load);
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCompany As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colState As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colZipCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCustomer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPurchaseDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHomePhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colFaxPhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPaymentType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPaymentAmount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCopies As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTime As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.IContainer
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
