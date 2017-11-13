Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomDrawEvents
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
			Me.components = New System.ComponentModel.Container()
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.timer2 = New System.Windows.Forms.Timer(Me.components)
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsSelection.CellSelection = False
			Me.pivotGridControl1.OptionsSelection.MultiSelect = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(690, 470)
			Me.pivotGridControl1.TabIndex = 5
'			Me.pivotGridControl1.FieldAreaChanged += New DevExpress.XtraPivotGrid.PivotFieldEventHandler(Me.pivotGridControl1_FieldAreaChanged);
'			Me.pivotGridControl1.CustomDrawCell += New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(Me.pivotGridControl1_CustomDrawCell);
'			Me.pivotGridControl1.CustomDrawFieldValue += New DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(Me.pivotGridControl1_CustomDrawFieldValue);
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 2000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' timer2
			' 
'			Me.timer2.Tick += New System.EventHandler(Me.timer2_Tick);
			' 
			' CustomDrawEvents
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "CustomDrawEvents"
			Me.Size = New System.Drawing.Size(690, 470)
'			Me.Load += New System.EventHandler(Me.CustomDrawEvents_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As PivotGridControl
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents timer2 As System.Windows.Forms.Timer
	End Class
End Namespace
