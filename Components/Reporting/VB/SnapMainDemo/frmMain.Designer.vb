Imports Microsoft.VisualBasic
Imports System
Namespace SnapDemos
	Partial Public Class frmMain
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.SuspendLayout()
			' 
			' pnlCaption
			' 
			Me.pnlCaption.Size = New System.Drawing.Size(800, 0)
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1000, 800)
			Me.Name = "frmMain"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region
	End Class
End Namespace

