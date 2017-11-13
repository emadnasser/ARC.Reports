Imports Microsoft.VisualBasic
Imports System
Namespace DashboardMainDemo.Modules
	Partial Public Class DashboardTutorialControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
			If disposing Then
				DisposeDashboard()
			End If
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.panelHeader = New DevExpress.XtraEditors.PanelControl()
			Me.btnEditDashboard = New DevExpress.XtraEditors.SimpleButton()
			Me.dashboardViewer_Renamed = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.panelFooter = New DevExpress.XtraEditors.PanelControl()
			CType(Me.panelHeader, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelHeader.SuspendLayout()
			CType(Me.dashboardViewer_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelFooter, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelHeader
			' 
			Me.panelHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelHeader.Controls.Add(Me.btnEditDashboard)
			Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelHeader.Location = New System.Drawing.Point(0, 0)
			Me.panelHeader.Name = "panelHeader"
			Me.panelHeader.Size = New System.Drawing.Size(724, 32)
			Me.panelHeader.TabIndex = 0
			' 
			' btnEditDashboard
			' 
			Me.btnEditDashboard.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnEditDashboard.Location = New System.Drawing.Point(644, 0)
			Me.btnEditDashboard.Name = "btnEditDashboard"
			Me.btnEditDashboard.Size = New System.Drawing.Size(75, 23)
			Me.btnEditDashboard.TabIndex = 0
			Me.btnEditDashboard.Text = "Edit"
'			Me.btnEditDashboard.Click += New System.EventHandler(Me.btnEditDashboard_Click);
			' 
			' dashboardViewer
			' 
			Me.dashboardViewer_Renamed.AllowPrintDashboardItems = True
			Me.dashboardViewer_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer_Renamed.Location = New System.Drawing.Point(0, 32)
			Me.dashboardViewer_Renamed.Name = "dashboardViewer"
			Me.dashboardViewer_Renamed.Size = New System.Drawing.Size(724, 382)
			Me.dashboardViewer_Renamed.TabIndex = 0
			' 
			' panelFooter
			' 
			Me.panelFooter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelFooter.Location = New System.Drawing.Point(0, 414)
			Me.panelFooter.Name = "panelFooter"
			Me.panelFooter.Size = New System.Drawing.Size(724, 45)
			Me.panelFooter.TabIndex = 2
			Me.panelFooter.Visible = False
			' 
			' DashboardTutorialControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.dashboardViewer_Renamed)
			Me.Controls.Add(Me.panelFooter)
			Me.Controls.Add(Me.panelHeader)
			Me.Name = "DashboardTutorialControl"
			Me.Size = New System.Drawing.Size(724, 459)
			CType(Me.panelHeader, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelHeader.ResumeLayout(False)
			CType(Me.dashboardViewer_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelFooter, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelHeader As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnEditDashboard As DevExpress.XtraEditors.SimpleButton
		Private dashboardViewer_Renamed As DevExpress.DashboardWin.DashboardViewer
		Protected panelFooter As DevExpress.XtraEditors.PanelControl

	End Class
End Namespace
