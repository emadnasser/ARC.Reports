Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.DataBinding
	Partial Public Class UsingSeriesTemplatesDemo
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
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Dim barSlideAnimation1 As New DevExpress.XtraCharts.BarSlideAnimation()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditSeriesDataMember = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelSeriesDataMember = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditSeriesDataMember.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelSeriesDataMember)
			Me.panel.Controls.Add(Me.comboBoxEditSeriesDataMember)
			Me.panel.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditSeriesDataMember, 0)
			Me.panel.Controls.SetChildIndex(Me.labelSeriesDataMember, 0)
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
			' chart
			' 
			Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
			Me.chart.CrosshairOptions.GroupHeaderPattern = "<b>{A}</b>"
			Me.chart.DataBindings = Nothing
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 46)
			Me.chart.Name = "chart"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			sideBySideBarSeriesLabel1.TextPattern = "{V:F2}"
			Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Product"
			barSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromRight
			barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
			sideBySideBarSeriesView1.Animation = barSlideAnimation1
			Me.chart.SeriesTemplate.View = sideBySideBarSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 454)
			Me.chart.TabIndex = 1
			Me.chart.TabStop = False
			chartTitle1.Text = "G7 GDP, in Billions of US$"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "The World Bank: GDP (current US$)"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2})
			' 
			' comboBoxEditSeriesDataMember
			' 
			Me.comboBoxEditSeriesDataMember.EditValue = ""
			Me.comboBoxEditSeriesDataMember.Location = New System.Drawing.Point(115, 9)
			Me.comboBoxEditSeriesDataMember.Margin = New System.Windows.Forms.Padding(3, 0, 10, 0)
			Me.comboBoxEditSeriesDataMember.Name = "comboBoxEditSeriesDataMember"
			Me.comboBoxEditSeriesDataMember.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditSeriesDataMember.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditSeriesDataMember.Size = New System.Drawing.Size(90, 20)
			Me.comboBoxEditSeriesDataMember.TabIndex = 1
'			Me.comboBoxEditSeriesDataMember.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditSeriesDataMember_SelectedIndexChanged);
			' 
			' labelSeriesDataMember
			' 
			Me.labelSeriesDataMember.Location = New System.Drawing.Point(12, 12)
			Me.labelSeriesDataMember.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
			Me.labelSeriesDataMember.Name = "labelSeriesDataMember"
			Me.labelSeriesDataMember.Size = New System.Drawing.Size(100, 13)
			Me.labelSeriesDataMember.TabIndex = 0
			Me.labelSeriesDataMember.Text = "Series Data Member:"
			' 
			' UsingSeriesTemplatesDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "UsingSeriesTemplatesDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditSeriesDataMember.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelSeriesDataMember As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
