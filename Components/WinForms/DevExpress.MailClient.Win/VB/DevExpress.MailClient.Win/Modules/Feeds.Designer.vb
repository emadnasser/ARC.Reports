Namespace DevExpress.MailClient.Win
	Partial Public Class Feeds
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Feeds))
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.ucMailViewer1 = New DevExpress.MailClient.Win.ucMailViewer()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontSizeDelta"), Integer))
            Me.layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.Appearance.DisabledLayoutItem.GradientMode = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.Appearance.DisabledLayoutItem.Image = (CType(resources.GetObject("layoutControl1.Appearance.DisabledLayoutItem.Image"), System.Drawing.Image))
            Me.layoutControl1.Controls.Add(Me.ucMailViewer1)
            Me.layoutControl1.Controls.Add(Me.gridControl1)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(645, 328, 450, 350)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceGroupCaption.Image"), System.Drawing.Image))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontSizeDelta"), Integer))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Image = (CType(resources.GetObject("layoutControl1.OptionsPrint.AppearanceItemCaption.Image"), System.Drawing.Image))
            'this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ucMailViewer1
            ' 
            resources.ApplyResources(Me.ucMailViewer1, "ucMailViewer1")
            Me.ucMailViewer1.Name = "ucMailViewer1"
            Me.ucMailViewer1.ZoomFactor = 1.0F
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleDescription")
            Me.gridControl1.EmbeddedNavigator.AccessibleName = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleName")
            Me.gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip"), DevExpress.Utils.DefaultBoolean))
            Me.gridControl1.EmbeddedNavigator.Anchor = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles))
            Me.gridControl1.EmbeddedNavigator.BackgroundImage = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImage"), System.Drawing.Image))
            Me.gridControl1.EmbeddedNavigator.BackgroundImageLayout = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout))
            Me.gridControl1.EmbeddedNavigator.ImeMode = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode))
            Me.gridControl1.EmbeddedNavigator.MaximumSize = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.MaximumSize"), System.Drawing.Size))
            Me.gridControl1.EmbeddedNavigator.TextLocation = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation))
            Me.gridControl1.EmbeddedNavigator.ToolTip = resources.GetString("gridControl1.EmbeddedNavigator.ToolTip")
            Me.gridControl1.EmbeddedNavigator.ToolTipIconType = (CType(resources.GetObject("gridControl1.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType))
            Me.gridControl1.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControl1.EmbeddedNavigator.ToolTipTitle")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemMemoEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '			Me.gridControl1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.gridControl1_MouseClick)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Appearance.ViewCaption.FontSizeDelta = (CType(resources.GetObject("gridView1.Appearance.ViewCaption.FontSizeDelta"), Integer))
            Me.gridView1.Appearance.ViewCaption.FontStyleDelta = (CType(resources.GetObject("gridView1.Appearance.ViewCaption.FontStyleDelta"), System.Drawing.FontStyle))
            Me.gridView1.Appearance.ViewCaption.GradientMode = (CType(resources.GetObject("gridView1.Appearance.ViewCaption.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            Me.gridView1.Appearance.ViewCaption.Image = (CType(resources.GetObject("gridView1.Appearance.ViewCaption.Image"), System.Drawing.Image))
            Me.gridView1.Appearance.ViewCaption.Options.UseTextOptions = True
            Me.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            resources.ApplyResources(Me.gridView1, "gridView1")
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitle, Me.colFrom, Me.colDate})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsPrint.PrintHorzLines = False
            Me.gridView1.OptionsPrint.PrintVertLines = False
            Me.gridView1.OptionsView.RowAutoHeight = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowIndicator = False
            Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            Me.gridView1.OptionsView.ShowViewCaption = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDate, DevExpress.Data.ColumnSortOrder.Descending)})
            '			Me.gridView1.CustomDrawEmptyForeground += New DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(Me.gridView1_CustomDrawEmptyForeground)
            '			Me.gridView1.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.gridView1_FocusedRowChanged)
            '			Me.gridView1.ColumnFilterChanged += New System.EventHandler(Me.gridView1_ColumnFilterChanged)
            '			Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove)
            '			Me.gridView1.MouseLeave += New System.EventHandler(Me.gridView1_MouseLeave)
            ' 
            ' colTitle
            ' 
            resources.ApplyResources(Me.colTitle, "colTitle")
            Me.colTitle.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowFocus = False
            ' 
            ' repositoryItemMemoEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoEdit1, "repositoryItemMemoEdit1")
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colFrom
            ' 
            resources.ApplyResources(Me.colFrom, "colFrom")
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            Me.colFrom.OptionsColumn.AllowFocus = False
            ' 
            ' colDate
            ' 
            resources.ApplyResources(Me.colDate, "colDate")
            Me.colDate.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colDate.FieldName = "Date"
            Me.colDate.Name = "colDate"
            Me.colDate.OptionsColumn.AllowFocus = False
            ' 
            ' repositoryItemTextEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
            Me.repositoryItemTextEdit1.Mask.AutoComplete = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType))
            Me.repositoryItemTextEdit1.Mask.BeepOnError = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.BeepOnError"), Boolean))
            Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
            Me.repositoryItemTextEdit1.Mask.IgnoreMaskBlank = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.IgnoreMaskBlank"), Boolean))
            Me.repositoryItemTextEdit1.Mask.MaskType = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
            Me.repositoryItemTextEdit1.Mask.PlaceHolder = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.PlaceHolder"), Char))
            Me.repositoryItemTextEdit1.Mask.SaveLiteral = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.SaveLiteral"), Boolean))
            Me.repositoryItemTextEdit1.Mask.ShowPlaceHolders = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.ShowPlaceHolders"), Boolean))
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat"), Boolean))
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1052, 537)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Control = Me.gridControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(487, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(553, 525)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Control = Me.ucMailViewer1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem2.Size = New System.Drawing.Size(482, 525)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' splitterItem1
            ' 
            Me.splitterItem1.AllowHotTrack = True
            resources.ApplyResources(Me.splitterItem1, "splitterItem1")
            Me.splitterItem1.Location = New System.Drawing.Point(482, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 525)
            ' 
            ' Feeds
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Feeds"
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private ucMailViewer1 As ucMailViewer
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colFrom As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem

	End Class
End Namespace
