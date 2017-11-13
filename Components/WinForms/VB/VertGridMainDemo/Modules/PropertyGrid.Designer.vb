Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class PropertyGrid
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PropertyGrid))
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.pcControls = New DevExpress.XtraEditors.PanelControl()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.icbControls = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.splitterControl2 = New DevExpress.XtraEditors.SplitterControl()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.chPropertyDescription = New DevExpress.XtraEditors.CheckEdit()
            Me.chDefaultEditors = New DevExpress.XtraEditors.CheckEdit()
			Me.chRootCategories = New DevExpress.XtraEditors.CheckEdit()
			Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.pcControls, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcControls.SuspendLayout()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbControls.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
            CType(Me.chPropertyDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chDefaultEditors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chRootCategories.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.pcControls)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.icbControls)
			Me.splitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(8)
			Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGridControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.splitterControl2)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.splitterControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.panelControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyDescriptionControl1)
			Me.splitContainerControl1.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
			Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(712, 392)
			Me.splitContainerControl1.SplitterPosition = 163
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' pcControls
			' 
			Me.pcControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcControls.Controls.Add(Me.pictureEdit1)
			Me.pcControls.Controls.Add(Me.progressBarControl1)
			Me.pcControls.Controls.Add(Me.trackBarControl1)
			Me.pcControls.Controls.Add(Me.simpleButton1)
			Me.pcControls.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pcControls.Location = New System.Drawing.Point(8, 28)
			Me.pcControls.Name = "pcControls"
			Me.pcControls.Size = New System.Drawing.Size(147, 356)
			Me.pcControls.TabIndex = 1
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.EditValue = (CObj(resources.GetObject("pictureEdit1.EditValue")))
			Me.pictureEdit1.Location = New System.Drawing.Point(16, 240)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Size = New System.Drawing.Size(112, 96)
			Me.pictureEdit1.TabIndex = 3
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.EditValue = 50
			Me.progressBarControl1.Location = New System.Drawing.Point(24, 184)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(104, 18)
			Me.progressBarControl1.TabIndex = 2
			' 
			' trackBarControl1
			' 
			Me.trackBarControl1.EditValue = Nothing
			Me.trackBarControl1.Location = New System.Drawing.Point(16, 112)
			Me.trackBarControl1.Name = "trackBarControl1"
			Me.trackBarControl1.Size = New System.Drawing.Size(112, 45)
			Me.trackBarControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(16, 40)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(112, 40)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' icbControls
			' 
			Me.icbControls.Dock = System.Windows.Forms.DockStyle.Top
			Me.icbControls.Location = New System.Drawing.Point(8, 8)
			Me.icbControls.Name = "icbControls"
			Me.icbControls.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.icbControls.Size = New System.Drawing.Size(147, 20)
			Me.icbControls.TabIndex = 0
'			Me.icbControls.SelectedIndexChanged += New System.EventHandler(Me.icbControls_SelectedIndexChanged)
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(System.Drawing.Color), Me.repositoryItemColorEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(System.Drawing.Image), Me.repositoryItemPictureEdit1)})
            Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGridControl1.FindPanelVisible = True
            Me.propertyGridControl1.Location = New System.Drawing.Point(8, 88)
			Me.propertyGridControl1.OptionsView.MaxRowAutoHeight = 100
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.OptionsBehavior.ResizeRowHeaders = False
			Me.propertyGridControl1.OptionsMenu.EnableContextMenu = True
			Me.propertyGridControl1.OptionsView.MinRowAutoHeight = 19
			Me.propertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemColorEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemPictureEdit1})
			Me.propertyGridControl1.Size = New System.Drawing.Size(527, 227)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' repositoryItemColorEdit1
			' 
			Me.repositoryItemColorEdit1.AutoHeight = False
			Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
			Me.repositoryItemColorEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			' 
			' splitterControl2
			' 
			Me.splitterControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.splitterControl2.Location = New System.Drawing.Point(8, 315)
			Me.splitterControl2.Name = "splitterControl2"
			Me.splitterControl2.Size = New System.Drawing.Size(527, 6)
			Me.splitterControl2.TabIndex = 4
			Me.splitterControl2.TabStop = False
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(8, 82)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(527, 6)
			Me.splitterControl1.TabIndex = 2
			Me.splitterControl1.TabStop = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.chPropertyDescription)
            Me.panelControl1.Controls.Add(Me.chDefaultEditors)
			Me.panelControl1.Controls.Add(Me.chRootCategories)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(8, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(527, 82)
			Me.panelControl1.TabIndex = 1
            ' 
            ' chPropertyDescription
            ' 
            Me.chPropertyDescription.Location = New System.Drawing.Point(8, 55)
            Me.chPropertyDescription.Name = "chPropertyDescription"
            Me.chPropertyDescription.Properties.Caption = "Show Property Description"
            Me.chPropertyDescription.Size = New System.Drawing.Size(192, 19)
            Me.chPropertyDescription.TabIndex = 2
            '			Me.chPropertyDescription.CheckedChanged += New System.EventHandler(Me.chPropertyDescription_CheckedChanged)
            ' 
            ' chDefaultEditors
            ' 
            Me.chDefaultEditors.Location = New System.Drawing.Point(8, 31)
			Me.chDefaultEditors.Name = "chDefaultEditors"
			Me.chDefaultEditors.Properties.Caption = "Use Default Editors Collection"
			Me.chDefaultEditors.Size = New System.Drawing.Size(192, 19)
			Me.chDefaultEditors.TabIndex = 1
'			Me.chDefaultEditors.CheckedChanged += New System.EventHandler(Me.chDefaultEditors_CheckedChanged)
			' 
			' chRootCategories
			' 
			Me.chRootCategories.Location = New System.Drawing.Point(8, 7)
			Me.chRootCategories.Name = "chRootCategories"
			Me.chRootCategories.Properties.Caption = "Show Root Categories"
			Me.chRootCategories.Size = New System.Drawing.Size(192, 19)
			Me.chRootCategories.TabIndex = 0
'			Me.chRootCategories.CheckedChanged += New System.EventHandler(Me.chRootCategories_CheckedChanged)
			' 
			' propertyDescriptionControl1
			' 
			Me.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.propertyDescriptionControl1.Location = New System.Drawing.Point(8, 321)
			Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
			Me.propertyDescriptionControl1.Size = New System.Drawing.Size(527, 71)
			Me.propertyDescriptionControl1.TabIndex = 3
			Me.propertyDescriptionControl1.TabStop = False
			' 
			' PropertyGrid
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "PropertyGrid"
			Me.Size = New System.Drawing.Size(712, 392)
'			Me.Load += New System.EventHandler(Me.PropertyGrid_Load)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.pcControls, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcControls.ResumeLayout(False)
			Me.pcControls.PerformLayout()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbControls.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
            CType(Me.chPropertyDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chDefaultEditors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chRootCategories.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private WithEvents icbControls As DevExpress.XtraEditors.ImageComboBoxEdit
		Private pcControls As DevExpress.XtraEditors.PanelControl
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents chRootCategories As DevExpress.XtraEditors.CheckEdit
		Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private WithEvents chDefaultEditors As DevExpress.XtraEditors.CheckEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private components As System.ComponentModel.IContainer = Nothing
		Private propertyDescriptionControl1 As PropertyDescriptionControl
        Private WithEvents chPropertyDescription As DevExpress.XtraEditors.CheckEdit
        Private splitterControl2 As DevExpress.XtraEditors.SplitterControl

	End Class
End Namespace
