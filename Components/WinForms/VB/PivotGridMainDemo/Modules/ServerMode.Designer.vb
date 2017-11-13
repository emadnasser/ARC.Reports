Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class ServerMode
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
            Me.fieldOrderDateYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDateMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.panelDemo = New DevExpress.XtraEditors.PanelControl()
            Me.sccPivot = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCustomerName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCustomerID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderQuerter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPersonName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPersonID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldRevenue = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.headerPanel = New DevExpress.XtraEditors.PanelControl()
            Me.btnGenerateDataSource = New DevExpress.XtraEditors.SimpleButton()
            Me.lcTimeTaken = New DevExpress.XtraEditors.LabelControl()
            Me.lcTimeTakenCaption = New DevExpress.XtraEditors.LabelControl()
            Me.panelNoConnection = New DevExpress.XtraEditors.PanelControl()
            Me.lcNoConnection = New DevExpress.XtraEditors.LabelControl()
            Me.btnGenerateDatasourceLarge = New DevExpress.XtraEditors.SimpleButton()
            Me.panelFieldCust = New DevExpress.XtraEditors.PanelControl()
            CType(Me.panelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelDemo.SuspendLayout()
            CType(Me.sccPivot, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sccPivot.SuspendLayout()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.headerPanel.SuspendLayout()
            CType(Me.panelNoConnection, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelNoConnection.SuspendLayout()
            CType(Me.panelFieldCust, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'fieldOrderDateYear
            '
            Me.fieldOrderDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDateYear.AreaIndex = 0
            Me.fieldOrderDateYear.Caption = "Order Year"
            Me.fieldOrderDateYear.DisplayFolder = "Order Date"
            Me.fieldOrderDateYear.FieldName = "Order.OrderDate"
            Me.fieldOrderDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDateYear.Name = "fieldOrderDateYear"
            Me.fieldOrderDateYear.Options.AllowRunTimeSummaryChange = True
            Me.fieldOrderDateYear.UnboundFieldName = "fieldOrderDateYear"
            '
            'fieldOrderDateMonth
            '
            Me.fieldOrderDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDateMonth.AreaIndex = 1
            Me.fieldOrderDateMonth.Caption = "Order Month"
            Me.fieldOrderDateMonth.DisplayFolder = "Order Date"
            Me.fieldOrderDateMonth.FieldName = "Order.OrderDate"
            Me.fieldOrderDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDateMonth.Name = "fieldOrderDateMonth"
            Me.fieldOrderDateMonth.Options.AllowRunTimeSummaryChange = True
            Me.fieldOrderDateMonth.UnboundFieldName = "fieldOrderDateMonth"
            Me.fieldOrderDateMonth.Visible = False
            '
            'panelDemo
            '
            Me.panelDemo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelDemo.Controls.Add(Me.sccPivot)
            Me.panelDemo.Controls.Add(Me.headerPanel)
            Me.panelDemo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelDemo.Location = New System.Drawing.Point(0, 0)
            Me.panelDemo.Name = "panelDemo"
            Me.panelDemo.Size = New System.Drawing.Size(784, 432)
            Me.panelDemo.TabIndex = 24
            '
            'sccPivot
            '
            Me.sccPivot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sccPivot.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.sccPivot.Location = New System.Drawing.Point(0, 29)
            Me.sccPivot.Name = "sccPivot"
            Me.sccPivot.Panel1.Controls.Add(Me.pivotGridControl)
            Me.sccPivot.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
            Me.sccPivot.Panel1.Text = "Panel1"
            Me.sccPivot.Panel2.Controls.Add(Me.panelFieldCust)
            Me.sccPivot.Panel2.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
            Me.sccPivot.Panel2.Text = "Panel2"
            Me.sccPivot.Size = New System.Drawing.Size(784, 403)
            Me.sccPivot.SplitterPosition = 218
            Me.sccPivot.TabIndex = 26
            '
            'pivotGridControl
            '
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldCategoryID, Me.fieldCustomerName, Me.fieldCustomerID, Me.fieldOrderID, Me.fieldOrderDateYear, Me.fieldOrderQuerter, Me.fieldOrderDateMonth, Me.fieldOrderDate, Me.fieldProductName, Me.fieldProductID, Me.fieldSalesPersonName, Me.fieldSalesPersonID, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldRevenue})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsBehavior.UseAsyncMode = True
            Me.pivotGridControl.OptionsCustomization.AllowCustomizationForm = False
            Me.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = True
            Me.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Me.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
            Me.pivotGridControl.OptionsView.RowTreeWidth = 140
            Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowHeaders = False
            Me.pivotGridControl.Size = New System.Drawing.Size(557, 403)
            Me.pivotGridControl.TabIndex = 16
'			Me.pivotGridControl.AsyncOperationStarting += New System.EventHandler(Me.pivotGridControl_AsyncOperationStarting);
'			Me.pivotGridControl.AsyncOperationCompleted += New System.EventHandler(Me.pivotGridControl_AsyncOperationCompleted);
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 1
            Me.fieldCategoryName.Caption = "Category"
            Me.fieldCategoryName.DisplayFolder = "Product"
            Me.fieldCategoryName.FieldName = "Product.Category.CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Options.AllowRunTimeSummaryChange = True
            Me.fieldCategoryName.Visible = False
            '
            'fieldCategoryID
            '
            Me.fieldCategoryID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCategoryID.AreaIndex = 0
            Me.fieldCategoryID.Caption = "CategoryID"
            Me.fieldCategoryID.DisplayFolder = "Product"
            Me.fieldCategoryID.FieldName = "Product.CategoryID"
            Me.fieldCategoryID.Name = "fieldCategoryID"
            Me.fieldCategoryID.Options.AllowRunTimeSummaryChange = True
            Me.fieldCategoryID.Visible = False
            '
            'fieldCustomerName
            '
            Me.fieldCustomerName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCustomerName.AreaIndex = 0
            Me.fieldCustomerName.Caption = "Customer"
            Me.fieldCustomerName.DisplayFolder = "Customer"
            Me.fieldCustomerName.FieldName = "Order.Customer.CustomerName"
            Me.fieldCustomerName.Name = "fieldCustomerName"
            Me.fieldCustomerName.Options.AllowRunTimeSummaryChange = True
            Me.fieldCustomerName.Visible = False
            '
            'fieldCustomerID
            '
            Me.fieldCustomerID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCustomerID.AreaIndex = 0
            Me.fieldCustomerID.Caption = "CustomerID"
            Me.fieldCustomerID.DisplayFolder = "Customer"
            Me.fieldCustomerID.FieldName = "Order.CustomerID"
            Me.fieldCustomerID.Name = "fieldCustomerID"
            Me.fieldCustomerID.Options.AllowRunTimeSummaryChange = True
            Me.fieldCustomerID.Visible = False
            '
            'fieldOrderID
            '
            Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderID.AreaIndex = 0
            Me.fieldOrderID.Caption = "OrderID"
            Me.fieldOrderID.DisplayFolder = "Order"
            Me.fieldOrderID.FieldName = "OrderID"
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.Options.AllowRunTimeSummaryChange = True
            Me.fieldOrderID.Visible = False
            '
            'fieldOrderQuerter
            '
            Me.fieldOrderQuerter.AreaIndex = 0
            Me.fieldOrderQuerter.Caption = "Order Querter"
            Me.fieldOrderQuerter.DisplayFolder = "Order Date"
            Me.fieldOrderQuerter.FieldName = "Order.OrderDate"
            Me.fieldOrderQuerter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderQuerter.Name = "fieldOrderQuerter"
            Me.fieldOrderQuerter.UnboundFieldName = "fieldOrderQuerter"
            Me.fieldOrderQuerter.Visible = False
            '
            'fieldOrderDate
            '
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Date"
            Me.fieldOrderDate.DisplayFolder = "Order Date"
            Me.fieldOrderDate.FieldName = "Order.OrderDate"
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.Options.AllowRunTimeSummaryChange = True
            Me.fieldOrderDate.Visible = False
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product"
            Me.fieldProductName.DisplayFolder = "Product"
            Me.fieldProductName.FieldName = "Product.ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Options.AllowRunTimeSummaryChange = True
            '
            'fieldProductID
            '
            Me.fieldProductID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductID.AreaIndex = 0
            Me.fieldProductID.Caption = "ProductID"
            Me.fieldProductID.DisplayFolder = "Product"
            Me.fieldProductID.FieldName = "ProductID"
            Me.fieldProductID.Name = "fieldProductID"
            Me.fieldProductID.Options.AllowRunTimeSummaryChange = True
            Me.fieldProductID.Visible = False
            '
            'fieldSalesPersonName
            '
            Me.fieldSalesPersonName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPersonName.AreaIndex = 1
            Me.fieldSalesPersonName.Caption = "Sales Person"
            Me.fieldSalesPersonName.DisplayFolder = "Sales Person"
            Me.fieldSalesPersonName.FieldName = "Order.SalesPerson.SalesPersonName"
            Me.fieldSalesPersonName.Name = "fieldSalesPersonName"
            Me.fieldSalesPersonName.Options.AllowRunTimeSummaryChange = True
            '
            'fieldSalesPersonID
            '
            Me.fieldSalesPersonID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPersonID.AreaIndex = 0
            Me.fieldSalesPersonID.Caption = "SalesPersonID"
            Me.fieldSalesPersonID.DisplayFolder = "Sales Person"
            Me.fieldSalesPersonID.FieldName = "Order.SalesPersonID"
            Me.fieldSalesPersonID.Name = "fieldSalesPersonID"
            Me.fieldSalesPersonID.Options.AllowRunTimeSummaryChange = True
            Me.fieldSalesPersonID.Visible = False
            '
            'fieldUnitPrice
            '
            Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice.AreaIndex = 1
            Me.fieldUnitPrice.Caption = "UnitPrice"
            Me.fieldUnitPrice.DisplayFolder = "Order"
            Me.fieldUnitPrice.FieldName = "UnitPrice"
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            Me.fieldUnitPrice.Options.AllowRunTimeSummaryChange = True
            '
            'fieldQuantity
            '
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.DisplayFolder = "Order"
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Options.AllowRunTimeSummaryChange = True
            '
            'fieldRevenue
            '
            Me.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldRevenue.AreaIndex = 2
            Me.fieldRevenue.Caption = "Revenue"
            Me.fieldRevenue.DisplayFolder = "Order"
            Me.fieldRevenue.Name = "fieldRevenue"
            Me.fieldRevenue.UnboundExpression = "[UnitPrice]*[Quantity]"
            Me.fieldRevenue.UnboundFieldName = "fieldRevenue"
			Me.fieldRevenue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            '
            'headerPanel
            '
            Me.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.headerPanel.Controls.Add(Me.btnGenerateDataSource)
            Me.headerPanel.Controls.Add(Me.lcTimeTaken)
            Me.headerPanel.Controls.Add(Me.lcTimeTakenCaption)
            Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.headerPanel.Location = New System.Drawing.Point(0, 0)
            Me.headerPanel.Name = "headerPanel"
            Me.headerPanel.Size = New System.Drawing.Size(784, 29)
            Me.headerPanel.TabIndex = 25
            '
            'btnGenerateDataSource
            '
			Me.btnGenerateDataSource.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.btnGenerateDataSource.Location = New System.Drawing.Point(676, 2)
            Me.btnGenerateDataSource.Name = "btnGenerateDataSource"
            Me.btnGenerateDataSource.Size = New System.Drawing.Size(105, 23)
            Me.btnGenerateDataSource.TabIndex = 9
            Me.btnGenerateDataSource.Text = "Generate Database"
'			Me.btnGenerateDataSource.Click += New System.EventHandler(Me.btnGenerateDataSource_Click);
            '
            'lcTimeTaken
            '
            Me.lcTimeTaken.Location = New System.Drawing.Point(179, 8)
            Me.lcTimeTaken.Name = "lcTimeTaken"
            Me.lcTimeTaken.Size = New System.Drawing.Size(0, 13)
            Me.lcTimeTaken.TabIndex = 8
            '
            'lcTimeTakenCaption
            '
			Me.lcTimeTakenCaption.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lcTimeTakenCaption.Location = New System.Drawing.Point(4, 8)
            Me.lcTimeTakenCaption.Name = "lcTimeTakenCaption"
            Me.lcTimeTakenCaption.Size = New System.Drawing.Size(170, 13)
            Me.lcTimeTakenCaption.TabIndex = 4
            Me.lcTimeTakenCaption.Text = "Data Recalculation Time (ms):"
            '
            'panelNoConnection
            '
            Me.panelNoConnection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelNoConnection.Controls.Add(Me.lcNoConnection)
            Me.panelNoConnection.Controls.Add(Me.btnGenerateDatasourceLarge)
            Me.panelNoConnection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelNoConnection.Location = New System.Drawing.Point(0, 0)
            Me.panelNoConnection.Name = "panelNoConnection"
            Me.panelNoConnection.Size = New System.Drawing.Size(784, 432)
            Me.panelNoConnection.TabIndex = 25
            '
            'lcNoConnection
            '
			Me.lcNoConnection.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.lcNoConnection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lcNoConnection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lcNoConnection.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.lcNoConnection.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.lcNoConnection.Location = New System.Drawing.Point(15, 230)
            Me.lcNoConnection.Name = "lcNoConnection"
            Me.lcNoConnection.Size = New System.Drawing.Size(754, 13)
            Me.lcNoConnection.TabIndex = 4
			Me.lcNoConnection.Text = "This demo requires a large database. To create a sample database, click the Creat" & "e Database and Start Demo button."
            '
            'btnGenerateDatasourceLarge
            '
            Me.btnGenerateDatasourceLarge.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btnGenerateDatasourceLarge.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            Me.btnGenerateDatasourceLarge.Location = New System.Drawing.Point(271, 181)
            Me.btnGenerateDatasourceLarge.Name = "btnGenerateDatasourceLarge"
            Me.btnGenerateDatasourceLarge.Size = New System.Drawing.Size(244, 43)
            Me.btnGenerateDatasourceLarge.TabIndex = 25
            Me.btnGenerateDatasourceLarge.Text = "Create Database and Start Demo"
            '
            'panelFieldCust
            '
            Me.panelFieldCust.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelFieldCust.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelFieldCust.Location = New System.Drawing.Point(4, 0)
            Me.panelFieldCust.Name = "panelFieldCust"
            Me.panelFieldCust.Size = New System.Drawing.Size(214, 403)
            Me.panelFieldCust.TabIndex = 26
            '
            'ServerMode
            '
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panelNoConnection)
            Me.Controls.Add(Me.panelDemo)
            Me.Name = "ServerMode"
'			Me.Load += New System.EventHandler(Me.ServerMode_Load);
            CType(Me.panelDemo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelDemo.ResumeLayout(False)
            CType(Me.sccPivot, System.ComponentModel.ISupportInitialize).EndInit()
            Me.sccPivot.ResumeLayout(False)
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.headerPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.headerPanel.ResumeLayout(False)
            Me.headerPanel.PerformLayout()
            CType(Me.panelNoConnection, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelNoConnection.ResumeLayout(False)
            CType(Me.panelFieldCust, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panelDemo As XtraEditors.PanelControl
		Private headerPanel As XtraEditors.PanelControl
		Private lcTimeTaken As XtraEditors.LabelControl
		Private panelNoConnection As XtraEditors.PanelControl
		Private sccPivot As XtraEditors.SplitContainerControl
		Private WithEvents pivotGridControl As PivotGridControl
		Private fieldOrderID As PivotGridField
		Private fieldProductID As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldUnitPrice As PivotGridField
		Private fieldSalesPersonID As PivotGridField
		Private fieldCustomerID As PivotGridField
		Private fieldOrderDate As PivotGridField
		Private fieldOrderDateYear As PivotGridField
		Private fieldOrderDateMonth As PivotGridField
		Private fieldProductName As PivotGridField
		Private fieldCategoryID As PivotGridField
		Private fieldSalesPersonName As PivotGridField
		Private fieldCustomerName As PivotGridField
		Private fieldCategoryName As PivotGridField
		Private fieldRevenue As PivotGridField
		Private lcNoConnection As XtraEditors.LabelControl
		Private WithEvents btnGenerateDataSource As XtraEditors.SimpleButton
		Private WithEvents btnGenerateDatasourceLarge As XtraEditors.SimpleButton
		Private fieldOrderQuerter As PivotGridField
        Private lcTimeTakenCaption As XtraEditors.LabelControl
        Private WithEvents panelFieldCust As DevExpress.XtraEditors.PanelControl



	End Class
End Namespace
