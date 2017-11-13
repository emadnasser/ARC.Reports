Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos
	Partial Public Class KanbanBoard
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tileViewItemElement1 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim tileViewItemElement2 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(KanbanBoard))
			Dim tileViewItemElement3 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim tileViewItemElement4 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Me.colCaption = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.colLabel = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.colProgress = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.tileView = New DevExpress.XtraGrid.Views.Tile.TileView()
			Me.colStatus = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.colMembers = New DevExpress.XtraGrid.Columns.TileViewColumn()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colCaption
			' 
			Me.colCaption.Caption = "Caption"
			Me.colCaption.FieldName = "Caption"
			Me.colCaption.Name = "colCaption"
			Me.colCaption.Visible = True
			Me.colCaption.VisibleIndex = 1
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 4
			' 
			' colLabel
			' 
			Me.colLabel.Caption = "Label"
			Me.colLabel.FieldName = "Label"
			Me.colLabel.Name = "colLabel"
			Me.colLabel.Visible = True
			Me.colLabel.VisibleIndex = 3
			' 
			' colProgress
			' 
			Me.colProgress.Caption = "Progress"
			Me.colProgress.FieldName = "Progress"
			Me.colProgress.Name = "colProgress"
			Me.colProgress.Visible = True
			Me.colProgress.VisibleIndex = 5
			' 
			' gridControl
			' 
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(0, 0)
			Me.gridControl.MainView = Me.tileView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.Size = New System.Drawing.Size(784, 432)
			Me.gridControl.TabIndex = 0
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.tileView})
			' 
			' tileView
			' 
			Me.tileView.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(240))))))
			Me.tileView.Appearance.EmptySpace.Options.UseBackColor = True
			Me.tileView.Appearance.GroupText.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tileView.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(117))))), (CInt(Fix((CByte(125))))), (CInt(Fix((CByte(128))))))
			Me.tileView.Appearance.GroupText.Options.UseFont = True
			Me.tileView.Appearance.GroupText.Options.UseForeColor = True
			Me.tileView.Appearance.ItemNormal.BackColor = System.Drawing.Color.White
			Me.tileView.Appearance.ItemNormal.BorderColor = System.Drawing.Color.Gainsboro
			Me.tileView.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tileView.Appearance.ItemNormal.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(214))))))
			Me.tileView.Appearance.ItemNormal.Options.UseBackColor = True
			Me.tileView.Appearance.ItemNormal.Options.UseBorderColor = True
			Me.tileView.Appearance.ItemNormal.Options.UseFont = True
			Me.tileView.Appearance.ItemNormal.Options.UseForeColor = True
			Me.tileView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colStatus, Me.colCaption, Me.colMembers, Me.colLabel, Me.colDescription, Me.colProgress})
			Me.tileView.ColumnSet.GroupColumn = Me.colStatus
			Me.tileView.GridControl = Me.gridControl
			Me.tileView.Name = "tileView"
			Me.tileView.OptionsBehavior.AllowSmoothScrolling = True
			Me.tileView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.EditForm
			Me.tileView.OptionsDragDrop.AllowDrag = True
			Me.tileView.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing
			Me.tileView.OptionsEditForm.PopupEditFormWidth = 500
			Me.tileView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False
			Me.tileView.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.tileView.OptionsTiles.IndentBetweenGroups = 45
			Me.tileView.OptionsTiles.IndentBetweenItems = 10
			Me.tileView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(10)
			Me.tileView.OptionsTiles.ItemSize = New System.Drawing.Size(256, 100)
			Me.tileView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban
			Me.tileView.OptionsTiles.Padding = New System.Windows.Forms.Padding(25)
			Me.tileView.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
			Me.tileView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colStatus, DevExpress.Data.ColumnSortOrder.Ascending)})
			tileViewItemElement1.Column = Me.colCaption
			tileViewItemElement1.Text = "colCaption"
			tileViewItemElement2.Column = Me.colDescription
			tileViewItemElement2.Image = (CType(resources.GetObject("tileViewItemElement2.Image"), System.Drawing.Image))
			tileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
			tileViewItemElement2.Text = "colDescription"
			tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
			tileViewItemElement2.TextVisible = False
			tileViewItemElement3.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(128))))))
			tileViewItemElement3.Appearance.Normal.Options.UseBackColor = True
			tileViewItemElement3.Column = Me.colLabel
			tileViewItemElement3.StretchVertical = True
			tileViewItemElement3.Text = "colLabel"
			tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
			tileViewItemElement3.TextLocation = New System.Drawing.Point(-9, 0)
			tileViewItemElement3.TextVisible = False
			tileViewItemElement3.Width = 4
			tileViewItemElement4.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right
			tileViewItemElement4.AnchorElementIndex = 1
			tileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(153))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(153))))))
			tileViewItemElement4.Appearance.Normal.Options.UseFont = True
			tileViewItemElement4.Appearance.Normal.Options.UseForeColor = True
			tileViewItemElement4.Column = Me.colProgress
			tileViewItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
			tileViewItemElement4.ImageToTextIndent = 3
			tileViewItemElement4.ImageVisible = False
			tileViewItemElement4.Text = "colProgress"
			Me.tileView.TileTemplate.Add(tileViewItemElement1)
			Me.tileView.TileTemplate.Add(tileViewItemElement2)
			Me.tileView.TileTemplate.Add(tileViewItemElement3)
			Me.tileView.TileTemplate.Add(tileViewItemElement4)
'			Me.tileView.EditFormShowing += New DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(Me.tileView_EditFormShowing);
'			Me.tileView.BeforeItemDrag += New DevExpress.XtraGrid.Views.Tile.TileViewBeforeItemDragEventHandler(Me.tileView_BeforeItemDrag);
'			Me.tileView.ItemDrop += New DevExpress.XtraGrid.Views.Tile.TileViewItemDropEventHandler(Me.tileView_ItemDrop);
'			Me.tileView.ItemClick += New DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(Me.tileView_ItemClick);
'			Me.tileView.ItemCustomize += New DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventHandler(Me.tileView_ItemCustomize);
			' 
			' colStatus
			' 
			Me.colStatus.Caption = "Status"
			Me.colStatus.FieldName = "Status"
			Me.colStatus.Name = "colStatus"
			Me.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
			Me.colStatus.Visible = True
			Me.colStatus.VisibleIndex = 0
			' 
			' colMembers
			' 
			Me.colMembers.Caption = "Members"
			Me.colMembers.FieldName = "Members"
			Me.colMembers.Name = "colMembers"
			Me.colMembers.Visible = True
			Me.colMembers.VisibleIndex = 2
			' 
			' KanbanBoard
			' 
			Me.Controls.Add(Me.gridControl)
			Me.Name = "KanbanBoard"
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl As GridControl
		Private WithEvents tileView As Views.Tile.TileView
		Private colStatus As Columns.TileViewColumn
		Private colCaption As Columns.TileViewColumn
		Private colMembers As Columns.TileViewColumn
		Private colLabel As Columns.TileViewColumn
		Private colDescription As Columns.TileViewColumn
		Private colProgress As Columns.TileViewColumn
	End Class
End Namespace
