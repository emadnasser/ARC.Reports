Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Partial Public Class GridExport
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.cbExport = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.sbExport = New DevExpress.XtraEditors.SimpleButton()
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.cbExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 48)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(597, 282)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderID", Nothing, "")})
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Order ID"
			Me.gridColumn1.FieldName = "OrderID"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 86
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Product"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.gridColumn2.FieldName = "ProductID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 225
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
			Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
			Me.repositoryItemLookUpEdit1.DropDownRows = 10
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 220
			Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Unit Price"
			Me.gridColumn3.ColumnEdit = Me.repositoryItemCalcEdit1
			Me.gridColumn3.DisplayFormat.FormatString = "c"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn3.FieldName = "UnitPrice"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 104
			' 
			' repositoryItemCalcEdit1
			' 
			Me.repositoryItemCalcEdit1.AutoHeight = False
			Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Quantity"
			Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.gridColumn4.FieldName = "Quantity"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			Me.gridColumn4.Width = 104
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Discount"
			Me.gridColumn5.DisplayFormat.FormatString = "p"
			Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn5.FieldName = "Discount"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 4
			Me.gridColumn5.Width = 121
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.cbExport)
			Me.panel1.Controls.Add(Me.labelControl1)
			Me.panel1.Controls.Add(Me.sbExport)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(597, 40)
			Me.panel1.TabIndex = 5
			' 
			' cbExport
			' 
			Me.cbExport.Location = New System.Drawing.Point(96, 12)
			Me.cbExport.Name = "cbExport"
			Me.cbExport.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.cbExport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbExport.Properties.DropDownRows = 10
			Me.cbExport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbExport.Size = New System.Drawing.Size(186, 20)
			Me.cbExport.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.AllowHtmlString = True
			Me.labelControl1.Location = New System.Drawing.Point(15, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(54, 14)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "<b>Export</b> to:"
			' 
			' sbExport
			' 
			Me.sbExport.Location = New System.Drawing.Point(304, 9)
			Me.sbExport.Name = "sbExport"
			Me.sbExport.Size = New System.Drawing.Size(136, 25)
			Me.sbExport.TabIndex = 1
			Me.sbExport.Text = "Export..."
'			Me.sbExport.Click += New System.EventHandler(Me.sbExport_Click);
			' 
			' panel2
			' 
			Me.panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel2.Controls.Add(Me.progressBarControl1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel2.Location = New System.Drawing.Point(0, 330)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(597, 36)
			Me.panel2.TabIndex = 6
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.progressBarControl1.Location = New System.Drawing.Point(4, 12)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(589, 16)
			Me.progressBarControl1.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 40)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(597, 8)
			Me.panelControl1.TabIndex = 9
			' 
			' GridExport
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Name = "GridExport"
			Me.Size = New System.Drawing.Size(597, 366)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridExport_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.cbExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbExport As DevExpress.XtraEditors.SimpleButton
		Private panel2 As DevExpress.XtraEditors.PanelControl
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.Container = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private cbExport As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
