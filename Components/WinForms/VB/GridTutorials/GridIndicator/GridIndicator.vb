Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridIndicator.
	''' </summary>
	Public Partial Class GridIndicator
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub GridIndicator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
			radioGroup1.SelectedIndex = 2
		End Sub

		Private Sub InitData()
			Dim xv As DevExpress.XtraGrid.Design.XViewsPrinting = New DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1)
		End Sub

		'<radioGroup1>
		Private icon As Boolean = True
		Private Sub SetIndicator(ByVal val As Integer, ByVal icon As Boolean)
			spinEdit1.EditValue = val
			Me.icon = icon
			gridView1.Invalidate()
		End Sub

		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			Dim val As Integer = CInt(Fix(radioGroup1.EditValue))
			If val = 0 Then
			SetIndicator(12, True)
			ElseIf val = 1 Then
			SetIndicator(50, False)
			Else
				SetIndicator(55, True)
			End If
		End Sub
		'</radioGroup1>

		'<spinEdit1>
		Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
			gridView1.IndicatorWidth = Convert.ToInt32(spinEdit1.EditValue)
			spinEdit1.EditValue = gridView1.IndicatorWidth
		End Sub
		'</spinEdit1>

		'<radioGroup1>
		Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
			If radioGroup1.EditValue Is Nothing OrElse radioGroup1.EditValue.Equals(0) Then
			Return
			End If
			If e.Info.IsRowIndicator Then
				e.Info.DisplayText = "Row " & e.RowHandle.ToString()
				If (Not icon) Then
				e.Info.ImageIndex = -1
				End If
			End If
		End Sub
		'</radioGroup1>
	End Class
End Namespace
