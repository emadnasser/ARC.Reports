Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class ClipboardFormats
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
			Dim treeListFormatRule1 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom1 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim treeListFormatRule2 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom2 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim treeListFormatRule3 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleContains1 As New DevExpress.XtraEditors.FormatConditionRuleContains()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ClipboardFormats))
			Dim treeListFormatRule4 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleValue1 As New DevExpress.XtraEditors.FormatConditionRuleValue()
			Dim treeListFormatRule5 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleValue2 As New DevExpress.XtraEditors.FormatConditionRuleValue()
			Dim treeListFormatRule6 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleValue3 As New DevExpress.XtraEditors.FormatConditionRuleValue()
			Dim treeListFormatRule7 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleValue4 As New DevExpress.XtraEditors.FormatConditionRuleValue()
			Dim treeListFormatRule8 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom3 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim treeListFormatRule9 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom4 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim treeListFormatRule10 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom5 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Dim treeListFormatRule11 As New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
			Dim formatConditionRuleTopBottom6 As New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
			Me.colMarketShare = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colRegion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colSeptSalesPrev = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colMarchSalesPrev = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colSeptSales = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colMarchSales = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeList = New DevExpress.XtraTreeList.Demos.ClipboardTreeListControl()
			Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
			Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
			Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
			Me.simpleButtonCopyPaste = New DevExpress.XtraEditors.SimpleButton()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
			Me.propertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.richEditLCI = New DevExpress.XtraLayout.LayoutControlItem()
			Me.gridViewPropertiesLayoutGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItemProperties = New DevExpress.XtraLayout.SplitterItem()
			Me.webBrowserLCI = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItemGrid = New DevExpress.XtraLayout.SplitterItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.copyPasteButtonLCI = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.propertyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.richEditLCI, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridViewPropertiesLayoutGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitterItemProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.webBrowserLCI, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitterItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.copyPasteButtonLCI, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colMarketShare
			' 
			Me.colMarketShare.Caption = "Market Share"
			Me.colMarketShare.FieldName = "MarketShare"
			Me.colMarketShare.Format.FormatString = "p0"
			Me.colMarketShare.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colMarketShare.Name = "colMarketShare"
			Me.colMarketShare.Visible = True
			Me.colMarketShare.VisibleIndex = 5
			Me.colMarketShare.Width = 61
			' 
			' colRegion
			' 
			Me.colRegion.Caption = " Region"
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.VisibleIndex = 0
			Me.colRegion.Width = 46
			' 
			' colSeptSalesPrev
			' 
			Me.colSeptSalesPrev.Caption = "September"
			Me.colSeptSalesPrev.FieldName = "September From Prior Year"
			Me.colSeptSalesPrev.Format.FormatString = "p"
			Me.colSeptSalesPrev.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSeptSalesPrev.Name = "colSeptSalesPrev"
			Me.colSeptSalesPrev.UnboundExpression = "([SeptemberSales] - [SeptemberSalesPrev]) / [SeptemberSales] "
			Me.colSeptSalesPrev.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal
			Me.colSeptSalesPrev.Visible = True
			Me.colSeptSalesPrev.VisibleIndex = 4
			Me.colSeptSalesPrev.Width = 53
			' 
			' colMarchSalesPrev
			' 
			Me.colMarchSalesPrev.Caption = "March"
			Me.colMarchSalesPrev.FieldName = "March From Prior Year"
			Me.colMarchSalesPrev.Format.FormatString = "p"
			Me.colMarchSalesPrev.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colMarchSalesPrev.Name = "colMarchSalesPrev"
			Me.colMarchSalesPrev.UnboundExpression = "([MarchSales] - [MarchSalesPrev]) / [MarchSales] "
			Me.colMarchSalesPrev.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal
			Me.colMarchSalesPrev.Visible = True
			Me.colMarchSalesPrev.VisibleIndex = 3
			Me.colMarchSalesPrev.Width = 51
			' 
			' colSeptSales
			' 
			Me.colSeptSales.Caption = "September"
			Me.colSeptSales.FieldName = "SeptemberSales"
			Me.colSeptSales.Name = "colSeptSales"
			Me.colSeptSales.Visible = True
			Me.colSeptSales.VisibleIndex = 2
			Me.colSeptSales.Width = 46
			' 
			' colMarchSales
			' 
			Me.colMarchSales.Caption = "March"
			Me.colMarchSales.FieldName = "MarchSales"
			Me.colMarchSales.Name = "colMarchSales"
			Me.colMarchSales.Visible = True
			Me.colMarchSales.VisibleIndex = 1
			Me.colMarchSales.Width = 44
			' 
			' treeList
			' 
			Me.treeList.Bands.AddRange(New DevExpress.XtraTreeList.Columns.TreeListBand() { Me.treeListBand1, Me.treeListBand2, Me.treeListBand3})
			Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colRegion, Me.colMarchSales, Me.colSeptSales, Me.colMarchSalesPrev, Me.colSeptSalesPrev, Me.colMarketShare})
			treeListFormatRule1.Column = Me.colMarketShare
			treeListFormatRule1.Name = "Market Share Bottom"
			formatConditionRuleTopBottom1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom1.Appearance.ForeColor = System.Drawing.Color.DarkRed
			formatConditionRuleTopBottom1.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom1.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom1.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom1.Rank = New Decimal(New Integer() { 20, 0, 0, 0})
			formatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent
			formatConditionRuleTopBottom1.TopBottom = DevExpress.XtraEditors.FormatConditionTopBottomType.Bottom
			treeListFormatRule1.Rule = formatConditionRuleTopBottom1
			treeListFormatRule2.Column = Me.colMarketShare
			treeListFormatRule2.Name = "Market Share Top"
			formatConditionRuleTopBottom2.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom2.Appearance.ForeColor = System.Drawing.Color.DarkGreen
			formatConditionRuleTopBottom2.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom2.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom2.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom2.Rank = New Decimal(New Integer() { 20, 0, 0, 0})
			formatConditionRuleTopBottom2.RankType = DevExpress.XtraEditors.FormatConditionValueType.Percent
			treeListFormatRule2.Rule = formatConditionRuleTopBottom2
			treeListFormatRule3.ApplyToRow = True
			treeListFormatRule3.Column = Me.colRegion
			treeListFormatRule3.Name = "Region Name"
			formatConditionRuleContains1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleContains1.Appearance.Options.UseFont = True
			formatConditionRuleContains1.Values = (DirectCast(resources.GetObject("formatConditionRuleContains1.Values"), System.Collections.IList))
			treeListFormatRule3.Rule = formatConditionRuleContains1
			treeListFormatRule4.Column = Me.colSeptSalesPrev
			treeListFormatRule4.Name = "Change Sept Positive"
			formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.DarkGreen
			formatConditionRuleValue1.Appearance.Options.UseForeColor = True
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
			formatConditionRuleValue1.Value1 = "0"
			treeListFormatRule4.Rule = formatConditionRuleValue1
			treeListFormatRule5.Column = Me.colSeptSalesPrev
			treeListFormatRule5.Name = "Change Sept Negative"
			formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.DarkRed
			formatConditionRuleValue2.Appearance.Options.UseForeColor = True
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less
			formatConditionRuleValue2.Value1 = "0"
			treeListFormatRule5.Rule = formatConditionRuleValue2
			treeListFormatRule6.Column = Me.colMarchSalesPrev
			treeListFormatRule6.Name = "Change March Positive"
			formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.DarkGreen
			formatConditionRuleValue3.Appearance.Options.UseForeColor = True
			formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater
			formatConditionRuleValue3.Value1 = "0"
			treeListFormatRule6.Rule = formatConditionRuleValue3
			treeListFormatRule7.Column = Me.colMarchSalesPrev
			treeListFormatRule7.Name = "Change March Negative"
			formatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.DarkRed
			formatConditionRuleValue4.Appearance.Options.UseForeColor = True
			formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Less
			formatConditionRuleValue4.Value1 = "0"
			treeListFormatRule7.Rule = formatConditionRuleValue4
			treeListFormatRule8.Column = Me.colSeptSales
			treeListFormatRule8.Name = "Sales Sept Top"
			formatConditionRuleTopBottom3.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom3.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom3.Appearance.ForeColor = System.Drawing.Color.DarkGreen
			formatConditionRuleTopBottom3.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom3.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom3.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom3.Rank = New Decimal(New Integer() { 5, 0, 0, 0})
			treeListFormatRule8.Rule = formatConditionRuleTopBottom3
			treeListFormatRule9.Column = Me.colMarchSales
			treeListFormatRule9.Name = "Sales March Top"
			formatConditionRuleTopBottom4.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom4.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom4.Appearance.ForeColor = System.Drawing.Color.DarkGreen
			formatConditionRuleTopBottom4.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom4.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom4.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom4.Rank = New Decimal(New Integer() { 5, 0, 0, 0})
			treeListFormatRule9.Rule = formatConditionRuleTopBottom4
			treeListFormatRule10.Column = Me.colMarchSales
			treeListFormatRule10.Name = "Sales March Bottom"
			formatConditionRuleTopBottom5.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom5.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom5.Appearance.ForeColor = System.Drawing.Color.DarkRed
			formatConditionRuleTopBottom5.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom5.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom5.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom5.Rank = New Decimal(New Integer() { 5, 0, 0, 0})
			formatConditionRuleTopBottom5.TopBottom = DevExpress.XtraEditors.FormatConditionTopBottomType.Bottom
			treeListFormatRule10.Rule = formatConditionRuleTopBottom5
			treeListFormatRule11.Column = Me.colSeptSales
			treeListFormatRule11.Name = "Sales Sept Bottom"
			formatConditionRuleTopBottom6.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			formatConditionRuleTopBottom6.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
			formatConditionRuleTopBottom6.Appearance.ForeColor = System.Drawing.Color.DarkRed
			formatConditionRuleTopBottom6.Appearance.Options.UseBackColor = True
			formatConditionRuleTopBottom6.Appearance.Options.UseFont = True
			formatConditionRuleTopBottom6.Appearance.Options.UseForeColor = True
			formatConditionRuleTopBottom6.Rank = New Decimal(New Integer() { 5, 0, 0, 0})
			formatConditionRuleTopBottom6.TopBottom = DevExpress.XtraEditors.FormatConditionTopBottomType.Bottom
			treeListFormatRule11.Rule = formatConditionRuleTopBottom6
			Me.treeList.FormatRules.Add(treeListFormatRule1)
			Me.treeList.FormatRules.Add(treeListFormatRule2)
			Me.treeList.FormatRules.Add(treeListFormatRule3)
			Me.treeList.FormatRules.Add(treeListFormatRule4)
			Me.treeList.FormatRules.Add(treeListFormatRule5)
			Me.treeList.FormatRules.Add(treeListFormatRule6)
			Me.treeList.FormatRules.Add(treeListFormatRule7)
			Me.treeList.FormatRules.Add(treeListFormatRule8)
			Me.treeList.FormatRules.Add(treeListFormatRule9)
			Me.treeList.FormatRules.Add(treeListFormatRule10)
			Me.treeList.FormatRules.Add(treeListFormatRule11)
			Me.treeList.Location = New System.Drawing.Point(2, 28)
			Me.treeList.Name = "treeList"
			Me.treeList.OptionsBehavior.Editable = False
			Me.treeList.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.True
            Me.treeList.OptionsClipboard.ClipboardMode = Export.ClipboardMode.Formatted
            Me.treeList.OptionsClipboard.CopyCollapsedData = DevExpress.Utils.DefaultBoolean.True
            Me.treeList.OptionsMenu.ShowConditionalFormattingItem = True
            Me.treeList.OptionsSelection.MultiSelect = True
			Me.treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect
			Me.treeList.OptionsView.AllowHtmlDrawHeaders = True
			Me.treeList.OptionsView.AnimationType = DevExpress.XtraTreeList.TreeListAnimationType.AnimateAllContent
			Me.treeList.OptionsView.EnableAppearanceOddRow = True
			Me.treeList.OptionsView.ShowBandsMode = DevExpress.Utils.DefaultBoolean.True
			Me.treeList.ParentFieldName = "RegionID"
			Me.treeList.Size = New System.Drawing.Size(346, 522)
			Me.treeList.TabIndex = 13
			' 
			' treeListBand1
			' 
			Me.treeListBand1.Caption = "<b>Sales</b>"
			Me.treeListBand1.Columns.Add(Me.colRegion)
			Me.treeListBand1.Columns.Add(Me.colMarchSales)
			Me.treeListBand1.Columns.Add(Me.colSeptSales)
			Me.treeListBand1.Name = "treeListBand1"
			Me.treeListBand1.Width = 136
			' 
			' treeListBand2
			' 
			Me.treeListBand2.Caption = "<b>Change From Prior Year</b>"
			Me.treeListBand2.Columns.Add(Me.colMarchSalesPrev)
			Me.treeListBand2.Columns.Add(Me.colSeptSalesPrev)
			Me.treeListBand2.Name = "treeListBand2"
			Me.treeListBand2.Width = 104
			' 
			' treeListBand3
			' 
			Me.treeListBand3.Caption = "<b>Current Market Share </b>"
			Me.treeListBand3.Columns.Add(Me.colMarketShare)
			Me.treeListBand3.Name = "treeListBand3"
			Me.treeListBand3.Width = 61
			' 
			' simpleButtonCopyPaste
			' 
			Me.simpleButtonCopyPaste.Location = New System.Drawing.Point(-55, -63)
			Me.simpleButtonCopyPaste.Name = "simpleButtonCopyPaste"
			Me.simpleButtonCopyPaste.Size = New System.Drawing.Size(272, 22)
			Me.simpleButtonCopyPaste.TabIndex = 20
			Me.simpleButtonCopyPaste.Text = "Copy and Paste"
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Mask.EditMask = "p"
			Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemTextEdit2
			' 
			Me.repositoryItemTextEdit2.AutoHeight = False
			Me.repositoryItemTextEdit2.Mask.EditMask = "p0"
			Me.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.repositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
			Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
			' 
			' repositoryItemTextEdit3
			' 
			Me.repositoryItemTextEdit3.AutoHeight = False
			Me.repositoryItemTextEdit3.Mask.EditMask = "n"
			Me.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.treeList)
			Me.layoutControl1.Controls.Add(Me.spreadsheetControl1)
			Me.layoutControl1.Controls.Add(Me.richEditControl)
			Me.layoutControl1.Controls.Add(Me.propertyGridControl)
			Me.layoutControl1.Controls.Add(Me.panelControl1)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1064, 368, 950, 805)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(985, 552)
			Me.layoutControl1.TabIndex = 21
			Me.layoutControl1.Text = "layoutControl1"
