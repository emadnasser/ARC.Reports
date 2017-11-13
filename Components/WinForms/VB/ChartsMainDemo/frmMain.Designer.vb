Imports Microsoft.VisualBasic
Imports System.ComponentModel

Namespace DevExpress.XtraCharts.Demos

	Partial Public Class frmMain
		Private components As IContainer = Nothing

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		Private Sub InitializeComponent()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
			' 
			' pnlCaption
			' 
			Me.pnlCaption.Location = New System.Drawing.Point(200, 126)
			Me.pnlCaption.Size = New System.Drawing.Size(1078, 47)
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Size = New System.Drawing.Size(1278, 126)
			' 
			' ribbonStatusBar
			' 
			Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 832)
			Me.ribbonStatusBar.Size = New System.Drawing.Size(1278, 23)
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(1278, 855)
			Me.MinimumSize = New System.Drawing.Size(1000, 800)
			Me.Name = "frmMain"
			Me.Text = "XtraCharts Features Demo"
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

#End Region
	End Class

End Namespace
