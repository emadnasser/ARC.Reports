Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.Data.PivotGrid

Partial Public Class OLAP_CustomTotals
	Inherits Page
	Private Const CategoriesFieldName As String = "[Categories].[Category Name].[Category Name]"
	Private Const ProductsFieldName As String = "[Products].[Products].[Products]"

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim [error] As String = OLAPConnector.TryConnect(pivotGrid)
		If (Not String.IsNullOrEmpty([error])) Then
			Dim errorPanel As Control = OLAPConnector.CreateErrorPanel([error])
			pivotGrid.Parent.Controls.AddAt(0, errorPanel)
		End If
		SetCustomTotals(pivotGrid.Fields(CategoriesFieldName).CustomTotals)
	End Sub
	Private Sub SetCustomTotals(ByVal totals As DevExpress.Web.ASPxPivotGrid.PivotGridCustomTotalCollection)
		totals.Clear()
		If average.Checked = True Then
			totals.Add(PivotSummaryType.Average)
		End If
		If count.Checked = True Then
			totals.Add(PivotSummaryType.Count)
		End If
		If max.Checked = True Then
			totals.Add(PivotSummaryType.Max)
		End If
		If min.Checked = True Then
			totals.Add(PivotSummaryType.Min)
		End If
		If stdev.Checked = True Then
			totals.Add(PivotSummaryType.StdDev)
		End If
		If stdevp.Checked = True Then
			totals.Add(PivotSummaryType.StdDevp)
		End If
		If sum.Checked = True Then
			totals.Add(PivotSummaryType.Sum)
		End If
		If var.Checked = True Then
			totals.Add(PivotSummaryType.Var)
		End If
		If varp.Checked = True Then
			totals.Add(PivotSummaryType.Varp)
		End If
	End Sub
	Private Sub SetProductsFilter()
		Dim field As DevExpress.Web.ASPxPivotGrid.PivotGridField = pivotGrid.Fields(ProductsFieldName)
		Dim values() As Object = field.GetUniqueValues()
		Dim includedValues As New List(Of Object)(values.Length / 3)
		For i As Integer = 0 To values.Length - 1
			If i Mod 3 = 0 Then
				includedValues.Add(values(i))
			End If
		Next i
		field.FilterValues.ValuesIncluded = includedValues.ToArray()
	End Sub
	Protected Sub pivotGrid_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso pivotGrid.IsDataBound Then
			SetProductsFilter()
			pivotGrid.Fields(CategoriesFieldName).ExpandValue("Beverages")
		End If
	End Sub
End Class
