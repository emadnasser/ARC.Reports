Namespace DevExpress.XtraGrid.Demos
	Partial Public Class FilterControl
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterControl))
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.gridColumnUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.gridColumnQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.gridColumnDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.xtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.ceToolTips = New DevExpress.XtraEditors.CheckEdit()
            Me.ceOperandTypeIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.ceGroupCommandsIcon = New DevExpress.XtraEditors.CheckEdit()
            Me.seSeparatorHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.seLevelIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
            Me.ceValue = New DevExpress.XtraEditors.ColorEdit()
            Me.ceOperator = New DevExpress.XtraEditors.ColorEdit()
            Me.ceGroupOperator = New DevExpress.XtraEditors.ColorEdit()
            Me.ceFieldName = New DevExpress.XtraEditors.ColorEdit()
            Me.ceEmptyValue = New DevExpress.XtraEditors.ColorEdit()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sbApply = New DevExpress.XtraEditors.SimpleButton()
            Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.filterControl2 = New DevExpress.XtraEditors.FilterControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.sbReset = New DevExpress.XtraEditors.SimpleButton()
            Me.sbApplyFilter2 = New DevExpress.XtraEditors.SimpleButton()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridColumnID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumnImplemented = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.gridColumnSuspended = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl2.SuspendLayout()
            Me.xtraTabPage3.SuspendLayout()
            CType(Me.ceToolTips.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceOperandTypeIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceGroupCommandsIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seSeparatorHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seLevelIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage4.SuspendLayout()
            CType(Me.ceValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceGroupOperator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceFieldName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceEmptyValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl2.SuspendLayout()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.CaptionImageUri.Uri = ""
            resources.ApplyResources(Me.splitContainerControl1, "splitContainerControl1")
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.filterControl1)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl2)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.xtraTabControl2)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.panelControl1)
            resources.ApplyResources(Me.splitContainerControl1.Panel1, "splitContainerControl1.Panel1")
            Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.splitContainerControl1.Panel2, "splitContainerControl1.Panel2")
            Me.splitContainerControl1.SplitterPosition = 215
            '
            'filterControl1
            '
            Me.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            resources.ApplyResources(Me.filterControl1, "filterControl1")
            Me.filterControl1.Name = "filterControl1"
            Me.filterControl1.SourceControl = Me.gridControl1
            '
            'gridControl1
            '
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumnOrder, Me.gridColumnProduct, Me.gridColumnUnitPrice, Me.gridColumnQuantity, Me.gridColumnDiscount})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType), resources.GetString("gridView1.GroupSummary1"), CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn), resources.GetString("gridView1.GroupSummary3"))})
            Me.gridView1.Images = Me.imageList1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            '
            'gridColumnOrder
            '
            resources.ApplyResources(Me.gridColumnOrder, "gridColumnOrder")
            Me.gridColumnOrder.FieldName = "OrderID"
            Me.gridColumnOrder.Name = "gridColumnOrder"
            '
            'gridColumnProduct
            '
            resources.ApplyResources(Me.gridColumnProduct, "gridColumnProduct")
            Me.gridColumnProduct.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.gridColumnProduct.FieldName = "ProductID"
            Me.gridColumnProduct.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.gridColumnProduct.Image = CType(resources.GetObject("gridColumnProduct.Image"), System.Drawing.Image)
            Me.gridColumnProduct.Name = "gridColumnProduct"
            '
            'repositoryItemLookUpEdit1
            '
            resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            '
            'gridColumnUnitPrice
            '
            resources.ApplyResources(Me.gridColumnUnitPrice, "gridColumnUnitPrice")
            Me.gridColumnUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.gridColumnUnitPrice.DisplayFormat.FormatString = "c"
            Me.gridColumnUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumnUnitPrice.FieldName = "UnitPrice"
            Me.gridColumnUnitPrice.Name = "gridColumnUnitPrice"
            '
            'repositoryItemCalcEdit1
            '
            resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'gridColumnQuantity
            '
            resources.ApplyResources(Me.gridColumnQuantity, "gridColumnQuantity")
            Me.gridColumnQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumnQuantity.FieldName = "Quantity"
            Me.gridColumnQuantity.Name = "gridColumnQuantity"
            '
            'repositoryItemSpinEdit1
            '
            resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = resources.GetString("repositoryItemSpinEdit1.Mask.EditMask")
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'gridColumnDiscount
            '
            resources.ApplyResources(Me.gridColumnDiscount, "gridColumnDiscount")
            Me.gridColumnDiscount.DisplayFormat.FormatString = "p"
            Me.gridColumnDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumnDiscount.FieldName = "Discount"
            Me.gridColumnDiscount.Name = "gridColumnDiscount"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.panelControl2, "panelControl2")
            Me.panelControl2.Name = "panelControl2"
            '
            'xtraTabControl2
            '
            resources.ApplyResources(Me.xtraTabControl2, "xtraTabControl2")
            Me.xtraTabControl2.Name = "xtraTabControl2"
            Me.xtraTabControl2.SelectedTabPage = Me.xtraTabPage3
            Me.xtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage3, Me.xtraTabPage4})
            '
            'xtraTabPage3
            '
            Me.xtraTabPage3.Controls.Add(Me.ceToolTips)
            Me.xtraTabPage3.Controls.Add(Me.ceOperandTypeIcon)
            Me.xtraTabPage3.Controls.Add(Me.ceGroupCommandsIcon)
            Me.xtraTabPage3.Controls.Add(Me.seSeparatorHeight)
            Me.xtraTabPage3.Controls.Add(Me.labelControl7)
            Me.xtraTabPage3.Controls.Add(Me.seLevelIndent)
            Me.xtraTabPage3.Controls.Add(Me.labelControl6)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            resources.ApplyResources(Me.xtraTabPage3, "xtraTabPage3")
            '
            'ceToolTips
            '
            resources.ApplyResources(Me.ceToolTips, "ceToolTips")
            Me.ceToolTips.Name = "ceToolTips"
            Me.ceToolTips.Properties.Caption = resources.GetString("ceToolTips.Properties.Caption")
            '
            'ceOperandTypeIcon
            '
            resources.ApplyResources(Me.ceOperandTypeIcon, "ceOperandTypeIcon")
            Me.ceOperandTypeIcon.Name = "ceOperandTypeIcon"
            Me.ceOperandTypeIcon.Properties.Caption = resources.GetString("ceOperandTypeIcon.Properties.Caption")
            '
            'ceGroupCommandsIcon
            '
            resources.ApplyResources(Me.ceGroupCommandsIcon, "ceGroupCommandsIcon")
            Me.ceGroupCommandsIcon.Name = "ceGroupCommandsIcon"
            Me.ceGroupCommandsIcon.Properties.Caption = resources.GetString("ceGroupCommandsIcon.Properties.Caption")
            '
            'seSeparatorHeight
            '
            resources.ApplyResources(Me.seSeparatorHeight, "seSeparatorHeight")
            Me.seSeparatorHeight.Name = "seSeparatorHeight"
            Me.seSeparatorHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSeparatorHeight.Properties.IsFloatValue = False
            Me.seSeparatorHeight.Properties.Mask.EditMask = resources.GetString("seSeparatorHeight.Properties.Mask.EditMask")
            Me.seSeparatorHeight.Properties.MaxValue = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'labelControl7
            '
            Me.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl7, "labelControl7")
            Me.labelControl7.Name = "labelControl7"
            '
            'seLevelIndent
            '
            resources.ApplyResources(Me.seLevelIndent, "seLevelIndent")
            Me.seLevelIndent.Name = "seLevelIndent"
            Me.seLevelIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLevelIndent.Properties.IsFloatValue = False
            Me.seLevelIndent.Properties.Mask.EditMask = resources.GetString("seLevelIndent.Properties.Mask.EditMask")
            Me.seLevelIndent.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seLevelIndent.Properties.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'labelControl6
            '
            Me.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl6, "labelControl6")
            Me.labelControl6.Name = "labelControl6"
            '
            'xtraTabPage4
            '
            Me.xtraTabPage4.Controls.Add(Me.ceValue)
            Me.xtraTabPage4.Controls.Add(Me.ceOperator)
            Me.xtraTabPage4.Controls.Add(Me.ceGroupOperator)
            Me.xtraTabPage4.Controls.Add(Me.ceFieldName)
            Me.xtraTabPage4.Controls.Add(Me.ceEmptyValue)
            Me.xtraTabPage4.Controls.Add(Me.labelControl5)
            Me.xtraTabPage4.Controls.Add(Me.labelControl4)
            Me.xtraTabPage4.Controls.Add(Me.labelControl3)
            Me.xtraTabPage4.Controls.Add(Me.labelControl2)
            Me.xtraTabPage4.Controls.Add(Me.labelControl1)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            resources.ApplyResources(Me.xtraTabPage4, "xtraTabPage4")
            '
            'ceValue
            '
            resources.ApplyResources(Me.ceValue, "ceValue")
            Me.ceValue.Name = "ceValue"
            Me.ceValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceValue.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceOperator
            '
            resources.ApplyResources(Me.ceOperator, "ceOperator")
            Me.ceOperator.Name = "ceOperator"
            Me.ceOperator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceOperator.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceGroupOperator
            '
            resources.ApplyResources(Me.ceGroupOperator, "ceGroupOperator")
            Me.ceGroupOperator.Name = "ceGroupOperator"
            Me.ceGroupOperator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceGroupOperator.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceGroupOperator.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceFieldName
            '
            resources.ApplyResources(Me.ceFieldName, "ceFieldName")
            Me.ceFieldName.Name = "ceFieldName"
            Me.ceFieldName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceFieldName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceFieldName.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'ceEmptyValue
            '
            resources.ApplyResources(Me.ceEmptyValue, "ceEmptyValue")
            Me.ceEmptyValue.Name = "ceEmptyValue"
            Me.ceEmptyValue.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.ceEmptyValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("ceEmptyValue.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            '
            'labelControl5
            '
            Me.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl5, "labelControl5")
            Me.labelControl5.Name = "labelControl5"
            '
            'labelControl4
            '
            Me.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl4, "labelControl4")
            Me.labelControl4.Name = "labelControl4"
            '
            'labelControl3
            '
            Me.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl3, "labelControl3")
            Me.labelControl3.Name = "labelControl3"
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.Name = "labelControl2"
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.sbApply)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            '
            'sbApply
            '
            resources.ApplyResources(Me.sbApply, "sbApply")
            Me.sbApply.Name = "sbApply"
            '
            'splitContainerControl2
            '
            Me.splitContainerControl2.CaptionImageUri.Uri = ""
            resources.ApplyResources(Me.splitContainerControl2, "splitContainerControl2")
            Me.splitContainerControl2.Horizontal = False
            Me.splitContainerControl2.Name = "splitContainerControl2"
            Me.splitContainerControl2.Panel1.Controls.Add(Me.filterControl2)
            Me.splitContainerControl2.Panel1.Controls.Add(Me.panelControl3)
            resources.ApplyResources(Me.splitContainerControl2.Panel1, "splitContainerControl2.Panel1")
            Me.splitContainerControl2.Panel2.Controls.Add(Me.gridControl2)
            resources.ApplyResources(Me.splitContainerControl2.Panel2, "splitContainerControl2.Panel2")
            Me.splitContainerControl2.SplitterPosition = 161
            '
            'filterControl2
            '
            resources.ApplyResources(Me.filterControl2, "filterControl2")
            Me.filterControl2.Name = "filterControl2"
            '
            'panelControl3
            '
            Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl3.Controls.Add(Me.sbReset)
            Me.panelControl3.Controls.Add(Me.sbApplyFilter2)
            resources.ApplyResources(Me.panelControl3, "panelControl3")
            Me.panelControl3.Name = "panelControl3"
            '
            'sbReset
            '
            resources.ApplyResources(Me.sbReset, "sbReset")
            Me.sbReset.Name = "sbReset"
            '
            'sbApplyFilter2
            '
            resources.ApplyResources(Me.sbApplyFilter2, "sbApplyFilter2")
            Me.sbApplyFilter2.Name = "sbApplyFilter2"
            '
            'gridControl2
            '
            resources.ApplyResources(Me.gridControl2, "gridControl2")
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemProgressBar1})
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            '
            'gridView2
            '
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumnID, Me.gridColumnSubject, Me.gridColumnImplemented, Me.gridColumnSuspended})
            StyleFormatCondition1.Appearance.Font = CType(resources.GetObject("resource.Font"), System.Drawing.Font)
            StyleFormatCondition1.Appearance.ForeColor = CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color)
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.Appearance.Options.UseForeColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.gridColumnSuspended
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = True
            Me.gridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.OptionsView.ShowIndicator = False
            '
            'gridColumnID
            '
            resources.ApplyResources(Me.gridColumnID, "gridColumnID")
            Me.gridColumnID.FieldName = "ID"
            Me.gridColumnID.Name = "gridColumnID"
            '
            'gridColumnSubject
            '
            resources.ApplyResources(Me.gridColumnSubject, "gridColumnSubject")
            Me.gridColumnSubject.FieldName = "Subject"
            Me.gridColumnSubject.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
            Me.gridColumnSubject.Name = "gridColumnSubject"
            '
            'gridColumnImplemented
            '
            resources.ApplyResources(Me.gridColumnImplemented, "gridColumnImplemented")
            Me.gridColumnImplemented.ColumnEdit = Me.repositoryItemProgressBar1
            Me.gridColumnImplemented.FieldName = "Implemented"
            Me.gridColumnImplemented.Name = "gridColumnImplemented"
            Me.gridColumnImplemented.OptionsColumn.AllowFocus = False
            '
            'repositoryItemProgressBar1
            '
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            '
            'gridColumnSuspended
            '
            resources.ApplyResources(Me.gridColumnSuspended, "gridColumnSuspended")
            Me.gridColumnSuspended.FieldName = "Suspended"
            Me.gridColumnSuspended.Name = "gridColumnSuspended"
            '
            'xtraTabControl1
            '
            resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.splitContainerControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.splitContainerControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
            '
            'FilterControl
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "FilterControl"
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl2.ResumeLayout(False)
            Me.xtraTabPage3.ResumeLayout(False)
            Me.xtraTabPage3.PerformLayout()
            CType(Me.ceToolTips.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceOperandTypeIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceGroupCommandsIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seSeparatorHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seLevelIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage4.ResumeLayout(False)
            Me.xtraTabPage4.PerformLayout()
            CType(Me.ceValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceGroupOperator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceFieldName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceEmptyValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl2.ResumeLayout(False)
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private filterControl1 As DevExpress.XtraEditors.FilterControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumnOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnProduct As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private gridColumnUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private gridColumnQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumnDiscount As DevExpress.XtraGrid.Columns.GridColumn
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbApply As DevExpress.XtraEditors.SimpleButton
		Private xtraTabControl2 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents ceEmptyValue As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceFieldName As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceGroupOperator As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceOperator As DevExpress.XtraEditors.ColorEdit
		Private WithEvents ceValue As DevExpress.XtraEditors.ColorEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl6 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seLevelIndent As DevExpress.XtraEditors.SpinEdit
		Private WithEvents seSeparatorHeight As DevExpress.XtraEditors.SpinEdit
		Private labelControl7 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceGroupCommandsIcon As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceOperandTypeIcon As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceToolTips As DevExpress.XtraEditors.CheckEdit
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private filterControl2 As DevExpress.XtraEditors.FilterControl
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumnID As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnImplemented As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumnSuspended As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbApplyFilter2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbReset As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer
	End Class
End Namespace
