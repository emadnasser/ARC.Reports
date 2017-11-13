Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class CardSizing
		Inherits TutorialControl

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>

		Private Sub InitializeComponent()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
			Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colCaption = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.layoutViewField_colCaption = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewTemplateCard = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewTemplateCard, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True

			Me.layoutControl1.Controls.Add(Me.gridControl1)
			Me.layoutControl1.Controls.Add(Me.zoomTrackBarControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(615, 505)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(7, 7)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPictureEdit1, Me.repositoryItemTextEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(602, 465)
			Me.gridControl1.TabIndex = 5
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' layoutView1
			' 
			Me.layoutView1.Appearance.FieldValue.Options.UseTextOptions = True
			Me.layoutView1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.layoutView1.Appearance.FieldValue.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.layoutView1.CardMinSize = New System.Drawing.Size(200, 220)
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPhoto, Me.colCaption})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsBehavior.AllowExpandCollapse = False
			Me.layoutView1.OptionsBehavior.AllowPanCards = False
			Me.layoutView1.OptionsBehavior.Editable = False
			Me.layoutView1.OptionsCustomization.AllowFilter = False
			Me.layoutView1.OptionsCustomization.AllowSort = False
			Me.layoutView1.OptionsHeaderPanel.EnableCarouselModeButton = False
			Me.layoutView1.OptionsHeaderPanel.EnableColumnModeButton = False
			Me.layoutView1.OptionsHeaderPanel.EnableMultiColumnModeButton = False
			Me.layoutView1.OptionsHeaderPanel.EnableMultiRowModeButton = False
			Me.layoutView1.OptionsHeaderPanel.EnablePanButton = False
			Me.layoutView1.OptionsHeaderPanel.EnableRowModeButton = False
			Me.layoutView1.OptionsHeaderPanel.EnableSingleModeButton = False
			Me.layoutView1.OptionsView.AllowHotTrackFields = False
			Me.layoutView1.OptionsView.CardsAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Near
			Me.layoutView1.OptionsView.ShowCardBorderIfCaptionHidden = False
			Me.layoutView1.OptionsView.ShowCardCaption = False
			Me.layoutView1.OptionsView.ShowCardLines = False
			Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.layoutView1.OptionsView.ShowHeaderPanel = False
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
			Me.layoutView1.TemplateCard = Me.layoutViewTemplateCard
			' 
			' colPhoto
			' 
			Me.colPhoto.Caption = "Photo"
			Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
			Me.colPhoto.CustomizationCaption = "Photo"
            Me.colPhoto.FieldName = "Image"
			Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
			Me.colPhoto.Name = "colPhoto"
			' 
			' repositoryItemPictureEdit1
			' 
			Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
			Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			' 
			' layoutViewField_colPhoto
			' 
			Me.layoutViewField_colPhoto.EditorPreferredWidth = 199
			Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
			Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(200, 186)
			Me.layoutViewField_colPhoto.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colPhoto.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colPhoto.TextToControlDistance = 0
			Me.layoutViewField_colPhoto.TextVisible = False
			' 
			' colCaption
			' 
			Me.colCaption.Caption = "Caption"
			Me.colCaption.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colCaption.CustomizationCaption = "Caption"
			Me.colCaption.FieldName = "Address"
			Me.colCaption.LayoutViewField = Me.layoutViewField_colCaption
			Me.colCaption.Name = "colCaption"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' layoutViewField_colCaption
			' 
			Me.layoutViewField_colCaption.EditorPreferredWidth = 199
			Me.layoutViewField_colCaption.Location = New System.Drawing.Point(0, 186)
			Me.layoutViewField_colCaption.Name = "layoutViewField_colCaption"
			Me.layoutViewField_colCaption.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutViewField_colCaption.Size = New System.Drawing.Size(200, 17)
			Me.layoutViewField_colCaption.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colCaption.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutViewField_colCaption.TextToControlDistance = 0
			Me.layoutViewField_colCaption.TextVisible = False
			' 
			' layoutViewTemplateCard
			' 
			Me.layoutViewTemplateCard.CustomizationFormText = "layoutViewTemplateCard"
            Me.layoutViewTemplateCard.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewTemplateCard.GroupBordersVisible = False
			Me.layoutViewTemplateCard.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colPhoto, Me.layoutViewField_colCaption})
			Me.layoutViewTemplateCard.Name = "layoutViewTemplateCard"
			Me.layoutViewTemplateCard.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutViewTemplateCard.Text = "layoutViewTemplateCard"
			' 
			' zoomTrackBarControl1
			' 
			Me.zoomTrackBarControl1.EditValue = 20
			Me.zoomTrackBarControl1.Location = New System.Drawing.Point(396, 483)
			Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
			Me.zoomTrackBarControl1.Properties.Maximum = 100
			Me.zoomTrackBarControl1.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.zoomTrackBarControl1.Size = New System.Drawing.Size(213, 16)
			Me.zoomTrackBarControl1.StyleController = Me.layoutControl1
			Me.zoomTrackBarControl1.TabIndex = 4
			Me.zoomTrackBarControl1.Value = 20
'			Me.zoomTrackBarControl1.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl1_EditValueChanged)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(615, 505)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.zoomTrackBarControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(389, 476)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(224, 27)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.gridControl1
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(613, 476)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 476)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(389, 27)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' CardSizing
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "CardSizing"
			Me.Size = New System.Drawing.Size(615, 505)
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colPhoto, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewTemplateCard, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.zoomTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private gridControl1 As GridControl
		Private WithEvents zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colCaption As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private layoutViewField_colCaption As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewTemplateCard As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem



	End Class
End Namespace
