Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
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
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub StyleConditions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
		End Sub

		'<checkBox1>
		Private multiEditorColors As Color() = New Color() { Color.LightSkyBlue, Color.LemonChiffon }
		Private Sub CustomDraw(ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowEventArgs, ByVal cellIndex As Integer)
			If e.Row.Properties.Caption = "First Name" OrElse e.Row.Properties.Caption = "Last Name" Then
				e.Appearance.Font = New Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Bold)
			End If
			If TypeOf e.Row Is DevExpress.XtraVerticalGrid.Rows.MultiEditorRow Then
				Dim i As Integer = ((e.Row.Index + cellIndex) Mod 2)
				e.Appearance.BackColor = multiEditorColors(i)
				e.Appearance.ForeColor = Color.Black
			End If
			If e.Row.Properties.Caption = "Hire Date" Then
				e.Appearance.Font = New Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Strikeout)
				e.Appearance.ForeColor = SystemColors.ControlDark
			End If
			If e.Row.Properties.Caption = "Birth Date" Then
				e.Appearance.Font = New Font(DevExpress.Utils.AppearanceObject.DefaultFont, FontStyle.Italic)
				e.Appearance.BackColor = Color.Yellow
				e.Appearance.ForeColor = Color.Black
			End If
		End Sub

		Private Sub vGridControl1_CustomDrawRowValueCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs) Handles vGridControl1.CustomDrawRowValueCell
			CustomDraw(e, e.CellIndex)
		End Sub

		Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
			If (Not checkBox1.Checked) Then
				CustomDraw(e, e.CellIndex)
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			vGridControl1.LayoutChanged()
		End Sub
		'</checkBox1>
	End Class
End Namespace
