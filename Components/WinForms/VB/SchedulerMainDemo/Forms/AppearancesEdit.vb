Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports System.Collections.Generic

Namespace DevExpress.XtraScheduler.Demos
	''' <summary>
	''' Summary description for Appearances.
	''' </summary>
	Partial Public Class AppearancesEditForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private appearances As BaseAppearanceCollection

		Public Sub New(ByVal appearances As BaseAppearanceCollection, ByVal parent As Form)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Left = CInt(Fix(parent.Left + (parent.Width - Width) / 2))
			Top = CInt(Fix(parent.Top + (parent.Height - Height) / 2))

			Me.appearances = appearances
			FillAppearanceList()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub FillAppearanceList()
			lbcAppearances.Items.Clear()

			Dim validNames As List(Of String) = CalculateValidAppearanceNames()
			For Each app As AppearanceObject In appearances
				If validNames.Contains(app.Name) Then
					lbcAppearances.Items.Add(app.Name)
				End If
			Next app
			lbcAppearances.SelectedIndex = 0
		End Sub
		Private Function CalculateValidAppearanceNames() As List(Of String)
			Dim names As New List(Of String)()
			Dim descriptors As PropertyDescriptorCollection = TypeDescriptor.GetProperties(appearances, New Attribute() { New BrowsableAttribute(True) })
			For i As Integer = 0 To descriptors.Count - 1
				names.Add(descriptors(i).Name)
			Next i
			Return names
		End Function

		Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbcAppearances.SelectedIndexChanged
			propertyGrid1.SelectedObjects = GetSelectedObjects()
		End Sub
		Private Function GetSelectedObjects() As Object()
			If lbcAppearances.SelectedItem Is Nothing Then
				Return Nothing
			End If
			Dim result As New ArrayList()
			For i As Integer = 0 To lbcAppearances.SelectedIndices.Count - 1
				Dim obj As Object = appearances.GetAppearance(lbcAppearances.Text)
				result.Add(obj)
			Next i
			Return result.ToArray()
		End Function
	End Class
End Namespace
