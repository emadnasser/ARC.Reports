Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleCheckedComboBoxEdit
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.checkedComboBoxEdit2 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.checkedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAllowMultiSelect = New DevExpress.XtraEditors.CheckEdit()
			Me.ceIncrementalSearch = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowButtons = New DevExpress.XtraEditors.CheckEdit()
			Me.teSelectAllItemCaption = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.cmbSeparatorChar = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.icbHighlightedItemStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.ceSelectAllItem = New DevExpress.XtraEditors.CheckEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.checkedComboBoxEditSample = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.checkedComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceIncrementalSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowButtons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teSelectAllItemCaption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSeparatorChar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbHighlightedItemStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceSelectAllItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.checkedComboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(959, 604)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			Me.xtraTabControl1.TabStop = False
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.groupControl2)
			Me.xtraTabPage1.Controls.Add(Me.groupControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(953, 598)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			Me.xtraTabPage1.TooltipTitle = Nothing
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.labelControl4)
			Me.groupControl2.Controls.Add(Me.checkedComboBoxEdit2)
			Me.groupControl2.Controls.Add(Me.labelControl3)
			Me.groupControl2.Controls.Add(Me.checkedComboBoxEdit1)
			Me.groupControl2.Location = New System.Drawing.Point(322, 283)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(304, 137)
			Me.groupControl2.TabIndex = 3
			Me.groupControl2.Text = "Flags samples"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(20, 75)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(221, 13)
			Me.labelControl4.TabIndex = 32
			Me.labelControl4.Text = "Platforms (Flags without a named zero value):"
			' 
			' checkedComboBoxEdit2
			' 
			Me.checkedComboBoxEdit2.Location = New System.Drawing.Point(96, 94)
			Me.checkedComboBoxEdit2.Name = "checkedComboBoxEdit2"
			Me.checkedComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit2.Properties.DropDownRows = 12
			Me.checkedComboBoxEdit2.Size = New System.Drawing.Size(186, 20)
			Me.checkedComboBoxEdit2.TabIndex = 31
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(20, 30)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(190, 13)
			Me.labelControl3.TabIndex = 30
			Me.labelControl3.Text = "Colors (Flags with a named zero value):"
			' 
			' checkedComboBoxEdit1
			' 
			Me.checkedComboBoxEdit1.Location = New System.Drawing.Point(96, 49)
			Me.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1"
			Me.checkedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit1.Size = New System.Drawing.Size(186, 20)
			Me.checkedComboBoxEdit1.TabIndex = 1
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.ceAllowMultiSelect)
			Me.groupControl1.Controls.Add(Me.ceIncrementalSearch)
			Me.groupControl1.Controls.Add(Me.ceShowButtons)
			Me.groupControl1.Controls.Add(Me.teSelectAllItemCaption)
			Me.groupControl1.Controls.Add(Me.labelControl5)
			Me.groupControl1.Controls.Add(Me.cmbSeparatorChar)
			Me.groupControl1.Controls.Add(Me.labelControl2)
			Me.groupControl1.Controls.Add(Me.icbHighlightedItemStyle)
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Controls.Add(Me.ceSelectAllItem)
			Me.groupControl1.Location = New System.Drawing.Point(322, 30)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(304, 232)
			Me.groupControl1.TabIndex = 2
			Me.groupControl1.Text = "Properties"
			' 
			' ceAllowMultiSelect
			' 
			Me.ceAllowMultiSelect.Location = New System.Drawing.Point(18, 144)
			Me.ceAllowMultiSelect.Name = "ceAllowMultiSelect"
			Me.ceAllowMultiSelect.Properties.Caption = "Allow Multi Select"
			Me.ceAllowMultiSelect.Size = New System.Drawing.Size(242, 19)
			Me.ceAllowMultiSelect.TabIndex = 4
'			Me.ceAllowMultiSelect.CheckedChanged += New System.EventHandler(Me.ceAllowMultiSelect_CheckedChanged)
			' 
			' ceIncrementalSearch
			' 
			Me.ceIncrementalSearch.Location = New System.Drawing.Point(18, 169)
			Me.ceIncrementalSearch.Name = "ceIncrementalSearch"
			Me.ceIncrementalSearch.Properties.Caption = "Incremental Search"
			Me.ceIncrementalSearch.Size = New System.Drawing.Size(242, 19)
			Me.ceIncrementalSearch.TabIndex = 5
'			Me.ceIncrementalSearch.CheckedChanged += New System.EventHandler(Me.ceIncrementalSearch_CheckedChanged)
			' 
			' ceShowButtons
			' 
			Me.ceShowButtons.Location = New System.Drawing.Point(18, 194)
			Me.ceShowButtons.Name = "ceShowButtons"
			Me.ceShowButtons.Properties.Caption = "Show Buttons"
			Me.ceShowButtons.Size = New System.Drawing.Size(242, 19)
			Me.ceShowButtons.TabIndex = 6
