Namespace DevExpress.XtraGrid.Demos
	Partial Public Class GridSheet
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.repositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit})
			Me.gridControl1.Size = New System.Drawing.Size(873, 512)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
			Me.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.HorzScrollStep = 15
			Me.gridView1.IndicatorWidth = 60
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AutoUpdateTotalSummary = False
			Me.gridView1.OptionsCustomization.AllowFilter = False
			Me.gridView1.OptionsCustomization.AllowGroup = False
			Me.gridView1.OptionsCustomization.AllowSort = False
			Me.gridView1.OptionsMenu.EnableColumnMenu = False
			Me.gridView1.OptionsMenu.EnableFooterMenu = False
			Me.gridView1.OptionsMenu.EnableGroupPanelMenu = False
			Me.gridView1.OptionsSelection.InvertSelection = True
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			Me.gridView1.OptionsView.ShowFooter = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
'			Me.gridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.gridView1_CustomUnboundColumnData)
'			Me.gridView1.CustomDrawRowIndicator += New DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(Me.gridView1_CustomDrawRowIndicator)
'			Me.gridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.gridView1_FocusedColumnChanged)
'			Me.gridView1.CellValueChanged += New DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(Me.gridView1_CellValueChanged)
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell)
'			Me.gridView1.CustomSummaryCalculate += New DevExpress.Data.CustomSummaryEventHandler(Me.gridView1_CustomSummaryCalculate)
'			Me.gridView1.CustomDrawColumnHeader += New DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(Me.gridView1_CustomDrawColumnHeader)
			' 
			' repositoryItemSpinEdit
			' 
			Me.repositoryItemSpinEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.repositoryItemSpinEdit.AutoHeight = False
			Me.repositoryItemSpinEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemSpinEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit.IsFloatValue = False
			Me.repositoryItemSpinEdit.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit.MaxValue = New Decimal(New Integer() { 1000000, 0, 0, 0})
			Me.repositoryItemSpinEdit.MinValue = New Decimal(New Integer() { 1000000, 0, 0, -2147483648})
			Me.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit"
			' 
			' GridSheet
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridSheet"
			Me.Size = New System.Drawing.Size(873, 512)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemSpinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.IContainer = Nothing
	End Class
End Namespace
