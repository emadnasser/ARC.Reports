Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.Model
Imports DevExpress.XtraRichEdit

Namespace DevExpress.XtraRichEdit.Demos
	#Region "OperationRestrictionsModule"
	Partial Public Class OperationRestrictionsModule
		Inherits DevExpress.XtraRichEdit.Demos.TutorialControl

		Public Sub New()
			InitializeComponent()
			InitializeZoomFactors()
            RtfLoadHelper.Load("TextWithImages.rtf", richEditControl)
            CType(New RichEditDemoExceptionsHandler(richEditControl), RichEditDemoExceptionsHandler).Install()
			richEditControl.Focus()
		End Sub

		#Region "Properties"
		Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return richEditControl
			End Get
		End Property
		Public ReadOnly Property IsHideDisabled() As Boolean
			Get
				Return edtHideDisabled.Checked
			End Get
		End Property
		#End Region

		Private Sub InitializeZoomFactors()
			richEditControl.Options.Behavior.MaxZoomFactor = CSng(edtMaxZoomFactor.Value)
			richEditControl.Options.Behavior.MinZoomFactor = CSng(edtMinZoomFactor.Value)
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			richEditControl.Focus()
		End Sub
		#Region "Handlers"
		Private Sub AllowCutCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowCut.CheckedChanged
			richEditControl.Options.Behavior.Cut = GetOptionValue(sender)
		End Sub
		Private Sub AllowCopyCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowCopy.CheckedChanged
			richEditControl.Options.Behavior.Copy = GetOptionValue(sender)
		End Sub
		Private Sub AllowPasteCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowPaste.CheckedChanged
			richEditControl.Options.Behavior.Paste = GetOptionValue(sender)
		End Sub
		Private Sub AllowDragCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowDrag.CheckedChanged
			richEditControl.Options.Behavior.Drag = GetOptionValue(sender)
		End Sub
		Private Sub AllowDropCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowDrop.CheckedChanged
			richEditControl.Options.Behavior.Drop = GetOptionValue(sender)
		End Sub
		Private Sub AllowSaveCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtSave.CheckedChanged
			richEditControl.Options.Behavior.Save = GetOptionValue(sender)
		End Sub
		Private Sub AllowSaveAsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowSaveAs.CheckedChanged
			richEditControl.Options.Behavior.SaveAs = GetOptionValue(sender)
		End Sub
		Private Sub AllowPrintingCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowPrinting.CheckedChanged
			richEditControl.Options.Behavior.Printing = GetOptionValue(sender)
		End Sub
		Private Sub AllowCreateNewCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowCreateNew.CheckedChanged
			richEditControl.Options.Behavior.CreateNew = GetOptionValue(sender)
		End Sub
		Private Sub AllowOpenCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowOpen.CheckedChanged
			richEditControl.Options.Behavior.Open = GetOptionValue(sender)
		End Sub
		Private Sub AllowZoomCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowZoom.CheckedChanged
			richEditControl.Options.Behavior.Zooming = GetOptionValue(sender)

			edtMaxZoomFactor.Enabled = (CType(sender, CheckEdit)).Checked
			edtMinZoomFactor.Enabled = (CType(sender, CheckEdit)).Checked
		End Sub
		Private Sub OnMinZoomFactorValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtMinZoomFactor.EditValueChanged
			richEditControl.Options.Behavior.MinZoomFactor = CSng((CType(sender, SpinEdit)).Value)
			CType(sender, SpinEdit).Value = CDec(richEditControl.Options.Behavior.MinZoomFactor)
		End Sub
		Private Sub OnMaxZoomFactorValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtMaxZoomFactor.EditValueChanged
			richEditControl.Options.Behavior.MaxZoomFactor = CSng((CType(sender, SpinEdit)).Value)
			CType(sender, SpinEdit).Value = CDec(richEditControl.Options.Behavior.MaxZoomFactor)
		End Sub
		Private Sub OnShowPopupMenuCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtAllowShowPopupMenu.CheckedChanged
			richEditControl.Options.Behavior.ShowPopupMenu = GetOptionValue(sender)
		End Sub
		#End Region

		Private Function GetOptionValue(ByVal sender As Object) As DocumentCapability
			If (CType(sender, CheckEdit)).Checked Then
				Return DocumentCapability.Enabled
			End If
			If IsHideDisabled Then
				Return DocumentCapability.Hidden
			End If
			Return DocumentCapability.Disabled
		End Function
		Public Function UpdateBarItemVisibility(ByVal capabilityCheckBoxChecked As Boolean) As DocumentCapability
			If capabilityCheckBoxChecked Then
				Return DocumentCapability.Enabled
			End If
			If (IsHideDisabled) Then
				Return DocumentCapability.Hidden
			Else
				Return DocumentCapability.Disabled
			End If
		End Function
		Private Sub edtHideDisabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtHideDisabled.CheckedChanged
			richEditControl.BeginUpdate()
			Try
				richEditControl.Options.Behavior.Cut = UpdateBarItemVisibility(Me.edtAllowCut.Checked)
				richEditControl.Options.Behavior.Copy = UpdateBarItemVisibility(Me.edtAllowCopy.Checked)
				richEditControl.Options.Behavior.Paste = UpdateBarItemVisibility(Me.edtAllowPaste.Checked)
				richEditControl.Options.Behavior.Drag = UpdateBarItemVisibility(Me.edtAllowDrag.Checked)
				richEditControl.Options.Behavior.Drop = UpdateBarItemVisibility(Me.edtAllowDrop.Checked)
				richEditControl.Options.Behavior.Save = UpdateBarItemVisibility(Me.edtSave.Checked)
				richEditControl.Options.Behavior.SaveAs = UpdateBarItemVisibility(Me.edtAllowSaveAs.Checked)
				richEditControl.Options.Behavior.Printing = UpdateBarItemVisibility(Me.edtAllowPrinting.Checked)
				richEditControl.Options.Behavior.CreateNew = UpdateBarItemVisibility(Me.edtAllowCreateNew.Checked)
				richEditControl.Options.Behavior.Open = UpdateBarItemVisibility(Me.edtAllowOpen.Checked)
				richEditControl.Options.Behavior.Zooming = UpdateBarItemVisibility(Me.edtAllowZoom.Checked)
			Finally
				richEditControl.EndUpdate()
			End Try
		End Sub

		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edtReadOnly.CheckedChanged
			richEditControl.ReadOnly = (CType(sender, CheckEdit)).Checked
		End Sub
	End Class
	#End Region
End Namespace
