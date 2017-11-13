Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxColorEdit_Example
	Inherits Page

	Public Enum Palette
		[Default] = 0
		Gray
		Red
		Green
		Blue = 4
	End Enum

	Protected Shared CountHues As Integer = 40

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim enableCustomColors As Boolean = ASPxCheckBoxEnableCustomColors.Checked
		Dim columns As Integer = CInt(Fix(ASPxSpinEditColumns.Number))

		ColorEditHeaderBackColor.ColumnCount = columns
		ColorEditBackColor.ColumnCount = columns
		ColorEditBorderColor.ColumnCount = columns
		ColorEditForeColor.ColumnCount = columns

		ColorEditHeaderBackColor.EnableCustomColors = enableCustomColors
		ColorEditBackColor.EnableCustomColors = enableCustomColors
		ColorEditBorderColor.EnableCustomColors = enableCustomColors
		ColorEditForeColor.EnableCustomColors = enableCustomColors

		Dim pallete As New ColorEditItemCollection()
		If ASPxComboBoxPalettes.SelectedIndex = CInt(Fix(Palette.Default)) Then
			pallete.CreateDefaultItems(True)
		Else
			pallete.Assign(CreatePalette(CountHues, CType(ASPxComboBoxPalettes.SelectedIndex, Palette)))
		End If

		ColorEditHeaderBackColor.Items.Assign(pallete)
		ColorEditBackColor.Items.Assign(pallete)
		ColorEditBorderColor.Items.Assign(pallete)
		ColorEditForeColor.Items.Assign(pallete)

		ApplyColorOnRoundPanel()
	End Sub

	Protected Sub OnCallBack(ByVal sender As Object, ByVal e As EventArgs)
		ApplyColorOnRoundPanel()
	End Sub

	Protected Sub ApplyColorOnRoundPanel()
		RoundPanel.HeaderStyle.BackColor = ColorEditHeaderBackColor.Color
		RoundPanel.BackColor = ColorEditBackColor.Color
		RoundPanel.Border.BorderColor = ColorEditBorderColor.Color
		RoundPanel.ForeColor = ColorEditForeColor.Color
	End Sub

	Protected Function CreatePalette(ByVal countColors As Integer, ByVal palette As Palette) As ColorEditItemCollection
		Dim colorEditItemCollection As New ColorEditItemCollection()
		Dim [step] As Integer = 256 \ countColors

		For i As Integer = 0 To countColors - 1
			colorEditItemCollection.Add(GetHue(palette, i * [step]))
		Next i

		Return colorEditItemCollection
	End Function

	Protected Function GetHue(ByVal palette As Palette, ByVal value As Integer) As Color
		Dim color As Color = Color.Empty
		Select Case palette
			Case Palette.Red
				color = Color.FromArgb(value, 0, 0)
			Case Palette.Green
				color = Color.FromArgb(0, value, 0)
			Case Palette.Blue
				color = Color.FromArgb(0, 0, value)
			Case Palette.Gray
				color = Color.FromArgb(value, value, value)
		End Select
		Return color
	End Function
End Class
