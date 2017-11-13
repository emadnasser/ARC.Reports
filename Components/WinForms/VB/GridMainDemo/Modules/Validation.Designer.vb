Namespace DevExpress.XtraGrid.Demos
	Partial Public Class Validation
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Validation))
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindOrders1 = New dsNWindOrders()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
			Me.validationControl1 = New DevExpress.XtraGrid.Demos.ValidationControl()
			Me.validationControl3 = New DevExpress.XtraGrid.Demos.ValidationControl()
			Me.validationControl2 = New DevExpress.XtraGrid.Demos.ValidationControl()
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dsNWindOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.xtraScrollableControl1.SuspendLayout()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' repositoryItemLookUpEdit1
			' 
			resources.ApplyResources(Me.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1")
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemLookUpEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"))})
			Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 220
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' gridColumn2
			' 
			resources.ApplyResources(Me.gridColumn2, "gridColumn2")
			Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.gridColumn2.FieldName = "ProductID"
			Me.gridColumn2.Name = "gridColumn2"
			' 
			' repositoryItemCalcEdit1
			' 
			resources.ApplyResources(Me.repositoryItemCalcEdit1, "repositoryItemCalcEdit1")
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemCalcEdit1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' repositoryItemSpinEdit1
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridColumn5
			' 
			Me.gridColumn5.AppearanceHeader.Font = (CType(resources.GetObject("gridColumn5.AppearanceHeader.Font"), System.Drawing.Font))
			Me.gridColumn5.AppearanceHeader.Options.UseFont = True
			resources.ApplyResources(Me.gridColumn5, "gridColumn5")
			Me.gridColumn5.DisplayFormat.FormatString = "p"
			Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn5.FieldName = "Discount"
			Me.gridColumn5.Name = "gridColumn5"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.AppearanceHeader.Font = (CType(resources.GetObject("gridColumn4.AppearanceHeader.Font"), System.Drawing.Font))
			Me.gridColumn4.AppearanceHeader.Options.UseFont = True
			resources.ApplyResources(Me.gridColumn4, "gridColumn4")
			Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.gridColumn4.FieldName = "Quantity"
			Me.gridColumn4.Name = "gridColumn4"
			' 
			' repositoryItemSpinEdit2
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = resources.GetString("repositoryItemSpinEdit2.Mask.EditMask")
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dsNWindOrders1.Order_Details
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dsNWindOrders1
			' 
			Me.dsNWindOrders1.DataSetName = "dsNWindOrders"
			Me.dsNWindOrders1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsNWindOrders1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.EvenRow.BackColor = (CType(resources.GetObject("gridView1.Appearance.EvenRow.BackColor"), System.Drawing.Color))
			Me.gridView1.Appearance.EvenRow.BackColor2 = (CType(resources.GetObject("gridView1.Appearance.EvenRow.BackColor2"), System.Drawing.Color))
			Me.gridView1.Appearance.EvenRow.GradientMode = (CType(resources.GetObject("gridView1.Appearance.EvenRow.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.gridView1.Appearance.EvenRow.Options.UseBackColor = True
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), Nothing, resources.GetString("gridView1.GroupSummary2"))})
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.ValidatingEditor += New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(Me.gridView1_ValidatingEditor)
'			Me.gridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.gridView1_RowCellStyle)
'			Me.gridView1.ValidateRow += New DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(Me.gridView1_ValidateRow)
			' 
			' gridColumn1
			' 
			resources.ApplyResources(Me.gridColumn1, "gridColumn1")
			Me.gridColumn1.FieldName = "OrderID"
			Me.gridColumn1.Name = "gridColumn1"
			' 
			' gridColumn3
			' 
			Me.gridColumn3.AppearanceHeader.Font = (CType(resources.GetObject("gridColumn3.AppearanceHeader.Font"), System.Drawing.Font))
			Me.gridColumn3.AppearanceHeader.Options.UseFont = True
			resources.ApplyResources(Me.gridColumn3, "gridColumn3")
			Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.gridColumn3.DisplayFormat.FormatString = "c"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn3.FieldName = "UnitPrice"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsFilter.AllowFilter = False
			' 
			' gridColumn6
			' 
			Me.gridColumn6.AppearanceCell.BackColor = (CType(resources.GetObject("gridColumn6.AppearanceCell.BackColor"), System.Drawing.Color))
			Me.gridColumn6.AppearanceCell.BackColor2 = (CType(resources.GetObject("gridColumn6.AppearanceCell.BackColor2"), System.Drawing.Color))
			Me.gridColumn6.AppearanceCell.Font = (CType(resources.GetObject("gridColumn6.AppearanceCell.Font"), System.Drawing.Font))
			Me.gridColumn6.AppearanceCell.ForeColor = (CType(resources.GetObject("gridColumn6.AppearanceCell.ForeColor"), System.Drawing.Color))
			Me.gridColumn6.AppearanceCell.GradientMode = (CType(resources.GetObject("gridColumn6.AppearanceCell.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			Me.gridColumn6.AppearanceCell.Options.UseBackColor = True
			Me.gridColumn6.AppearanceCell.Options.UseFont = True
			Me.gridColumn6.AppearanceCell.Options.UseForeColor = True
			resources.ApplyResources(Me.gridColumn6, "gridColumn6")
			Me.gridColumn6.DisplayFormat.FormatString = "c"
			Me.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn6.FieldName = "SubTotal"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.OptionsColumn.AllowEdit = False
			Me.gridColumn6.OptionsColumn.ReadOnly = True
			Me.gridColumn6.OptionsFilter.AllowFilter = False
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.xtraScrollableControl1)
			resources.ApplyResources(Me.panel1, "panel1")
			Me.panel1.Name = "panel1"
			' 
			' xtraScrollableControl1
			' 
			Me.xtraScrollableControl1.Controls.Add(Me.validationControl1)
			Me.xtraScrollableControl1.Controls.Add(Me.validationControl3)
			Me.xtraScrollableControl1.Controls.Add(Me.validationControl2)
			resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
			Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
			' 
			' validationControl1
			' 
			resources.ApplyResources(Me.validationControl1, "validationControl1")
			Me.validationControl1.Name = "validationControl1"
'			Me.validationControl1.ValidateCondition += New System.EventHandler(Me.validationControl_ValidateCondition)
			' 
			' validationControl3
			' 
			resources.ApplyResources(Me.validationControl3, "validationControl3")
			Me.validationControl3.Name = "validationControl3"
'			Me.validationControl3.ValidateCondition += New System.EventHandler(Me.validationControl_ValidateCondition)
			' 
			' validationControl2
			' 
			resources.ApplyResources(Me.validationControl2, "validationControl2")
			Me.validationControl2.Name = "validationControl2"
'			Me.validationControl2.ValidateCondition += New System.EventHandler(Me.validationControl_ValidateCondition)
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.simpleButton1)
			resources.ApplyResources(Me.panel2, "panel2")
			Me.panel2.Name = "panel2"
			' 
			' simpleButton1
			' 
			resources.ApplyResources(Me.simpleButton1, "simpleButton1")
			Me.simpleButton1.Name = "simpleButton1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl2, "panelControl2")
			Me.panelControl2.Name = "panelControl2"
			' 
			' Validation
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Validation"
'			Me.Load += New System.EventHandler(Me.Validation_Load)
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dsNWindOrders1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.xtraScrollableControl1.ResumeLayout(False)
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents validationControl1 As ValidationControl
		Private WithEvents validationControl2 As ValidationControl
		Private WithEvents validationControl3 As ValidationControl
		Private panel2 As DevExpress.XtraEditors.PanelControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private dsNWindOrders1 As dsNWindOrders
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
	End Class
End Namespace