'			Me.layoutControl1.GroupExpandChanged += New DevExpress.XtraLayout.Utils.LayoutGroupEventHandler(Me.layoutControl1_GroupExpandChanged)
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Location = New System.Drawing.Point(357, 18)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			Me.spreadsheetControl1.Options.View.ShowColumnHeaders = False
			Me.spreadsheetControl1.Options.View.ShowPrintArea = False
			Me.spreadsheetControl1.Options.View.ShowRowHeaders = False
			Me.spreadsheetControl1.Size = New System.Drawing.Size(292, 164)
			Me.spreadsheetControl1.TabIndex = 4
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' richEditControl
			' 
			Me.richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
			Me.richEditControl.EnableToolTips = True
			Me.richEditControl.Location = New System.Drawing.Point(357, 202)
			Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Options.Bookmarks.ConflictNameResolution = XtraRichEdit.ConflictNameAction.Keep
			Me.richEditControl.Options.Export.PlainText.ExportFinalParagraphMark = DevExpress.XtraRichEdit.Export.PlainText.ExportFinalParagraphMark.Never
			Me.richEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
			Me.richEditControl.Size = New System.Drawing.Size(292, 164)
			Me.richEditControl.TabIndex = 12
			Me.richEditControl.Views.DraftView.Padding = New System.Windows.Forms.Padding(17, 16, 0, 0)
			' 
			' propertyGridControl
			' 
			Me.propertyGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.propertyGridControl.Location = New System.Drawing.Point(661, 4)
			Me.propertyGridControl.MinimumSize = New System.Drawing.Size(300, 0)
			Me.propertyGridControl.Name = "propertyGridControl"
			Me.propertyGridControl.OptionsView.ShowRootCategories = False
			Me.propertyGridControl.Size = New System.Drawing.Size(300, 543)
			Me.propertyGridControl.TabIndex = 17
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.webBrowser1)
			Me.panelControl1.Location = New System.Drawing.Point(357, 386)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(292, 164)
			Me.panelControl1.TabIndex = 19
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser1.Location = New System.Drawing.Point(2, 2)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(288, 160)
			Me.webBrowser1.TabIndex = 13
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(2, 2)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(346, 22)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 15
			Me.simpleButton1.Text = "Copy and Paste"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButtonCopyPaste_Click)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.richEditLCI, Me.gridViewPropertiesLayoutGroup, Me.splitterItemProperties, Me.webBrowserLCI, Me.splitterItemGrid, Me.layoutControlItem1, Me.copyPasteButtonLCI})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(985, 552)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.spreadsheetControl1
			Me.layoutControlItem2.CustomizationFormText = "Excel format"
			Me.layoutControlItem2.Location = New System.Drawing.Point(355, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(296, 184)
			Me.layoutControlItem2.Text = "Excel format"
			Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(78, 13)
			' 
			' richEditLCI
			' 
			Me.richEditLCI.Control = Me.richEditControl
			Me.richEditLCI.CustomizationFormText = "Rich text format"
			Me.richEditLCI.Location = New System.Drawing.Point(355, 184)
			Me.richEditLCI.Name = "richEditLCI"
			Me.richEditLCI.Size = New System.Drawing.Size(296, 184)
			Me.richEditLCI.Text = "Rich text format"
			Me.richEditLCI.TextLocation = DevExpress.Utils.Locations.Top
			Me.richEditLCI.TextSize = New System.Drawing.Size(78, 13)
			' 
			' gridViewPropertiesLayoutGroup
			' 
			Me.gridViewPropertiesLayoutGroup.CustomizationFormText = "Clipboard Options"
			Me.gridViewPropertiesLayoutGroup.ExpandButtonVisible = True
			Me.gridViewPropertiesLayoutGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem8})
			Me.gridViewPropertiesLayoutGroup.Location = New System.Drawing.Point(656, 0)
			Me.gridViewPropertiesLayoutGroup.Name = "gridViewPropertiesLayoutGroup"
			Me.gridViewPropertiesLayoutGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.gridViewPropertiesLayoutGroup.Size = New System.Drawing.Size(329, 552)
			Me.gridViewPropertiesLayoutGroup.Text = "Clipboard Options"
			Me.gridViewPropertiesLayoutGroup.TextLocation = DevExpress.Utils.Locations.Right
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.propertyGridControl
			Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
			Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(304, 547)
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextVisible = False
			' 
			' splitterItemProperties
			' 
			Me.splitterItemProperties.AllowHotTrack = True
			Me.splitterItemProperties.CustomizationFormText = "splitterItemProperties"
			Me.splitterItemProperties.Location = New System.Drawing.Point(651, 0)
			Me.splitterItemProperties.Name = "splitterItemProperties"
			Me.splitterItemProperties.Size = New System.Drawing.Size(5, 552)
			Me.splitterItemProperties.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			' 
			' webBrowserLCI
			' 
			Me.webBrowserLCI.Control = Me.panelControl1
			Me.webBrowserLCI.CustomizationFormText = "HTML format"
			Me.webBrowserLCI.Location = New System.Drawing.Point(355, 368)
			Me.webBrowserLCI.Name = "webBrowserLCI"
			Me.webBrowserLCI.Size = New System.Drawing.Size(296, 184)
			Me.webBrowserLCI.Text = "HTML format"
			Me.webBrowserLCI.TextLocation = DevExpress.Utils.Locations.Top
			Me.webBrowserLCI.TextSize = New System.Drawing.Size(78, 13)
			' 
			' splitterItemGrid
			' 
			Me.splitterItemGrid.AllowHotTrack = True
			Me.splitterItemGrid.CustomizationFormText = "splitterItemGrid"
			Me.splitterItemGrid.Location = New System.Drawing.Point(350, 0)
			Me.splitterItemGrid.Name = "splitterItemGrid"
			Me.splitterItemGrid.Size = New System.Drawing.Size(5, 552)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.treeList
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 26)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(350, 526)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' copyPasteButtonLCI
			' 
			Me.copyPasteButtonLCI.Control = Me.simpleButton1
			Me.copyPasteButtonLCI.CustomizationFormText = "copyPasteButtonLCI"
			Me.copyPasteButtonLCI.Location = New System.Drawing.Point(0, 0)
			Me.copyPasteButtonLCI.Name = "copyPasteButtonLCI"
			Me.copyPasteButtonLCI.Size = New System.Drawing.Size(350, 26)
			Me.copyPasteButtonLCI.TextSize = New System.Drawing.Size(0, 0)
			Me.copyPasteButtonLCI.TextVisible = False
			' 
			' ClipboardFormats
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.simpleButtonCopyPaste)
			Me.Name = "ClipboardFormats"
			Me.Size = New System.Drawing.Size(985, 552)
