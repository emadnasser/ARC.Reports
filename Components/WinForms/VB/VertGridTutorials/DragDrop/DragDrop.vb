Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for DragDrop.
	''' </summary>
	Public Partial Class DragDrop
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
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub DragDrop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			checkBox1.Checked = vGridControl1.OptionsBehavior.DragRowHeaders
		End Sub

		'<vGridControl1>
		Private Sub vGridControl1_ProcessDragRow(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.DragRowEventArgs) Handles vGridControl1.ProcessDragRow
			Dim lb As DevExpress.XtraEditors.ListBoxControl = listBox1
			Dim p As Point = lb.PointToClient(e.ScreenLocation)
			If lb.ClientRectangle.Contains(p) Then
				Dim ind As Integer = lb.IndexFromPoint(p)
				If ind = -1 Then
					e.Effect = RowDragEffect.MoveToEnd
				Else
					e.Effect = RowDragEffect.InsertBefore
				End If
			End If
		End Sub
		Private Function GetCellValue(ByVal p As DevExpress.XtraVerticalGrid.Rows.RowProperties) As String
			Return vGridControl1.GetCellValue(p, vGridControl1.FocusedRecord).ToString()
		End Function
		Private Sub vGridControl1_EndDragRow(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.EndDragRowEventArgs) Handles vGridControl1.EndDragRow
			Dim lb As DevExpress.XtraEditors.ListBoxControl = listBox1
			Dim p As Point = lb.PointToClient(e.ScreenLocation)
			If lb.ClientRectangle.Contains(p) Then
				Dim dragString As String = ""
				If TypeOf e.Row Is DevExpress.XtraVerticalGrid.Rows.CategoryRow Then
					dragString = "Category: " & e.Row.Properties.Caption
				Else
					dragString = e.Row.Properties.Caption & " : " & GetCellValue(e.Row.Properties)
					If TypeOf e.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
						dragString = e.Row.GetRowProperties(0).Caption & " / " & e.Row.GetRowProperties(1).Caption & " : " & GetCellValue(e.Row.GetRowProperties(0)) & " / " & GetCellValue(e.Row.GetRowProperties(1))
					End If
				End If
				Dim ind As Integer = lb.IndexFromPoint(p)
				If ind = -1 Then
					lb.Items.Add(dragString)
				Else
					lb.Items.Insert(ind, dragString)
				End If
			End If
		End Sub
		'</vGridControl1>

		'<checkBox1>
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			Dim cb As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
			vGridControl1.OptionsBehavior.DragRowHeaders = cb.Checked
		End Sub
		'</checkBox1>
	End Class
End Namespace
