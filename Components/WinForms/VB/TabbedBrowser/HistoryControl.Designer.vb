Namespace TabbedBrowser
	Partial Public Class HistoryControl
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
            Me.components = New System.ComponentModel.Container
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem
            Me.barButtonItemNewTab = New DevExpress.XtraBars.BarButtonItem
            Me.barButtonItemNewWindow = New DevExpress.XtraBars.BarButtonItem
            Me.barButtonItemClear = New DevExpress.XtraBars.BarButtonItem
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.Url = New DevExpress.XtraGrid.Columns.GridColumn
            Me.LastDate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'barManager1
            '
            Me.barManager1.AllowQuickCustomization = False
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barSubItem1, Me.barButtonItemNewTab, Me.barButtonItemNewWindow, Me.barButtonItemClear})
            Me.barManager1.MaxItemId = 6
            '
            'bar1
            '
            Me.bar1.BarName = "Custom 2"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItemClear)})
            Me.bar1.Offset = 10
            Me.bar1.OptionsBar.AllowRename = True
            Me.bar1.OptionsBar.DrawBorder = False
            Me.bar1.Text = "History"
            '
            'barSubItem1
            '
            Me.barSubItem1.Caption = "Open"
            Me.barSubItem1.Id = 2
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItemNewTab), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItemNewWindow)})
            Me.barSubItem1.Name = "barSubItem1"
            Me.barSubItem1.Tag = "Open"
            '
            'barButtonItemNewTab
            '
            Me.barButtonItemNewTab.Caption = "Open in new Tab"
            Me.barButtonItemNewTab.Id = 3
            Me.barButtonItemNewTab.Name = "barButtonItemNewTab"
            Me.barButtonItemNewTab.Tag = "Open in new Tab"
            '
            'barButtonItemNewWindow
            '
            Me.barButtonItemNewWindow.Caption = "Open in new Window"
            Me.barButtonItemNewWindow.Id = 4
            Me.barButtonItemNewWindow.Name = "barButtonItemNewWindow"
            Me.barButtonItemNewWindow.Tag = "Open in new Window"
            '
            'barButtonItemClear
            '
            Me.barButtonItemClear.Caption = "Clear"
            Me.barButtonItemClear.Id = 5
            Me.barButtonItemClear.Name = "barButtonItemClear"
            Me.barButtonItemClear.Tag = "Clear"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(355, 29)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 306)
            Me.barDockControlBottom.Size = New System.Drawing.Size(355, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 277)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(355, 29)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 277)
            '
            'barButtonItem1
            '
            Me.barButtonItem1.Caption = "Open"
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            '
            'barButtonItem2
            '
            Me.barButtonItem2.Caption = "barButtonItem2"
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 29)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me.barManager1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemButtonEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(355, 277)
            Me.gridControl1.TabIndex = 5
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Url, Me.LastDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            '
            'Url
            '
            Me.Url.Caption = "Url"
            Me.Url.FieldName = "Url"
            Me.Url.Name = "Url"
            Me.Url.OptionsColumn.AllowEdit = False
            Me.Url.OptionsColumn.ReadOnly = True
            Me.Url.Visible = True
            Me.Url.VisibleIndex = 0
            '
            'LastDate
            '
            Me.LastDate.Caption = "Date"
            Me.LastDate.FieldName = "LastDate"
            Me.LastDate.Name = "LastDate"
            Me.LastDate.OptionsColumn.AllowEdit = False
            Me.LastDate.OptionsColumn.ReadOnly = True
            Me.LastDate.Visible = True
            Me.LastDate.VisibleIndex = 1
            '
            'repositoryItemButtonEdit1
            '
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            '
            'HistoryControl
            '
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "HistoryControl"
            Me.Size = New System.Drawing.Size(355, 306)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barSubItem1 As DevExpress.XtraBars.BarSubItem
		Private WithEvents barButtonItemNewTab As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItemNewWindow As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItemClear As DevExpress.XtraBars.BarButtonItem
		Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private Url As DevExpress.XtraGrid.Columns.GridColumn
		Private LastDate As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace
