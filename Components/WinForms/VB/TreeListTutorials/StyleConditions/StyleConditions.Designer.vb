Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class StyleConditions
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StyleConditions))
			Dim styleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
			Dim styleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
			Dim styleFormatCondition3 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition()
			Me.tlcDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.tlcPriority = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.tlcRejected = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.checkBox1 = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.treeList2 = New DevExpress.XtraTreeList.TreeList()
			Me.tlcName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel2.SuspendLayout()
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.treeList2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tlcDate
			' 
			Me.tlcDate.Caption = "Start Date"
			Me.tlcDate.ColumnEdit = Me.repositoryItemDateEdit2
			Me.tlcDate.FieldName = "StartDate"
			Me.tlcDate.Format.FormatString = "d"
			Me.tlcDate.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.tlcDate.Name = "tlcDate"
			Me.tlcDate.Visible = True
			Me.tlcDate.VisibleIndex = 1
			Me.tlcDate.Width = 121
			' 
			' repositoryItemDateEdit2
			' 
			Me.repositoryItemDateEdit2.AllowFocused = False
			Me.repositoryItemDateEdit2.AutoHeight = False
			Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
			Me.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' tlcPriority
			' 
			Me.tlcPriority.Caption = "Priority"
			Me.tlcPriority.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.tlcPriority.FieldName = "Priority"
			Me.tlcPriority.Name = "tlcPriority"
			Me.tlcPriority.Visible = True
			Me.tlcPriority.VisibleIndex = 2
			Me.tlcPriority.Width = 118
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AllowFocused = False
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 1, 1)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' tlcRejected
			' 
			Me.tlcRejected.Caption = "Rejected"
			Me.tlcRejected.ColumnEdit = Me.repositoryItemCheckEdit2
			Me.tlcRejected.FieldName = "Rejected"
			Me.tlcRejected.Name = "tlcRejected"
			Me.tlcRejected.Visible = True
			Me.tlcRejected.VisibleIndex = 3
			Me.tlcRejected.Width = 60
			' 
			' repositoryItemCheckEdit2
			' 
			Me.repositoryItemCheckEdit2.AllowFocused = False
			Me.repositoryItemCheckEdit2.AutoHeight = False
			Me.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2"
			' 
			' repositoryImageComboBox1
			' 
			Me.repositoryImageComboBox1.AllowFocused = False
			Me.repositoryImageComboBox1.AutoHeight = False
			Me.repositoryImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Normal", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 1, 1)})
			Me.repositoryImageComboBox1.Name = "repositoryImageComboBox1"
			Me.repositoryImageComboBox1.SmallImages = Me.imageList2
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(2, 39)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "Project A", New System.DateTime(2003, 5, 28, 0, 0, 0), 2, True}, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 1", New System.DateTime(2003, 5, 30, 0, 0, 0), 0, True}, 0, 1, 1, -1)
			Me.treeList1.AppendNode(New Object() { "This task is mine A", New System.DateTime(2003, 6, 12, 0, 0, 0), 0, False}, 1, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "This task is not mine A", New System.DateTime(2003, 6, 19, 0, 0, 0), 1, True}, 1, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "Project B", New System.DateTime(2003, 6, 20, 0, 0, 0), 0, False}, -1)
			Me.treeList1.AppendNode(New Object() { "This task is mine B", New System.DateTime(2003, 7, 24, 0, 0, 0), 2, False}, 4, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "This task is not mine B", New System.DateTime(2003, 6, 29, 0, 0, 0), 1, False}, 4, 2, 2, -1)
			Me.treeList1.AppendNode(New Object() { "Project C", New System.DateTime(2003, 6, 12, 0, 0, 0), 2, True}, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 2", New System.DateTime(2003, 6, 26, 0, 0, 0), 0, True}, 7, 1, 1, -1)
			Me.treeList1.AppendNode(New Object() { "Deliverable 3", New System.DateTime(2003, 6, 19, 0, 0, 0), 1, False}, 7, 1, 1, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryImageComboBox1, Me.repositoryItemCheckEdit1})
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(562, 267)
			Me.treeList1.TabIndex = 8
'			Me.treeList1.NodeCellStyle += New DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(Me.treeList1_NodeCellStyle);
'			Me.treeList1.CustomDrawNodeCell += New DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(Me.treeList1_CustomDrawNodeCell);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 81
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			Me.treeListColumn1.Width = 221
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Start Date"
			Me.treeListColumn2.ColumnEdit = Me.repositoryItemDateEdit1
			Me.treeListColumn2.FieldName = "StartDate"
			Me.treeListColumn2.Format.FormatString = "d"
			Me.treeListColumn2.Format.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			Me.treeListColumn2.Width = 121
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Priority"
			Me.treeListColumn3.ColumnEdit = Me.repositoryImageComboBox1
			Me.treeListColumn3.FieldName = "Priority"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 2
			Me.treeListColumn3.Width = 118
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.Caption = "Rejected"
			Me.treeListColumn4.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.treeListColumn4.FieldName = "Rejected"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.Visible = True
			Me.treeListColumn4.VisibleIndex = 3
			Me.treeListColumn4.Width = 60
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.checkBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(2, 2)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(562, 37)
			Me.panel2.TabIndex = 9
			' 
			' checkBox1
			' 
			Me.checkBox1.Location = New System.Drawing.Point(9, 10)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Properties.Caption = "Use custom style for the ""Name"" column only"
			Me.checkBox1.Size = New System.Drawing.Size(284, 18)
			Me.checkBox1.TabIndex = 0
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(575, 338)
			Me.xtraTabControl1.TabIndex = 10
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.treeList2)
			Me.xtraTabPage1.Controls.Add(Me.panel3)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(2)
			Me.xtraTabPage1.Size = New System.Drawing.Size(566, 308)
			Me.xtraTabPage1.Text = "Style Conditions"
			' 
			' treeList2
			' 
			Me.treeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.tlcName, Me.tlcDate, Me.tlcPriority, Me.tlcRejected})
			Me.treeList2.Dock = System.Windows.Forms.DockStyle.Fill
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))))
			styleFormatCondition1.Appearance.Options.UseBackColor = True
			styleFormatCondition1.Column = Me.tlcDate
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
			styleFormatCondition1.Value1 = New System.DateTime(2003, 6, 10, 10, 2, 10, 0)
			styleFormatCondition1.Value2 = New System.DateTime(2003, 6, 19, 10, 2, 35, 0)
			styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
			styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
			styleFormatCondition2.Appearance.Options.UseBackColor = True
			styleFormatCondition2.Appearance.Options.UseForeColor = True
			styleFormatCondition2.Column = Me.tlcPriority
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition2.Value1 = 2
			styleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout)
			styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Gray
			styleFormatCondition3.Appearance.Options.UseFont = True
			styleFormatCondition3.Appearance.Options.UseForeColor = True
			styleFormatCondition3.ApplyToRow = True
			styleFormatCondition3.Column = Me.tlcRejected
			styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
			styleFormatCondition3.Value1 = True
			Me.treeList2.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() { styleFormatCondition1, styleFormatCondition2, styleFormatCondition3})
			Me.treeList2.Location = New System.Drawing.Point(2, 39)
			Me.treeList2.Name = "treeList2"
			Me.treeList2.BeginUnboundLoad()
			Me.treeList2.AppendNode(New Object() { "Project A", New System.DateTime(2003, 5, 28, 0, 0, 0), 2, True}, -1)
			Me.treeList2.AppendNode(New Object() { "Deliverable 1", New System.DateTime(2003, 5, 30, 0, 0, 0), 0, True}, 0, 1, 1, -1)
			Me.treeList2.AppendNode(New Object() { "This task is mine A", New System.DateTime(2003, 6, 12, 0, 0, 0), 0, False}, 1, 2, 2, -1)
			Me.treeList2.AppendNode(New Object() { "This task is not mine A", New System.DateTime(2003, 6, 19, 0, 0, 0), 1, True}, 1, 2, 2, -1)
			Me.treeList2.AppendNode(New Object() { "Project B", New System.DateTime(2003, 6, 20, 0, 0, 0), 0, False}, -1)
			Me.treeList2.AppendNode(New Object() { "This task is mine B", New System.DateTime(2003, 7, 24, 0, 0, 0), 2, False}, 4, 2, 2, -1)
			Me.treeList2.AppendNode(New Object() { "This task is not mine B", New System.DateTime(2003, 6, 29, 0, 0, 0), 1, False}, 4, 2, 2, -1)
			Me.treeList2.AppendNode(New Object() { "Project C", New System.DateTime(2003, 6, 12, 0, 0, 0), 2, False}, -1)
			Me.treeList2.AppendNode(New Object() { "Deliverable 2", New System.DateTime(2003, 6, 26, 0, 0, 0), 0, True}, 7, 1, 1, -1)
			Me.treeList2.AppendNode(New Object() { "Deliverable 3", New System.DateTime(2003, 6, 19, 0, 0, 0), 1, False}, 7, 1, 1, -1)
			Me.treeList2.EndUnboundLoad()
			Me.treeList2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemCheckEdit2})
			Me.treeList2.SelectImageList = Me.imageList1
			Me.treeList2.Size = New System.Drawing.Size(562, 267)
			Me.treeList2.TabIndex = 11
			' 
			' tlcName
			' 
			Me.tlcName.Caption = "Name"
			Me.tlcName.FieldName = "Name"
			Me.tlcName.MinWidth = 81
			Me.tlcName.Name = "tlcName"
			Me.tlcName.Visible = True
			Me.tlcName.VisibleIndex = 0
			Me.tlcName.Width = 221
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.simpleButton1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel3.Location = New System.Drawing.Point(2, 2)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(562, 37)
			Me.panel3.TabIndex = 10
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(8, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(156, 22)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "Show style conditions"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.treeList1)
			Me.xtraTabPage2.Controls.Add(Me.panel2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(2)
			Me.xtraTabPage2.Size = New System.Drawing.Size(566, 308)
			Me.xtraTabPage2.Text = "Custom Draw"
			' 
			' StyleConditions
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "StyleConditions"
			Me.Size = New System.Drawing.Size(575, 338)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel2.ResumeLayout(False)
			CType(Me.checkBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.treeList2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private repositoryImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList2 As System.Windows.Forms.ImageList
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents checkBox1 As DevExpress.XtraEditors.CheckEdit
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private panel3 As System.Windows.Forms.Panel
		Private treeList2 As DevExpress.XtraTreeList.TreeList
		Private repositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private tlcName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private tlcDate As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private tlcPriority As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private tlcRejected As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