'			Me.Load += New System.EventHandler(Me.ClipboardFormats_Load)
			DirectCast(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.propertyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.richEditLCI, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridViewPropertiesLayoutGroup, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitterItemProperties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.webBrowserLCI, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitterItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.copyPasteButtonLCI, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeList As ClipboardTreeListControl
		Private colRegion As Columns.TreeListColumn
		Private colMarchSales As Columns.TreeListColumn
		Private colSeptSales As Columns.TreeListColumn
		Private colMarchSalesPrev As Columns.TreeListColumn
		Private colSeptSalesPrev As Columns.TreeListColumn
		Private colMarketShare As Columns.TreeListColumn
		Private treeListBand1 As Columns.TreeListBand
		Private treeListBand2 As Columns.TreeListBand
		Private treeListBand3 As Columns.TreeListBand
		Private simpleButtonCopyPaste As XtraEditors.SimpleButton
		Private repositoryItemSpinEdit1 As XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemTextEdit1 As XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemTextEdit2 As XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemTextEdit3 As XtraEditors.Repository.RepositoryItemTextEdit
		Private WithEvents layoutControl1 As XtraLayout.LayoutControl
		Private spreadsheetControl1 As XtraSpreadsheet.SpreadsheetControl
		Private richEditControl As XtraRichEdit.RichEditControl
		Private propertyGridControl As XtraVerticalGrid.PropertyGridControl
		Private panelControl1 As XtraEditors.PanelControl
		Private webBrowser1 As System.Windows.Forms.WebBrowser
		Private WithEvents simpleButton1 As XtraEditors.SimpleButton
		Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
		Private richEditLCI As XtraLayout.LayoutControlItem
		Private gridViewPropertiesLayoutGroup As XtraLayout.LayoutControlGroup
		Private layoutControlItem8 As XtraLayout.LayoutControlItem
		Private splitterItemProperties As XtraLayout.SplitterItem
		Private webBrowserLCI As XtraLayout.LayoutControlItem
		Private splitterItemGrid As XtraLayout.SplitterItem
		Private layoutControlItem1 As XtraLayout.LayoutControlItem
		Private copyPasteButtonLCI As XtraLayout.LayoutControlItem
	End Class
End Namespace
