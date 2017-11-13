Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class TopValuesDemo
	Inherits Page

	Private Const MaxTopValueCount As Integer = 20

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			SetShowTopValuesDropDownList()
		End If
		SetSortBySummary()
	End Sub
	Private Sub SetShowTopValuesDropDownList()
		For i As Integer = 1 To MaxTopValueCount
			ddlTopCount.Items.Add(i.ToString())
		Next i
		ddlTopCount.SelectedIndex = MaxTopValueCount \ 5
	End Sub
	Private Sub SetSortBySummary()
		Dim fieldOrderAmount As PivotGridField = pivotGrid.Fields("fieldOrderAmount")
		For Each field As PivotGridField In pivotGrid.Fields
			If field IsNot fieldOrderAmount Then
				field.Visible = False
			End If
		Next field
		Dim selField As PivotGridField = pivotGrid.Fields(ddlField.SelectedItem.Text)
		If selField Is Nothing Then
			Return
		End If
		selField.Visible = True
		selField.TopValueCount = Integer.Parse(ddlTopCount.SelectedItem.Text)
		selField.TopValueShowOthers = cbShowOthers.Checked
	End Sub
End Class
