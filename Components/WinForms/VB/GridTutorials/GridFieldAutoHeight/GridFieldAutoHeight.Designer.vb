Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridFieldAutoHeight
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
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 62)
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit1, Me.repositoryItemHyperLinkEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(597, 354)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cardView1})
            '
            'cardView1
            '
            Me.cardView1.Appearance.FieldValue.Options.UseTextOptions = True
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.MaximumCardColumns = 2
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.AutoHorzWidth = True
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            Me.cardView1.OptionsView.ShowLines = False
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Product Name"
            Me.gridColumn1.FieldName = "ProductName"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Picture"
            Me.gridColumn2.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.gridColumn2.FieldName = "Picture"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Platform"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn3.FieldName = "Platform"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(".NET", 2, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("VCL", 0, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("ActiveX", 1, -1)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Price"
            Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.gridColumn4.DisplayFormat.FormatString = "c"
            Me.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.gridColumn4.FieldName = "Price"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "Description"
            Me.gridColumn5.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.gridColumn5.FieldName = "Description"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 4
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "HyperLink"
            Me.gridColumn6.ColumnEdit = Me.repositoryItemHyperLinkEdit1
            Me.gridColumn6.FieldName = "Link"
            Me.gridColumn6.Name = "gridColumn6"
            Me.gridColumn6.Visible = True
            Me.gridColumn6.VisibleIndex = 5
            '
            'repositoryItemHyperLinkEdit1
            '
            Me.repositoryItemHyperLinkEdit1.AutoHeight = False
            Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.radioGroup1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(597, 54)
            Me.panel1.TabIndex = 5
            '
            'radioGroup1
            '
            Me.radioGroup1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radioGroup1.Location = New System.Drawing.Point(122, 12)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Never"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Always"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Auto")})
            Me.radioGroup1.Size = New System.Drawing.Size(463, 33)
            Me.radioGroup1.TabIndex = 0
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(17, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "VertScroll Visibility:"
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 54)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(597, 8)
            Me.panelControl1.TabIndex = 9
            '
            'GridFieldAutoHeight
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "GridFieldAutoHeight"
            Me.Size = New System.Drawing.Size(597, 416)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Private panel1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
