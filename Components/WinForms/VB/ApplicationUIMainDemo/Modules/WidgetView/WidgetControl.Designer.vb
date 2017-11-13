Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class WidgetControl
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
			Dim indicatorState11 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState12 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState13 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState14 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState15 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState16 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState17 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState18 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState19 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Dim indicatorState20 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.stateIndicatorGauge1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
			Me.stateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
			Me.panel2.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.stateIndicatorGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.labelControl1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(3, 3)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
			Me.panel2.Size = New System.Drawing.Size(186, 87)
			Me.panel2.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
			Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.labelControl1.Location = New System.Drawing.Point(5, 0)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(176, 17)
			Me.labelControl1.TabIndex = 13
			Me.labelControl1.Text = "Name"
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F))
			Me.tableLayoutPanel1.Controls.Add(Me.panel4, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.panel3, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.panel2, 0, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 2
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(302, 143)
			Me.tableLayoutPanel1.TabIndex = 20
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.labelControl5)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(195, 96)
			Me.panel4.Name = "panel4"
			Me.panel4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
			Me.panel4.Size = New System.Drawing.Size(104, 44)
			Me.panel4.TabIndex = 1
			' 
			' labelControl5
			' 
			Me.labelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelControl5.Dock = System.Windows.Forms.DockStyle.Right
			Me.labelControl5.Location = New System.Drawing.Point(91, 5)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(13, 32)
			Me.labelControl5.TabIndex = 17
			Me.labelControl5.Text = "5"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.labelControl2)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(195, 3)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(104, 87)
			Me.panel3.TabIndex = 1
			' 
			' labelControl2
			' 
			Me.labelControl2.AllowHtmlString = True
			Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.labelControl2.Location = New System.Drawing.Point(80, 0)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(24, 17)
			Me.labelControl2.TabIndex = 20
			Me.labelControl2.Text = "15.5"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gaugeControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(3, 96)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(186, 44)
			Me.panel1.TabIndex = 0
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.AutoLayout = False
			Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
			Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.stateIndicatorGauge1})
			Me.gaugeControl1.LayoutInterval = 0
			Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0)
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(35, 44)
			Me.gaugeControl1.TabIndex = 17
			' 
			' stateIndicatorGauge1
			' 
			Me.stateIndicatorGauge1.Bounds = New System.Drawing.Rectangle(0, 0, 32, 44)
			Me.stateIndicatorGauge1.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() { Me.stateIndicatorComponent1})
			Me.stateIndicatorGauge1.Name = "stateIndicatorGauge1"
			' 
			' stateIndicatorComponent1
			' 
			Me.stateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124F, 124F)
			Me.stateIndicatorComponent1.Name = "stateIndicatorComponent2"
			Me.stateIndicatorComponent1.Size = New System.Drawing.SizeF(200F, 200F)
			Me.stateIndicatorComponent1.StateIndex = 0
			indicatorState11.Name = "State1"
			indicatorState11.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow1
			indicatorState12.Name = "State2"
			indicatorState12.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow2
			indicatorState13.Name = "State3"
			indicatorState13.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow3
			indicatorState14.Name = "State4"
			indicatorState14.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow4
			indicatorState15.Name = "State5"
			indicatorState15.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow5
			indicatorState16.Name = "State6"
			indicatorState16.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow6
			indicatorState17.Name = "State7"
			indicatorState17.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow7
			indicatorState18.Name = "State8"
			indicatorState18.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow8
			indicatorState19.Name = "State9"
			indicatorState19.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow9
			indicatorState20.Name = "State10"
			indicatorState20.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.Arrow10
			Me.stateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() { indicatorState11, indicatorState12, indicatorState13, indicatorState14, indicatorState15, indicatorState16, indicatorState17, indicatorState18, indicatorState19, indicatorState20})
'			Me.stateIndicatorComponent1.CustomDrawElement += New DevExpress.XtraGauges.Core.Primitive.CustomDrawElementEventHandler(Me.OnCustomDrawElement);
			' 
			' WidgetControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.Name = "WidgetControl"
			Me.Size = New System.Drawing.Size(302, 143)
			Me.panel2.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			Me.panel4.PerformLayout()
			Me.panel3.ResumeLayout(False)
			Me.panel3.PerformLayout()
			Me.panel1.ResumeLayout(False)
			CType(Me.stateIndicatorGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel2 As System.Windows.Forms.Panel
		Public labelControl1 As DevExpress.XtraEditors.LabelControl
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private panel4 As System.Windows.Forms.Panel
		Public labelControl5 As DevExpress.XtraEditors.LabelControl
		Private panel3 As System.Windows.Forms.Panel
		Public labelControl2 As DevExpress.XtraEditors.LabelControl
		Private panel1 As System.Windows.Forms.Panel
		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private stateIndicatorGauge1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
		Private WithEvents stateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent

	End Class
End Namespace
