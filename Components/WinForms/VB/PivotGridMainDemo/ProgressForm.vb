Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos
	Partial Public Class ProgressForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal parent As Form)
			InitializeComponent()
			If parent IsNot Nothing Then
				Left = parent.Left + CInt(Fix((parent.Width - Width) / 2))
				Top = parent.Top + CInt(Fix((parent.Height - Height) / 2))
			End If
			Me.Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4
		End Sub

		Public Sub SetProgressValue(ByVal position As Integer)
			progressBarControl1.Position = position
			Me.Update()
		End Sub
	End Class
End Namespace
