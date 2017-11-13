Namespace DevExpress.XtraLayout.Demos
    Partial Public Class LayoutWaybill
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lblcShipmentDetails = New DevExpress.XtraEditors.LabelControl()
            Me.tedShipCountry = New DevExpress.XtraEditors.TextEdit()
            Me.dsOrder = New DevExpress.XtraLayout.Demos.dsOrder()
            Me.tedShipAddress = New DevExpress.XtraEditors.TextEdit()
            Me.tedShipName = New DevExpress.XtraEditors.TextEdit()
            Me.tedShipDate = New DevExpress.XtraEditors.TextEdit()
            Me.pedLogo = New DevExpress.XtraEditors.PictureEdit()
            Me.gridOrders = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource()
            Me.gridViewOrders = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.dnNavigationCustomer = New DevExpress.XtraEditors.DataNavigator()
            Me.dnNavigationEmployee = New DevExpress.XtraEditors.DataNavigator()
            Me.tedCountryEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedPostalCodeEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedRegionEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedCityEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedAddressEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedContactTitleEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedContactNameEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedCompanyNameEmployee = New DevExpress.XtraEditors.TextEdit()
            Me.tedOrderID = New DevExpress.XtraEditors.TextEdit()
            Me.tedOrderDate = New DevExpress.XtraEditors.TextEdit()
            Me.dnNavigationOrders = New DevExpress.XtraEditors.DataNavigator()
            Me.tedLastNameCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedFirstNameCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedAddressCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedCityCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedRegionCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedPostalCodeCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedCountryCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.tedTitleCustomer = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupOrderInfo = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemOrderDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemNavigationOrder = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemOrderID = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupInfoCustomer = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLastNameCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAddressCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRegionCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemNavigationCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItemFirstNameCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPostalCodeCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemTitleCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemCityCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemCountryCustomer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupInfoEmployee = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemCompanyNameEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemContactNameEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAddressEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRegionEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemNavigationEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItemCityEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPostalEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemCountryEmployee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemContactTitleEmloyee = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupShipInfo = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemShopDate = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemShopAddress = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemShipCountry = New DevExpress.XtraLayout.LayoutControlItem()
            Me.shipNameLCI = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemLogo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.tedShipCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dsOrder, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedShipAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedShipName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedShipDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pedLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedCountryEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedPostalCodeEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedRegionEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedCityEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedAddressEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedContactTitleEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedContactNameEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedCompanyNameEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedOrderID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedOrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedLastNameCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedFirstNameCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedAddressCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedCityCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedRegionCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedPostalCodeCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedCountryCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tedTitleCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroupOrderInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemNavigationOrder, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroupInfoCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemLastNameCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemAddressCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemRegionCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemNavigationCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemFirstNameCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemPostalCodeCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemTitleCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemCityCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemCountryCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroupInfoEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemCompanyNameEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemContactNameEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemAddressEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemRegionEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemNavigationEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemCityEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemPostalEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemCountryEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemContactTitleEmloyee, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroupShipInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemShopDate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemShopAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemShipCountry, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.shipNameLCI, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItemLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.lblcShipmentDetails)
            Me.layoutControl1.Controls.Add(Me.tedShipCountry)
            Me.layoutControl1.Controls.Add(Me.tedShipAddress)
            Me.layoutControl1.Controls.Add(Me.tedShipName)
            Me.layoutControl1.Controls.Add(Me.tedShipDate)
            Me.layoutControl1.Controls.Add(Me.pedLogo)
            Me.layoutControl1.Controls.Add(Me.gridOrders)
            Me.layoutControl1.Controls.Add(Me.dnNavigationCustomer)
            Me.layoutControl1.Controls.Add(Me.dnNavigationEmployee)
            Me.layoutControl1.Controls.Add(Me.tedCountryEmployee)
            Me.layoutControl1.Controls.Add(Me.tedPostalCodeEmployee)
            Me.layoutControl1.Controls.Add(Me.tedRegionEmployee)
            Me.layoutControl1.Controls.Add(Me.tedCityEmployee)
            Me.layoutControl1.Controls.Add(Me.tedAddressEmployee)
            Me.layoutControl1.Controls.Add(Me.tedContactTitleEmployee)
            Me.layoutControl1.Controls.Add(Me.tedContactNameEmployee)
            Me.layoutControl1.Controls.Add(Me.tedCompanyNameEmployee)
            Me.layoutControl1.Controls.Add(Me.tedOrderID)
            Me.layoutControl1.Controls.Add(Me.tedOrderDate)
            Me.layoutControl1.Controls.Add(Me.dnNavigationOrders)
            Me.layoutControl1.Controls.Add(Me.tedLastNameCustomer)
            Me.layoutControl1.Controls.Add(Me.tedFirstNameCustomer)
            Me.layoutControl1.Controls.Add(Me.tedAddressCustomer)
            Me.layoutControl1.Controls.Add(Me.tedCityCustomer)
            Me.layoutControl1.Controls.Add(Me.tedRegionCustomer)
            Me.layoutControl1.Controls.Add(Me.tedPostalCodeCustomer)
            Me.layoutControl1.Controls.Add(Me.tedCountryCustomer)
            Me.layoutControl1.Controls.Add(Me.tedTitleCustomer)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2214, 46, 956, 917)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(968, 620)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl2"
            '
            'lblcShipmentDetails
            '
            Me.lblcShipmentDetails.Location = New System.Drawing.Point(24, 444)
            Me.lblcShipmentDetails.Name = "lblcShipmentDetails"
            Me.lblcShipmentDetails.Size = New System.Drawing.Size(94, 13)
            Me.lblcShipmentDetails.StyleController = Me.layoutControl1
            Me.lblcShipmentDetails.TabIndex = 47
            Me.lblcShipmentDetails.Text = "SHIPMENT DETAILS"
            '
            'tedShipCountry
            '
            Me.tedShipCountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.ShipCountry", True))
            Me.tedShipCountry.EditValue = ""
            Me.tedShipCountry.Location = New System.Drawing.Point(673, 38)
            Me.tedShipCountry.Name = "tedShipCountry"
            Me.tedShipCountry.Size = New System.Drawing.Size(281, 20)
            Me.tedShipCountry.StyleController = Me.layoutControl1
            Me.tedShipCountry.TabIndex = 34
            '
            'dsOrder
            '
            Me.dsOrder.DataSetName = "dsOrder"
            Me.dsOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'tedShipAddress
            '
            Me.tedShipAddress.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.ShipAddress", True))
            Me.tedShipAddress.Location = New System.Drawing.Point(673, 62)
            Me.tedShipAddress.Name = "tedShipAddress"
            Me.tedShipAddress.Size = New System.Drawing.Size(281, 20)
            Me.tedShipAddress.StyleController = Me.layoutControl1
            Me.tedShipAddress.TabIndex = 33
            '
            'tedShipName
            '
            Me.tedShipName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.ShipPostalCode", True))
            Me.tedShipName.Location = New System.Drawing.Point(673, 86)
            Me.tedShipName.Name = "tedShipName"
            Me.tedShipName.Size = New System.Drawing.Size(281, 20)
            Me.tedShipName.StyleController = Me.layoutControl1
            Me.tedShipName.TabIndex = 32
            '
            'tedShipDate
            '
            Me.tedShipDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.ShippedDate", True))
            Me.tedShipDate.Location = New System.Drawing.Point(673, 14)
            Me.tedShipDate.Name = "tedShipDate"
            Me.tedShipDate.Properties.DisplayFormat.FormatString = "D"
            Me.tedShipDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.tedShipDate.Properties.Mask.EditMask = "D"
            Me.tedShipDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            Me.tedShipDate.Size = New System.Drawing.Size(281, 20)
            Me.tedShipDate.StyleController = Me.layoutControl1
            Me.tedShipDate.TabIndex = 31
            '
            'pedLogo
            '
            Me.pedLogo.EditValue = Global.My.Resources.Resources.Logo
            Me.pedLogo.Location = New System.Drawing.Point(2, 2)
            Me.pedLogo.Name = "pedLogo"
            Me.pedLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pedLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.pedLogo.Size = New System.Drawing.Size(272, 116)
            Me.pedLogo.StyleController = Me.layoutControl1
            Me.pedLogo.TabIndex = 30
            '
            'gridOrders
            '
            Me.gridOrders.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridOrders.DataSource = Me.bindingSource
            Me.gridOrders.Location = New System.Drawing.Point(2, 462)
            Me.gridOrders.MainView = Me.gridViewOrders
            Me.gridOrders.Name = "gridOrders"
            Me.gridOrders.Size = New System.Drawing.Size(964, 156)
            Me.gridOrders.TabIndex = 29
            Me.gridOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewOrders})
            '
            'bindingSource
            '
            Me.bindingSource.AllowNew = False
            Me.bindingSource.DataMember = "Order Details"
            Me.bindingSource.DataSource = Me.dsOrder
            '
            'gridViewOrders
            '
            Me.gridViewOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colProductName, Me.colSubTotal})
            Me.gridViewOrders.GridControl = Me.gridOrders
            Me.gridViewOrders.Name = "gridViewOrders"
            Me.gridViewOrders.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
            Me.gridViewOrders.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.gridViewOrders.OptionsView.ShowFooter = True
            Me.gridViewOrders.OptionsView.ShowGroupPanel = False
            Me.gridViewOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSubTotal, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colOrderID
            '
            Me.colOrderID.Caption = "Shipment ID"
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            Me.colOrderID.Width = 214
            '
            'colUnitPrice
            '
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colUnitPrice.Width = 226
            '
            'colQuantity
            '
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 3
            Me.colQuantity.Width = 165
            '
            'colDiscount
            '
            Me.colDiscount.DisplayFormat.FormatString = "p"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 4
            Me.colDiscount.Width = 154
            '
            'colProductName
            '
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            Me.colProductName.Width = 208
            '
            'colSubTotal
            '
            Me.colSubTotal.Caption = "SubTotal"
            Me.colSubTotal.DisplayFormat.FormatString = "c"
            Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSubTotal.FieldName = "gridColumn1"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "Total = {0:c}")})
            Me.colSubTotal.UnboundExpression = "[UnitPrice]*[Quantity]  * (1 - [Discount])"
            Me.colSubTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
            Me.colSubTotal.Visible = True
            Me.colSubTotal.VisibleIndex = 5
            Me.colSubTotal.Width = 339
            '
            'dnNavigationCustomer
            '
            Me.dnNavigationCustomer.DataMember = "Employees"
            Me.dnNavigationCustomer.DataSource = Me.dsOrder
            Me.dnNavigationCustomer.Location = New System.Drawing.Point(14, 409)
            Me.dnNavigationCustomer.Name = "dnNavigationCustomer"
            Me.dnNavigationCustomer.Size = New System.Drawing.Size(228, 19)
            Me.dnNavigationCustomer.StyleController = Me.layoutControl1
            Me.dnNavigationCustomer.TabIndex = 28
            Me.dnNavigationCustomer.Text = "dataNavigator3"
            Me.dnNavigationCustomer.Visible = False
            '
            'dnNavigationEmployee
            '
            Me.dnNavigationEmployee.DataMember = "Customers"
            Me.dnNavigationEmployee.DataSource = Me.dsOrder
            Me.dnNavigationEmployee.Location = New System.Drawing.Point(14, 248)
            Me.dnNavigationEmployee.Name = "dnNavigationEmployee"
            Me.dnNavigationEmployee.Size = New System.Drawing.Size(228, 19)
            Me.dnNavigationEmployee.StyleController = Me.layoutControl1
            Me.dnNavigationEmployee.TabIndex = 27
            Me.dnNavigationEmployee.Text = "dataNavigator2"
            Me.dnNavigationEmployee.Visible = False
            '
            'tedCountryEmployee
            '
            Me.tedCountryEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.Country", True))
            Me.tedCountryEmployee.Location = New System.Drawing.Point(705, 224)
            Me.tedCountryEmployee.Name = "tedCountryEmployee"
            Me.tedCountryEmployee.Size = New System.Drawing.Size(249, 20)
            Me.tedCountryEmployee.StyleController = Me.layoutControl1
            Me.tedCountryEmployee.TabIndex = 26
            '
            'tedPostalCodeEmployee
            '
            Me.tedPostalCodeEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.PostalCode", True))
            Me.tedPostalCodeEmployee.Location = New System.Drawing.Point(393, 224)
            Me.tedPostalCodeEmployee.Name = "tedPostalCodeEmployee"
            Me.tedPostalCodeEmployee.Size = New System.Drawing.Size(226, 20)
            Me.tedPostalCodeEmployee.StyleController = Me.layoutControl1
            Me.tedPostalCodeEmployee.TabIndex = 25
            '
            'tedRegionEmployee
            '
            Me.tedRegionEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.Region", True))
            Me.tedRegionEmployee.Location = New System.Drawing.Point(96, 224)
            Me.tedRegionEmployee.Name = "tedRegionEmployee"
            Me.tedRegionEmployee.Size = New System.Drawing.Size(211, 20)
            Me.tedRegionEmployee.StyleController = Me.layoutControl1
            Me.tedRegionEmployee.TabIndex = 24
            '
            'tedCityEmployee
            '
            Me.tedCityEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.City", True))
            Me.tedCityEmployee.Location = New System.Drawing.Point(705, 200)
            Me.tedCityEmployee.Name = "tedCityEmployee"
            Me.tedCityEmployee.Size = New System.Drawing.Size(249, 20)
            Me.tedCityEmployee.StyleController = Me.layoutControl1
            Me.tedCityEmployee.TabIndex = 23
            '
            'tedAddressEmployee
            '
            Me.tedAddressEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.Address", True))
            Me.tedAddressEmployee.Location = New System.Drawing.Point(96, 200)
            Me.tedAddressEmployee.Name = "tedAddressEmployee"
            Me.tedAddressEmployee.Size = New System.Drawing.Size(523, 20)
            Me.tedAddressEmployee.StyleController = Me.layoutControl1
            Me.tedAddressEmployee.TabIndex = 22
            '
            'tedContactTitleEmployee
            '
            Me.tedContactTitleEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.ContactTitle", True))
            Me.tedContactTitleEmployee.Location = New System.Drawing.Point(532, 176)
            Me.tedContactTitleEmployee.Name = "tedContactTitleEmployee"
            Me.tedContactTitleEmployee.Size = New System.Drawing.Size(422, 20)
            Me.tedContactTitleEmployee.StyleController = Me.layoutControl1
            Me.tedContactTitleEmployee.TabIndex = 21
            '
            'tedContactNameEmployee
            '
            Me.tedContactNameEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.ContactName", True))
            Me.tedContactNameEmployee.Location = New System.Drawing.Point(96, 176)
            Me.tedContactNameEmployee.Name = "tedContactNameEmployee"
            Me.tedContactNameEmployee.Size = New System.Drawing.Size(350, 20)
            Me.tedContactNameEmployee.StyleController = Me.layoutControl1
            Me.tedContactNameEmployee.TabIndex = 20
            '
            'tedCompanyNameEmployee
            '
            Me.tedCompanyNameEmployee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Customers.CompanyName", True))
            Me.tedCompanyNameEmployee.Location = New System.Drawing.Point(96, 152)
            Me.tedCompanyNameEmployee.Name = "tedCompanyNameEmployee"
            Me.tedCompanyNameEmployee.Size = New System.Drawing.Size(858, 20)
            Me.tedCompanyNameEmployee.StyleController = Me.layoutControl1
            Me.tedCompanyNameEmployee.TabIndex = 19
            '
            'tedOrderID
            '
            Me.tedOrderID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.OrderID", True))
            Me.tedOrderID.Location = New System.Drawing.Point(372, 37)
            Me.tedOrderID.Name = "tedOrderID"
            Me.tedOrderID.Size = New System.Drawing.Size(191, 20)
            Me.tedOrderID.StyleController = Me.layoutControl1
            Me.tedOrderID.TabIndex = 18
            '
            'tedOrderDate
            '
            Me.tedOrderDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Orders.OrderDate", True))
            Me.tedOrderDate.Location = New System.Drawing.Point(372, 61)
            Me.tedOrderDate.Name = "tedOrderDate"
            Me.tedOrderDate.Properties.DisplayFormat.FormatString = "F"
            Me.tedOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.tedOrderDate.Properties.Mask.EditMask = "F"
            Me.tedOrderDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
            Me.tedOrderDate.Size = New System.Drawing.Size(191, 20)
            Me.tedOrderDate.StyleController = Me.layoutControl1
            Me.tedOrderDate.TabIndex = 17
            '
            'dnNavigationOrders
            '
            Me.dnNavigationOrders.Buttons.Append.Visible = False
            Me.dnNavigationOrders.Buttons.CancelEdit.Visible = False
            Me.dnNavigationOrders.Buttons.EndEdit.Visible = False
            Me.dnNavigationOrders.Buttons.First.Visible = False
            Me.dnNavigationOrders.Buttons.Last.Visible = False
            Me.dnNavigationOrders.Buttons.NextPage.Visible = False
            Me.dnNavigationOrders.Buttons.PrevPage.Visible = False
            Me.dnNavigationOrders.Buttons.Remove.Visible = False
            Me.dnNavigationOrders.DataMember = "Orders"
            Me.dnNavigationOrders.DataSource = Me.dsOrder
            Me.dnNavigationOrders.Location = New System.Drawing.Point(290, 14)
            Me.dnNavigationOrders.Name = "dnNavigationOrders"
            Me.dnNavigationOrders.Size = New System.Drawing.Size(273, 19)
            Me.dnNavigationOrders.StyleController = Me.layoutControl1
            Me.dnNavigationOrders.TabIndex = 16
            Me.dnNavigationOrders.Text = "dataNavigator1"
            Me.dnNavigationOrders.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            '
            'tedLastNameCustomer
            '
            Me.tedLastNameCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.LastName", True))
            Me.tedLastNameCustomer.Location = New System.Drawing.Point(532, 313)
            Me.tedLastNameCustomer.Name = "tedLastNameCustomer"
            Me.tedLastNameCustomer.Size = New System.Drawing.Size(422, 20)
            Me.tedLastNameCustomer.StyleController = Me.layoutControl1
            Me.tedLastNameCustomer.TabIndex = 19
            '
            'tedFirstNameCustomer
            '
            Me.tedFirstNameCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.FirstName", True))
            Me.tedFirstNameCustomer.Location = New System.Drawing.Point(96, 313)
            Me.tedFirstNameCustomer.Name = "tedFirstNameCustomer"
            Me.tedFirstNameCustomer.Size = New System.Drawing.Size(350, 20)
            Me.tedFirstNameCustomer.StyleController = Me.layoutControl1
            Me.tedFirstNameCustomer.TabIndex = 20
            '
            'tedAddressCustomer
            '
            Me.tedAddressCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.Address", True))
            Me.tedAddressCustomer.Location = New System.Drawing.Point(96, 361)
            Me.tedAddressCustomer.Name = "tedAddressCustomer"
            Me.tedAddressCustomer.Size = New System.Drawing.Size(523, 20)
            Me.tedAddressCustomer.StyleController = Me.layoutControl1
            Me.tedAddressCustomer.TabIndex = 21
            '
            'tedCityCustomer
            '
            Me.tedCityCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.City", True))
            Me.tedCityCustomer.Location = New System.Drawing.Point(705, 361)
            Me.tedCityCustomer.Name = "tedCityCustomer"
            Me.tedCityCustomer.Size = New System.Drawing.Size(249, 20)
            Me.tedCityCustomer.StyleController = Me.layoutControl1
            Me.tedCityCustomer.TabIndex = 22
            '
            'tedRegionCustomer
            '
            Me.tedRegionCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.Region", True))
            Me.tedRegionCustomer.Location = New System.Drawing.Point(96, 385)
            Me.tedRegionCustomer.Name = "tedRegionCustomer"
            Me.tedRegionCustomer.Size = New System.Drawing.Size(211, 20)
            Me.tedRegionCustomer.StyleController = Me.layoutControl1
            Me.tedRegionCustomer.TabIndex = 23
            '
            'tedPostalCodeCustomer
            '
            Me.tedPostalCodeCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.PostalCode", True))
            Me.tedPostalCodeCustomer.Location = New System.Drawing.Point(393, 385)
            Me.tedPostalCodeCustomer.Name = "tedPostalCodeCustomer"
            Me.tedPostalCodeCustomer.Size = New System.Drawing.Size(226, 20)
            Me.tedPostalCodeCustomer.StyleController = Me.layoutControl1
            Me.tedPostalCodeCustomer.TabIndex = 24
            '
            'tedCountryCustomer
            '
            Me.tedCountryCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.Country", True))
            Me.tedCountryCustomer.Location = New System.Drawing.Point(705, 385)
            Me.tedCountryCustomer.Name = "tedCountryCustomer"
            Me.tedCountryCustomer.Size = New System.Drawing.Size(249, 20)
            Me.tedCountryCustomer.StyleController = Me.layoutControl1
            Me.tedCountryCustomer.TabIndex = 25
            '
            'tedTitleCustomer
            '
            Me.tedTitleCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsOrder, "Employees.Title", True))
            Me.tedTitleCustomer.Location = New System.Drawing.Point(96, 337)
            Me.tedTitleCustomer.Name = "tedTitleCustomer"
            Me.tedTitleCustomer.Size = New System.Drawing.Size(858, 20)
            Me.tedTitleCustomer.StyleController = Me.layoutControl1
            Me.tedTitleCustomer.TabIndex = 26
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupOrderInfo, Me.layoutControlItemGrid, Me.layoutControlGroupInfoCustomer, Me.layoutControlGroupInfoEmployee, Me.layoutControlGroupShipInfo, Me.layoutControlItemLogo, Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(968, 620)
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlGroupOrderInfo
            '
            Me.layoutControlGroupOrderInfo.CustomizationFormText = "Shipment info"
            Me.layoutControlGroupOrderInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemOrderDate, Me.layoutControlItemNavigationOrder, Me.layoutControlItemOrderID})
            Me.layoutControlGroupOrderInfo.Location = New System.Drawing.Point(276, 0)
            Me.layoutControlGroupOrderInfo.Name = "layoutControlGroupOrderInfo"
            Me.layoutControlGroupOrderInfo.Size = New System.Drawing.Size(301, 120)
            Me.layoutControlGroupOrderInfo.Text = "Shipment info"
            Me.layoutControlGroupOrderInfo.TextVisible = False
            '
            'layoutControlItemOrderDate
            '
            Me.layoutControlItemOrderDate.Control = Me.tedOrderDate
            Me.layoutControlItemOrderDate.CustomizationFormText = "Shipment date:"
            Me.layoutControlItemOrderDate.Location = New System.Drawing.Point(0, 47)
            Me.layoutControlItemOrderDate.Name = "layoutControlItemOrderDate"
            Me.layoutControlItemOrderDate.Size = New System.Drawing.Size(277, 49)
            Me.layoutControlItemOrderDate.Text = "Shipment Date:"
            Me.layoutControlItemOrderDate.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemNavigationOrder
            '
            Me.layoutControlItemNavigationOrder.Control = Me.dnNavigationOrders
            Me.layoutControlItemNavigationOrder.CustomizationFormText = "NavigationShipment"
            Me.layoutControlItemNavigationOrder.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemNavigationOrder.MaxSize = New System.Drawing.Size(0, 23)
            Me.layoutControlItemNavigationOrder.MinSize = New System.Drawing.Size(1, 1)
            Me.layoutControlItemNavigationOrder.Name = "layoutControlItemNavigationOrder"
            Me.layoutControlItemNavigationOrder.OptionsPrint.AllowPrint = False
            Me.layoutControlItemNavigationOrder.Size = New System.Drawing.Size(277, 23)
            Me.layoutControlItemNavigationOrder.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItemNavigationOrder.Text = "NavigationShipment"
            Me.layoutControlItemNavigationOrder.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemNavigationOrder.TextVisible = False
            '
            'layoutControlItemOrderID
            '
            Me.layoutControlItemOrderID.Control = Me.tedOrderID
            Me.layoutControlItemOrderID.CustomizationFormText = "Shipment ID:"
            Me.layoutControlItemOrderID.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItemOrderID.Name = "layoutControlItemOrderID"
            Me.layoutControlItemOrderID.Size = New System.Drawing.Size(277, 24)
            Me.layoutControlItemOrderID.Text = "Shipment ID:"
            Me.layoutControlItemOrderID.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemGrid
            '
            Me.layoutControlItemGrid.Control = Me.gridOrders
            Me.layoutControlItemGrid.CustomizationFormText = "Shipment Details"
            Me.layoutControlItemGrid.Location = New System.Drawing.Point(0, 460)
            Me.layoutControlItemGrid.MinSize = New System.Drawing.Size(97, 137)
            Me.layoutControlItemGrid.Name = "layoutControlItemGrid"
            Me.layoutControlItemGrid.Size = New System.Drawing.Size(968, 160)
            Me.layoutControlItemGrid.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItemGrid.Text = "SHIPMENT DETAILS"
            Me.layoutControlItemGrid.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItemGrid.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItemGrid.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemGrid.TextToControlDistance = 0
            Me.layoutControlItemGrid.TextVisible = False
            '
            'layoutControlGroupInfoCustomer
            '
            Me.layoutControlGroupInfoCustomer.CustomizationFormText = "to consignee"
            Me.layoutControlGroupInfoCustomer.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLastNameCustomer, Me.layoutControlItemAddressCustomer, Me.layoutControlItemRegionCustomer, Me.layoutControlItemNavigationCustomer, Me.emptySpaceItem6, Me.layoutControlItemFirstNameCustomer, Me.layoutControlItemPostalCodeCustomer, Me.layoutControlItemTitleCustomer, Me.layoutControlItemCityCustomer, Me.layoutControlItemCountryCustomer})
            Me.layoutControlGroupInfoCustomer.Location = New System.Drawing.Point(0, 281)
            Me.layoutControlGroupInfoCustomer.Name = "layoutControlGroupInfoCustomer"
            Me.layoutControlGroupInfoCustomer.Size = New System.Drawing.Size(968, 161)
            Me.layoutControlGroupInfoCustomer.Text = "TO - CONSIGNEE"
            '
            'layoutControlItemLastNameCustomer
            '
            Me.layoutControlItemLastNameCustomer.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemLastNameCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemLastNameCustomer.Control = Me.tedLastNameCustomer
            Me.layoutControlItemLastNameCustomer.CustomizationFormText = "Last name:"
            Me.layoutControlItemLastNameCustomer.Location = New System.Drawing.Point(436, 0)
            Me.layoutControlItemLastNameCustomer.MinSize = New System.Drawing.Size(135, 22)
            Me.layoutControlItemLastNameCustomer.Name = "layoutControlItemLastNameCustomer"
            Me.layoutControlItemLastNameCustomer.Size = New System.Drawing.Size(508, 24)
            Me.layoutControlItemLastNameCustomer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItemLastNameCustomer.Text = "Last name:"
            Me.layoutControlItemLastNameCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemAddressCustomer
            '
            Me.layoutControlItemAddressCustomer.Control = Me.tedAddressCustomer
            Me.layoutControlItemAddressCustomer.CustomizationFormText = "Address:"
            Me.layoutControlItemAddressCustomer.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAddressCustomer.Name = "layoutControlItemAddressCustomer"
            Me.layoutControlItemAddressCustomer.Size = New System.Drawing.Size(609, 24)
            Me.layoutControlItemAddressCustomer.Text = "Address:"
            Me.layoutControlItemAddressCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemRegionCustomer
            '
            Me.layoutControlItemRegionCustomer.Control = Me.tedRegionCustomer
            Me.layoutControlItemRegionCustomer.CustomizationFormText = "Region:"
            Me.layoutControlItemRegionCustomer.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemRegionCustomer.Name = "layoutControlItemRegionCustomer"
            Me.layoutControlItemRegionCustomer.Size = New System.Drawing.Size(297, 24)
            Me.layoutControlItemRegionCustomer.Text = "Region:"
            Me.layoutControlItemRegionCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemNavigationCustomer
            '
            Me.layoutControlItemNavigationCustomer.Control = Me.dnNavigationCustomer
            Me.layoutControlItemNavigationCustomer.CustomizationFormText = "NavigationCustomer"
            Me.layoutControlItemNavigationCustomer.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItemNavigationCustomer.Name = "layoutControlItemNavigationCustomer"
            Me.layoutControlItemNavigationCustomer.Size = New System.Drawing.Size(232, 23)
            Me.layoutControlItemNavigationCustomer.Text = "NavigationCustomer"
            Me.layoutControlItemNavigationCustomer.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemNavigationCustomer.TextVisible = False
            Me.layoutControlItemNavigationCustomer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'emptySpaceItem6
            '
            Me.emptySpaceItem6.AllowHotTrack = False
            Me.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6"
            Me.emptySpaceItem6.Location = New System.Drawing.Point(232, 96)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(712, 23)
            Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'layoutControlItemFirstNameCustomer
            '
            Me.layoutControlItemFirstNameCustomer.Control = Me.tedFirstNameCustomer
            Me.layoutControlItemFirstNameCustomer.CustomizationFormText = "First name:"
            Me.layoutControlItemFirstNameCustomer.DataBindings.Add(New System.Windows.Forms.Binding("CustomizationFormText", Me.dsOrder, "Employees.FirstName", True))
            Me.layoutControlItemFirstNameCustomer.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemFirstNameCustomer.Name = "layoutControlItemFirstNameCustomer"
            Me.layoutControlItemFirstNameCustomer.Size = New System.Drawing.Size(436, 24)
            Me.layoutControlItemFirstNameCustomer.Text = "First name:"
            Me.layoutControlItemFirstNameCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemPostalCodeCustomer
            '
            Me.layoutControlItemPostalCodeCustomer.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemPostalCodeCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemPostalCodeCustomer.Control = Me.tedPostalCodeCustomer
            Me.layoutControlItemPostalCodeCustomer.CustomizationFormText = "Postal code:"
            Me.layoutControlItemPostalCodeCustomer.Location = New System.Drawing.Point(297, 72)
            Me.layoutControlItemPostalCodeCustomer.Name = "layoutControlItemPostalCodeCustomer"
            Me.layoutControlItemPostalCodeCustomer.Size = New System.Drawing.Size(312, 24)
            Me.layoutControlItemPostalCodeCustomer.Text = "Postal code:"
            Me.layoutControlItemPostalCodeCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemTitleCustomer
            '
            Me.layoutControlItemTitleCustomer.Control = Me.tedTitleCustomer
            Me.layoutControlItemTitleCustomer.CustomizationFormText = "Title:"
            Me.layoutControlItemTitleCustomer.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemTitleCustomer.Name = "layoutControlItemTitleCustomer"
            Me.layoutControlItemTitleCustomer.Size = New System.Drawing.Size(944, 24)
            Me.layoutControlItemTitleCustomer.Text = "Title:"
            Me.layoutControlItemTitleCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemCityCustomer
            '
            Me.layoutControlItemCityCustomer.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemCityCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemCityCustomer.Control = Me.tedCityCustomer
            Me.layoutControlItemCityCustomer.CustomizationFormText = "City:"
            Me.layoutControlItemCityCustomer.Location = New System.Drawing.Point(609, 48)
            Me.layoutControlItemCityCustomer.Name = "layoutControlItemCityCustomer"
            Me.layoutControlItemCityCustomer.Size = New System.Drawing.Size(335, 24)
            Me.layoutControlItemCityCustomer.Text = "City:"
            Me.layoutControlItemCityCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemCountryCustomer
            '
            Me.layoutControlItemCountryCustomer.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemCountryCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemCountryCustomer.Control = Me.tedCountryCustomer
            Me.layoutControlItemCountryCustomer.CustomizationFormText = "Country:"
            Me.layoutControlItemCountryCustomer.Location = New System.Drawing.Point(609, 72)
            Me.layoutControlItemCountryCustomer.Name = "layoutControlItemCountryCustomer"
            Me.layoutControlItemCountryCustomer.Size = New System.Drawing.Size(335, 24)
            Me.layoutControlItemCountryCustomer.Text = "Country:"
            Me.layoutControlItemCountryCustomer.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlGroupInfoEmployee
            '
            Me.layoutControlGroupInfoEmployee.CustomizationFormText = "Shipment from"
            Me.layoutControlGroupInfoEmployee.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemCompanyNameEmployee, Me.layoutControlItemContactNameEmployee, Me.layoutControlItemAddressEmployee, Me.layoutControlItemRegionEmployee, Me.layoutControlItemNavigationEmployee, Me.emptySpaceItem3, Me.layoutControlItemCityEmployee, Me.layoutControlItemPostalEmployee, Me.layoutControlItemCountryEmployee, Me.layoutControlItemContactTitleEmloyee})
            Me.layoutControlGroupInfoEmployee.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlGroupInfoEmployee.Name = "layoutControlGroupInfoEmployee"
            Me.layoutControlGroupInfoEmployee.Size = New System.Drawing.Size(968, 161)
            Me.layoutControlGroupInfoEmployee.Text = "SHIPMENT FROM"
            '
            'layoutControlItemCompanyNameEmployee
            '
            Me.layoutControlItemCompanyNameEmployee.Control = Me.tedCompanyNameEmployee
            Me.layoutControlItemCompanyNameEmployee.CustomizationFormText = "Company name:"
            Me.layoutControlItemCompanyNameEmployee.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemCompanyNameEmployee.Name = "layoutControlItemCompanyNameEmployee"
            Me.layoutControlItemCompanyNameEmployee.Size = New System.Drawing.Size(944, 24)
            Me.layoutControlItemCompanyNameEmployee.Text = "Company Name:"
            Me.layoutControlItemCompanyNameEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemContactNameEmployee
            '
            Me.layoutControlItemContactNameEmployee.Control = Me.tedContactNameEmployee
            Me.layoutControlItemContactNameEmployee.CustomizationFormText = "Contact name:"
            Me.layoutControlItemContactNameEmployee.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemContactNameEmployee.Name = "layoutControlItemContactNameEmployee"
            Me.layoutControlItemContactNameEmployee.Size = New System.Drawing.Size(436, 24)
            Me.layoutControlItemContactNameEmployee.Text = "Contact Name:"
            Me.layoutControlItemContactNameEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemAddressEmployee
            '
            Me.layoutControlItemAddressEmployee.Control = Me.tedAddressEmployee
            Me.layoutControlItemAddressEmployee.CustomizationFormText = "Address:"
            Me.layoutControlItemAddressEmployee.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemAddressEmployee.Name = "layoutControlItemAddressEmployee"
            Me.layoutControlItemAddressEmployee.Size = New System.Drawing.Size(609, 24)
            Me.layoutControlItemAddressEmployee.Text = "Address:"
            Me.layoutControlItemAddressEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemRegionEmployee
            '
            Me.layoutControlItemRegionEmployee.Control = Me.tedRegionEmployee
            Me.layoutControlItemRegionEmployee.CustomizationFormText = "Region:"
            Me.layoutControlItemRegionEmployee.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemRegionEmployee.Name = "layoutControlItemRegionEmployee"
            Me.layoutControlItemRegionEmployee.Size = New System.Drawing.Size(297, 24)
            Me.layoutControlItemRegionEmployee.Text = "Region:"
            Me.layoutControlItemRegionEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemNavigationEmployee
            '
            Me.layoutControlItemNavigationEmployee.Control = Me.dnNavigationEmployee
            Me.layoutControlItemNavigationEmployee.CustomizationFormText = "NavigationEmployee"
            Me.layoutControlItemNavigationEmployee.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItemNavigationEmployee.Name = "layoutControlItemNavigationEmployee"
            Me.layoutControlItemNavigationEmployee.Size = New System.Drawing.Size(232, 23)
            Me.layoutControlItemNavigationEmployee.Text = "NavigationEmployee"
            Me.layoutControlItemNavigationEmployee.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemNavigationEmployee.TextVisible = False
            Me.layoutControlItemNavigationEmployee.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'emptySpaceItem3
            '
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3"
            Me.emptySpaceItem3.Location = New System.Drawing.Point(232, 96)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(712, 23)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.emptySpaceItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            '
            'layoutControlItemCityEmployee
            '
            Me.layoutControlItemCityEmployee.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemCityEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemCityEmployee.Control = Me.tedCityEmployee
            Me.layoutControlItemCityEmployee.CustomizationFormText = "City:"
            Me.layoutControlItemCityEmployee.Location = New System.Drawing.Point(609, 48)
            Me.layoutControlItemCityEmployee.Name = "layoutControlItemCityEmployee"
            Me.layoutControlItemCityEmployee.Size = New System.Drawing.Size(335, 24)
            Me.layoutControlItemCityEmployee.Text = "City:"
            Me.layoutControlItemCityEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemPostalEmployee
            '
            Me.layoutControlItemPostalEmployee.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemPostalEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemPostalEmployee.Control = Me.tedPostalCodeEmployee
            Me.layoutControlItemPostalEmployee.CustomizationFormText = "Postal code:"
            Me.layoutControlItemPostalEmployee.Location = New System.Drawing.Point(297, 72)
            Me.layoutControlItemPostalEmployee.Name = "layoutControlItemPostalEmployee"
            Me.layoutControlItemPostalEmployee.Size = New System.Drawing.Size(312, 24)
            Me.layoutControlItemPostalEmployee.Text = "Postal code:"
            Me.layoutControlItemPostalEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemCountryEmployee
            '
            Me.layoutControlItemCountryEmployee.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemCountryEmployee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemCountryEmployee.Control = Me.tedCountryEmployee
            Me.layoutControlItemCountryEmployee.CustomizationFormText = "Country:"
            Me.layoutControlItemCountryEmployee.Location = New System.Drawing.Point(609, 72)
            Me.layoutControlItemCountryEmployee.Name = "layoutControlItemCountryEmployee"
            Me.layoutControlItemCountryEmployee.Size = New System.Drawing.Size(335, 24)
            Me.layoutControlItemCountryEmployee.Text = "Country:"
            Me.layoutControlItemCountryEmployee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemContactTitleEmloyee
            '
            Me.layoutControlItemContactTitleEmloyee.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItemContactTitleEmloyee.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.layoutControlItemContactTitleEmloyee.Control = Me.tedContactTitleEmployee
            Me.layoutControlItemContactTitleEmloyee.CustomizationFormText = "Contact title:"
            Me.layoutControlItemContactTitleEmloyee.Location = New System.Drawing.Point(436, 24)
            Me.layoutControlItemContactTitleEmloyee.Name = "layoutControlItemContactTitleEmloyee"
            Me.layoutControlItemContactTitleEmloyee.Size = New System.Drawing.Size(508, 24)
            Me.layoutControlItemContactTitleEmloyee.Text = "Contact Title:"
            Me.layoutControlItemContactTitleEmloyee.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlGroupShipInfo
            '
            Me.layoutControlGroupShipInfo.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroupShipInfo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemShopDate, Me.layoutControlItemShopAddress, Me.layoutControlItemShipCountry, Me.shipNameLCI})
            Me.layoutControlGroupShipInfo.Location = New System.Drawing.Point(577, 0)
            Me.layoutControlGroupShipInfo.Name = "layoutControlGroupShipInfo"
            Me.layoutControlGroupShipInfo.Size = New System.Drawing.Size(391, 120)
            Me.layoutControlGroupShipInfo.TextVisible = False
            '
            'layoutControlItemShopDate
            '
            Me.layoutControlItemShopDate.Control = Me.tedShipDate
            Me.layoutControlItemShopDate.CustomizationFormText = "Ship Date:"
            Me.layoutControlItemShopDate.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemShopDate.Name = "layoutControlItemShopDate"
            Me.layoutControlItemShopDate.Size = New System.Drawing.Size(367, 24)
            Me.layoutControlItemShopDate.Text = "Ship Date:"
            Me.layoutControlItemShopDate.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemShopAddress
            '
            Me.layoutControlItemShopAddress.Control = Me.tedShipAddress
            Me.layoutControlItemShopAddress.CustomizationFormText = "Ship Address:"
            Me.layoutControlItemShopAddress.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemShopAddress.Name = "layoutControlItemShopAddress"
            Me.layoutControlItemShopAddress.Size = New System.Drawing.Size(367, 24)
            Me.layoutControlItemShopAddress.Text = "Ship Address:"
            Me.layoutControlItemShopAddress.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemShipCountry
            '
            Me.layoutControlItemShipCountry.Control = Me.tedShipCountry
            Me.layoutControlItemShipCountry.CustomizationFormText = "Ship Country:"
            Me.layoutControlItemShipCountry.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemShipCountry.Name = "layoutControlItemShipCountry"
            Me.layoutControlItemShipCountry.Size = New System.Drawing.Size(367, 24)
            Me.layoutControlItemShipCountry.Text = "Ship Country:"
            Me.layoutControlItemShipCountry.TextSize = New System.Drawing.Size(79, 13)
            '
            'shipNameLCI
            '
            Me.shipNameLCI.Control = Me.tedShipName
            Me.shipNameLCI.CustomizationFormText = "layoutControlItem2"
            Me.shipNameLCI.Location = New System.Drawing.Point(0, 72)
            Me.shipNameLCI.Name = "shipNameLCI"
            Me.shipNameLCI.Size = New System.Drawing.Size(367, 24)
            Me.shipNameLCI.Text = "Ship Name:"
            Me.shipNameLCI.TextSize = New System.Drawing.Size(79, 13)
            '
            'layoutControlItemLogo
            '
            Me.layoutControlItemLogo.Control = Me.pedLogo
            Me.layoutControlItemLogo.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItemLogo.CustomizationFormText = "Logo"
            Me.layoutControlItemLogo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItemLogo.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLogo.MaxSize = New System.Drawing.Size(276, 120)
            Me.layoutControlItemLogo.MinSize = New System.Drawing.Size(276, 120)
            Me.layoutControlItemLogo.Name = "layoutControlItemLogo"
            Me.layoutControlItemLogo.Size = New System.Drawing.Size(276, 120)
            Me.layoutControlItemLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItemLogo.Text = "Logo"
            Me.layoutControlItemLogo.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLogo.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.lblcShipmentDetails
            Me.layoutControlItem1.CustomizationFormText = "lciShipmentDetails"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 442)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(24, 2, 2, 3)
            Me.layoutControlItem1.Size = New System.Drawing.Size(968, 18)
            Me.layoutControlItem1.Text = "Shipment Details"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlGroup2
            '
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(968, 731)
            Me.layoutControlGroup2.TextVisible = False
            '
            'LayoutWaybill
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "LayoutWaybill"
            Me.Size = New System.Drawing.Size(968, 620)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.tedShipCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dsOrder, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedShipAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedShipName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedShipDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pedLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridOrders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedCountryEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedPostalCodeEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedRegionEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedCityEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedAddressEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedContactTitleEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedContactNameEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedCompanyNameEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedOrderID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedOrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedLastNameCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedFirstNameCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedAddressCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedCityCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedRegionCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedPostalCodeCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedCountryCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tedTitleCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroupOrderInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemNavigationOrder, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemOrderID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroupInfoCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemLastNameCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemAddressCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemRegionCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemNavigationCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemFirstNameCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemPostalCodeCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemTitleCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemCityCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemCountryCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroupInfoEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemCompanyNameEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemContactNameEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemAddressEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemRegionEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemNavigationEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemCityEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemPostalEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemCountryEmployee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemContactTitleEmloyee, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroupShipInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemShopDate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemShopAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemShipCountry, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.shipNameLCI, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItemLogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private layoutControlGroup1 As LayoutControlGroup
        Private dsOrder As dsOrder
        Private layoutControlItemNavigationOrder As LayoutControlItem
        Private tedCountryEmployee As XtraEditors.TextEdit
        Private tedPostalCodeEmployee As XtraEditors.TextEdit
        Private tedRegionEmployee As XtraEditors.TextEdit
        Private tedCityEmployee As XtraEditors.TextEdit
        Private tedAddressEmployee As XtraEditors.TextEdit
        Private tedContactTitleEmployee As XtraEditors.TextEdit
        Private tedContactNameEmployee As XtraEditors.TextEdit
        Private tedCompanyNameEmployee As XtraEditors.TextEdit
        Private tedOrderID As XtraEditors.TextEdit
        Private tedOrderDate As XtraEditors.TextEdit
        Private layoutControlGroupOrderInfo As LayoutControlGroup
        Private layoutControlItemOrderID As LayoutControlItem
        Private layoutControlItemOrderDate As LayoutControlItem
        Private tedLastNameCustomer As XtraEditors.TextEdit
        Private tedFirstNameCustomer As XtraEditors.TextEdit
        Private tedAddressCustomer As XtraEditors.TextEdit
        Private tedCityCustomer As XtraEditors.TextEdit
        Private tedRegionCustomer As XtraEditors.TextEdit
        Private tedPostalCodeCustomer As XtraEditors.TextEdit
        Private tedCountryCustomer As XtraEditors.TextEdit
        Private tedTitleCustomer As XtraEditors.TextEdit
        Private dnNavigationCustomer As XtraEditors.DataNavigator
        Private dnNavigationEmployee As XtraEditors.DataNavigator
        Private gridOrders As XtraGrid.GridControl
        Private bindingSource As System.Windows.Forms.BindingSource
        Private gridViewOrders As XtraGrid.Views.Grid.GridView
        Private layoutControlItemGrid As LayoutControlItem
        Private colOrderID As XtraGrid.Columns.GridColumn
        Private colUnitPrice As XtraGrid.Columns.GridColumn
        Private colQuantity As XtraGrid.Columns.GridColumn
        Private colDiscount As XtraGrid.Columns.GridColumn
        Private colProductName As XtraGrid.Columns.GridColumn
        Private layoutControlItemLogo As LayoutControlItem
        Private layoutControlGroupInfoCustomer As LayoutControlGroup
        Private layoutControlItemLastNameCustomer As LayoutControlItem
        Private layoutControlItemAddressCustomer As LayoutControlItem
        Private layoutControlItemRegionCustomer As LayoutControlItem
        Private layoutControlItemNavigationCustomer As LayoutControlItem
        Private emptySpaceItem6 As EmptySpaceItem
        Private layoutControlItemFirstNameCustomer As LayoutControlItem
        Private layoutControlItemPostalCodeCustomer As LayoutControlItem
        Private layoutControlItemTitleCustomer As LayoutControlItem
        Private layoutControlItemCityCustomer As LayoutControlItem
        Private layoutControlItemCountryCustomer As LayoutControlItem
        Private layoutControlGroupInfoEmployee As LayoutControlGroup
        Private layoutControlItemCompanyNameEmployee As LayoutControlItem
        Private layoutControlItemContactNameEmployee As LayoutControlItem
        Private layoutControlItemAddressEmployee As LayoutControlItem
        Private layoutControlItemRegionEmployee As LayoutControlItem
        Private layoutControlItemNavigationEmployee As LayoutControlItem
        Private emptySpaceItem3 As EmptySpaceItem
        Private layoutControlItemCityEmployee As LayoutControlItem
        Private layoutControlItemPostalEmployee As LayoutControlItem
        Private layoutControlItemCountryEmployee As LayoutControlItem
        Private layoutControlItemContactTitleEmloyee As LayoutControlItem
        Private tedShipDate As XtraEditors.TextEdit
        Private layoutControlItemShopDate As LayoutControlItem
        Private tedShipAddress As XtraEditors.TextEdit
        Private tedShipName As XtraEditors.TextEdit
        Private layoutControlGroupShipInfo As LayoutControlGroup
        Private shipNameLCI As LayoutControlItem
        Private layoutControlItemShopAddress As LayoutControlItem
        Private tedShipCountry As XtraEditors.TextEdit
        Private layoutControlItemShipCountry As LayoutControlItem
        Private colSubTotal As XtraGrid.Columns.GridColumn
        Public WithEvents dnNavigationOrders As XtraEditors.DataNavigator
        Private layoutControlGroup2 As LayoutControlGroup
        Public layoutControl1 As LayoutControl
        Private lblcShipmentDetails As XtraEditors.LabelControl
        Private layoutControlItem1 As LayoutControlItem
        Public pedLogo As XtraEditors.PictureEdit
    End Class
End Namespace
