Namespace DevExpress.XtraLayout.Demos
	Partial Public Class Multilanguage
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
			Me.showFormButton = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.lblInfo = New DevExpress.XtraEditors.LabelControl()
			Me.layoutModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.localizationModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.dpiModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.sizeModeRadioGroup = New DevExpress.XtraEditors.RadioGroup()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.selectionGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.localizationGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.localizationModeRadionGroupItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutModeGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutModeRadionGroupItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.dpiGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.dpiModeRadionGroupItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.sizeModeGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.sizeModeRadionGroupItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.showFormButtonItem = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.emptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.localizationModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dpiModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sizeModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.selectionGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.localizationGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.localizationModeRadionGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutModeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutModeRadionGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dpiGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dpiModeRadionGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sizeModeGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sizeModeRadionGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.showFormButtonItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' showFormButton
            ' 
            Me.showFormButton.Location = New System.Drawing.Point(616, 263)
            Me.showFormButton.Name = "showFormButton"
            Me.showFormButton.Size = New System.Drawing.Size(136, 36)
            Me.showFormButton.StyleController = Me.layoutControl1
            Me.showFormButton.TabIndex = 6
            Me.showFormButton.Text = "Show"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.lblInfo)
            Me.layoutControl1.Controls.Add(Me.showFormButton)
            Me.layoutControl1.Controls.Add(Me.layoutModeRadioGroup)
            Me.layoutControl1.Controls.Add(Me.localizationModeRadioGroup)
            Me.layoutControl1.Controls.Add(Me.dpiModeRadioGroup)
            Me.layoutControl1.Controls.Add(Me.sizeModeRadioGroup)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(961, 80, 854, 859)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(935, 540)
            Me.layoutControl1.TabIndex = 7
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' lblInfo
            ' 
            Me.lblInfo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold)
            Me.lblInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(150)))), (CInt((CByte(150)))), (CInt((CByte(150)))))
            Me.lblInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblInfo.Location = New System.Drawing.Point(455, 161)
            Me.lblInfo.Name = "lblInfo"
            Me.lblInfo.Size = New System.Drawing.Size(467, 19)
            Me.lblInfo.StyleController = Me.layoutControl1
            Me.lblInfo.TabIndex = 14
            Me.lblInfo.Text = "Click the button below to show a form with these options"
            ' 
            ' layoutModeRadioGroup
            ' 
            Me.layoutModeRadioGroup.Location = New System.Drawing.Point(241, 127)
            Me.layoutModeRadioGroup.Name = "layoutModeRadioGroup"
            Me.layoutModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.layoutModeRadioGroup.Properties.Columns = 1
            Me.layoutModeRadioGroup.Size = New System.Drawing.Size(177, 143)
            Me.layoutModeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Flow"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Regular")
            })
            Me.layoutModeRadioGroup.StyleController = Me.layoutControl1
            Me.layoutModeRadioGroup.TabIndex = 10
            ' 
            ' localizationModeRadioGroup
            ' 
            Me.localizationModeRadioGroup.Location = New System.Drawing.Point(36, 127)
            Me.localizationModeRadioGroup.Name = "localizationModeRadioGroup"
            Me.localizationModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.localizationModeRadioGroup.Properties.Columns = 1
            Me.localizationModeRadioGroup.Size = New System.Drawing.Size(177, 143)
            Me.localizationModeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "English version"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "German version")
            })
            Me.localizationModeRadioGroup.StyleController = Me.layoutControl1
            Me.localizationModeRadioGroup.TabIndex = 11
            ' 
            ' dpiModeRadioGroup
            ' 
            Me.dpiModeRadioGroup.Location = New System.Drawing.Point(241, 317)
            Me.dpiModeRadioGroup.Name = "dpiModeRadioGroup"
            Me.dpiModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.dpiModeRadioGroup.Properties.Columns = 1
            Me.dpiModeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Small DPI(75%)"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Regular DPI(100%)"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Medium DPI(125%)"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Large DPI(150%)")
            })
            Me.dpiModeRadioGroup.Size = New System.Drawing.Size(177, 143)
            Me.dpiModeRadioGroup.StyleController = Me.layoutControl1
            Me.dpiModeRadioGroup.TabIndex = 12
            ' 
            ' sizeModeRadioGroup
            ' 
            Me.sizeModeRadioGroup.Location = New System.Drawing.Point(36, 317)
            Me.sizeModeRadioGroup.Name = "sizeModeRadioGroup"
            Me.sizeModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.sizeModeRadioGroup.Properties.Columns = 1
            Me.sizeModeRadioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.sizeModeRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Animated Form"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tablet Landscape"),
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tablet Portrait")
            })
            Me.sizeModeRadioGroup.Size = New System.Drawing.Size(177, 143)
            Me.sizeModeRadioGroup.StyleController = Me.layoutControl1
            Me.sizeModeRadioGroup.TabIndex = 13
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.selectionGroup, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.showFormButtonItem, Me.emptySpaceItem5, Me.emptySpaceItem6, Me.layoutControlItem1, Me.emptySpaceItem8})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(935, 540)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' selectionGroup
            ' 
            Me.selectionGroup.CustomizationFormText = "selectionGroup"
            Me.selectionGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.localizationGroup, Me.layoutModeGroup, Me.dpiGroup, Me.sizeModeGroup})
            Me.selectionGroup.Location = New System.Drawing.Point(0, 72)
            Me.selectionGroup.Name = "selectionGroup"
            Me.selectionGroup.Size = New System.Drawing.Size(434, 404)
            Me.selectionGroup.Text = "selectionGroup"
            Me.selectionGroup.TextVisible = False
            ' 
            ' localizationGroup
            ' 
            Me.localizationGroup.CustomizationFormText = "Select Localization"
            Me.localizationGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.localizationModeRadionGroupItem})
            Me.localizationGroup.Location = New System.Drawing.Point(0, 0)
            Me.localizationGroup.Name = "localizationGroup"
            Me.localizationGroup.Size = New System.Drawing.Size(205, 190)
            Me.localizationGroup.Text = "Form Localization"
            ' 
            ' localizationModeRadionGroupItem
            ' 
            Me.localizationModeRadionGroupItem.Control = Me.localizationModeRadioGroup
            Me.localizationModeRadionGroupItem.CustomizationFormText = "localizationModeRadionGroupItem"
            Me.localizationModeRadionGroupItem.Location = New System.Drawing.Point(0, 0)
            Me.localizationModeRadionGroupItem.MaxSize = New System.Drawing.Size(181, 147)
            Me.localizationModeRadionGroupItem.MinSize = New System.Drawing.Size(181, 147)
            Me.localizationModeRadionGroupItem.Name = "localizationModeRadionGroupItem"
            Me.localizationModeRadionGroupItem.Size = New System.Drawing.Size(181, 147)
            Me.localizationModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.localizationModeRadionGroupItem.Text = "localizationModeRadionGroupItem"
            Me.localizationModeRadionGroupItem.TextSize = New System.Drawing.Size(0, 0)
            Me.localizationModeRadionGroupItem.TextVisible = False
            ' 
            ' layoutModeGroup
            ' 
            Me.layoutModeGroup.CustomizationFormText = "Select Layout"
            Me.layoutModeGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutModeRadionGroupItem})
            Me.layoutModeGroup.Location = New System.Drawing.Point(205, 0)
            Me.layoutModeGroup.Name = "layoutModeGroup"
            Me.layoutModeGroup.Size = New System.Drawing.Size(205, 190)
            Me.layoutModeGroup.Text = "LayoutControl’s Layout Mode"
            ' 
            ' layoutModeRadionGroupItem
            ' 
            Me.layoutModeRadionGroupItem.Control = Me.layoutModeRadioGroup
            Me.layoutModeRadionGroupItem.CustomizationFormText = "layoutModeRadionGroupItem"
            Me.layoutModeRadionGroupItem.Location = New System.Drawing.Point(0, 0)
            Me.layoutModeRadionGroupItem.MaxSize = New System.Drawing.Size(181, 147)
            Me.layoutModeRadionGroupItem.MinSize = New System.Drawing.Size(181, 147)
            Me.layoutModeRadionGroupItem.Name = "layoutModeRadionGroupItem"
            Me.layoutModeRadionGroupItem.Size = New System.Drawing.Size(181, 147)
            Me.layoutModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutModeRadionGroupItem.Text = "layoutModeRadionGroupItem"
            Me.layoutModeRadionGroupItem.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutModeRadionGroupItem.TextVisible = False
            ' 
            ' dpiGroup
            ' 
            Me.dpiGroup.CustomizationFormText = "Select DPI"
            Me.dpiGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.dpiModeRadionGroupItem})
            Me.dpiGroup.Location = New System.Drawing.Point(205, 190)
            Me.dpiGroup.Name = "dpiGroup"
            Me.dpiGroup.Size = New System.Drawing.Size(205, 190)
            Me.dpiGroup.Text = "DPI"
            ' 
            ' dpiModeRadionGroupItem
            ' 
            Me.dpiModeRadionGroupItem.Control = Me.dpiModeRadioGroup
            Me.dpiModeRadionGroupItem.CustomizationFormText = "dpiModeRadionGroupItem"
            Me.dpiModeRadionGroupItem.Location = New System.Drawing.Point(0, 0)
            Me.dpiModeRadionGroupItem.MaxSize = New System.Drawing.Size(181, 147)
            Me.dpiModeRadionGroupItem.MinSize = New System.Drawing.Size(181, 147)
            Me.dpiModeRadionGroupItem.Name = "dpiModeRadionGroupItem"
            Me.dpiModeRadionGroupItem.Size = New System.Drawing.Size(181, 147)
            Me.dpiModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.dpiModeRadionGroupItem.Text = "dpiModeRadionGroupItem"
            Me.dpiModeRadionGroupItem.TextSize = New System.Drawing.Size(0, 0)
            Me.dpiModeRadionGroupItem.TextVisible = False
            ' 
            ' sizeModeGroup
            ' 
            Me.sizeModeGroup.CustomizationFormText = "Select animation"
            Me.sizeModeGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.sizeModeRadionGroupItem})
            Me.sizeModeGroup.Location = New System.Drawing.Point(0, 190)
            Me.sizeModeGroup.Name = "sizeModeGroup"
            Me.sizeModeGroup.Size = New System.Drawing.Size(205, 190)
            Me.sizeModeGroup.Text = "Form Size"
            ' 
            ' sizeModeRadionGroupItem
            ' 
            Me.sizeModeRadionGroupItem.Control = Me.sizeModeRadioGroup
            Me.sizeModeRadionGroupItem.CustomizationFormText = "sizeModeRadionGroupItem"
            Me.sizeModeRadionGroupItem.Location = New System.Drawing.Point(0, 0)
            Me.sizeModeRadionGroupItem.MaxSize = New System.Drawing.Size(181, 147)
            Me.sizeModeRadionGroupItem.MinSize = New System.Drawing.Size(181, 147)
            Me.sizeModeRadionGroupItem.Name = "sizeModeRadionGroupItem"
            Me.sizeModeRadionGroupItem.Size = New System.Drawing.Size(181, 147)
            Me.sizeModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.sizeModeRadionGroupItem.Text = "sizeModeRadionGroupItem"
            Me.sizeModeRadionGroupItem.TextSize = New System.Drawing.Size(0, 0)
            Me.sizeModeRadionGroupItem.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 476)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(915, 44)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(915, 72)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' showFormButtonItem
            ' 
            Me.showFormButtonItem.Control = Me.showFormButton
            Me.showFormButtonItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.showFormButtonItem.CustomizationFormText = "showFormButtonItem"
            Me.showFormButtonItem.Location = New System.Drawing.Point(434, 251)
            Me.showFormButtonItem.MaxSize = New System.Drawing.Size(140, 40)
            Me.showFormButtonItem.MinSize = New System.Drawing.Size(140, 40)
            Me.showFormButtonItem.Name = "showFormButtonItem"
            Me.showFormButtonItem.Size = New System.Drawing.Size(481, 40)
            Me.showFormButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.showFormButtonItem.Text = "showFormButtonItem"
            Me.showFormButtonItem.TextLocation = DevExpress.Utils.Locations.Top
            Me.showFormButtonItem.TextSize = New System.Drawing.Size(0, 0)
            Me.showFormButtonItem.TextVisible = False
            ' 
            ' emptySpaceItem5
            ' 
            Me.emptySpaceItem5.AllowHotTrack = False
            Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
            Me.emptySpaceItem5.Location = New System.Drawing.Point(434, 72)
            Me.emptySpaceItem5.Name = "emptySpaceItem5"
            Me.emptySpaceItem5.Size = New System.Drawing.Size(481, 77)
            Me.emptySpaceItem5.Text = "emptySpaceItem5"
            Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem6
            ' 
            Me.emptySpaceItem6.AllowHotTrack = False
            Me.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6"
            Me.emptySpaceItem6.Location = New System.Drawing.Point(434, 291)
            Me.emptySpaceItem6.Name = "emptySpaceItem6"
            Me.emptySpaceItem6.Size = New System.Drawing.Size(481, 185)
            Me.emptySpaceItem6.Text = "emptySpaceItem6"
            Me.emptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.lblInfo
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(434, 149)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(481, 23)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' emptySpaceItem8
            ' 
            Me.emptySpaceItem8.AllowHotTrack = False
            Me.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8"
            Me.emptySpaceItem8.Location = New System.Drawing.Point(434, 172)
            Me.emptySpaceItem8.Name = "emptySpaceItem8"
            Me.emptySpaceItem8.Size = New System.Drawing.Size(481, 79)
            Me.emptySpaceItem8.Text = "emptySpaceItem8"
            Me.emptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' Multilanguage
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Multilanguage"
            Me.Size = New System.Drawing.Size(935, 540)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.localizationModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dpiModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sizeModeRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.selectionGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.localizationGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.localizationModeRadionGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutModeGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutModeRadionGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dpiGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dpiModeRadionGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sizeModeGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sizeModeRadionGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.showFormButtonItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.Container = Nothing
		Private showFormButton As XtraEditors.SimpleButton
		Private layoutControl1 As LayoutControl
		Private layoutControlGroup1 As LayoutControlGroup
		Private dpiGroup As LayoutControlGroup
		Private layoutModeGroup As LayoutControlGroup
		Private localizationGroup As LayoutControlGroup
		Private showFormButtonItem As LayoutControlItem
		Private sizeModeGroup As LayoutControlGroup
		Private layoutModeRadioGroup As XtraEditors.RadioGroup
		Private localizationModeRadioGroup As XtraEditors.RadioGroup
		Private dpiModeRadioGroup As XtraEditors.RadioGroup
		Private sizeModeRadioGroup As XtraEditors.RadioGroup
		Private dpiModeRadionGroupItem As LayoutControlItem
		Private layoutModeRadionGroupItem As LayoutControlItem
		Private localizationModeRadionGroupItem As LayoutControlItem
		Private sizeModeRadionGroupItem As LayoutControlItem
		Private selectionGroup As LayoutControlGroup
		Private emptySpaceItem1 As EmptySpaceItem
		Private emptySpaceItem2 As EmptySpaceItem
		Private emptySpaceItem5 As EmptySpaceItem
		Private emptySpaceItem6 As EmptySpaceItem
		Private lblInfo As XtraEditors.LabelControl
		Private layoutControlItem1 As LayoutControlItem
		Private emptySpaceItem8 As EmptySpaceItem

	End Class
End Namespace
