Namespace DevExpress.XtraGrid.Demos
	Partial Public Class CustomDraw
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDraw))
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindProducts1 = New dsNWindProducts()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colProductName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imlCategories = New System.Windows.Forms.ImageList(Me.components)
			Me.colProductID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colSupplierID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colReorderLevel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDiscontinued = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colUnitsOnOrder = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colUnitsInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.imlIndicator = New System.Windows.Forms.ImageList(Me.components)
			Me.toolBar1 = New System.Windows.Forms.ToolBar()
			Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton10 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton11 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton12 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton13 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton14 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton15 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton16 = New System.Windows.Forms.ToolBarButton()
			Me.imlToolBar = New System.Windows.Forms.ImageList(Me.components)
			Me.imlCustomDrawImages = New System.Windows.Forms.ImageList(Me.components)
			Me.imlFilterShapes = New System.Windows.Forms.ImageList(Me.components)
			Me.imlSortShapes = New System.Windows.Forms.ImageList(Me.components)
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colLink = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.colPlatform = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.xtraGridBlending1 = New DevExpress.XtraGrid.Blending.XtraGridBlending()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.Appearance.Card.BackColor = System.Drawing.Color.Aquamarine
			Me.cardView1.Appearance.Card.Options.UseBackColor = True
			Me.cardView1.Appearance.CardButton.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.cardView1.Appearance.CardButton.Options.UseFont = True
			Me.cardView1.Appearance.CardCaption.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.cardView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black
			Me.cardView1.Appearance.CardCaption.Options.UseFont = True
			Me.cardView1.Appearance.CardCaption.Options.UseForeColor = True
			Me.cardView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.Transparent
			Me.cardView1.Appearance.EmptySpace.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.cardView1.Appearance.EmptySpace.Options.UseBackColor = True
			Me.cardView1.Appearance.EmptySpace.Options.UseFont = True
			Me.cardView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.Aquamarine
			Me.cardView1.Appearance.FieldCaption.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.cardView1.Appearance.FieldCaption.Options.UseBackColor = True
			Me.cardView1.Appearance.FieldCaption.Options.UseFont = True
			Me.cardView1.Appearance.FieldValue.BackColor = System.Drawing.Color.DarkSeaGreen
			Me.cardView1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.cardView1.Appearance.FieldValue.Options.UseBackColor = True
			Me.cardView1.Appearance.FieldValue.Options.UseFont = True
			Me.cardView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Navy
			Me.cardView1.Appearance.FocusedCardCaption.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.cardView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White
			Me.cardView1.Appearance.FocusedCardCaption.Options.UseBorderColor = True
			Me.cardView1.Appearance.FocusedCardCaption.Options.UseFont = True
			Me.cardView1.Appearance.FocusedCardCaption.Options.UseForeColor = True
			Me.cardView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.White
			Me.cardView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = True
			Me.cardView1.Appearance.SeparatorLine.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.cardView1.Appearance.SeparatorLine.Options.UseFont = True
			Me.cardView1.CardCaptionFormat = "Order ID: {1}"
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colQuantity, Me.colUnitPrice1, Me.colDiscount, Me.colSubTotal})
			Me.cardView1.DetailHeight = 150
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			Me.cardView1.OptionsView.ShowCardExpandButton = False
			Me.cardView1.OptionsView.ShowQuickCustomizeButton = False
