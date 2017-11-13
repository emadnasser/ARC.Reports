Imports System.Collections
Imports System.ComponentModel
' <comboGlyphAlign>
Imports DevExpress.Utils
' </comboGlyphAlign>
' <btnPopulateItems>
Imports DevExpress.XtraEditors.Controls
' </btnPopulateItems>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleRadioGroup
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleRadioGroup.vb"
			TutorialInfo.WhatsThisXMLFile = "radioGroup.xml"
		End Sub

		Private updateValues As Boolean = False

		' <btnSelectNext>
		Private Sub btnSelectNext_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim currentSelectedIndex As Integer = radioGroupSample.SelectedIndex
			currentSelectedIndex += 1
			If currentSelectedIndex = radioGroupSample.Properties.Items.Count Then
				currentSelectedIndex = 0
			End If
			radioGroupSample.SelectedIndex = currentSelectedIndex
		End Sub
		' </btnSelectNext>

		' <comboGlyphAlign>
		Private Sub comboGlyphAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboGlyphAlign.SelectedIndexChanged
			Dim alignments() As HorzAlignment = { HorzAlignment.Near, HorzAlignment.Center, HorzAlignment.Far }
			Dim selectedIndex As Integer = comboGlyphAlign.SelectedIndex
			radioGroupSample.Properties.GlyphAlignment = alignments(selectedIndex)
			radioGroupSample.Properties.Appearance.TextOptions.HAlignment = alignments(selectedIndex)
		End Sub
		' </comboGlyphAlign>

		' <spinColumns>
		Private Sub spinColumns_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinColumns.EditValueChanged
			radioGroupSample.Properties.Columns = CInt(Fix(spinColumns.Value))
			UpdateRadioGroupSize()
		End Sub
        Private Sub UpdateRadioGroupSize()
            If radioGroupSample.Parent Is Nothing Then Return
            radioGroupSample.SuspendLayout()
            Dim columnWidth As Integer = radioGroupSample.Parent.Width \ 3 - 5
            Dim rowHeight As Integer = 24
            Dim rowCount As Integer = CInt(Fix(Math.Ceiling(CDbl(radioGroupSample.Properties.Items.Count) / CDbl(radioGroupSample.Properties.Columns))))
            radioGroupSample.Width = columnWidth * radioGroupSample.Properties.Columns
            radioGroupSample.Height = rowCount * rowHeight
            CenterRadioGroup()
            radioGroupSample.ResumeLayout(True)
        End Sub
		Private Sub CenterRadioGroup()
			radioGroupSample.Left = (radioGroupSample.Parent.Width - radioGroupSample.Width) \ 2
			radioGroupSample.Top = (radioGroupSample.Parent.Height - radioGroupSample.Height) \ 2
		End Sub
		' </spinColumns>

		' <comboSetEditValue>
		Private Sub comboSetEditValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboSetEditValue.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim editValues() As String = { "Circle", "Rectangle", "Ellipse", "Triangle", "Square", "Nothing" }
			Dim selectedIndex As Integer = comboSetEditValue.SelectedIndex
			radioGroupSample.EditValue = editValues(selectedIndex)
		End Sub
		' </comboSetEditValue>

		Private Sub ModuleRadioGroup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			btnPopulateItems_Click(btnPopulateItems, New EventArgs())
			UpdateRadioGroupSize()
		End Sub

		' <btnPopulateItems>
		Private Sub btnPopulateItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPopulateItems.Click
			Dim strings() As String = { "Circle", "Rectangle", "Ellipse", "Triangle", "Square" }
			Dim values() As String = { "Circle", "Rectangle", "Ellipse", "Triangle", "Square", "Nothing" }
			For i As Integer = 0 To strings.Length - 1
				radioGroupSample.Properties.Items.Add(New RadioGroupItem(values(i), strings(i)))
			Next i
			comboSetEditValue.Properties.Items.Clear()
			For i As Integer = 0 To values.Length - 1
				comboSetEditValue.Properties.Items.Add(values(i))
			Next i
			radioGroupSample.SelectedIndex = 0
			SetControlsEnabled(True)
		End Sub
		' </btnPopulateItems>

		' <btnClearItems>
		Private Sub btnClearItems_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearItems.Click
			radioGroupSample.Properties.Items.Clear()
			comboSetEditValue.Properties.Items.Clear()
			checkEditAllowMnemonics.Checked = False
			SetControlsEnabled(False)
		End Sub
		' <btnPopulateItems>
		Private Sub SetControlsEnabled(ByVal listPopulated As Boolean)
			btnPopulateItems.Enabled = Not listPopulated
			Dim controls As New ArrayList()
			controls.AddRange(New Control() { btnClearItems, spinColumns, comboGlyphAlign, checkEditAllowMnemonics, spinSelectedIndex, comboSetEditValue, txtSelectedIndexValue })
			For Each ctrl As Control In controls
				ctrl.Enabled = listPopulated
			Next ctrl
		End Sub
		' </btnClearItems> </btnPopulateItems>

		' <spinSelectedIndex>
		Private Sub spinSelectedIndex_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinSelectedIndex.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			radioGroupSample.SelectedIndex = CInt(Fix(spinSelectedIndex.Value))
		End Sub
		' </spinSelectedIndex>


		' <txtSelectedIndexValue>
		Private Sub radioGroupSample_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroupSample.SelectedIndexChanged
			txtSelectedIndexValue.Text = radioGroupSample.SelectedIndex.ToString() & " / " & radioGroupSample.EditValue.ToString()
			updateValues = True
			spinSelectedIndex.Value = radioGroupSample.SelectedIndex
			comboSetEditValue.EditValue = radioGroupSample.EditValue
			updateValues = False

		End Sub
		' </txtSelectedIndexValue>

		' <checkEditAllowMnemonics>
		Private Sub checkEditAllowMnemonics_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAllowMnemonics.CheckedChanged
			For Each item As RadioGroupItem In radioGroupSample.Properties.Items
				If checkEditAllowMnemonics.Checked Then
					item.Description = "&" & item.Description
				Else
					item.Description = item.Description.Substring(1)
				End If
			Next item
		End Sub
		' </checkEditAllowMnemonics>

	End Class
End Namespace

