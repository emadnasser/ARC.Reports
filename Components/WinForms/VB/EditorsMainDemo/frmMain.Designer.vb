Namespace DevExpress.XtraEditors.Demos
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
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
			' 
			' pnlCaption
			' 
			Me.pnlCaption.Location = New System.Drawing.Point(200, 125)
			Me.pnlCaption.Size = New System.Drawing.Size(1066, 47)
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(1266, 853)
			Me.MinimumSize = New System.Drawing.Size(798, 568)
			Me.Name = "frmMain"
			Me.ResumeLayout(False)

		End Sub

#End Region
Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
