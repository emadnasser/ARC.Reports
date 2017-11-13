Namespace DevExpress.XtraGrid.Demos
    Partial Public Class StyleConditions
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(StyleConditions))
            Dim gridFormatRule1 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression1 As New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule2 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression2 As New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule3 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression3 As New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule4 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleExpression4 As New DevExpress.XtraEditors.FormatConditionRuleExpression()
            Dim gridFormatRule5 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule6 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule7 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue3 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule8 As New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue4 As New DevExpress.XtraEditors.FormatConditionRuleValue()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.expressionConditionsEditor1 = New DevExpress.XtraGrid.Demos.ExpressionConditionsEditor()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gcOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gcProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gcUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gcQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gcDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gcTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Demos.MyGridView()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.ceTranslucentColors = New DevExpress.XtraEditors.CheckEdit()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType(Me.ceTranslucentColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
            resources.ApplyResources(Me.splitContainerControl1, "splitContainerControl1")
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.expressionConditionsEditor1)
            Me.splitContainerControl1.Panel1.MinSize = 200
            resources.ApplyResources(Me.splitContainerControl1.Panel1, "splitContainerControl1.Panel1")
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl2)
            resources.ApplyResources(Me.splitContainerControl1.Panel2, "splitContainerControl1.Panel2")
            Me.splitContainerControl1.SplitterPosition = 210
            ' 
            ' expressionConditionsEditor1
            ' 
            resources.ApplyResources(Me.expressionConditionsEditor1, "expressionConditionsEditor1")
            Me.expressionConditionsEditor1.Name = "expressionConditionsEditor1"
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit3, Me.repositoryItemTextEdit1})
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcOrderID, Me.gcProduct, Me.gcUnitPrice, Me.gcQuantity, Me.gcDiscount, Me.gcTotal})
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.gcQuantity
            gridFormatRule1.Name = "Format0"
            formatConditionRuleExpression1.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor"), System.Drawing.Color))
            formatConditionRuleExpression1.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = True
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression1.Expression = "[Quantity] >= 20 And [Discount] != 0"
            gridFormatRule1.Rule = formatConditionRuleExpression1
            gridFormatRule2.ApplyToRow = True
            gridFormatRule2.Column = Me.gcQuantity
            gridFormatRule2.Name = "Format1"
            formatConditionRuleExpression2.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor1"), System.Drawing.Color))
            formatConditionRuleExpression2.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor1"), System.Drawing.Color))
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = True
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression2.Expression = "[Quantity] <= 20 AND [Total] < 100"
            gridFormatRule2.Rule = formatConditionRuleExpression2
            gridFormatRule3.Column = Me.gcTotal
            gridFormatRule3.Name = "Format2"
            formatConditionRuleExpression3.Appearance.Font = (CType(resources.GetObject("resource.Font"), System.Drawing.Font))
            formatConditionRuleExpression3.Appearance.Options.UseFont = True
            formatConditionRuleExpression3.Expression = "[Total] >= 500"
            gridFormatRule3.Rule = formatConditionRuleExpression3
            gridFormatRule4.ApplyToRow = True
            gridFormatRule4.Column = Me.gcTotal
            gridFormatRule4.Name = "Format3"
            formatConditionRuleExpression4.Appearance.Font = (CType(resources.GetObject("resource.Font1"), System.Drawing.Font))
            formatConditionRuleExpression4.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor2"), System.Drawing.Color))
            formatConditionRuleExpression4.Appearance.Options.UseFont = True
            formatConditionRuleExpression4.Appearance.Options.UseForeColor = True
            formatConditionRuleExpression4.Expression = "[Total] < 50 And [Discount] != 0"
            gridFormatRule4.Rule = formatConditionRuleExpression4
            Me.gridView2.FormatRules.Add(gridFormatRule1)
            Me.gridView2.FormatRules.Add(gridFormatRule2)
            Me.gridView2.FormatRules.Add(gridFormatRule3)
            Me.gridView2.FormatRules.Add(gridFormatRule4)
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView2.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView2.GroupSummary1"), (CType(resources.GetObject("gridView2.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView2.GroupSummary3"))})
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowIndicator = False
            ' 
            ' gcOrderID
            ' 
            Me.gcOrderID.FieldName = "OrderID"
            Me.gcOrderID.Name = "gcOrderID"
            resources.ApplyResources(Me.gcOrderID, "gcOrderID")
            ' 
            ' gcProduct
            ' 
            resources.ApplyResources(Me.gcProduct, "gcProduct")
            Me.gcProduct.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gcProduct.FieldName = "ProductID"
            Me.gcProduct.Name = "gcProduct"
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' gcUnitPrice
            ' 
            Me.gcUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gcUnitPrice.DisplayFormat.FormatString = "c"
            Me.gcUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcUnitPrice.FieldName = "UnitPrice"
            Me.gcUnitPrice.Name = "gcUnitPrice"
            resources.ApplyResources(Me.gcUnitPrice, "gcUnitPrice")
            ' 
            ' repositoryItemCalcEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemCalcEdit1.Mask.EditMask = resources.GetString("repositoryItemCalcEdit1.Mask.EditMask")
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' gcQuantity
            ' 
            resources.ApplyResources(Me.gcQuantity, "gcQuantity")
            Me.gcQuantity.ColumnEdit = Me.repositoryItemSpinEdit3
            Me.gcQuantity.FieldName = "Quantity"
            Me.gcQuantity.Name = "gcQuantity"
            ' 
            ' repositoryItemSpinEdit3
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit3, "repositoryItemSpinEdit3")
            Me.repositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit3.IsFloatValue = False
            Me.repositoryItemSpinEdit3.Mask.EditMask = resources.GetString("repositoryItemSpinEdit3.Mask.EditMask")
            Me.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3"
            ' 
            ' gcDiscount
            ' 
            resources.ApplyResources(Me.gcDiscount, "gcDiscount")
            Me.gcDiscount.ColumnEdit = Me.repositoryItemTextEdit1
            Me.gcDiscount.DisplayFormat.FormatString = "p"
            Me.gcDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcDiscount.FieldName = "Discount"
            Me.gcDiscount.Name = "gcDiscount"
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.MaskType = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gcTotal
            ' 
            resources.ApplyResources(Me.gcTotal, "gcTotal")
            Me.gcTotal.DisplayFormat.FormatString = "c"
            Me.gcTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gcTotal.FieldName = "Total"
            Me.gcTotal.Name = "gcTotal"
            Me.gcTotal.OptionsColumn.ReadOnly = True
            Me.gcTotal.ShowUnboundExpressionMenu = True
            Me.gcTotal.UnboundExpression = "([UnitPrice] * [Quantity]) * (1 - [Discount])"
            Me.gcTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            ' 
            ' repositoryItemSpinEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colDiscontinued
            ' 
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' colProductName
            ' 
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            ' 
            ' colQuantityPerUnit
            ' 
            resources.ApplyResources(Me.colQuantityPerUnit, "colQuantityPerUnit")
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.Row.Options.UseTextOptions = True
            Me.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            gridFormatRule5.Column = Me.colUnitPrice
            gridFormatRule5.Name = "Format0"
            formatConditionRuleValue1.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor2"), System.Drawing.Color))
            formatConditionRuleValue1.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor3"), System.Drawing.Color))
            formatConditionRuleValue1.Appearance.Options.UseBackColor = True
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual
            formatConditionRuleValue1.Value1 = 18
            gridFormatRule5.Rule = formatConditionRuleValue1
            gridFormatRule6.Column = Me.colUnitPrice
            gridFormatRule6.Name = "Format1"
            formatConditionRuleValue2.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor3"), System.Drawing.Color))
            formatConditionRuleValue2.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor4"), System.Drawing.Color))
            formatConditionRuleValue2.Appearance.Options.UseBackColor = True
            formatConditionRuleValue2.Appearance.Options.UseForeColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.GreaterOrEqual
            formatConditionRuleValue2.Value1 = 40
            gridFormatRule6.Rule = formatConditionRuleValue2
            gridFormatRule7.ApplyToRow = True
            gridFormatRule7.Column = Me.colDiscontinued
            gridFormatRule7.Name = "Format2"
            formatConditionRuleValue3.Appearance.Font = (CType(resources.GetObject("resource.Font2"), System.Drawing.Font))
            formatConditionRuleValue3.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor5"), System.Drawing.Color))
            formatConditionRuleValue3.Appearance.Options.UseFont = True
            formatConditionRuleValue3.Appearance.Options.UseForeColor = True
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue3.Value1 = True
            gridFormatRule7.Rule = formatConditionRuleValue3
            gridFormatRule8.Column = Me.colProductName
            gridFormatRule8.Name = "Format3"
            formatConditionRuleValue4.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor4"), System.Drawing.Color))
            formatConditionRuleValue4.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor6"), System.Drawing.Color))
            formatConditionRuleValue4.Appearance.Options.UseBackColor = True
            formatConditionRuleValue4.Appearance.Options.UseForeColor = True
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Between
            formatConditionRuleValue4.Value1 = "c"
            formatConditionRuleValue4.Value2 = "d"
            gridFormatRule8.Rule = formatConditionRuleValue4
            Me.gridView1.FormatRules.Add(gridFormatRule5)
            Me.gridView1.FormatRules.Add(gridFormatRule6)
            Me.gridView1.FormatRules.Add(gridFormatRule7)
            Me.gridView1.FormatRules.Add(gridFormatRule8)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Images = Me.imageList1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colUnitsInStock
            ' 
            resources.ApplyResources(Me.colUnitsInStock, "colUnitsInStock")
            Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            ' 
            ' repositoryItemSpinEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' colUnitsOnOrder
            ' 
            resources.ApplyResources(Me.colUnitsOnOrder, "colUnitsOnOrder")
            Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            ' 
            ' colReorderLevel
            ' 
            resources.ApplyResources(Me.colReorderLevel, "colReorderLevel")
            Me.colReorderLevel.ColumnEdit = Me.repositoryItemSpinEdit2
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            ' 
            ' imageList1
            ' 
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Controls.Add(Me.ceTranslucentColors)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Controls.Add(Me.simpleButton1)
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            ' 
            ' simpleButton1
            ' 
            resources.ApplyResources(Me.simpleButton1, "simpleButton1")
            Me.simpleButton1.Name = "simpleButton1"
            ' 
            ' ceTranslucentColors
            ' 
            resources.ApplyResources(Me.ceTranslucentColors, "ceTranslucentColors")
            Me.ceTranslucentColors.Name = "ceTranslucentColors"
            Me.ceTranslucentColors.Properties.Caption = resources.GetString("ceTranslucentColors.Properties.Caption")
            ' 
            ' xtraTabControl1
            ' 
            resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage2
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage2, Me.xtraTabPage1})
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.splitContainerControl1)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.gridControl1)
            Me.xtraTabPage1.Controls.Add(Me.panelControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
            ' 
            ' StyleConditions
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "StyleConditions"
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType(Me.ceTranslucentColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Demos.MyGridView
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
        Private imageList1 As System.Windows.Forms.ImageList
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents ceTranslucentColors As DevExpress.XtraEditors.CheckEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private gridControl2 As GridControl
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gcOrderID As DevExpress.XtraGrid.Columns.GridColumn
        Private gcProduct As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private gcUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private gcQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private gcDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private gcTotal As DevExpress.XtraGrid.Columns.GridColumn
        Private expressionConditionsEditor1 As ExpressionConditionsEditor
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

    End Class
End Namespace
