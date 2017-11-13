Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class MultiDragAndDrop
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultiDragAndDrop))
            Me.panel = New DevExpress.XtraEditors.PanelControl()
            Me.ceAcceptOuterNodes = New DevExpress.XtraEditors.CheckEdit()
            Me.ceMultipleNodesDragAndDrop = New DevExpress.XtraEditors.CheckEdit()
            Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.tl1ClassView = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.tl2ClassView = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.repositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel.SuspendLayout()
            CType(Me.ceAcceptOuterNodes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ceMultipleNodesDragAndDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tl1ClassView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tl2ClassView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel
            '
            Me.panel.Controls.Add(Me.ceAcceptOuterNodes)
            Me.panel.Controls.Add(Me.ceMultipleNodesDragAndDrop)
            Me.panel.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel.Location = New System.Drawing.Point(0, 0)
            Me.panel.Name = "panel"
            Me.panel.Padding = New System.Windows.Forms.Padding(8)
            Me.panel.Size = New System.Drawing.Size(784, 48)
            Me.panel.TabIndex = 1
            '
            'ceAcceptOuterNodes
            '
            Me.ceAcceptOuterNodes.EditValue = True
            Me.ceAcceptOuterNodes.Location = New System.Drawing.Point(202, 13)
            Me.ceAcceptOuterNodes.Name = "ceAcceptOuterNodes"
            Me.ceAcceptOuterNodes.Properties.AutoWidth = True
            Me.ceAcceptOuterNodes.Properties.Caption = "Drag and drop between treelist controls"
            Me.ceAcceptOuterNodes.Size = New System.Drawing.Size(213, 19)
            Me.ceAcceptOuterNodes.TabIndex = 21
            '
            'ceMultipleNodesDragAndDrop
            '
            Me.ceMultipleNodesDragAndDrop.EditValue = True
            Me.ceMultipleNodesDragAndDrop.Location = New System.Drawing.Point(23, 13)
            Me.ceMultipleNodesDragAndDrop.Name = "ceMultipleNodesDragAndDrop"
            Me.ceMultipleNodesDragAndDrop.Properties.AutoWidth = True
            Me.ceMultipleNodesDragAndDrop.Properties.Caption = "Multiple nodes drag and drop"
            Me.ceMultipleNodesDragAndDrop.Size = New System.Drawing.Size(161, 19)
            Me.ceMultipleNodesDragAndDrop.TabIndex = 20
            '
            'imageCollection
            '
            Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection.Images.SetKeyName(0, "CSharp_16x16.png")
            Me.imageCollection.Images.SetKeyName(1, "csharp_16x16.png")
            Me.imageCollection.Images.SetKeyName(2, "namespace.png")
            Me.imageCollection.Images.SetKeyName(3, "class.png")
            Me.imageCollection.Images.SetKeyName(4, "interface.png")
            Me.imageCollection.Images.SetKeyName(5, "enum.png")
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 48)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(8)
            Me.panelControl1.Size = New System.Drawing.Size(784, 13)
            Me.panelControl1.TabIndex = 22
            '
            'tl1ClassView
            '
            Me.tl1ClassView.AllowDrop = True
            Me.tl1ClassView.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1})
            Me.tl1ClassView.Dock = System.Windows.Forms.DockStyle.Left
            Me.tl1ClassView.Location = New System.Drawing.Point(0, 61)
            Me.tl1ClassView.Name = "tl1ClassView"
            Me.tl1ClassView.OptionsBehavior.AutoChangeParent = False
            Me.tl1ClassView.OptionsBehavior.CloseEditorOnLostFocus = False
            Me.tl1ClassView.OptionsBehavior.Editable = False
            Me.tl1ClassView.OptionsBehavior.ResizeNodes = False
            Me.tl1ClassView.OptionsBehavior.ShowEditorOnMouseUp = True
            Me.tl1ClassView.OptionsBehavior.SmartMouseHover = False
            Me.tl1ClassView.OptionsDragAndDrop.AcceptOuterNodes = True
            Me.tl1ClassView.OptionsDragAndDrop.CanCloneNodesOnDrop = True
            Me.tl1ClassView.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Multiple
            Me.tl1ClassView.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced
            Me.tl1ClassView.OptionsSelection.MultiSelect = True
            Me.tl1ClassView.OptionsView.EnableAppearanceEvenRow = True
            Me.tl1ClassView.OptionsView.ShowColumns = False
            Me.tl1ClassView.OptionsView.ShowHorzLines = False
            Me.tl1ClassView.OptionsView.ShowIndicator = False
            Me.tl1ClassView.OptionsView.ShowVertLines = False
            Me.tl1ClassView.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryImageComboBox1, Me.repositoryItemDateEdit2})
            Me.tl1ClassView.SelectImageList = Me.imageCollection
            Me.tl1ClassView.Size = New System.Drawing.Size(415, 371)
            Me.tl1ClassView.TabIndex = 24
            '
            'treeListColumn1
            '
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.MinWidth = 49
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 397
            '
            'repositoryItemDateEdit1
            '
            Me.repositoryItemDateEdit1.AllowFocused = False
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            '
            'repositoryImageComboBox1
            '
            Me.repositoryImageComboBox1.AllowFocused = False
            Me.repositoryImageComboBox1.AutoHeight = False
            Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 1, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 2, 1)})
            Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
            '
            'repositoryItemDateEdit2
            '
            Me.repositoryItemDateEdit2.AutoHeight = False
            Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
            '
            'splitterControl1
            '
            Me.splitterControl1.Location = New System.Drawing.Point(415, 61)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(5, 371)
            Me.splitterControl1.TabIndex = 25
            Me.splitterControl1.TabStop = False
            '
            'tl2ClassView
            '
            Me.tl2ClassView.AllowDrop = True
            Me.tl2ClassView.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn2})
            Me.tl2ClassView.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tl2ClassView.Location = New System.Drawing.Point(420, 61)
            Me.tl2ClassView.Name = "tl2ClassView"
            Me.tl2ClassView.OptionsBehavior.AutoChangeParent = False
            Me.tl2ClassView.OptionsBehavior.CloseEditorOnLostFocus = False
            Me.tl2ClassView.OptionsBehavior.Editable = False
            Me.tl2ClassView.OptionsBehavior.ResizeNodes = False
            Me.tl2ClassView.OptionsBehavior.ShowEditorOnMouseUp = True
            Me.tl2ClassView.OptionsBehavior.SmartMouseHover = False
            Me.tl2ClassView.OptionsDragAndDrop.AcceptOuterNodes = True
            Me.tl2ClassView.OptionsDragAndDrop.CanCloneNodesOnDrop = True
            Me.tl2ClassView.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Multiple
            Me.tl2ClassView.OptionsDragAndDrop.DropNodesMode = DevExpress.XtraTreeList.DropNodesMode.Advanced
            Me.tl2ClassView.OptionsSelection.MultiSelect = True
            Me.tl2ClassView.OptionsView.EnableAppearanceEvenRow = True
            Me.tl2ClassView.OptionsView.ShowColumns = False
            Me.tl2ClassView.OptionsView.ShowHorzLines = False
            Me.tl2ClassView.OptionsView.ShowIndicator = False
            Me.tl2ClassView.OptionsView.ShowVertLines = False
            Me.tl2ClassView.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit3, Me.repositoryItemImageComboBox1, Me.repositoryItemDateEdit4})
            Me.tl2ClassView.SelectImageList = Me.imageCollection
            Me.tl2ClassView.Size = New System.Drawing.Size(364, 371)
            Me.tl2ClassView.TabIndex = 26
            '
            'treeListColumn2
            '
            Me.treeListColumn2.Caption = "Name"
            Me.treeListColumn2.FieldName = "Name"
            Me.treeListColumn2.MinWidth = 33
            Me.treeListColumn2.Name = "treeListColumn2"
            Me.treeListColumn2.Visible = True
            Me.treeListColumn2.VisibleIndex = 0
            '
            'repositoryItemDateEdit3
            '
            Me.repositoryItemDateEdit3.AllowFocused = False
            Me.repositoryItemDateEdit3.AutoHeight = False
            Me.repositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3"
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AllowFocused = False
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 1, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 2, 1)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'repositoryItemDateEdit4
            '
            Me.repositoryItemDateEdit4.AutoHeight = False
            Me.repositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4"
            '
            'MultiDragAndDrop
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tl2ClassView)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.tl1ClassView)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.panel)
            Me.Name = "MultiDragAndDrop"
            CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel.ResumeLayout(False)
            Me.panel.PerformLayout()
            CType(Me.ceAcceptOuterNodes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ceMultipleNodesDragAndDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tl1ClassView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tl2ClassView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panel As XtraEditors.PanelControl
        Private WithEvents ceAcceptOuterNodes As XtraEditors.CheckEdit
        Private WithEvents ceMultipleNodesDragAndDrop As XtraEditors.CheckEdit
		Private imageCollection As Utils.ImageCollection
		Private panelControl1 As XtraEditors.PanelControl
		Private tl1ClassView As TreeList
		Private treeListColumn1 As Columns.TreeListColumn
		Private repositoryItemDateEdit1 As XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemDateEdit2 As XtraEditors.Repository.RepositoryItemDateEdit
		Private splitterControl1 As XtraEditors.SplitterControl
		Private tl2ClassView As TreeList
		Private treeListColumn2 As Columns.TreeListColumn
		Private repositoryItemDateEdit3 As XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemDateEdit4 As XtraEditors.Repository.RepositoryItemDateEdit
	End Class
End Namespace
