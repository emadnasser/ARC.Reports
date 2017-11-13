Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports System.Collections.Generic
Imports DevExpress.Utils

Namespace DevExpress.XtraPivotGrid.Demos.Modules
	Partial Public Class SummaryVariation
		Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
		Public Sub New()
			' This call is required by the Windows Form Designer.
			CreateWaitDialog()
			InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\SummaryVariation.vb"
            TutorialInfo.WhatsThisXMLFile = "SummaryVariation.xml"
		End Sub

		Private Enum SummaryDisplayTypeGroup
			Variation = 0
			Percentage = 1
			Rank = 2
			Index = 3
		End Enum

		Private ReadOnly Property SelectedGroup() As SummaryDisplayTypeGroup
			Get
				Return CType(rgSummaryDisplayTypeGroup.SelectedIndex, SummaryDisplayTypeGroup)
			End Get
		End Property

		Private privateSourceDataField As PivotGridField
		Private Property SourceDataField() As PivotGridField
			Get
				Return privateSourceDataField
			End Get
			Set(ByVal value As PivotGridField)
				privateSourceDataField = value
			End Set
		End Property
		Private privateSummaryDisplayTypeDataField As PivotGridField
		Private Property SummaryDisplayTypeDataField() As PivotGridField
			Get
				Return privateSummaryDisplayTypeDataField
			End Get
			Set(ByVal value As PivotGridField)
				privateSummaryDisplayTypeDataField = value
			End Set
		End Property

		Private Sub InitSummaryDisplayTypeGroupRadioGroup()
			Dim typeGroupType As Type = GetType(SummaryDisplayTypeGroup)
			For Each typeGroup As SummaryDisplayTypeGroup In System.Enum.GetValues(typeGroupType)
				rgSummaryDisplayTypeGroup.Properties.Items.Add(New RadioGroupItem(typeGroup, System.Enum.GetName(typeGroupType, typeGroup)))
			Next typeGroup
			rgSummaryDisplayTypeGroup.SelectedIndex = 0
		End Sub

		Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As PivotGridControl
			Get
				Return pivotGridControl1
			End Get
		End Property

		Private Sub SummaryVariation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.ValueImages = CategoryImageList
			InitSummaryDisplayTypeGroupRadioGroup()
		End Sub
		'<rgSummaryDisplayTypeGroup>
		Private Sub ConfigureSummaryDisplayTypeComboBox(ByVal typeGroup As SummaryDisplayTypeGroup)
			Dim types As New List(Of PivotSummaryDisplayType)()
			Select Case typeGroup
				Case SummaryDisplayTypeGroup.Variation
					types.Add(PivotSummaryDisplayType.AbsoluteVariation)
					types.Add(PivotSummaryDisplayType.PercentVariation)
				Case SummaryDisplayTypeGroup.Percentage
					types.Add(PivotSummaryDisplayType.PercentOfColumn)
					types.Add(PivotSummaryDisplayType.PercentOfRow)
					types.Add(PivotSummaryDisplayType.PercentOfColumnGrandTotal)
					types.Add(PivotSummaryDisplayType.PercentOfRowGrandTotal)
					types.Add(PivotSummaryDisplayType.PercentOfGrandTotal)
				Case SummaryDisplayTypeGroup.Rank
					types.Add(PivotSummaryDisplayType.RankInColumnLargestToSmallest)
					types.Add(PivotSummaryDisplayType.RankInColumnSmallestToLargest)
					types.Add(PivotSummaryDisplayType.RankInRowLargestToSmallest)
					types.Add(PivotSummaryDisplayType.RankInRowSmallestToLargest)
				Case SummaryDisplayTypeGroup.Index
					types.Add(PivotSummaryDisplayType.Index)
			End Select
			icbSummaryDisplayType.Properties.Items.Clear()
			For Each type As PivotSummaryDisplayType In types
				icbSummaryDisplayType.Properties.Items.Add(New ImageComboBoxItem(type))
			Next type
			icbSummaryDisplayType.SelectedIndex = 0
		End Sub
		'<skip>
		Private Sub ConfigurePivotGridLayout(ByVal typeGroup As SummaryDisplayTypeGroup)
			pivotGridControl1.BeginUpdate()
			Select Case typeGroup
				Case SummaryDisplayTypeGroup.Variation
						pivotGridControl1.DataSource = GetNWindData("SalesPerson")
						pivotGridControl1.Fields.Clear()
						Dim fieldYear As PivotGridField = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea)
						fieldYear.GroupInterval = PivotGroupInterval.DateYear
						fieldYear.Caption = "Year"
						Dim fieldQuarter As PivotGridField = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea)
						fieldQuarter.GroupInterval = PivotGroupInterval.DateQuarter
						fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
						fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
						fieldQuarter.Caption = "Quarter"
						pivotGridControl1.Fields.Add("Sales Person", PivotArea.RowArea)
						SourceDataField = pivotGridControl1.Fields.Add("OrderID", PivotArea.DataArea)
						SourceDataField.SummaryType = PivotSummaryType.Count
						SourceDataField.Caption = "Order Count"
						SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea)
						SummaryDisplayTypeDataField.SummaryType = SourceDataField.SummaryType
				Case SummaryDisplayTypeGroup.Percentage
						pivotGridControl1.DataSource = GetNWindData("ProductReports")
						pivotGridControl1.Fields.Clear()
						Dim fieldYear As PivotGridField = pivotGridControl1.Fields.Add("ShippedDate", PivotArea.ColumnArea)
						fieldYear.GroupInterval = PivotGroupInterval.DateYear
						fieldYear.Caption = "Year"
						Dim fieldMonth As PivotGridField = pivotGridControl1.Fields.Add("ShippedDate", PivotArea.ColumnArea)
						fieldMonth.GroupInterval = PivotGroupInterval.DateMonth
						fieldMonth.Caption = "Month"
						pivotGridControl1.Fields.Add("CategoryName", PivotArea.RowArea)
						pivotGridControl1.Fields.Add("ProductName", PivotArea.RowArea)
						SourceDataField = pivotGridControl1.Fields.Add("ProductSales", PivotArea.DataArea)
						SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea)
				Case SummaryDisplayTypeGroup.Rank
						pivotGridControl1.DataSource = GetNWindData("SalesPerson")
						pivotGridControl1.Fields.Clear()
						Dim fieldYear As PivotGridField = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea)
						fieldYear.GroupInterval = PivotGroupInterval.DateYear
						fieldYear.Caption = "Year"
						Dim fieldQuarter As PivotGridField = pivotGridControl1.Fields.Add("OrderDate", PivotArea.ColumnArea)
						fieldQuarter.GroupInterval = PivotGroupInterval.DateQuarter
						fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
						fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
						fieldQuarter.Caption = "Quarter"
						pivotGridControl1.Fields.Add("Country", PivotArea.RowArea)
						pivotGridControl1.Fields.Add("Sales Person", PivotArea.RowArea)
						SourceDataField = pivotGridControl1.Fields.Add("Extended Price", PivotArea.DataArea)
						SourceDataField.Caption = "Sales"
						SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea)
				Case SummaryDisplayTypeGroup.Index
						pivotGridControl1.DataSource = GetNWindData("SalesPerson")
						pivotGridControl1.Fields.Clear()
						Dim fieldYear As PivotGridField = pivotGridControl1.Fields.Add("Country", PivotArea.ColumnArea)
						pivotGridControl1.Fields.Add("CategoryName", PivotArea.RowArea)
						SourceDataField = pivotGridControl1.Fields.Add("Extended Price", PivotArea.DataArea)
						SourceDataField.Caption = "Sales"
						SummaryDisplayTypeDataField = pivotGridControl1.Fields.Add(SourceDataField.FieldName, PivotArea.DataArea)
			End Select

			pivotGridControl1.EndUpdate()
		End Sub
		'</skip>
		Private Sub rgSummaryDisplayTypeGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgSummaryDisplayTypeGroup.SelectedIndexChanged
			ConfigurePivotGridLayout(SelectedGroup)
			Dim isVariation As Boolean = (SelectedGroup = SummaryDisplayTypeGroup.Variation)
			checkAllowCrossGroupVariation.Visible = isVariation
			checkHideEmptyVariationItems.Visible = isVariation
			If SourceDataField IsNot Nothing Then
				checkShowOriginalDataField.Checked = SourceDataField.Visible
			End If
			ConfigureSummaryDisplayTypeComboBox(SelectedGroup)
		End Sub
		'</rgSummaryDisplayTypeGroup>
		Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
			If e.Field IsNot Nothing AndAlso e.Field.FieldName = "CategoryName" AndAlso Comparer.Equals(e.ValueType, PivotGridValueType.Value) Then
				e.ImageIndex = GetCategoryIndexByName(e.Value)
			End If
		End Sub

		'<icbSummaryDisplayType>
		Private Sub icbSummaryDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSummaryDisplayType.SelectedIndexChanged
			If SummaryDisplayTypeDataField Is Nothing Then
				Return
			End If
			SummaryDisplayTypeDataField.SummaryDisplayType = CType(icbSummaryDisplayType.EditValue, PivotSummaryDisplayType)
			SummaryDisplayTypeDataField.Caption = String.Format("{0}", SummaryDisplayTypeDataField.SummaryDisplayType)
		End Sub
		'</icbSummaryDisplayType>
		Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles pivotGridControl1.CustomDrawCell
			If Comparer.ReferenceEquals(e.DataField, SummaryDisplayTypeDataField) Then
				If e.Value Is Nothing Then
					Return
				End If
				Dim isBlue As DefaultBoolean = DefaultBoolean.Default
				Select Case SelectedGroup
					Case SummaryDisplayTypeGroup.Variation
						isBlue = If(Convert.ToDecimal(e.Value) >= 0, DefaultBoolean.True, DefaultBoolean.False)
					Case SummaryDisplayTypeGroup.Percentage, SummaryDisplayTypeGroup.Rank
						If SourceDataField IsNot Nothing AndAlso SourceDataField.Visible Then
							isBlue = DefaultBoolean.True
						End If
					Case SummaryDisplayTypeGroup.Index
						If e.RowValueType <> PivotGridValueType.GrandTotal AndAlso e.ColumnValueType <> PivotGridValueType.GrandTotal Then
							isBlue = If(Convert.ToDecimal(e.Value) < 1, DefaultBoolean.True, DefaultBoolean.False)
						End If
				End Select
				If Comparer.Equals(isBlue, DefaultBoolean.Default) Then
					Return
				End If
				e.Appearance.ForeColor = If(Comparer.Equals(isBlue, DefaultBoolean.True), Blue, Red)
			End If
		End Sub
		'<checkAllowCrossGroupVariation>
		Private Sub checkAllowCrossGroupVariation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkAllowCrossGroupVariation.CheckedChanged
			pivotGridControl1.OptionsData.AllowCrossGroupVariation = checkAllowCrossGroupVariation.Checked
		End Sub
		'</checkAllowCrossGroupVariation>
		'<checkHideEmptyVariationItems>
		Private Sub checkHideEmptyVariationItems_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkHideEmptyVariationItems.CheckedChanged
			If SummaryDisplayTypeDataField IsNot Nothing Then
				SummaryDisplayTypeDataField.Options.HideEmptyVariationItems = checkHideEmptyVariationItems.Checked
			End If
		End Sub
		'</checkHideEmptyVariationItems>
		'<checkShowOriginalDataField>
		Private Sub checkShowOriginalDataField_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkShowOriginalDataField.CheckedChanged
			If SourceDataField IsNot Nothing Then
				SourceDataField.Visible = checkShowOriginalDataField.Checked
			End If
		End Sub
		'</checkShowOriginalDataField>
	End Class
End Namespace

