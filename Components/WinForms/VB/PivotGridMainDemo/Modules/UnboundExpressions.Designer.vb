Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class UnboundExpressions
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
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.paddingPanel = New DevExpress.XtraEditors.PanelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldFirstName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldLastName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderCount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldNewYearBonus = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderCountBonus = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldBonusAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.label1 = New DevExpress.XtraEditors.LabelControl()
			Me.icbSalesPerson = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.btnAddBonus = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' paddingPanel
			' 
			Me.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top
			Me.paddingPanel.Location = New System.Drawing.Point(0, 37)
			Me.paddingPanel.Name = "paddingPanel"
			Me.paddingPanel.Size = New System.Drawing.Size(706, 8)
			Me.paddingPanel.TabIndex = 10
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldFirstName, Me.fieldLastName, Me.fieldSalesPerson, Me.fieldQuarter, Me.fieldExtendedPrice, Me.fieldQuantity, Me.fieldOrderCount, Me.fieldNewYearBonus, Me.fieldOrderCountBonus, Me.fieldBonusAmount})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 45)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsCustomization.AllowExpand = False
			Me.pivotGridControl1.OptionsCustomization.AllowResizing = False
			Me.pivotGridControl1.OptionsData.DataFieldUnboundExpressionMode = DevExpress.XtraPivotGrid.DataFieldUnboundExpressionMode.UseSummaryValues
			Me.pivotGridControl1.OptionsSelection.CellSelection = False
			Me.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = False
			Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
			Me.pivotGridControl1.OptionsView.ShowDataHeaders = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.OptionsView.ShowRowGrandTotals = False
			Me.pivotGridControl1.OptionsView.ShowRowTotals = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 371)
			Me.pivotGridControl1.TabIndex = 11
'			Me.pivotGridControl1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pivotGridControl1_MouseClick);
'			Me.pivotGridControl1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.pivotGridControl1_MouseMove);
'			Me.pivotGridControl1.FieldUnboundExpressionChanged += New DevExpress.XtraPivotGrid.PivotFieldEventHandler(Me.pivotGridControl1_FieldUnboundExpressionChanged);
'			Me.pivotGridControl1.PopupMenuShowing += New DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(Me.pivotGridControl1_PopupMenuShowing);
'			Me.pivotGridControl1.CustomDrawFieldValue += New DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(Me.pivotGridControl1_CustomDrawFieldValue);
			' 
			' fieldFirstName
			' 
			Me.fieldFirstName.AreaIndex = 0
			Me.fieldFirstName.FieldName = "FirstName"
			Me.fieldFirstName.Name = "fieldFirstName"
			Me.fieldFirstName.Visible = False
			' 
			' fieldLastName
			' 
			Me.fieldLastName.AreaIndex = 0
			Me.fieldLastName.FieldName = "LastName"
			Me.fieldLastName.Name = "fieldLastName"
			Me.fieldLastName.Visible = False
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
			Me.fieldSalesPerson.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.fieldSalesPerson.Appearance.Header.Options.UseFont = True
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Options.ShowUnboundExpressionMenu = True
			Me.fieldSalesPerson.UnboundFieldName = "SalesPerson"
			Me.fieldSalesPerson.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.fieldSalesPerson.Width = 219
			' 
			' fieldQuarter
			' 
			Me.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
			Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldQuarter.AreaIndex = 1
			Me.fieldQuarter.Caption = "Quarter"
			Me.fieldQuarter.FieldName = "OrderDate"
			Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.fieldQuarter.Name = "fieldQuarter"
			Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.UnboundFieldName = "Quarter"
			Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
			Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldQuarter.Width = 140
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 2
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 1
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldOrderCount
			' 
			Me.fieldOrderCount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldOrderCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldOrderCount.AreaIndex = 0
			Me.fieldOrderCount.Caption = "Order Count"
			Me.fieldOrderCount.FieldName = "OrderID"
			Me.fieldOrderCount.Name = "fieldOrderCount"
			Me.fieldOrderCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
			' 
			' fieldNewYearBonus
			' 
			Me.fieldNewYearBonus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldNewYearBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldNewYearBonus.AreaIndex = 3
			Me.fieldNewYearBonus.Caption = "New Year Bonus"
			Me.fieldNewYearBonus.Name = "fieldNewYearBonus"
			Me.fieldNewYearBonus.Options.ShowUnboundExpressionMenu = True
			Me.fieldNewYearBonus.UnboundExpression = "Iif([Quarter] == 4, Iif([fieldExtendedPrice] > 40000, 600, 400), 0)"
			Me.fieldNewYearBonus.UnboundFieldName = "NewYearBonus"
			Me.fieldNewYearBonus.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' fieldOrderCountBonus
			' 
			Me.fieldOrderCountBonus.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldOrderCountBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldOrderCountBonus.AreaIndex = 4
			Me.fieldOrderCountBonus.Caption = "Order Count Bonus"
			Me.fieldOrderCountBonus.Name = "fieldOrderCountBonus"
			Me.fieldOrderCountBonus.Options.ShowUnboundExpressionMenu = True
			Me.fieldOrderCountBonus.UnboundExpression = "Iif([fieldOrderCount] > 50 and [fieldExtendedPrice] / [fieldOrderCount] > 500, 15" & " * [fieldExtendedPrice] / [fieldQuantity] , 0)"
			Me.fieldOrderCountBonus.UnboundFieldName = "OrderCountBonus"
			Me.fieldOrderCountBonus.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' fieldBonusAmount
			' 
			Me.fieldBonusAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldBonusAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldBonusAmount.AreaIndex = 5
			Me.fieldBonusAmount.Caption = "Bonus Amount"
			Me.fieldBonusAmount.Name = "fieldBonusAmount"
			Me.fieldBonusAmount.Options.ShowUnboundExpressionMenu = True
			Me.fieldBonusAmount.UnboundExpression = "[fieldNewYearBonus] + [fieldOrderCountBonus]"
			Me.fieldBonusAmount.UnboundFieldName = "BonusAmount"
			Me.fieldBonusAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' label1
			' 
			Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.label1.Location = New System.Drawing.Point(19, 12)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(105, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Sales Person Format: "
			' 
			' icbSalesPerson
			' 
			Me.icbSalesPerson.Location = New System.Drawing.Point(130, 9)
			Me.icbSalesPerson.Name = "icbSalesPerson"
			Me.icbSalesPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSalesPerson.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("First Name + Last Name", "[fieldFirstName] + ' ' + [fieldLastName]", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name + First Name", "[fieldLastName] + ' ' + [fieldFirstName]", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Last Name only", "[fieldLastName]", -1)})
			Me.icbSalesPerson.Size = New System.Drawing.Size(172, 20)
			Me.icbSalesPerson.TabIndex = 2
