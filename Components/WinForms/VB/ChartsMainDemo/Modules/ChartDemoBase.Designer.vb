Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraCharts.Demos
	Partial Public Class ChartDemoBase
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
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.checkEditShowLabels = New DevExpress.XtraEditors.CheckEdit()
			Me.panelRoot = New System.Windows.Forms.Panel()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelRoot.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.checkEditShowLabels)
			Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel.Location = New System.Drawing.Point(0, 0)
			Me.panel.Name = "panel"
			Me.panel.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
			Me.panel.Size = New System.Drawing.Size(700, 66)
			Me.panel.TabIndex = 0
			' 
			' checkEditShowLabels
			' 
			Me.checkEditShowLabels.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkEditShowLabels.Location = New System.Drawing.Point(606, 37)
			Me.checkEditShowLabels.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
			Me.checkEditShowLabels.Name = "checkEditShowLabels"
			Me.checkEditShowLabels.Properties.Caption = "Show Labels"
			Me.checkEditShowLabels.Size = New System.Drawing.Size(82, 18)
			Me.checkEditShowLabels.TabIndex = 1
'			Me.checkEditShowLabels.CheckedChanged += New System.EventHandler(Me.checkEditShowLabels_CheckedChanged);
			' 
			' panelRoot
			' 
			Me.panelRoot.Controls.Add(Me.panel)
			Me.panelRoot.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelRoot.Location = New System.Drawing.Point(0, 0)
			Me.panelRoot.Name = "panelRoot"
			Me.panelRoot.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
			Me.panelRoot.Size = New System.Drawing.Size(700, 74)
			Me.panelRoot.TabIndex = 1
			' 
			' ChartDemoBase
			' 
			Me.Controls.Add(Me.panelRoot)
			Me.Name = "ChartDemoBase"
			Me.Size = New System.Drawing.Size(700, 500)
'			Me.Load += New System.EventHandler(Me.ChartDemoBase_Load);
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			CType(Me.checkEditShowLabels.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelRoot.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.Container = Nothing
		Protected panelRoot As System.Windows.Forms.Panel

	End Class
End Namespace
