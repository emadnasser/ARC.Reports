Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraVerticalGrid

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for Options.
	''' </summary>
	Public Partial Class Options
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

		Private Sub Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
			InitOptions(vGridControl1.OptionsView, checkedListBox1)
			InitOptions(vGridControl1.OptionsBehavior, checkedListBox2)
		End Sub

		Private Sub InitOptions(ByVal options As Object, ByVal checkedListBox As DevExpress.XtraEditors.CheckedListBoxControl)
			Dim arr As ArrayList = DevExpress.Utils.SetOptions.GetOptionNames(options)
			Dim i As Integer = 0
			Do While i < arr.Count
				checkedListBox.Items.Add(New DevExpress.XtraEditors.Controls.CheckedListBoxItem (arr(i), DevExpress.Utils.SetOptions.OptionValueByString(arr(i).ToString(), options)))
				i += 1
			Loop
		End Sub

		'<checkedListBox1>
		Private Sub checkedListBox1_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles checkedListBox1.ItemCheck
			Dim optionSet As Boolean
			If e.State = CheckState.Checked Then
				optionSet = True
			Else
				optionSet = False
			End If
			Dim [option] As String = checkedListBox1.GetDisplayItemValue(e.Index).ToString()
			DevExpress.Utils.SetOptions.SetOptionValueByString([option], vGridControl1.OptionsView, optionSet)
		End Sub
		'</checkedListBox1>

		'<checkedListBox2>
		Private Sub checkedListBox2_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles checkedListBox2.ItemCheck
			Dim optionSet As Boolean
			If e.State = CheckState.Checked Then
				optionSet = True
			Else
				optionSet = False
			End If
			Dim [option] As String = checkedListBox2.GetDisplayItemValue(e.Index).ToString()
			DevExpress.Utils.SetOptions.SetOptionValueByString([option], vGridControl1.OptionsBehavior, optionSet)
		End Sub
		'</checkedListBox2>
	End Class
End Namespace
