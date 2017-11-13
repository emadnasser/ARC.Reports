Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos.Modules
	Partial Public Class FileSystemViewer
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FileSystemViewer))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumnImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridColumnName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnSize = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnModified = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumnType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.cbDrives = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.edtCurrentPath = New DevExpress.XtraEditors.TextEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDrives.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtCurrentPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 28)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageEdit1, Me.repositoryItemImageComboBox1})
			Me.gridControl1.Size = New System.Drawing.Size(609, 354)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumnImage, Me.gridColumnName, Me.gridColumnSize, Me.gridColumnModified, Me.gridColumnType})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowIncrementalSearch = True
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsMenu.EnableFooterMenu = False
			Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
			Me.gridView1.OptionsMenu.ShowGroupSortSummaryItems = False
			Me.gridView1.OptionsSelection.MultiSelect = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumnName, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell);
'			Me.gridView1.CalcPreviewText += New DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(Me.gridView1_CalcPreviewText);
'			Me.gridView1.CustomColumnSort += New DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(Me.gridView1_CustomColumnSort);
'			Me.gridView1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridView1_KeyDown);
'			Me.gridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseDown);
			' 
			' gridColumnImage
			' 
			Me.gridColumnImage.Caption = "gridColumn1"
			Me.gridColumnImage.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.gridColumnImage.FieldName = "ImageIndex"
			Me.gridColumnImage.Name = "gridColumnImage"
			Me.gridColumnImage.OptionsColumn.AllowFocus = False
			Me.gridColumnImage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnImage.OptionsColumn.AllowMove = False
			Me.gridColumnImage.OptionsColumn.AllowSize = False
			Me.gridColumnImage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnImage.OptionsColumn.ShowCaption = False
			Me.gridColumnImage.OptionsColumn.ShowInCustomizationForm = False
			Me.gridColumnImage.OptionsFilter.AllowFilter = False
			Me.gridColumnImage.Visible = True
			Me.gridColumnImage.VisibleIndex = 0
			Me.gridColumnImage.Width = 20
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.CaseSensitiveSearch = True
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "File_16x16.png")
			Me.imageList1.Images.SetKeyName(1, "Folder_16x16.png")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			' 
			' gridColumnName
			' 
			Me.gridColumnName.Caption = "Name"
			Me.gridColumnName.FieldName = "Name"
			Me.gridColumnName.Name = "gridColumnName"
			Me.gridColumnName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			Me.gridColumnName.Visible = True
			Me.gridColumnName.VisibleIndex = 1
			Me.gridColumnName.Width = 423
			' 
			' gridColumnSize
			' 
			Me.gridColumnSize.Caption = "Size"
			Me.gridColumnSize.FieldName = "Size"
			Me.gridColumnSize.Name = "gridColumnSize"
			Me.gridColumnSize.OptionsColumn.AllowFocus = False
			Me.gridColumnSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnSize.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			Me.gridColumnSize.Visible = True
			Me.gridColumnSize.VisibleIndex = 2
			Me.gridColumnSize.Width = 87
			' 
			' gridColumnModified
			' 
			Me.gridColumnModified.Caption = "Modified"
			Me.gridColumnModified.FieldName = "Modified"
			Me.gridColumnModified.Name = "gridColumnModified"
			Me.gridColumnModified.OptionsColumn.AllowFocus = False
			Me.gridColumnModified.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumnModified.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
			Me.gridColumnModified.Visible = True
			Me.gridColumnModified.VisibleIndex = 3
			Me.gridColumnModified.Width = 157
			' 
			' gridColumnType
			' 
			Me.gridColumnType.Caption = "Type"
			Me.gridColumnType.FieldName = "ItemType"
			Me.gridColumnType.Name = "gridColumnType"
			Me.gridColumnType.OptionsColumn.ShowInCustomizationForm = False
			Me.gridColumnType.Visible = True
			Me.gridColumnType.VisibleIndex = 4
			' 
			' repositoryItemImageEdit1
			' 
			Me.repositoryItemImageEdit1.AutoHeight = False
			Me.repositoryItemImageEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageEdit1.Images = Me.imageList1
			Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
			' 
			' cbDrives
			' 
			Me.cbDrives.Location = New System.Drawing.Point(0, 0)
			Me.cbDrives.Margin = New System.Windows.Forms.Padding(3, 3, 4, 3)
			Me.cbDrives.Name = "cbDrives"
			Me.cbDrives.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbDrives.Size = New System.Drawing.Size(50, 20)
			Me.cbDrives.TabIndex = 1
			' 
			' edtCurrentPath
			' 
			Me.edtCurrentPath.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.edtCurrentPath.Location = New System.Drawing.Point(54, 0)
			Me.edtCurrentPath.Name = "edtCurrentPath"
			Me.edtCurrentPath.Size = New System.Drawing.Size(555, 20)
			Me.edtCurrentPath.TabIndex = 2
'			Me.edtCurrentPath.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.edtCurrentPath_KeyDown);
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.edtCurrentPath)
			Me.panelControl1.Controls.Add(Me.cbDrives)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(609, 28)
			Me.panelControl1.TabIndex = 3
			' 
			' FileSystemViewer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "FileSystemViewer"
			Me.Size = New System.Drawing.Size(609, 382)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDrives.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtCurrentPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As XtraGrid.GridControl
		Private WithEvents gridView1 As XtraGrid.Views.Grid.GridView
		Private gridColumnImage As XtraGrid.Columns.GridColumn
		Private repositoryItemImageEdit1 As XtraEditors.Repository.RepositoryItemImageEdit
		Private gridColumnName As XtraGrid.Columns.GridColumn
		Private cbDrives As XtraEditors.ComboBoxEdit
		Private imageList1 As System.Windows.Forms.ImageList
		Private gridColumnSize As XtraGrid.Columns.GridColumn
		Private gridColumnModified As XtraGrid.Columns.GridColumn
		Private gridColumnType As XtraGrid.Columns.GridColumn
		Private repositoryItemImageComboBox1 As XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents edtCurrentPath As XtraEditors.TextEdit
		Private panelControl1 As XtraEditors.PanelControl
	End Class
End Namespace
