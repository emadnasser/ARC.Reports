Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class TimeScalesEditForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private fScales As TimeScaleCollection

		Public Sub New(ByVal lScales As TimeScaleCollection, ByVal parent As Form)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Left = CInt(Fix(parent.Left + (parent.Width - Width) / 2))
			Top = CInt(Fix(parent.Top + (parent.Height - Height) / 2))

			Me.fScales = lScales

			UpdateTimeScalesList()
		End Sub
		Public ReadOnly Property Scales() As TimeScaleCollection
			Get
				Return fScales
			End Get
		End Property


		Private Sub UpdateTimeScalesList()
			lbTimeScales.Items.Clear()
			For i As Integer = 0 To Scales.Count - 1
				lbTimeScales.Items.Add(Scales(i).DisplayName)
			Next i
			lbTimeScales.SelectedIndex = 0
		End Sub
		Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbTimeScales.SelectedIndexChanged
			propertyGrid1.SelectedObjects = GetSelectedObjects()
		End Sub
		Private Function GetSelectedObjects() As Object()
			If lbTimeScales.SelectedItem Is Nothing Then
				Return Nothing
			End If
			Return New Object() { Scales(lbTimeScales.SelectedIndex) }
		End Function
		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
			Scales.Add(New TimeScaleFixedInterval())
			UpdateTimeScalesList()
		End Sub
		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
			If lbTimeScales.SelectedIndex = -1 Then
				Return
			End If
			Scales.RemoveAt(lbTimeScales.SelectedIndex)
			UpdateTimeScalesList()
		End Sub

		Private Sub btnDefaults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefaults.Click
			Scales.LoadDefaults()
			UpdateTimeScalesList()
		End Sub
	End Class
End Namespace

