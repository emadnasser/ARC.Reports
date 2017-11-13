Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraRichEdit.Demos.Forms
	Public Partial Class SelectAmountForm
		Inherits PopupFormBase
		Public Sub New()
			InitializeComponent()
			Me.calcEdit1.Value = 0D
		End Sub

		Protected Overrides Sub SetEditValue()
			If Me.calcEdit1.Value > 0D Then
				SetEditValueCore(Me.calcEdit1.Value)
				Return
			End If
			Dim value As Decimal
			If Decimal.TryParse(Me.calcEdit1.Text, value) Then
				SetEditValueCore(value)
			End If
		End Sub
		Private Sub calcEdit1_Properties_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles calcEdit1.Properties.ButtonClick
            If Object.ReferenceEquals(e.Button, Me.calcEdit1.Properties.Buttons(1)) Then
                OnCommit()
            End If
		End Sub
		Private Sub calcEdit1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles calcEdit1.ValueChanged
			SetEditValue()
		End Sub
	End Class
End Namespace
