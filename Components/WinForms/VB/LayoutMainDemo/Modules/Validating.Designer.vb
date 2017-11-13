Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class Validating
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Validating))
            Me.dsCategories1 = New dsCategories()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.subTotalTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.discountSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.orderUnitPriceCalcEdit = New DevExpress.XtraEditors.CalcEdit()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.unitsOnOrderSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.unitsInStockSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.reorderLevelSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.productsUnitPriceCalcEdit = New DevExpress.XtraEditors.CalcEdit()
            Me.quantityPerUnitTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.supplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
            Me.productNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.dataNavigator2 = New DevExpress.XtraEditors.DataNavigator()
            Me.orderIdTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.quantitySpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.dataNavigator3 = New DevExpress.XtraEditors.DataNavigator()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
            CType(Me.dsCategories1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.subTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.discountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.orderUnitPriceCalcEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitsOnOrderSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.unitsInStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.reorderLevelSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productsUnitPriceCalcEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.quantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.supplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.productNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.orderIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.quantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dsCategories1
            '
            Me.dsCategories1.DataSetName = "dsCategories"
            Me.dsCategories1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsCategories1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.subTotalTextEdit)
            Me.layoutControl1.Controls.Add(Me.discountSpinEdit)
            Me.layoutControl1.Controls.Add(Me.orderUnitPriceCalcEdit)
            Me.layoutControl1.Controls.Add(Me.checkEdit1)
            Me.layoutControl1.Controls.Add(Me.unitsOnOrderSpinEdit)
            Me.layoutControl1.Controls.Add(Me.unitsInStockSpinEdit)
            Me.layoutControl1.Controls.Add(Me.reorderLevelSpinEdit)
            Me.layoutControl1.Controls.Add(Me.productsUnitPriceCalcEdit)
            Me.layoutControl1.Controls.Add(Me.quantityPerUnitTextEdit)
            Me.layoutControl1.Controls.Add(Me.supplierLookUpEdit)
            Me.layoutControl1.Controls.Add(Me.productNameTextEdit)
            Me.layoutControl1.Controls.Add(Me.dataNavigator2)
            Me.layoutControl1.Controls.Add(Me.orderIdTextEdit)
            Me.layoutControl1.Controls.Add(Me.quantitySpinEdit)
            Me.layoutControl1.Controls.Add(Me.dataNavigator3)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(725, 512)
            Me.layoutControl1.TabIndex = 6
            Me.layoutControl1.Text = "layoutControl1"
            '
            'subTotalTextEdit
            '
            Me.subTotalTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.ProductsOrder_x0020_Details.SubTotal", True))
            Me.subTotalTextEdit.EditValue = "textEdit5"
            Me.subTotalTextEdit.Location = New System.Drawing.Point(110, 456)
            Me.subTotalTextEdit.Name = "subTotalTextEdit"
            Me.subTotalTextEdit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.subTotalTextEdit.Properties.Appearance.Options.UseBackColor = True
            Me.subTotalTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.subTotalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.subTotalTextEdit.Properties.Mask.EditMask = "c"
            Me.subTotalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.subTotalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.subTotalTextEdit.Properties.ReadOnly = True
            Me.subTotalTextEdit.Size = New System.Drawing.Size(584, 20)
            Me.subTotalTextEdit.StyleController = Me.layoutControl1
            Me.subTotalTextEdit.TabIndex = 17
            '
            'discountSpinEdit
            '
            Me.discountSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.ProductsOrder_x0020_Details.Discount", True))
            Me.discountSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.discountSpinEdit.Location = New System.Drawing.Point(110, 366)
            Me.discountSpinEdit.Name = "discountSpinEdit"
            Me.discountSpinEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.discountSpinEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.discountSpinEdit.Properties.Mask.EditMask = "p"
            Me.discountSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.discountSpinEdit.Properties.ValidateOnEnterKey = True
            Me.discountSpinEdit.Size = New System.Drawing.Size(584, 20)
            Me.discountSpinEdit.StyleController = Me.layoutControl1
            Me.discountSpinEdit.TabIndex = 16
            Me.discountSpinEdit.Tag = "Discount"
            Me.discountSpinEdit.ToolTip = "This field value can't be larger than 50%"
            '
            'orderUnitPriceCalcEdit
            '
            Me.orderUnitPriceCalcEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.ProductsOrder_x0020_Details.UnitPrice", True))
            Me.orderUnitPriceCalcEdit.EditValue = CType(resources.GetObject("orderUnitPriceCalcEdit.EditValue"), Object)
            Me.orderUnitPriceCalcEdit.Location = New System.Drawing.Point(110, 426)
            Me.orderUnitPriceCalcEdit.Name = "orderUnitPriceCalcEdit"
            Me.orderUnitPriceCalcEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.orderUnitPriceCalcEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.orderUnitPriceCalcEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.orderUnitPriceCalcEdit.Properties.Mask.EditMask = "c"
            Me.orderUnitPriceCalcEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.orderUnitPriceCalcEdit.Properties.ValidateOnEnterKey = True
            Me.orderUnitPriceCalcEdit.Size = New System.Drawing.Size(584, 20)
            Me.orderUnitPriceCalcEdit.StyleController = Me.layoutControl1
            Me.orderUnitPriceCalcEdit.TabIndex = 15
            Me.orderUnitPriceCalcEdit.Tag = "Unit Price"
            Me.orderUnitPriceCalcEdit.ToolTip = "This field value can't be less than 0"
            '
            'checkEdit1
            '
            Me.checkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.Discontinued", True))
            Me.checkEdit1.EditValue = CType(resources.GetObject("checkEdit1.EditValue"), Object)
            Me.checkEdit1.Location = New System.Drawing.Point(14, 248)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Discontinued"
            Me.checkEdit1.Size = New System.Drawing.Size(680, 19)
            Me.checkEdit1.StyleController = Me.layoutControl1
            Me.checkEdit1.TabIndex = 14
            Me.checkEdit1.TabStop = False
            '
            'unitsOnOrderSpinEdit
            '
            Me.unitsOnOrderSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.UnitsOnOrder", True))
            Me.unitsOnOrderSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.unitsOnOrderSpinEdit.Location = New System.Drawing.Point(110, 218)
            Me.unitsOnOrderSpinEdit.Name = "unitsOnOrderSpinEdit"
            Me.unitsOnOrderSpinEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.unitsOnOrderSpinEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.unitsOnOrderSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.unitsOnOrderSpinEdit.Properties.IsFloatValue = False
            Me.unitsOnOrderSpinEdit.Properties.Mask.EditMask = "N00"
            Me.unitsOnOrderSpinEdit.Size = New System.Drawing.Size(584, 20)
            Me.unitsOnOrderSpinEdit.StyleController = Me.layoutControl1
            Me.unitsOnOrderSpinEdit.TabIndex = 13
            Me.unitsOnOrderSpinEdit.Tag = "Units On Order"
            Me.unitsOnOrderSpinEdit.ToolTip = "This field value can't be less than 0"
            '
            'unitsInStockSpinEdit
            '
            Me.unitsInStockSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.UnitsInStock", True))
            Me.unitsInStockSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.unitsInStockSpinEdit.Location = New System.Drawing.Point(110, 158)
            Me.unitsInStockSpinEdit.Name = "unitsInStockSpinEdit"
            Me.unitsInStockSpinEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.unitsInStockSpinEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.unitsInStockSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.unitsInStockSpinEdit.Properties.IsFloatValue = False
            Me.unitsInStockSpinEdit.Properties.Mask.EditMask = "N00"
            Me.unitsInStockSpinEdit.Size = New System.Drawing.Size(584, 20)
            Me.unitsInStockSpinEdit.StyleController = Me.layoutControl1
            Me.unitsInStockSpinEdit.TabIndex = 12
            Me.unitsInStockSpinEdit.Tag = "Units In Stock"
            Me.unitsInStockSpinEdit.ToolTip = "This field value can't be less than 0"
            '
            'reorderLevelSpinEdit
            '
            Me.reorderLevelSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.ReorderLevel", True))
            Me.reorderLevelSpinEdit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.reorderLevelSpinEdit.Location = New System.Drawing.Point(110, 188)
            Me.reorderLevelSpinEdit.Name = "reorderLevelSpinEdit"
            Me.reorderLevelSpinEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.reorderLevelSpinEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.reorderLevelSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.reorderLevelSpinEdit.Properties.IsFloatValue = False
            Me.reorderLevelSpinEdit.Properties.Mask.EditMask = "N00"
            Me.reorderLevelSpinEdit.Size = New System.Drawing.Size(584, 20)
            Me.reorderLevelSpinEdit.StyleController = Me.layoutControl1
            Me.reorderLevelSpinEdit.TabIndex = 11
            Me.reorderLevelSpinEdit.Tag = "Reorder Level"
            Me.reorderLevelSpinEdit.ToolTip = "This field value can't be less than 0"
            '
            'productsUnitPriceCalcEdit
            '
            Me.productsUnitPriceCalcEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.UnitPrice", True))
            Me.productsUnitPriceCalcEdit.EditValue = CType(resources.GetObject("productsUnitPriceCalcEdit.EditValue"), Object)
            Me.productsUnitPriceCalcEdit.Location = New System.Drawing.Point(110, 128)
            Me.productsUnitPriceCalcEdit.Name = "productsUnitPriceCalcEdit"
            Me.productsUnitPriceCalcEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.productsUnitPriceCalcEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.productsUnitPriceCalcEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.productsUnitPriceCalcEdit.Properties.Mask.EditMask = "c"
            Me.productsUnitPriceCalcEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.productsUnitPriceCalcEdit.Size = New System.Drawing.Size(584, 20)
            Me.productsUnitPriceCalcEdit.StyleController = Me.layoutControl1
            Me.productsUnitPriceCalcEdit.TabIndex = 10
            Me.productsUnitPriceCalcEdit.Tag = "Unit Price"
            Me.productsUnitPriceCalcEdit.ToolTip = "This field value can't be less than 0"
            '
            'quantityPerUnitTextEdit
            '
            Me.quantityPerUnitTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCategories1, "Categories.CategoriesProducts.QuantityPerUnit", True))
            Me.quantityPerUnitTextEdit.Location = New System.Drawing.Point(110, 98)
            Me.quantityPerUnitTextEdit.Name = "quantityPerUnitTextEdit"
            Me.quantityPerUnitTextEdit.Size = New System.Drawing.Size(584, 20)
            Me.quantityPerUnitTextEdit.StyleController = Me.layoutControl1
            Me.quantityPerUnitTextEdit.TabIndex = 9
            '
            'supplierLookUpEdit
            '
            Me.supplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.SupplierID", True))
            Me.supplierLookUpEdit.EditValue = CType(resources.GetObject("supplierLookUpEdit.EditValue"), Object)
            Me.supplierLookUpEdit.Location = New System.Drawing.Point(110, 68)
            Me.supplierLookUpEdit.Name = "supplierLookUpEdit"
            Me.supplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.supplierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
            Me.supplierLookUpEdit.Properties.DataSource = Me.dsCategories1.Suppliers
            Me.supplierLookUpEdit.Properties.DisplayMember = "CompanyName"
            Me.supplierLookUpEdit.Properties.PopupWidth = 400
            Me.supplierLookUpEdit.Properties.ValueMember = "SupplierID"
            Me.supplierLookUpEdit.Size = New System.Drawing.Size(584, 20)
            Me.supplierLookUpEdit.StyleController = Me.layoutControl1
            Me.supplierLookUpEdit.TabIndex = 8
            '
            'productNameTextEdit
            '
            Me.productNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCategories1, "Categories.CategoriesProducts.ProductName", True))
            Me.productNameTextEdit.Location = New System.Drawing.Point(110, 38)
            Me.productNameTextEdit.Name = "productNameTextEdit"
            Me.productNameTextEdit.Size = New System.Drawing.Size(584, 20)
            Me.productNameTextEdit.StyleController = Me.layoutControl1
            Me.productNameTextEdit.TabIndex = 1
            Me.productNameTextEdit.Tag = "Product Name"
            Me.productNameTextEdit.ToolTip = "This field can't be empty"
            '
            'dataNavigator2
            '
            Me.dataNavigator2.Buttons.NextPage.Visible = False
            Me.dataNavigator2.Buttons.PrevPage.Visible = False
            Me.dataNavigator2.DataMember = "Categories.CategoriesProducts"
            Me.dataNavigator2.DataSource = Me.dsCategories1
            Me.dataNavigator2.Location = New System.Drawing.Point(14, 277)
            Me.dataNavigator2.Name = "dataNavigator2"
            Me.dataNavigator2.Size = New System.Drawing.Size(291, 19)
            Me.dataNavigator2.StyleController = Me.layoutControl1
            Me.dataNavigator2.TabIndex = 4
            Me.dataNavigator2.Text = "dataNavigator2"
            Me.dataNavigator2.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            Me.dataNavigator2.TextStringFormat = "Product {0} of {1}"
            '
            'orderIdTextEdit
            '
            Me.orderIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCategories1, "Categories.CategoriesProducts.ProductsOrder_x0020_Details.OrderID", True))
            Me.orderIdTextEdit.EditValue = "textEdit3"
            Me.orderIdTextEdit.Location = New System.Drawing.Point(110, 336)
            Me.orderIdTextEdit.Name = "orderIdTextEdit"
            Me.orderIdTextEdit.Size = New System.Drawing.Size(52, 20)
            Me.orderIdTextEdit.StyleController = Me.layoutControl1
            Me.orderIdTextEdit.TabIndex = 2
            '
            'quantitySpinEdit
            '
            Me.quantitySpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories1, "Categories.CategoriesProducts.ProductsOrder_x0020_Details.Quantity", True))
            Me.quantitySpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.quantitySpinEdit.Location = New System.Drawing.Point(110, 396)
            Me.quantitySpinEdit.Name = "quantitySpinEdit"
            Me.quantitySpinEdit.Properties.AppearanceDisabled.Options.UseTextOptions = True
            Me.quantitySpinEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.quantitySpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.quantitySpinEdit.Properties.IsFloatValue = False
            Me.quantitySpinEdit.Properties.Mask.EditMask = "N00"
            Me.quantitySpinEdit.Properties.ValidateOnEnterKey = True
            Me.quantitySpinEdit.Size = New System.Drawing.Size(584, 20)
            Me.quantitySpinEdit.StyleController = Me.layoutControl1
            Me.quantitySpinEdit.TabIndex = 12
            Me.quantitySpinEdit.Tag = "Quantity"
            Me.quantitySpinEdit.ToolTip = "This field value can't be less than 0"
            '
            'dataNavigator3
            '
            Me.dataNavigator3.Buttons.NextPage.Visible = False
            Me.dataNavigator3.Buttons.PrevPage.Visible = False
            Me.dataNavigator3.DataMember = "Categories.CategoriesProducts.ProductsOrder_x0020_Details"
            Me.dataNavigator3.DataSource = Me.dsCategories1
            Me.dataNavigator3.Location = New System.Drawing.Point(14, 486)
            Me.dataNavigator3.Name = "dataNavigator3"
            Me.dataNavigator3.Size = New System.Drawing.Size(286, 19)
            Me.dataNavigator3.StyleController = Me.layoutControl1
            Me.dataNavigator3.TabIndex = 7
            Me.dataNavigator3.Text = "dataNavigator3"
            Me.dataNavigator3.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(708, 519)
            Me.layoutControlGroup1.Text = "Group"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlGroup3
            '
            Me.layoutControlGroup3.CaptionImage = CType(resources.GetObject("layoutControlGroup3.CaptionImage"), System.Drawing.Image)
            Me.layoutControlGroup3.CaptionImageIndex = 6
            Me.layoutControlGroup3.ExpandButtonVisible = True
            Me.layoutControlGroup3.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem9, Me.layoutControlItem11, Me.layoutControlItem13, Me.layoutControlItem12, Me.layoutControlItem14, Me.layoutControlItem7, Me.layoutControlItem4, Me.layoutControlItem10})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(696, 298)
            Me.layoutControlGroup3.Text = "Products"
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.productNameTextEdit
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem3.Text = "*Product Name: "
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.supplierLookUpEdit
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 30)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem9.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem9.Text = "Supplier:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.Control = Me.productsUnitPriceCalcEdit
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem11.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem11.Text = "*Unit Price:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem13
            '
            Me.layoutControlItem13.Control = Me.unitsInStockSpinEdit
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem13.Name = "layoutControlItem13"
            Me.layoutControlItem13.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem13.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem13.Text = "*Units In Stock:"
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.Control = Me.reorderLevelSpinEdit
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 150)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem12.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem12.Text = "*Reorder Level:"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem14
            '
            Me.layoutControlItem14.Control = Me.unitsOnOrderSpinEdit
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 180)
            Me.layoutControlItem14.Name = "layoutControlItem14"
            Me.layoutControlItem14.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem14.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem14.Text = "*Units On Order:"
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.checkEdit1
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 210)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem7.Size = New System.Drawing.Size(690, 29)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            '
            'layoutControlItem4
            '
            Me.layoutControlItem4.Control = Me.dataNavigator2
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 239)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(690, 29)
            Me.layoutControlItem4.Text = "DataNavigator"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.quantityPerUnitTextEdit
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem10.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem10.Text = "Quantity Per Unit:  "
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlGroup4
            '
            Me.layoutControlGroup4.CaptionImage = CType(resources.GetObject("layoutControlGroup4.CaptionImage"), System.Drawing.Image)
            Me.layoutControlGroup4.CaptionImageIndex = 7
            Me.layoutControlGroup4.ExpandButtonVisible = True
            Me.layoutControlGroup4.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem18, Me.layoutControlItem1, Me.layoutControlItem16, Me.layoutControlItem2, Me.layoutControlItem6})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 298)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(696, 209)
            Me.layoutControlGroup4.Text = "Order Details"
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.orderIdTextEdit
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(158, 30)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(158, 30)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.Text = "Order ID:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.Control = Me.discountSpinEdit
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 30)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem18.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem18.Text = "*Discount:"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.quantitySpinEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem1.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem1.Text = "*Quantity:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem16
            '
            Me.layoutControlItem16.Control = Me.orderUnitPriceCalcEdit
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlItem16.Name = "layoutControlItem16"
            Me.layoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem16.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem16.Text = "*Unit Price:"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.subTotalTextEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem2.Size = New System.Drawing.Size(690, 30)
            Me.layoutControlItem2.Text = "Sub Total:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(93, 13)
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.dataNavigator3
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 150)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(690, 29)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            '
            'dxErrorProvider1
            '
            Me.dxErrorProvider1.ContainerControl = Me.layoutControl1
            Me.dxErrorProvider1.DataMember = ""
            '
            'Validating
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Validating"
            Me.Size = New System.Drawing.Size(725, 512)
            CType(Me.dsCategories1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.subTotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.discountSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.orderUnitPriceCalcEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitsOnOrderSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.unitsInStockSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.reorderLevelSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productsUnitPriceCalcEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.quantityPerUnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.supplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.productNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.orderIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.quantitySpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents dataNavigator2 As DevExpress.XtraEditors.DataNavigator
        Private dsCategories1 As dsCategories
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private layoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents dataNavigator3 As DevExpress.XtraEditors.DataNavigator
		Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private dxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
		Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
		Private subTotalTextEdit As DevExpress.XtraEditors.TextEdit
		Private WithEvents discountSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private WithEvents orderUnitPriceCalcEdit As DevExpress.XtraEditors.CalcEdit
		Private WithEvents unitsOnOrderSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private WithEvents unitsInStockSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private WithEvents reorderLevelSpinEdit As DevExpress.XtraEditors.SpinEdit
		Private WithEvents productsUnitPriceCalcEdit As DevExpress.XtraEditors.CalcEdit
		Private supplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
		Private WithEvents productNameTextEdit As DevExpress.XtraEditors.TextEdit
		Private orderIdTextEdit As DevExpress.XtraEditors.TextEdit
		Private WithEvents quantitySpinEdit As DevExpress.XtraEditors.SpinEdit
		Private quantityPerUnitTextEdit As DevExpress.XtraEditors.TextEdit
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
