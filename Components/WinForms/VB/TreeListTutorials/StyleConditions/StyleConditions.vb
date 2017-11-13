Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for StyleConditions.
	''' </summary>
	Public Partial Class StyleConditions
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			treeList1.ExpandAll()
			treeList2.ExpandAll()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		'<treeList1>
		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			If (e.Node Is treeList1.FocusedNode AndAlso Not e.Column Is treeList1.FocusedColumn) OrElse e.Node Is Nothing OrElse e.Column Is Nothing Then
			Return
			End If
			If e.Node(3).Equals(True) Then
				e.Appearance.Font = New Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Strikeout)
				e.Appearance.ForeColor = SystemColors.ControlDark
			End If
		End Sub
		'</treeList1>

		'<checkBox1>
		Private Sub treeList1_NodeCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs) Handles treeList1.NodeCellStyle
			If e.Node Is treeList1.FocusedNode Then
			Return
			End If
			If e.Column.FieldName <> "Name" AndAlso checkBox1.Checked Then
			Return
			End If
			Select Case e.Node(2).ToString()
				Case "0"
					e.Appearance.BackColor = Color.MediumSpringGreen
				Case "1"
					e.Appearance.BackColor = Color.LightSkyBlue
				Case "2"
					e.Appearance.BackColor = Color.FromArgb(255, 128, 128)
					e.Appearance.ForeColor = Color.White
			End Select
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			treeList1.LayoutChanged()
		End Sub
		'</checkBox1>

		'<simpleButton1>
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			Dim dlg As StyleConditionsForm = New StyleConditionsForm(treeList2.FormatConditions)
			dlg.ShowDialog(Me)
			dlg.Dispose()
		End Sub
		'</simpleButton1>
	End Class
End Namespace
