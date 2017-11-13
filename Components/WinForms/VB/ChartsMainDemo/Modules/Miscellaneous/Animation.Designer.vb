Imports Microsoft.VisualBasic
Imports System.ComponentModel

Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class AnimationDemo

		Private components As IContainer = Nothing

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
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.bbiRotateDiagram = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiChangeAxisXDirection = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiChangeAxisYDirection = New DevExpress.XtraBars.BarButtonItem()
			Me.cbeSeriesAnimation = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lcSeriesAnimation = New DevExpress.XtraEditors.LabelControl()
			Me.cbePointAnimation = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lcPointAnimation = New DevExpress.XtraEditors.LabelControl()
			Me.cheShowSeriesLabels = New DevExpress.XtraEditors.CheckEdit()
			Me.sbAnimateChart = New DevExpress.XtraEditors.SimpleButton()
			Me.pmContextMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.cbSeriesView = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lbSeriesView = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeSeriesAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbePointAnimation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cheShowSeriesLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pmContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbSeriesView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lbSeriesView)
			Me.panel.Controls.Add(Me.cbSeriesView)
			Me.panel.Controls.Add(Me.cbePointAnimation)
			Me.panel.Controls.Add(Me.cbeSeriesAnimation)
			Me.panel.Controls.Add(Me.lcPointAnimation)
			Me.panel.Controls.Add(Me.lcSeriesAnimation)
			Me.panel.Controls.Add(Me.sbAnimateChart)
			Me.panel.Controls.Add(Me.cheShowSeriesLabels)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.cheShowSeriesLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.sbAnimateChart, 0)
			Me.panel.Controls.SetChildIndex(Me.lcSeriesAnimation, 0)
			Me.panel.Controls.SetChildIndex(Me.lcPointAnimation, 0)
			Me.panel.Controls.SetChildIndex(Me.cbeSeriesAnimation, 0)
			Me.panel.Controls.SetChildIndex(Me.cbePointAnimation, 0)
			Me.panel.Controls.SetChildIndex(Me.cbSeriesView, 0)
			Me.panel.Controls.SetChildIndex(Me.lbSeriesView, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(13545, 37)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' chartControl1
			' 
			Me.chartControl1.DataBindings = Nothing
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Name = "Default Legend"
			Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.Location = New System.Drawing.Point(0, 74)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.Size = New System.Drawing.Size(700, 426)
			Me.chartControl1.TabIndex = 2
'			Me.chartControl1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.chartControl_MouseDown);
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.bbiRotateDiagram, Me.bbiChangeAxisXDirection, Me.bbiChangeAxisYDirection})
			Me.barManager1.MaxItemId = 3
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(700, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 500)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(700, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 500)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(700, 0)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 500)
			' 
			' bbiRotateDiagram
			' 
			Me.bbiRotateDiagram.Caption = "Rotate Diagram"
			Me.bbiRotateDiagram.Id = 0
			Me.bbiRotateDiagram.Name = "bbiRotateDiagram"
'			Me.bbiRotateDiagram.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiRotateDiagram_ItemClick);
			' 
			' bbiChangeAxisXDirection
			' 
			Me.bbiChangeAxisXDirection.Caption = "Change Axis X Direction"
			Me.bbiChangeAxisXDirection.Id = 1
			Me.bbiChangeAxisXDirection.Name = "bbiChangeAxisXDirection"
'			Me.bbiChangeAxisXDirection.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiChangeAxisXDirection_ItemClick);
			' 
			' bbiChangeAxisYDirection
			' 
			Me.bbiChangeAxisYDirection.Caption = "Change Axis Y Direction"
			Me.bbiChangeAxisYDirection.Id = 2
			Me.bbiChangeAxisYDirection.Name = "bbiChangeAxisYDirection"
'			Me.bbiChangeAxisYDirection.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.bbiChangeAxisYDirection_ItemClick);
			' 
			' cbeSeriesAnimation
			' 
			Me.cbeSeriesAnimation.Location = New System.Drawing.Point(288, 32)
			Me.cbeSeriesAnimation.MenuManager = Me.barManager1
			Me.cbeSeriesAnimation.Name = "cbeSeriesAnimation"
			Me.cbeSeriesAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeSeriesAnimation.Properties.DropDownRows = 8
			Me.cbeSeriesAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbeSeriesAnimation.Size = New System.Drawing.Size(120, 20)
			Me.cbeSeriesAnimation.TabIndex = 8
'			Me.cbeSeriesAnimation.SelectedValueChanged += New System.EventHandler(Me.cbeSeriesAnimation_SelectedValueChanged);
			' 
			' lcSeriesAnimation
			' 
			Me.lcSeriesAnimation.Location = New System.Drawing.Point(288, 12)
			Me.lcSeriesAnimation.Name = "lcSeriesAnimation"
			Me.lcSeriesAnimation.Size = New System.Drawing.Size(83, 13)
			Me.lcSeriesAnimation.TabIndex = 7
			Me.lcSeriesAnimation.Text = "Series Animation:"
			' 
			' cbePointAnimation
			' 
			Me.cbePointAnimation.Location = New System.Drawing.Point(150, 32)
			Me.cbePointAnimation.MenuManager = Me.barManager1
			Me.cbePointAnimation.Name = "cbePointAnimation"
			Me.cbePointAnimation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbePointAnimation.Properties.DropDownRows = 8
			Me.cbePointAnimation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbePointAnimation.Size = New System.Drawing.Size(120, 20)
			Me.cbePointAnimation.TabIndex = 8
