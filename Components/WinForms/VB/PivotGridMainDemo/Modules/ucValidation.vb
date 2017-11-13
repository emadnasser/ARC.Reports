Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	''' <summary>
	''' Summary description for UserControl1.
	''' </summary>
	Partial Public Class ValidationControl
		Inherits System.Windows.Forms.UserControl
		Public Sub New()
			SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		Private fCaption As String
		Public Event ValidateCondition As EventHandler

		Private Sub imageComboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit1.SelectedIndexChanged
			Dim visibleNextCondition As Boolean = CInt(Fix(imageComboBoxEdit1.EditValue)) < 2
			spinEdit2.Visible = visibleNextCondition
			imageComboBoxEdit2.Visible = spinEdit2.Visible
			label2.Visible = imageComboBoxEdit2.Visible
			RaiseValidateCondition()
		End Sub

		Private Sub imageComboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles imageComboBoxEdit2.SelectedIndexChanged
			label2.Enabled = Not imageComboBoxEdit2.EditValue.Equals(0)
			spinEdit2.Visible = label2.Enabled
			RaiseValidateCondition()
		End Sub

		Private Sub spinEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged, spinEdit2.EditValueChanged
			RaiseValidateCondition()
		End Sub

		Protected Sub RaiseValidateCondition()
			RaiseEvent ValidateCondition(Me, New EventArgs())
		End Sub

		Public Property Caption() As String
			Get
				Return fCaption
			End Get
			Set(ByVal value As String)
				fCaption = value
				label1.Text = fCaption
			End Set
		End Property

		Public Function IsTrueCondition(ByVal val As Object) As Object()
			Dim dValue As Decimal = Convert.ToDecimal(val)
			Dim value1 As Decimal = Convert.ToDecimal(spinEdit1.EditValue)
			Dim value2 As Decimal = Convert.ToDecimal(spinEdit2.EditValue)
			Dim condition1 As Integer = imageComboBoxEdit1.SelectedIndex
			Dim condition2 As Integer = imageComboBoxEdit2.SelectedIndex
			Dim greater As Boolean = False
			Dim reply As String = ""
			If condition1 = 2 Then
				reply = "The value must be less than " & value1.ToString()
				Return New Object() { (dValue < value1), reply }
			End If
			If condition1 = 3 Then
				reply = "The value must be less than or equal to " & value1.ToString()
				Return New Object() { (dValue <= value1), reply }
			End If
			If condition1 = 4 Then
				reply = "The value must not equal " & value1.ToString()
				Return New Object() { (dValue <> value1), reply }
			End If
			If condition1 = 0 Then
				reply = "The value must be greater than " & value1.ToString()
				greater = dValue > value1
			End If
			If condition1 = 1 Then
				reply = "The value must be greater than or equal to " & value1.ToString()
				greater = dValue >= value1
			End If
			If condition2 = 0 Then
				Return New Object() { greater, reply }
			End If
			If greater Then
				If condition2 = 1 Then
					reply = "The value must be less than " & value2.ToString()
					Return New Object() { (greater AndAlso dValue < value2), reply }
				End If
				If condition2 = 2 Then
					reply = "The value must be less than or equal to " & value2.ToString()
					Return New Object() { (greater AndAlso dValue <= value2), reply }
				End If
			End If
			Return New Object() { False, reply }
		End Function
	End Class
End Namespace
