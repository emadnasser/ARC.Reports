Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.ChartElements
	Partial Public Class ChartTitlesDemo
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle4 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.lblAlignment = New DevExpress.XtraEditors.LabelControl()
			Me.lblDock = New DevExpress.XtraEditors.LabelControl()
			Me.cmbAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.cmbDock = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblText = New DevExpress.XtraEditors.LabelControl()
			Me.meeText = New DevExpress.XtraEditors.MemoExEdit()
			Me.chbWordWrap = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbDock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meeText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbWordWrap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.chbWordWrap)
			Me.panel.Controls.Add(Me.cmbAlignment)
			Me.panel.Controls.Add(Me.meeText)
			Me.panel.Controls.Add(Me.lblText)
			Me.panel.Controls.Add(Me.lblAlignment)
			Me.panel.Controls.Add(Me.lblDock)
			Me.panel.Controls.Add(Me.cmbDock)
			Me.panel.Controls.SetChildIndex(Me.cmbDock, 0)
			Me.panel.Controls.SetChildIndex(Me.lblDock, 0)
			Me.panel.Controls.SetChildIndex(Me.lblAlignment, 0)
			Me.panel.Controls.SetChildIndex(Me.lblText, 0)
			Me.panel.Controls.SetChildIndex(Me.meeText, 0)
			Me.panel.Controls.SetChildIndex(Me.cmbAlignment, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.chbWordWrap, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.Visible = False
			' 
			' chart
			' 
			Me.chart.AutoLayout = False
			Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			Me.chart.DataBindings = Nothing
			xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
			xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chart.Diagram = xyDiagram1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Single
			pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			series1.Label = pointSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Series 1"
			areaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.View = areaSeriesView1
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "With XtraCharts, <b>you</b> can display an <u>unlimited</u> number of <color=blue" & ">chart titles</color>"
			chartTitle1.WordWrap = True
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Text = "<size=14>Title</size> <size=+2>with <size=+6>a</size></size> <size=24>variable</s" & "ize> <size=14>font <size=+6>size</size></size>"
			chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left
			chartTitle3.Text = "<i>Italicized</i> title"
			chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Right
			chartTitle4.Text = "<color=red>Multi</color>-<color=green>color</color> <color=blue>title</color>"
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3, chartTitle4})
'			Me.chart.ObjectSelected += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chart_ObjectSelected);
'			Me.chart.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chart_ObjectHotTracked);
			' 
			' lblAlignment
			' 
			Me.lblAlignment.Enabled = False
			Me.lblAlignment.Location = New System.Drawing.Point(12, 12)
			Me.lblAlignment.Name = "lblAlignment"
			Me.lblAlignment.Size = New System.Drawing.Size(51, 13)
			Me.lblAlignment.TabIndex = 2
			Me.lblAlignment.Text = "Alignment:"
			' 
			' lblDock
			' 
			Me.lblDock.Enabled = False
			Me.lblDock.Location = New System.Drawing.Point(156, 12)
			Me.lblDock.Name = "lblDock"
			Me.lblDock.Size = New System.Drawing.Size(27, 13)
			Me.lblDock.TabIndex = 3
			Me.lblDock.Text = "Dock:"
			' 
			' cmbAlignment
			' 
			Me.cmbAlignment.AllowDrop = True
			Me.cmbAlignment.Enabled = False
			Me.cmbAlignment.Location = New System.Drawing.Point(69, 9)
			Me.cmbAlignment.Name = "cmbAlignment"
			Me.cmbAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbAlignment.Size = New System.Drawing.Size(80, 20)
			Me.cmbAlignment.TabIndex = 4
'			Me.cmbAlignment.SelectedIndexChanged += New System.EventHandler(Me.cmbAlignment_SelectedIndexChanged);
			' 
			' cmbDock
			' 
			Me.cmbDock.Enabled = False
			Me.cmbDock.Location = New System.Drawing.Point(189, 9)
			Me.cmbDock.Name = "cmbDock"
			Me.cmbDock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cmbDock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cmbDock.Size = New System.Drawing.Size(80, 20)
			Me.cmbDock.TabIndex = 5
'			Me.cmbDock.SelectedIndexChanged += New System.EventHandler(Me.cmbDock_SelectedIndexChanged);
			' 
			' lblText
			' 
			Me.lblText.Enabled = False
			Me.lblText.Location = New System.Drawing.Point(12, 40)
			Me.lblText.Name = "lblText"
			Me.lblText.Size = New System.Drawing.Size(26, 13)
			Me.lblText.TabIndex = 6
			Me.lblText.Text = "Text:"
			' 
			' meeText
			' 
			Me.meeText.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.meeText.EditValue = ""
			Me.meeText.Enabled = False
			Me.meeText.Location = New System.Drawing.Point(69, 37)
			Me.meeText.Name = "meeText"
			Me.meeText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.meeText.Properties.PopupFormSize = New System.Drawing.Size(480, 150)
			Me.meeText.Properties.ShowIcon = False
			Me.meeText.Size = New System.Drawing.Size(480, 20)
			Me.meeText.TabIndex = 7
'			Me.meeText.TextChanged += New System.EventHandler(Me.meeText_TextChanged);
			' 
			' chbWordWrap
			' 
			Me.chbWordWrap.Location = New System.Drawing.Point(282, 9)
			Me.chbWordWrap.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
			Me.chbWordWrap.Name = "chbWordWrap"
			Me.chbWordWrap.Properties.Caption = "Word Wrap"
			Me.chbWordWrap.Size = New System.Drawing.Size(99, 19)
			Me.chbWordWrap.TabIndex = 8
'			Me.chbWordWrap.CheckedChanged += New System.EventHandler(Me.chbWordWrap_CheckedChanged);
			' 
			' ChartTitlesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "ChartTitlesDemo"
'			Me.Load += New System.EventHandler(Me.ChartDemoChartTitles_Load);
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbDock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meeText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbWordWrap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents cmbAlignment As DevExpress.XtraEditors.ComboBoxEdit
		Private WithEvents meeText As DevExpress.XtraEditors.MemoExEdit
		Private lblText As DevExpress.XtraEditors.LabelControl
		Private WithEvents cmbDock As DevExpress.XtraEditors.ComboBoxEdit
		Private lblDock As DevExpress.XtraEditors.LabelControl
		Private lblAlignment As DevExpress.XtraEditors.LabelControl
		Private WithEvents chbWordWrap As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
