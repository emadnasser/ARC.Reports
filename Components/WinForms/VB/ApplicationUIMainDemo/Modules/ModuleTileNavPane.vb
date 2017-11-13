Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.Utils

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ModuleTileNavPane
		Inherits TutorialControlBase
		Public Sub New()
			InitializeComponent()
			SelectHomePath()
		End Sub

		Private Sub SelectHomePath()
			tileNavPane.SelectedElement = catMarketing
		End Sub

		Private Sub tileNavPane_TileClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles tileNavPane.TileClick
			Dim item = TryCast(e.Element, TileNavItem)
            If item IsNot Nothing AndAlso item.Category.Equals(catCreateNew) Then
                AddToLog("Tile clicked: " & e.Element.Caption)
                tileNavPane.HideDropDownWindow()
            End If
		End Sub

		Private Sub navButtonHome_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles navButtonHome.ElementClick
			AddToLog("Button clicked: Home")
			SelectHomePath()
		End Sub

		Private Sub tileNavPane_SelectedElementChanged(ByVal sender As Object, ByVal e As TileNavElementEventArgs) Handles tileNavPane.SelectedElementChanged
			Dim name As String
			If e.Element Is Nothing Then
				name = "null"
			Else
				name = e.Element.Caption
			End If
			AddToLog("Selected element changed: " & name)
		End Sub

		Private Sub navButtonSettings_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles navButtonSettings.ElementClick
			AddToLog("Button clicked: Settings")
		End Sub

		Private Sub navButtonHelp_ElementClick(ByVal sender As Object, ByVal e As NavElementEventArgs) Handles navButtonHelp.ElementClick
			AddToLog("Button clicked: Help")
		End Sub

		Private Sub AddToLog(ByVal value As String)
			eventsLog.Text = value & Environment.NewLine & eventsLog.Text
		End Sub

		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDock.SelectedIndexChanged
			tileNavPane.HideDropDownWindow()
			If cbDock.SelectedIndex = 0 Then
				tileNavPane.Dock = DockStyle.Top
			Else
				tileNavPane.Dock = DockStyle.Bottom
			End If
		End Sub

		Private Sub ceItemShadow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceItemShadow.CheckedChanged
            Dim value As DefaultBoolean
			If ceItemShadow.Checked Then
				value = DefaultBoolean.True
			Else
				value = DefaultBoolean.False
			End If
			tileNavPane.OptionsPrimaryDropDown.ShowItemShadow = value
			tileNavPane.OptionsSecondaryDropDown.ShowItemShadow = value
			tileNavPane.HideDropDownWindow()
		End Sub

		Private Sub ceOuterClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceOuterClick.CheckedChanged
            Dim value As DefaultBoolean
			If ceOuterClick.Checked Then
				value = DefaultBoolean.True
			Else
				value = DefaultBoolean.False
			End If
			tileNavPane.OptionsPrimaryDropDown.CloseOnOuterClick = value
		End Sub

		Private Sub seDropDownHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seDropDownHeight.EditValueChanged
			tileNavPane.OptionsPrimaryDropDown.Height = CInt(Fix(seDropDownHeight.Value))
			tileNavPane.HideDropDownWindow()
		End Sub

		Private Sub btnClearEventLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearEventLog.Click
			eventsLog.Text = String.Empty
		End Sub

		Protected Overrides Sub DoHide()
			MyBase.DoHide()
			If tileNavPane IsNot Nothing Then
				tileNavPane.HideDropDownWindow()
			End If
		End Sub

		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			MyBase.OnResize(e)
			If panelContainer Is Nothing Then
				Return
			End If
            Dim x As Integer = (Me.Width \ 2) - (panelContainer.Width \ 2)
            Dim y As Integer = (Me.Height \ 2) - (panelContainer.Height \ 2)
			panelContainer.Location = New Point(x, y)
		End Sub
	End Class
End Namespace
