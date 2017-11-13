Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridValidatingControl
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
			Dim styleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
			Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.Caption = "Discontinued"
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 3
            Me.colDiscontinued.Width = 119
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(0, 46)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemLookUpEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(593, 320)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '			Me.gridControl1.Validating += New System.ComponentModel.CancelEventHandler(Me.gridControl1_Validating);
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colDiscontinued})
            styleFormatCondition1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Strikeout)
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark
            styleFormatCondition1.Appearance.Options.UseFont = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.ApplyToRow = True
            styleFormatCondition1.Column = Me.colDiscontinued
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            styleFormatCondition1.Value1 = True
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged);
            '			Me.gridView1.ValidateRow += New DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(Me.gridView1_ValidateRow);
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "Product Name"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.OptionsFilter.AllowFilter = False
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 180
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.Caption = "Category"
            Me.colCategoryID.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 1
            Me.colCategoryID.Width = 102
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "CategoryName", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)})
            Me.repositoryItemLookUpEdit1.DisplayMember = "CategoryName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 8
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.ShowFooter = False
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "CategoryID"
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.Caption = "Quantity Per Unit"
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.OptionsFilter.AllowFilter = False
            Me.colQuantityPerUnit.Width = 112
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "Unit Price"
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colUnitPrice.Width = 112
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Controls.Add(Me.textEdit1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(593, 38)
            Me.panel1.TabIndex = 5
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(332, 9)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Appearance.Options.UseTextOptions = True
            Me.spinEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.DisplayFormat.FormatString = "c"
            Me.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEdit1.Size = New System.Drawing.Size(112, 20)
            Me.spinEdit1.TabIndex = 1
            '			Me.spinEdit1.Validating += New System.ComponentModel.CancelEventHandler(Me.editors_Validating);
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.EditValue = "textEdit1"
            Me.textEdit1.Location = New System.Drawing.Point(118, 9)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(208, 20)
            Me.textEdit1.TabIndex = 0
            '			Me.textEdit1.Validating += New System.ComponentModel.CancelEventHandler(Me.editors_Validating);
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 16)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Current record:"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 38)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(593, 8)
            Me.panelControl1.TabIndex = 9
            ' 
            ' GridValidatingControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridValidatingControl"
            Me.Size = New System.Drawing.Size(593, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            '			Me.Load += New System.EventHandler(Me.GridValidatingControl_Load);
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
        Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