'			Me.ceShowButtons.CheckedChanged += New System.EventHandler(Me.ceShowButtons_CheckedChanged)
			' 
			' teSelectAllItemCaption
			' 
			Me.teSelectAllItemCaption.Location = New System.Drawing.Point(160, 90)
			Me.teSelectAllItemCaption.Name = "teSelectAllItemCaption"
			Me.teSelectAllItemCaption.Size = New System.Drawing.Size(122, 20)
			Me.teSelectAllItemCaption.TabIndex = 2
'			Me.teSelectAllItemCaption.EditValueChanged += New System.EventHandler(Me.teSelectAllItemCaption_EditValueChanged)
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(20, 93)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(120, 13)
			Me.labelControl5.TabIndex = 31
			Me.labelControl5.Text = "'(Select All)' item caption:"
			' 
			' cmbSeparatorChar
			' 
			Me.cmbSeparatorChar.Location = New System.Drawing.Point(160, 61)
			Me.cmbSeparatorChar.Name = "cmbSeparatorChar"
			Me.cmbSeparatorChar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbSeparatorChar.Properties.Items.AddRange(New Object() { ",", ";", "/", "-"})
			Me.cmbSeparatorChar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbSeparatorChar.Size = New System.Drawing.Size(122, 20)
			Me.cmbSeparatorChar.TabIndex = 1
'			Me.cmbSeparatorChar.SelectedIndexChanged += New System.EventHandler(Me.cmbSeparatorChar_SelectedIndexChanged)
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(20, 64)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(76, 13)
			Me.labelControl2.TabIndex = 30
			Me.labelControl2.Text = "Separator char:"
			' 
			' icbHighlightedItemStyle
			' 
			Me.icbHighlightedItemStyle.EditValue = "imageComboBoxEdit1"
			Me.icbHighlightedItemStyle.Location = New System.Drawing.Point(160, 32)
			Me.icbHighlightedItemStyle.Name = "icbHighlightedItemStyle"
			Me.icbHighlightedItemStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbHighlightedItemStyle.Size = New System.Drawing.Size(122, 20)
			Me.icbHighlightedItemStyle.TabIndex = 0
'			Me.icbHighlightedItemStyle.SelectedIndexChanged += New System.EventHandler(Me.icbHighlightedItemStyle_SelectedIndexChanged)
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(20, 35)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(106, 13)
			Me.labelControl1.TabIndex = 29
			Me.labelControl1.Text = "Highlighted item style:"
			' 
			' ceSelectAllItem
			' 
			Me.ceSelectAllItem.Location = New System.Drawing.Point(18, 119)
			Me.ceSelectAllItem.Name = "ceSelectAllItem"
			Me.ceSelectAllItem.Properties.Caption = "'(Select All)' item visible"
			Me.ceSelectAllItem.Size = New System.Drawing.Size(242, 19)
			Me.ceSelectAllItem.TabIndex = 3
'			Me.ceSelectAllItem.CheckedChanged += New System.EventHandler(Me.ceSelectAllItem_CheckedChanged)
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.Controls.Add(Me.checkedComboBoxEditSample)
			Me.panelControl1.Location = New System.Drawing.Point(30, 30)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(261, 390)
			Me.panelControl1.TabIndex = 1
			Me.panelControl1.Text = "Sample"
			' 
			' checkedComboBoxEditSample
			' 
			Me.checkedComboBoxEditSample.Location = New System.Drawing.Point(24, 61)
			Me.checkedComboBoxEditSample.Name = "checkedComboBoxEditSample"
			Me.checkedComboBoxEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEditSample.Size = New System.Drawing.Size(209, 20)
			Me.checkedComboBoxEditSample.TabIndex = 0
'			Me.checkedComboBoxEditSample.CustomDisplayText += New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(Me.checkedComboBoxEditSample_CustomDisplayText)
			' 
			' ModuleCheckedComboBoxEdit
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleCheckedComboBoxEdit"
			Me.Size = New System.Drawing.Size(964, 609)
'			Me.Load += New System.EventHandler(Me.ModuleCheckedComboBoxEdit_Load)
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.checkedComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceAllowMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceIncrementalSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowButtons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teSelectAllItemCaption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSeparatorChar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbHighlightedItemStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceSelectAllItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.checkedComboBoxEditSample.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceSelectAllItem As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents checkedComboBoxEditSample As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private WithEvents cmbSeparatorChar As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbHighlightedItemStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private checkedComboBoxEdit2 As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private checkedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private WithEvents teSelectAllItemCaption As DevExpress.XtraEditors.TextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ceShowButtons As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceIncrementalSearch As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAllowMultiSelect As DevExpress.XtraEditors.CheckEdit

	End Class
End Namespace
