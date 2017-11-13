Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid.Customization

Partial Public Class FieldsCustomizationDemo
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.OptionsCustomization.AllowDrag = allowDrag.Checked
		ASPxPivotGrid1.OptionsCustomization.AllowDragInCustomizationForm = allowDragCF.Checked
	End Sub

	Protected Sub pivotGrid_CustomUnboundFieldData(ByVal sender As Object, ByVal e As CustomFieldDataEventArgs)
		If Object.ReferenceEquals(e.Field, ASPxPivotGrid1.Fields("OrderAmount")) Then
			e.Value = Convert.ToDouble(e.GetListSourceColumnValue("UnitPrice")) * Convert.ToDouble(e.GetListSourceColumnValue("Quantity"))
		End If
	End Sub
	Protected Sub FieldListStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		If FieldListStyle.SelectedItem.Value.ToString() = "Simple" Then
			ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Simple
		Else
			ASPxPivotGrid1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007
		End If
	End Sub

	Protected Sub FieldListLayout_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.OptionsCustomization.CustomizationFormLayout = CType(System.Enum.Parse(GetType(CustomizationFormLayout), FieldListLayout.SelectedItem.Value.ToString()), CustomizationFormLayout)
	End Sub
End Class
