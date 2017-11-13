Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSpellChecker.Rules
Imports System.Collections.Generic
Imports DevExpress.XtraBars
Imports System.Globalization
Imports System.IO
Imports DevExpress.Utils.Zip

Namespace DevExpress.XtraSpellChecker.Demos
	''' <summary>
	''' Summary description for Employees.
	''' </summary>
	Partial Public Class CheckRichEditControl
		Inherits BaseTutorialControl
		Public Sub New()
			InitializeComponent()

			spellChecker1.UseSharedDictionaries = False
			LoadDocument()
		End Sub

		Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
			MyBase.OnVisibleChanged(e)
			If Visible Then
				MergeRibbon()
			Else
				UnMergeRibbon()
			End If
		End Sub
		Private Sub UnMergeRibbon()
			If ParentFormMain Is Nothing Then
				Return
			End If
			Dim parentRibbon As DevExpress.XtraBars.Ribbon.RibbonControl = ParentFormMain.Ribbon
			parentRibbon.UnMergeRibbon()
			parentRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
			parentRibbon.SelectedPage = parentRibbon.Pages(0)
		End Sub
		Private Sub MergeRibbon()
			If ParentFormMain Is Nothing Then
				Return
			End If
			Dim parentRibbon As DevExpress.XtraBars.Ribbon.RibbonControl = ParentFormMain.Ribbon
			parentRibbon.MergeRibbon(Me.ribbonControl1)
			parentRibbon.Pages(0).Text = "Demo"
			parentRibbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages
			parentRibbon.SelectedPage = parentRibbon.MergedPages("Review")
		End Sub
		Private Sub LoadDocument()
			Dim path As String = DemoUtils.GetRelativePath("SpellChecker.rtf")
			If (Not String.IsNullOrEmpty(path)) Then
				richEditControl1.LoadDocument(path, DevExpress.XtraRichEdit.DocumentFormat.Rtf)
			End If
		End Sub
		Protected Overrides Function GetActiveControl() As Control
			Return richEditControl1
		End Function
		Protected Sub OnEditControlKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles richEditControl1.KeyDown
			OnEditorKeyDown(sender, e)
		End Sub
		Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barCheckItem1.CheckedChanged
			Me.spellChecker1.SpellCheckMode = If((TryCast(sender, BarCheckItem)).Checked, SpellCheckMode.AsYouType, SpellCheckMode.OnDemand)
		End Sub
	End Class
End Namespace
