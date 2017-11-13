Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.Utils
Namespace DevExpress.Xpo.Demos
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
            Me.SuspendLayout()
            '
            'pnlCaption
            '
            Me.pnlCaption.Size = New System.Drawing.Size(800, 64)
            '
            'frmMain
            '
            Me.ClientSize = New System.Drawing.Size(1000, 800)
            Me.Name = "frmMain"
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
