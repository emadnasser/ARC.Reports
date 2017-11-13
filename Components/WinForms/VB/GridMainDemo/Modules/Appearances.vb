Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos
	''' <summary>
	''' Summary description for Appearances.
	''' </summary>
	Partial Public Class Appearances
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New(ByVal view As BaseView, ByVal parent As Form)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Left = parent.Left + (parent.Width - Width) \ 2
            Top = parent.Top + (parent.Height - Height) \ 2
			Me.view = view
			InitAppearanceList(view)
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private view As BaseView

		Private Sub InitAppearanceList(ByVal view As BaseView)
			lbcAppearances.Items.Clear()
			Dim app As ColumnViewAppearances = TryCast(view.Appearance, ColumnViewAppearances)
			If app Is Nothing Then
				Return
			End If
			Dim collection As PropertyDescriptorCollection = TypeDescriptor.GetProperties(view.Appearance)
			For i As Integer = 0 To collection.Count - 1
				If collection(i).PropertyType Is GetType(AppearanceObject) Then
					lbcAppearances.Items.Add(collection(i).Name)
				End If
			Next i
			lbcAppearances.SelectedIndex = 0
		End Sub

		Private Sub lbcAppearances_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbcAppearances.SelectedIndexChanged
			xtraPropertyGrid1.PropertyGrid.SelectedObjects = SelectedObjects
		End Sub

		Private Function GetAppearanceObjectByName(ByVal view As BaseView, ByVal name As String) As AppearanceObject
			Dim app As ColumnViewAppearances = TryCast(view.Appearance, ColumnViewAppearances)
			If app Is Nothing Then
				Return Nothing
			Else
				Return app.GetAppearance(name)
			End If
		End Function

		Private ReadOnly Property SelectedObjects() As Object()
			Get
				If lbcAppearances.SelectedItem Is Nothing Then
					Return Nothing
				End If
				Dim ret As New ArrayList()
				For i As Integer = 0 To lbcAppearances.SelectedIndices.Count - 1
					Dim obj As Object = GetAppearanceObjectByName(view, lbcAppearances.GetItem(lbcAppearances.SelectedIndices(i)).ToString())
					ret.Add(obj)
				Next i
				Return ret.ToArray()
			End Get
		End Property
	End Class
End Namespace
