Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class FindPanelOptions
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnApply = New DevExpress.XtraEditors.SimpleButton()
            Me.ceShowFindButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowClearButton = New DevExpress.XtraEditors.CheckEdit()
            Me.cbFindMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seFindDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.cbFindFilterColumns = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceHighlightFindResults = New DevExpress.XtraEditors.CheckEdit()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.ceShowFindButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowClearButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFindMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seFindDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' btnCancel
            ' 
            Me.btnCancel.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(267, 244)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(83, 22)
            Me.btnCancel.StyleController = Me.layoutControl1
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancel"
            ' 
            ' btnApply
            ' 
            Me.btnApply.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnApply.Location = New System.Drawing.Point(181, 244)
            Me.btnApply.Name = "btnApply"
            Me.btnApply.Size = New System.Drawing.Size(82, 22)
            Me.btnApply.StyleController = Me.layoutControl1
            Me.btnApply.TabIndex = 0
            Me.btnApply.Text = "&OK"
            '			Me.btnApply.Click += New System.EventHandler(Me.btnApply_Click)
            ' 
            ' ceShowFindButton
            ' 
            Me.ceShowFindButton.Location = New System.Drawing.Point(12, 154)
            Me.ceShowFindButton.Name = "ceShowFindButton"
            Me.ceShowFindButton.Properties.Caption = "Show Find Button"
            Me.ceShowFindButton.Size = New System.Drawing.Size(158, 19)
            Me.ceShowFindButton.StyleController = Me.layoutControl1
            Me.ceShowFindButton.TabIndex = 7
            ' 
            ' ceShowCloseButton
            ' 
            Me.ceShowCloseButton.Location = New System.Drawing.Point(12, 108)
            Me.ceShowCloseButton.Name = "ceShowCloseButton"
            Me.ceShowCloseButton.Properties.Caption = "Show Close Button"
            Me.ceShowCloseButton.Size = New System.Drawing.Size(158, 19)
            Me.ceShowCloseButton.StyleController = Me.layoutControl1
            Me.ceShowCloseButton.TabIndex = 5
            ' 
            ' ceShowClearButton
            ' 
            Me.ceShowClearButton.Location = New System.Drawing.Point(12, 131)
            Me.ceShowClearButton.Name = "ceShowClearButton"
            Me.ceShowClearButton.Properties.Caption = "Show Clear Button"
            Me.ceShowClearButton.Size = New System.Drawing.Size(158, 19)
            Me.ceShowClearButton.StyleController = Me.layoutControl1
            Me.ceShowClearButton.TabIndex = 6
            ' 
            ' cbFindMode
            ' 
            Me.cbFindMode.Location = New System.Drawing.Point(124, 36)
            Me.cbFindMode.Name = "cbFindMode"
            Me.cbFindMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFindMode.Size = New System.Drawing.Size(226, 20)
            Me.cbFindMode.StyleController = Me.layoutControl1
            Me.cbFindMode.TabIndex = 3
            ' 
            ' seFindDelay
            ' 
            Me.seFindDelay.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seFindDelay.Location = New System.Drawing.Point(124, 60)
            Me.seFindDelay.Name = "seFindDelay"
            Me.seFindDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seFindDelay.Properties.IsFloatValue = False
            Me.seFindDelay.Properties.Mask.EditMask = "N00"
            Me.seFindDelay.Properties.MaxValue = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.seFindDelay.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seFindDelay.Size = New System.Drawing.Size(226, 20)
            Me.seFindDelay.StyleController = Me.layoutControl1
            Me.seFindDelay.TabIndex = 4
            ' 
            ' cbFindFilterColumns
            ' 
            Me.cbFindFilterColumns.Location = New System.Drawing.Point(124, 12)
            Me.cbFindFilterColumns.Name = "cbFindFilterColumns"
            Me.cbFindFilterColumns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbFindFilterColumns.Properties.DropDownRows = 25
            Me.cbFindFilterColumns.Size = New System.Drawing.Size(226, 20)
            Me.cbFindFilterColumns.StyleController = Me.layoutControl1
            Me.cbFindFilterColumns.TabIndex = 2
            ' 
            ' ceHighlightFindResults
            ' 
            Me.ceHighlightFindResults.Location = New System.Drawing.Point(12, 177)
            Me.ceHighlightFindResults.Name = "ceHighlightFindResults"
            Me.ceHighlightFindResults.Properties.Caption = "Highlight Find Results"
            Me.ceHighlightFindResults.Size = New System.Drawing.Size(158, 19)
            Me.ceHighlightFindResults.StyleController = Me.layoutControl1
            Me.ceHighlightFindResults.TabIndex = 8
            ' 
            ' label1
            ' 
            Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label1.Location = New System.Drawing.Point(12, 60)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(108, 20)
            Me.label1.TabIndex = 21
            Me.label1.Text = "Find Delay:"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' label2
            ' 
            Me.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label2.Location = New System.Drawing.Point(12, 12)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(108, 20)
            Me.label2.TabIndex = 21
            Me.label2.Text = "Find Filter Columns:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' label3
            ' 
            Me.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label3.Location = New System.Drawing.Point(12, 36)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(108, 20)
            Me.label3.TabIndex = 21
            Me.label3.Text = "Find Mode:"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnCancel)
            Me.layoutControl1.Controls.Add(Me.ceHighlightFindResults)
            Me.layoutControl1.Controls.Add(Me.btnApply)
            Me.layoutControl1.Controls.Add(Me.ceShowFindButton)
            Me.layoutControl1.Controls.Add(Me.label1)
            Me.layoutControl1.Controls.Add(Me.ceShowClearButton)
            Me.layoutControl1.Controls.Add(Me.ceShowCloseButton)
            Me.layoutControl1.Controls.Add(Me.seFindDelay)
            Me.layoutControl1.Controls.Add(Me.label3)
            Me.layoutControl1.Controls.Add(Me.cbFindMode)
            Me.layoutControl1.Controls.Add(Me.label2)
            Me.layoutControl1.Controls.Add(Me.cbFindFilterColumns)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(820, 52, 625, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(362, 278)
            Me.layoutControl1.TabIndex = 22
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem11, Me.layoutControlItem12, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(362, 278)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.label2
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(112, 24)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cbFindFilterColumns
            Me.layoutControlItem2.Location = New System.Drawing.Point(112, 0)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(54, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(230, 24)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.label3
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(112, 24)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbFindMode
            Me.layoutControlItem4.Location = New System.Drawing.Point(112, 24)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(54, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(230, 24)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.label1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(112, 24)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(112, 24)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seFindDelay
            Me.layoutControlItem6.Location = New System.Drawing.Point(112, 48)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(54, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(230, 24)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceShowCloseButton
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem7.MaxSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(162, 23)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceShowClearButton
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 119)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(162, 23)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceShowFindButton
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 142)
            Me.layoutControlItem9.MaxSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem9.MinSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(162, 23)
            Me.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceHighlightFindResults
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 165)
            Me.layoutControlItem10.MaxSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem10.MinSize = New System.Drawing.Size(162, 23)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(162, 23)
            Me.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.btnApply
            Me.layoutControlItem11.Location = New System.Drawing.Point(169, 232)
            Me.layoutControlItem11.MaxSize = New System.Drawing.Size(86, 26)
            Me.layoutControlItem11.MinSize = New System.Drawing.Size(86, 26)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(86, 26)
            Me.layoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.btnCancel
            Me.layoutControlItem12.Location = New System.Drawing.Point(255, 232)
            Me.layoutControlItem12.MaxSize = New System.Drawing.Size(87, 26)
            Me.layoutControlItem12.MinSize = New System.Drawing.Size(87, 26)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(87, 26)
            Me.layoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 72)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(342, 24)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 188)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(342, 44)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(162, 96)
            Me.emptySpaceItem3.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(180, 92)
            Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 232)
            Me.emptySpaceItem5.MinSize = New System.Drawing.Size(104, 24)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(169, 26)
            Me.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' FindPanelOptions
            ' 
            Me.AcceptButton = Me.btnApply
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(362, 278)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "FindPanelOptions"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Find Panel Options"
            Me.TopMost = True
            CType(Me.ceShowFindButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowClearButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFindMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seFindDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private btnCancel As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnApply As DevExpress.XtraEditors.SimpleButton
        Private ceShowFindButton As DevExpress.XtraEditors.CheckEdit
        Private ceShowCloseButton As DevExpress.XtraEditors.CheckEdit
        Private ceShowClearButton As DevExpress.XtraEditors.CheckEdit
        Private cbFindMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private seFindDelay As DevExpress.XtraEditors.SpinEdit
        Private cbFindFilterColumns As DevExpress.XtraEditors.ImageComboBoxEdit
        Private ceHighlightFindResults As DevExpress.XtraEditors.CheckEdit
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private layoutControlItem5 As XtraLayout.LayoutControlItem
        Private layoutControlItem6 As XtraLayout.LayoutControlItem
        Private layoutControlItem7 As XtraLayout.LayoutControlItem
        Private layoutControlItem11 As XtraLayout.LayoutControlItem
        Private layoutControlItem12 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
        Private layoutControlItem8 As XtraLayout.LayoutControlItem
        Private layoutControlItem9 As XtraLayout.LayoutControlItem
        Private layoutControlItem10 As XtraLayout.LayoutControlItem
        Private emptySpaceItem5 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
