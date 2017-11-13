Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class GridModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(GridModule))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.nbgEmployees = New DevExpress.XtraNavBar.NavBarGroup()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colComplete = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIcon = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.icEditors = New DevExpress.Utils.ImageCollection(Me.components)
			Me.colPriority = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.colPercent = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.colCreated = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.icCategory = New DevExpress.Utils.ImageCollection(Me.components)
			Me.colFlagStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.colOverdue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ilColumns = New System.Windows.Forms.ImageList(Me.components)
			Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icEditors, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
            Me.layoutControl1.AllowCustomization = False
			Me.layoutControl1.Controls.Add(Me.navBarControl1)
			Me.layoutControl1.Controls.Add(Me.gridControl1)
			resources.ApplyResources(Me.layoutControl1, "layoutControl1")
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(842, -11, 630, 697)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.nbgEmployees
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.nbgEmployees})
			resources.ApplyResources(Me.navBarControl1, "navBarControl1")
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.NavigationPaneGroupClientHeight = 320
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = (CInt(Fix(resources.GetObject("resource.ExpandedWidth"))))
			Me.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = True
			Me.navBarControl1.OptionsNavPane.ShowOverflowPanel = False
			Me.navBarControl1.OptionsNavPane.ShowSplitter = False
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
			' 
			' nbgEmployees
			' 
			resources.ApplyResources(Me.nbgEmployees, "nbgEmployees")
			Me.nbgEmployees.Expanded = True
			Me.nbgEmployees.LargeImage = My.Resources.Contact_32x32
			Me.nbgEmployees.Name = "nbgEmployees"
			Me.nbgEmployees.NavigationPaneVisible = False
			Me.nbgEmployees.SmallImage = My.Resources.Contact_16x16
			' 
			' gridControl1
			' 
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemProgressBar1, Me.repositoryItemImageComboBox4, Me.repositoryItemTrackBar1, Me.repositoryItemImageComboBox5})
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colComplete, Me.colIcon, Me.colPriority, Me.colSubject, Me.colStatus, Me.colPercent, Me.colCreated, Me.colStartDate, Me.colDueDate, Me.colCompleted, Me.colCategory, Me.colFlagStatus, Me.colOverdue})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView1.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView1.GroupSummary1"), (CType(resources.GetObject("gridView1.GroupSummary2"), DevExpress.XtraGrid.Columns.GridColumn)), resources.GetString("gridView1.GroupSummary3"))})
			Me.gridView1.Images = Me.ilColumns
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True
			Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
			Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
			Me.gridView1.OptionsFind.AlwaysVisible = True
			Me.gridView1.OptionsFind.FindFilterColumns = "Subject"
			Me.gridView1.OptionsPrint.PrintHorzLines = False
			Me.gridView1.OptionsPrint.PrintVertLines = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
