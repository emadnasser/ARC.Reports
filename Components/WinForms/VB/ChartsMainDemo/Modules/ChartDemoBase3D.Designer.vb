Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos
	Partial Public Class ChartDemoBase3D
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
			Me.btnDefaultAngles = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.btnDefaultAngles)
			Me.panel.Controls.SetChildIndex(Me.checkEditShowLabels, 0)
			Me.panel.Controls.SetChildIndex(Me.btnDefaultAngles, 0)
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 19)
			Me.checkEditShowLabels.TabIndex = 52
			' 
			' btnDefaultAngles
			' 
			Me.btnDefaultAngles.Location = New System.Drawing.Point(10, 36)
			Me.btnDefaultAngles.Margin = New System.Windows.Forms.Padding(0, 10, 10, 0)
			Me.btnDefaultAngles.Name = "btnDefaultAngles"
			Me.btnDefaultAngles.Size = New System.Drawing.Size(128, 22)
			Me.btnDefaultAngles.TabIndex = 51
			Me.btnDefaultAngles.Text = "Restore Default Angles"
'			Me.btnDefaultAngles.Click += New System.EventHandler(Me.btnDefaultAngles_Click);
			' 
			' ChartDemoBase3D
			' 
			Me.Name = "ChartDemoBase3D"
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Protected WithEvents btnDefaultAngles As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace
