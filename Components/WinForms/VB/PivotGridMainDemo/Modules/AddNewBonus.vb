Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.Utils
Imports System.IO

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class AddNewBonus
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private pivotGrid_Renamed As PivotGridControl
		Public Property PivotGrid() As PivotGridControl
			Get
				Return pivotGrid_Renamed
			End Get
			Set(ByVal value As PivotGridControl)
				pivotGrid_Renamed = value
			End Set
		End Property

		Private Sub teBonusName_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles teBonusName.EditValueChanging
			If String.IsNullOrEmpty(teBonusName.Text) Then
				buttonOK.Enabled = False
				beExpression.Enabled = False
			Else
				buttonOK.Enabled = True
				beExpression.Enabled = True
			End If
		End Sub

		Private Function GetNewInvisibleBonusField() As PivotGridField
			Dim newBonusField As New PivotGridField(teBonusName.Text, PivotArea.DataArea)
			newBonusField.Name = "field_" & teBonusName.Text
			newBonusField.Visible = False
			newBonusField.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			newBonusField.UnboundExpression = beExpression.Text
			newBonusField.Options.ShowUnboundExpressionMenu = True
			Return newBonusField
		End Function

		Private Sub beExpression_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beExpression.ButtonClick
			Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
			PivotGrid.Fields.Add(newBonus)
            PivotGrid.ShowUnboundExpressionEditor(newBonus)
			beExpression.Text = newBonus.UnboundExpression
			PivotGrid.Fields.Remove(newBonus)
		End Sub

		Private Sub buttonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonOK.Click
			Dim newBonus As PivotGridField = GetNewInvisibleBonusField()
			newBonus.Visible = True
            newBonus.AreaIndex = PivotGrid.GetFieldsByArea(PivotArea.DataArea).Count
            PivotGrid.Fields.Add(newBonus)
			teBonusName.Text = String.Empty
			buttonOK.Enabled = False
			beExpression.Text = String.Empty
			beExpression.Enabled = False
			PivotGrid.BestFit()
			DialogResult = System.Windows.Forms.DialogResult.OK
		End Sub
	End Class
End Namespace