'			Me.cbePointAnimation.SelectedIndexChanged += New System.EventHandler(Me.cbePointAnimation_SelectedIndexChanged);
			' 
			' lcPointAnimation
			' 
			Me.lcPointAnimation.Location = New System.Drawing.Point(150, 12)
			Me.lcPointAnimation.Name = "lcPointAnimation"
			Me.lcPointAnimation.Size = New System.Drawing.Size(78, 13)
			Me.lcPointAnimation.TabIndex = 7
			Me.lcPointAnimation.Text = "Point Animation:"
			' 
			' cheShowSeriesLabels
			' 
			Me.cheShowSeriesLabels.Location = New System.Drawing.Point(430, 32)
			Me.cheShowSeriesLabels.MenuManager = Me.barManager1
			Me.cheShowSeriesLabels.Name = "cheShowSeriesLabels"
			Me.cheShowSeriesLabels.Properties.Caption = "Show Series Labels"
			Me.cheShowSeriesLabels.Size = New System.Drawing.Size(115, 19)
			Me.cheShowSeriesLabels.TabIndex = 16
'			Me.cheShowSeriesLabels.CheckedChanged += New System.EventHandler(Me.cheShowSeriesLabels_CheckedChanged);
			' 
			' sbAnimateChart
			' 
			Me.sbAnimateChart.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sbAnimateChart.Location = New System.Drawing.Point(575, 14)
			Me.sbAnimateChart.Name = "sbAnimateChart"
			Me.sbAnimateChart.Size = New System.Drawing.Size(110, 38)
			Me.sbAnimateChart.TabIndex = 17
			Me.sbAnimateChart.Text = "Animate"
'			Me.sbAnimateChart.Click += New System.EventHandler(Me.sbAnimateChart_Click);
			' 
			' pmContextMenu
			' 
			Me.pmContextMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.bbiRotateDiagram), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiChangeAxisXDirection), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiChangeAxisYDirection)})
			Me.pmContextMenu.Manager = Me.barManager1
			Me.pmContextMenu.MultiColumn = DevExpress.Utils.DefaultBoolean.False
			Me.pmContextMenu.Name = "pmContextMenu"
			Me.pmContextMenu.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False
			' 
			' cbSeriesView
			' 
			Me.cbSeriesView.Location = New System.Drawing.Point(12, 32)
			Me.cbSeriesView.MenuManager = Me.barManager1
			Me.cbSeriesView.Name = "cbSeriesView"
			Me.cbSeriesView.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbSeriesView.Properties.DropDownRows = 16
			Me.cbSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbSeriesView.Size = New System.Drawing.Size(120, 20)
			Me.cbSeriesView.TabIndex = 18
'			Me.cbSeriesView.SelectedIndexChanged += New System.EventHandler(Me.cbSeriesView_SelectedIndexChanged);
			' 
			' lbSeriesView
			' 
			Me.lbSeriesView.Location = New System.Drawing.Point(12, 12)
			Me.lbSeriesView.Name = "lbSeriesView"
			Me.lbSeriesView.Size = New System.Drawing.Size(58, 13)
			Me.lbSeriesView.TabIndex = 19
			Me.lbSeriesView.Text = "Series View:"
			' 
			' AnimationDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "AnimationDemo"
			Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
			Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
			Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
			Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chartControl1, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeSeriesAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbePointAnimation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cheShowSeriesLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pmContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbSeriesView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private WithEvents chartControl1 As ChartControl
		Private barManager1 As XtraBars.BarManager
		Private barDockControlTop As XtraBars.BarDockControl
		Private barDockControlBottom As XtraBars.BarDockControl
		Private barDockControlLeft As XtraBars.BarDockControl
		Private barDockControlRight As XtraBars.BarDockControl
		Private WithEvents cbePointAnimation As XtraEditors.ComboBoxEdit
		Private lcPointAnimation As XtraEditors.LabelControl
		Private lcSeriesAnimation As XtraEditors.LabelControl
		Private WithEvents cbeSeriesAnimation As XtraEditors.ComboBoxEdit
		Private WithEvents cheShowSeriesLabels As XtraEditors.CheckEdit
		Private WithEvents sbAnimateChart As XtraEditors.SimpleButton
		Private WithEvents bbiRotateDiagram As XtraBars.BarButtonItem
		Private WithEvents bbiChangeAxisXDirection As XtraBars.BarButtonItem
		Private WithEvents bbiChangeAxisYDirection As XtraBars.BarButtonItem
		Private pmContextMenu As XtraBars.PopupMenu
		Private lbSeriesView As XtraEditors.LabelControl
		Private WithEvents cbSeriesView As XtraEditors.ComboBoxEdit
	End Class
End Namespace
