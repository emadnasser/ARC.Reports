Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class RowAlignment
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
			Me.panel2 = New DevExpress.XtraEditors.PanelControl()
			Me.comboBox2 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label4 = New System.Windows.Forms.Label()
			Me.comboBox1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.label3 = New System.Windows.Forms.Label()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmiss_Speed_Count = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmiss_Automatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDelivery_Date = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowIs_In_Stock = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.comboBox2)
			Me.panel2.Controls.Add(Me.label4)
			Me.panel2.Controls.Add(Me.comboBox1)
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(400, 38)
			Me.panel2.TabIndex = 10
			' 
			' comboBox2
			' 
			Me.comboBox2.Location = New System.Drawing.Point(256, 9)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox2.Size = New System.Drawing.Size(128, 20)
			Me.comboBox2.TabIndex = 12
'			Me.comboBox2.SelectedIndexChanged += New System.EventHandler(Me.comboBox_SelectedIndexChanged);
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(192, 12)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(58, 13)
			Me.label4.TabIndex = 11
			Me.label4.Text = "Alignment:"
			' 
			' comboBox1
			' 
			Me.comboBox1.Location = New System.Drawing.Point(50, 9)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox1.Size = New System.Drawing.Size(128, 20)
			Me.comboBox1.TabIndex = 10
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox_SelectedIndexChanged);
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(12, 12)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(32, 13)
			Me.label3.TabIndex = 9
			Me.label3.Text = "Row:"
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 46)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.OptionsBehavior.ResizeHeaderPanel = False
			Me.vGridControl1.OptionsBehavior.UseTabKey = False
			Me.vGridControl1.RecordWidth = 197
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1})
			Me.vGridControl1.RowHeaderWidth = 188
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow1, Me.categoryRow3})
			Me.vGridControl1.Size = New System.Drawing.Size(400, 368)
			Me.vGridControl1.TabIndex = 11
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowID, Me.rowTrademark, Me.rowModel})
			Me.categoryRow4.Name = "categoryRow4"
			Me.categoryRow4.Properties.Caption = "Main Info"
			' 
			' rowID
			' 
			Me.rowID.Name = "rowID"
			Me.rowID.Properties.Caption = "Record ID"
			Me.rowID.Properties.FieldName = "ID"
			Me.rowID.Properties.ImageIndex = 0
			' 
			' rowTrademark
			' 
			Me.rowTrademark.Name = "rowTrademark"
			Me.rowTrademark.Properties.Caption = "Trademark"
			Me.rowTrademark.Properties.FieldName = "Trademark"
			' 
			' rowModel
			' 
			Me.rowModel.Name = "rowModel"
			Me.rowModel.Properties.Caption = "Model"
			Me.rowModel.Properties.FieldName = "Model"
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmiss_Speed_Count, Me.rowTransmiss_Automatic})
			Me.categoryRow1.Name = "categoryRow1"
			Me.categoryRow1.Properties.Caption = "Performance Attributes"
			' 
			' rowHP
			' 
			Me.rowHP.Name = "rowHP"
			Me.rowHP.Properties.Caption = "HP"
			Me.rowHP.Properties.FieldName = "HP"
			' 
			' rowLiter
			' 
			Me.rowLiter.Name = "rowLiter"
			Me.rowLiter.Properties.Caption = "Capacity"
			Me.rowLiter.Properties.FieldName = "Liter"
			Me.rowLiter.Properties.Format.FormatString = "#.### Liters"
			Me.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' rowCyl
			' 
			Me.rowCyl.Name = "rowCyl"
			Me.rowCyl.Properties.Caption = "Cyl"
			Me.rowCyl.Properties.FieldName = "Cyl"
			' 
			' rowTransmiss_Speed_Count
			' 
			Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
			Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
			Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
			' 
			' rowTransmiss_Automatic
			' 
			Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
			Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
			Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
			Me.rowTransmiss_Automatic.Properties.ImageIndex = 2
			' 
			' categoryRow3
			' 
			Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowPrice, Me.rowDelivery_Date, Me.rowIs_In_Stock})
			Me.categoryRow3.Name = "categoryRow3"
			Me.categoryRow3.Properties.Caption = "Others"
			' 
			' rowPrice
			' 
			Me.rowPrice.Name = "rowPrice"
			Me.rowPrice.Properties.Caption = "Price"
			Me.rowPrice.Properties.FieldName = "Price"
			Me.rowPrice.Properties.Format.FormatString = "c"
			Me.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' rowDelivery_Date
			' 
			Me.rowDelivery_Date.Name = "rowDelivery_Date"
			Me.rowDelivery_Date.Properties.Caption = "Delivery Date"
			Me.rowDelivery_Date.Properties.FieldName = "Delivery Date"
			' 
			' rowIs_In_Stock
			' 
			Me.rowIs_In_Stock.Name = "rowIs_In_Stock"
			Me.rowIs_In_Stock.Properties.Caption = "In Stock?"
			Me.rowIs_In_Stock.Properties.FieldName = "Is In Stock"
			Me.rowIs_In_Stock.Properties.RowEdit = Me.repositoryItemTextEdit1
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 38)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(400, 8)
			Me.panelControl1.TabIndex = 14
			' 
			' RowAlignment
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.panel2)
			Me.Name = "RowAlignment"
			Me.Size = New System.Drawing.Size(400, 414)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.RowAlignment_Load);
			CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			CType(Me.comboBox2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private panel2 As PanelControl
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private WithEvents comboBox2 As DevExpress.XtraEditors.ComboBoxEdit
		Private label4 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As DevExpress.XtraEditors.ComboBoxEdit
		Private label3 As System.Windows.Forms.Label
		Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowModel As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowHP As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowLiter As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCyl As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Speed_Count As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Automatic As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDelivery_Date As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIs_In_Stock As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As PanelControl

	End Class
End Namespace
