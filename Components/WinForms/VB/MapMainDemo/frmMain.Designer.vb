Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraMap.Demos
	Partial Public Class frmMain
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
			Me.components = New System.ComponentModel.Container()
			Me.SuspendLayout()
			' 
			' pnlCaption
			' 
			Me.pnlCaption.Location = New System.Drawing.Point(200, 24)
			' 
			' frmMain
			' 
			Me.ClientSize = New System.Drawing.Size(950, 650)
			Me.Name = "frmMain"
'			Me.Load += New System.EventHandler(Me.frmMain_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
