Namespace DevExpress.XtraGrid.Demos
	Partial Public Class FixedColumns
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FixedColumns))
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.label5 = New System.Windows.Forms.Label()
			Me.numFixedLineWidth1 = New DevExpress.XtraEditors.SpinEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.icbFixedStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.icbColumn = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numFixedLineWidth1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.icbFixedStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbColumn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl2
			' 
			resources.ApplyResources(Me.gridControl2, "gridControl2")
			Me.gridControl2.MainView = Me.gridView1
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemComboBox2})
			Me.gridControl2.ShowOnlyPredefinedDetails = True
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
			Me.gridView1.GridControl = Me.gridControl2
			Me.gridView1.GroupCount = 1
			Me.gridView1.HorzScrollStep = 30
			Me.gridView1.Images = Me.imageCollection1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
			Me.gridView1.OptionsPrint.AutoWidth = False
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colContactTitle, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.gridView1_PopupMenuShowing)
			' 
			' colCustomerID
			' 
			resources.ApplyResources(Me.colCustomerID, "colCustomerID")
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.OptionsFilter.AllowFilter = False
			' 
			' colCompanyName
			' 
			resources.ApplyResources(Me.colCompanyName, "colCompanyName")
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colCompanyName.Summary"), DevExpress.Data.SummaryItemType)))})
			' 
			' colContactName
			' 
			resources.ApplyResources(Me.colContactName, "colContactName")
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			' 
			' colContactTitle
			' 
			resources.ApplyResources(Me.colContactTitle, "colContactTitle")
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			' 
			' colAddress
			' 
			resources.ApplyResources(Me.colAddress, "colAddress")
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			' 
			' colCity
			' 
			resources.ApplyResources(Me.colCity, "colCity")
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			' 
			' colRegion
			' 
			resources.ApplyResources(Me.colRegion, "colRegion")
			Me.colRegion.ColumnEdit = Me.repositoryItemComboBox1
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			' 
			' repositoryItemComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17")})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' colPostalCode
			' 
			resources.ApplyResources(Me.colPostalCode, "colPostalCode")
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			' 
			' colCountry
			' 
			resources.ApplyResources(Me.colCountry, "colCountry")
			Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			' 
			' repositoryItemComboBox2
			' 
			resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
			Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemComboBox2.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
			Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
			' 
			' colPhone
			' 
			resources.ApplyResources(Me.colPhone, "colPhone")
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			' 
			' colFax
			' 
			resources.ApplyResources(Me.colFax, "colFax")
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "customer-16x16.png")
			Me.imageCollection1.Images.SetKeyName(1, "Home_16x16.png")
			Me.imageCollection1.Images.SetKeyName(2, "organization-16x16.png")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl2, "panelControl2")
			Me.panelControl2.Name = "panelControl2"
			' 
			' label5
			' 
			resources.ApplyResources(Me.label5, "label5")
			Me.label5.Name = "label5"
			' 
			' numFixedLineWidth1
			' 
			resources.ApplyResources(Me.numFixedLineWidth1, "numFixedLineWidth1")
			Me.numFixedLineWidth1.Name = "numFixedLineWidth1"
			Me.numFixedLineWidth1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.numFixedLineWidth1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.numFixedLineWidth1.Properties.IsFloatValue = False
			Me.numFixedLineWidth1.Properties.Mask.EditMask = resources.GetString("numFixedLineWidth1.Properties.Mask.EditMask")
			Me.numFixedLineWidth1.Properties.MaxValue = New Decimal(New Integer() { 12, 0, 0, 0})
			Me.numFixedLineWidth1.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
'			Me.numFixedLineWidth1.EditValueChanged += New System.EventHandler(Me.numFixedLineWidth1_ValueChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.icbFixedStyle)
			Me.panelControl1.Controls.Add(Me.icbColumn)
			Me.panelControl1.Controls.Add(Me.label1)
			Me.panelControl1.Controls.Add(Me.numFixedLineWidth1)
			Me.panelControl1.Controls.Add(Me.label5)
			Me.panelControl1.Controls.Add(Me.label2)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' icbFixedStyle
			' 
			resources.ApplyResources(Me.icbFixedStyle, "icbFixedStyle")
			Me.icbFixedStyle.Name = "icbFixedStyle"
			Me.icbFixedStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbFixedStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
'			Me.icbFixedStyle.SelectedIndexChanged += New System.EventHandler(Me.icbFixedStyle_SelectedIndexChanged)
			' 
			' icbColumn
			' 
			resources.ApplyResources(Me.icbColumn, "icbColumn")
			Me.icbColumn.Name = "icbColumn"
			Me.icbColumn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbColumn.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.icbColumn.Properties.DropDownRows = 15
'			Me.icbColumn.SelectedIndexChanged += New System.EventHandler(Me.icbColumn_SelectedIndexChanged)
			' 
			' label1
			' 
			resources.ApplyResources(Me.label1, "label1")
			Me.label1.Name = "label1"
			' 
			' label2
			' 
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' FixedColumns
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "FixedColumns"
'			Me.Load += New System.EventHandler(Me.FixedColumns_Load)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numFixedLineWidth1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.icbFixedStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbColumn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colFax As DevExpress.XtraGrid.Columns.GridColumn
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private label5 As System.Windows.Forms.Label
		Private WithEvents numFixedLineWidth1 As XtraEditors.SpinEdit
		Private panelControl1 As XtraEditors.PanelControl
		Private WithEvents icbFixedStyle As XtraEditors.ImageComboBoxEdit
		Private WithEvents icbColumn As XtraEditors.ImageComboBoxEdit
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private imageCollection1 As Utils.ImageCollection
	End Class
End Namespace
