Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class OLAPKPI
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.panelConnection = New DevExpress.XtraEditors.PanelControl()
            Me.ddlTrendGraphics = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.ddlStatusGraphics = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.fieldTrend = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldStatus = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.separator1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelError = New DevExpress.XtraEditors.PanelControl()
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.panelConnection, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelConnection.SuspendLayout()
            CType(Me.ddlTrendGraphics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlStatusGraphics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.separator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelError, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelError.SuspendLayout()
            CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panelConnection
            '
            Me.panelConnection.Controls.Add(Me.ddlTrendGraphics)
            Me.panelConnection.Controls.Add(Me.label1)
            Me.panelConnection.Controls.Add(Me.ddlStatusGraphics)
            Me.panelConnection.Controls.Add(Me.label2)
            Me.panelConnection.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelConnection.Location = New System.Drawing.Point(0, 51)
            Me.panelConnection.Margin = New System.Windows.Forms.Padding(0)
            Me.panelConnection.Name = "panelConnection"
            Me.panelConnection.Size = New System.Drawing.Size(690, 68)
            Me.panelConnection.TabIndex = 4
            '
            'ddlTrendGraphics
            '
            Me.ddlTrendGraphics.EditValue = ""
            Me.ddlTrendGraphics.Location = New System.Drawing.Point(109, 37)
            Me.ddlTrendGraphics.Name = "ddlTrendGraphics"
            Me.ddlTrendGraphics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ddlTrendGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.ddlTrendGraphics.Size = New System.Drawing.Size(173, 20)
            Me.ddlTrendGraphics.TabIndex = 6
'			Me.ddlTrendGraphics.SelectedIndexChanged += New System.EventHandler(Me.cbTrendGraphic_SelectedIndexChanged);
            '
            'label1
            '
            Me.label1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(18, 40)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(76, 13)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Trend Graphics:"
            '
            'ddlStatusGraphics
            '
            Me.ddlStatusGraphics.EditValue = ""
            Me.ddlStatusGraphics.Location = New System.Drawing.Point(109, 11)
            Me.ddlStatusGraphics.Name = "ddlStatusGraphics"
            Me.ddlStatusGraphics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ddlStatusGraphics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.ddlStatusGraphics.Size = New System.Drawing.Size(173, 20)
            Me.ddlStatusGraphics.TabIndex = 4
'			Me.ddlStatusGraphics.SelectedIndexChanged += New System.EventHandler(Me.cbStatusGraphic_SelectedIndexChanged);
            '
            'label2
            '
            Me.label2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(18, 14)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(79, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Status Graphics:"
            '
            'fieldTrend
            '
            Me.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldTrend.AreaIndex = 3
            Me.fieldTrend.Caption = "Trend"
            Me.fieldTrend.FieldName = "[Measures].[Internet Revenue Trend]"
            Me.fieldTrend.Name = "fieldTrend"
            Me.fieldTrend.ToolTips.HeaderText = "[Measures].[Internet Revenue Trend]"
            Me.fieldTrend.ToolTips.ValueText = "[Measures].[Internet Revenue Trend]"
            '
            'fieldStatus
            '
            Me.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldStatus.AreaIndex = 2
            Me.fieldStatus.Caption = "Status"
            Me.fieldStatus.FieldName = "[Measures].[Internet Revenue Status]"
            Me.fieldStatus.Name = "fieldStatus"
            Me.fieldStatus.ToolTips.HeaderText = "[Measures].[Internet Revenue Status]"
            Me.fieldStatus.ToolTips.ValueText = "[Measures].[Internet Revenue Status]"
            '
            'pivotGridField5
            '
            Me.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField5.AreaIndex = 2
            Me.pivotGridField5.Caption = "Fiscal Quarter"
            Me.pivotGridField5.FieldName = "[Date].[Fiscal].[Fiscal Quarter]"
            Me.pivotGridField5.Name = "pivotGridField5"
            '
            'pivotGridField4
            '
            Me.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField4.AreaIndex = 1
            Me.pivotGridField4.Caption = "Fiscal Semester"
            Me.pivotGridField4.FieldName = "[Date].[Fiscal].[Fiscal Semester]"
            Me.pivotGridField4.Name = "pivotGridField4"
            '
            'pivotGridField3
            '
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.Caption = "Fiscal Year"
            Me.pivotGridField3.FieldName = "[Date].[Fiscal].[Fiscal Year]"
            Me.pivotGridField3.Name = "pivotGridField3"
            '
            'pivotGridField2
            '
            Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField2.AreaIndex = 1
            Me.pivotGridField2.Caption = "Goal"
            Me.pivotGridField2.CellFormat.FormatString = "c2"
            Me.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.pivotGridField2.FieldName = "[Measures].[Internet Revenue Goal]"
            Me.pivotGridField2.Name = "pivotGridField2"
            Me.pivotGridField2.ToolTips.HeaderText = "[Measures].[Internet Revenue Goal]"
            Me.pivotGridField2.ToolTips.ValueText = "[Measures].[Internet Revenue Goal]"
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 0
            Me.pivotGridField1.Caption = "Internet Revenue"
            Me.pivotGridField1.CellFormat.FormatString = "c2"
            Me.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.pivotGridField1.FieldName = "[Measures].[Internet Sales Amount]"
            Me.pivotGridField1.Name = "pivotGridField1"
            Me.pivotGridField1.ToolTips.HeaderText = "[Measures].[Internet Sales Amount]"
            Me.pivotGridField1.ToolTips.ValueText = "[Measures].[Internet Sales Amount]"
            '
            'pivotGridControl
            '
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.pivotGridField4, Me.pivotGridField5, Me.fieldStatus, Me.fieldTrend})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 127)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.Size = New System.Drawing.Size(690, 343)
            Me.pivotGridControl.TabIndex = 3
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 119)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(690, 8)
            Me.panelControl2.TabIndex = 14
            '
            'separator1
            '
            Me.separator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.separator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.separator1.Location = New System.Drawing.Point(0, 43)
            Me.separator1.Name = "separator1"
            Me.separator1.Size = New System.Drawing.Size(690, 8)
            Me.separator1.TabIndex = 16
            '
            'panelError
            '
            Me.panelError.Controls.Add(Me.hyperLinkEdit1)
            Me.panelError.Controls.Add(Me.labelControl1)
            Me.panelError.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelError.Location = New System.Drawing.Point(0, 0)
            Me.panelError.Name = "panelError"
            Me.panelError.Size = New System.Drawing.Size(690, 43)
            Me.panelError.TabIndex = 17
            '
            'hyperLinkEdit1
            '
            Me.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB"
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(456, 18)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.hyperLinkEdit1.Properties.Caption = "www.microsoft.com"
			Me.hyperLinkEdit1.Properties.UseParentBackground = True
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(100, 18)
            Me.hyperLinkEdit1.TabIndex = 1
            '
            'labelControl1
            '
			Me.labelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red
            Me.labelControl1.AutoEllipsis = True
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(12, 6)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(663, 28)
            Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services" & " OLE DB 8.0 (or later) " & Constants.vbCrLf & "installed on your system. You can get the latest version of this provider here:"
            '
            'OLAPKPI
            '
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelConnection)
            Me.Controls.Add(Me.separator1)
            Me.Controls.Add(Me.panelError)
            Me.Name = "OLAPKPI"
            Me.Size = New System.Drawing.Size(690, 470)
            CType(Me.panelConnection, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelConnection.ResumeLayout(False)
            Me.panelConnection.PerformLayout()
            CType(Me.ddlTrendGraphics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlStatusGraphics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.separator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelError, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelError.ResumeLayout(False)
            CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panelConnection As DevExpress.XtraEditors.PanelControl
		Private label2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ddlTrendGraphics As DevExpress.XtraEditors.ComboBoxEdit
		Private label1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents ddlStatusGraphics As DevExpress.XtraEditors.ComboBoxEdit
		Private fieldTrend As PivotGridField
		Private fieldStatus As PivotGridField
		Private pivotGridField5 As PivotGridField
		Private pivotGridField4 As PivotGridField
		Private pivotGridField3 As PivotGridField
		Private pivotGridField2 As PivotGridField
		Private pivotGridField1 As PivotGridField
		Private pivotGridControl As PivotGridControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private separator1 As DevExpress.XtraEditors.PanelControl
		Private panelError As DevExpress.XtraEditors.PanelControl
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
