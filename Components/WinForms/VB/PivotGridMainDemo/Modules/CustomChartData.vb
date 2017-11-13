Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class CustomChartData
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Private Enum RowFieldValueExportRule
			ProductName = 0
			CategoryAndProduct = 1
			CategoryEncoded = 2
		End Enum

		Private Shared categories() As String = { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" }

		Private rowFieldValueExportRule_Renamed As RowFieldValueExportRule

		Private Property RowExportRule() As RowFieldValueExportRule
			Get
				Return rowFieldValueExportRule_Renamed
			End Get
			Set(ByVal value As RowFieldValueExportRule)
				rowFieldValueExportRule_Renamed = value
			End Set
		End Property
		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl
			End Get
		End Property

		Public Sub New()
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\CustomChartData.vb"
            TutorialInfo.WhatsThisXMLFile = "CustomChartData.xml"
            chartControl.CrosshairOptions.ShowArgumentLine = False
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			comboChartType.Properties.Items.AddRange(New ViewType() { ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar, ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Spline, ViewType.Area, ViewType.SplineArea, ViewType.StackedArea, ViewType.StackedSplineArea, ViewType.FullStackedArea, ViewType.FullStackedSplineArea })
			comboChartType.SelectedItem = ViewType.Line
			RowExportRule = RowFieldValueExportRule.ProductName
			cbRowFieldValuesExportRule.Properties.Items.AddRange(New String() { "ProductName", "Category/ProductName", "Encoded Product Category" })
			cbRowFieldValuesExportRule.SelectedIndex = 0
			pivotGridControl.DataSource = GetNWindData("SalesPerson")
			CollapseValues()
			SetSelection()
			chartControl.DataSource = pivotGridControl
		End Sub
		Private Sub CollapseValues()
			fieldCategoryName.CollapseAll()
			fieldCategoryName.ExpandValue("Condiments")
			fieldYear.CollapseAll()
			fieldYear.ExpandValue(1994)
			fieldQuarter.CollapseAll()
			fieldQuarter.ExpandValue(3)
		End Sub
		Private Sub SetSelection()
			pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() { "Condiments", "Aniseed Syrup" })
			pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() { "Condiments", "Chef Anton's Cajun Seasoning" })
			pivotGridControl.Cells.SetSelectionByFieldValues(False, New Object() { "Condiments", "Chef Anton's Gumbo Mix" })
		End Sub
		'<comboChartType>
		Private Sub comboBoxEdit2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboChartType.SelectedIndexChanged
			chartControl.SeriesTemplate.ChangeView(CType(comboChartType.SelectedItem, ViewType))
		End Sub
		'</comboChartType>
		'<checkShowPointLabels>
		Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkShowPointLabels.CheckedChanged
			chartControl.SeriesTemplate.LabelsVisibility = If(checkShowPointLabels.Checked, DevExpress.Utils.DefaultBoolean.True, DefaultBoolean.False)
		End Sub
		'</checkShowPointLabels>

		'<seCellZeroValueThreshold>
		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl.CustomChartDataSourceData
			If e.ItemType = PivotChartItemType.CellItem Then
				If e.Value Is DBNull.Value OrElse CDec(e.Value) < Convert.ToDecimal(seCellZeroValueThreshold.Value) Then
					e.Value = 0
				End If
			End If
			'</seCellZeroValueThreshold>
			If e.ItemType = PivotChartItemType.RowItem Then
				Dim isCategoryNameField As Boolean = Object.Equals(e.FieldValueInfo.Field, fieldCategoryName)
				Select Case RowExportRule
					Case RowFieldValueExportRule.ProductName
						If isCategoryNameField Then
							e.Value = e.FieldValueInfo.Value.ToString() & " Category"
						Else
							e.Value = e.FieldValueInfo.Value
						End If
					Case RowFieldValueExportRule.CategoryAndProduct
						If isCategoryNameField Then
							e.Value = e.FieldValueInfo.Value.ToString() & "/"c & "Total"
						Else
							e.Value = e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString() & "/"c + e.FieldValueInfo.Value.ToString()
						End If
					Case RowFieldValueExportRule.CategoryEncoded
						Dim categoryName As String = If(isCategoryNameField, e.FieldValueInfo.Value.ToString(), e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString())
						e.Value = EncodeCategoryName(categoryName)
				End Select
			End If
		End Sub
		'<cbRowFieldValuesExportRule>
		Private Sub cbRowFieldValuesExportRule_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRowFieldValuesExportRule.SelectedIndexChanged
			RowExportRule = (CType(cbRowFieldValuesExportRule.SelectedIndex, RowFieldValueExportRule))
			If RowExportRule = RowFieldValueExportRule.CategoryEncoded Then
				pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(Char)
			Else
				pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(String)
			End If
			pivotGridControl.RefreshData()
		End Sub
		'</cbRowFieldValuesExportRule>

		'<seCellZeroValueThreshold>
		Private Sub seCellZeroValueThreshold_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seCellZeroValueThreshold.EditValueChanged
			pivotGridControl.RefreshData()
		End Sub
		'</seCellZeroValueThreshold>
		Private Function EncodeCategoryName(ByVal categoryName As String) As Char
			For i As Integer = 0 To categories.Length - 1
				If categories(i) = categoryName Then
					Return Convert.ToChar(Convert.ToInt32("A"c) + i)
				End If
			Next i
			Return "Z"c
		End Function
	End Class
End Namespace
