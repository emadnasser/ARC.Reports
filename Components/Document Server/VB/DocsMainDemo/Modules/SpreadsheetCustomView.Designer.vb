Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Control

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetCustomViewModule
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
		''' 
		Private Sub InitializeComponent()
			Me.zoomLabel = New DevExpress.XtraEditors.LabelControl()
			Me.showGridCheckEdit = New DevExpress.XtraEditors.CheckEdit()
			Me.showHeadingsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
			Me.useR1C1StyleCheckEdit = New DevExpress.XtraEditors.CheckEdit()
			Me.saveButton = New DevExpress.XtraEditors.SimpleButton()
			Me.tabColorLabel = New DevExpress.XtraEditors.LabelControl()
			Me.tabColodEdit = New DevExpress.XtraEditors.ColorEdit()
			Me.pageOrientationGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.viewTypeGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.zoomTrackBar = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.marginsPanel = New DevExpress.XtraEditors.GroupControl()
			Me.footerMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.footerMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.headerMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.headerMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.topMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.topMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.bottomMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.bottomMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.rightMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.rightMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.leftMarginLabel = New DevExpress.XtraEditors.LabelControl()
			Me.leftMarginEdit = New DevExpress.XtraEditors.SpinEdit()
			Me.pageOrientationPanel = New DevExpress.XtraEditors.GroupControl()
			Me.paperKindBox = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.paperKindLabel = New DevExpress.XtraEditors.LabelControl()
			Me.viewTypePanel = New DevExpress.XtraEditors.GroupControl()
			Me.viewOptionsPanel = New DevExpress.XtraEditors.GroupControl()
			Me.previewControl = New DevExpress.XtraPrinting.Control.PrintControl()
			CType(Me.showGridCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showHeadingsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.useR1C1StyleCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabColodEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageOrientationGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewTypeGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.marginsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.marginsPanel.SuspendLayout()
			CType(Me.footerMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.headerMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rightMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.leftMarginEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageOrientationPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageOrientationPanel.SuspendLayout()
			CType(Me.paperKindBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewTypePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewTypePanel.SuspendLayout()
			CType(Me.viewOptionsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewOptionsPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' zoomLabel
			' 
			Me.zoomLabel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.zoomLabel.Location = New System.Drawing.Point(9, 137)
			Me.zoomLabel.Name = "zoomLabel"
			Me.zoomLabel.Size = New System.Drawing.Size(62, 13)
			Me.zoomLabel.TabIndex = 1
			Me.zoomLabel.Text = "Zoom 100%:"
			' 
			' showGridCheckEdit
			' 
			Me.showGridCheckEdit.EditValue = True
			Me.showGridCheckEdit.Location = New System.Drawing.Point(7, 28)
			Me.showGridCheckEdit.Name = "showGridCheckEdit"
			Me.showGridCheckEdit.Properties.AutoWidth = True
			Me.showGridCheckEdit.Properties.Caption = "Show Gridlines"
			Me.showGridCheckEdit.Size = New System.Drawing.Size(92, 19)
			Me.showGridCheckEdit.TabIndex = 2
			' 
			' showHeadingsCheckEdit
			' 
			Me.showHeadingsCheckEdit.EditValue = True
			Me.showHeadingsCheckEdit.Location = New System.Drawing.Point(7, 54)
			Me.showHeadingsCheckEdit.Name = "showHeadingsCheckEdit"
			Me.showHeadingsCheckEdit.Properties.AutoWidth = True
			Me.showHeadingsCheckEdit.Properties.Caption = "Show Headings"
			Me.showHeadingsCheckEdit.Size = New System.Drawing.Size(96, 19)
			Me.showHeadingsCheckEdit.TabIndex = 3
			' 
			' useR1C1StyleCheckEdit
			' 
			Me.useR1C1StyleCheckEdit.Location = New System.Drawing.Point(7, 80)
			Me.useR1C1StyleCheckEdit.Name = "useR1C1StyleCheckEdit"
			Me.useR1C1StyleCheckEdit.Properties.AutoWidth = True
			Me.useR1C1StyleCheckEdit.Properties.Caption = "Use R1C1 Style"
			Me.useR1C1StyleCheckEdit.Size = New System.Drawing.Size(97, 19)
			Me.useR1C1StyleCheckEdit.TabIndex = 4
			' 
			' saveButton
			' 
			Me.saveButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.saveButton.Location = New System.Drawing.Point(586, 526)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New System.Drawing.Size(75, 23)
			Me.saveButton.TabIndex = 15
			Me.saveButton.Text = "Save As..."
'			Me.saveButton.Click += New System.EventHandler(Me.saveButton_Click);
			' 
			' tabColorLabel
			' 
			Me.tabColorLabel.Location = New System.Drawing.Point(9, 109)
			Me.tabColorLabel.Name = "tabColorLabel"
			Me.tabColorLabel.Size = New System.Drawing.Size(50, 13)
			Me.tabColorLabel.TabIndex = 4
			Me.tabColorLabel.Text = "Tab Color:"
			' 
			' tabColodEdit
			' 
			Me.tabColodEdit.EditValue = System.Drawing.Color.Empty
			Me.tabColodEdit.Location = New System.Drawing.Point(66, 106)
			Me.tabColodEdit.Name = "tabColodEdit"
			Me.tabColodEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.tabColodEdit.Size = New System.Drawing.Size(140, 20)
			Me.tabColodEdit.TabIndex = 5
			' 
			' pageOrientationGroup
			' 
			Me.pageOrientationGroup.Location = New System.Drawing.Point(6, 26)
			Me.pageOrientationGroup.Name = "pageOrientationGroup"
			Me.pageOrientationGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.pageOrientationGroup.Properties.Appearance.Options.UseBackColor = True
			Me.pageOrientationGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pageOrientationGroup.Size = New System.Drawing.Size(190, 70)
			Me.pageOrientationGroup.TabIndex = 14
'			Me.pageOrientationGroup.SelectedIndexChanged += New System.EventHandler(Me.pageOrientationGroup_SelectedIndexChanged);
			' 
			' viewTypeGroup
			' 
			Me.viewTypeGroup.Location = New System.Drawing.Point(6, 26)
			Me.viewTypeGroup.Name = "viewTypeGroup"
			Me.viewTypeGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.viewTypeGroup.Properties.Appearance.Options.UseBackColor = True
			Me.viewTypeGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewTypeGroup.Size = New System.Drawing.Size(190, 70)
			Me.viewTypeGroup.TabIndex = 7
			' 
			' zoomTrackBar
			' 
			Me.zoomTrackBar.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.zoomTrackBar.EditValue = 100
			Me.zoomTrackBar.Location = New System.Drawing.Point(76, 133)
			Me.zoomTrackBar.Name = "zoomTrackBar"
			Me.zoomTrackBar.Properties.AllowUseMiddleValue = True
			Me.zoomTrackBar.Properties.LargeChange = 10
			Me.zoomTrackBar.Properties.Maximum = 400
			Me.zoomTrackBar.Properties.Middle = 100
			Me.zoomTrackBar.Properties.Minimum = 10
			Me.zoomTrackBar.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.zoomTrackBar.ShowToolTips = False
			Me.zoomTrackBar.Size = New System.Drawing.Size(128, 23)
			Me.zoomTrackBar.TabIndex = 6
			Me.zoomTrackBar.Value = 100
'			Me.zoomTrackBar.EditValueChanged += New System.EventHandler(Me.zoomTrackBar_EditValueChanged);
			' 
			' marginsPanel
			' 
			Me.marginsPanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.marginsPanel.Controls.Add(Me.footerMarginEdit)
			Me.marginsPanel.Controls.Add(Me.footerMarginLabel)
			Me.marginsPanel.Controls.Add(Me.headerMarginEdit)
			Me.marginsPanel.Controls.Add(Me.headerMarginLabel)
			Me.marginsPanel.Controls.Add(Me.topMarginLabel)
			Me.marginsPanel.Controls.Add(Me.topMarginEdit)
			Me.marginsPanel.Controls.Add(Me.bottomMarginLabel)
			Me.marginsPanel.Controls.Add(Me.bottomMarginEdit)
			Me.marginsPanel.Controls.Add(Me.rightMarginLabel)
			Me.marginsPanel.Controls.Add(Me.rightMarginEdit)
			Me.marginsPanel.Controls.Add(Me.leftMarginLabel)
			Me.marginsPanel.Controls.Add(Me.leftMarginEdit)
			Me.marginsPanel.Location = New System.Drawing.Point(449, 292)
			Me.marginsPanel.Name = "marginsPanel"
			Me.marginsPanel.Size = New System.Drawing.Size(212, 100)
			Me.marginsPanel.TabIndex = 10
			Me.marginsPanel.Text = "Margins"
			' 
			' footerMarginEdit
			' 
			Me.footerMarginEdit.EditValue = New Decimal(New Integer() { 3, 0, 0, 65536})
			Me.footerMarginEdit.Location = New System.Drawing.Point(151, 75)
			Me.footerMarginEdit.Name = "footerMarginEdit"
			Me.footerMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.footerMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.footerMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.footerMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 1125, 0, 0, 131072})
			Me.footerMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.footerMarginEdit.TabIndex = 13
'			Me.footerMarginEdit.EditValueChanged += New System.EventHandler(Me.footerMarginEdit_EditValueChanged);
			' 
			' footerMarginLabel
			' 
			Me.footerMarginLabel.Location = New System.Drawing.Point(111, 78)
			Me.footerMarginLabel.Name = "footerMarginLabel"
			Me.footerMarginLabel.Size = New System.Drawing.Size(36, 13)
			Me.footerMarginLabel.TabIndex = 1
			Me.footerMarginLabel.Text = "Footer:"
			' 
			' headerMarginEdit
			' 
			Me.headerMarginEdit.EditValue = New Decimal(New Integer() { 3, 0, 0, 65536})
			Me.headerMarginEdit.Location = New System.Drawing.Point(51, 75)
			Me.headerMarginEdit.Name = "headerMarginEdit"
			Me.headerMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.headerMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.headerMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.headerMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 1125, 0, 0, 131072})
			Me.headerMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.headerMarginEdit.TabIndex = 12
'			Me.headerMarginEdit.EditValueChanged += New System.EventHandler(Me.headerMarginEdit_EditValueChanged);
			' 
			' headerMarginLabel
			' 
			Me.headerMarginLabel.Location = New System.Drawing.Point(10, 78)
			Me.headerMarginLabel.Name = "headerMarginLabel"
			Me.headerMarginLabel.Size = New System.Drawing.Size(39, 13)
			Me.headerMarginLabel.TabIndex = 3
			Me.headerMarginLabel.Text = "Header:"
			' 
			' topMarginLabel
			' 
			Me.topMarginLabel.Location = New System.Drawing.Point(10, 28)
			Me.topMarginLabel.Name = "topMarginLabel"
			Me.topMarginLabel.Size = New System.Drawing.Size(22, 13)
			Me.topMarginLabel.TabIndex = 4
			Me.topMarginLabel.Text = "Top:"
			' 
			' topMarginEdit
			' 
			Me.topMarginEdit.EditValue = New Decimal(New Integer() { 75, 0, 0, 131072})
			Me.topMarginEdit.Location = New System.Drawing.Point(51, 25)
			Me.topMarginEdit.Name = "topMarginEdit"
			Me.topMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.topMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.topMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.topMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 115, 0, 0, 65536})
			Me.topMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.topMarginEdit.TabIndex = 8
'			Me.topMarginEdit.EditValueChanged += New System.EventHandler(Me.topMarginEdit_EditValueChanged);
			' 
			' bottomMarginLabel
			' 
			Me.bottomMarginLabel.Location = New System.Drawing.Point(111, 28)
			Me.bottomMarginLabel.Name = "bottomMarginLabel"
			Me.bottomMarginLabel.Size = New System.Drawing.Size(38, 13)
			Me.bottomMarginLabel.TabIndex = 6
			Me.bottomMarginLabel.Text = "Bottom:"
			' 
			' bottomMarginEdit
			' 
			Me.bottomMarginEdit.EditValue = New Decimal(New Integer() { 75, 0, 0, 131072})
			Me.bottomMarginEdit.Location = New System.Drawing.Point(151, 25)
			Me.bottomMarginEdit.Name = "bottomMarginEdit"
			Me.bottomMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.bottomMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.bottomMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.bottomMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 115, 0, 0, 65536})
			Me.bottomMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.bottomMarginEdit.TabIndex = 9
'			Me.bottomMarginEdit.EditValueChanged += New System.EventHandler(Me.bottomMarginEdit_EditValueChanged);
			' 
			' rightMarginLabel
			' 
			Me.rightMarginLabel.Location = New System.Drawing.Point(111, 53)
			Me.rightMarginLabel.Name = "rightMarginLabel"
			Me.rightMarginLabel.Size = New System.Drawing.Size(29, 13)
			Me.rightMarginLabel.TabIndex = 8
			Me.rightMarginLabel.Text = "Right:"
			' 
			' rightMarginEdit
			' 
			Me.rightMarginEdit.EditValue = New Decimal(New Integer() { 7, 0, 0, 65536})
			Me.rightMarginEdit.Location = New System.Drawing.Point(151, 50)
			Me.rightMarginEdit.Name = "rightMarginEdit"
			Me.rightMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.rightMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.rightMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.rightMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 825, 0, 0, 131072})
			Me.rightMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.rightMarginEdit.TabIndex = 11
'			Me.rightMarginEdit.EditValueChanged += New System.EventHandler(Me.rightMarginEdit_EditValueChanged);
			' 
			' leftMarginLabel
			' 
			Me.leftMarginLabel.Location = New System.Drawing.Point(10, 53)
			Me.leftMarginLabel.Name = "leftMarginLabel"
			Me.leftMarginLabel.Size = New System.Drawing.Size(23, 13)
			Me.leftMarginLabel.TabIndex = 10
			Me.leftMarginLabel.Text = "Left:"
			' 
			' leftMarginEdit
			' 
			Me.leftMarginEdit.EditValue = New Decimal(New Integer() { 7, 0, 0, 65536})
			Me.leftMarginEdit.Location = New System.Drawing.Point(51, 50)
			Me.leftMarginEdit.Name = "leftMarginEdit"
			Me.leftMarginEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.leftMarginEdit.Properties.Increment = New Decimal(New Integer() { 25, 0, 0, 131072})
			Me.leftMarginEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.leftMarginEdit.Properties.MaxValue = New Decimal(New Integer() { 825, 0, 0, 131072})
			Me.leftMarginEdit.Size = New System.Drawing.Size(50, 20)
			Me.leftMarginEdit.TabIndex = 10
'			Me.leftMarginEdit.EditValueChanged += New System.EventHandler(Me.leftMarginEdit_EditValueChanged);
			' 
			' pageOrientationPanel
			' 
			Me.pageOrientationPanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pageOrientationPanel.Controls.Add(Me.pageOrientationGroup)
			Me.pageOrientationPanel.Location = New System.Drawing.Point(449, 398)
			Me.pageOrientationPanel.Name = "pageOrientationPanel"
			Me.pageOrientationPanel.Size = New System.Drawing.Size(212, 100)
			Me.pageOrientationPanel.TabIndex = 11
			Me.pageOrientationPanel.Text = "Page Orientation"
			' 
			' paperKindBox
			' 
			Me.paperKindBox.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.paperKindBox.Location = New System.Drawing.Point(508, 266)
			Me.paperKindBox.Name = "paperKindBox"
			Me.paperKindBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.paperKindBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.paperKindBox.Size = New System.Drawing.Size(153, 20)
			Me.paperKindBox.TabIndex = 7
'			Me.paperKindBox.SelectedIndexChanged += New System.EventHandler(Me.paperKindBox_SelectedIndexChanged);
			' 
			' paperKindLabel
			' 
			Me.paperKindLabel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.paperKindLabel.Location = New System.Drawing.Point(449, 269)
			Me.paperKindLabel.Name = "paperKindLabel"
			Me.paperKindLabel.Size = New System.Drawing.Size(54, 13)
			Me.paperKindLabel.TabIndex = 8
			Me.paperKindLabel.Text = "Paper Size:"
			' 
			' viewTypePanel
			' 
			Me.viewTypePanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewTypePanel.Controls.Add(Me.viewTypeGroup)
			Me.viewTypePanel.Location = New System.Drawing.Point(449, 0)
			Me.viewTypePanel.Name = "viewTypePanel"
			Me.viewTypePanel.Size = New System.Drawing.Size(212, 94)
			Me.viewTypePanel.TabIndex = 0
			Me.viewTypePanel.Text = "View Type"
			' 
			' viewOptionsPanel
			' 
			Me.viewOptionsPanel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.viewOptionsPanel.Controls.Add(Me.showGridCheckEdit)
			Me.viewOptionsPanel.Controls.Add(Me.showHeadingsCheckEdit)
			Me.viewOptionsPanel.Controls.Add(Me.zoomTrackBar)
			Me.viewOptionsPanel.Controls.Add(Me.useR1C1StyleCheckEdit)
			Me.viewOptionsPanel.Controls.Add(Me.zoomLabel)
			Me.viewOptionsPanel.Controls.Add(Me.tabColorLabel)
			Me.viewOptionsPanel.Controls.Add(Me.tabColodEdit)
			Me.viewOptionsPanel.Location = New System.Drawing.Point(449, 100)
			Me.viewOptionsPanel.Name = "viewOptionsPanel"
			Me.viewOptionsPanel.Size = New System.Drawing.Size(212, 160)
			Me.viewOptionsPanel.TabIndex = 1
			Me.viewOptionsPanel.Text = "View Options"
			' 
			' previewControl
			' 
			Me.previewControl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.previewControl.IsMetric = False
			Me.previewControl.Location = New System.Drawing.Point(0, 0)
			Me.previewControl.Name = "previewControl"
			Me.previewControl.Size = New System.Drawing.Size(443, 549)
			Me.previewControl.TabIndex = 12
			Me.previewControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' SpreadsheetCustomViewModule
			' 
			Me.Controls.Add(Me.saveButton)
			Me.Controls.Add(Me.paperKindLabel)
			Me.Controls.Add(Me.marginsPanel)
			Me.Controls.Add(Me.viewOptionsPanel)
			Me.Controls.Add(Me.viewTypePanel)
			Me.Controls.Add(Me.pageOrientationPanel)
			Me.Controls.Add(Me.paperKindBox)
			Me.Controls.Add(Me.previewControl)
			Me.Name = "SpreadsheetCustomViewModule"
			Me.Size = New System.Drawing.Size(667, 549)
			CType(Me.showGridCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showHeadingsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.useR1C1StyleCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabColodEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageOrientationGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewTypeGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.marginsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.marginsPanel.ResumeLayout(False)
			Me.marginsPanel.PerformLayout()
			CType(Me.footerMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.headerMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rightMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.leftMarginEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageOrientationPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageOrientationPanel.ResumeLayout(False)
			CType(Me.paperKindBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewTypePanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewTypePanel.ResumeLayout(False)
			CType(Me.viewOptionsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewOptionsPanel.ResumeLayout(False)
			Me.viewOptionsPanel.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private zoomLabel As LabelControl
		Private showGridCheckEdit As CheckEdit
		Private showHeadingsCheckEdit As CheckEdit
		Private useR1C1StyleCheckEdit As CheckEdit
		Private WithEvents saveButton As SimpleButton
		Private tabColorLabel As LabelControl
		Private tabColodEdit As ColorEdit
		Private WithEvents pageOrientationGroup As RadioGroup
		Private viewTypeGroup As RadioGroup
		Private WithEvents zoomTrackBar As ZoomTrackBarControl
		Private marginsPanel As GroupControl
		Private pageOrientationPanel As GroupControl
		Private footerMarginLabel As LabelControl
		Private WithEvents footerMarginEdit As SpinEdit
		Private headerMarginLabel As LabelControl
		Private WithEvents headerMarginEdit As SpinEdit
		Private topMarginLabel As LabelControl
		Private WithEvents topMarginEdit As SpinEdit
		Private bottomMarginLabel As LabelControl
		Private WithEvents bottomMarginEdit As SpinEdit
		Private rightMarginLabel As LabelControl
		Private WithEvents rightMarginEdit As SpinEdit
		Private leftMarginLabel As LabelControl
		Private WithEvents leftMarginEdit As SpinEdit
		Private paperKindLabel As LabelControl
		Private WithEvents paperKindBox As ComboBoxEdit
		Private viewTypePanel As GroupControl
		Private viewOptionsPanel As GroupControl
		Private previewControl As PrintControl
	End Class
End Namespace