'			Me.cardView1.CustomDrawCardFieldValue += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.cardView1_CustomDrawCardFieldValue)
'			Me.cardView1.CustomDrawCardCaption += New DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(Me.cardView1_CustomDrawCardCaption)
'			Me.cardView1.CustomDrawCardFieldCaption += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.cardView1_CustomDrawCardFieldCaption)
			' 
			' colOrderID
			' 
			Me.colOrderID.Caption = "Order ID"
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			' 
			' colQuantity
			' 
			Me.colQuantity.Caption = "Quantity"
			Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colQuantity.FieldName = "Quantity"
			Me.colQuantity.Name = "colQuantity"
			Me.colQuantity.Visible = True
			Me.colQuantity.VisibleIndex = 1
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' colUnitPrice1
			' 
			Me.colUnitPrice1.Caption = "Unit Price"
			Me.colUnitPrice1.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.colUnitPrice1.DisplayFormat.FormatString = "c"
			Me.colUnitPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colUnitPrice1.FieldName = "UnitPrice"
			Me.colUnitPrice1.Name = "colUnitPrice1"
			Me.colUnitPrice1.Visible = True
			Me.colUnitPrice1.VisibleIndex = 0
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' colDiscount
			' 
			Me.colDiscount.Caption = "Discount"
			Me.colDiscount.DisplayFormat.FormatString = "p"
			Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colDiscount.FieldName = "Discount"
			Me.colDiscount.Name = "colDiscount"
			Me.colDiscount.Visible = True
			Me.colDiscount.VisibleIndex = 2
			' 
			' colSubTotal
			' 
			Me.colSubTotal.Caption = "Sub Total"
			Me.colSubTotal.DisplayFormat.FormatString = "c"
			Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSubTotal.FieldName = "SubTotal"
			Me.colSubTotal.Name = "colSubTotal"
			Me.colSubTotal.OptionsColumn.AllowEdit = False
			Me.colSubTotal.OptionsColumn.ReadOnly = True
			Me.colSubTotal.Visible = True
			Me.colSubTotal.VisibleIndex = 3
			' 
			' gridControl1
			' 
			Me.gridControl1.BackgroundImage = (CType(resources.GetObject("gridControl1.BackgroundImage"), System.Drawing.Image))
			Me.gridControl1.DataSource = Me.dsNWindProducts1.Products
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.cardView1
			gridLevelNode1.RelationName = "ProductsOrder_x0020_Details"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 32)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(711, 458)
			Me.gridControl1.TabIndex = 11
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.advBandedGridView1, Me.cardView1})
			' 
			' dsNWindProducts1
			' 
			Me.dsNWindProducts1.DataSetName = "dsNWindProducts"
			Me.dsNWindProducts1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Appearance.BandPanel.Font = New System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold)
			Me.advBandedGridView1.Appearance.BandPanel.Options.UseFont = True
			Me.advBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White
			Me.advBandedGridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.WhiteSmoke
			Me.advBandedGridView1.Appearance.EvenRow.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
			Me.advBandedGridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
			Me.advBandedGridView1.Appearance.EvenRow.Options.UseBackColor = True
			Me.advBandedGridView1.Appearance.EvenRow.Options.UseFont = True
			Me.advBandedGridView1.Appearance.EvenRow.Options.UseForeColor = True
			Me.advBandedGridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.FocusedCell.Options.UseFont = True
			Me.advBandedGridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkBlue
			Me.advBandedGridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.SteelBlue
			Me.advBandedGridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
			Me.advBandedGridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
			Me.advBandedGridView1.Appearance.FocusedRow.Options.UseBackColor = True
			Me.advBandedGridView1.Appearance.FocusedRow.Options.UseFont = True
			Me.advBandedGridView1.Appearance.FocusedRow.Options.UseForeColor = True
			Me.advBandedGridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold)
			Me.advBandedGridView1.Appearance.FooterPanel.Options.UseFont = True
			Me.advBandedGridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold)
			Me.advBandedGridView1.Appearance.GroupFooter.Options.UseFont = True
			Me.advBandedGridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold)
			Me.advBandedGridView1.Appearance.HeaderPanel.Options.UseFont = True
			Me.advBandedGridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.DimGray
			Me.advBandedGridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Silver
			Me.advBandedGridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(224)))), (CInt((CByte(224)))))
			Me.advBandedGridView1.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
			Me.advBandedGridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
			Me.advBandedGridView1.Appearance.HideSelectionRow.Options.UseFont = True
			Me.advBandedGridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
			Me.advBandedGridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.DarkGray
			Me.advBandedGridView1.Appearance.HorzLine.Options.UseBackColor = True
			Me.advBandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.AntiqueWhite
			Me.advBandedGridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
			Me.advBandedGridView1.Appearance.OddRow.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.OddRow.Options.UseBackColor = True
			Me.advBandedGridView1.Appearance.OddRow.Options.UseFont = True
			Me.advBandedGridView1.Appearance.Row.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.advBandedGridView1.Appearance.Row.Options.UseFont = True
			Me.advBandedGridView1.Appearance.VertLine.BackColor = System.Drawing.Color.DarkGray
			Me.advBandedGridView1.Appearance.VertLine.Options.UseBackColor = True
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
			styleFormatCondition1.Appearance.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Strikeout)
			styleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark
			styleFormatCondition1.Appearance.Options.UseFont = True
			styleFormatCondition1.Appearance.Options.UseForeColor = True
			styleFormatCondition1.ApplyToRow = True
			styleFormatCondition1.Column = Me.colDiscontinued
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition1.Value1 = True
			Me.advBandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.GroupCount = 1
			Me.advBandedGridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProductID", Nothing, "")})
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsDetail.AllowZoomDetail = False
			Me.advBandedGridView1.OptionsDetail.ShowDetailTabs = False
			Me.advBandedGridView1.OptionsNavigation.UseAdvVertNavigation = False
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
			Me.advBandedGridView1.OptionsView.EnableAppearanceOddRow = True
			Me.advBandedGridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard
			Me.advBandedGridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
			Me.advBandedGridView1.OptionsView.ShowFooter = True
			Me.advBandedGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSupplierID, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDiscontinued, DevExpress.Data.ColumnSortOrder.Descending)})
