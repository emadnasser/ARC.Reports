Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridRunTimeGrouping
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
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colCyl = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colMPGCity = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colMPGHighway = New DevExpress.XtraGrid.Columns.GridColumn
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.colIsInStock = New DevExpress.XtraGrid.Columns.GridColumn
            Me.pnlMain = New DevExpress.XtraEditors.PanelControl
            Me.panel1 = New DevExpress.XtraEditors.PanelControl
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMain.SuspendLayout()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(134, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemCalcEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(564, 366)
            Me.gridControl1.TabIndex = 4
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTrademark, Me.colModel, Me.colCyl, Me.colTransmissSpeedCount, Me.colMPGCity, Me.colMPGHighway, Me.colPrice, Me.colIsInStock})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 2
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsMenu.EnableColumnMenu = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colIsInStock, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTransmissSpeedCount, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colTrademark
            '
            Me.colTrademark.Caption = "Trademark"
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            Me.colTrademark.VisibleIndex = 0
            Me.colTrademark.Width = 147
            '
            'colModel
            '
            Me.colModel.Caption = "Model"
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.OptionsFilter.AllowFilter = False
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 1
            Me.colModel.Width = 135
            '
            'colCyl
            '
            Me.colCyl.Caption = "Cyl"
            Me.colCyl.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colCyl.FieldName = "Cyl"
            Me.colCyl.Name = "colCyl"
            Me.colCyl.Visible = True
            Me.colCyl.VisibleIndex = 2
            Me.colCyl.Width = 64
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'colTransmissSpeedCount
            '
            Me.colTransmissSpeedCount.Caption = "# of Gears"
            Me.colTransmissSpeedCount.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colTransmissSpeedCount.FieldName = "Transmiss Speed Count"
            Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
            Me.colTransmissSpeedCount.Width = 78
            '
            'colMPGCity
            '
            Me.colMPGCity.Caption = "MPG City"
            Me.colMPGCity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colMPGCity.FieldName = "MPG City"
            Me.colMPGCity.Name = "colMPGCity"
            Me.colMPGCity.Visible = True
            Me.colMPGCity.VisibleIndex = 3
            Me.colMPGCity.Width = 91
            '
            'colMPGHighway
            '
            Me.colMPGHighway.Caption = "MPG Highway"
            Me.colMPGHighway.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colMPGHighway.FieldName = "MPG Highway"
            Me.colMPGHighway.Name = "colMPGHighway"
            Me.colMPGHighway.Visible = True
            Me.colMPGHighway.VisibleIndex = 4
            Me.colMPGHighway.Width = 133
            '
            'colPrice
            '
            Me.colPrice.Caption = "Price"
            Me.colPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colPrice.DisplayFormat.FormatString = "c"
            Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 5
            Me.colPrice.Width = 111
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'colIsInStock
            '
            Me.colIsInStock.Caption = "In Stock?"
            Me.colIsInStock.FieldName = "Is In Stock"
            Me.colIsInStock.Name = "colIsInStock"
            Me.colIsInStock.Width = 79
            '
            'pnlMain
            '
            Me.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlMain.Controls.Add(Me.panel1)
            Me.pnlMain.Controls.Add(Me.label1)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlMain.Location = New System.Drawing.Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(128, 366)
            Me.pnlMain.TabIndex = 5
            '
            'panel1
            '
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 25)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(128, 341)
            Me.panel1.TabIndex = 1
            '
            'label1
            '
            Me.label1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
            Me.label1.Appearance.Options.UseFont = True
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 10)
            Me.label1.Size = New System.Drawing.Size(107, 25)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Grouped Columns:"
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(128, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(6, 366)
            Me.splitter1.TabIndex = 6
            Me.splitter1.TabStop = False
            '
            'GridRunTimeGrouping
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.pnlMain)
            Me.Name = "GridRunTimeGrouping"
            Me.Size = New System.Drawing.Size(698, 366)
            Me.TutorialInfo.AboutFile = Nothing
            Me.TutorialInfo.Description = Nothing
            Me.TutorialInfo.TutorialName = Nothing
            Me.TutorialInfo.WhatsThisCodeFile = Nothing
            Me.TutorialInfo.WhatsThisXMLFile = Nothing
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlMain.PerformLayout()
            CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn
        Private colModel As DevExpress.XtraGrid.Columns.GridColumn
        Private colCyl As DevExpress.XtraGrid.Columns.GridColumn
        Private colTransmissSpeedCount As DevExpress.XtraGrid.Columns.GridColumn
        Private colMPGCity As DevExpress.XtraGrid.Columns.GridColumn
        Private colMPGHighway As DevExpress.XtraGrid.Columns.GridColumn
        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Private colIsInStock As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Private pnlMain As DevExpress.XtraEditors.PanelControl
        Private label1 As DevExpress.XtraEditors.LabelControl
		Private panel1 As DevExpress.XtraEditors.PanelControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
