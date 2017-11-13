Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class MultiEditorsRow
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
            Me.multiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.multiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.multiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.multiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
            Me.multiEditorRowProperties10 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
            Me.multiEditorRowProperties11 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
            Me.multiEditorRowProperties12 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.multiEditorRowProperties13 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow
            Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.multiEditorRow2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.multiEditorRow3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.multiEditorRow4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.multiEditorRow5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.multiEditorRow6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
            Me.panel2 = New DevExpress.XtraEditors.PanelControl
            Me.textBox1 = New DevExpress.XtraEditors.TextEdit
            Me.comboBox1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.label5 = New DevExpress.XtraEditors.LabelControl
            Me.label4 = New DevExpress.XtraEditors.LabelControl
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'multiEditorRowProperties1
            '
            Me.multiEditorRowProperties1.Caption = "Trademark"
            Me.multiEditorRowProperties1.FieldName = "Trademark"
            '
            'multiEditorRowProperties2
            '
            Me.multiEditorRowProperties2.Caption = "Model"
            Me.multiEditorRowProperties2.FieldName = "Model"
            '
            'multiEditorRowProperties3
            '
            Me.multiEditorRowProperties3.Caption = "HP"
            Me.multiEditorRowProperties3.FieldName = "HP"
            Me.multiEditorRowProperties3.Width = 16
            '
            'multiEditorRowProperties4
            '
            Me.multiEditorRowProperties4.Caption = "Capacity"
            Me.multiEditorRowProperties4.FieldName = "Liter"
            Me.multiEditorRowProperties4.Width = 24
            '
            'multiEditorRowProperties5
            '
            Me.multiEditorRowProperties5.Caption = "Cyl"
            Me.multiEditorRowProperties5.FieldName = "Cyl"
            Me.multiEditorRowProperties5.RowEdit = Me.repositoryItemSpinEdit1
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AllowFocused = False
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'multiEditorRowProperties6
            '
            Me.multiEditorRowProperties6.Caption = "MPG City"
            Me.multiEditorRowProperties6.FieldName = "MPG City"
            Me.multiEditorRowProperties6.RowEdit = Me.repositoryItemSpinEdit2
            Me.multiEditorRowProperties6.Width = 21
            '
            'repositoryItemSpinEdit2
            '
            Me.repositoryItemSpinEdit2.AllowFocused = False
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            '
            'multiEditorRowProperties7
            '
            Me.multiEditorRowProperties7.Caption = "MPG Highway"
            Me.multiEditorRowProperties7.FieldName = "MPG Highway"
            Me.multiEditorRowProperties7.RowEdit = Me.repositoryItemSpinEdit2
            Me.multiEditorRowProperties7.Width = 19
            '
            'multiEditorRowProperties8
            '
            Me.multiEditorRowProperties8.Caption = "# of Gears"
            Me.multiEditorRowProperties8.FieldName = "Transmiss Speed Count"
            '
            'multiEditorRowProperties9
            '
            Me.multiEditorRowProperties9.Caption = "Automatic Transmission"
            Me.multiEditorRowProperties9.FieldName = "Transmiss Automatic"
            Me.multiEditorRowProperties9.RowEdit = Me.repositoryItemComboBox1
            '
            'repositoryItemComboBox1
            '
            Me.repositoryItemComboBox1.AllowFocused = False
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"Yes", "No"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'multiEditorRowProperties10
            '
            Me.multiEditorRowProperties10.Caption = "Picture"
            Me.multiEditorRowProperties10.FieldName = "Picture"
            Me.multiEditorRowProperties10.RowEdit = Me.repositoryItemImageEdit1
            Me.multiEditorRowProperties10.Width = 21
            '
            'repositoryItemImageEdit1
            '
            Me.repositoryItemImageEdit1.AllowFocused = False
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            '
            'multiEditorRowProperties11
            '
            Me.multiEditorRowProperties11.Caption = "Description"
            Me.multiEditorRowProperties11.FieldName = "Description"
            Me.multiEditorRowProperties11.RowEdit = Me.repositoryItemMemoExEdit1
            Me.multiEditorRowProperties11.Width = 19
            '
            'repositoryItemMemoExEdit1
            '
            Me.repositoryItemMemoExEdit1.AllowFocused = False
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            '
            'multiEditorRowProperties12
            '
            Me.multiEditorRowProperties12.Caption = "Price"
            Me.multiEditorRowProperties12.FieldName = "Price"
            Me.multiEditorRowProperties12.RowEdit = Me.repositoryItemCalcEdit1
            Me.multiEditorRowProperties12.Width = 21
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AllowFocused = False
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'multiEditorRowProperties13
            '
            Me.multiEditorRowProperties13.Caption = "In Stock?"
            Me.multiEditorRowProperties13.FieldName = "Is In Stock"
            Me.multiEditorRowProperties13.Width = 19
            '
            'vGridControl1
            '
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.Location = New System.Drawing.Point(0, 70)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.RecordWidth = 189
            Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2, Me.repositoryItemComboBox1, Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemCheckEdit1})
            Me.vGridControl1.RowHeaderWidth = 289
            Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryRow1})
            Me.vGridControl1.Size = New System.Drawing.Size(538, 220)
            Me.vGridControl1.TabIndex = 8
            '
            'repositoryItemTextEdit1
            '
            Me.repositoryItemTextEdit1.AllowFocused = False
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            '
            'repositoryItemCheckEdit1
            '
            Me.repositoryItemCheckEdit1.AllowFocused = False
            Me.repositoryItemCheckEdit1.AutoHeight = False
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            '
            'categoryRow1
            '
            Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.multiEditorRow1, Me.multiEditorRow2, Me.multiEditorRow3, Me.multiEditorRow4, Me.multiEditorRow5, Me.multiEditorRow6})
            Me.categoryRow1.Name = "categoryRow1"
            Me.categoryRow1.Properties.Caption = "MultiEditor Rows"
            '
            'multiEditorRow1
            '
            Me.multiEditorRow1.Name = "multiEditorRow1"
            Me.multiEditorRow1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties1, Me.multiEditorRowProperties2})
            '
            'multiEditorRow2
            '
            Me.multiEditorRow2.Name = "multiEditorRow2"
            Me.multiEditorRow2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties3, Me.multiEditorRowProperties4, Me.multiEditorRowProperties5})
            '
            'multiEditorRow3
            '
            Me.multiEditorRow3.Name = "multiEditorRow3"
            Me.multiEditorRow3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties6, Me.multiEditorRowProperties7})
            Me.multiEditorRow3.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.[String]
            Me.multiEditorRow3.SeparatorString = "<>"
            '
            'multiEditorRow4
            '
            Me.multiEditorRow4.Name = "multiEditorRow4"
            Me.multiEditorRow4.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties8, Me.multiEditorRowProperties9})
            '
            'multiEditorRow5
            '
            Me.multiEditorRow5.Name = "multiEditorRow5"
            Me.multiEditorRow5.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties10, Me.multiEditorRowProperties11})
            Me.multiEditorRow5.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.[String]
            Me.multiEditorRow5.SeparatorString = ">>"
            '
            'multiEditorRow6
            '
            Me.multiEditorRow6.Name = "multiEditorRow6"
            Me.multiEditorRow6.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties12, Me.multiEditorRowProperties13})
            Me.multiEditorRow6.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.[String]
            Me.multiEditorRow6.SeparatorString = "/"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.comboBox1)
            Me.panel2.Controls.Add(Me.label5)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Controls.Add(Me.checkBox1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(538, 62)
            Me.panel2.TabIndex = 9
            '
            'textBox1
            '
            Me.textBox1.EditValue = ""
            Me.textBox1.Location = New System.Drawing.Point(406, 30)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(112, 20)
            Me.textBox1.TabIndex = 5
            '
            'comboBox1
            '
            Me.comboBox1.Location = New System.Drawing.Point(186, 30)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBox1.Properties.Items.AddRange(New Object() {"VertLine", "String"})
            Me.comboBox1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBox1.Size = New System.Drawing.Size(108, 20)
            Me.comboBox1.TabIndex = 4
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(318, 33)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(82, 13)
            Me.label5.TabIndex = 3
            Me.label5.Text = "Separator string:"
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(106, 33)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(74, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "Separator kind:"
            '
            'label3
            '
            Me.label3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
            Me.label3.Appearance.Options.UseFont = True
            Me.label3.Location = New System.Drawing.Point(11, 33)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(76, 13)
            Me.label3.TabIndex = 1
            Me.label3.Text = "Focused Row:"
            '
            'checkBox1
            '
            Me.checkBox1.EditValue = True
            Me.checkBox1.Location = New System.Drawing.Point(12, 12)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Properties.Caption = "Custom Styles"
            Me.checkBox1.Size = New System.Drawing.Size(125, 18)
            Me.checkBox1.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 62)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(538, 8)
            Me.panelControl1.TabIndex = 14
            '
            'MultiEditorsRow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel2)
            Me.Name = "MultiEditorsRow"
            Me.Size = New System.Drawing.Size(538, 290)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.textBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
        Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private multiEditorRow2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private multiEditorRow3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private multiEditorRow4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private multiEditorRow5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private multiEditorRow6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
        Private panel2 As PanelControl
        Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
        Private label3 As DevExpress.XtraEditors.LabelControl
        Private label4 As DevExpress.XtraEditors.LabelControl
        Private label5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBox1 As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents textBox1 As DevExpress.XtraEditors.TextEdit
		Private components As System.ComponentModel.IContainer = Nothing
        Private panelControl1 As PanelControl
        Friend WithEvents multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties10 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties11 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties12 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties13 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties

	End Class
End Namespace
