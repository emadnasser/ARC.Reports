Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ActionDockPanel
		Inherits XtraUserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Property TextActions() As String
			Get
				Return meActions.EditValue.ToString()
			End Get
			Set(ByVal value As String)
				meActions.EditValue = value
			End Set
		End Property
		Private Sub CustomHeaderButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles dockPanel1.CustomButtonClick
			Dim button As IButton = GetButton(e)
			If button IsNot Nothing Then
				ShowAction(button, "Click")
			End If
		End Sub
		Private Sub CustomHeaderButtonChecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles dockPanel1.CustomButtonChecked
			Dim button As IButton = GetButton(e)
			If button IsNot Nothing Then
				ShowAction(button, "Checked")
			End If
		End Sub
		Private Sub CustomHeaderButtonUnchecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles dockPanel1.CustomButtonUnchecked
			Dim button As IButton = GetButton(e)
			If button IsNot Nothing Then
				ShowAction(button, "Unchecked")
			End If
		End Sub
		Private Function GetButton(ByVal e As ButtonEventArgs) As IButton
			Dim es As ButtonEventArgs = TryCast(e, ButtonEventArgs)
			If es Is Nothing Then
				Return Nothing
			End If
			Return es.Button
		End Function
		Private Sub ShowAction(ByVal button As IButton, ByVal action As String)
			TextActions = button.Properties.Caption + Constants.vbTab & action & Constants.vbCrLf & TextActions
		End Sub
		Public ReadOnly Property Buttons() As DevExpress.XtraBars.Docking2010.ButtonCollection
			Get
				Return dockPanel1.CustomHeaderButtons
			End Get
		End Property
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbClear.Click
			meActions.EditValue = String.Empty
		End Sub
		Public ReadOnly Property Button() As IButton
			Get
				Return dockPanel1.CustomHeaderButtons(0)
			End Get
		End Property
	End Class
End Namespace
