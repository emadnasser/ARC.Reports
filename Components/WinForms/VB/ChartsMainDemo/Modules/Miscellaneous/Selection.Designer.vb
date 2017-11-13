Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.Miscellaneous
	Partial Public Class SelectionDemo
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
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Me.chartBars = New DevExpress.XtraCharts.ChartControl()
			Me.chartTotal = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditSelectionMode = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSeriesDataMember = New DevExpress.XtraEditors.LabelControl()
			Me.labelTitle = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chartBars, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartTotal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditSelectionMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelSeriesDataMember)
			Me.panel.Controls.Add(Me.comboBoxEditSelectionMode)
			Me.panel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditSelectionMode, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSeriesDataMember, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 3
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chartBars
			' 
			Me.chartBars.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartBars.BackColor = System.Drawing.Color.Transparent
			Me.chartBars.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartBars.CrosshairOptions.GroupHeaderPattern = "<b>{A:yyyy}</b>"
			Me.chartBars.CrosshairOptions.HighlightPoints = False
			Me.chartBars.DataBindings = Nothing
			Me.chartBars.Legend.Name = "Default Legend"
			Me.chartBars.Location = New System.Drawing.Point(381, 76)
			Me.chartBars.Name = "chartBars"
			Me.chartBars.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartBars.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
			Me.chartBars.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartBars.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chartBars.Size = New System.Drawing.Size(318, 423)
			Me.chartBars.TabIndex = 1
			Me.chartBars.TabStop = False
			chartTitle1.Alignment = System.Drawing.StringAlignment.Near
			chartTitle1.Font = New System.Drawing.Font("Tahoma", 10F)
			chartTitle1.Text = ""
			Me.chartBars.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' chartTotal
			' 
			Me.chartTotal.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.chartTotal.BackColor = System.Drawing.Color.Transparent
			Me.chartTotal.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartTotal.DataBindings = Nothing
			Me.chartTotal.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chartTotal.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartTotal.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chartTotal.Legend.Name = "Default Legend"
			Me.chartTotal.Location = New System.Drawing.Point(0, 76)
			Me.chartTotal.Name = "chartTotal"
			Me.chartTotal.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartTotal.SeriesTemplate.ArgumentDataMember = "Region"
			Me.chartTotal.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			Me.chartTotal.SeriesTemplate.ValueDataMembersSerializable = "Sales"
			Me.chartTotal.SeriesTemplate.View = pieSeriesView1
			Me.chartTotal.Size = New System.Drawing.Size(375, 425)
			Me.chartTotal.TabIndex = 2
'			Me.chartTotal.ObjectSelected += New DevExpress.XtraCharts.HotTrackEventHandler(Me.ChartTotal_ObjectSelected);
'			Me.chartTotal.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.ChartBars_ObjectHotTracked);
			' 
			' comboBoxEditSelectionMode
			' 
			Me.comboBoxEditSelectionMode.EditValue = ""
			Me.comboBoxEditSelectionMode.Location = New System.Drawing.Point(91, 9)
			Me.comboBoxEditSelectionMode.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
			Me.comboBoxEditSelectionMode.Name = "comboBoxEditSelectionMode"
			Me.comboBoxEditSelectionMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditSelectionMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditSelectionMode.Size = New System.Drawing.Size(90, 20)
			Me.comboBoxEditSelectionMode.TabIndex = 1
'			Me.comboBoxEditSelectionMode.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSelectionMode_SelectedIndexChanged);
			' 
			' labelSeriesDataMember
			' 
			Me.labelSeriesDataMember.Location = New System.Drawing.Point(12, 12)
			Me.labelSeriesDataMember.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
			Me.labelSeriesDataMember.Name = "labelSeriesDataMember"
			Me.labelSeriesDataMember.Size = New System.Drawing.Size(76, 13)
			Me.labelSeriesDataMember.TabIndex = 0
			Me.labelSeriesDataMember.Text = "Selection Mode:"
			' 
			' labelTitle
			' 
			Me.labelTitle.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 18F)
			Me.labelTitle.Appearance.Options.UseFont = True
			Me.labelTitle.Appearance.Options.UseTextOptions = True
			Me.labelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.labelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelTitle.Location = New System.Drawing.Point(0, 35)
			Me.labelTitle.Name = "labelTitle"
			Me.labelTitle.Size = New System.Drawing.Size(700, 46)
			Me.labelTitle.TabIndex = 3
			Me.labelTitle.Text = "The DevAV Company Sales Comparison"
			' 
			' SelectionDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chartTotal)
			Me.Controls.Add(Me.chartBars)
			Me.Controls.Add(Me.labelTitle)
			Me.Name = "SelectionDemo"
			Me.Controls.SetChildIndex(Me.labelTitle, 0)
			Me.Controls.SetChildIndex(Me.chartBars, 0)
			Me.Controls.SetChildIndex(Me.chartTotal, 0)
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartBars, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartTotal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditSelectionMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents chartTotal As ChartControl
		Private labelSeriesDataMember As XtraEditors.LabelControl
		Private WithEvents comboBoxEditSelectionMode As XtraEditors.ComboBoxEdit
		Private labelTitle As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
