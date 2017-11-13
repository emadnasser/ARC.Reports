Namespace DevExpress.XtraGrid.Demos
	Partial Public Class NWindNavigator
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
			Me.pnlNavigator = New DevExpress.XtraEditors.PanelControl()
			Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
			Me.sbPreview = New DevExpress.XtraEditors.SimpleButton()
			Me.sbCollapse = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlNavigator.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 73)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(742, 404)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'			Me.gridControl1.ViewRegistered += New DevExpress.XtraGrid.ViewOperationEventHandler(Me.gridControl1_ViewRegistered)
			' 
			' gridView1
			' 
			Me.gridView1.DetailHeight = 150
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableDetailToolTip = True
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			Me.gridView1.OptionsPrint.AutoWidth = False
			Me.gridView1.OptionsPrint.PrintDetails = True
			Me.gridView1.OptionsPrint.UsePrintStyles = True
			Me.gridView1.OptionsSelection.InvertSelection = True
			Me.gridView1.OptionsView.ShowColumnHeaders = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
			' 
			' pnlNavigator
			' 
			Me.pnlNavigator.Controls.Add(Me.controlNavigator1)
			Me.pnlNavigator.Controls.Add(Me.sbPreview)
			Me.pnlNavigator.Controls.Add(Me.sbCollapse)
			Me.pnlNavigator.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlNavigator.Location = New System.Drawing.Point(0, 0)
			Me.pnlNavigator.Name = "pnlNavigator"
			Me.pnlNavigator.Size = New System.Drawing.Size(742, 65)
			Me.pnlNavigator.TabIndex = 4
			' 
			' controlNavigator1
			' 
			Me.controlNavigator1.Location = New System.Drawing.Point(8, 40)
			Me.controlNavigator1.Name = "controlNavigator1"
			Me.controlNavigator1.NavigatableControl = Me.gridControl1
			Me.controlNavigator1.ShowToolTips = True
			Me.controlNavigator1.Size = New System.Drawing.Size(539, 19)
			Me.controlNavigator1.TabIndex = 0
			Me.controlNavigator1.Text = "controlNavigator1"
			Me.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' sbPreview
			' 
			Me.sbPreview.Location = New System.Drawing.Point(160, 8)
			Me.sbPreview.Name = "sbPreview"
			Me.sbPreview.Size = New System.Drawing.Size(112, 24)
			Me.sbPreview.TabIndex = 2
			Me.sbPreview.Text = "Print Preview"
'			Me.sbPreview.Click += New System.EventHandler(Me.sbPreview_Click)
			' 
			' sbCollapse
			' 
			Me.sbCollapse.Location = New System.Drawing.Point(8, 8)
			Me.sbCollapse.Name = "sbCollapse"
			Me.sbCollapse.Size = New System.Drawing.Size(136, 24)
			Me.sbCollapse.TabIndex = 1
			Me.sbCollapse.Text = "Collapse All Details"
'			Me.sbCollapse.Click += New System.EventHandler(Me.sbCollapse_Click)
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 65)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(742, 8)
			Me.panelControl1.TabIndex = 5
			' 
			' NWindNavigator
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.pnlNavigator)
			Me.Name = "NWindNavigator"
			Me.Size = New System.Drawing.Size(742, 477)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlNavigator, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlNavigator.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private components As System.ComponentModel.IContainer = Nothing
		Private pnlNavigator As DevExpress.XtraEditors.PanelControl
		Private WithEvents sbPreview As DevExpress.XtraEditors.SimpleButton
		Private WithEvents sbCollapse As DevExpress.XtraEditors.SimpleButton
		Private controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
		Private panelControl1 As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
