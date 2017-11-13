Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.BarViews
	Partial Public Class StackedBarSideBySide3dDemo
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim stackedBar3DSeriesLabel1 As New DevExpress.XtraCharts.StackedBar3DSeriesLabel()
			Dim sideBySideStackedBar3DSeriesView1 As New DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Me.chart = New DevExpress.XtraCharts.ChartControl()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.lblGroup = New DevExpress.XtraEditors.LabelControl()
			Me.radioGroup = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedBar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideStackedBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(224, 8)
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.lblGroup)
			Me.panel.Controls.Add(Me.radioGroup)
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.radioGroup, 0)
			Me.panel.Controls.SetChildIndex(Me.lblGroup, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			' 
			' chart
			' 
			Me.chart.DataBindings = Nothing
			xyDiagram3D1.AxisX.Label.MaxWidth = 60
			xyDiagram3D1.AxisY.Label.TextPattern = "{V:0,,}M"
			xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 4R
			xyDiagram3D1.ZoomPercent = 130
			Me.chart.Diagram = xyDiagram3D1
			Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chart.Legend.MaxHorizontalPercentage = 75R
			Me.chart.Legend.Name = "Default Legend"
			Me.chart.Location = New System.Drawing.Point(0, 74)
			Me.chart.Name = "chart"
			Me.chart.SeriesDataMember = "GenderAge"
			Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chart.SeriesTemplate.ArgumentDataMember = "Country"
			stackedBar3DSeriesLabel1.TextPattern = "{V:0,,.000}"
			Me.chart.SeriesTemplate.Label = stackedBar3DSeriesLabel1
			Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Population"
			Me.chart.SeriesTemplate.View = sideBySideStackedBar3DSeriesView1
			Me.chart.Size = New System.Drawing.Size(700, 426)
			Me.chart.TabIndex = 2
			chartTitle1.Text = "Population: Age Structure"
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle2.Text = "Data estimate for end-2016"
			chartTitle3.Alignment = System.Drawing.StringAlignment.Far
			chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle3.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle3.Text = "From www.cia.gov"
			chartTitle3.TextColor = System.Drawing.Color.Gray
			Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3})
'			Me.chart.BoundDataChanged += New DevExpress.XtraCharts.BoundDataChangedEventHandler(Me.chart_BoundDataChanged);
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 40)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 60
			Me.labelPerspective.Text = "Perspective Angle:"
			' 
			' comboBoxEditPerspective
			' 
			Me.comboBoxEditPerspective.EditValue = ""
			Me.comboBoxEditPerspective.Location = New System.Drawing.Point(105, 37)
			Me.comboBoxEditPerspective.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.comboBoxEditPerspective.Name = "comboBoxEditPerspective"
			Me.comboBoxEditPerspective.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditPerspective.Size = New System.Drawing.Size(78, 20)
			Me.comboBoxEditPerspective.TabIndex = 59
'			Me.comboBoxEditPerspective.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditPerspective_SelectedIndexChanged);
			' 
			' lblGroup
			' 
			Me.lblGroup.Location = New System.Drawing.Point(12, 12)
			Me.lblGroup.Name = "lblGroup"
			Me.lblGroup.Size = New System.Drawing.Size(80, 13)
			Me.lblGroup.TabIndex = 64
			Me.lblGroup.Text = "Group Series by:"
			' 
			' radioGroup
			' 
			Me.radioGroup.Location = New System.Drawing.Point(98, 8)
			Me.radioGroup.Name = "radioGroup"
			Me.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroup.Properties.Appearance.Options.UseBackColor = True
			Me.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.radioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Gender"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Age")})
			Me.radioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radioGroup.Size = New System.Drawing.Size(123, 22)
			Me.radioGroup.TabIndex = 65
'			Me.radioGroup.SelectedIndexChanged += New System.EventHandler(Me.radioGroup_SelectedIndexChanged);
			' 
			' StackedBarSideBySide3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chart)
			Me.Name = "StackedBarSideBySide3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chart, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedBar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideStackedBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents chart As ChartControl
		Private labelPerspective As DevExpress.XtraEditors.LabelControl
		Private WithEvents comboBoxEditPerspective As DevExpress.XtraEditors.ComboBoxEdit
		Private lblGroup As DevExpress.XtraEditors.LabelControl
		Private WithEvents radioGroup As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace
