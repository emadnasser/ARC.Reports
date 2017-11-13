Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class ColorSchemasEditForm
		Inherits DevExpress.XtraEditors.XtraForm
		Private fColorSchemas As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase)

		Public Sub New(ByVal lColorSchemas As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase), ByVal parent As Form)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Left = CInt(Fix(parent.Left + (parent.Width - Width) / 2))
			Top = CInt(Fix(parent.Top + (parent.Height - Height) / 2))

			Me.fColorSchemas = lColorSchemas

			UpdateColorSchemaList()
		End Sub
		Public ReadOnly Property ColorSchemas() As ISchedulerColorSchemaCollection(Of SchedulerColorSchemaBase)
			Get
				Return fColorSchemas
			End Get
		End Property

		Private Sub UpdateColorSchemaList()
			lbTimeScales.Items.Clear()
			For i As Integer = 0 To ColorSchemas.Count - 1
				lbTimeScales.Items.Add(String.Format("{0}-{1}", ColorSchemas(i), i))
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
			Return New Object() { ColorSchemas(lbTimeScales.SelectedIndex) }
		End Function
		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
			ColorSchemas.Add(New SchedulerColorSchema())
			UpdateColorSchemaList()
		End Sub
		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
			ColorSchemas.RemoveAt(lbTimeScales.SelectedIndex)
			UpdateColorSchemaList()
		End Sub

		Private Sub btnDefaults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefaults.Click
			ColorSchemas.LoadDefaults()
			UpdateColorSchemaList()
		End Sub
	End Class
End Namespace

