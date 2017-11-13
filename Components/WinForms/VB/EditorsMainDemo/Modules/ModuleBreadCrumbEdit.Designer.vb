Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleBreadCrumbEdit
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleBreadCrumbEdit))
            Dim breadCrumbNode1 As New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode2 As New DevExpress.XtraEditors.BreadCrumbNode()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.groupControl5 = New DevExpress.XtraEditors.GroupControl()
            Me.eventsLog = New DevExpress.XtraEditors.MemoEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnClearEventLog = New DevExpress.XtraEditors.SimpleButton()
            Me.navCommandsPanal = New DevExpress.XtraEditors.GroupControl()
            Me.btnGoUp = New DevExpress.XtraEditors.SimpleButton()
            Me.btnGoForward = New DevExpress.XtraEditors.SimpleButton()
            Me.btnGoBack = New DevExpress.XtraEditors.SimpleButton()
            Me.optionsGroup = New DevExpress.XtraEditors.GroupControl()
            Me.selNodeValueLabel = New DevExpress.XtraEditors.LabelControl()
            Me.cbeImages = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.images = New DevExpress.Utils.ImageCollection(Me.components)
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.ceShowRootGlyph = New DevExpress.XtraEditors.CheckEdit()
            Me.seDropDownRowCount = New DevExpress.XtraEditors.SpinEdit()
            Me.cbeMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.selectedNodeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.dropDownRowCountLabel = New DevExpress.XtraEditors.LabelControl()
            Me.modeLabel = New DevExpress.XtraEditors.LabelControl()
            Me.previewGroup = New DevExpress.XtraEditors.GroupControl()
            Me.breadCrumbEdit = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.pathLabel = New DevExpress.XtraEditors.LabelControl()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl5.SuspendLayout()
            CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.navCommandsPanal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navCommandsPanal.SuspendLayout()
            CType(Me.optionsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.optionsGroup.SuspendLayout()
            CType(Me.cbeImages.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.images, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceShowRootGlyph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.seDropDownRowCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbeMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewGroup.SuspendLayout()
            CType(Me.breadCrumbEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' breadCrumbEdit
            ' 
            Me.breadCrumbEdit.Location = New System.Drawing.Point(20, 61)
            Me.breadCrumbEdit.Name = "breadCrumbEdit"
            Me.breadCrumbEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.breadCrumbEdit.Properties.ImageIndex = 0
            Me.breadCrumbEdit.Properties.SortNodesByCaption = True
            Me.breadCrumbEdit.Properties.Images = Me.images
            breadCrumbNode1.Caption = "Root"
            breadCrumbNode1.Persistent = True
            breadCrumbNode1.PopulateOnDemand = True
            breadCrumbNode1.ShowCaption = False
            breadCrumbNode1.Value = "Root"
            breadCrumbNode2.Caption = "Computer"
            breadCrumbNode2.Persistent = True
            breadCrumbNode2.PopulateOnDemand = True
            breadCrumbNode2.Value = "Computer"
            Me.breadCrumbEdit.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() {breadCrumbNode1, breadCrumbNode2})
            Me.breadCrumbEdit.Properties.RootImageIndex = 0
            '			Me.breadCrumbEdit.Properties.PathChanged += New DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(Me.OnBreadCrumbPathChanged)
            '			Me.breadCrumbEdit.Properties.NodeClick += New DevExpress.XtraEditors.BreadCrumbNodeClickEventHandler(Me.OnBreadCrumbNodeClick)
            '			Me.breadCrumbEdit.Properties.SelectedNodeChanged += New DevExpress.XtraEditors.BreadCrumbSelectedNodeChangedEventHandler(Me.OnBreadCrumbSelectedNodeChanged)
            '			Me.breadCrumbEdit.Properties.RootGlyphClick += New System.EventHandler(Me.OnBreadCrumbRootGlyphClick)
            '			Me.breadCrumbEdit.Properties.SelectorClientEmptySpaceClick += New System.Windows.Forms.MouseEventHandler(Me.OnBreadCrumbSelectorClientEmptySpaceClick)
            '			Me.breadCrumbEdit.Properties.QueryChildNodes += New DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(Me.OnBreadCrumbQueryChildNodes)
            '			Me.breadCrumbEdit.Properties.ValidatePath += New DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(Me.OnBreadCrumbValidatePath)
            '			Me.breadCrumbEdit.Properties.PathRejected += New DevExpress.XtraEditors.BreadCrumbPathRejectedEventHandler(Me.OnBreadCrumbPathRejected)
            '			Me.breadCrumbEdit.Properties.NewNodeAdding += New DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(Me.OnBreadCrumbNewNodeAdding)
            '			Me.breadCrumbEdit.Properties.ShowUserActionMenu += New DevExpress.XtraEditors.BreadCrumbShowUserActionMenuEventHandler(Me.OnBreadCrumbShowUserActionMenu)
            '			Me.breadCrumbEdit.Properties.ShownNodeDropdown += New DevExpress.XtraEditors.BreadCrumbShownNodeDropDownEventHandler(Me.OnBreadCrumbShownNodeDropdown)
            '			Me.breadCrumbEdit.Properties.HiddenNodeDropDown += New DevExpress.XtraEditors.BreadCrumbHiddenNodeDropDownEventHandler(Me.OnBreadCrumbHiddenNodeDropDown)
            Me.breadCrumbEdit.Size = New System.Drawing.Size(639, 22)
            Me.breadCrumbEdit.TabIndex = 0
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(5, 0)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            Me.xtraTabControl1.Size = New System.Drawing.Size(734, 504)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1})
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.Controls.Add(Me.groupControl5)
            Me.xtraTabPage1.Controls.Add(Me.navCommandsPanal)
            Me.xtraTabPage1.Controls.Add(Me.optionsGroup)
            Me.xtraTabPage1.Controls.Add(Me.previewGroup)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(728, 498)
            Me.xtraTabPage1.Text = "xtraTabPage1"
            ' 
            ' groupControl5
            ' 
            Me.groupControl5.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupControl5.Appearance.Options.UseBackColor = True
            Me.groupControl5.CaptionImage = My.Resources.note_16x16
            Me.groupControl5.Controls.Add(Me.eventsLog)
            Me.groupControl5.Controls.Add(Me.panelControl1)
            Me.groupControl5.Location = New System.Drawing.Point(381, 199)
            Me.groupControl5.Name = "groupControl5"
            Me.groupControl5.Padding = New System.Windows.Forms.Padding(8)
            Me.groupControl5.Size = New System.Drawing.Size(328, 284)
            Me.groupControl5.TabIndex = 14
            Me.groupControl5.Text = "Event log"
            ' 
            ' eventsLog
            ' 
            Me.eventsLog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.eventsLog.EditValue = ""
            Me.eventsLog.Location = New System.Drawing.Point(10, 32)
            Me.eventsLog.Name = "eventsLog"
            Me.eventsLog.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.eventsLog.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
            Me.eventsLog.Properties.Appearance.Options.UseBackColor = True
            Me.eventsLog.Properties.Appearance.Options.UseForeColor = True
            Me.eventsLog.Properties.ReadOnly = True
            Me.eventsLog.Size = New System.Drawing.Size(308, 195)
            Me.eventsLog.TabIndex = 0
            Me.eventsLog.TabStop = False
            Me.eventsLog.UseOptimizedRendering = True
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.btnClearEventLog)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(10, 227)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(308, 47)
            Me.panelControl1.TabIndex = 9
            ' 
            ' btnClearEventLog
            ' 
            Me.btnClearEventLog.Location = New System.Drawing.Point(228, 12)
            Me.btnClearEventLog.Name = "btnClearEventLog"
            Me.btnClearEventLog.Size = New System.Drawing.Size(80, 23)
            Me.btnClearEventLog.TabIndex = 8
            Me.btnClearEventLog.Text = "Clear log"
            '			Me.btnClearEventLog.Click += New System.EventHandler(Me.OnClearEventLogClick)
            ' 
            ' navCommandsPanal
            ' 
            Me.navCommandsPanal.Controls.Add(Me.btnGoUp)
            Me.navCommandsPanal.Controls.Add(Me.btnGoForward)
            Me.navCommandsPanal.Controls.Add(Me.btnGoBack)
            Me.navCommandsPanal.Location = New System.Drawing.Point(22, 406)
            Me.navCommandsPanal.Name = "navCommandsPanal"
            Me.navCommandsPanal.Size = New System.Drawing.Size(328, 77)
            Me.navCommandsPanal.TabIndex = 13
            Me.navCommandsPanal.Text = "Navigation"
            ' 
            ' btnGoUp
            ' 
            Me.btnGoUp.Location = New System.Drawing.Point(20, 32)
            Me.btnGoUp.Name = "btnGoUp"
            Me.btnGoUp.Size = New System.Drawing.Size(84, 23)
            Me.btnGoUp.TabIndex = 3
            Me.btnGoUp.Text = "Go Up"
            '			Me.btnGoUp.Click += New System.EventHandler(Me.OnGoUpClick)
            ' 
            ' btnGoForward
            ' 
            Me.btnGoForward.Location = New System.Drawing.Point(216, 32)
            Me.btnGoForward.Name = "btnGoForward"
            Me.btnGoForward.Size = New System.Drawing.Size(84, 23)
            Me.btnGoForward.TabIndex = 2
            Me.btnGoForward.Text = "Go Forward"
            '			Me.btnGoForward.Click += New System.EventHandler(Me.OnGoForwardClick)
            ' 
            ' btnGoBack
            ' 
            Me.btnGoBack.Location = New System.Drawing.Point(118, 32)
            Me.btnGoBack.Name = "btnGoBack"
            Me.btnGoBack.Size = New System.Drawing.Size(84, 23)
            Me.btnGoBack.TabIndex = 1
            Me.btnGoBack.Text = "Go Back"
            '			Me.btnGoBack.Click += New System.EventHandler(Me.OnGoBackClick)
            ' 
            ' optionsGroup
            ' 
            Me.optionsGroup.Controls.Add(Me.selNodeValueLabel)
            Me.optionsGroup.Controls.Add(Me.cbeImages)
            Me.optionsGroup.Controls.Add(Me.labelControl1)
            Me.optionsGroup.Controls.Add(Me.ceShowRootGlyph)
            Me.optionsGroup.Controls.Add(Me.seDropDownRowCount)
            Me.optionsGroup.Controls.Add(Me.cbeMode)
            Me.optionsGroup.Controls.Add(Me.selectedNodeLabel)
            Me.optionsGroup.Controls.Add(Me.dropDownRowCountLabel)
            Me.optionsGroup.Controls.Add(Me.modeLabel)
            Me.optionsGroup.Location = New System.Drawing.Point(22, 199)
            Me.optionsGroup.Name = "optionsGroup"
            Me.optionsGroup.Size = New System.Drawing.Size(328, 186)
            Me.optionsGroup.TabIndex = 5
            Me.optionsGroup.Text = "Options"
            ' 
            ' selNodeValueLabel
            ' 
            Me.selNodeValueLabel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.selNodeValueLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.selNodeValueLabel.Location = New System.Drawing.Point(151, 152)
            Me.selNodeValueLabel.Name = "selNodeValueLabel"
            Me.selNodeValueLabel.Size = New System.Drawing.Size(149, 13)
            Me.selNodeValueLabel.TabIndex = 15
            Me.selNodeValueLabel.Text = "(node)"
            ' 
            ' cbeImages
            ' 
            Me.cbeImages.Location = New System.Drawing.Point(151, 90)
            Me.cbeImages.Name = "cbeImages"
            Me.cbeImages.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeImages.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Folder", "Folder", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("GrayFolder", "GrayFolder", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Check", "Check", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Delete", "Delete", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Customize", "Customize", 4)})
            Me.cbeImages.Properties.LargeImages = Me.images
            Me.cbeImages.Properties.SmallImages = Me.images
            Me.cbeImages.Size = New System.Drawing.Size(149, 20)
            Me.cbeImages.TabIndex = 14
            '			Me.cbeImages.SelectedIndexChanged += New System.EventHandler(Me.OnBreadCrumbSelectedIndexChanged)
            ' 
            ' images
            ' 
            Me.images.ImageStream = (CType(resources.GetObject("images.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.images.Images.SetKeyName(0, "folder_16x16.png")
            Me.images.Images.SetKeyName(1, "gray-folder_16x161.png")
            Me.images.Images.SetKeyName(2, "checkbox_16x16.png")
            Me.images.Images.SetKeyName(3, "delete_16x16.png")
            Me.images.Images.SetKeyName(4, "technology_16x16.png")
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(20, 93)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(57, 13)
            Me.labelControl1.TabIndex = 13
            Me.labelControl1.Text = "Root Glyph:"
            ' 
            ' ceShowRootGlyph
            ' 
            Me.ceShowRootGlyph.Location = New System.Drawing.Point(19, 122)
            Me.ceShowRootGlyph.Name = "ceShowRootGlyph"
            Me.ceShowRootGlyph.Properties.Caption = "Show Root Glyph"
            Me.ceShowRootGlyph.Size = New System.Drawing.Size(153, 15)
            Me.ceShowRootGlyph.TabIndex = 12
            '			Me.ceShowRootGlyph.CheckedChanged += New System.EventHandler(Me.OnShowRootGlyphCheckedChanged)
            ' 
            ' seDropDownRowCount
            ' 
            Me.seDropDownRowCount.EditValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.seDropDownRowCount.Location = New System.Drawing.Point(151, 61)
            Me.seDropDownRowCount.Name = "seDropDownRowCount"
            Me.seDropDownRowCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seDropDownRowCount.Properties.Mask.EditMask = "n0"
            Me.seDropDownRowCount.Properties.MaxValue = New Decimal(New Integer() {48, 0, 0, 0})
            Me.seDropDownRowCount.Properties.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.seDropDownRowCount.Size = New System.Drawing.Size(149, 20)
            Me.seDropDownRowCount.TabIndex = 11
            '			Me.seDropDownRowCount.EditValueChanged += New System.EventHandler(Me.OnBreadCrumbDropDownRowCountChanged)
            ' 
            ' cbeMode
            ' 
            Me.cbeMode.Location = New System.Drawing.Point(151, 32)
            Me.cbeMode.Name = "cbeMode"
            Me.cbeMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeMode.Size = New System.Drawing.Size(149, 20)
            Me.cbeMode.TabIndex = 10
            '			Me.cbeMode.SelectedIndexChanged += New System.EventHandler(Me.OnBreadCrumbModeChanged)
            ' 
            ' selectedNodeLabel
            ' 
            Me.selectedNodeLabel.Location = New System.Drawing.Point(20, 153)
            Me.selectedNodeLabel.Name = "selectedNodeLabel"
            Me.selectedNodeLabel.Size = New System.Drawing.Size(73, 13)
            Me.selectedNodeLabel.TabIndex = 6
            Me.selectedNodeLabel.Text = "Selected Node:"
            ' 
            ' dropDownRowCountLabel
            ' 
            Me.dropDownRowCountLabel.Location = New System.Drawing.Point(20, 64)
            Me.dropDownRowCountLabel.Name = "dropDownRowCountLabel"
            Me.dropDownRowCountLabel.Size = New System.Drawing.Size(110, 13)
            Me.dropDownRowCountLabel.TabIndex = 4
            Me.dropDownRowCountLabel.Text = "DropDown Row Count:"
            ' 
            ' modeLabel
            ' 
            Me.modeLabel.Location = New System.Drawing.Point(20, 35)
            Me.modeLabel.Name = "modeLabel"
            Me.modeLabel.Size = New System.Drawing.Size(92, 13)
            Me.modeLabel.TabIndex = 0
            Me.modeLabel.Text = "BreadCrumb Mode:"
            ' 
            ' previewGroup
            ' 
            Me.previewGroup.Controls.Add(Me.breadCrumbEdit)
            Me.previewGroup.Controls.Add(Me.pathLabel)
            Me.previewGroup.Location = New System.Drawing.Point(22, 24)
            Me.previewGroup.Name = "previewGroup"
            Me.previewGroup.Size = New System.Drawing.Size(687, 154)
            Me.previewGroup.TabIndex = 4
            Me.previewGroup.Text = "Sample"

            ' 
            ' pathLabel
            ' 
            Me.pathLabel.Location = New System.Drawing.Point(20, 34)
            Me.pathLabel.Name = "pathLabel"
            Me.pathLabel.Size = New System.Drawing.Size(22, 13)
            Me.pathLabel.TabIndex = 5
            Me.pathLabel.Text = "Path"
            ' 
            ' ModuleBreadCrumbEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Name = "ModuleBreadCrumbEdit"
            Me.Size = New System.Drawing.Size(739, 509)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.groupControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl5.ResumeLayout(False)
            CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.navCommandsPanal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navCommandsPanal.ResumeLayout(False)
            CType(Me.optionsGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.optionsGroup.ResumeLayout(False)
            Me.optionsGroup.PerformLayout()
            CType(Me.cbeImages.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.images, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceShowRootGlyph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.seDropDownRowCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbeMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.previewGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewGroup.ResumeLayout(False)
            Me.previewGroup.PerformLayout()
            CType(Me.breadCrumbEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private previewGroup As GroupControl
		Private WithEvents breadCrumbEdit As BreadCrumbEdit
		Private optionsGroup As GroupControl
		Private modeLabel As LabelControl
		Private WithEvents btnGoUp As SimpleButton
		Private WithEvents btnGoForward As SimpleButton
		Private WithEvents btnGoBack As SimpleButton
		Private dropDownRowCountLabel As LabelControl
		Private pathLabel As LabelControl
		Private selectedNodeLabel As LabelControl
		Private images As Utils.ImageCollection
		Private WithEvents seDropDownRowCount As SpinEdit
		Private WithEvents cbeMode As ImageComboBoxEdit
		Private WithEvents ceShowRootGlyph As CheckEdit
		Private navCommandsPanal As GroupControl
		Private groupControl5 As GroupControl
		Private eventsLog As MemoEdit
		Private panelControl1 As PanelControl
		Private WithEvents btnClearEventLog As SimpleButton
		Private labelControl1 As LabelControl
		Private WithEvents cbeImages As ImageComboBoxEdit
		Private selNodeValueLabel As LabelControl

	End Class
End Namespace
