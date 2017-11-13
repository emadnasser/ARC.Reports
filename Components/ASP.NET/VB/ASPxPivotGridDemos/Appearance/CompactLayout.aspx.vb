Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils

Partial Public Class Appearance_CompactLayout
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) AndAlso (Not IsCallback) Then
			ASPxPivotGrid1.CollapseAll()
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK" })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments" })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Chef Anton's Cajun Seasoning" })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King" })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1994})
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Chef Anton's Cajun Seasoning", "Robert King", 1996 })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Genen Shouyu" })
			ASPxPivotGrid1.ExpandValue(False, New Object() { "UK", "Condiments", "Genen Shouyu", "Michael Suyama" })
		End If
		If LayoutMode.SelectedIndex = 0 Then
			SetCompactLayout()
		Else
			SetFullLayout()
		End If
	End Sub

	Private Sub SetCompactLayout()
		ASPxPivotGrid1.Width = Unit.Pixel(500)
		ASPxPivotGrid1.OptionsView.ShowColumnHeaders = False
		ASPxPivotGrid1.OptionsView.ShowRowHeaders = False
		ASPxPivotGrid1.OptionsView.ShowDataHeaders = False
		ASPxPivotGrid1.OptionsView.ShowFilterHeaders = False
		ASPxPivotGrid1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree
		ASPxPivotGrid1.Styles.FieldValueStyle.Wrap = DefaultBoolean.False
		ASPxPivotCustomizationControl1.Width = Unit.Pixel(300)
		ASPxPivotCustomizationControl1.ASPxPivotGridID = "ASPxPivotGrid1"
		ASPxPivotCustomizationControl1.Visible = True
	End Sub

	Private Sub SetFullLayout()
		ASPxPivotGrid1.Width = Unit.Pixel(800)
		ASPxPivotGrid1.OptionsView.ShowColumnHeaders = True
		ASPxPivotGrid1.OptionsView.ShowRowHeaders = True
		ASPxPivotGrid1.OptionsView.ShowDataHeaders = True
		ASPxPivotGrid1.OptionsView.ShowFilterHeaders = True
		ASPxPivotGrid1.Styles.FieldValueStyle.Wrap = DefaultBoolean.Default
		ASPxPivotGrid1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far
		ASPxPivotCustomizationControl1.ASPxPivotGridID = "NoControl"
		ASPxPivotCustomizationControl1.Visible = False
	End Sub
End Class
