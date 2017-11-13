Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace ContactManagement

	Public Partial Class ObjectList
		Inherits System.Windows.Forms.Form
		Private Sub UpdateMenu()
			mnuDelete.Enabled = gridObjects.CurrentRowIndex >= 0
			mnuEdit.Enabled = mnuDelete.Enabled
		End Sub
		Public Event OnInsertObject As InsertObjectEventHandler
		Public Event OnEditObject As EditObjectEventHandler

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal caption As String, ByVal collection As XPCollection, ByVal displayableProperties As String)
			Me.New()
			Me.Text = caption
			objects = collection
			objects.DisplayableProperties = displayableProperties
			gridObjects.DataSource = objects
			UpdateMenu()
		End Sub
		Public Sub New(ByVal caption As String, ByVal session As Session, ByVal objectType As Type, ByVal criteria As CriteriaOperator, ByVal displayableProperties As String)
			Me.New(caption, New XPCollection(session, objectType, criteria), displayableProperties)
		End Sub

		Private Sub gridObjects_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridObjects.KeyDown
			If e.KeyCode = Keys.Delete Then
			mnuDelete_Click(Nothing, Nothing)
			End If
			If e.KeyCode = Keys.Insert Then
			mnuAdd_Click(Nothing, Nothing)
			End If
			If e.KeyCode = Keys.Enter Then
			mnuEdit_Click(Nothing, Nothing)
			End If
		End Sub

		Private Sub mnuAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
			If Not OnInsertObjectEvent Is Nothing Then
				RaiseEvent OnInsertObject(Me)
			End If
			objects.Reload()
			gridObjects.Refresh()
			UpdateMenu()
		End Sub

		Private Sub mnuEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
			If Not OnEditObjectEvent Is Nothing Then
				RaiseEvent OnEditObject(Me, New EditObjectEventArgs(objects(gridObjects.CurrentRowIndex)))
			End If
			objects.Reload()
			gridObjects.Refresh()
		End Sub

		Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
			Dim obj As XPObject = CType(objects(gridObjects.CurrentRowIndex), XPObject)
			obj.Delete()
			obj.Save()
			objects.Remove(obj)
			UpdateMenu()
		End Sub
	End Class
End Namespace