'			Me.advBandedGridView1.CustomDrawGroupPanel += New DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(Me.advBandedGridView1_CustomDrawGroupPanel)
'			Me.advBandedGridView1.CustomDrawFooterCell += New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawFooterCell)
'			Me.advBandedGridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawGroupRow)
'			Me.advBandedGridView1.GroupLevelStyle += New DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventHandler(Me.advBandedGridView1_GroupLevelStyle)
'			Me.advBandedGridView1.CustomDrawRowIndicator += New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawRowIndicator)
'			Me.advBandedGridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.advBandedGridView1_FocusedColumnChanged)
'			Me.advBandedGridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawCell)
'			Me.advBandedGridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.advBandedGridView1_RowCellStyle)
'			Me.advBandedGridView1.CustomDrawFilterPanel += New DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventHandler(Me.advBandedGridView1_CustomDrawFilterPanel)
'			Me.advBandedGridView1.CustomDrawBandHeader += New DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawBandHeader)
'			Me.advBandedGridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawColumnHeader)
'			Me.advBandedGridView1.CustomDrawFooter += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.advBandedGridView1_CustomDrawFooter)
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Product"
			Me.gridBand1.Columns.Add(Me.colProductName)
			Me.gridBand1.Columns.Add(Me.colCategoryID)
			Me.gridBand1.Columns.Add(Me.colProductID)
			Me.gridBand1.Columns.Add(Me.colSupplierID)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 300
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "Product Name"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			Me.colProductName.Visible = True
			Me.colProductName.Width = 300
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "Category"
			Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.RowIndex = 1
			Me.colCategoryID.Visible = True
			Me.colCategoryID.Width = 151
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Beverages", 1, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Condiments", 2, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Confections", 3, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dairy Products", 4, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Grains/Cereals", 5, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Meat/Poultry", 6, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Produce", 7, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Seafood", 8, 7)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imlCategories
			' 
			' imlCategories
			' 
			Me.imlCategories.ImageStream = (CType(resources.GetObject("imlCategories.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlCategories.TransparentColor = System.Drawing.Color.Magenta
			Me.imlCategories.Images.SetKeyName(0, "")
			Me.imlCategories.Images.SetKeyName(1, "")
			Me.imlCategories.Images.SetKeyName(2, "")
			Me.imlCategories.Images.SetKeyName(3, "")
			Me.imlCategories.Images.SetKeyName(4, "")
			Me.imlCategories.Images.SetKeyName(5, "")
			Me.imlCategories.Images.SetKeyName(6, "")
			Me.imlCategories.Images.SetKeyName(7, "")
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "Product ID"
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Width = 59
			' 
			' colSupplierID
			' 
			Me.colSupplierID.Caption = "Supplier"
			Me.colSupplierID.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colSupplierID.FieldName = "SupplierID"
			Me.colSupplierID.Name = "colSupplierID"
			Me.colSupplierID.RowIndex = 1
			Me.colSupplierID.Visible = True
			Me.colSupplierID.Width = 149
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.dsNWindProducts1.Suppliers
			Me.repositoryItemLookUpEdit1.DisplayMember = "CompanyName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 200
			Me.repositoryItemLookUpEdit1.ValueMember = "SupplierID"
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Price"
			Me.gridBand2.Columns.Add(Me.colUnitPrice)
			Me.gridBand2.Columns.Add(Me.colQuantityPerUnit)
			Me.gridBand2.Columns.Add(Me.colReorderLevel)
			Me.gridBand2.Columns.Add(Me.colDiscontinued)
			Me.gridBand2.Columns.Add(Me.colUnitsOnOrder)
			Me.gridBand2.Columns.Add(Me.colUnitsInStock)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 412
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "Unit Price"
			Me.colUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.colUnitPrice.DisplayFormat.FormatString = "c"
			Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.SummaryItem.DisplayFormat = "SUM={0:c}"
			Me.colUnitPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.Width = 135
			' 
			' colQuantityPerUnit
			' 
			Me.colQuantityPerUnit.Caption = "Quantity Per Unit"
			Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
			Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
			Me.colQuantityPerUnit.Visible = True
			Me.colQuantityPerUnit.Width = 127
			' 
			' colReorderLevel
			' 
			Me.colReorderLevel.Caption = "Reorder Level"
			Me.colReorderLevel.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colReorderLevel.FieldName = "ReorderLevel"
			Me.colReorderLevel.Name = "colReorderLevel"
			Me.colReorderLevel.RowIndex = 1
			Me.colReorderLevel.SummaryItem.DisplayFormat = "MAX={0}"
			Me.colReorderLevel.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
			Me.colReorderLevel.Visible = True
			Me.colReorderLevel.Width = 135
			' 
			' colDiscontinued
			' 
			Me.colDiscontinued.Caption = "Discontinued"
			Me.colDiscontinued.FieldName = "Discontinued"
			Me.colDiscontinued.Name = "colDiscontinued"
			Me.colDiscontinued.Visible = True
			Me.colDiscontinued.Width = 150
			' 
			' colUnitsOnOrder
			' 
			Me.colUnitsOnOrder.Caption = "Units On Order"
			Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
			Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
			Me.colUnitsOnOrder.RowIndex = 1
			Me.colUnitsOnOrder.Visible = True
			Me.colUnitsOnOrder.Width = 127
			' 
			' colUnitsInStock
			' 
			Me.colUnitsInStock.Caption = "Units In Stock"
			Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colUnitsInStock.FieldName = "UnitsInStock"
			Me.colUnitsInStock.Name = "colUnitsInStock"
			Me.colUnitsInStock.RowIndex = 1
			Me.colUnitsInStock.SummaryItem.DisplayFormat = "AVG={0:#.##}"
			Me.colUnitsInStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
			Me.colUnitsInStock.Visible = True
			Me.colUnitsInStock.Width = 150
			' 
			' imlIndicator
			' 
			Me.imlIndicator.ImageStream = (CType(resources.GetObject("imlIndicator.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlIndicator.TransparentColor = System.Drawing.Color.Magenta
			Me.imlIndicator.Images.SetKeyName(0, "")
			Me.imlIndicator.Images.SetKeyName(1, "")
			Me.imlIndicator.Images.SetKeyName(2, "")
			Me.imlIndicator.Images.SetKeyName(3, "")
			Me.imlIndicator.Images.SetKeyName(4, "")
			Me.imlIndicator.Images.SetKeyName(5, "")
			' 
			' toolBar1
			' 
			Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
			Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() { Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton5, Me.toolBarButton6, Me.toolBarButton7, Me.toolBarButton8, Me.toolBarButton9, Me.toolBarButton10, Me.toolBarButton11, Me.toolBarButton12, Me.toolBarButton13, Me.toolBarButton14, Me.toolBarButton15, Me.toolBarButton16})
			Me.toolBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.toolBar1.DropDownArrows = True
			Me.toolBar1.ImageList = Me.imlToolBar
			Me.toolBar1.Location = New System.Drawing.Point(0, 0)
			Me.toolBar1.Name = "toolBar1"
			Me.toolBar1.ShowToolTips = True
			Me.toolBar1.Size = New System.Drawing.Size(711, 28)
			Me.toolBar1.TabIndex = 10
			Me.toolBar1.Wrappable = False
'			Me.toolBar1.ButtonClick += New System.Windows.Forms.ToolBarButtonClickEventHandler(Me.toolBar1_ButtonClick)
			' 
			' toolBarButton1
			' 
			Me.toolBarButton1.ImageIndex = 0
			Me.toolBarButton1.Name = "toolBarButton1"
			Me.toolBarButton1.Pushed = True
			Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton1.ToolTipText = "Custom Draw Group Panel"
			' 
			' toolBarButton2
			' 
			Me.toolBarButton2.ImageIndex = 1
			Me.toolBarButton2.Name = "toolBarButton2"
			Me.toolBarButton2.Pushed = True
			Me.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton2.ToolTipText = "Custom Draw Band Header"
			' 
			' toolBarButton3
			' 
			Me.toolBarButton3.ImageIndex = 2
			Me.toolBarButton3.Name = "toolBarButton3"
			Me.toolBarButton3.Pushed = True
			Me.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton3.ToolTipText = "Custom Draw Column Header"
			' 
			' toolBarButton4
			' 
			Me.toolBarButton4.ImageIndex = 3
			Me.toolBarButton4.Name = "toolBarButton4"
			Me.toolBarButton4.Pushed = True
			Me.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton4.ToolTipText = "Custom Draw Sorted Shapes and Filter Buttons"
			' 
			' toolBarButton5
			' 
			Me.toolBarButton5.ImageIndex = 4
			Me.toolBarButton5.Name = "toolBarButton5"
			Me.toolBarButton5.Pushed = True
			Me.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton5.ToolTipText = "Custom Draw Row Indicator"
			' 
			' toolBarButton6
			' 
			Me.toolBarButton6.ImageIndex = 5
			Me.toolBarButton6.Name = "toolBarButton6"
			Me.toolBarButton6.Pushed = True
			Me.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton6.ToolTipText = "Custom Draw Group Row"
			' 
			' toolBarButton7
			' 
			Me.toolBarButton7.ImageIndex = 6
			Me.toolBarButton7.Name = "toolBarButton7"
			Me.toolBarButton7.Pushed = True
			Me.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton7.ToolTipText = "Custom Draw Footer"
			' 
			' toolBarButton8
			' 
			Me.toolBarButton8.ImageIndex = 7
			Me.toolBarButton8.Name = "toolBarButton8"
			Me.toolBarButton8.Pushed = True
			Me.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton8.ToolTipText = "Custom Draw Footer Cell"
			' 
			' toolBarButton9
			' 
			Me.toolBarButton9.ImageIndex = 8
			Me.toolBarButton9.Name = "toolBarButton9"
			Me.toolBarButton9.Pushed = True
			Me.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton9.ToolTipText = "Custom Draw Cell"
			' 
			' toolBarButton10
			' 
			Me.toolBarButton10.ImageIndex = 9
			Me.toolBarButton10.Name = "toolBarButton10"
			Me.toolBarButton10.Pushed = True
			Me.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton10.ToolTipText = "Custom Draw Filter Panel"
			' 
			' toolBarButton11
			' 
			Me.toolBarButton11.Name = "toolBarButton11"
			Me.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
			' 
			' toolBarButton12
			' 
			Me.toolBarButton12.ImageIndex = 10
			Me.toolBarButton12.Name = "toolBarButton12"
			Me.toolBarButton12.Pushed = True
			Me.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton12.ToolTipText = "Custom Draw Card Caption"
			' 
			' toolBarButton13
			' 
			Me.toolBarButton13.ImageIndex = 11
			Me.toolBarButton13.Name = "toolBarButton13"
			Me.toolBarButton13.Pushed = True
			Me.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton13.ToolTipText = "Custom Draw Card Field Caption"
			' 
			' toolBarButton14
			' 
			Me.toolBarButton14.ImageIndex = 12
			Me.toolBarButton14.Name = "toolBarButton14"
			Me.toolBarButton14.Pushed = True
			Me.toolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton14.ToolTipText = "Custom Draw Card Field Value"
			' 
			' toolBarButton15
			' 
			Me.toolBarButton15.Name = "toolBarButton15"
			Me.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
			' 
			' toolBarButton16
			' 
			Me.toolBarButton16.ImageIndex = 13
			Me.toolBarButton16.Name = "toolBarButton16"
			Me.toolBarButton16.Pushed = True
			Me.toolBarButton16.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
			Me.toolBarButton16.ToolTipText = "Draw BackGround"
			' 
			' imlToolBar
			' 
			Me.imlToolBar.ImageStream = (CType(resources.GetObject("imlToolBar.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlToolBar.TransparentColor = System.Drawing.Color.Magenta
			Me.imlToolBar.Images.SetKeyName(0, "")
			Me.imlToolBar.Images.SetKeyName(1, "")
			Me.imlToolBar.Images.SetKeyName(2, "")
			Me.imlToolBar.Images.SetKeyName(3, "")
			Me.imlToolBar.Images.SetKeyName(4, "")
			Me.imlToolBar.Images.SetKeyName(5, "")
			Me.imlToolBar.Images.SetKeyName(6, "")
			Me.imlToolBar.Images.SetKeyName(7, "")
			Me.imlToolBar.Images.SetKeyName(8, "")
			Me.imlToolBar.Images.SetKeyName(9, "")
			Me.imlToolBar.Images.SetKeyName(10, "")
			Me.imlToolBar.Images.SetKeyName(11, "")
			Me.imlToolBar.Images.SetKeyName(12, "")
			Me.imlToolBar.Images.SetKeyName(13, "")
			' 
			' imlCustomDrawImages
			' 
			Me.imlCustomDrawImages.ImageStream = (CType(resources.GetObject("imlCustomDrawImages.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlCustomDrawImages.TransparentColor = System.Drawing.Color.Magenta
			Me.imlCustomDrawImages.Images.SetKeyName(0, "")
			Me.imlCustomDrawImages.Images.SetKeyName(1, "")
			Me.imlCustomDrawImages.Images.SetKeyName(2, "")
			Me.imlCustomDrawImages.Images.SetKeyName(3, "")
			' 
			' imlFilterShapes
			' 
			Me.imlFilterShapes.ImageStream = (CType(resources.GetObject("imlFilterShapes.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlFilterShapes.TransparentColor = System.Drawing.Color.Magenta
			Me.imlFilterShapes.Images.SetKeyName(0, "")
			Me.imlFilterShapes.Images.SetKeyName(1, "")
			Me.imlFilterShapes.Images.SetKeyName(2, "")
			Me.imlFilterShapes.Images.SetKeyName(3, "")
			Me.imlFilterShapes.Images.SetKeyName(4, "")
			Me.imlFilterShapes.Images.SetKeyName(5, "")
			' 
			' imlSortShapes
			' 
			Me.imlSortShapes.ImageStream = (CType(resources.GetObject("imlSortShapes.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imlSortShapes.TransparentColor = System.Drawing.Color.Magenta
			Me.imlSortShapes.Images.SetKeyName(0, "")
			Me.imlSortShapes.Images.SetKeyName(1, "")
			' 
			' gridControl2
			' 
			Me.gridControl2.BackgroundImage = (CType(resources.GetObject("gridControl2.BackgroundImage"), System.Drawing.Image))
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.EmbeddedNavigator.Name = ""
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl2.MainView = Me.gridView1
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemSpinEdit2, Me.repositoryItemImageComboBox2, Me.repositoryItemHyperLinkEdit1})
			Me.gridControl2.Size = New System.Drawing.Size(711, 490)
			Me.gridControl2.TabIndex = 4
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colLink, Me.colPicture, Me.colPlatform, Me.colPrice, Me.colProduct})
			Me.gridView1.GridControl = Me.gridControl2
			Me.gridView1.GroupCount = 1
			Me.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", Me.colPrice, "SUM={0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ProductName", Me.colProduct, "")})
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsNavigation.UseTabKey = False
			Me.gridView1.OptionsView.AutoCalcPreviewLineCount = True
			Me.gridView1.OptionsView.ShowPreview = True
			Me.gridView1.PaintStyleName = "MixedXP"
			Me.gridView1.PreviewFieldName = "Description"
			Me.gridView1.RowHeight = 48
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPlatform, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomDrawRowIndicator += New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(Me.gridView1_CustomDrawRowIndicator)
'			Me.gridView1.CustomDrawRowFooter += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawRowFooter)
'			Me.gridView1.CustomDrawRowPreview += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawRowPreview)
'			Me.gridView1.CustomDrawRowFooterCell += New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(Me.gridView1_CustomDrawRowFooterCell)
'			Me.gridView1.CustomDrawFilterPanel += New DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventHandler(Me.gridView1_CustomDrawFilterPanel)
'			Me.gridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.gridView1_CustomDrawColumnHeader)
			' 
			' colLink
			' 
			Me.colLink.Caption = "Link"
			Me.colLink.ColumnEdit = Me.repositoryItemHyperLinkEdit1
			Me.colLink.FieldName = "Link"
			Me.colLink.Name = "colLink"
			Me.colLink.OptionsColumn.ReadOnly = True
			Me.colLink.Visible = True
			Me.colLink.VisibleIndex = 3
			Me.colLink.Width = 162
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' colPicture
			' 
			Me.colPicture.Caption = "Picture"
			Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colPicture.OptionsColumn.AllowSize = False
			Me.colPicture.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colPicture.OptionsColumn.FixedWidth = True
			Me.colPicture.OptionsFilter.AllowFilter = False
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 1
			Me.colPicture.Width = 220
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			' 
			' colPlatform
			' 
			Me.colPlatform.Caption = "Platform"
			Me.colPlatform.ColumnEdit = Me.repositoryItemImageComboBox2
			Me.colPlatform.FieldName = "Platform"
			Me.colPlatform.Name = "colPlatform"
			Me.colPlatform.Width = 100
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("VCL", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("ActiveX", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(".NET", 2, -1)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' colPrice
			' 
			Me.colPrice.Caption = "Price"
			Me.colPrice.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.colPrice.DisplayFormat.FormatString = "c"
			Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPrice.FieldName = "Price"
			Me.colPrice.Name = "colPrice"
			Me.colPrice.Visible = True
			Me.colPrice.VisibleIndex = 2
			Me.colPrice.Width = 101
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' colProduct
			' 
			Me.colProduct.Caption = "ProductName"
			Me.colProduct.FieldName = "ProductName"
			Me.colProduct.Name = "colProduct"
			Me.colProduct.Visible = True
			Me.colProduct.VisibleIndex = 0
			Me.colProduct.Width = 154
			' 
			' xtraGridBlending1
			' 
			Me.xtraGridBlending1.AlphaStyles.AddReplace("GroupFooter", 73)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("Preview", 70)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("FilterPanel", 50)
			Me.xtraGridBlending1.AlphaStyles.AddReplace("HeaderPanel", 70)
			Me.xtraGridBlending1.GridControl = Me.gridControl2
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(720, 521)
			Me.xtraTabControl1.TabIndex = 13
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.Text = "xtraTabControl1"
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged)
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gridControl1)
			Me.xtraTabPage1.Controls.Add(Me.panel1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(711, 490)
			Me.xtraTabPage1.Text = "Custom Draw (full features)"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.toolBar1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(711, 32)
			Me.panel1.TabIndex = 12
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.gridControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(711, 490)
			Me.xtraTabPage2.Text = "Custom Draw (mix example)"
			' 
			' CustomDraw
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "CustomDraw"
			Me.Size = New System.Drawing.Size(720, 521)
'			Me.Load += New System.EventHandler(Me.CustomDraw_Load)
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsNWindProducts1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.xtraTabPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents toolBar1 As System.Windows.Forms.ToolBar
		Private toolBarButton1 As System.Windows.Forms.ToolBarButton
		Private toolBarButton2 As System.Windows.Forms.ToolBarButton
		Private toolBarButton3 As System.Windows.Forms.ToolBarButton
		Private toolBarButton4 As System.Windows.Forms.ToolBarButton
		Private toolBarButton5 As System.Windows.Forms.ToolBarButton
		Private imlToolBar As System.Windows.Forms.ImageList
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colProductName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCategoryID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colProductID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colSupplierID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colReorderLevel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colUnitsOnOrder As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private dsNWindProducts1 As dsNWindProducts
		Private WithEvents cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
		Private imlIndicator As System.Windows.Forms.ImageList
		Private imlCategories As System.Windows.Forms.ImageList
		Private imlCustomDrawImages As System.Windows.Forms.ImageList
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private imlFilterShapes As System.Windows.Forms.ImageList
		Private imlSortShapes As System.Windows.Forms.ImageList
		Private toolBarButton6 As System.Windows.Forms.ToolBarButton
		Private toolBarButton7 As System.Windows.Forms.ToolBarButton
		Private toolBarButton8 As System.Windows.Forms.ToolBarButton
		Private toolBarButton9 As System.Windows.Forms.ToolBarButton
		Private toolBarButton10 As System.Windows.Forms.ToolBarButton
		Private toolBarButton11 As System.Windows.Forms.ToolBarButton
		Private toolBarButton12 As System.Windows.Forms.ToolBarButton
		Private toolBarButton13 As System.Windows.Forms.ToolBarButton
		Private toolBarButton14 As System.Windows.Forms.ToolBarButton
		Private toolBarButton15 As System.Windows.Forms.ToolBarButton
		Private toolBarButton16 As System.Windows.Forms.ToolBarButton
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colLink As DevExpress.XtraGrid.Columns.GridColumn
		Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
		Private colPlatform As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colProduct As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private xtraGridBlending1 As DevExpress.XtraGrid.Blending.XtraGridBlending
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private components As System.ComponentModel.IContainer
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace
