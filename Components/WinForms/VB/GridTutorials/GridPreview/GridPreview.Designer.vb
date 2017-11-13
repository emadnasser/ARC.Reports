Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridPreview
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
            Me.label3 = New DevExpress.XtraEditors.LabelControl
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 91)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(594, 325)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "First Name"
            Me.gridColumn1.FieldName = "FirstName"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsFilter.AllowFilter = False
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 127
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Last Name"
            Me.gridColumn2.FieldName = "LastName"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsFilter.AllowFilter = False
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 121
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Title"
            Me.gridColumn3.FieldName = "Title"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 161
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Birth Date"
            Me.gridColumn4.FieldName = "BirthDate"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 117
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Home Phone"
            Me.gridColumn5.FieldName = "HomePhone"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            Me.gridColumn5.Width = 155
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "Notes"
            Me.gridColumn6.FieldName = "Notes"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.OptionsFilter.AllowFilter = False
            '
            'gridColumn7
            '
            Me.gridColumn7.Caption = "Photo"
            Me.gridColumn7.ColumnEdit = Me.repositoryItemImageEdit1
            Me.gridColumn7.FieldName = "Photo"
            Me.gridColumn7.Name = "gridColumn7"
            '
            'repositoryItemImageEdit1
            '
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkEdit3)
            Me.panel1.Controls.Add(Me.comboBoxEdit1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.checkEdit2)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(594, 83)
            Me.panel1.TabIndex = 5
            '
            'spinEdit1
            '
            Me.spinEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(360, 37)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEdit1.Properties.IsFloatValue = False
            Me.spinEdit1.Properties.Mask.EditMask = "N00"
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.spinEdit1.Size = New System.Drawing.Size(88, 20)
            Me.spinEdit1.TabIndex = 8
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Location = New System.Drawing.Point(277, 40)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(77, 13)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Preview Indent:"
            '
            'checkEdit3
            '
            Me.checkEdit3.Location = New System.Drawing.Point(12, 55)
            Me.checkEdit3.Name = "checkEdit3"
            Me.checkEdit3.Properties.Caption = "Custom Draw Row Preview"
            Me.checkEdit3.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit3.TabIndex = 6
            '
            'comboBoxEdit1
            '
            Me.comboBoxEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBoxEdit1.EditValue = "comboBoxEdit1"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(360, 11)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(217, 20)
            Me.comboBoxEdit1.TabIndex = 5
            '
            'label3
            '
            Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label3.Location = New System.Drawing.Point(257, 14)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(97, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Preview Field Name:"
            '
            'checkEdit2
            '
            Me.checkEdit2.Location = New System.Drawing.Point(12, 34)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Auto Calc Preview Line Count"
            Me.checkEdit2.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit2.TabIndex = 1
            '
            'checkEdit1
            '
            Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Show Preview"
            Me.checkEdit1.Size = New System.Drawing.Size(184, 18)
            Me.checkEdit1.TabIndex = 0
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 83)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(594, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridPreview
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridPreview"
            Me.Size = New System.Drawing.Size(594, 416)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
        Private label3 As DevExpress.XtraEditors.LabelControl
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
        Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
