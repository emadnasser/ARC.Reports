Imports System.Text

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class BusinessObjectBinding
        Inherits TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property

		Private WithEvents treeList1 As TreeList
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private components As System.ComponentModel.IContainer
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

		Public Sub New()
			InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\BusinessObjectBinding.vb;VB\TreeListMainDemo\Modules\BusinessObject.vb"
            TutorialInfo.WhatsThisXMLFile = "BusinessObjectBinding.xml"
			InitEditors()
			InitData()
		End Sub
		Private Sub InitEditors()
			repositoryItemImageComboBox1.Items.AddEnum(GetType(Priority))
			repositoryItemImageComboBox1.Items(0).ImageIndex = 0
			repositoryItemImageComboBox1.Items(1).ImageIndex = 1
			repositoryItemImageComboBox1.Items(2).ImageIndex = 2
		End Sub

		'<treeList1>
		Private Sub InitData()
			Dim projects As New Projects()
			projects.Add(New Project("Project: Betaron", "", New Date(2011, 05, 01), New Date(2011, 09, 20), Priority.Normal, False))
			projects.Add(New Project("Project: Stanton", "", New Date(2011, 03, 04), New Date(2011, 05, 01), Priority.Normal, False))
			projects(0).Projects.Add(New Project("Planning", "", New Date(2011, 05, 12), New Date(2011, 06, 15), Priority.Normal, False))
			projects(0).Projects.Add(New Project("Design", "", New Date(2011, 07, 16), New Date(2011, 09, 20), Priority.Normal, False))
			projects(0).Projects.Add(New Project("Development", "", New Date(2011, 07, 16), New Date(2011, 08, 20), Priority.Normal, False))
			projects(0).Projects.Add(New Project("Testing and Delivery", "", New Date(2011, 08, 12), New Date(2011, 10, 17), Priority.Normal, False))
			projects(0).Projects(0).Projects.Add(New Project("Market research", "", New Date(2011, 05, 01), New Date(2011, 05, 13), Priority.Normal, True))
			projects(0).Projects(0).Projects.Add(New Project("Making specification", "", New Date(2011, 05, 14), New Date(2011, 06, 04), Priority.Low, True))
			projects(0).Projects(0).Projects.Add(New Project("Documentation", "", New Date(2011, 06, 05), New Date(2011, 06, 15), Priority.Normal, True))
			projects(0).Projects(1).Projects.Add(New Project("Design of a web pages", "", New Date(2011, 07, 16), New Date(2011, 07, 28), Priority.Low, True))
			projects(0).Projects(1).Projects.Add(New Project("Pages layout", "", New Date(2011, 08, 01), New Date(2011, 09, 20), Priority.Normal, True))
			projects(0).Projects(2).Projects.Add(New Project("Design", "", New Date(2011, 07, 16), New Date(2011, 07, 28), Priority.Low, True))
			projects(0).Projects(2).Projects.Add(New Project("Coding", "", New Date(2011, 08, 01), New Date(2011, 09, 20), Priority.Normal, True))
			projects(0).Projects(3).Projects.Add(New Project("Testing", "", New Date(2011, 08, 12), New Date(2011, 08, 28), Priority.Low, True))
			projects(0).Projects(3).Projects.Add(New Project("Content", "", New Date(2011, 09, 1), New Date(2011, 09, 24), Priority.Normal, True))

			projects(1).Projects.Add(New Project("Planning", "", New Date(2012, 03, 01), New Date(2012, 04, 15), Priority.Normal, True))
			projects(1).Projects.Add(New Project("Design", "", New Date(2012, 04, 12), New Date(2012, 05, 12), Priority.Low, True))
			projects(1).Projects.Add(New Project("Development", "", New Date(2012, 05, 16), New Date(2012, 05, 23), Priority.Low, True))
			projects(1).Projects.Add(New Project("Testing and Delivery", "", New Date(2012, 06, 16), New Date(2012, 06, 25), Priority.Low, True))
			projects(1).Projects(0).Projects.Add(New Project("Market research", "", New Date(2012, 05, 01), New Date(2012, 05, 13), Priority.Normal, True))
			projects(1).Projects(0).Projects.Add(New Project("Making specification", "", New Date(2012, 05, 14), New Date(2012, 06, 04), Priority.Low, True))
			projects(1).Projects(0).Projects.Add(New Project("Documentation", "", New Date(2012, 06, 05), New Date(2012, 06, 15), Priority.Normal, True))
			projects(1).Projects(1).Projects.Add(New Project("Design of a web pages", "", New Date(2012, 07, 16), New Date(2012, 07, 28), Priority.Low, True))
			projects(1).Projects(1).Projects.Add(New Project("Pages layout", "", New Date(2012, 08, 01), New Date(2012, 09, 20), Priority.Normal, True))
			projects(1).Projects(2).Projects.Add(New Project("Design", "", New Date(2012, 07, 16), New Date(2012, 07, 28), Priority.Low, True))
			projects(1).Projects(2).Projects.Add(New Project("Coding", "", New Date(2012, 08, 01), New Date(2012, 09, 20), Priority.Normal, True))
			projects(1).Projects(3).Projects.Add(New Project("Testing", "", New Date(2012, 08, 12), New Date(2012, 08, 28), Priority.Low, True))
			projects(1).Projects(3).Projects.Add(New Project("Content", "", New Date(2012, 09, 1), New Date(2012, 09, 24), Priority.Normal, True))

			treeList1.DataSource = projects
		End Sub
		'</treeList1>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BusinessObjectBinding))
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.treeList1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.propertyGridControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(792, 406)
			Me.splitContainerControl1.SplitterPosition = 560
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryItemDateEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemProgressBar1})
			Me.treeList1.Size = New System.Drawing.Size(560, 406)
			Me.treeList1.StateImageList = Me.imageCollection1
			Me.treeList1.TabIndex = 0
