Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridRowCellStyle
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHP = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLiter = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMPGCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMPGHighway = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemCalcEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(584, 358)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colMPGCity, Me.colMPGHighway, Me.colPrice, Me.colDeliveryDate, Me.colIsInStock})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ColumnAutoWidth = False
'			Me.gridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.gridView1_RowCellStyle);
			' 
			' colTrademark
			' 
			Me.colTrademark.Caption = "Trademark"
			Me.colTrademark.FieldName = "Trademark"
			Me.colTrademark.Name = "colTrademark"
			Me.colTrademark.Visible = True
			Me.colTrademark.VisibleIndex = 0
			Me.colTrademark.Width = 88
			' 
			' colModel
			' 
			Me.colModel.Caption = "Model"
			Me.colModel.FieldName = "Model"
			Me.colModel.Name = "colModel"
			Me.colModel.OptionsFilter.AllowFilter = False
			Me.colModel.Visible = True
			Me.colModel.VisibleIndex = 1
			Me.colModel.Width = 163
			' 
			' colHP
			' 
			Me.colHP.Caption = "HP"
			Me.colHP.FieldName = "HP"
			Me.colHP.Name = "colHP"
			Me.colHP.Visible = True
			Me.colHP.VisibleIndex = 2
			Me.colHP.Width = 44
			' 
			' colLiter
			' 
			Me.colLiter.Caption = "Capacity"
			Me.colLiter.FieldName = "Liter"
			Me.colLiter.Name = "colLiter"
			Me.colLiter.Visible = True
			Me.colLiter.VisibleIndex = 3
			Me.colLiter.Width = 72
			' 
			' colCyl
			' 
			Me.colCyl.Caption = "Cyl"
			Me.colCyl.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colCyl.FieldName = "Cyl"
			Me.colCyl.Name = "colCyl"
			Me.colCyl.Visible = True
			Me.colCyl.VisibleIndex = 4
			Me.colCyl.Width = 45
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' colTransmissSpeedCount
			' 
			Me.colTransmissSpeedCount.Caption = "# of Gears"
			Me.colTransmissSpeedCount.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colTransmissSpeedCount.FieldName = "Transmiss Speed Count"
			Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
			Me.colTransmissSpeedCount.Visible = True
			Me.colTransmissSpeedCount.VisibleIndex = 5
			Me.colTransmissSpeedCount.Width = 80
			' 
			' colMPGCity
			' 
			Me.colMPGCity.Caption = "MPG City"
			Me.colMPGCity.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colMPGCity.FieldName = "MPG City"
			Me.colMPGCity.Name = "colMPGCity"
			Me.colMPGCity.Visible = True
			Me.colMPGCity.VisibleIndex = 6
			Me.colMPGCity.Width = 76
			' 
			' colMPGHighway
			' 
			Me.colMPGHighway.Caption = "MPG Highway"
			Me.colMPGHighway.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colMPGHighway.FieldName = "MPG Highway"
			Me.colMPGHighway.Name = "colMPGHighway"
			Me.colMPGHighway.Visible = True
			Me.colMPGHighway.VisibleIndex = 7
			Me.colMPGHighway.Width = 99
			' 
			' colPrice
			' 
			Me.colPrice.Caption = "Price"
			Me.colPrice.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.colPrice.DisplayFormat.FormatString = "c"
			Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colPrice.FieldName = "Price"
			Me.colPrice.Name = "colPrice"
			Me.colPrice.Visible = True
			Me.colPrice.VisibleIndex = 8
			Me.colPrice.Width = 83
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' colDeliveryDate
			' 
			Me.colDeliveryDate.Caption = "Delivery Date"
			Me.colDeliveryDate.FieldName = "Delivery Date"
			Me.colDeliveryDate.Name = "colDeliveryDate"
			Me.colDeliveryDate.Visible = True
			Me.colDeliveryDate.VisibleIndex = 9
			Me.colDeliveryDate.Width = 95
			' 
			' colIsInStock
			' 
			Me.colIsInStock.Caption = "In Stock?"
			Me.colIsInStock.FieldName = "Is In Stock"
			Me.colIsInStock.Name = "colIsInStock"
			Me.colIsInStock.Visible = True
			Me.colIsInStock.VisibleIndex = 10
			' 
			' GridRowCellStyle
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridRowCellStyle"
			Me.Size = New System.Drawing.Size(592, 366)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridRowCellStyle_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
		Private colModel As DevExpress.XtraGrid.Columns.GridColumn
		Private colHP As DevExpress.XtraGrid.Columns.GridColumn
		Private colLiter As DevExpress.XtraGrid.Columns.GridColumn
		Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransmissSpeedCount As DevExpress.XtraGrid.Columns.GridColumn
		Private colMPGCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colMPGHighway As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colIsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
