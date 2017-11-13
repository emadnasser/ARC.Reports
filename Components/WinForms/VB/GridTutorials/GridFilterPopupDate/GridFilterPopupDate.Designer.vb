Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Partial Public Class GridFilterPopupDate
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridFilterPopupDate))
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colReceived = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
            Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.panelControl4 = New DevExpress.XtraEditors.PanelControl
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl
            Me.cbeFilterPopupMode = New DevExpress.XtraEditors.ComboBoxEdit
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.panelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType(Me.cbeFilterPopupMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridColumn2
            '
            Me.gridColumn2.Caption = "Read"
            Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.gridColumn2.FieldName = "Read"
            Me.gridColumn2.ImageIndex = 1
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.AllowEdit = False
            Me.gridColumn2.OptionsColumn.AllowSize = False
            Me.gridColumn2.OptionsColumn.FixedWidth = True
            Me.gridColumn2.OptionsColumn.ShowCaption = False
            Me.gridColumn2.ToolTip = "Icon"
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 1
            Me.gridColumn2.Width = 44
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", 0, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", 1, 2)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageList2
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            Me.imageList2.Images.SetKeyName(5, "")
            '
            'imageList3
            '
            Me.imageList3.ImageStream = CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList3.Images.SetKeyName(0, "")
            Me.imageList3.Images.SetKeyName(1, "")
            Me.imageList3.Images.SetKeyName(2, "")
            Me.imageList3.Images.SetKeyName(3, "attach.png")
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 61)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4})
            Me.gridControl1.Size = New System.Drawing.Size(837, 361)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(185, Byte), Integer))
            Me.gridView1.Appearance.GroupRow.Options.UseForeColor = True
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.colReceived, Me.gridColumn9})
            StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            StyleFormatCondition1.Appearance.Options.UseFont = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.gridColumn2
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = 0
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupFormat = "[#image]{1} {2}"
            Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Subject", Nothing, "({0} items)")})
            Me.gridView1.Images = Me.imageList1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
            Me.gridView1.OptionsView.ShowGroupedColumns = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colReceived, DevExpress.Data.ColumnSortOrder.Descending)})
            '
            'gridColumn1
            '
            Me.gridColumn1.Caption = "Priority"
            Me.gridColumn1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.gridColumn1.FieldName = "Priority"
            Me.gridColumn1.ImageIndex = 0
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.OptionsColumn.AllowSize = False
            Me.gridColumn1.OptionsColumn.FixedWidth = True
            Me.gridColumn1.OptionsColumn.ShowCaption = False
            Me.gridColumn1.ToolTip = "Importance"
            Me.gridColumn1.Visible = True
            Me.gridColumn1.VisibleIndex = 0
            Me.gridColumn1.Width = 44
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 1)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
            '
            'gridColumn3
            '
            Me.gridColumn3.Caption = "Attachment"
            Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox3
            Me.gridColumn3.FieldName = "Attachment"
            Me.gridColumn3.ImageIndex = 2
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.AllowEdit = False
            Me.gridColumn3.OptionsColumn.AllowSize = False
            Me.gridColumn3.OptionsColumn.FixedWidth = True
            Me.gridColumn3.OptionsColumn.ShowCaption = False
            Me.gridColumn3.ToolTip = "Attachment"
            Me.gridColumn3.Visible = True
            Me.gridColumn3.VisibleIndex = 2
            Me.gridColumn3.Width = 44
            '
            'repositoryItemImageComboBox3
            '
            Me.repositoryItemImageComboBox3.AutoHeight = False
            Me.repositoryItemImageComboBox3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Attachment", 0, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 1, -1)})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            Me.repositoryItemImageComboBox3.SmallImages = Me.imageList2
            '
            'gridColumn4
            '
            Me.gridColumn4.Caption = "Subject"
            Me.gridColumn4.FieldName = "Subject"
            Me.gridColumn4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 4
            Me.gridColumn4.Width = 332
            '
            'gridColumn5
            '
            Me.gridColumn5.Caption = "From"
            Me.gridColumn5.FieldName = "From"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.Visible = True
            Me.gridColumn5.VisibleIndex = 5
            Me.gridColumn5.Width = 99
            '
            'gridColumn6
            '
            Me.gridColumn6.Caption = "To"
            Me.gridColumn6.FieldName = "To"
            Me.gridColumn6.Name = "gridColumn6"
            '
            'colReceived
            '
            Me.colReceived.Caption = "<b>Received</b>"
            Me.colReceived.ColumnEdit = Me.repositoryItemDateEdit1
            Me.colReceived.FieldName = "Received"
            Me.colReceived.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
            Me.colReceived.Name = "colReceived"
            Me.colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
            Me.colReceived.Visible = True
            Me.colReceived.VisibleIndex = 3
            Me.colReceived.Width = 149
            '
            'repositoryItemDateEdit1
            '
            Me.repositoryItemDateEdit1.AutoHeight = False
            Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "g"
            Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.repositoryItemDateEdit1.Mask.EditMask = "g"
            Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
            Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            '
            'gridColumn9
            '
            Me.gridColumn9.Caption = "Flag"
            Me.gridColumn9.ColumnEdit = Me.repositoryItemImageComboBox4
            Me.gridColumn9.FieldName = "Flag"
            Me.gridColumn9.ImageIndex = 3
            Me.gridColumn9.Name = "gridColumn9"
            Me.gridColumn9.OptionsColumn.AllowEdit = False
            Me.gridColumn9.OptionsColumn.AllowSize = False
            Me.gridColumn9.OptionsColumn.FixedWidth = True
            Me.gridColumn9.OptionsColumn.ShowCaption = False
            Me.gridColumn9.ToolTip = "Flag"
            Me.gridColumn9.Visible = True
            Me.gridColumn9.VisibleIndex = 6
            Me.gridColumn9.Width = 44
            '
            'repositoryItemImageComboBox4
            '
            Me.repositoryItemImageComboBox4.AutoHeight = False
            Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox4.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Flag", 0, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 1, -1)})
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.SmallImages = Me.imageList2
            '
            'panelControl1
            '
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.panelControl4)
            Me.panelControl1.Controls.Add(Me.panelControl3)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(837, 53)
            Me.panelControl1.TabIndex = 2
            '
            'panelControl4
            '
            Me.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl4.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelControl4.Location = New System.Drawing.Point(213, 0)
            Me.panelControl4.Name = "panelControl4"
            Me.panelControl4.Size = New System.Drawing.Size(8, 53)
            Me.panelControl4.TabIndex = 7
            '
            'panelControl3
            '
            Me.panelControl3.Controls.Add(Me.cbeFilterPopupMode)
            Me.panelControl3.Controls.Add(Me.label1)
            Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.panelControl3.Location = New System.Drawing.Point(0, 0)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(213, 53)
            Me.panelControl3.TabIndex = 6
            '
            'cbeFilterPopupMode
            '
            Me.cbeFilterPopupMode.EditValue = "DateSmart"
            Me.cbeFilterPopupMode.Location = New System.Drawing.Point(45, 25)
            Me.cbeFilterPopupMode.Name = "cbeFilterPopupMode"
            Me.cbeFilterPopupMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeFilterPopupMode.Properties.Items.AddRange(New Object() {"Date", "DateSmart", "DateAlt", "Custom"})
            Me.cbeFilterPopupMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeFilterPopupMode.Size = New System.Drawing.Size(155, 20)
            Me.cbeFilterPopupMode.TabIndex = 5
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(17, 6)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(90, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Filter Popup Mode:"
            '
            'panelControl2
            '
            Me.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl2.Location = New System.Drawing.Point(0, 53)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(837, 8)
            Me.panelControl2.TabIndex = 10
            '
            'GridFilterPopupDate
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panelControl2)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "GridFilterPopupDate"
            Me.Size = New System.Drawing.Size(837, 422)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.panelControl4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            Me.panelControl3.PerformLayout()
            CType(Me.cbeFilterPopupMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private imageList2 As System.Windows.Forms.ImageList
        Private imageList3 As System.Windows.Forms.ImageList
        Private imageList1 As System.Windows.Forms.ImageList
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Private colReceived As DevExpress.XtraGrid.Columns.GridColumn
        Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private panelControl2 As DevExpress.XtraEditors.PanelControl
        Private WithEvents cbeFilterPopupMode As DevExpress.XtraEditors.ComboBoxEdit
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
		Private panelControl4 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