'			Me.gridView1.RowCellClick += New DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(Me.gridView1_RowCellClick)
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell)
'			Me.gridView1.CustomRowCellEditForEditing += New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(Me.gridView1_CustomRowCellEditForEditing)
'			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged)
'			Me.gridView1.CellValueChanging += New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(Me.gridView1_CellValueChanging)
'			Me.gridView1.ColumnFilterChanged += New System.EventHandler(Me.gridView1_ColumnFilterChanged)
'			Me.gridView1.CustomColumnDisplayText += New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(Me.gridView1_CustomColumnDisplayText)
'			Me.gridView1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridView1_KeyDown)
			' 
			' colComplete
			' 
			Me.colComplete.FieldName = "Complete"
			resources.ApplyResources(Me.colComplete, "colComplete")
			Me.colComplete.Name = "colComplete"
			Me.colComplete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colComplete.OptionsColumn.AllowSize = False
			Me.colComplete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colComplete.OptionsColumn.FixedWidth = True
			Me.colComplete.OptionsColumn.ShowCaption = False
			Me.colComplete.OptionsFilter.AllowFilter = False
			' 
			' colIcon
			' 
			Me.colIcon.ColumnEdit = Me.repositoryItemImageComboBox2
			Me.colIcon.FieldName = "Icon"
			resources.ApplyResources(Me.colIcon, "colIcon")
			Me.colIcon.Name = "colIcon"
			Me.colIcon.OptionsColumn.AllowEdit = False
			Me.colIcon.OptionsColumn.AllowFocus = False
			Me.colIcon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colIcon.OptionsColumn.AllowSize = False
			Me.colIcon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colIcon.OptionsColumn.FixedWidth = True
			Me.colIcon.OptionsColumn.ShowCaption = False
			Me.colIcon.OptionsFilter.AllowFilter = False
			' 
			' repositoryItemImageComboBox2
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox2, "repositoryItemImageComboBox2")
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), (CObj(resources.GetObject("repositoryItemImageComboBox2.Items1"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox2.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), (CObj(resources.GetObject("repositoryItemImageComboBox2.Items4"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox2.Items5")))))})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			Me.repositoryItemImageComboBox2.SmallImages = Me.icEditors
			' 
			' icEditors
			' 
			Me.icEditors.ImageStream = (CType(resources.GetObject("icEditors.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.icEditors.Images.SetKeyName(0, "Low16x16.png")
			Me.icEditors.Images.SetKeyName(1, "High16x16.png")
			Me.icEditors.Images.SetKeyName(2, "Task_16x16.png")
			Me.icEditors.Images.SetKeyName(3, "Report_16x16.png")
			' 
			' colPriority
			' 
			Me.colPriority.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.colPriority.FieldName = "Priority"
			resources.ApplyResources(Me.colPriority, "colPriority")
			Me.colPriority.Name = "colPriority"
			Me.colPriority.OptionsColumn.AllowSize = False
			Me.colPriority.OptionsColumn.FixedWidth = True
			Me.colPriority.OptionsColumn.ShowCaption = False
			Me.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			' 
			' repositoryItemImageComboBox1
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items1"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items4"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj(resources.GetObject("repositoryItemImageComboBox1.Items7"))), (CInt(Fix(resources.GetObject("repositoryItemImageComboBox1.Items8")))))})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.icEditors
			' 
			' colSubject
			' 
			resources.ApplyResources(Me.colSubject, "colSubject")
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.OptionsColumn.AllowEdit = False
			Me.colSubject.OptionsColumn.AllowFocus = False
			' 
			' colStatus
			' 
			resources.ApplyResources(Me.colStatus, "colStatus")
			Me.colStatus.ColumnEdit = Me.repositoryItemImageComboBox3
			Me.colStatus.FieldName = "Status"
			Me.colStatus.Name = "colStatus"
			Me.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			' 
			' repositoryItemImageComboBox3
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox3, "repositoryItemImageComboBox3")
			Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
			' 
			' colPercent
			' 
			resources.ApplyResources(Me.colPercent, "colPercent")
			Me.colPercent.ColumnEdit = Me.repositoryItemProgressBar1
			Me.colPercent.FieldName = "PercentComplete"
			Me.colPercent.Name = "colPercent"
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			Me.repositoryItemProgressBar1.ShowTitle = True
			' 
			' colCreated
			' 
			resources.ApplyResources(Me.colCreated, "colCreated")
			Me.colCreated.FieldName = "CreatedDate"
			Me.colCreated.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
			Me.colCreated.Name = "colCreated"
			Me.colCreated.OptionsColumn.AllowEdit = False
			Me.colCreated.OptionsColumn.AllowFocus = False
			' 
			' colStartDate
			' 
			resources.ApplyResources(Me.colStartDate, "colStartDate")
			Me.colStartDate.FieldName = "StartDate"
			Me.colStartDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
			Me.colStartDate.Name = "colStartDate"
			' 
			' colDueDate
			' 
			resources.ApplyResources(Me.colDueDate, "colDueDate")
			Me.colDueDate.FieldName = "DueDate"
			Me.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
			Me.colDueDate.Name = "colDueDate"
			' 
			' colCompleted
			' 
			resources.ApplyResources(Me.colCompleted, "colCompleted")
			Me.colCompleted.FieldName = "CompletedDate"
			Me.colCompleted.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
			Me.colCompleted.Name = "colCompleted"
			Me.colCompleted.OptionsColumn.AllowEdit = False
			Me.colCompleted.OptionsColumn.AllowFocus = False
			' 
			' colCategory
			' 
			resources.ApplyResources(Me.colCategory, "colCategory")
			Me.colCategory.ColumnEdit = Me.repositoryItemImageComboBox4
			Me.colCategory.FieldName = "Category"
			Me.colCategory.Name = "colCategory"
			Me.colCategory.OptionsColumn.AllowEdit = False
			Me.colCategory.OptionsColumn.AllowFocus = False
			Me.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			' 
			' repositoryItemImageComboBox4
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox4, "repositoryItemImageComboBox4")
			Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox4.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
			Me.repositoryItemImageComboBox4.SmallImages = Me.icCategory
			' 
			' icCategory
			' 
			Me.icCategory.ImageStream = (CType(resources.GetObject("icCategory.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.icCategory.Images.SetKeyName(0, "HouseChores_16x16.png")
			Me.icCategory.Images.SetKeyName(1, "BO_Cart.png")
			Me.icCategory.Images.SetKeyName(2, "BO_Organization.png")
			' 
			' colFlagStatus
			' 
			Me.colFlagStatus.ColumnEdit = Me.repositoryItemImageComboBox5
			Me.colFlagStatus.FieldName = "FlagStatus"
			resources.ApplyResources(Me.colFlagStatus, "colFlagStatus")
			Me.colFlagStatus.Name = "colFlagStatus"
			Me.colFlagStatus.OptionsColumn.AllowEdit = False
			Me.colFlagStatus.OptionsColumn.AllowFocus = False
			Me.colFlagStatus.OptionsColumn.AllowSize = False
			Me.colFlagStatus.OptionsColumn.FixedWidth = True
			Me.colFlagStatus.OptionsColumn.ShowCaption = False
			' 
			' repositoryItemImageComboBox5
			' 
			resources.ApplyResources(Me.repositoryItemImageComboBox5, "repositoryItemImageComboBox5")
			Me.repositoryItemImageComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemImageComboBox5.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5"
			' 
			' colOverdue
			' 
			Me.colOverdue.FieldName = "Overdue"
			Me.colOverdue.Name = "colOverdue"
			Me.colOverdue.OptionsColumn.ShowInCustomizationForm = False
			' 
			' ilColumns
			' 
			Me.ilColumns.ImageStream = (CType(resources.GetObject("ilColumns.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilColumns.TransparentColor = System.Drawing.Color.Transparent
			Me.ilColumns.Images.SetKeyName(0, "Importance.png")
			Me.ilColumns.Images.SetKeyName(1, "Icon.png")
			Me.ilColumns.Images.SetKeyName(2, "Complete.png")
			Me.ilColumns.Images.SetKeyName(3, "Flag.png")
			' 
			' repositoryItemTrackBar1
			' 
			Me.repositoryItemTrackBar1.LargeChange = 10
			Me.repositoryItemTrackBar1.Maximum = 100
			Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
			Me.repositoryItemTrackBar1.ShowValueToolTip = True
			Me.repositoryItemTrackBar1.SmallChange = 5
			Me.repositoryItemTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
			' 
			' layoutControlGroup1
			' 
			resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(1075, 593)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.gridControl1
			resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Size = New System.Drawing.Size(879, 581)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.navBarControl1
			resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
			Me.layoutControlItem2.Location = New System.Drawing.Point(879, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(184, 581)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' GridModule
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "GridModule"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icEditors, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private colComplete As DevExpress.XtraGrid.Columns.GridColumn
		Private colIcon As DevExpress.XtraGrid.Columns.GridColumn
		Private colPriority As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private colCreated As DevExpress.XtraGrid.Columns.GridColumn
		Private colStartDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colDueDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompleted As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private colFlagStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private colPercent As DevExpress.XtraGrid.Columns.GridColumn
		Private ilColumns As System.Windows.Forms.ImageList
		Private icEditors As DevExpress.Utils.ImageCollection
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private icCategory As DevExpress.Utils.ImageCollection
		Private repositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
		Private colOverdue As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private navBarControl1 As XtraNavBar.NavBarControl
		Private nbgEmployees As XtraNavBar.NavBarGroup
		Private layoutControlItem2 As XtraLayout.LayoutControlItem
	End Class
End Namespace