'			Me.icbSalesPerson.SelectedIndexChanged += New System.EventHandler(Me.icb_SelectedIndexChanged);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.panelControl2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(706, 37)
			Me.panelControl1.TabIndex = 1
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.label1)
			Me.panelControl2.Controls.Add(Me.btnAddBonus)
			Me.panelControl2.Controls.Add(Me.icbSalesPerson)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
			Me.panelControl2.Size = New System.Drawing.Size(706, 34)
			Me.panelControl2.TabIndex = 4
			' 
			' btnAddBonus
			' 
			Me.btnAddBonus.Location = New System.Drawing.Point(357, 7)
			Me.btnAddBonus.Name = "btnAddBonus"
			Me.btnAddBonus.Size = New System.Drawing.Size(88, 22)
			Me.btnAddBonus.TabIndex = 3
			Me.btnAddBonus.Text = "Add Bonus"
'			Me.btnAddBonus.Click += New System.EventHandler(Me.btnAddBonus_Click);
			' 
			' UnboundExpressions
			' 
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.paddingPanel)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "UnboundExpressions"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.UnboundColumns_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.paddingPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSalesPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private components As System.ComponentModel.IContainer = Nothing
		Private paddingPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private fieldFirstName As PivotGridField
		Private fieldLastName As PivotGridField
		Private fieldSalesPerson As PivotGridField
		Private fieldQuarter As PivotGridField
		Private fieldExtendedPrice As PivotGridField
		Private fieldQuantity As PivotGridField
		Private fieldOrderCount As PivotGridField
		Private fieldNewYearBonus As PivotGridField
		Private fieldOrderCountBonus As PivotGridField
		Private fieldBonusAmount As PivotGridField
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbSalesPerson As DevExpress.XtraEditors.ImageComboBoxEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnAddBonus As DevExpress.XtraEditors.SimpleButton
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
