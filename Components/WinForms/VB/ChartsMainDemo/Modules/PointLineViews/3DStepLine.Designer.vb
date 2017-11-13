Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos.PointLineViews
	Partial Public Class StepLine3dDemo
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
			Dim xyDiagram3D1 As New DevExpress.XtraCharts.XYDiagram3D()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim line3DSeriesLabel1 As New DevExpress.XtraCharts.Line3DSeriesLabel()
			Dim stepLine3DSeriesView1 As New DevExpress.XtraCharts.StepLine3DSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Me.chartControl_Renamed = New DevExpress.XtraCharts.ChartControl()
			Me.comboBoxEditPerspective = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.checkEditInverted = New DevExpress.XtraEditors.CheckEdit()
			Me.labelPerspective = New DevExpress.XtraEditors.LabelControl()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			CType(Me.chartControl_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(line3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stepLine3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEditInverted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(203, 8)
			Me.btnDefaultAngles.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
			Me.btnDefaultAngles.TabIndex = 1
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.labelPerspective)
			Me.panel.Controls.Add(Me.checkEditInverted)
			Me.panel.Controls.Add(Me.comboBoxEditPerspective)
			Me.panel.Size = New System.Drawing.Size(700, 38)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.comboBoxEditPerspective, 0)
			Me.panel.Controls.SetChildIndex(Me.checkEditInverted, 0)
			Me.panel.Controls.SetChildIndex(Me.labelPerspective, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 9)
			Me.checkEditShowLabels.TabIndex = 3
			' 
			' panelRoot
			' 
			Me.panelRoot.Size = New System.Drawing.Size(700, 46)
			' 
			' chartControl
			' 
			Me.chartControl_Renamed.DataBindings = Nothing
			xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
			xyDiagram3D1.AxisX.Label.TextPattern = "{A:MMMM}"
			xyDiagram3D1.AxisY.Label.TextPattern = "{V:N1}"
			xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
			xyDiagram3D1.RuntimeRotation = True
			xyDiagram3D1.RuntimeScrolling = True
			xyDiagram3D1.RuntimeZooming = True
			xyDiagram3D1.VerticalScrollPercent = 4R
			xyDiagram3D1.ZoomPercent = 140
			Me.chartControl_Renamed.Diagram = xyDiagram3D1
			Me.chartControl_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl_Renamed.Legend.Name = "Default Legend"
			Me.chartControl_Renamed.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl_Renamed.Location = New System.Drawing.Point(0, 46)
			Me.chartControl_Renamed.Name = "chartControl"
			series1.ArgumentDataMember = "Date"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
			line3DSeriesLabel1.TextPattern = "{V:#.00}"
			series1.Label = line3DSeriesLabel1
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Gasoline Prices"
			series1.ValueDataMembersSerializable = "Price"
			stepLine3DSeriesView1.LineWidth = 1.2R
			series1.View = stepLine3DSeriesView1
			Me.chartControl_Renamed.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl_Renamed.Size = New System.Drawing.Size(700, 454)
			Me.chartControl_Renamed.TabIndex = 1
			chartTitle1.Text = "US Gasoline Prices in 2015"
			chartTitle2.Alignment = System.Drawing.StringAlignment.Far
			chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
			chartTitle2.Font = New System.Drawing.Font("Tahoma", 8F)
			chartTitle2.Text = "From www.eia.gov"
			chartTitle2.TextColor = System.Drawing.Color.Gray
			chartTitle3.Font = New System.Drawing.Font("Tahoma", 12F)
			chartTitle3.Text = "Dollars per Gallon"
			Me.chartControl_Renamed.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1, chartTitle2, chartTitle3})
			' 
			' comboBoxEditPerspective
			' 
			Me.comboBoxEditPerspective.EditValue = ""
			Me.comboBoxEditPerspective.Location = New System.Drawing.Point(105, 9)
			Me.comboBoxEditPerspective.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.comboBoxEditPerspective.Name = "comboBoxEditPerspective"
			Me.comboBoxEditPerspective.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBoxEditPerspective.Size = New System.Drawing.Size(78, 20)
			Me.comboBoxEditPerspective.TabIndex = 0
'			Me.comboBoxEditPerspective.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEditPerspective_SelectedIndexChanged);
			' 
			' checkEditInverted
			' 
			Me.checkEditInverted.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditInverted.Location = New System.Drawing.Point(497, 9)
			Me.checkEditInverted.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
			Me.checkEditInverted.Name = "checkEditInverted"
			Me.checkEditInverted.Properties.AutoWidth = True
			Me.checkEditInverted.Properties.Caption = "Inverted Step"
			Me.checkEditInverted.Size = New System.Drawing.Size(89, 19)
			Me.checkEditInverted.TabIndex = 2
'			Me.checkEditInverted.CheckedChanged += New System.EventHandler(Me.checkEditInverted_CheckedChanged);
			' 
			' labelPerspective
			' 
			Me.labelPerspective.Location = New System.Drawing.Point(12, 12)
			Me.labelPerspective.Margin = New System.Windows.Forms.Padding(0, 10, 3, 10)
			Me.labelPerspective.Name = "labelPerspective"
			Me.labelPerspective.Size = New System.Drawing.Size(90, 13)
			Me.labelPerspective.TabIndex = 14
			Me.labelPerspective.Text = "Perspective Angle:"
			' 
			' StepLine3dDemo
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.chartControl_Renamed)
			Me.Name = "StepLine3dDemo"
			Me.Controls.SetChildIndex(Me.panelRoot, 0)
			Me.Controls.SetChildIndex(Me.chartControl_Renamed, 0)
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			CType(xyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(line3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stepLine3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEditPerspective.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEditInverted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private labelPerspective As DevExpress.XtraEditors.LabelControl
		Protected WithEvents checkEditInverted As XtraEditors.CheckEdit

	End Class
End Namespace