'			Me.treeList1.GetStateImage += New DevExpress.XtraTreeList.GetStateImageEventHandler(Me.treeList1_GetStateImage)
'			Me.treeList1.AfterExpand += New DevExpress.XtraTreeList.NodeEventHandler(Me.treeList1_AfterExpand)
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged)
'			Me.treeList1.CellValueChanged += New DevExpress.XtraTreeList.CellValueChangedEventHandler(Me.treeList1_CellValueChanged)
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.MinWidth = 33
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "StartDate"
			Me.treeListColumn3.ColumnEdit = Me.repositoryItemDateEdit1
			Me.treeListColumn3.FieldName = "StartDate"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.Visible = True
			Me.treeListColumn3.VisibleIndex = 1
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' treeListColumn4
			' 
			Me.treeListColumn4.Caption = "EndDate"
			Me.treeListColumn4.ColumnEdit = Me.repositoryItemDateEdit2
			Me.treeListColumn4.FieldName = "EndDate"
			Me.treeListColumn4.Name = "treeListColumn4"
			Me.treeListColumn4.Visible = True
			Me.treeListColumn4.VisibleIndex = 2
			' 
			' repositoryItemDateEdit2
			' 
			Me.repositoryItemDateEdit2.AutoHeight = False
			Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
			Me.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' treeListColumn5
			' 
			Me.treeListColumn5.Caption = "Priority"
			Me.treeListColumn5.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.treeListColumn5.FieldName = "Priority"
			Me.treeListColumn5.Name = "treeListColumn5"
			Me.treeListColumn5.Visible = True
			Me.treeListColumn5.VisibleIndex = 3
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AllowFocused = False
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection2
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "Normal1.png")
			Me.imageCollection2.Images.SetKeyName(1, "Low1.png")
			Me.imageCollection2.Images.SetKeyName(2, "High1.png")
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Object_Project.png")
			Me.imageCollection1.Images.SetKeyName(1, "Object_Task.png")
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Date), Me.repositoryItemDateEdit3)})
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.OptionsBehavior.PropertySort = DevExpress.XtraVerticalGrid.PropertySort.NoSort
			Me.propertyGridControl1.OptionsView.ShowRootCategories = False
			Me.propertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1, Me.repositoryItemDateEdit3})
			Me.propertyGridControl1.Size = New System.Drawing.Size(227, 406)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Caption = "Check"
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemDateEdit3
			' 
			Me.repositoryItemDateEdit3.AutoHeight = False
			Me.repositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3"
			Me.repositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' BusinessObjectBinding
			' 
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "BusinessObjectBinding"
			Me.Size = New System.Drawing.Size(792, 406)
'			Me.Load += New System.EventHandler(Me.businessObjectBinding_Load)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit3.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		'<propertyGridControl1>
		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
			propertyGridControl1.SelectedObject = treeList1.GetDataRecordByNode(e.Node)
		End Sub
		'</propertyGridControl1>
		Private Sub businessObjectBinding_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			treeList1.ForceInitialize()
			treeList1.ExpandAll()
			treeList1.FocusedNode = treeList1.Nodes.FirstNode
			treeList1.BestFitColumns()
		End Sub
		Private Sub treeList1_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles treeList1.CellValueChanged
			propertyGridControl1.Refresh()
		End Sub
		Private Sub treeList1_AfterExpand(ByVal sender As Object, ByVal e As NodeEventArgs) Handles treeList1.AfterExpand
			treeList1.BestFitColumns()
		End Sub
		Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As GetStateImageEventArgs) Handles treeList1.GetStateImage
			Dim project As Project = CType(treeList1.GetDataRecordByNode(e.Node), Project)
			If project Is Nothing Then
				Return
			End If
			e.NodeImageIndex = If(project.IsTask, 1, 0)
		End Sub
	End Class
End Namespace
