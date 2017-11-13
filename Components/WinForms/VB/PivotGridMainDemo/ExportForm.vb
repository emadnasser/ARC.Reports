Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos
	Partial Public Class ExportForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal parent As Form)
			InitializeComponent()
			Me.ClientSize = New Size(pictureBox1.Image.Width + Me.DockPadding.All * 2, pictureBox1.Image.Height + Me.DockPadding.All * 2)
			If parent IsNot Nothing Then
				Left = parent.Left + CInt(Fix((parent.Width - Width) / 2))
				Top = parent.Top + CInt(Fix((parent.Height - Height) / 2))
			End If
		End Sub
	End Class
End Namespace
