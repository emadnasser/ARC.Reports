Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ToDoList
		Inherits UserControl
		Private Shared RegularFont As Font = New System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
		Private Shared StrikeoutFont As Font = New System.Drawing.Font("Segoe UI", 8.25F, FontStyle.Strikeout, GraphicsUnit.Point, 0)
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.CheckedChanged, checkEdit3.CheckedChanged, checkEdit4.CheckedChanged, checkEdit1.CheckedChanged
			Dim checkEdit As CheckEdit = (TryCast(sender, CheckEdit))
			If checkEdit.Checked Then
				checkEdit.Font = StrikeoutFont
			Else
				checkEdit.Font = RegularFont
			End If
		End Sub
	End Class
End Namespace
