Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class Formats
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Formats))
			Me.tabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.tcProperties = New DevExpress.XtraTab.XtraTabControl()
			Me.tabPage6 = New DevExpress.XtraTab.XtraTabPage()
			Me.lsStyles = New DevExpress.XtraEditors.ListBoxControl()
			Me.ceNewStyles = New DevExpress.XtraEditors.CheckEdit()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tabPage10 = New DevExpress.XtraTab.XtraTabPage()
			Me.propertyGrid1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
			Me.splitter4 = New DevExpress.XtraEditors.SplitterControl()
			Me.lbcAppearances = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLeft.SuspendLayout()
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tcProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tcProperties.SuspendLayout()
			Me.tabPage6.SuspendLayout()
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceNewStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPage10.SuspendLayout()
			CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' pnlLeft
			' 
			Me.pnlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pnlLeft.Controls.Add(Me.tcProperties)
			Me.pnlLeft.Controls.SetChildIndex(Me.tcProperties, 0)
			' 
			' tabPage5
			' 
			Me.tabPage5.Name = "tabPage5"
			Me.tabPage5.Size = New System.Drawing.Size(589, 458)
			Me.tabPage5.Text = "Simple Mode"
			' 
			' tcProperties
			' 
			Me.tcProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.tcProperties.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tcProperties.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
			Me.tcProperties.Location = New System.Drawing.Point(0, 0)
			Me.tcProperties.Name = "tcProperties"
			Me.tcProperties.SelectedTabPage = Me.tabPage6
			Me.tcProperties.Size = New System.Drawing.Size(204, 400)
			Me.tcProperties.TabIndex = 3
			Me.tcProperties.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabPage6, Me.tabPage10})
			' 
			' tabPage6
			' 
			Me.tabPage6.Controls.Add(Me.lsStyles)
			Me.tabPage6.Controls.Add(Me.ceNewStyles)
			Me.tabPage6.Controls.Add(Me.label1)
			Me.tabPage6.Name = "tabPage6"
			Me.tabPage6.Padding = New System.Windows.Forms.Padding(4)
			Me.tabPage6.Size = New System.Drawing.Size(173, 391)
			Me.tabPage6.Text = "Formats"
			' 
			' lsStyles
			' 
			Me.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lsStyles.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.lsStyles.ItemHeight = 15
			Me.lsStyles.Location = New System.Drawing.Point(4, 43)
			Me.lsStyles.Name = "lsStyles"
			Me.lsStyles.Size = New System.Drawing.Size(165, 344)
			Me.lsStyles.TabIndex = 10
'			Me.lsStyles.SelectedIndexChanged += New System.EventHandler(Me.lsStyles_SelectedIndexChanged)
			' 
			' ceNewStyles
			' 
			Me.ceNewStyles.Dock = System.Windows.Forms.DockStyle.Top
			Me.ceNewStyles.Location = New System.Drawing.Point(4, 24)
			Me.ceNewStyles.Name = "ceNewStyles"
			Me.ceNewStyles.Properties.Caption = "Only New Styles"
			Me.ceNewStyles.Size = New System.Drawing.Size(165, 19)
			Me.ceNewStyles.TabIndex = 26
'			Me.ceNewStyles.CheckedChanged += New System.EventHandler(Me.ceNewStyles_CheckedChanged)
			' 
			' label1
			' 
			Me.label1.Dock = System.Windows.Forms.DockStyle.Top
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.label1.Location = New System.Drawing.Point(4, 4)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(165, 20)
			Me.label1.TabIndex = 11
			Me.label1.Text = "Style Formats:"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' tabPage10
			' 
			Me.tabPage10.Controls.Add(Me.propertyGrid1)
			Me.tabPage10.Controls.Add(Me.splitter4)
			Me.tabPage10.Controls.Add(Me.lbcAppearances)
			Me.tabPage10.Name = "tabPage10"
			Me.tabPage10.Padding = New System.Windows.Forms.Padding(4)
			Me.tabPage10.Size = New System.Drawing.Size(169, 387)
			Me.tabPage10.Text = "Appearances"
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(System.Drawing.Color), Me.repositoryItemColorEdit1)})
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.Location = New System.Drawing.Point(4, 186)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.OptionsView.ShowRootCategories = False
			Me.propertyGrid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemColorEdit1})
			Me.propertyGrid1.ServiceProvider = Nothing
			Me.propertyGrid1.Size = New System.Drawing.Size(161, 197)
			Me.propertyGrid1.TabIndex = 28
			' 
			' repositoryItemColorEdit1
			' 
			Me.repositoryItemColorEdit1.AutoHeight = False
			Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
			' 
			' splitter4
			' 
			Me.splitter4.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter4.Location = New System.Drawing.Point(4, 180)
			Me.splitter4.Name = "splitter4"
			Me.splitter4.Size = New System.Drawing.Size(161, 6)
			Me.splitter4.TabIndex = 29
			Me.splitter4.TabStop = False
			' 
			' lbcAppearances
			' 
			Me.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Top
			Me.lbcAppearances.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
			Me.lbcAppearances.ItemHeight = 16
			Me.lbcAppearances.Location = New System.Drawing.Point(4, 4)
			Me.lbcAppearances.Name = "lbcAppearances"
			Me.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			Me.lbcAppearances.Size = New System.Drawing.Size(161, 176)
			Me.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending
			Me.lbcAppearances.TabIndex = 27
'			Me.lbcAppearances.SelectedIndexChanged += New System.EventHandler(Me.lbcAppearances_SelectedIndexChanged)
			' 
			' Formats
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Formats"
			Me.Size = New System.Drawing.Size(803, 488)
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLeft.ResumeLayout(False)
			CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tcProperties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tcProperties.ResumeLayout(False)
			Me.tabPage6.ResumeLayout(False)
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceNewStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPage10.ResumeLayout(False)
			CType(Me.propertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private tcProperties As DevExpress.XtraTab.XtraTabControl
		Private tabPage6 As DevExpress.XtraTab.XtraTabPage
		Private WithEvents lsStyles As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents ceNewStyles As DevExpress.XtraEditors.CheckEdit
		Private label1 As System.Windows.Forms.Label
		Private tabPage10 As DevExpress.XtraTab.XtraTabPage
		Private propertyGrid1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private splitter4 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents lbcAppearances As DevExpress.XtraEditors.ListBoxControl
		Private tabPage5 As DevExpress.XtraTab.XtraTabPage
		Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
