Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SummaryVariation
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
			Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.checkShowOriginalDataField = New DevExpress.XtraEditors.CheckEdit()
			Me.rgSummaryDisplayTypeGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.checkHideEmptyVariationItems = New DevExpress.XtraEditors.CheckEdit()
			Me.checkAllowCrossGroupVariation = New DevExpress.XtraEditors.CheckEdit()
			Me.icbSummaryDisplayType = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New DevExpress.XtraEditors.LabelControl()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.checkShowOriginalDataField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgSummaryDisplayTypeGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkHideEmptyVariationItems.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkAllowCrossGroupVariation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSummaryDisplayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dsSalesPerson1
			' 
			Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
			Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.checkShowOriginalDataField)
			Me.panelControl1.Controls.Add(Me.rgSummaryDisplayTypeGroup)
			Me.panelControl1.Controls.Add(Me.checkHideEmptyVariationItems)
			Me.panelControl1.Controls.Add(Me.checkAllowCrossGroupVariation)
			Me.panelControl1.Controls.Add(Me.icbSummaryDisplayType)
			Me.panelControl1.Controls.Add(Me.label2)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(706, 122)
			Me.panelControl1.TabIndex = 2
			' 
			' checkShowOriginalDataField
			' 
			Me.checkShowOriginalDataField.EditValue = True
			Me.checkShowOriginalDataField.Location = New System.Drawing.Point(9, 84)
			Me.checkShowOriginalDataField.Name = "checkShowOriginalDataField"
			Me.checkShowOriginalDataField.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkShowOriginalDataField.Properties.Appearance.Options.UseBackColor = True
			Me.checkShowOriginalDataField.Properties.Caption = "Show Raw Values"
			Me.checkShowOriginalDataField.Size = New System.Drawing.Size(156, 19)
			Me.checkShowOriginalDataField.TabIndex = 9
'			Me.checkShowOriginalDataField.CheckedChanged += New System.EventHandler(Me.checkShowOriginalDataField_CheckedChanged);
			' 
			' rgSummaryDisplayTypeGroup
			' 
			Me.rgSummaryDisplayTypeGroup.Location = New System.Drawing.Point(11, 7)
			Me.rgSummaryDisplayTypeGroup.Name = "rgSummaryDisplayTypeGroup"
			Me.rgSummaryDisplayTypeGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.rgSummaryDisplayTypeGroup.Properties.Appearance.Options.UseBackColor = True
			Me.rgSummaryDisplayTypeGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.rgSummaryDisplayTypeGroup.Properties.Columns = 4
			Me.rgSummaryDisplayTypeGroup.Size = New System.Drawing.Size(473, 32)
			Me.rgSummaryDisplayTypeGroup.TabIndex = 0
'			Me.rgSummaryDisplayTypeGroup.SelectedIndexChanged += New System.EventHandler(Me.rgSummaryDisplayTypeGroup_SelectedIndexChanged);
			' 
			' checkHideEmptyVariationItems
			' 
			Me.checkHideEmptyVariationItems.Location = New System.Drawing.Point(341, 58)
			Me.checkHideEmptyVariationItems.Name = "checkHideEmptyVariationItems"
			Me.checkHideEmptyVariationItems.Properties.Caption = "Hide Empty Variation Items"
			Me.checkHideEmptyVariationItems.Size = New System.Drawing.Size(153, 19)
			Me.checkHideEmptyVariationItems.TabIndex = 8
			Me.checkHideEmptyVariationItems.Visible = False
'			Me.checkHideEmptyVariationItems.CheckedChanged += New System.EventHandler(Me.checkHideEmptyVariationItems_CheckedChanged);
			' 
			' checkAllowCrossGroupVariation
			' 
			Me.checkAllowCrossGroupVariation.Location = New System.Drawing.Point(341, 84)
			Me.checkAllowCrossGroupVariation.Name = "checkAllowCrossGroupVariation"
			Me.checkAllowCrossGroupVariation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.checkAllowCrossGroupVariation.Properties.Appearance.Options.UseBackColor = True
			Me.checkAllowCrossGroupVariation.Properties.Caption = "Allow Cross-Group Variation"
			Me.checkAllowCrossGroupVariation.Size = New System.Drawing.Size(156, 19)
			Me.checkAllowCrossGroupVariation.TabIndex = 7
			Me.checkAllowCrossGroupVariation.Visible = False
'			Me.checkAllowCrossGroupVariation.CheckedChanged += New System.EventHandler(Me.checkAllowCrossGroupVariation_CheckedChanged);
			' 
			' icbSummaryDisplayType
			' 
			Me.icbSummaryDisplayType.EditValue = "imageComboBoxEdit1"
			Me.icbSummaryDisplayType.Location = New System.Drawing.Point(138, 58)
			Me.icbSummaryDisplayType.Name = "icbSummaryDisplayType"
			Me.icbSummaryDisplayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbSummaryDisplayType.Size = New System.Drawing.Size(179, 20)
			Me.icbSummaryDisplayType.TabIndex = 5
'			Me.icbSummaryDisplayType.SelectedIndexChanged += New System.EventHandler(Me.icbSummaryDisplayType_SelectedIndexChanged);
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(17, 60)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(115, 13)
			Me.label2.TabIndex = 6
			Me.label2.Text = "Summary Display Type: "
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 130)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsData.AllowCrossGroupVariation = False
			Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(706, 286)
			Me.pivotGridControl1.TabIndex = 11
'			Me.pivotGridControl1.FieldValueImageIndex += New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(Me.pivotGridControl1_FieldValueImageIndex);
'			Me.pivotGridControl1.CustomDrawCell += New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(Me.pivotGridControl1_CustomDrawCell);
			' 
			' panelControl2
			' 
			Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl2.Location = New System.Drawing.Point(0, 122)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(706, 8)
			Me.panelControl2.TabIndex = 12
			' 
			' SummaryVariation
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "SummaryVariation"
			Me.Size = New System.Drawing.Size(706, 416)
'			Me.Load += New System.EventHandler(Me.SummaryVariation_Load);
			CType(Me.dsSalesPerson1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.checkShowOriginalDataField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgSummaryDisplayTypeGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkHideEmptyVariationItems.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkAllowCrossGroupVariation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSummaryDisplayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents rgSummaryDisplayTypeGroup As DevExpress.XtraEditors.RadioGroup
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents icbSummaryDisplayType As DevExpress.XtraEditors.ImageComboBoxEdit
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents pivotGridControl1 As PivotGridControl
		Private WithEvents checkAllowCrossGroupVariation As CheckEdit
		Private WithEvents checkHideEmptyVariationItems As CheckEdit
		Private panelControl2 As PanelControl
		Private WithEvents checkShowOriginalDataField As CheckEdit

	End Class
End Namespace
